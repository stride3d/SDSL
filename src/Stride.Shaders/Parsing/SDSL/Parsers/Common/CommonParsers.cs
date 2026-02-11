using System.Security.Cryptography;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;




public static class Parsers
{
    public static bool Exit<TNode>(ref Scanner scanner, ParseResult result, out TNode parsed, int beginningPosition, in ParseError? orError = null)
        where TNode : class
    {
        if (orError is not null)
        {
            result.Errors.Add(orError.Value);
            scanner.Backtrack(scanner.End);
            parsed = null!;
            return false;
        }
        if (result.Errors.Count == 0)
            scanner.Backtrack(beginningPosition);
        parsed = null!;
        return false;
    }


    public static bool Alternatives<TResult>(ref Scanner scanner, ParseResult result, out TResult parsed, in ParseError? orError = null, params ReadOnlySpan<ParserDelegate<TResult>> parsers)
        where TResult : Node
    {
        var position = scanner.Position;
        foreach (var p in parsers)
            if (p.Invoke(ref scanner, result, out parsed))
                return true;
        return Exit(ref scanner, result, out parsed, position, orError);
    }
    public static bool Sequences<TResult>(ref Scanner scanner, ParseResult result, out List<TResult> parsed, in ParseError? orError = null, bool withSPaces = false, string? separator = null, params ReadOnlySpan<ParserDelegate<TResult>> parsers)

        where TResult : Node
    {
        parsed = [];
        var position = scanner.Position;
        foreach (var p in parsers)
            if (p.Invoke(ref scanner, result, out var r))
                parsed.Add(r);
            else
                return Exit(ref scanner, result, out parsed, position, orError);
        return true;
    }

    public static bool SequenceOf(ref Scanner scanner, ReadOnlySpan<string> literals, bool advance = false)

    {
        var position = scanner.Position;
        foreach (var l in literals)
        {
            if (!(scanner.Match(l, advance: true) && scanner.MatchWhiteSpace(minimum: 1, advance: true)))
            {
                scanner.Backtrack(position);
                return false;
            }
        }
        scanner.Backtrack(advance ? scanner.Position : position);
        return true;
    }


    public static bool MethodModifiers(ref Scanner scanner, ParseResult result, out bool isStaged, out bool isStatic, out bool isClone, out bool isOverride, out bool isAbstract, bool advance = true)
    {
        var position = scanner.Position;
        isStaged = false;
        isStatic = false;
        isOverride = false;
        isAbstract = false;
        isClone = false;
        bool matched = false;
        // legacy
        while (
            scanner.MatchAnyOf(
                [
                    "stage",
                    "override",
                    "clone",
                    "abstract",
                    "static"
                ],
                out string match,
                advance: true)
            && scanner.MatchWhiteSpace(minimum: 1, advance: true))
        {
            matched = true;
            if (match == "stage")
                isStaged = true;
            else if (match == "override")
                isOverride = true;
            else if (match == "clone")
                isClone = true;
            else if (match == "abstract")
                isAbstract = true;
            else if (match == "static")
                isStatic = true;
            else break;
        }
        if (!advance)
            scanner.Backtrack(position);
        return matched;
    }

    public static bool VariableModifiers(ref Scanner scanner, ParseResult result, out bool isStaged, out bool isCompose, out StreamKind streamKind, out InterpolationModifier interpolation, out TypeModifier typeModifier, out StorageClass storageClass, bool advance = true)

    {
        var position = scanner.Position;
        isStaged = false;
        isCompose = false;
        streamKind = StreamKind.None;
        interpolation = InterpolationModifier.None;
        typeModifier = TypeModifier.None;
        storageClass = StorageClass.None;
        bool matched = false;
        // legacy
        while (
            scanner.MatchAnyOf(
                [
                    "stage",
                    "compose",
                    "stream",
                    "patchstream",
                    "linear",
                    "centroid",
                    "nointerpolation",
                    "noperspective",
                    "sample",
                    "extern",
                    "nointerpolation",
                    "precise",
                    "shared",
                    "groupshared",
                    "static",
                    "uniform",
                    "volatile",
                    "const",
                    "rowmajor",
                    "columnmajor"
                ],
                out string match,
                advance: true)
            && scanner.MatchWhiteSpace(minimum: 1, advance: true))
        {
            matched = true;
            if (match == "stage")
                isStaged = true;
            else if (match == "compose")
                isCompose = true;
            else if (match == "stream")
                streamKind = StreamKind.Stream;
            else if (match == "patchstream")
                streamKind = StreamKind.PatchStream;
            else if (match == "linear")
                interpolation = InterpolationModifier.Linear;
            else if (match == "centroid")
                interpolation = InterpolationModifier.Centroid;
            else if (match == "nointerpolation")
                interpolation = InterpolationModifier.NoInterpolation;
            else if (match == "noperspective")
                interpolation = InterpolationModifier.NoPerspective;
            else if (match == "sample")
                interpolation = InterpolationModifier.Sample;
            else if (match == "extern")
                storageClass = StorageClass.Extern;
            else if (match == "nointerpolation")
                storageClass = StorageClass.NoInterpolation;
            else if (match == "precise")
                storageClass = StorageClass.Precise;
            else if (match == "shared")
                storageClass = StorageClass.Shared;
            else if (match == "groupshared")
                storageClass = StorageClass.GroupShared;
            else if (match == "static")
                storageClass = StorageClass.Static;
            else if (match == "uniform")
                storageClass = StorageClass.Uniform;
            else if (match == "volatile")
                storageClass = StorageClass.Volatile;
            else if (match == "const")
                typeModifier = TypeModifier.Const;
            else if (match == "rowmajor")
                typeModifier = TypeModifier.RowMajor;
            else if (match == "columnmajor")
                typeModifier = TypeModifier.ColumnMajor;
            else break;
        }
        if (!advance)
            scanner.Backtrack(position);
        return matched;
    }


    public static bool IdentifierArraySizeOptionalValue(ref Scanner scanner, ParseResult result, out Identifier identifier, out List<Expression> arraySizes, out Expression? value, bool advance = true)

    {
        var position = scanner.Position;
        arraySizes = null!;
        value = null!;

        if (
            LiteralsParser.Identifier(ref scanner, result, out identifier)
            && !scanner.FollowedBy('.', withSpaces: true, advance: true)
        )
        {
            var tmp = scanner.Position;
            scanner.MatchWhiteSpace(advance: true);
            if (!FollowedByDelList(ref scanner, result, ArraySizes, out arraySizes, withSpaces: true, advance: true))
            {
                scanner.Backtrack(tmp);
            }
            tmp = scanner.Position;
            if (
                !(
                    scanner.FollowedBy('=', withSpaces: true, advance: true)
                    && FollowedBy(ref scanner, result, ExpressionParser.Expression, out value, withSpaces: true, advance: true)
                )
            )
            {
                scanner.Backtrack(tmp);
            }
            if (!advance)
                scanner.Backtrack(position);
            return true;
        }
        else
        {
            scanner.Backtrack(position);
            identifier = null!;
            arraySizes = null!;
            return false;
        }
    }
    public static bool TypeNameIdentifierArraySizeValue(ref Scanner scanner, ParseResult result, out TypeName typeName, out Identifier identifier, out Expression? value, bool advance = true)

    {
        var position = scanner.Position;
        value = null!;

        if (
            LiteralsParser.TypeName(ref scanner, result, out typeName)
            && scanner.MatchWhiteSpace(minimum: 1, advance: true)
            && LiteralsParser.Identifier(ref scanner, result, out identifier))
        {
            var tmp = scanner.Position;
            scanner.MatchWhiteSpace(advance: true);
            if (FollowedByDelList(ref scanner, result, ArraySizes, out List<Expression> arraySize, withSpaces: true, advance: true))
                typeName.ArraySize = arraySize;
            else
                scanner.Backtrack(tmp);
            tmp = scanner.Position;
            if (
                !(
                    scanner.FollowedBy('=', withSpaces: true, advance: true)
                    && FollowedBy(ref scanner, result, ExpressionParser.Expression, out value, withSpaces: true, advance: true)
                )
            )
            {
                scanner.Backtrack(tmp);
            }
            if (!advance)
                scanner.Backtrack(position);
            return true;
        }
        else
        {
            scanner.Backtrack(position);
            if (
                LiteralsParser.TypeName(ref scanner, result, out typeName)
                && FollowedByDelList(ref scanner, result, ArraySizes, out List<Expression> sizes, withSpaces: true, advance: true)
                && scanner.MatchWhiteSpace(minimum: 1, advance: true)
                && LiteralsParser.Identifier(ref scanner, result, out identifier))
            {
                var tmp = scanner.Position;
                scanner.MatchWhiteSpace(advance: true);
                if (
                    !(
                        scanner.Match('=', advance: true)
                        && scanner.MatchWhiteSpace(advance: true)
                        && ExpressionParser.Expression(ref scanner, result, out value)
                    )
                )
                {
                    scanner.Backtrack(tmp);
                }
                if (!advance)
                    scanner.Backtrack(position);
                return true;
            }
        }
        scanner.Backtrack(position);
        typeName = null!;
        identifier = null!;
        return false;
    }

    public static bool MixinIdentifierArraySizeValue(ref Scanner scanner, ParseResult result, out Mixin mixin, out Identifier identifier, out List<Expression> arraySize, out Expression? value, bool advance = true)

    {
        var position = scanner.Position;
        arraySize = null!;
        value = null!;

        if (
            ShaderClassParsers.Mixin(ref scanner, result, out mixin)
            && scanner.MatchWhiteSpace(minimum: 1, advance: true)
            && LiteralsParser.Identifier(ref scanner, result, out identifier))
        {
            var tmp = scanner.Position;
            scanner.MatchWhiteSpace(advance: true);
            if (!FollowedByDelList(ref scanner, result, ArraySizes, out arraySize, withSpaces: true, advance: true))
            {
                scanner.Backtrack(tmp);
            }
            tmp = scanner.Position;
            if (
                !(
                    scanner.FollowedBy('=', withSpaces: true, advance: true)
                    && FollowedBy(ref scanner, result, ExpressionParser.Expression, out value, withSpaces: true, advance: true)
                )
            )
            {
                scanner.Backtrack(tmp);
            }
            if (!advance)
                scanner.Backtrack(position);
            return true;
        }
        else
        {
            scanner.Backtrack(position);
            if (
                ShaderClassParsers.Mixin(ref scanner, result, out mixin)
                && FollowedByDelList(ref scanner, result, ArraySizes, out List<Expression> sizes, withSpaces: true, advance: true)
                && scanner.MatchWhiteSpace(minimum: 1, advance: true)
                && LiteralsParser.Identifier(ref scanner, result, out identifier))
            {
                var tmp = scanner.Position;
                scanner.MatchWhiteSpace(advance: true);
                if (
                    !(
                        scanner.Match('=', advance: true)
                        && scanner.MatchWhiteSpace(advance: true)
                        && ExpressionParser.Expression(ref scanner, result, out value)
                    )
                )
                {
                    scanner.Backtrack(tmp);
                }
                if (!advance)
                    scanner.Backtrack(position);
                return true;
            }
        }
        scanner.Backtrack(position);
        mixin = null!;
        identifier = null!;
        arraySize = null!;
        return false;
    }

    public static bool ArraySizes(ref Scanner scanner, ParseResult result, out List<Expression> arraySizes, in ParseError? orError = null)

    {
        arraySizes = [];
        while (!scanner.IsEof)
        {
            if (scanner.FollowedBy('[', withSpaces: true, advance: true))
            {
                if (scanner.FollowedBy(']', withSpaces: true, advance: true))
                {
                    arraySizes.Add(new EmptyExpression(scanner[(scanner.Position - 1)..(scanner.Position - 1)]));
                }
                else if (FollowedByDel(ref scanner, result, ExpressionParser.Expression, out Expression arraySize, withSpaces: true, advance: true))
                {
                    arraySizes.Add(arraySize);
                    if (!scanner.FollowedBy(']', withSpaces: true, advance: true))
                        return Exit(ref scanner, result, out arraySizes, scanner.Position);
                }
                else return Exit(ref scanner, result, out arraySizes, scanner.Position);
            }
            else break;
        }
        return arraySizes.Count > 0;
    }

    public static bool TypeNameMixinArraySizeValue(ref Scanner scanner, ParseResult result, out TypeName typeName, out Mixin mixin, out Expression? arraySize, out Expression? value, bool advance = true)

    {
        var position = scanner.Position;
        arraySize = null!;
        value = null!;
        if (
            LiteralsParser.TypeName(ref scanner, result, out typeName)
            && scanner.MatchWhiteSpace(minimum: 1, advance: true)
            && ShaderClassParsers.Mixin(ref scanner, result, out mixin))
        {
            var tmp = scanner.Position;
            scanner.MatchWhiteSpace(advance: true);
            if (
                !(
                    scanner.Match('[', advance: true)
                    && scanner.MatchWhiteSpace(advance: true)
                    && ExpressionParser.Expression(ref scanner, result, out arraySize)
                    && scanner.MatchWhiteSpace(advance: true)
                    && scanner.Match(']', advance: true)
                )
            )
            {
                scanner.Backtrack(tmp);
            }
            tmp = scanner.Position;
            if (
                !(
                    scanner.Match('=', advance: true)
                    && scanner.MatchWhiteSpace(advance: true)
                    && ExpressionParser.Expression(ref scanner, result, out value)
                )
            )
            {
                scanner.Backtrack(tmp);
            }
            if (!advance)
                scanner.Backtrack(position);
            return true;
        }
        else
        {
            scanner.Backtrack(position);
            if (
                LiteralsParser.TypeName(ref scanner, result, out typeName)
                && scanner.FollowedBy('[', withSpaces: true, advance: true)
                && ExpressionParser.Expression(ref scanner, result, out arraySize)
                && scanner.FollowedBy(']', withSpaces: true, advance: true)
                && scanner.MatchWhiteSpace(minimum: 1, advance: true)
                && ShaderClassParsers.Mixin(ref scanner, result, out mixin))
            {
                var tmp = scanner.Position;
                scanner.MatchWhiteSpace(advance: true);
                if (
                    !(
                        scanner.Match('=', advance: true)
                        && scanner.MatchWhiteSpace(advance: true)
                        && ExpressionParser.Expression(ref scanner, result, out value)
                    )
                )
                {
                    scanner.Backtrack(tmp);
                }
                if (!advance)
                    scanner.Backtrack(position);
                return true;
            }
        }
        scanner.Backtrack(position);
        typeName = null!;
        mixin = null!;
        arraySize = null!;
        return false;
    }

    public static bool Optional<TTerminal>(ref Scanner scanner, TTerminal terminal, bool advance = false)

        where TTerminal : struct, IToken
    {
        terminal.Match(ref scanner, advance: advance);
        return true;
    }
    public static bool Optional<TNode>(ref Scanner scanner, IParser<TNode> parser, ParseResult result, out TNode? node)

        where TNode : Node
    {
        parser.Match(ref scanner, result, out node);
        return true;
    }

    public static bool FollowedBy(ref Scanner scanner, ReadOnlySpan<char> literal, bool withSpaces = false, bool advance = false)
    {
        var position = scanner.Position;
        if (withSpaces)
            scanner.MatchWhiteSpace(advance: true);
        if (scanner.Match(literal, advance: advance))
        {
            if (!advance)
                scanner.Backtrack(position);
            return true;
        }
        scanner.Backtrack(position);
        return false;
    }
    public static bool FollowedBy<TTerminal>(ref Scanner scanner, TTerminal terminal, bool withSpaces = false, bool advance = false)
        where TTerminal : struct, IToken
    {
        var position = scanner.Position;
        if (withSpaces)
            scanner.MatchWhiteSpace(advance: true);
        if (terminal.Match(ref scanner, advance: advance))
        {
            if (!advance)
                scanner.Backtrack(position);
            return true;
        }
        scanner.Backtrack(position);
        return false;
    }
    public static bool FollowedByAny(ref Scanner scanner, ReadOnlySpan<string> literals, out string matched, bool withSpaces = false, bool advance = false)

    {
        var position = scanner.Position;
        if (withSpaces)
            scanner.MatchWhiteSpace(advance: true);
        foreach (var l in literals)
        {
            if (scanner.Match(l, advance: advance))
            {
                if (!advance)
                    scanner.Backtrack(position);
                matched = l;
                return true;
            }
        }
        matched = null!;
        scanner.Backtrack(position);
        return false;
    }
    public static bool FollowedByAny(ref Scanner scanner, string literals, out char matched, bool withSpaces = false, bool advance = false)

    {
        var position = scanner.Position;
        if (withSpaces)
            scanner.MatchWhiteSpace(advance: true);
        foreach (var l in literals)
        {
            if (scanner.Match(l, advance: advance))
            {
                if (!advance)
                    scanner.Backtrack(position);
                matched = l;
                return true;
            }
        }
        matched = '0';
        scanner.Backtrack(position);
        return false;
    }
    public static bool FollowedByDel(ref Scanner scanner, ParseResult result, ParserDelegate func, bool withSpaces = false, bool advance = false)

    {
        var position = scanner.Position;
        if (withSpaces)
            scanner.MatchWhiteSpace(advance: true);
        if (func.Invoke(ref scanner, result))
        {
            if (!advance)
                scanner.Backtrack(position);
            return true;
        }
        scanner.Backtrack(position);
        return false;
    }
    public static bool FollowedByDel<TResult>(ref Scanner scanner, ParseResult result, ParserDelegate<TResult> func, out TResult parsed, bool withSpaces = false, bool advance = false)

    {
        var position = scanner.Position;
        if (withSpaces)
            scanner.MatchWhiteSpace(advance: true);
        if (func.Invoke(ref scanner, result, out parsed))
        {
            if (!advance)
                scanner.Backtrack(position);
            return true;
        }
        scanner.Backtrack(position);
        return false;
    }
    public static bool FollowedByDelList<TResult>(ref Scanner scanner, ParseResult result, ParserListDelegate<TResult> func, out List<TResult> parsed, bool withSpaces = false, bool advance = false)

    {
        var position = scanner.Position;
        if (withSpaces)
            scanner.MatchWhiteSpace(advance: true);
        if (func.Invoke(ref scanner, result, out parsed))
        {
            if (!advance)
                scanner.Backtrack(position);
            return true;
        }
        scanner.Backtrack(position);
        return false;
    }
    public static bool FollowedBy<TResult>(ref Scanner scanner, ParseResult result, ParserDelegate<TResult> func, out TResult parsed, bool withSpaces = false, bool advance = false)

    {
        var position = scanner.Position;
        if (withSpaces)
            scanner.MatchWhiteSpace(advance: true);
        if (func.Invoke(ref scanner, result, out parsed))
        {
            if (!advance)
                scanner.Backtrack(position);
            return true;
        }
        scanner.Backtrack(position);
        return false;
    }

    public static bool FollowedBy<TParser, TResult>(ref Scanner scanner, TParser parser, ParseResult result, out TResult parsed, bool withSpaces = false, bool advance = false)

        where TParser : struct, IParser<TResult>
        where TResult : Node
    {
        var position = scanner.Position;
        if (withSpaces)
            scanner.MatchWhiteSpace(advance: true);
        if (parser.Match(ref scanner, result, out parsed))
        {
            if (!advance)
                scanner.Backtrack(position);
            return true;
        }
        scanner.Backtrack(position);
        return false;
    }

    public static bool Until(ref Scanner scanner, char value, bool advance = false)

    {
        while (!scanner.IsEof && !scanner.Match(value, advance))
            scanner.Advance(1);
        return scanner.IsEof;
    }
    public static bool Until(ref Scanner scanner, string value, bool advance = false)

    {
        while (!scanner.IsEof && !scanner.Match(value, advance))
            scanner.Advance(1);
        return scanner.IsEof;
    }
    public static bool Until(ref Scanner scanner, ReadOnlySpan<string> values, bool advance = false)

    {
        while (!scanner.IsEof)
        {
            foreach (var value in values)
                if (scanner.Match(value, advance))
                    return scanner.IsEof;
            scanner.Advance(1);
        }
        return scanner.IsEof;
    }
    public static bool Until<TTerminal1, TTerminal2>(ref Scanner scanner, TTerminal1? terminal1 = null, TTerminal2? terminal2 = null, bool advance = false)
        where TTerminal1 : struct, IToken
        where TTerminal2 : struct, IToken
    {
        var t1 = terminal1 ?? new TTerminal1();
        var t2 = terminal2 ?? new TTerminal2();
        while (!scanner.IsEof && !(t1.Match(ref scanner, advance) || t2.Match(ref scanner, advance)))
            scanner.Advance(1);
        return !scanner.IsEof;
    }
    public static bool Until<TTerminal1, TTerminal2, TTerminal3>(ref Scanner scanner, TTerminal1? terminal1 = null, TTerminal2? terminal2 = null, TTerminal3? terminal3 = null, bool advance = false)

        where TTerminal1 : struct, IToken
        where TTerminal2 : struct, IToken
        where TTerminal3 : struct, IToken
    {
        var t1 = terminal1 ?? new TTerminal1();
        var t2 = terminal2 ?? new TTerminal2();
        var t3 = terminal3 ?? new TTerminal3();
        while (!scanner.IsEof && !(t1.Match(ref scanner, advance) || t2.Match(ref scanner, advance) || t3.Match(ref scanner, advance)))
            scanner.Advance(1);
        return !scanner.IsEof;
    }


    public static bool Repeat<TParser, TNode>(ref Scanner scanner, TParser parser, ParseResult result, out List<TNode> nodes, int minimum, bool withSpaces = false, string? separator = null, in ParseError? orError = null)

        where TParser : struct, IParser<TNode>
        where TNode : Node
    {
        return Repeat(ref scanner, result, (ref Scanner s, ParseResult r, out TNode node, in ParseError? orError) => new TParser().Match(ref s, r, out node, orError), out nodes, minimum, withSpaces, separator, orError);
    }
    public static bool Repeat<TNode>(ref Scanner scanner, ParseResult result, ParserDelegate<TNode> parser, out List<TNode> nodes, int minimum, bool withSpaces = false, string? separator = null, in ParseError? orError = null)

        where TNode : Node
    {
        var position = scanner.Position;
        nodes = [];
        while (!scanner.IsEof)
        {
            if (parser.Invoke(ref scanner, result, out var node))
            {
                nodes.Add(node);
                if (withSpaces)
                    scanner.MatchWhiteSpace(advance: true);
            }
            else break;

            if (separator is not null)
            {
                if (scanner.Match(separator, advance: true))
                {
                    if (withSpaces)
                        scanner.MatchWhiteSpace(advance: true);
                }
                else if (nodes.Count >= minimum)
                    return true;
                else return Exit(ref scanner, result, out nodes, position, orError);
            }
        }
        if (nodes.Count >= minimum)
            return true;
        else return Exit(ref scanner, result, out nodes, position, orError);
    }
}