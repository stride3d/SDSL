using Stride.Shaders.Parsing.SDFX.Parsers;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;




public record struct ShaderFileParser : IParser<ShaderFile>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderFile parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        scanner.MatchWhiteSpace(advance: true);
        var file = new ShaderFile(new(scanner.Memory, ..));
        while (!scanner.IsEof)
        {
            if (
                scanner.Match("namespace")
                && NamespaceParsers.Namespace(ref scanner, result, out var ns)
            )
            {
                file.Namespaces.Add(ns);
                scanner.MatchWhiteSpace(advance: true);
            }
            else if (
                (
                    scanner.Match("class")
                    || scanner.Match("shader")
                    || Parsers.SequenceOf(ref scanner, ["internal", "shader"])
                )
                && ShaderClassParsers.Class(ref scanner, result, out var shader)
            )
            {
                file.RootDeclarations.Add(shader);
                scanner.MatchWhiteSpace(advance: true);
            }
            else if ((scanner.Match("effect") || Parsers.SequenceOf(ref scanner, ["partial", "effect"]))
                && EffectParser.Effect(ref scanner, result, out var effect)
            )
            {
                file.RootDeclarations.Add(effect);
                scanner.MatchWhiteSpace(advance: true);
            }
            else if (scanner.Match("params ")
                && ParamsParsers.Params(ref scanner, result, out var p)
            )
            {
                file.RootDeclarations.Add(p);
                scanner.MatchWhiteSpace(advance: true);
            }
            else if (scanner.Match("using ")
                && UsingNamespace(ref scanner, result, out var uns)
            )
            {
                file.RootDeclarations.Add(uns);
                scanner.MatchWhiteSpace(advance: true);
            }
            else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0001, scanner[scanner.Position], scanner.Memory));
        }
        parsed = file;
        return true;
    }
    public static bool UsingNamespace(ref Scanner scanner, ParseResult result, out UsingShaderNamespace parsed, in ParseError? orError = null)
        
        => new UsingNamespaceParser().Match(ref scanner, result, out parsed, orError);
}

public record struct UsingNamespaceParser : IParser<UsingShaderNamespace>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out UsingShaderNamespace parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        if (scanner.Match("using", advance: true) && scanner.MatchWhiteSpace(advance: true))
        {
            parsed = new(scanner[..]);
            do
            {
                if (Parsers.FollowedByDel(ref scanner, result, LiteralsParser.Identifier, out Identifier identifier, withSpaces: true, advance: true))
                {
                    parsed.NamespacePath.Add(identifier);
                }
                else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0001, scanner[scanner.Position], scanner.Memory));
            }
            while (!scanner.IsEof && scanner.Match('.', advance: true));



            if (scanner.FollowedBy(';', withSpaces: true, advance: true))
            {
                parsed.Info = scanner[position..scanner.Position];
                return true;
            }
            else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0013, scanner[scanner.Position], scanner.Memory));
        }
        return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }


}


public record struct NamespaceParsers : IParser<ShaderNamespace>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderNamespace parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        if (
            scanner.Match("namespace", advance: true)
            && scanner.MatchWhiteSpace(minimum: 1, advance: true)
        )
        {
            var ns = new ShaderNamespace(new());
            scanner.MatchWhiteSpace(advance: true);
            var nsStart = scanner.Position;
            do
            {
                scanner.MatchWhiteSpace(advance: true);
                if (LiteralsParser.Identifier(ref scanner, result, out var identifier))
                    ns.NamespacePath.Add(identifier);
                else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0017, scanner[scanner.Position], scanner.Memory));

                scanner.MatchWhiteSpace(advance: true);
            }
            while (!scanner.IsEof && scanner.Match('.', advance: true));
            if (ns.NamespacePath.Count > 0)
                ns.Namespace = new(string.Join(".", ns.NamespacePath), scanner[nsStart..scanner.Position]);
            if (scanner.Match(';', advance: true))
            {
                scanner.MatchWhiteSpace(advance: true);
                while (!scanner.IsEof)
                {
                    if(ShaderClassParsers.Class(ref scanner, result, out var shader) && scanner.MatchWhiteSpace(advance: true))
                        ns.Declarations.Add(shader);
                    else if( EffectParser.Effect(ref scanner, result, out var effect) && scanner.MatchWhiteSpace(advance: true))
                        ns.Declarations.Add(effect);
                    else if( ParamsParsers.Params(ref scanner, result, out var p) && scanner.MatchWhiteSpace(advance: true))
                        ns.Declarations.Add(p);
                    else
                        return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0001, scanner[scanner.Position], scanner.Memory));
                    scanner.MatchWhiteSpace(advance: true);
                }
            }
            else if (scanner.Match('{', advance: true))
            {
                scanner.MatchWhiteSpace(advance: true);
                while (!scanner.IsEof && !scanner.Match('}', advance: true))
                {
                    if (ShaderClassParsers.Class(ref scanner, result, out var shader) && scanner.MatchWhiteSpace(advance: true))
                        ns.Declarations.Add(shader);
                    else if (EffectParser.Effect(ref scanner, result, out var effect) && scanner.MatchWhiteSpace(advance: true))
                        ns.Declarations.Add(effect);
                    else if (ParamsParsers.Params(ref scanner, result, out var p) && scanner.MatchWhiteSpace(advance: true))
                        ns.Declarations.Add(p);
                    else
                        return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0039, scanner[scanner.Position], scanner.Memory));
                }
            }
            else return Parsers.Exit(ref scanner, result, out parsed, position, orError);

            ns.Info = scanner[position..scanner.Position];
            parsed = ns;
            return true;
        }
        return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }

    public static bool Namespace(ref Scanner scanner, ParseResult result, out ShaderNamespace parsed, in ParseError? orError = null)
        
        => new NamespaceParsers().Match(ref scanner, result, out parsed, orError);
}