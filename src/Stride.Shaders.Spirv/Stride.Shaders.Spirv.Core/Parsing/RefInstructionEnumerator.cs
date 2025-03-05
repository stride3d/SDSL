namespace Stride.Shaders.Spirv.Core.Parsing;


public ref struct RefInstructionEnumerator
{
    int wordIndex;
    readonly Span<int> words;

    public readonly RefInstruction Current => RefInstruction.ParseRef(words.Slice(wordIndex, words[wordIndex] >> 16));

    public RefInstructionEnumerator(Span<int> words)
    {
        wordIndex = -1;
        this.words = words;
    }

    public bool MoveNext()
    {
        if (wordIndex == -1)
        {
            wordIndex = 0;
            return true;
        }
        else
        {
            if (wordIndex + (words[wordIndex] >> 16) >= words.Length)
                return false;
            wordIndex += words[wordIndex] >> 16;
            return true;
        }
    }
}