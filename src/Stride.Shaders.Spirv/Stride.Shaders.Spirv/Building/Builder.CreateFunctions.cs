using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Core.Buffers;
using static Spv.Specification;

namespace Stride.Shaders.Spirv.Building;

public partial class Builder
{
    public SpirvFunction CreateFunction(SpirvContext context, string name, FunctionTypeSymbol type, FunctionControlMask mask = FunctionControlMask.MaskNone, List<Symbol>? parameters = null)
    {
        var func = Buffer.AddOpFunction(context.Bound++, context.Types[type.Types[0]], mask, context.Types[type]);
        context.AddName(func, name);
        var result = new SpirvFunction(func.ResultId!.Value, name, type);
        if(parameters is not null)
            foreach(var p in parameters)
            {
                var i = Buffer.AddOpFunctionParameter(context.Bound++, context.Types[p.Type]);
                context.AddName(i, p.Id.Name);
            }
        Buffer.AddOpFunctionEnd();
        return result;
    }
}