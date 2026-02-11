using Stride.Shaders.Parsing.SDFX.AST;
using Stride.Shaders.Parsing.SDFX.Parsers;
using Stride.Shaders.Parsing.SDSL;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDFX;



public record struct FlowParsers : IParser<EffectFlow>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out EffectFlow parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (ForEach(ref scanner, result, out var fe, orError))
        {
            parsed = fe;
            return true;
        }
        else return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }

    public static bool ForEach(ref Scanner scanner, ParseResult result, out EffectForEach parsed, ParseError? orError = null)
        => new EffectForEachParser().Match(ref scanner, result, out parsed, orError);
}




public record struct EffectForEachParser : IParser<EffectForEach>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out EffectForEach parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (scanner.Match("foreach", advance: true) && scanner.MatchWhiteSpace(advance: true))
        {
            if (scanner.Match('(', advance: true) && scanner.MatchWhiteSpace(advance: true))
            {
                if (
                    LiteralsParser.TypeName(ref scanner, result, out var typeName, new(SDSLErrorMessages.SDSL0017, scanner[scanner.Position], scanner.Memory))
                    && scanner.MatchWhiteSpace(minimum: 1, advance: true)
                    && LiteralsParser.Identifier(ref scanner, result, out var identifier, new(SDSLErrorMessages.SDSL0032, scanner[scanner.Position], scanner.Memory))
                    && scanner.MatchWhiteSpace(minimum: 1, advance: true)
                )
                {
                    if (scanner.Match("in", advance: true) && scanner.MatchWhiteSpace(minimum: 1, advance: true))
                    {
                        if (
                            ExpressionParser.Expression(ref scanner, result, out var collection, new(SDSLErrorMessages.SDSL0032, scanner[scanner.Position], scanner.Memory))
                            && scanner.MatchWhiteSpace(advance: true)
                        )
                        {
                            if (scanner.Match(')', advance: true) && scanner.MatchWhiteSpace(advance: true))
                            {
                                if (EffectStatementParsers.Statement(ref scanner, result, out var statement, new(SDSLErrorMessages.SDSL0010, scanner[scanner.Position], scanner.Memory)))
                                {
                                    parsed = new((TypeName)typeName, identifier, collection, statement, scanner[position..scanner.Position]);
                                    return true;
                                }
                            }
                            else return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0018, scanner[scanner.Position], scanner.Memory));
                        }
                    }
                    else return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0001, scanner[scanner.Position], scanner.Memory));
                }
            }
            else return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0035, scanner[scanner.Position], scanner.Memory));
        }
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}