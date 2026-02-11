using Stride.Shaders.Core;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;


public record struct PrefixParser : IParser<Expression>
{
    public static bool Prefix(ref Scanner scanner, ParseResult result, out Expression prefix, in ParseError? orError = null)
        => new PrefixParser().Match(ref scanner, result, out prefix, in orError);


    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
    {
        return Parsers.Alternatives(
            ref scanner, 
            result, 
            out parsed, 
            orError,
            PrefixIncrement,
            Signed,
            Not,
            Cast,
            PostfixParser.Postfix
        );
    }

    public static bool Not(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (scanner.Match("!~"))
        {
            var op = ((char)scanner.Peek()).ToOperator();
            scanner.Advance(1);
            scanner.MatchWhiteSpace(advance: true);
            if (PostfixParser.Postfix(ref scanner, result, out var lit))
            {
                parsed = new PrefixExpression(op, lit, scanner[position..scanner.Position]);
                return true;
            }
            else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0020, scanner[position], scanner.Memory));

        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }

    public static bool Signed(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (scanner.Match("+-"))
        {
            var op = scanner.Peek().ToOperator();
            scanner.Advance(1);
            scanner.MatchWhiteSpace(advance: true);
            if (Prefix(ref scanner, result, out var lit))
            {
                parsed = new PrefixExpression(op, lit, scanner[position..scanner.Position]);
                return true;
            }
            else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
        }
        return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
    
    public static bool PrefixIncrement(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (scanner.Match("++", advance: true))
        {
            scanner.MatchWhiteSpace(advance: true);
            if (PostfixParser.Postfix(ref scanner, result, out var lit))
            {
                parsed = new PrefixExpression(Operator.Inc, lit, scanner[position..scanner.Position]);
                return true;
            }
            else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0020, scanner[position], scanner.Memory));
        }
        // prefix decrememnt 
        else if (scanner.Match("--", advance: true))
        {
            scanner.MatchWhiteSpace(advance: true);
            if (PostfixParser.Postfix(ref scanner, result, out var lit))
            {
                parsed = new PrefixExpression(Operator.Inc, lit, scanner[position..scanner.Position]);
                return true;
            }
            else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0020, scanner[position], scanner.Memory));

        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }

    public static bool Cast(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
                scanner.FollowedBy('(', withSpaces: true, advance: true)
                && Parsers.FollowedBy(ref scanner, result, LiteralsParser.TypeName, out TypeName typeName, withSpaces: true, advance: true)
                && scanner.FollowedBy(')', withSpaces: true, advance: true)
                && Parsers.FollowedBy(ref scanner, result, PostfixParser.Postfix, out Expression expression, withSpaces: true, advance: true)
        )
        {
            parsed = new CastExpression(typeName, Operator.Cast, expression, scanner[position..scanner.Position]);
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}
