using Stride.Shaders.Parsing.SDSL;
using Stride.Shaders.Parsing.SDFX.AST;

namespace Stride.Shaders.Parsing.SDFX.Parsers;


public record struct ParamsParsers : IParser<EffectParameters>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out EffectParameters parsed, in ParseError? orError = null) 
    {
        var position = scanner.Position;
        if (scanner.Match("params", advance: true) && scanner.MatchWhiteSpace(minimum: 1, advance: true))
        {
            if (LiteralsParser.TypeName(ref scanner, result, out var paramsName))
            {
                parsed = new(paramsName, new());
                scanner.MatchWhiteSpace(advance: true);
                if (scanner.Match('{', advance: true))
                {
                    scanner.MatchWhiteSpace(advance: true);
                    while (!scanner.IsEof)
                    {
                        if (Parameter(ref scanner, result, out var p))
                            parsed.Parameters.Add(p);
                        else if (scanner.FollowedBy('}', withSpaces: true, advance: true))
                        {
                            scanner.FollowedBy(';', withSpaces: true, advance: true);
                            parsed.Info = scanner[position..scanner.Position];
                            return true;
                        }
                        else
                            SDSL.Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0012, scanner[scanner.Position], scanner.Memory));
                        scanner.MatchWhiteSpace(advance: true);
                    }
                }
            }
        }
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
    public static bool Params(ref Scanner scanner, ParseResult result, out EffectParameters parsed, in ParseError? orError = null) 
            => new ParamsParsers().Match(ref scanner, result, out parsed, orError);
    public static bool Parameter(ref Scanner scanner, ParseResult result, out EffectParameter parsed, in ParseError? orError = null) 
            => new ParameterParser().Match(ref scanner, result, out parsed, orError);
}

public record struct ParameterParser : IParser<EffectParameter>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out EffectParameter parsed, in ParseError? orError = null) 
    {
        var position = scanner.Position;

        if (LiteralsParser.TypeName(ref scanner, result, out var typename) && scanner.MatchWhiteSpace(minimum: 1, advance: true))
        {
            if (LiteralsParser.Identifier(ref scanner, result, out var identifier))
            {
                if (scanner.FollowedBy('=', withSpaces: true, advance: true))
                {
                    scanner.MatchWhiteSpace(advance: true);
                    if (ExpressionParser.Expression(ref scanner, result, out var expression) && scanner.MatchWhiteSpace(advance: true))
                    {
                        if (!scanner.Match(';', advance: true))
                            return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0013, scanner[scanner.Position], scanner.Memory));
                        parsed = new(typename, identifier, scanner[position..scanner.Position], expression);
                        return true;
                    }
                }
                else if (scanner.FollowedBy(';', withSpaces: true, advance: true))
                {
                    parsed = new(typename, identifier, scanner[position..scanner.Position]);
                    return true;
                }
                else return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0014, scanner[scanner.Position], scanner.Memory));
            }
        }
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, orError);

    }
}