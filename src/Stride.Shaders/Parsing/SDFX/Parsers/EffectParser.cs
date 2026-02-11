using Stride.Shaders.Parsing.SDFX.AST;
using Stride.Shaders.Parsing.SDSL;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDFX.Parsers;


public record struct EffectParser : IParser<ShaderEffect>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderEffect parsed, in ParseError? orError = null) 
    {
        var position = scanner.Position;

        var isPartial = scanner.Match("partial", advance: true) && scanner.MatchWhiteSpace(minimum: 1, advance: true);
        if(!isPartial)
            scanner.Backtrack(position);

        if (scanner.Match("effect", advance: true) && scanner.MatchWhiteSpace(minimum: 1, advance: true))
        {
            if (LiteralsParser.TypeName(ref scanner, result, out var effectName) && scanner.MatchWhiteSpace(advance: true))
            {
                parsed = new((TypeName)effectName, isPartial, new());
                if (scanner.Match('{', advance: true) && scanner.MatchWhiteSpace(advance: true))
                {
                    while(
                       !scanner.IsEof
                       && !scanner.Match('}')
                    )
                    {
                        if (EffectStatementParsers.Statement(ref scanner, result, out var s) && scanner.MatchWhiteSpace(advance: true))
                        {
                            parsed.Members.Add(s);
                        }
                        else return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0009, scanner[scanner.Position], scanner.Memory));
                    }
                    if(scanner.IsEof)
                        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0011, scanner[scanner.Position], scanner.Memory));
                    else if(scanner.Match('}', advance: true))
                    {
                        parsed.Info = scanner[position..scanner.Position];
                        scanner.FollowedBy(';', withSpaces: true, advance: true);
                        return true;
                    }
                }
            }
        }
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }

    public static bool Effect(ref Scanner scanner, ParseResult result, out ShaderEffect parsed, in ParseError? orError = null) 
            => new EffectParser().Match(ref scanner, result, out parsed, orError);
    public static bool EffectStatement(ref Scanner scanner, ParseResult result, out EffectStatement parsed, in ParseError? orError = null) 
            => new EffectStatementParsers().Match(ref scanner, result, out parsed, orError);
}