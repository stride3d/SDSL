using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Core;
using Stride.Shaders.Spirv.Core.Buffers;

namespace Stride.Shaders.Spirv.Building;




/// <summary>
/// A SPIR-V value representing the result of an instruction
/// </summary>
/// <param name="id">IdResult of the instruction</param>
/// <param name="typeId">IdResultType of the instruction</param>
/// <param name="name">Optional name attached to the value</param>
public struct SpirvValue(IdRef id, IdRef typeId, string? name = null)
{

    public SpirvValue(Instruction instruction, string? name = null) : this(instruction, instruction.ResultType!.Value, name) {}

    public int Id { get; set; } = id;
    public int TypeId { get; set; } = typeId;
    public string? Name { get; set; } = name;
}


/// <summary>
/// Interface for SpirvBlock and SpirvFunction to avoid duplicating code.
/// </summary>
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
public struct SpirvFunction(int id, string name, FunctionType type) : IInstructionBlock
{
    public int Id { get; } = id;
    public string Name { get; } = name;
    public FunctionType FunctionType { get; private set; } = type;
    public Dictionary<string, SpirvValue> Parameters { get; } = [];
    public Dictionary<string, SpirvValue> Variables { get; } = [];
    public SortedList<int, SpirvBlock> BasicBlocks { get; } = [];
}

/// <summary>
/// Represents a basic block of instructions in SPIR-V, instructions are linearly processed without control flow.
/// </summary>
/// <param name="id">IdResult created by the Label instruction</param>
/// <param name="name">Name of the block</param>
/// <param name="parent">Function where the block is declared</param>
public struct SpirvBlock(in IdRef id, SpirvFunction parent, string? name = null) : IInstructionBlock
{
    public int Id { get; set; } = id;
    public string? Name { get; set; } = name;
    public SpirvFunction Parent { get; set; } = parent;
}
