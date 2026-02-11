using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;


public record struct ShaderElementParsers : IParser<ShaderElement>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderElement parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (TypeDef(ref scanner, result, out var typeDef))
        {
            parsed = typeDef;
            return true;
        }
        else if (BufferParsers.Buffer(ref scanner, result, out var buffer))
        {
            scanner.FollowedBy(';', withSpaces: true, advance: true);
            parsed = buffer;
            return true;
        }
        else if (Struct(ref scanner, result, out var structElement))
        {
            scanner.FollowedBy(';', withSpaces: true, advance: true);
            parsed = structElement;
            return true;
        }
        else
        {


            if(AnySamplers(ref scanner, result, out var sampler))
            {
                parsed = sampler;
                return true;
            }
            else if (Method(ref scanner, result, out var method))
            {
                parsed = method;
                return true;
            }
            else if (ShaderMemberParser.Member(ref scanner, result, out var member))
            {
                parsed = member;
                return true;
            }


            else return Parsers.Exit(ref scanner, result, out parsed, position);
        }

    }
    public static bool Compose(ref Scanner scanner, ParseResult result, out ShaderCompose parsed, in ParseError? orError = null)
        => new CompositionParser().Match(ref scanner, result, out parsed, in orError);
    public static bool Struct(ref Scanner scanner, ParseResult result, out ShaderStruct parsed, in ParseError? orError = null)
        => new ShaderStructParser().Match(ref scanner, result, out parsed, in orError);


    public static bool AnySamplers(ref Scanner scanner, ParseResult result, out ShaderElement parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        var isStaged = scanner.Match("stage", advance: true) && scanner.MatchWhiteSpace(advance: true);

        if (SamplerState(ref scanner, result, out var samplerState))
        {
            samplerState.IsStaged = isStaged;
            parsed = samplerState;
            return true;
        }
        else if (SamplerComparisonState(ref scanner, result, out var samplerCompState))
        {
            samplerCompState.IsStaged = isStaged;
            parsed = samplerCompState;
            return true;
        }
        else return Parsers.Exit(ref scanner,  result, out parsed, position);
    }
    public static bool SamplerState(ref Scanner scanner, ParseResult result, out ShaderSamplerState parsed, in ParseError? orError = null)
        => new ShaderSamplerStateParser().Match(ref scanner, result, out parsed, in orError);
    public static bool SamplerComparisonState(ref Scanner scanner, ParseResult result, out ShaderSamplerComparisonState parsed, in ParseError? orError = null)
        => new ShaderSamplerComparisonStateParser().Match(ref scanner, result, out parsed, in orError);
    public static bool ShaderElement(ref Scanner scanner, ParseResult result, out ShaderElement parsed, in ParseError? orError = null)
        => new ShaderElementParsers().Match(ref scanner, result, out parsed, in orError);

    public static bool Method(ref Scanner scanner, ParseResult result, out ShaderMethod parsed, in ParseError? orError = null)
        => new ShaderMethodParsers().Match(ref scanner, result, out parsed, in orError);

    public static bool ShaderVariable(ref Scanner scanner, ParseResult result, out ShaderElement parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;

        var hasStorageClass =
            scanner.MatchAnyOf(
                ["extern", "nointerpolation", "precise", "shared", "groupshared", "static", "uniform", "volatile"],
                out var storageClass,
                advance: true)
            && scanner.MatchWhiteSpace(minimum: 1, advance: true)
            ;
        var hasTypeModifier =
            scanner.MatchAnyOf(
                ["const", "row_major", "column_major"],
                out var typemodifier,
                advance: true)
            && scanner.MatchWhiteSpace(minimum: 1, advance: true)
            ;

        if (
            Parsers.TypeNameIdentifierArraySizeValue(ref scanner, result, out var typeName, out var identifier, out var value)
            && scanner.FollowedBy(';', withSpaces: true, advance: true)
        )
        {
            parsed = new ShaderVariable(typeName, identifier, value, scanner[position..scanner.Position])
            {
                StorageClass = storageClass.ToStorageClass(),
                TypeModifier = typemodifier.ToTypeModifier()
            };
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);

    }

    public static bool TypeDef(ref Scanner scanner, ParseResult result, out ShaderElement parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;

        if (
            scanner.Match("typedef", advance: true)
            && scanner.MatchWhiteSpace(minimum: 1, advance: true)
            && LiteralsParser.TypeName(ref scanner, result, out var type)
            && scanner.MatchWhiteSpace(minimum: 1, advance: true)
            && LiteralsParser.Identifier(ref scanner, result, out var name)
            && scanner.MatchWhiteSpace(advance: true)
            && scanner.Match(';', advance: true)
        )
        {
            parsed = new TypeDef(type, name, scanner[position..scanner.Position]);
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }

}