using Stride.Shaders.Parsing.SDSL.AST;
using System.Globalization;

namespace Stride.Shaders.Parsing.SDSL;


public struct NumberParser : IParser<Literal>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Literal parsed, in ParseError? orError = null)
    {
        return Parsers.Alternatives(
            ref scanner,
            result,
            out parsed,
            orError,
            Hex,
            Float,
            Integer
        );
    }

    public static bool Integer(ref Scanner scanner, ParseResult result, out Literal parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (scanner.MatchDigit(1.., advance: true))
        {
            while (scanner.MatchDigit(advance: true)) ;

            var numPos = scanner.Position;
            if (scanner.MatchIntSuffix(out Suffix? suf, true))
            {
                parsed = new IntegerLiteral(suf!.Value, long.Parse(scanner.Span[position..numPos]), scanner[position..scanner.Position]);
                return true;
            }
            else
            {
                var memory = scanner.Memory[position..scanner.Position];
                parsed = new IntegerLiteral(new(32, false, true), long.Parse(memory.Span), new(scanner.Memory, position..scanner.Position));
                return true;
            }
        }
        else if (scanner.Match('0', advance: true) && !scanner.MatchDigit())
        {
            parsed = new IntegerLiteral(new(32, false, true), 0, new(scanner.Memory, position..scanner.Position));
            return true;
        }
        else return scanner.Backtrack(position, result, out parsed, orError);
    }
    public static bool Float(ref Scanner scanner, ParseResult result, out Literal parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (scanner.Match('.', advance: true))
        {
            if (!scanner.MatchDigit())
                return scanner.Backtrack(position, result, out parsed);
            while (scanner.MatchDigit(advance: true)) ;
        }
        else if (scanner.MatchDigit(1.., advance: true))
        {
            while (scanner.MatchDigit(advance: true)) ;
            if (scanner.Match('.'))
            {
                scanner.Advance(1);
                if (!scanner.MatchDigit() && !scanner.MatchFloatSuffix(out _))
                    return scanner.Backtrack(position, result, out parsed, new(SDSLErrorMessages.SDSL0001, scanner[scanner.Position], scanner.Memory));
                while (scanner.MatchDigit(advance: true)) ;
            }
            else if (scanner.MatchFloatSuffix(out _) || scanner.Match('e')) { }
            else return scanner.Backtrack(position, result, out parsed);
        }
        else if (scanner.MatchDigit(0..0, advance: true))
        {
            if (scanner.Match('.', advance: true))
            {
                if (!scanner.MatchDigit() && !scanner.MatchFloatSuffix(out _))
                    return scanner.Backtrack(position, result, out parsed, new(SDSLErrorMessages.SDSL0001, scanner[scanner.Position], scanner.Memory));
                while (scanner.MatchDigit(advance: true)) ;
            }
            else return scanner.Backtrack(position, result, out parsed);
        }
        else return scanner.Backtrack(position, result, out parsed);


        var value = double.Parse(scanner.Span[position..scanner.Position], CultureInfo.InvariantCulture);
        int? exponent = null;
        if (scanner.Match('e', advance: true))
        {
            var signed = scanner.MatchAnyOf(["+", "-"], out var matched, advance: true);
            if (Integer(ref scanner, result, out var exp))
            {
                exponent = (int)((IntegerLiteral)exp).Value;
                if (signed && matched == "-")
                    exponent = -exponent;
            }
            else return scanner.Backtrack(position, result, out parsed, new(SDSLErrorMessages.SDSL0001, scanner[scanner.Position], scanner.Memory));
        }
        if (scanner.MatchFloatSuffix(out var suffix, advance: true) && suffix is not null)
            parsed = new FloatLiteral(suffix.Value, value, exponent, scanner[position..scanner.Position]);
        else
            parsed = new FloatLiteral(new(32, true, true), value, exponent, scanner[position..scanner.Position]);
        return true;
    }
    public static bool Hex(ref Scanner scanner, ParseResult result, out Literal parsed, in ParseError? orError = null)
    {
        parsed = null!;
        var position = scanner.Position;
        if (scanner.Match("0x", advance: true))
        {
            while (scanner.MatchSet("abcdefABCDEF", advance: true) || scanner.MatchDigit(advance: true)) ;

            ulong sum = 0;

            for (int i = position + 2; i < scanner.Position; i++)
            {
                // Check if multiplying by 16 would not overflow ulong
                if ((sum & ~(ulong)long.MaxValue) != 0)
                {
                    result.Errors.Add(new ParseError("Hex value bigger than ulong.", scanner[i], scanner.Memory));
                    return false;
                }

                sum <<= 4;
                var v = Hex2int(scanner.Span[i]);
                sum += (uint)v;
            }
            parsed = new HexLiteral(sum, scanner[position..scanner.Position]);
            return true;
        }
        else return scanner.Backtrack(position, result, out parsed, orError);
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

