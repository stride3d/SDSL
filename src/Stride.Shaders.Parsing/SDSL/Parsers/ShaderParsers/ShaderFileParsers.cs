using Stride.Shaders.Parsing.SDFX.Parsers;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;




public record struct ShaderFileParser : IParser<ShaderFile>
{
    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out ShaderFile parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        var position = scanner.Position;
        CommonParsers.Spaces0(ref scanner, result, out _);
        var file = new ShaderFile(new(scanner.Memory, ..));
        while (!scanner.IsEof)
        {
            if (
                Tokens.Literal("namespace", ref scanner)
                && NamespaceParsers.Namespace(ref scanner, result, out var ns)
            )
            {
                file.Namespaces.Add(ns);
                CommonParsers.Spaces0(ref scanner, result, out _);
            }
            else if (
                (
                    Tokens.Literal("class", ref scanner)
                    || Tokens.Literal("shader", ref scanner)
                    || CommonParsers.SequenceOf(ref scanner, ["internal", "shader"])
                )
                && ShaderClassParsers.Class(ref scanner, result, out var shader)
            )
            {
                file.RootDeclarations.Add(shader);
                CommonParsers.Spaces0(ref scanner, result, out _);
            }
            else if ((Tokens.Literal("effect", ref scanner) || CommonParsers.SequenceOf(ref scanner, ["partial", "effect"]))
                && EffectParser.Effect(ref scanner, result, out var effect)
            )
            {
                file.RootDeclarations.Add(effect);
                CommonParsers.Spaces0(ref scanner, result, out _);
            }
            else if (Tokens.Literal("params ", ref scanner)
                && ParamsParsers.Params(ref scanner, result, out var p)
            )
            {
                file.RootDeclarations.Add(p);
                CommonParsers.Spaces0(ref scanner, result, out _);
            }
            else if (Tokens.Literal("using ", ref scanner)
                && UsingNamespace(ref scanner, result, out var uns)
            )
            {
                file.RootDeclarations.Add(uns);
                CommonParsers.Spaces0(ref scanner, result, out _);
            }
            else return CommonParsers.Exit(ref scanner, result, out parsed, position, new(SDSLParsingMessages.SDSL0001, scanner[scanner.Position], scanner.Memory));
        }
        parsed = file;
        return true;
    }
    public static bool UsingNamespace<TScanner>(ref TScanner scanner, ParseResult result, out UsingShaderNamespace parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
        => new UsingNamespaceParser().Match(ref scanner, result, out parsed, orError);
}

public record struct UsingNamespaceParser : IParser<UsingShaderNamespace>
{
    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out UsingShaderNamespace parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        var position = scanner.Position;
        if (Tokens.Literal("using", ref scanner, advance: true) && CommonParsers.Spaces0(ref scanner, result, out _))
        {
            parsed = new(scanner[..]);
            do
            {
                if (CommonParsers.FollowedByDel(ref scanner, result, LiteralsParser.Identifier, out Identifier identifier, withSpaces: true, advance: true))
                {
                    parsed.NamespacePath.Add(identifier);
                }
                else return CommonParsers.Exit(ref scanner, result, out parsed, position, new(SDSLParsingMessages.SDSL0001, scanner[scanner.Position], scanner.Memory));
            }
            while (!scanner.IsEof && Tokens.Char('.', ref scanner, advance: true));



            if (CommonParsers.FollowedBy(ref scanner, Tokens.Char(';'), withSpaces: true, advance: true))
            {
                parsed.Info = scanner[position..scanner.Position];
                return true;
            }
            else return CommonParsers.Exit(ref scanner, result, out parsed, position, new(SDSLParsingMessages.SDSL0013, scanner[scanner.Position], scanner.Memory));
        }
        return CommonParsers.Exit(ref scanner, result, out parsed, position, orError);
    }


}


public record struct NamespaceParsers : IParser<ShaderNamespace>
{
    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out ShaderNamespace parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        var position = scanner.Position;
        if (
            Tokens.Literal("namespace", ref scanner, advance: true)
            && CommonParsers.Spaces1(ref scanner, result, out _)
        )
        {
            var ns = new ShaderNamespace(new());
            CommonParsers.Spaces0(ref scanner, result, out _);
            var nsStart = scanner.Position;
            do
            {
                CommonParsers.Spaces0(ref scanner, result, out _);
                if (LiteralsParser.Identifier(ref scanner, result, out var identifier))
                    ns.NamespacePath.Add(identifier);
                else return CommonParsers.Exit(ref scanner, result, out parsed, position, new(SDSLParsingMessages.SDSL0017, scanner[scanner.Position], scanner.Memory));

                CommonParsers.Spaces0(ref scanner, result, out _);
            }
            while (!scanner.IsEof && Tokens.Char('.', ref scanner, advance: true));
            if (ns.NamespacePath.Count > 0)
                ns.Namespace = new(string.Join(".", ns.NamespacePath), scanner[nsStart..scanner.Position]);
            if (Tokens.Char(';', ref scanner, advance: true))
            {
                CommonParsers.Spaces0(ref scanner, result, out _);
                while (ShaderClassParsers.Class(ref scanner, result, out var shader))
                {
                    ns.Declarations.Add(shader);
                }
            }
            else if (Tokens.Char('{', ref scanner, advance: true))
            {
                CommonParsers.Spaces0(ref scanner, result, out _);
                while (!scanner.IsEof && !Tokens.Char('}', ref scanner, advance: true))
                {
                    if (ShaderClassParsers.Class(ref scanner, result, out var shader) && CommonParsers.Spaces0(ref scanner, result, out _))
                        ns.Declarations.Add(shader);
                    else if (EffectParser.Effect(ref scanner, result, out var effect) && CommonParsers.Spaces0(ref scanner, result, out _))
                        ns.Declarations.Add(effect);
                    else if (ParamsParsers.Params(ref scanner, result, out var p) && CommonParsers.Spaces0(ref scanner, result, out _))
                        ns.Declarations.Add(p);
                    else
                        return CommonParsers.Exit(ref scanner, result, out parsed, position, new(SDSLParsingMessages.SDSL0039, scanner[scanner.Position], scanner.Memory));
                }
            }
            else return CommonParsers.Exit(ref scanner, result, out parsed, position, orError);

            ns.Info = scanner[position..scanner.Position];
            parsed = ns;
            return true;
        }
        return CommonParsers.Exit(ref scanner, result, out parsed, position, orError);
    }

    public static bool Namespace<TScanner>(ref TScanner scanner, ParseResult result, out ShaderNamespace parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
        => new NamespaceParsers().Match(ref scanner, result, out parsed, orError);
}