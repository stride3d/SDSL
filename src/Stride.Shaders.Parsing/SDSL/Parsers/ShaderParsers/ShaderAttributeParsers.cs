using Stride.Shaders.Parsing.SDSL.AST;


namespace Stride.Shaders.Parsing.SDSL;



public record struct ShaderAttributeListParser : IParser<ShaderAttributeList>
{
    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out ShaderAttributeList parsed, in ParseError? orError = null) where TScanner : struct, IScanner
    {
        var position = scanner.Position;

        if (
            CommonParsers.Repeat<TScanner, AttributeParser, ShaderAttribute>(
                ref scanner,
                new AttributeParser(),
                result,
                out var attributeList,
                1,
                true
            )
            && CommonParsers.Spaces0(ref scanner, result, out _)
        )
        {
            parsed = new ShaderAttributeList(attributeList, scanner[position..]);
            return true;
        }
        else return CommonParsers.Exit(ref scanner, result, out parsed, position, orError);

    }
    public static bool AttributeList<TScanner>(ref TScanner scanner, ParseResult result, out ShaderAttributeList parsed, in ParseError? orError = null) where TScanner : struct, IScanner
        => new ShaderAttributeListParser().Match(ref scanner, result, out parsed, orError);
    public static bool Attribute<TScanner>(ref TScanner scanner, ParseResult result, out ShaderAttribute parsed, in ParseError? orError = null) where TScanner : struct, IScanner
        => new AttributeParser().Match(ref scanner, result, out parsed, orError);
}

public record struct AttributeParser : IParser<ShaderAttribute>
{
    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out ShaderAttribute parsed, in ParseError? orError = null) where TScanner : struct, IScanner
    {
        var position = scanner.Position;
        if (Tokens.Char('[', ref scanner, advance: true))
        {
            CommonParsers.Spaces0(ref scanner, result, out _);
            if (LiteralsParser.Identifier(ref scanner, result, out var identifier))
            {
                CommonParsers.Spaces0(ref scanner, result, out _);
                if (Tokens.Char('(', ref scanner, advance: true))
                {
                    CommonParsers.Spaces0(ref scanner, result, out _);
                    ParameterParsers.Values(ref scanner, result, out var values);
                    CommonParsers.Spaces0(ref scanner, result, out _);
                    if (Tokens.Char(')', ref scanner, advance: true) && CommonParsers.Spaces0(ref scanner, result, out _) && Tokens.Char(']', ref scanner, advance: true))
                    {
                        parsed = new AnyShaderAttribute(identifier, scanner[position..], values.Values);
                        return true;
                    }
                    else return CommonParsers.Exit(ref scanner, result, out parsed, position, new("Badly formatted attribute", scanner[position], scanner.Memory));
                }
                CommonParsers.Spaces0(ref scanner, result, out _);
                if (!Tokens.Char(']', ref scanner, advance: true))
                    return CommonParsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0019, scanner[position], scanner.Memory));
                parsed = new AnyShaderAttribute(identifier, scanner[position..]);
                return true;
            }
            return CommonParsers.Exit(ref scanner, result, out parsed, position, orError);
        }
        else return CommonParsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}
