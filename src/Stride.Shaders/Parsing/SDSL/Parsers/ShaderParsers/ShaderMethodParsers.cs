using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;


public record struct ShaderMethodParsers : IParser<ShaderMethod>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderMethod parsed, in ParseError? orError = null)
    {
        if (Method(ref scanner, result, out var method, in orError))
        {
            parsed = method;
            return true;
        }
        else
        {
            parsed = null!;
            return false;
        }
    }

    public static bool Method(ref Scanner scanner, ParseResult result, out ShaderMethod parsed, in ParseError? orError = null)
        => new MethodParser().Match(ref scanner, result, out parsed, in orError);
    public static bool Simple(ref Scanner scanner, ParseResult result, out ShaderMethod parsed, in ParseError? orError = null)
        => new SimpleMethodParser().Match(ref scanner, result, out parsed, in orError);



    public static bool MethodParameters(ref Scanner scanner, ParseResult result, out List<MethodParameter> parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
#warning We should not allow void to be a parameter, this is legacy C code
        if (
            scanner.FollowedBy(')', withSpaces: true)
            ||
            (
                scanner.FollowedBy("void", withSpaces: true, advance: true)
                && scanner.FollowedBy(')', withSpaces: true)
            )
        )
        {
            parsed = [];
            return true;
        }
        else

        if (Parsers.Repeat(ref scanner, result, MethodParameter, out List<MethodParameter> parameters, 0, withSpaces: true, separator: ","))
        {
            parsed = parameters;
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position);

    }
    public static bool MethodParameter(ref Scanner scanner, ParseResult result, out MethodParameter parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;

        ParameterModifiers modifiers = ParameterModifiers.None;
        if (scanner.MatchAnyOf(["inout", "in", "out", "const", "point", "lineadj", "line", "triangleadj", "triangle"], out var modifiersString, advance: true) && scanner.MatchWhiteSpace(minimum: 1, advance: true))
        {
            modifiers = modifiersString.ToParameterModifiers();
        }
        else
        {
            scanner.Backtrack(position);
        }
        if (Parsers.TypeNameIdentifierArraySizeValue(ref scanner, result, out var typename, out var identifier, out var value, advance: true)
        )
        {
            if (
                scanner.FollowedBy(':', withSpaces: true, advance: true)
                && scanner.FollowedBy(result, LiteralsParser.Identifier, out Identifier semantic, withSpaces: true, advance: true)
                && scanner.MatchWhiteSpace(minimum: 0, advance: true)
            )
            {
                parsed = new(typename, identifier, scanner[position..scanner.Position], modifiers, value, semantic: semantic);
                return true;
            }
            else
            {
                parsed = new(typename, identifier, scanner[position..scanner.Position], modifiers, value);
                return true;
            }
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position);

    }
}

public record struct SimpleMethodParser : IParser<ShaderMethod>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderMethod parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            LiteralsParser.TypeName(ref scanner, result, out var typename)
            && scanner.MatchWhiteSpace(minimum: 1, advance: true)
            && LiteralsParser.Identifier(ref scanner, result, out var methodName)
            && scanner.FollowedBy('(', withSpaces: true, advance: true)
            && scanner.FollowedBy(result, ShaderMethodParsers.MethodParameters, out List<MethodParameter> parameters, withSpaces: true, advance: true)
            && scanner.FollowedBy(')', withSpaces: true, advance: true)
            && scanner.MatchWhiteSpace(advance: true)
            && StatementParsers.Block(ref scanner, result, out var body, new(SDSLErrorMessages.SDSL0040, scanner[scanner.Position], scanner.Memory))
        )
        {
            parsed = new ShaderMethod(typename, methodName, scanner[position..scanner.Position])
            {
                Parameters = parameters,
                Body = (BlockStatement)body
            };
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}


public record struct MethodParser : IParser<ShaderMethod>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderMethod parsed, in ParseError? orError = null)
    {
        parsed = null!;
        var position = scanner.Position;

        var hasAttributes = ShaderAttributeListParser.AttributeList(ref scanner, result, out var attributes) && scanner.MatchWhiteSpace(advance: true);
        var hasModifiers = Parsers.MethodModifiers(ref scanner, result, out var isStaged, out var isStatic, out var isClone, out var isOverride, out var isAbstract, advance: true) && scanner.MatchWhiteSpace(advance: true);

        if (isAbstract)
        {
            if (
                LiteralsParser.TypeName(ref scanner, result, out var typename, orError: new(SDSLErrorMessages.SDSL0017, scanner[scanner.Position], scanner.Memory))
                && scanner.MatchWhiteSpace(minimum: 1, advance: true)
                && LiteralsParser.Identifier(ref scanner, result, out var methodName, orError: new(SDSLErrorMessages.SDSL0017, scanner[scanner.Position], scanner.Memory))
                && scanner.MatchWhiteSpace(advance: true)
            )
            {
                if (scanner.Match('(', advance: true) && scanner.MatchWhiteSpace(advance: true))
                {
                    ShaderMethodParsers.MethodParameters(ref scanner, result, out var parameters);
                    scanner.MatchWhiteSpace(advance: true);
                    if (!scanner.Match(')', advance: true))
                        return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0018, scanner[scanner.Position], scanner.Memory));

                    scanner.MatchWhiteSpace(advance: true);
                    if (!scanner.Match(';', advance: true))
                    {
                        if (orError != null)
                            return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0033, scanner[scanner.Position], scanner.Memory));
                        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
                    }
                    else
                    {
                        parsed = new(typename, methodName, scanner[position..scanner.Position], isAbstract: true)
                        {
                            Parameters = parameters
                        };
                        return true;
                    }
                }
                else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
            }
        }
        else
        {
            if (ShaderMethodParsers.Simple(ref scanner, result, out parsed, orError))
            {
                if (hasAttributes)
                    parsed.Attributes = attributes.Attributes;
                parsed.IsStaged = isStaged;
                parsed.IsClone = isClone;
                parsed.IsOverride = isOverride;
                parsed.IsStatic = isStatic;
                parsed.Info = scanner[position..scanner.Position];
                return true;
            }
        }
        return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }

}

