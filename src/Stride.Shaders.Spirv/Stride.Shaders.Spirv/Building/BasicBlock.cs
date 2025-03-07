using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Core;
using Stride.Shaders.Spirv.Core.Buffers;

namespace Stride.Shaders.Spirv.Building;


public interface IInstructionBlock
{
    public int Id { get; }
}

/// <summary>
/// Function block in SPIR-V
/// </summary>
/// <param name="id">IdResult created by the OpFunction instruction</param>
/// <param name="name">Name of the function</param>
/// <param name="type">Type of the function</param>
public struct SpirvFunction(int id, string name, FunctionTypeSymbol type) : IInstructionBlock
{
    public int Id { get; } = id;
    public string Name { get; } = name;
    public FunctionTypeSymbol FunctionType { get; private set; } = type;
    public SortedList<string, BasicBlock> BasicBlocks { get; } = [];

    public readonly BasicBlock CreateBlock(int id, string name)
    {
        var result = new BasicBlock(id, name, this);
        BasicBlocks.Add(name, result);
        return result;
    }
}

/// <summary>
/// Represents a basic block of instructions in SPIR-V, instructions are linearly processed without control flow.
/// </summary>
/// <param name="id">IdResult created by the Label instruction</param>
/// <param name="name">Name of the block</param>
/// <param name="parent">Function where the block is declared</param>
public struct BasicBlock(int id, string name, SpirvFunction parent) : IInstructionBlock
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public SpirvFunction Parent { get; set; } = parent;
    public int Length { get; private set; }
}

