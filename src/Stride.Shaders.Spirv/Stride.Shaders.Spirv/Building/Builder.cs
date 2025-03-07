using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Core;
using Stride.Shaders.Spirv.Core.Buffers;

namespace Stride.Shaders.Spirv.Building;

// Should contain internal data not seen by the client but helpful for the generation like type symbols and other 
// SPIR-V parameters
public class SpirvContext(Module module)
{
    public int Bound { get; private set; }
    public Module Module { get; } = module;
    public SortedList<SymbolType, int> Types { get; } = [];
}

// Should contain symbols for the SPIR-V module
public class Module()
{
    public SortedList<string, SpirvFunction> Functions { get; init; } = [];
}

// Should have utility functions to add instruction to the buffer
public class Builder
{
    public SpirvBuffer Buffer { get; init; } = new();
    public int Position { get; private set; }

    public void SetPositionTo<TBlock>(TBlock block)
        where TBlock : IInstructionBlock
    {
        if(block is BasicBlock bb)
            SetPositionTo(bb.Parent);
        bool blockFound = false;
        Span<int> blockTermination = [
            (int)SDSLOp.OpBranch,    
            (int)SDSLOp.OpBranchConditional,
            (int)SDSLOp.OpSwitch,
            (int)SDSLOp.OpReturn,
            (int)SDSLOp.OpReturnValue,
            (int)SDSLOp.OpKill,
            (int)SDSLOp.OpUnreachable,
            (int)SDSLOp.OpTerminateInvocation
        ];
        foreach (var e in Buffer)
        {
            if (e.ResultId is int id && id == block.Id)
                blockFound = true;
            if(blockFound && blockTermination.Contains((int)e.OpCode))
            {
                Position = e.WordIndex;
                return;
            }
        }
        Position = Buffer.Length;
    }
}
