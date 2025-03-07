using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Spv.Specification;

namespace Stride.Shaders.Spirv.Core.Parsing;

/// <summary>
/// An instruction utility parser.
/// </summary>
public ref struct RefInstructions
{
    Memory<int> Words { get; init; }

    
    public RefInstructions(Memory<int> words)
    {
        Words = words;
    }


    public Enumerator GetEnumerator() => new(Words);

    public ref struct Enumerator(Memory<int> words)
    {
        int index;
        int wordIndex = 0;
        bool started = false;
        readonly Memory<int> words = words;

        public RefInstruction Current => ParseCurrentInstruction();

        public bool MoveNext()
        {
            if (!started)
            {
                started = true;
                return true;
            }
            else
            {
                var sizeToStep = words.Span[wordIndex] >> 16;
                wordIndex += sizeToStep;
                if (wordIndex >= words.Length)
                    return false;
                index += 1;
                return true;
            }

        }
        
        public readonly RefInstruction ParseCurrentInstruction()
        {
            return RefInstruction.Parse(words, wordIndex, index);
        }
    }
}
