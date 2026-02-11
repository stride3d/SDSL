using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;


public record struct DirectivePrimaryParsers : IParser<Expression>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        
    {
        if (Parenthesis(ref scanner, result, out parsed))
            return true;
        else if (LiteralsParser.Identifier(ref scanner, result, out var lit))
        {
            parsed = lit;
            return true;
        }
        else if (LiteralsParser.Integer(ref scanner, result, out var integer))
        {
            parsed = integer;
            return true;
        }
        else
        {
            if (orError is not null)
                result.Errors.Add(orError.Value);
            return false;
        }
    }
    public static bool Primary(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        
            => new DirectivePrimaryParsers().Match(ref scanner, result, out parsed, in orError);
    public static bool Identifier(ref Scanner scanner, ParseResult result, out Identifier parsed)
        
            => new IdentifierParser().Match(ref scanner, result, out parsed);
    public static bool Parenthesis(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        
        => new DirectiveParenthesisExpressionParser().Match(ref scanner, result, out parsed, in orError);
}


public record struct DirectiveParenthesisExpressionParser : IParser<Expression>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        if (
            scanner.Match('(', advance: true)
            && scanner.MatchWhiteSpace(advance: true)
            && ExpressionParser.Expression(ref scanner, result, out parsed, new(SDSLErrorMessages.SDSL0015, scanner[position], scanner.Memory))
            && scanner.MatchWhiteSpace(advance: true)
            && scanner.Match(')', advance: true)
        )
            return true;
        else
        {
            if (orError != null)
                result.Errors.Add(orError.Value);
            parsed = null!;
            scanner.Backtrack(position);
            return false;
        }
    }
}

public record struct DirectiveMethodCallParser : IParser<Expression>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        if (
            LiteralsParser.Identifier(ref scanner, result, out var identifier)
            && scanner.MatchWhiteSpace(advance: true)
            && scanner.Match('(', advance: true)
        )
        {
            scanner.MatchWhiteSpace(advance: true);
            ParameterParsers.Values(ref scanner, result, out var parameters);
            var pos2 = scanner.Position;
            if (scanner.Match(')', advance: true))
            {
                parsed = new MethodCall(identifier, parameters, scanner[position..scanner.Position]);
                return true;
            }
            else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0018, scanner[scanner.Position], scanner.Memory));
        }
        
        return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}