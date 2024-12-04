using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;

public record struct DirectivePostfixParser : IParser<Expression>
{

    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        var position = scanner.Position;
        // If the following 
        if (
            Accessor(ref scanner, result, out parsed)
            && CommonParsers.Spaces0(ref scanner, result, out _)
        )
        {
            if (Tokens.Set("[.", ref scanner) || Tokens.Literal("++", ref scanner) || Tokens.Literal("--", ref scanner))
            {
                if (Tokens.Char('.', ref scanner, advance: true))
                {
                    if (Postfix(ref scanner, result, out var accessed))
                    {
                        parsed = new AccessorExpression(parsed, accessed, scanner[position..scanner.Position]);
                        return true;
                    }
                    else
                    {
                        scanner.Position = position;
                        return false;
                    }
                }
                else if (Tokens.Char('[', ref scanner, advance: true))
                {
                    CommonParsers.Spaces0(ref scanner, result, out _);
                    if (
                        ExpressionParser.Expression(ref scanner, result, out var index)
                        && CommonParsers.Spaces0(ref scanner, result, out _)
                        && Tokens.Char(']', ref scanner, advance: true)
                    )
                    {
                        parsed = new IndexerExpression(parsed, index, scanner[position..scanner.Position]);
                        return true;
                    }
                    else
                    {
                        scanner.Position = position;
                        return false;
                    }
                }
                else if (Tokens.Literal("++", ref scanner, advance: true))
                {
                    parsed = new PostfixExpression(parsed, Operator.Inc, scanner[position..scanner.Position]);
                    return true;
                }
                else if (Tokens.Literal("--", ref scanner, advance: true))
                {
                    parsed = new PostfixExpression(parsed, Operator.Dec, scanner[position..scanner.Position]);
                    return true;
                }
                else 
                {
                    result.Errors.Add(new(SDSLParsingMessages.SDSL0020, scanner[position], scanner.Memory));
                    return false;
                }
            }
            else return true;
        }
        else 
        {
            if (orError is not null)
                result.Errors.Add(orError.Value);
            scanner.Position = position;
            return false;
        }
    }
    public static bool Postfix<TScanner>(ref TScanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
        => new DirectivePostfixParser().Match(ref scanner, result, out parsed, in orError);
    internal static bool Increment<TScanner>(ref TScanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
        => new DirectivePostfixIncrementParser().Match(ref scanner, result, out parsed, in orError);
    internal static bool Accessor<TScanner>(ref TScanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
        => new DirectivePostfixAccessorParser().Match(ref scanner, result, out parsed, in orError);
    internal static bool Indexer<TScanner>(ref TScanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
        => new DirectivePostfixIndexerParser().Match(ref scanner, result, out parsed, in orError);
}


public record struct DirectivePostfixAccessorParser : IParser<Expression>
{
    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        var position = scanner.Position;
        if (PostfixParser.Indexer(ref scanner, result, out var expression))
        {
            var pos2 = scanner.Position;
            CommonParsers.Spaces0(ref scanner, result, out _);
            if (
                Tokens.Char('.', ref scanner, advance: true)
                && CommonParsers.Spaces0(ref scanner, result, out _)
                && PostfixParser.Accessor(ref scanner, result, out var accessed, new(SDSLParsingMessages.SDSL0021, scanner[scanner.Position], scanner.Memory)))
            {
                parsed = new AccessorExpression(expression, accessed, scanner[position..scanner.Position]);
                return true;
            }
            else
            {
                scanner.Position = pos2;
                parsed = expression;
                return true;
            }
        }
        if (orError is not null)
                result.Errors.Add(orError.Value);
        parsed = null!;
        return false;
    }
}

public record struct DirectivePostfixIndexerParser : IParser<Expression>
{
    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        var position = scanner.Position;

        if (PrimaryParsers.Primary(ref scanner, result, out var expression))
        {
            var pos2 = scanner.Position;
            CommonParsers.Spaces0(ref scanner, result, out _);
            if (Tokens.Char('[', ref scanner, advance: true))
            {
                if (
                    CommonParsers.Spaces0(ref scanner, result, out _)
                    && ExpressionParser.Expression(ref scanner, result, out var index, new(SDSLParsingMessages.SDSL0010, scanner[scanner.Position], scanner.Memory))
                    && CommonParsers.Spaces0(ref scanner, result, out _)
                    && Tokens.Char(']', ref scanner, advance: true)
                )
                {
                    parsed = new IndexerExpression(expression, index, scanner[position..scanner.Position]);
                    return true;
                }
                else 
                {
                    result.Errors.Add(new(SDSLParsingMessages.SDSL0021, scanner[position], scanner.Memory));
                    parsed = null!;
                    return false;
                }
            }
            else
            {
                scanner.Position = pos2;
                parsed = expression;
                return true;
            }
        }
        if (orError is not null)
                result.Errors.Add(orError.Value);
        parsed = null!;
        return false;
    }
}

public record struct DirectivePostfixIncrementParser : IParser<Expression>
{
    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        var position = scanner.Position;
        if(PostfixParser.Accessor(ref scanner, result, out parsed))
        {
            var pos2 = scanner.Position;
            CommonParsers.Spaces0(ref scanner, result, out _);
            if(Tokens.Literal("++", ref scanner, advance: true))
            {
                parsed = new PostfixExpression(parsed, Operator.Inc, scanner[position..scanner.Position]);
                return true;
            }
            else
            {
                scanner.Position = pos2;
                return true;
            }
        }
        if (orError is not null)
                result.Errors.Add(orError.Value);
        parsed = null!;
        return false;
    }
}


