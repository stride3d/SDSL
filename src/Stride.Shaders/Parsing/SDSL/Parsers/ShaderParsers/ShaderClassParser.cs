using System.Runtime.CompilerServices;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;


public record struct ShaderClassParsers : IParser<ShaderClass>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderClass parsed, in ParseError? orError = null)
    {
        if (ComplexClass(ref scanner, result, out parsed, in orError))
            return true;
        else
            return false;
    }
    public static bool Class(ref Scanner scanner, ParseResult result, out ShaderClass parsed, in ParseError? orError = null)
        => new ShaderClassParsers().Match(ref scanner, result, out parsed, in orError);
    public static bool ComplexClass(ref Scanner scanner, ParseResult result, out ShaderClass parsed, in ParseError? orError = null)
        => new ShaderClassParser().Match(ref scanner, result, out parsed, in orError);
    public static bool GenericsDefinition(ref Scanner scanner, ParseResult result, out ShaderGenerics parsed)
        => new ShaderGenericsDefinitionParser().Match(ref scanner, result, out parsed);
    public static bool Mixin(ref Scanner scanner, ParseResult result, out Mixin parsed, in ParseError? orError = null)
        => new ShaderMixinParser().Match(ref scanner, result, out parsed);
}

public record struct SimpleShaderClassParser : IParser<ShaderClass>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderClass parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;

        if (
            scanner.Match("shader", advance: true)
            && scanner.MatchWhiteSpace(minimum: 1, advance: true)
            && LiteralsParser.Identifier(ref scanner, result, out var className, new(SDSLErrorMessages.SDSL0017, scanner[scanner.Position], scanner.Memory))
            && scanner.MatchWhiteSpace(advance: true)
            && scanner.Match('{', advance: true)
            && scanner.MatchWhiteSpace(advance: true)

        )
        {
            var c = new ShaderClass(className, scanner[position..scanner.Position]);
            while (!scanner.IsEof && !scanner.Match('}', advance: true))
            {
                if (ShaderElementParsers.ShaderElement(ref scanner, result, out var e))
                {
                    c.Elements.Add(e);
                }
                else
                    break;
                scanner.MatchWhiteSpace(advance: true);
            }
            parsed = c;
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}

public record struct ShaderClassParser : IParser<ShaderClass>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderClass parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        var tmp = position;
        if (scanner.Match("internal", advance: true) && scanner.MatchWhiteSpace(minimum: 1, advance: true))
            tmp = scanner.Position;
        if(scanner.FollowedBy("partial", withSpaces: true, advance: true) && scanner.MatchWhiteSpace(minimum: 1, advance: true))
            tmp = scanner.Position;
        if (
            (
                scanner.Match("shader", advance: true) 
                || scanner.Match("class", advance: true) 
            )
            && scanner.MatchWhiteSpace(minimum: 1, advance: true))
        {
            if (
                LiteralsParser.Identifier(ref scanner, result, out var identifier, new(SDSLErrorMessages.SDSL0017, scanner[scanner.Position], scanner.Memory))
                && scanner.MatchWhiteSpace(advance: true)
            )
            {
                parsed = new ShaderClass(identifier, scanner[..]);
                if (scanner.Match('<', advance: true))
                {
                    ParameterParsers.Declarations(ref scanner, result, out var generics);
                    scanner.MatchWhiteSpace(advance: true);
                    if (!scanner.Match('>', advance: true))
                        return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0034, scanner[scanner.Position], scanner.Memory));
                    parsed.Generics = generics;
                    scanner.MatchWhiteSpace(advance: true);
                }
                if (scanner.Match(':', advance: true))
                {
                    scanner.MatchWhiteSpace(advance: true);
                    while (ShaderClassParsers.Mixin(ref scanner, result, out var mixin))
                    {
                        parsed.Mixins.Add(mixin);
                        scanner.MatchWhiteSpace(advance: true);
                        if (scanner.Match(',', advance: true))
                            scanner.MatchWhiteSpace(advance: true);
                        else
                            break;
                    }
                    if (parsed.Mixins.Count == 0)
                        return Parsers.Exit(ref scanner, result, out parsed, position, new("Expecting at least one mixin", scanner[scanner.Position], scanner.Memory));
                    scanner.MatchWhiteSpace(advance: true);
                }
                if (scanner.Match('{', advance: true)
                    && scanner.MatchWhiteSpace(advance: true)
                )
                {
                    while (!scanner.IsEof && !scanner.Match('}', advance: true))
                    {
                        if (ShaderElementParsers.ShaderElement(ref scanner, result, out var e))
                        {
                            parsed.Elements.Add(e);
                        }
                        else
                            break;
                        scanner.MatchWhiteSpace(advance: true);
                    }
                    scanner.FollowedBy(';', withSpaces: true, advance: true);
                    parsed.Info = scanner[position..scanner.Position];
                    return true;
                }
                else return Parsers.Exit(ref scanner, result, out parsed, position, new("Expecting shader body", scanner[position], scanner.Memory));

            }
        }
        return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}


public record struct ShaderMixinParser : IParser<Mixin>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Mixin parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        List<Identifier> path = [];
        do
        {
            if(LiteralsParser.Identifier(ref scanner, result, out var id))
                path.Add(id);
        }
        while (!scanner.IsEof && scanner.Match('.', advance: true) && scanner.MatchWhiteSpace(advance: true));

        if (path.Count > 0)
        {
            var identifier = path[^1];
            parsed = new Mixin(identifier, scanner[..]);
            var tmpPos = scanner.Position;
            scanner.MatchWhiteSpace(advance: true);
            if (
                scanner.Match('<', advance: true)
                && scanner.MatchWhiteSpace(advance: true)
            )
            {
                ParameterParsers.GenericsList(ref scanner, result, out var values);
                parsed.Generics = values;
                parsed.Path = path[..^1];
                scanner.MatchWhiteSpace(advance: true);
                if (!scanner.Match('>', advance: true))
                    return Parsers.Exit(ref scanner, result, out parsed, position);
                return true;
            }
            else
            {
                scanner.Backtrack(tmpPos);
                return true;
            }
        }
        return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}


public record struct ShaderGenericsDefinitionParser : IParser<ShaderGenerics>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderGenerics parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            LiteralsParser.Identifier(ref scanner, result, out var typename)
            && scanner.MatchWhiteSpace(minimum: 1, advance: true)
            && LiteralsParser.Identifier(ref scanner, result, out var identifier)
        )
        {
            parsed = new ShaderGenerics(typename, identifier, scanner[position..scanner.Position]);
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}