using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Core;
using Stride.Shaders.Spirv.Core.Buffers;
using static Spv.Specification;

namespace Stride.Shaders.Spirv.Building;


public partial class Builder
{
    public Value OpAdd(SpirvContext context, Value a, Value b, string? name = null)
    {
        var instruction = Buffer.InsertOpIAdd(Position, context.Bound++, a.TypeId, a.Id, b.Id);
        if (instruction.ResultId is int r)
        {
            if (name is not null)
                context.AddName(instruction, name);
            return new(instruction, r, name);            
        }
        else throw new NotImplementedException("Instruction should have result id");
    }
}