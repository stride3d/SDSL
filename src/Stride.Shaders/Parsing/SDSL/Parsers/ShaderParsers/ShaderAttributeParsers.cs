using Stride.Shaders.Parsing.SDSL.AST;


namespace Stride.Shaders.Parsing.SDSL;



public record struct ShaderAttributeListParser : IParser<ShaderAttributeList>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderAttributeList parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;

        if (
            Parsers.Repeat<AttributeParser, ShaderAttribute>(
                ref scanner,
                new AttributeParser(),
                result,
                out var attributeList,
                1,
                true
            )
            && scanner.MatchWhiteSpace(advance: true)
        )
        {
            parsed = new ShaderAttributeList(attributeList, scanner[position..]);
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);

    }
    public static bool AttributeList(ref Scanner scanner, ParseResult result, out ShaderAttributeList parsed, in ParseError? orError = null)
        => new ShaderAttributeListParser().Match(ref scanner, result, out parsed, orError);
    public static bool Attribute(ref Scanner scanner, ParseResult result, out ShaderAttribute parsed, in ParseError? orError = null)
        => new AttributeParser().Match(ref scanner, result, out parsed, orError);
}

public record struct AttributeParser : IParser<ShaderAttribute>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderAttribute parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (scanner.Match('[', advance: true))
        {
            scanner.MatchWhiteSpace(advance: true);
            if (LiteralsParser.Identifier(ref scanner, result, out var identifier))
            {
                scanner.MatchWhiteSpace(advance: true);
                if (scanner.Match('(', advance: true))
                {
                    scanner.MatchWhiteSpace(advance: true);
                    ParameterParsers.Values(ref scanner, result, out var values);
                    scanner.MatchWhiteSpace(advance: true);
                    if (scanner.Match(')', advance: true) && scanner.MatchWhiteSpace(advance: true) && scanner.Match(']', advance: true))
                    {
                        parsed = new AnyShaderAttribute(identifier, scanner[position..], values.Values);
                        return true;
                    }
                    else return Parsers.Exit(ref scanner, result, out parsed, position, new("Badly formatted attribute", scanner[position], scanner.Memory));
                }
                scanner.MatchWhiteSpace(advance: true);
                if (!scanner.Match(']', advance: true))
                    return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0019, scanner[position], scanner.Memory));
                parsed = new AnyShaderAttribute(identifier, scanner[position..]);
                return true;
            }
            return Parsers.Exit(ref scanner, result, out parsed, position, orError);
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}
