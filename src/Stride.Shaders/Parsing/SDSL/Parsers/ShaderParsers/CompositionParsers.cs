using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;



public record struct CompositionParser() : IParser<ShaderCompose>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderCompose parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;

        var hasAttributes = ShaderAttributeListParser.AttributeList(ref scanner, result, out var attributes) && scanner.MatchWhiteSpace(advance: true);
        var isStaged = scanner.Match("stage", advance: true) && scanner.MatchWhiteSpace(minimum: 1, advance: true);
        
        if (scanner.Match("compose", advance: true) && scanner.MatchWhiteSpace(minimum: 1, advance: true))
        {
            var tmp = scanner.Position;
            if (Parsers.MixinIdentifierArraySizeValue(ref scanner, result, out var mixin, out var name, out var arraysize, out var value, advance: true))
            {
                scanner.MatchWhiteSpace(advance: true);
                if (!scanner.Match(';', advance: true))
                    return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0033, scanner[position], scanner.Memory));
                parsed = new(name, mixin, true, scanner[position..])
                {
                    Attributes = hasAttributes ? attributes.Attributes : null!,
                    IsStaged = isStaged
                };
                return true;
            }
            else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0032, scanner[scanner.Position], scanner.Memory));
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}