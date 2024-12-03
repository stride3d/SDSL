using Stride.Shaders.Parsing.SDSL.AST;
using System.Globalization;

namespace Stride.Shaders.Parsing.SDSL;


public struct NumberParser : IParser<NumberLiteral>
{
    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out NumberLiteral parsed, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        var position = scanner.Position;
        var fp = new FloatParser();
        var ip = new IntegerParser();
        var hx = new HexParser();

        if (fp.Match(ref scanner, result, out FloatLiteral pf))
        {
            parsed = pf;
            return true;
        }
        else if (hx.Match(ref scanner, result, out HexLiteral hi))
        {
            parsed = hi;
            return true;
        }
        else if (ip.Match(ref scanner, result, out IntegerLiteral pi))
        {
            parsed = pi;
            return true;
        }
        else return CommonParsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}

public struct IntegerParser : IParser<IntegerLiteral>
{
    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out IntegerLiteral node, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        var position = scanner.Position;
        IntegerSuffixParser suffix = new();
        if (Tokens.Digit(ref scanner, 1.., advance: true))
        {
            while (Tokens.Digit(ref scanner, advance: true)) ;

            var numPos = scanner.Position;
            if (suffix.Match(ref scanner, null!, out Suffix suf))
            {
                node = new(suf, long.Parse(scanner.Span[position..numPos]), scanner.GetLocation(position, scanner.Position));
                return true;
            }
            else
            {
                var memory = scanner.Memory[position..scanner.Position];
                node = new(new(32, false, true), long.Parse(memory.Span), new(scanner.Memory, position..scanner.Position));
                return true;
            }
        }
        else if (Tokens.Char('0', ref scanner, advance: true) && !Tokens.Digit(ref scanner, ..))
        {
            node = new(new(32, false, true), 0, new(scanner.Memory, position..scanner.Position));
            return true;
        }
        else return CommonParsers.Exit(ref scanner, result, out node, position, orError);
    }
}

public struct FloatParser : IParser<FloatLiteral>
{
    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out FloatLiteral node, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        var position = scanner.Position;
        if (Tokens.Char('.', ref scanner, advance: true))
        {
            if (!Tokens.Digit(ref scanner))
                return CommonParsers.Exit(ref scanner, result, out node, position);
            while (Tokens.Digit(ref scanner, advance: true)) ;
        }
        else if (Tokens.Digit(ref scanner, 1.., advance: true))
        {
            while (Tokens.Digit(ref scanner, advance: true)) ;
            if (Tokens.Char('.', ref scanner))
            {
                scanner.Advance(1);
                if (!Tokens.Digit(ref scanner) && !Tokens.FloatSuffix(ref scanner, out _))
                    return CommonParsers.Exit(ref scanner, result, out node, position, new(SDSLParsingMessages.SDSL0001, scanner.GetErrorLocation(scanner.Position), scanner.Memory));
                while (Tokens.Digit(ref scanner, advance: true)) ;
            }
            else if (Tokens.FloatSuffix(ref scanner, out _) || Tokens.Char('e', ref scanner)){}
            else return CommonParsers.Exit(ref scanner, result, out node, position);
        }
        else if (Tokens.Digit(ref scanner, 0, advance: true))
        {
            if (Tokens.Char('.', ref scanner, advance: true))
            {
                if (!Tokens.Digit(ref scanner) && !Tokens.FloatSuffix(ref scanner, out _))
                    return CommonParsers.Exit(ref scanner, result, out node, position, new(SDSLParsingMessages.SDSL0001, scanner.GetErrorLocation(scanner.Position), scanner.Memory));
                while (Tokens.Digit(ref scanner, advance: true)) ;
            }
            else return CommonParsers.Exit(ref scanner, result, out node, position);
        }
        else return CommonParsers.Exit(ref scanner, result, out node, position);


        var value = double.Parse(scanner.Span[position..scanner.Position], CultureInfo.InvariantCulture);
        int? exponent = null;
        if (Tokens.Char('e', ref scanner, advance: true))
        {
            var signed = Tokens.AnyOf(["+", "-"], ref scanner, out var matched, advance: true);
            if (LiteralsParser.Integer(ref scanner, result, out var exp))
            {
                exponent = (int)exp.Value;
                if(signed && matched == "-")
                    exponent = -exponent;
            }
            else return CommonParsers.Exit(ref scanner, result, out node, position, new(SDSLParsingMessages.SDSL0001, scanner.GetErrorLocation(scanner.Position), scanner.Memory));
        }
        if (Tokens.FloatSuffix(ref scanner, out var suffix, advance: true) && suffix is not null)
            node = new(suffix.Value, value, exponent, scanner.GetLocation(position..scanner.Position));
        else
            node = new(new(32, true, true), value, exponent, scanner.GetLocation(position..scanner.Position));
        return true;
    }
}

public struct HexParser : IParser<HexLiteral>
{
    public readonly bool Match<TScanner>(ref TScanner scanner, ParseResult result, out HexLiteral node, in ParseError? orError = null)
        where TScanner : struct, IScanner
    {
        node = null!;
        var position = scanner.Position;
        if (Tokens.Literal("0x", ref scanner, advance: true))
        {
            while (Tokens.Set("abcdefABCDEF", ref scanner, advance: true) || Tokens.Digit(ref scanner, advance: true)) ;

            ulong sum = 0;

            for (int i = 0; i < scanner.Position - position - 2; i += 1)
            {
                var v = Hex2int(scanner.Span[i]);
                var add = v * Math.Pow(16, i);
                if (ulong.MaxValue - sum < add)
                {
                    result.Errors.Add(new ParseError("Hex value bigger than ulong.", scanner.GetErrorLocation(position), scanner.Memory));
                    return false;
                }
            }
            node = new HexLiteral(sum, scanner.GetLocation(position, scanner.Position - position));
            return true;
        }
        else return CommonParsers.Exit(ref scanner, result, out node, position, orError);
    }

    static int Hex2int(char ch)
    {
        if (ch >= '0' && ch <= '9')
            return ch - '0';
        if (ch >= 'A' && ch <= 'F')
            return ch - 'A' + 10;
        if (ch >= 'a' && ch <= 'f')
            return ch - 'a' + 10;
        return -1;
    }
}