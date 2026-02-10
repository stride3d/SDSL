
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Stride.Shaders.Parsing.SDSL;




public static class ScannerExtensions
{
    public static bool IsBetween(this int v, Range range)
        => v >= range.Start.Value && v <= range.End.Value;
    public static bool AnyChar(this ref Scanner scanner, bool advance = false)
    {
        scanner.Advance(advance && !scanner.IsEof ? 1 : 0);
        return scanner.IsEof;
    }

    public static bool Match(this ref Scanner scanner, char c, bool advance = false)
        => scanner.Match([c], advance);
    public static bool Match(this ref Scanner scanner, ReadOnlySpan<char> chars, bool advance = false)
    {
        if (scanner.Peek(chars.Length).SequenceEqual(chars))
        {
            if (advance)
                scanner.Advance(chars.Length);
            return true;
        }
        return false;
    }

    public static bool MatchSet(this ref Scanner scanner, ReadOnlySpan<char> set, bool advance = false)
    {
        if (!scanner.IsEof && set.Contains(scanner.Peek()))
        {
            if (advance)
                scanner.Advance();
            return true;
        }
        return false;
    }

    public static bool MatchLetter(this ref Scanner scanner, bool advance = false)
        => !scanner.IsEof && char.IsLetter(scanner.Peek()) && scanner.Advance(advance ? 1 : 0);

    public static bool MatchLetter(this ref Scanner scanner, Range range, bool advance = false)
        => !scanner.IsEof && char.IsLetter(scanner.Peek()) && (scanner.Peek() - '\0').IsBetween(range) && scanner.Advance(advance ? 1 : 0);

    public static bool MatchDigit(this ref Scanner scanner, bool advance = false)
        => !scanner.IsEof && char.IsDigit(scanner.Peek()) && scanner.Advance(advance ? 1 : 0);

    public static bool MatchDigit(this ref Scanner scanner, Range range, bool advance = false)
        => !scanner.IsEof && (scanner.Peek() - '\0').IsBetween(range) && scanner.Advance(advance ? 1 : 0);


    public static bool MatchLetterOrDigit(this ref Scanner scanner, bool advance = false)
        => !scanner.IsEof && char.IsLetterOrDigit(scanner.Peek()) && scanner.Advance(advance ? 1 : 0);


    public static bool MatchAnyOf(this ref Scanner scanner, ReadOnlySpan<string> options, out string matched, bool advance = false)
    {
        foreach (var option in options)
        {
            if (scanner.Peek(option.Length).SequenceEqual(option))
            {
                matched = option;
                if (advance)
                    scanner.Advance(option.Length);
                return true;
            }
        }
        matched = null!;
        return false;
    }

    public static bool MatchFloatSuffix(this ref Scanner scanner, out Suffix? suffix, bool advance = false)
    {
        suffix = null;
        if (scanner.MatchAnyOf(["f16", "h", "f32", "f", "f64", "d"], out var matched, advance: advance))
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
    public static bool MatchIntSuffix(this ref Scanner scanner, out Suffix? suffix, bool advance = false)
    {
        suffix = null;
        if (scanner.MatchAnyOf(["u32", "u", "U", "i64", "l", "L", "u64", "ul", "UL"], out var matched, advance: advance))
        {
            suffix = matched switch
            {
                "u32" or "u" or "U" => new(32, false, false),
                "i64" or "l" or "L" => new(64, false, true),
                "u64" or "ul" or "UL" => new(64, false, false),
                _ => throw new NotImplementedException()
            };
            return true;
        }
        else return false;
    }


    public static bool MatchWhiteSpace(this ref Scanner scanner, int minimum = 0, bool advance = false)
    {
        var start = scanner.Position;
        while (!scanner.IsEof && char.IsWhiteSpace(scanner.Peek()))
            scanner.Advance();
        if (scanner.Position - start >= minimum)
        {
            if (!advance)
                scanner.Backtrack(start);
            return true;
        }
        return scanner.Backtrack(start);
    }

    public static bool MatchUntil(this ref Scanner scanner, char until, bool advance = false)
    {
        var start = scanner.Position;
        while (!scanner.IsEof && scanner.Peek() != until)
            scanner.Advance();
        if (!scanner.IsEof)
        {
            if (!advance)
                scanner.Backtrack(start);
            return true;
        }
        return scanner.Backtrack(start);
    }

    public static bool Match<T>(this ref Scanner scanner, ParseResult result, out T parsed, in ParseError? orError = null)
        where T : Node, IStrideParser<T>
    {
        if(T.Match(ref scanner, result, out parsed))
            return true;
        if (orError is not null)
            result.Errors.Add(orError.Value);
        return false;
    }

    public static bool MatchOr<T1, T2, TOut>(this ref Scanner scanner, ParseResult result, out TOut parsed, in ParseError? orError = null)
        where T1 : TOut, IStrideParser<T1>
        where T2 : TOut, IStrideParser<T2>
        where TOut : Node
    {
        if(T1.Match(ref scanner, result, out T1 parsed1))
        {
            parsed = parsed1;
            return true;
        }
        else if(T2.Match(ref scanner, result, out T2 parsed2))
        {
            parsed = parsed2;
            return true;
        }
        if (orError is not null)
            result.Errors.Add(orError.Value);
        parsed = default!;
        return false;
    }
    public static bool MatchOr<T1, T2, T3, TOut>(this ref Scanner scanner, ParseResult result, out TOut parsed, in ParseError? orError = null)
        where T1 : TOut, IStrideParser<T1>
        where T2 : TOut, IStrideParser<T2>
        where T3 : TOut, IStrideParser<T3>
        where TOut : Node
    {
        if(T1.Match(ref scanner, result, out T1 parsed1))
        {
            parsed = parsed1;
            return true;
        }
        else if(T2.Match(ref scanner, result, out T2 parsed2))
        {
            parsed = parsed2;
            return true;
        }
        else if(T3.Match(ref scanner, result, out T3 parsed3))
        {
            parsed = parsed3;
            return true;
        }
        if (orError is not null)
            result.Errors.Add(orError.Value);
        parsed = default!;
        return false;
    }
    public static bool MatchOr<T1, T2, T3, T4, TOut>(this ref Scanner scanner, ParseResult result, out TOut parsed, in ParseError? orError = null)
        where T1 : TOut, IStrideParser<T1>
        where T2 : TOut, IStrideParser<T2>
        where T3 : TOut, IStrideParser<T3>
        where T4 : TOut, IStrideParser<T4>
        where TOut : Node
    {
        if(T1.Match(ref scanner, result, out T1 parsed1))
        {
            parsed = parsed1;
            return true;
        }
        else if(T2.Match(ref scanner, result, out T2 parsed2))
        {
            parsed = parsed2;
            return true;
        }
        else if(T3.Match(ref scanner, result, out T3 parsed3))
        {
            parsed = parsed3;
            return true;
        }
        else if(T4.Match(ref scanner, result, out T4 parsed4))
        {
            parsed = parsed4;
            return true;
        }
        if (orError is not null)
            result.Errors.Add(orError.Value);
        parsed = default!;
        return false;
    }
    public static bool MatchOr<T1, T2, T3, T4, T5, TOut>(this ref Scanner scanner, ParseResult result, out TOut parsed, in ParseError? orError = null)
        where T1 : TOut, IStrideParser<T1>
        where T2 : TOut, IStrideParser<T2>
        where T3 : TOut, IStrideParser<T3>
        where T4 : TOut, IStrideParser<T4>
        where T5 : TOut, IStrideParser<T5>
        where TOut : Node
    {
        if(T1.Match(ref scanner, result, out T1 parsed1))
        {
            parsed = parsed1;
            return true;
        }
        else if(T2.Match(ref scanner, result, out T2 parsed2))
        {
            parsed = parsed2;
            return true;
        }
        else if(T3.Match(ref scanner, result, out T3 parsed3))
        {
            parsed = parsed3;
            return true;
        }
        else if(T4.Match(ref scanner, result, out T4 parsed4))
        {
            parsed = parsed4;
            return true;
        }
        else if(T5.Match(ref scanner, result, out T5 parsed5))
        {
            parsed = parsed5;
            return true;
        }
        if (orError is not null)
            result.Errors.Add(orError.Value);
        parsed = default!;
        return false;
    }
    public static bool MatchOr<T1, T2, T3, T4, T5, T6, TOut>(this ref Scanner scanner, ParseResult result, out TOut parsed, in ParseError? orError = null)
        where T1 : TOut, IStrideParser<T1>
        where T2 : TOut, IStrideParser<T2>
        where T3 : TOut, IStrideParser<T3>
        where T4 : TOut, IStrideParser<T4>
        where T5 : TOut, IStrideParser<T5>
        where T6 : TOut, IStrideParser<T6>
        where TOut : Node
    {
        if(T1.Match(ref scanner, result, out T1 parsed1))
        {
            parsed = parsed1;
            return true;
        }
        else if(T2.Match(ref scanner, result, out T2 parsed2))
        {
            parsed = parsed2;
            return true;
        }
        else if(T3.Match(ref scanner, result, out T3 parsed3))
        {
            parsed = parsed3;
            return true;
        }
        else if(T4.Match(ref scanner, result, out T4 parsed4))
        {
            parsed = parsed4;
            return true;
        }
        else if(T5.Match(ref scanner, result, out T5 parsed5))
        {
            parsed = parsed5;
            return true;
        }
        else if(T6.Match(ref scanner, result, out T6 parsed6))
        {
            parsed = parsed6;
            return true;
        }
        if (orError is not null)
            result.Errors.Add(orError.Value);
        parsed = default!;
        return false;
    }
}

