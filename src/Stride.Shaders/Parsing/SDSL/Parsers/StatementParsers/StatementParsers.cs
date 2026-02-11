using Stride.Shaders.Core;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;


public record struct StatementParsers : IParser<Statement>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Statement parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (Empty(ref scanner, result, out parsed))
            return true;
        else if (Controls(ref scanner, result, out var cond))
        {
            parsed = cond;
            return true;
        }
        else if (Flow(ref scanner, result, out var flow))
        {
            parsed = flow;
            return true;
        }
        else if (Break(ref scanner, result, out parsed))
            return true;
        else if (Discard(ref scanner, result, out parsed))
            return true;
        else if (Return(ref scanner, result, out parsed))
            return true;
        else if (Continue(ref scanner, result, out parsed))
            return true;
        else if (Declare(ref scanner, result, out parsed))
            return true;
        else if (!scanner.Match('{') && Expression(ref scanner, result, out parsed))
            return true;
        else if (!scanner.Match('{') && Assignments(ref scanner, result, out parsed))
            return true;
        else if (Block(ref scanner, result, out parsed))
            return true;
        return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
    internal static bool Statement(ref Scanner scanner, ParseResult result, out Statement parsed, ParseError? orError = null)
        => new StatementParsers().Match(ref scanner, result, out parsed, orError);
    internal static bool Empty(ref Scanner scanner, ParseResult result, out Statement parsed, ParseError? orError = null)
        => new EmptyStatementParser().Match(ref scanner, result, out parsed, orError);
    internal static bool Block(ref Scanner scanner, ParseResult result, out Statement parsed, ParseError? orError = null)
        => new BlockStatementParser().Match(ref scanner, result, out parsed, orError);
    internal static bool Break(ref Scanner scanner, ParseResult result, out Statement parsed, ParseError? orError = null)
        => new BreakParser().Match(ref scanner, result, out parsed, orError);
    internal static bool Discard(ref Scanner scanner, ParseResult result, out Statement parsed, ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            scanner.FollowedBy("discard", withSpaces: true, advance: true)
            && scanner.FollowedBy(';', withSpaces: true, advance: true)
        )
        {
            parsed = new Discard(scanner[position..scanner.Position]);
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
    internal static bool Return(ref Scanner scanner, ParseResult result, out Statement parsed, ParseError? orError = null)
        => new ReturnStatementParser().Match(ref scanner, result, out parsed, orError);
    internal static bool Continue(ref Scanner scanner, ParseResult result, out Statement parsed, ParseError? orError = null)
    => new ContinueParser().Match(ref scanner, result, out parsed, orError);
    internal static bool Expression(ref Scanner scanner, ParseResult result, out Statement parsed, ParseError? orError = null)
        => new ExpressionStatementParser().Match(ref scanner, result, out parsed, orError);
    internal static bool Declare(ref Scanner scanner, ParseResult result, out Statement parsed, ParseError? orError = null)
        => new DeclareStatementParser().Match(ref scanner, result, out parsed, orError);
    internal static bool Assignments(ref Scanner scanner, ParseResult result, out Statement parsed, ParseError? orError = null)
        => new AssignmentsParser().Match(ref scanner, result, out parsed, orError);
    internal static bool DeclareOrAssign(ref Scanner scanner, ParseResult result, out Statement parsed, ParseError? orError = null)
    {
        var position = scanner.Position;
        if (Assignments(ref scanner, result, out parsed, orError))
            return true;
        else if (Declare(ref scanner, result, out parsed, orError))
            return true;
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
    internal static bool AssignOrExpression(ref Scanner scanner, ParseResult result, out Statement parsed, ParseError? orError = null)
    {
        var position = scanner.Position;
        if (Assignments(ref scanner, result, out parsed, orError))
            return true;
        else if (Expression(ref scanner, result, out parsed, orError))
            return true;
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
    internal static bool VarAssign(ref Scanner scanner, ParseResult result, out VariableAssign parsed, in ParseError? orError = null)
        => new VariableAssignParser().Match(ref scanner, result, out parsed, orError);
    internal static bool DeclaredVarAssign(ref Scanner scanner, ParseResult result, out DeclaredVariableAssign parsed, in ParseError? orError = null)
        => new DeclaredVariableAssignParser().Match(ref scanner, result, out parsed, orError);
    internal static bool Controls(ref Scanner scanner, ParseResult result, out ConditionalFlow parsed, ParseError? orError = null)
       => new ControlsParser().Match(ref scanner, result, out parsed, orError);
    internal static bool Flow(ref Scanner scanner, ParseResult result, out Flow parsed, ParseError? orError = null)
      => new FlowParsers().Match(ref scanner, result, out parsed, orError);
}



public record struct EmptyStatementParser : IParser<Statement>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Statement parsed, in ParseError? orError = null)
    {
        parsed = null!;
        var position = scanner.Position;
        if (scanner.Match(';', advance: true))
        {
            parsed = new EmptyStatement(scanner[position..scanner.Position]);
            return true;
        }
        return false;
    }
}


public record struct ReturnStatementParser : IParser<Statement>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Statement parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (scanner.Match("return;", advance: true))
        {
            parsed = new Return(scanner[position..scanner.Position]);
            return true;
        }
        else if (
            scanner.Match("return", advance: true)
        )
        {

            if (scanner.FollowedBy(';', withSpaces: true, advance: true))
            {
                parsed = new Return(scanner[position..scanner.Position]);
                return true;
            }
            else if (
                Parsers.FollowedByDel(ref scanner, result, PrimaryParsers.Parenthesis, out Expression p, advance : true)
                && scanner.FollowedBy(';', withSpaces: true, advance: true)
            )
            {
                parsed = new Return(scanner[position..scanner.Position], p);
                return true;
            }
            else if (
                scanner.MatchWhiteSpace(minimum: 1, advance: true)
                && ExpressionParser.Expression(ref scanner, result, out var val)
                && scanner.MatchWhiteSpace(advance: true)
                && scanner.Match(';', advance: true)
            )
            {
                parsed = new Return(scanner[position..scanner.Position], val);
                return true;
            }
            else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0041, scanner[scanner.Position], scanner.Memory));
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}

public record struct BreakParser : IParser<Statement>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Statement parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            scanner.Match("break", advance: true)
            && scanner.MatchWhiteSpace(advance: true)
            && scanner.Match(';', advance: true)
        )
        {
            parsed = new Break(scanner[position..scanner.Position]);
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}
public record struct ContinueParser : IParser<Statement>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Statement parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            scanner.Match("continue", advance: true)
            && scanner.MatchWhiteSpace(advance: true)
            && scanner.Match(';', advance: true)
        )
        {
            parsed = new Continue(scanner[position..scanner.Position]);
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}

public record struct ExpressionStatementParser : IParser<Statement>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Statement parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            ExpressionParser.Expression(ref scanner, result, out var expression)
            && scanner.FollowedBy(';', advance: true)
        )
        {
            parsed = new ExpressionStatement(expression, scanner[position..scanner.Position]);
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}




public record struct BlockStatementParser : IParser<Statement>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Statement parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (scanner.Match('{', advance: true) && scanner.MatchWhiteSpace(advance: true))
        {
            var block = new BlockStatement(new());

            while (!scanner.IsEof && !scanner.Match('}', advance: true))
            {
                if (StatementParsers.Statement(ref scanner, result, out var statement))
                {
                    block.Statements.Add(statement);
                    scanner.MatchWhiteSpace(advance: true);
                }
                else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0010, scanner[scanner.Position], scanner.Memory));
            }
            block.Info = scanner[position..scanner.Position];
            parsed = block;
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}



public record struct VariableAssignParser : IParser<VariableAssign>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out VariableAssign parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (PostfixParser.Postfix(ref scanner, result, out var p))
        {
            if (
                Parsers.FollowedBy(
                    ref scanner,
                    result,
                    (ref Scanner s, ParseResult result, out AssignOperator op, in ParseError? orError = null) => LiteralsParser.AssignOperators(ref s, null!, out op) && s.MatchWhiteSpace(advance: true),
                    out var op,
                    withSpaces: true,
                    advance: true)
            )
            {
                scanner.MatchWhiteSpace(advance: true);
                if (ExpressionParser.Expression(ref scanner, result, out var expression))
                {
                    parsed = new(p, false, scanner[position..scanner.Position], op, expression);
                    return true;
                }
                else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0015, scanner[position], scanner.Memory));
            }
            else
            {
                parsed = new(p, false, scanner[position..scanner.Position]);
                return true;
            }
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position);
    }
}

public record struct DeclaredVariableAssignParser : IParser<DeclaredVariableAssign>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out DeclaredVariableAssign parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;

        if (Parsers.IdentifierArraySizeOptionalValue(ref scanner, result, out var identifier, out var arraySizes, out var value, advance: true))
        {
            if (
                Parsers.FollowedBy(
                    ref scanner,
                    result,
                    (ref Scanner s, ParseResult result, out AssignOperator op, in ParseError? orError = null) => LiteralsParser.AssignOperators(ref s, null!, out op) && s.MatchWhiteSpace(advance: true),
                    out var op,
                    withSpaces: true,
                    advance: true)
            )
            {
                scanner.MatchWhiteSpace(advance: true);
                if (ExpressionParser.Expression(ref scanner, result, out var expression))
                {
                    parsed = new(identifier, false, scanner[position..scanner.Position], op, expression)
                    {
                        ArraySizes = arraySizes,
                        Value = value
                    };
                    return true;
                }
                else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0015, scanner[position], scanner.Memory));
            }
            else
            {
                parsed = new(identifier, false, scanner[position..scanner.Position])
                {
                    ArraySizes = arraySizes,
                    Value = value
                };
                return true;
            }
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position);
    }
}



public record struct DeclareStatementParser : IParser<Statement>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Statement parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        var isConst =
            scanner.Match("const", advance: true) && scanner.MatchWhiteSpace(minimum: 1, advance: true)
            || Parsers.SequenceOf(ref scanner, ["static", "const"], advance: true) && scanner.MatchWhiteSpace(advance: true);
        if (!isConst)
            scanner.Backtrack(position);
        if (
            LiteralsParser.TypeName(ref scanner, result, out var typeName)
            && scanner.MatchWhiteSpace(minimum: 1, advance: true)

        )
        {
            if (Parsers.Repeat(ref scanner, result, StatementParsers.DeclaredVarAssign, out List<DeclaredVariableAssign> assigns, 1, true, ","))
            {
                foreach (var a in assigns)
                {
                    a.IsConst = isConst;
                    a.ReplaceTypeName(typeName);
                }
                scanner.MatchWhiteSpace(advance: true);
                if (scanner.Match(';', advance: true))
                {
                    parsed = new Declare(typeName, scanner[position..scanner.Position])
                    {
                        Variables = assigns
                    };
                    return true;
                }
                else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0033, scanner[scanner.Position], scanner.Memory));
            }
        }
        return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}

public record struct AssignmentsParser : IParser<Statement>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Statement parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (Parsers.Repeat<VariableAssign>(ref scanner, result, StatementParsers.VarAssign, out var assigns, 1, true, ","))
        {
            scanner.MatchWhiteSpace(advance: true);
            if (scanner.Match(';', advance: true))
            {
                parsed = new Assign(scanner[position..scanner.Position])
                {
                    Variables = assigns
                };
                return true;
            }
            else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0033, scanner[scanner.Position], scanner.Memory));
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}
