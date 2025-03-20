using Stride.Shaders.Spirv.Core;
using Stride.Shaders.Spirv.Core.Buffers;

namespace Stride.Shaders.Spirv.Building;


public partial class Builder
{
    public SpirvBlock CreateBlock(SpirvContext context, SpirvFunction parent, string? name = null)
    {
        var i = Buffer.InsertOpLabel(Position, context.Bound++);
        Position += i.WordCount;
        Position += Buffer.InsertOpUnreachable(Position).WordCount;
        var result = new SpirvBlock(i, parent, name);
        return result;
    }

    public void Return(in SpirvValue? value = null)
    {
        Position += value switch
        {
            SpirvValue v => Buffer.InsertOpReturnValue(Position, v.Id).WordCount,
            _ => Buffer.InsertOpReturn(Position).WordCount
        };
        CleanBlock();
    }

    public void CleanBlock()
    {
        if ((Buffer.Span[Position] & 0xFFFF) == (int)SDSLOp.OpUnreachable)
        {
            var size = Buffer.Span[Position] >> 16;
            Buffer.Remove(Position);
            Position -= size;
        }
    }
}