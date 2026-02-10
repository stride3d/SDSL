using Stride.Shaders.Parsing.SDSL.AST;
using Stride.Shaders.Parsing.SDSL.PreProcessing;

namespace Stride.Shaders.Parsing;

public struct Scanner(string code)
{
    readonly int start = 0;
    // public string Code { get; } = code;
    public readonly ReadOnlySpan<char> Span => Code.AsSpan();
    public readonly ReadOnlyMemory<char> Memory => Code.AsMemory();
    public readonly ReadOnlyMemory<char> Rest => Memory[Position..];
    string Code { get; } = code;
    public int Position { get; private set; } = 0;

    public readonly int Line => Span[..Position].Count('\n') + 1;
    public readonly int Column => Position - Span[..Position].LastIndexOf('\n') + 1;

    public readonly int End => Span.Length;
    public readonly bool IsEof => Position >= End;

    public readonly TextLocation this[Range range] => new(Memory, range);
    public readonly ErrorLocation this[int position] => new(this, position);

    public readonly char Peek()
        => Position < End ? Span[Position] : '\0';
    public readonly ReadOnlySpan<char> Peek(int size)
        => Position < End ? Slice(Position, size) : [];

    public bool Advance(int length = 1)
    {
        var pos = Position;
        var newPos = pos + length;
        if (newPos <= End)
        {
            Position = newPos;
            return true;
        }
        return false;
    }

    public bool Backtrack(int position)
    {
        Position = position;
        return false;
    }
    public bool Backtrack<T>(int position, ParseResult result, out T parsed, in ParseError? orError = null)
        where T : Node
    {
        Position = position;
        parsed = default!;
        if (orError is not null)
            result.Errors.Add(orError.Value);
        return false;
    }

    public readonly ReadOnlySpan<char> Slice(int index, int length)
    {
        if (index < End)
        {
            length = Math.Min(index + length, End) - index;
            var slice = Span.Slice(index, length);
            return slice;
        }
        return [];
    }
}




