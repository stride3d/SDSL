using Stride.Shaders.Spirv.Core.Parsing;

namespace Stride.Shaders.Spirv.Core.Buffers;

/// <summary>
/// A spirv buffer object
/// </summary>
public interface ISpirvBuffer
{
    Span<int> Span { get; }
    Memory<int> Memory { get; }
    Span<int> InstructionSpan { get; }
    Memory<int> InstructionMemory { get; }
    public int InstructionCount { get; }

    int Length { get; }

    bool HasHeader { get; }
    RefHeader Header { get; set; }

    public Instruction this[int index] { get; }

    public SpirvSpan AsSpan();
    public SpirvMemory AsMemory();

}


public interface ISpirvEnumerable
{
    public InstructionEnumerator GetEnumerator();
}

public interface IRefSpirvEnumerable
{
    public RefInstructionEnumerator GetEnumerator();
}