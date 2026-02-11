using Stride.Shaders.Core;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;

public struct DirectiveExpressionParser : IParser<Expression>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
    {
        if (Or(ref scanner, result, out parsed))
            return true;
        else
        {
            if (orError is not null)
                result.Errors.Add(orError.Value);
            return false;
        }
    }

    public static bool Expression(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        => new DirectiveExpressionParser().Match(ref scanner, result, out parsed, in orError);
    public static bool Add(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        => new DirectiveAdditionParser().Match(ref scanner, result, out parsed, in orError);
    public static bool Mul(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        => new DirectiveMultiplicationParser().Match(ref scanner, result, out parsed, in orError);
    public static bool Shift(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        => new DirectiveBitwiseShiftParser().Match(ref scanner, result, out parsed, in orError);
    public static bool Relation(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        => new DirectiveRelationalParser().Match(ref scanner, result, out parsed, in orError);
    public static bool Equality(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        => new DirectiveEqualityParser().Match(ref scanner, result, out parsed, in orError);
    public static bool BAnd(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        => new DirectiveBitwiseAndParser().Match(ref scanner, result, out parsed, in orError);
    public static bool BOr(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        => new DirectiveBitwiseOrParser().Match(ref scanner, result, out parsed, in orError);
    public static bool XOr(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        => new DirectiveBitwiseXOrParser().Match(ref scanner, result, out parsed, in orError);
    public static bool And(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        => new DirectiveAndParser().Match(ref scanner, result, out parsed, in orError);
    public static bool Or(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        => new DirectiveOrParser().Match(ref scanner, result, out parsed, in orError);
}


public record struct DirectiveTernaryParser : IParser<Expression>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (DirectiveExpressionParser.Or(ref scanner, result, out parsed))
        {
            var pos2 = scanner.Position;
            scanner.MatchWhiteSpace(advance: true);
            if (
                scanner.Match('?', advance: true)
                && scanner.MatchWhiteSpace(advance: true)
                && DirectiveExpressionParser.Expression(ref scanner, result, out var left, new(SDSLErrorMessages.SDSL0015, scanner[scanner.Position], scanner.Memory))
                && scanner.MatchWhiteSpace(advance: true)
                && scanner.Match(':', advance: true)
                && scanner.MatchWhiteSpace(advance: true)
                && DirectiveExpressionParser.Expression(ref scanner, result, out var right, new(SDSLErrorMessages.SDSL0015, scanner[scanner.Position], scanner.Memory))
            )
            {
                parsed = new TernaryExpression(parsed, left, right, scanner[position..scanner.Position]);
                return true;
            }
            else
            {
                scanner.Backtrack(pos2);
                return true;
            }
        }
        else
        {
            if (orError is not null)
                result.Errors.Add(orError.Value);
            scanner.Backtrack(position);
            return false;
        }
    }
}

public record struct DirectiveOrParser() : IParser<Expression>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        parsed = null!;
        scanner.MatchWhiteSpace(advance: true);
        if (DirectiveExpressionParser.And(ref scanner, result, out var left))
        {
            scanner.MatchWhiteSpace(advance: true);
            if (scanner.Match("||"))
            {
                var op = scanner.Slice(scanner.Position, 2).ToOperator();
                scanner.Advance(2);
                scanner.MatchWhiteSpace(advance: true);
                if (DirectiveExpressionParser.Or(ref scanner, result, out var shift))
                {
                    parsed = new BinaryExpression(left, op, shift, scanner[position..scanner.Position]);
                    return true;
                }
                else if (DirectiveExpressionParser.And(ref scanner, result, out var add))
                {
                    parsed = new BinaryExpression(left, op, add, scanner[position..scanner.Position]);
                    return true;
                }
                else
                {
                    scanner.Backtrack(position);
                    return false;
                }

            }
            else
            {
                parsed = left;
                return true;
            }
        }
        else
        {
            if (orError is not null)
                result.Errors.Add(orError.Value);
            scanner.Backtrack(position);
            return false;
        }
    }
}

public record struct DirectiveAndParser() : IParser<Expression>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        parsed = null!;
        scanner.MatchWhiteSpace(advance: true);
        if (DirectiveExpressionParser.BOr(ref scanner, result, out var left))
        {
            scanner.MatchWhiteSpace(advance: true);
            if (scanner.Match("&&"))
            {
                var op = scanner.Slice(scanner.Position, 2).ToOperator();
                scanner.Advance(2);
                scanner.MatchWhiteSpace(advance: true);
                if (DirectiveExpressionParser.BAnd(ref scanner, result, out var shift))
                {
                    parsed = new BinaryExpression(left, op, shift, scanner[position..scanner.Position]);
                    return true;
                }
                else if (DirectiveExpressionParser.BOr(ref scanner, result, out var add))
                {
                    parsed = new BinaryExpression(left, op, add, scanner[position..scanner.Position]);
                    return true;
                }
                else
                {
                    scanner.Backtrack(position);
                    return false;
                }

            }
            else
            {
                parsed = left;
                return true;
            }
        }
        else
        {
            if (orError is not null)
                result.Errors.Add(orError.Value);
            scanner.Backtrack(position);
            return false;
        }
    }
}



public record struct DirectiveBitwiseOrParser() : IParser<Expression>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        
        parsed = null!;
        scanner.MatchWhiteSpace(advance: true);
        if (DirectiveExpressionParser.XOr(ref scanner, result, out var left))
        {
            scanner.MatchWhiteSpace(advance: true);
            if (!scanner.Match("||") && scanner.Match('|'))
            {
                var op = ((char)scanner.Peek()).ToOperator();
                scanner.Advance(1);
                scanner.MatchWhiteSpace(advance: true);
                if (DirectiveExpressionParser.BOr(ref scanner, result, out var shift))
                {
                    parsed = new BinaryExpression(left, op, shift, scanner[position..scanner.Position]);
                    return true;
                }
                else if (DirectiveExpressionParser.XOr(ref scanner, result, out var add))
                {
                    parsed = new BinaryExpression(left, op, add, scanner[position..scanner.Position]);
                    return true;
                }
                else
                {
                    scanner.Backtrack(position);
                    return false;
                }

            }
            else
            {
                parsed = left;
                return true;
            }
        }
        else
        {
            if (orError is not null)
                result.Errors.Add(orError.Value);
            scanner.Backtrack(position);
            return false;
        }
    }
}
public record struct DirectiveBitwiseXOrParser() : IParser<Expression>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        
        parsed = null!;
        scanner.MatchWhiteSpace(advance: true);
        if (DirectiveExpressionParser.BAnd(ref scanner, result, out var left))
        {
            scanner.MatchWhiteSpace(advance: true);
            if (scanner.Match('^'))
            {
                var op = ((char)scanner.Peek()).ToOperator();
                scanner.Advance(1);
                scanner.MatchWhiteSpace(advance: true);
                if (DirectiveExpressionParser.XOr(ref scanner, result, out var shift))
                {
                    parsed = new BinaryExpression(left, op, shift, scanner[position..scanner.Position]);
                    return true;
                }
                else if (DirectiveExpressionParser.BAnd(ref scanner, result, out var add))
                {
                    parsed = new BinaryExpression(left, op, add, scanner[position..scanner.Position]);
                    return true;
                }
                else
                {
                    scanner.Backtrack(position);
                    return false;
                }

            }
            else
            {
                parsed = left;
                return true;
            }
        }
        else
        {
            if (orError is not null)
                result.Errors.Add(orError.Value);
            scanner.Backtrack(position);
            return false;
        }
    }
}
public record struct DirectiveBitwiseAndParser() : IParser<Expression>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        
        parsed = null!;
        scanner.MatchWhiteSpace(advance: true);
        if (DirectiveExpressionParser.Equality(ref scanner, result, out var left))
        {
            scanner.MatchWhiteSpace(advance: true);
            if (!scanner.Match("&&") && scanner.Match('&'))
            {
                var op = ((char)scanner.Peek()).ToOperator();
                scanner.Advance(1);
                scanner.MatchWhiteSpace(advance: true);
                if (DirectiveExpressionParser.BAnd(ref scanner, result, out var shift))
                {
                    parsed = new BinaryExpression(left, op, shift, scanner[position..scanner.Position]);
                    return true;
                }
                else if (DirectiveExpressionParser.Equality(ref scanner, result, out var add))
                {
                    parsed = new BinaryExpression(left, op, add, scanner[position..scanner.Position]);
                    return true;
                }
                else
                {
                    scanner.Backtrack(position);
                    return false;
                }

            }
            else
            {
                parsed = left;
                return true;
            }
        }
        else
        {
            if (orError is not null)
                result.Errors.Add(orError.Value);
            scanner.Backtrack(position);
            return false;
        }
    }
}



public record struct DirectiveEqualityParser() : IParser<Expression>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        
        parsed = null!;
        scanner.MatchWhiteSpace(advance: true);
        if (DirectiveExpressionParser.Relation(ref scanner, result, out var left))
        {
            scanner.MatchWhiteSpace(advance: true);
            if (scanner.Match("==") || scanner.Match("!="))
            {
                var op = scanner.Slice(scanner.Position, 2).ToOperator();
                scanner.Advance(2);
                scanner.MatchWhiteSpace(advance: true);
                if (DirectiveExpressionParser.Equality(ref scanner, result, out var shift))
                {
                    parsed = new BinaryExpression(left, op, shift, scanner[position..scanner.Position]);
                    return true;
                }
                else if (DirectiveExpressionParser.Relation(ref scanner, result, out var add))
                {
                    parsed = new BinaryExpression(left, op, add, scanner[position..scanner.Position]);
                    return true;
                }
                else
                {
                    scanner.Backtrack(position);
                    return false;
                }

            }
            else
            {
                parsed = left;
                return true;
            }
        }
        else
        {
            if (orError is not null)
                result.Errors.Add(orError.Value);
            scanner.Backtrack(position);
            return false;
        }
    }
}

public record struct DirectiveRelationalParser() : IParser<Expression>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        
        parsed = null!;
        scanner.MatchWhiteSpace(advance: true);
        if (DirectiveExpressionParser.Shift(ref scanner, result, out var left))
        {
            scanner.MatchWhiteSpace(advance: true);
            if (
                !scanner.Match(">=") && scanner.Match(">")
                || !scanner.Match("<=") && scanner.Match("<"))
            {
                var op = ((char)scanner.Peek()).ToOperator();
                scanner.Advance(1);
                scanner.MatchWhiteSpace(advance: true);
                if (DirectiveExpressionParser.Relation(ref scanner, result, out var shift))
                {
                    parsed = new BinaryExpression(left, op, shift, scanner[position..scanner.Position]);
                    return true;
                }
                else if (DirectiveExpressionParser.Shift(ref scanner, result, out var add))
                {
                    parsed = new BinaryExpression(left, op, add, scanner[position..scanner.Position]);
                    return true;
                }
                else
                {
                    scanner.Backtrack(position);
                    return false;
                }

            }
            else if (scanner.Match(">=") || scanner.Match("<="))
            {
                var op = scanner.Slice(scanner.Position, 2).ToOperator();
                scanner.Advance(2);
                scanner.MatchWhiteSpace(advance: true);
                if (DirectiveExpressionParser.Relation(ref scanner, result, out var shift))
                {
                    parsed = new BinaryExpression(left, op, shift, scanner[position..scanner.Position]);
                    return true;
                }
                else if (DirectiveExpressionParser.Shift(ref scanner, result, out var add))
                {
                    parsed = new BinaryExpression(left, op, add, scanner[position..scanner.Position]);
                    return true;
                }
                else
                {
                    scanner.Backtrack(position);
                    return false;
                }

            }
            else
            {
                parsed = left;
                return true;
            }
        }
        else
        {
            if (orError is not null)
                result.Errors.Add(orError.Value);
            scanner.Backtrack(position);
            return false;
        }
    }
}

public record struct DirectiveBitwiseShiftParser() : IParser<Expression>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        
        parsed = null!;
        scanner.MatchWhiteSpace(advance: true);
        if (DirectiveExpressionParser.Add(ref scanner, result, out var left))
        {
            scanner.MatchWhiteSpace(advance: true);
            if (scanner.Match(">>") || scanner.Match("<<"))
            {
                var op = scanner.Slice(scanner.Position, 2).ToOperator();
                scanner.Advance(2);
                scanner.MatchWhiteSpace(advance: true);
                if (DirectiveExpressionParser.Shift(ref scanner, result, out var shift))
                {
                    parsed = new BinaryExpression(left, op, shift, scanner[position..scanner.Position]);
                    return true;
                }
                else if (DirectiveExpressionParser.Add(ref scanner, result, out var add))
                {
                    parsed = new BinaryExpression(left, op, add, scanner[position..scanner.Position]);
                    return true;
                }
                else
                {
                    scanner.Backtrack(position);
                    return false;
                }

            }
            else
            {
                parsed = left;
                return true;
            }
        }
        else
        {
            if (orError is not null)
                result.Errors.Add(orError.Value);
            scanner.Backtrack(position);
            return false;
        }
    }
}

public record struct DirectiveAdditionParser() : IParser<Expression>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        
        parsed = null!;
        scanner.MatchWhiteSpace(advance: true);
        if (DirectiveExpressionParser.Mul(ref scanner, result, out var left))
        {
            scanner.MatchWhiteSpace(advance: true);
            if (scanner.MatchSet("+-"))
            {
                var op = ((char)scanner.Peek()).ToOperator();
                scanner.Advance(1);
                scanner.MatchWhiteSpace(advance: true);
                if (DirectiveExpressionParser.Add(ref scanner, result, out var add))
                {
                    parsed = new BinaryExpression(left, op, add, scanner[position..scanner.Position]);
                    return true;
                }
                else if (DirectiveExpressionParser.Mul(ref scanner, result, out var mul))
                {
                    parsed = new BinaryExpression(left, op, mul, scanner[position..scanner.Position]);
                    return true;
                }
                else
                {
                    scanner.Backtrack(position);
                    return false;
                }

            }
            else
            {
                parsed = left;
                return true;
            }
        }
        else
        {
            if (orError is not null)
                result.Errors.Add(orError.Value);
            scanner.Backtrack(position);
            return false;
        }
    }
}

public record struct DirectiveMultiplicationParser() : IParser<Expression>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        parsed = null!;
        scanner.MatchWhiteSpace(advance: true);
        if (DirectiveUnaryParsers.Prefix(ref scanner, result, out var left))
        {
            scanner.MatchWhiteSpace(advance: true);
            if (scanner.MatchSet("*/%"))
            {
                var op = scanner.Peek().ToOperator();
                scanner.Advance(1);
                scanner.MatchWhiteSpace(advance: true);

                if (DirectiveExpressionParser.Mul(ref scanner, result, out var expression))
                {
                    parsed = new BinaryExpression(left, op, expression, scanner[position..scanner.Position]);
                    return true;
                }
                else if (DirectiveUnaryParsers.Prefix(ref scanner, result, out var right))
                {
                    parsed = new BinaryExpression(left, op, right, scanner[position..scanner.Position]);
                    return true;
                }
                scanner.Backtrack(position);
                return false;
            }
            else
            {
                parsed = left;
                return true;
            }
        }
        else
        {
            if (orError is not null)
                result.Errors.Add(orError.Value);
            scanner.Backtrack(position);
            return false;
        }
    }
}