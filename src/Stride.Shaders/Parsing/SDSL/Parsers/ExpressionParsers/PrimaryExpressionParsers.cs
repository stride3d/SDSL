using System.Security.AccessControl;
using Stride.Shaders.Core;
using Stride.Shaders.Parsing.SDSL.AST;
using Stride.Shaders.Spirv;

namespace Stride.Shaders.Parsing.SDSL;


public record struct PrimaryParsers : IParser<Expression>
{
    public static bool Primary(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
            => new PrimaryParsers().Match(ref scanner, result, out parsed, in orError);


    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
    {
        return Parsers.Alternatives(
            ref scanner, result, out parsed, in orError,
            Parenthesis,
            ArrayLiteral,
            Method,
            MixinAccess,
            Literal
        );
    }

    public static bool Literal(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if(LiteralsParser.Literal(ref scanner, result, out var lit))
        {
            parsed = lit;
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position);
    }
    
    
    public static bool Method(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            LiteralsParser.Identifier(ref scanner, result, out var identifier)
            && scanner.MatchWhiteSpace(advance: true)
            && scanner.Match('(', advance: true)
        )
        {
            ParameterParsers.Values(ref scanner, result, out var parameters);
            scanner.MatchWhiteSpace(advance: true);
            if (scanner.Match(')', advance: true))
            {
                parsed = new MethodCall(identifier, parameters, scanner[position..scanner.Position]);
                return true;
            }
            else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0018, scanner[scanner.Position], scanner.Memory));
        }
        return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }

    public static bool Parenthesis(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
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
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }

    public static bool ArrayLiteral(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            scanner.Match('{', advance: true)
            && Parsers.FollowedByDel(ref scanner, result, ParameterParsers.Values, out ShaderExpressionList values, withSpaces: true, advance: true)
            && scanner.FollowedBy('}', withSpaces: true, advance: true)
        )
        {
            parsed = new ArrayLiteral(scanner[position..scanner.Position])
            {
                Values = values.Values
            };
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position);
    }
    
    public static bool MixinAccess(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            ShaderClassParsers.Mixin(ref scanner, result, out var mixin)
            && scanner.FollowedBy('.', withSpaces: true)
        )
        {
            parsed = new MixinAccess(mixin, scanner[position..scanner.Position]);
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}