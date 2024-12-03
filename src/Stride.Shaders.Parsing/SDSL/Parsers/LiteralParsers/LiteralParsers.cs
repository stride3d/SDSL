using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;


public interface ILiteralParser<TResult>
{
    public bool Match<TScanner>(ref TScanner scanner, ParseResult result, out TResult literal, in ParseError? error = null)
        where TScanner : struct, IScanner;
}

public record struct LiteralsParser : IParser<Literal>
{
    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out Literal literal, in ParseError? orError = null)
        where TScanner : struct, IScanner
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
        else return CommonParsers.Exit(ref scanner, result, out literal, position, orError);
    }
    public static bool Literal<TScanner>(ref TScanner scanner, ParseResult result, out Literal literal, in ParseError? orError = null)
        where TScanner : struct, IScanner
        => new LiteralsParser().Match(ref scanner, result, out literal, in orError);
    public static bool Identifier<TScanner>(ref TScanner scanner, ParseResult result, out Identifier identifier, in ParseError? orError = null)
        where TScanner : struct, IScanner
        => new IdentifierParser().Match(ref scanner, result, out identifier, orError);

    public static bool TypeName<TScanner>(ref TScanner scanner, ParseResult result, out Literal name, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        name = null!;
        var position = scanner.Position;
        if (Tokens.Char('_', ref scanner) || Tokens.Letter(ref scanner))
        {
            name = new TypeName("", new(), false);
            scanner.Advance(1);
            while (Tokens.LetterOrDigit(ref scanner) || Tokens.Char('_', ref scanner))
                scanner.Advance(1);
            var identifier = new Identifier(scanner.Memory[position..scanner.Position].ToString(), scanner.GetLocation(position, scanner.Position - position));

            var intermediate = scanner.Position;

            if (CommonParsers.FollowedBy(ref scanner, Tokens.Char('<'), withSpaces: true, advance: true))
            {
                CommonParsers.Spaces0(ref scanner, result, out _);
                CommonParsers.Repeat(ref scanner, result, TypeNameOrNumber, out List<TypeName> generics, 1, withSpaces: true, separator: ",");
                if (!CommonParsers.FollowedBy(ref scanner, Tokens.Char('>'), withSpaces: true, advance: true))
                    return CommonParsers.Exit(ref scanner, result, out name, position);
                ((TypeName)name).Generics = generics;
                intermediate = scanner.Position;
            }


            if (
                CommonParsers.Spaces0(ref scanner, result, out _)
                && Tokens.Char('[', ref scanner, advance: true)
                && CommonParsers.Spaces0(ref scanner, result, out _)
                && CommonParsers.Optional(ref scanner, new ExpressionParser(), result, out _)
                && CommonParsers.Spaces0(ref scanner, result, out _)
                && Tokens.Char(']', ref scanner, advance: true)
            )
            {
                ((TypeName)name).Name = scanner.Memory[position..scanner.Position].ToString().Trim();
                name.Info = scanner.GetLocation(position..scanner.Position);
                ((TypeName)name).IsArray = true;
                return true;
            }
            else
            {
                scanner.Position = intermediate;
                ((TypeName)name).Name = identifier.Name;
                name.Info = scanner.GetLocation(position..scanner.Position);
                ((TypeName)name).IsArray = false;
                return true;
            }
        }
        else return CommonParsers.Exit(ref scanner, result, out name, position, orError);
    }

    public static bool TypeNameOrNumber<TScanner>(ref TScanner scanner, ParseResult result, out TypeName parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        if (TypeName(ref scanner, result, out var typename))
        {
            parsed = (TypeName)typename;
            return true;
        }
        else if (Number(ref scanner, result, out var number))
        {
            parsed = new TypeName(number.ToString() ?? "", number.Info, isArray: false);
            return true;
        }
        else return CommonParsers.Exit(ref scanner, result, out parsed, scanner.Position, orError);
    }

    public static bool Boolean<TScanner>(ref TScanner scanner, ParseResult result, out BoolLiteral number, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        var position = scanner.Position;
        if (Tokens.AnyOf(["true", "false"], ref scanner, out var matched, advance: true))
        {
            number = new(matched == "true", scanner.GetLocation(position..scanner.Position));
            return true;
        }
        else return CommonParsers.Exit(ref scanner, result, out number, scanner.Position, orError);
    }
    public static bool Number<TScanner>(ref TScanner scanner, ParseResult result, out Literal number, in ParseError? orError = null)
        where TScanner : struct, IScanner
        => new NumberParser().Match(ref scanner, result, out number, in orError);

    public static bool Vector<TScanner>(ref TScanner scanner, ParseResult result, out Literal parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        var position = scanner.Position;
        if (
            Tokens.AnyOf(["bool", "half", "float", "double", "short", "ushort", "int", "uint", "long", "ulong"], ref scanner, out var baseType, advance: true)
        )
        {
            var tnPos = scanner.Position;
            if (Tokens.Digit(ref scanner, 2..4, advance: true))
            {
                tnPos = scanner.Position;
                int size = scanner.Span[scanner.Position - 1] - '0';
                if (size < 2 || size > 4)
                    return CommonParsers.Exit(ref scanner, result, out parsed, position, new(SDSLParsingMessages.SDSL0002, scanner.GetErrorLocation(scanner.Position - 1), scanner.Memory));
                CommonParsers.Spaces0(ref scanner, result, out _);
                if (Tokens.Char('(', ref scanner, advance: true))
                {
                    var p = new VectorLiteral(new TypeName(scanner.Memory[position..tnPos].ToString(), scanner.GetLocation(position..tnPos), isArray: false), scanner.GetLocation(..))
                    {
                        TypeName = new(baseType, scanner.GetLocation((tnPos - baseType.Length)..(tnPos - 1)), isArray: false)
                    };
                    while (!scanner.IsEof)
                    {
                        CommonParsers.Spaces0(ref scanner, result, out _);
                        if (Vector(ref scanner, result, out var vec))
                            p.Values.Add(vec);
                        else if (ExpressionParser.Expression(ref scanner, result, out var exp))
                            p.Values.Add(exp);
                        else return CommonParsers.Exit(ref scanner, result, out parsed, position, new(SDSLParsingMessages.SDSL0001, scanner.GetErrorLocation(scanner.Position), scanner.Memory));
                        CommonParsers.Spaces0(ref scanner, result, out _);
                        if (Tokens.Char(',', ref scanner, advance: true))
                            CommonParsers.Spaces0(ref scanner, result, out _);
                        else if (Tokens.Char(')', ref scanner, advance: true))
                            break;
                    }
                    if (scanner.IsEof)
                        return CommonParsers.Exit(ref scanner, result, out parsed, position, new(SDSLParsingMessages.SDSL0004, scanner.GetErrorLocation(scanner.Position), scanner.Memory));
                    if (p.Values.Count != size && p.Values.Count > size)
                        return CommonParsers.Exit(ref scanner, result, out parsed, position, new(SDSLParsingMessages.SDSL0005, scanner.GetErrorLocation(scanner.Position), scanner.Memory));
                    parsed = p;
                    return true;
                }
            }
            else if (
                CommonParsers.FollowedBy(ref scanner, Tokens.Char('('), withSpaces: true, advance: true)
                && CommonParsers.FollowedByDel(ref scanner, result, ExpressionParser.Expression, out Expression value, withSpaces: true, advance: true)
                && CommonParsers.FollowedBy(ref scanner, Tokens.Char(')'), withSpaces: true, advance: true)
            )
            {
                parsed = new VectorLiteral(new TypeName(baseType, scanner.GetLocation(position..tnPos), isArray: false), scanner.GetLocation(position..scanner.Position))
                {
                    Values = [value]
                };
                return true;
            }
            else return CommonParsers.Exit(ref scanner, result, out parsed, position);

        }
        return CommonParsers.Exit(ref scanner, result, out parsed, position, orError);
    }
    public static bool Matrix<TScanner>(ref TScanner scanner, ParseResult result, out MatrixLiteral parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
        => new MatrixParser().Match(ref scanner, result, out parsed, in orError);
    public static bool Integer<TScanner>(ref TScanner scanner, ParseResult result, out Literal number, in ParseError? orError = null)
        where TScanner : struct, IScanner
        => NumberParser.Integer(ref scanner, result, out number, in orError);

    public static bool StringLiteral<TScanner>(ref TScanner scanner, ParseResult result, out StringLiteral parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        var position = scanner.Position;
        if (Tokens.Char('\"', ref scanner, advance: true))
        {
            CommonParsers.Until(ref scanner, '\"', advance: true);
            if (scanner.Span[position..scanner.Position].Contains('\n'))
                return CommonParsers.Exit(ref scanner, result, out parsed, position, new(SDSLParsingMessages.SDSL0001, scanner.GetErrorLocation(position), scanner.Memory));
            parsed = new(scanner.Span[position..scanner.Position].ToString(), scanner.GetLocation(position..scanner.Position));
            return true;
        }
        return CommonParsers.Exit(ref scanner, result, out parsed, position);
    }

    public static bool AssignOperators<TScanner>(ref TScanner scanner, ParseResult result, out AssignOperator op, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        op = AssignOperator.NOp;
        if (
            Tokens.AnyOf(
                ["=", "+=", "-=", "*=", "/=", "%=", "&=", "|=", "^=", "<<=", ">>="],
                ref scanner,
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
    public static bool TryMatchAndAdvance<TScanner>(ref TScanner scanner, string match)
        where TScanner : struct, IScanner
    {
        if (Tokens.Literal(match, ref scanner))
        {
            scanner.Advance(match.Length);
            return true;
        }
        return false;
    }

    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out Suffix suffix, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        suffix = new(32, false, false);
        if (Tokens.AnyOf(["f", "f16", "f32", "f64", "d", "h"], ref scanner, out var matched, advance: true))
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
    public static bool TryMatchAndAdvance<TScanner>(ref TScanner scanner, string match)
        where TScanner : struct, IScanner
    {
        if (Tokens.Literal(match, ref scanner))
        {
            scanner.Advance(match.Length);
            return true;
        }
        return false;
    }

    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out Suffix suffix, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        suffix = new(32, false, false);
        if (Tokens.AnyOf(["u8", "u16", "u32", "u64", "i8", "i16", "i32", "i64", "U", "L"], ref scanner, out var matched, advance: true))
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
                "U" => new(32, false, false),
                "L" => new(32, false, true),
                _ => throw new NotImplementedException()
            };
            return true;
        }
        else return false;
    }
}


public record struct IdentifierParser() : ILiteralParser<Identifier>
{
    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out Identifier literal, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        literal = null!;
        var position = scanner.Position;
        if (Tokens.Char('_', ref scanner) || Tokens.Letter(ref scanner))
        {
            scanner.Advance(1);
            while (Tokens.LetterOrDigit(ref scanner) || Tokens.Char('_', ref scanner))
                scanner.Advance(1);
            var id = scanner.Memory[position..scanner.Position].ToString();
            if (Reserved.Keywords.Contains(id))
                return CommonParsers.Exit(ref scanner, result, out literal, position, orError);
            literal = new(id, scanner.GetLocation(position, scanner.Position - position));
            return true;
        }
        else return false;
    }
}


public record struct MatrixParser : IParser<MatrixLiteral>
{

    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out MatrixLiteral parsed, in ParseError? orError = null) where TScanner : struct, IScanner
    {
        var position = scanner.Position;
        if (
            Tokens.AnyOf(["bool", "half", "float", "double", "short", "ushort", "int", "uint", "long", "ulong"], ref scanner, out var baseType, advance: true)
            && Tokens.Digit(ref scanner, 2..4, advance: true)
            && Tokens.Char('x', ref scanner, advance: true)
            && Tokens.Digit(ref scanner, 2..4, advance: true)
        )
        {
            var tnPos = scanner.Position;
            int rows = scanner.Span[scanner.Position - 3] - '0';
            int cols = scanner.Span[scanner.Position - 1] - '0';
            if (cols < 2 || cols > 4 || rows < 2 || rows > 4)
                return CommonParsers.Exit(ref scanner, result, out parsed, position, new(SDSLParsingMessages.SDSL0006, scanner.GetErrorLocation(scanner.Position - 1), scanner.Memory));
            CommonParsers.Spaces0(ref scanner, result, out _);
            if (Tokens.Char('(', ref scanner, advance: true))
            {
                var p = new MatrixLiteral(new TypeName(scanner.Memory[position..tnPos].ToString(), scanner.GetLocation(position..tnPos), isArray: false), rows, cols, scanner.GetLocation(..))
                {
                    TypeName = new(baseType, scanner.GetLocation((tnPos - baseType.Length)..(tnPos - 1)), isArray: false)
                };
                while (!scanner.IsEof)
                {
                    CommonParsers.Spaces0(ref scanner, result, out _);

                    if (LiteralsParser.Vector(ref scanner, result, out var vector))
                        p.Values.Add(vector);
                    else if (ExpressionParser.Expression(ref scanner, result, out var expression))
                        p.Values.Add(expression);
                    else return CommonParsers.Exit(ref scanner, result, out parsed, position, orError);
                    CommonParsers.Spaces0(ref scanner, result, out _);
                    if (Tokens.Char(',', ref scanner, advance: true))
                        CommonParsers.Spaces0(ref scanner, result, out _);
                    else if (Tokens.Char(')', ref scanner, advance: true))
                        break;
                }
                if (scanner.IsEof)
                    return CommonParsers.Exit(ref scanner, result, out parsed, position, new(SDSLParsingMessages.SDSL0008, scanner.GetErrorLocation(scanner.Position), scanner.Memory));
                if (p.Values.Count != rows * cols && p.Values.Count > rows * cols)
                    return CommonParsers.Exit(ref scanner, result, out parsed, position, new(SDSLParsingMessages.SDSL0002, scanner.GetErrorLocation(scanner.Position), scanner.Memory));
                parsed = p;
                return true;
            }

        }
        return CommonParsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}