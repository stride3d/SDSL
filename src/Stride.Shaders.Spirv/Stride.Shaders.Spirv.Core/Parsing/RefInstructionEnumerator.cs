namespace Stride.Shaders.Spirv.Core.Parsing;


public ref struct RefInstructionEnumerator
{
    int wordIndex;
    int index;
    readonly Span<int> words;

    public readonly RefInstruction Current => RefInstruction.ParseRef(words.Slice(wordIndex, words[wordIndex] >> 16), index);

    public RefInstructionEnumerator(Span<int> words)
    {
        wordIndex = -1;
        index = 0;
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
            index += 1;
            return true;
        }
    }
}