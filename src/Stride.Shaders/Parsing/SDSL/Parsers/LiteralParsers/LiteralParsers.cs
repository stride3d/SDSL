using Stride.Shaders.Core;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;


public interface ILiteralParser<TResult>
{
    public bool Match(ref Scanner scanner, ParseResult result, out TResult literal, in ParseError? error = null);
}

public record struct LiteralsParser : IParser<Literal>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Literal literal, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (Vector(ref scanner, result, out var v, orError))
        {
            literal = v;
            return true;
        }
        else if (Matrix(ref scanner, result, out var m, orError))
        {
            literal = m;
            return true;
        }
        else if (Identifier(ref scanner, result, out var i, orError))
        {
            literal = i;
            return true;
        }
        else if (Number(ref scanner, result, out var n, orError))
        {
            literal = n;
            return true;
        }
        else if (Boolean(ref scanner, result, out var b, orError))
        {
            literal = b;
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out literal, position, orError);
    }
    public static bool Literal(ref Scanner scanner, ParseResult result, out Literal literal, in ParseError? orError = null)
        => new LiteralsParser().Match(ref scanner, result, out literal, in orError);
    public static bool Identifier(ref Scanner scanner, ParseResult result, out Identifier identifier, in ParseError? orError = null)
        => new IdentifierParser().Match(ref scanner, result, out identifier, orError);


    public static bool TypeNameLiteral(ref Scanner scanner, ParseResult result, out Literal parsed, in ParseError? orError = null)
    {
        parsed = null!;
        if(TypeNameLiteral(ref scanner, result, out var tn, orError))
        {
            parsed = tn;
            return true;
        }
        else return false;
    }
    public static bool TypeName(ref Scanner scanner, ParseResult result, out TypeName name, in ParseError? orError = null)
    {
        name = null!;
        var position = scanner.Position;
        if (scanner.Match('_') || scanner.MatchLetter())
        {
            scanner.Advance(1);
            while (scanner.MatchLetterOrDigit() || scanner.Match('_'))
                scanner.Advance(1);
            var identifier = new Identifier(scanner.Memory[position..scanner.Position].ToString(), scanner[position..scanner.Position]);
            name = new TypeName(identifier.Name, scanner[position..scanner.Position]);

            var intermediate = scanner.Position;

            if (scanner.FollowedBy('<', withSpaces: true, advance: true))
            {
                scanner.MatchWhiteSpace(advance: true);
                Parsers.Repeat(ref scanner, result, TypeNameOrNumber, out List<Literal> generics, 1, withSpaces: true, separator: ",");
                if (!scanner.FollowedBy('>', withSpaces: true, advance: true))
                    return Parsers.Exit(ref scanner, result, out name, position);
                name.Info = scanner[position..scanner.Position];
                name.Generics = generics;
                intermediate = scanner.Position;
            }
            else
            {
                scanner.Backtrack(intermediate);
            }

            if (Parsers.FollowedByDelList(ref scanner, result, Parsers.ArraySizes, out List<Expression> arraySize, withSpaces: true, advance: true))
            {
                name.Info = scanner[position..scanner.Position];
                name.ArraySize = arraySize;
            }
            else
            {
                scanner.Backtrack(intermediate);
            }

            return true;
        }
        else return Parsers.Exit(ref scanner, result, out name, position, orError);
    }

    public static bool TypeNameOrNumber(ref Scanner scanner, ParseResult result, out Literal parsed, in ParseError? orError = null)
    {
        if (TypeName(ref scanner, result, out var typename))
        {
            parsed = typename;
            return true;
        }
        else if (Number(ref scanner, result, out var number))
        {
            parsed = number;
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out parsed, scanner.Position, orError);
    }

    public static bool Boolean(ref Scanner scanner, ParseResult result, out BoolLiteral number, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (scanner.MatchAnyOf(["true", "false"], out var matched, advance: true))
        {
            number = new(matched == "true", scanner[position..scanner.Position]);
            return true;
        }
        else return Parsers.Exit(ref scanner, result, out number, scanner.Position, orError);
    }
    public static bool Number(ref Scanner scanner, ParseResult result, out Literal number, in ParseError? orError = null)
        => new NumberParser().Match(ref scanner, result, out number, in orError);

    public static bool Vector(ref Scanner scanner, ParseResult result, out Literal parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            scanner.MatchAnyOf(["bool", "half", "float", "double", "short", "ushort", "int", "uint", "long", "ulong"], out var baseType, advance: true)
        )
        {
            var tnPos = scanner.Position;
            if (scanner.MatchDigit(2..4, advance: true))
            {
                tnPos = scanner.Position;
                int size = scanner.Span[scanner.Position - 1] - '0';
                if (size < 2 || size > 4)
                    return scanner.Backtrack(position, result, out parsed, new(SDSLErrorMessages.SDSL0002, scanner[scanner.Position - 1], scanner.Memory));
                scanner.MatchWhiteSpace(advance: true);
                if (scanner.Match('(', advance: true))
                {
                    var p = new VectorLiteral(new TypeName(scanner.Memory[position..tnPos].ToString(), scanner[position..tnPos]), scanner[..]);
                    while (!scanner.IsEof)
                    {
                        scanner.MatchWhiteSpace(advance: true);
                        if (Vector(ref scanner, result, out var vec))
                            p.Values.Add(vec);
                        else if (ExpressionParser.Expression(ref scanner, result, out var exp))
                            p.Values.Add(exp);
                        else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0001, scanner[scanner.Position], scanner.Memory));
                        scanner.MatchWhiteSpace(advance: true);
                        if (scanner.Match(',', advance: true))
                            scanner.MatchWhiteSpace(advance: true);
                        else if (scanner.Match(')', advance: true))
                            break;
                    }
                    if (scanner.IsEof && scanner.Span[scanner.Position - 1] != ')')
                        return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0004, scanner[scanner.Position], scanner.Memory));
                    if (p.Values.Count != size && p.Values.Count > size)
                        return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0005, scanner[scanner.Position], scanner.Memory));
                    parsed = p;
                    return true;
                }
            }
            else if (
                scanner.FollowedBy('(', withSpaces: true, advance: true)
                && scanner.FollowedBy(result, ExpressionParser.Expression, out Expression value, withSpaces: true, advance: true)
                && scanner.FollowedBy(')', withSpaces: true, advance: true)
            )
            {
                parsed = new ExpressionLiteral(value, new TypeName(baseType, scanner[position..tnPos]), scanner[position..scanner.Position]);
                return true;
            }
            else return Parsers.Exit(ref scanner, result, out parsed, position);

        }
        return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
    public static bool Matrix(ref Scanner scanner, ParseResult result, out MatrixLiteral parsed, in ParseError? orError = null)
        => new MatrixParser().Match(ref scanner, result, out parsed, in orError);
    public static bool Integer(ref Scanner scanner, ParseResult result, out Literal number, in ParseError? orError = null)
        => NumberParser.Integer(ref scanner, result, out number, in orError);

    public static bool StringLiteral(ref Scanner scanner, ParseResult result, out StringLiteral parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (scanner.Match('\"', advance: true))
        {
            var strStart = scanner.Position;
            Parsers.Until(ref scanner, '\"', advance: false);
            var strEnd = scanner.Position;
            if (scanner.Match('\"', advance: true))
            {
                if (scanner.Span[position..scanner.Position].Contains('\n'))
                    return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0001, scanner[position], scanner.Memory));
                parsed = new(scanner.Span[strStart..strEnd].ToString(), scanner[position..scanner.Position]);
                return true;
            }
        }
        return Parsers.Exit(ref scanner, result, out parsed, position);
    }

    public static bool AssignOperators(ref Scanner scanner, ParseResult result, out AssignOperator op, in ParseError? orError = null)
    {
        op = AssignOperator.NOp;
        if (
            scanner.MatchAnyOf(
                ["=", "+=", "-=", "*=", "/=", "%=", "&=", "|=", "^=", "<<=", ">>="],
                out var matched,
                advance: true
            )
        )
        {
            op = matched.ToAssignOperator();
            return true;
        }
        else return false;
    }

}


public record struct Suffix(int Size, bool IsFloatingPoint, bool Signed)
{
    public readonly override string ToString()
    {
        return (IsFloatingPoint, Signed) switch
        {
            (true, _) => $"f{Size}",
            (false, false) => $"u{Size}",
            (false, true) => $"i{Size}",
        };
    }
}

public readonly record struct FloatSuffixParser() : ILiteralParser<Suffix>
{
    public static bool TryMatchAndAdvance(ref Scanner scanner, string match)
    {
        if (scanner.Match(match))
        {
            scanner.Advance(match.Length);
            return true;
        }
        return false;
    }

    public readonly bool Match(ref Scanner scanner, ParseResult result, out Suffix suffix, in ParseError? orError = null)
    {
        suffix = new(32, false, false);
        if (scanner.MatchAnyOf(["f", "f16", "f32", "f64", "d", "h"], out var matched, advance: true))
        {
            suffix = matched switch
            {
                "f16" or "h" => new(16, true, true),
                "f32" or "f" => new(32, true, true),
                "f64" or "d" => new(64, true, true),

                _ => throw new NotImplementedException()
            };
            return true;
        }
        else return false;
    }
}

public readonly record struct IntegerSuffixParser() : ILiteralParser<Suffix>
{
    public static bool TryMatchAndAdvance(ref Scanner scanner, string match)
    {
        if (scanner.Match(match))
        {
            scanner.Advance(match.Length);
            return true;
        }
        return false;
    }

    public readonly bool Match(ref Scanner scanner, ParseResult result, out Suffix suffix, in ParseError? orError = null)
    {
        suffix = new(32, false, false);
        if (scanner.MatchAnyOf(["u8", "u16", "u32", "u64", "i8", "i16", "i32", "i64", "u", "U", "l", "L"], out var matched, advance: true))
        {
            suffix = matched switch
            {
                "u8" => new(8, false, false),
                "u16" => new(16, false, false),
                "u32" => new(32, false, false),
                "u64" => new(64, false, false),
                "i8" => new(8, false, true),
                "i16" => new(16, false, true),
                "i32" => new(32, false, true),
                "i64" => new(64, false, true),
                "u" or "U" => new(32, false, false),
                "l" or "L" => new(32, false, true),
                _ => throw new NotImplementedException()
            };
            return true;
        }
        else return false;
    }
}


public record struct IdentifierParser() : ILiteralParser<Identifier>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Identifier literal, in ParseError? orError = null)
    {
        literal = null!;
        var position = scanner.Position;
        if (scanner.Match('_') || scanner.MatchLetter())
        {
            scanner.Advance(1);
            while (scanner.MatchLetterOrDigit() || scanner.Match('_'))
                scanner.Advance(1);
            var id = scanner.Memory[position..scanner.Position].ToString();
            if (Reserved.Keywords.Contains(id))
                return Parsers.Exit(ref scanner, result, out literal, position, orError);
            literal = new(id, scanner[position..scanner.Position]);
            return true;
        }
        else return false;
    }
}


public record struct MatrixParser : IParser<MatrixLiteral>
{

    public readonly bool Match(ref Scanner scanner, ParseResult result, out MatrixLiteral parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            scanner.MatchAnyOf(["bool", "half", "float", "double", "short", "ushort", "int", "uint", "long", "ulong"], out var baseType, advance: true)
            && scanner.MatchDigit(2..4, advance: true)
            && scanner.Match('x', advance: true)
            && scanner.MatchDigit(2..4, advance: true)
        )
        {
            var tnPos = scanner.Position;
            int rows = scanner.Span[scanner.Position - 3] - '0';
            int cols = scanner.Span[scanner.Position - 1] - '0';
            if (cols < 2 || cols > 4 || rows < 2 || rows > 4)
                return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0006, scanner[scanner.Position - 1], scanner.Memory));
            scanner.MatchWhiteSpace(advance: true);
            if (scanner.Match('(', advance: true))
            {
                var p = new MatrixLiteral(new TypeName(scanner.Memory[position..tnPos].ToString(), scanner[position..tnPos]), rows, cols, scanner[..]);
                while (!scanner.IsEof)
                {
                    scanner.MatchWhiteSpace(advance: true);

                    if (LiteralsParser.Vector(ref scanner, result, out var vector))
                        p.Values.Add(vector);
                    else if (ExpressionParser.Expression(ref scanner, result, out var expression))
                        p.Values.Add(expression);
                    else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
                    scanner.MatchWhiteSpace(advance: true);
                    if (scanner.Match(',', advance: true))
                        scanner.MatchWhiteSpace(advance: true);
                    else if (scanner.Match(')', advance: true))
                        break;
                }
                if (scanner.IsEof && scanner.Span[scanner.Position - 1] != ')')
                    return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0008, scanner[scanner.Position], scanner.Memory));
                if (p.Values.Count != rows * cols && p.Values.Count > rows * cols)
                    return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0002, scanner[scanner.Position], scanner.Memory));
                parsed = p;
                return true;
            }

        }
        return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}