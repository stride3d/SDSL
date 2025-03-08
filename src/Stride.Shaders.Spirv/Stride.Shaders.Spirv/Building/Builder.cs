using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Core;
using Stride.Shaders.Spirv.Core.Buffers;

namespace Stride.Shaders.Spirv.Building;



// Should have utility functions to add instruction to the buffer
public class Builder()
{
    public SpirvBuffer Buffer { get; init; } = new();
    public int Position { get; private set; }

    public void SetPositionTo<TBlock>(TBlock block)
        where TBlock : IInstructionBlock
    {
        if (block is BasicBlock bb)
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
            if (blockFound && blockTermination.Contains((int)e.OpCode))
            {
                Position = e.WordIndex;
                return;
            }
        }
        Position = Buffer.Length;
    }
}
