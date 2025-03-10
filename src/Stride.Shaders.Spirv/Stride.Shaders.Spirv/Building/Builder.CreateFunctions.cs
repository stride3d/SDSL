using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Core.Buffers;
using static Spv.Specification;

namespace Stride.Shaders.Spirv.Building;

public partial class Builder
{
    public SpirvFunction CreateFunction(SpirvContext context, string name, FunctionTypeSymbol ftype, ReadOnlySpan<Symbol> parameters, FunctionControlMask mask = FunctionControlMask.MaskNone)
    {
        foreach(var t in ftype.Types)
            context.Register(t);
        var func = Buffer.AddOpFunction(context.Bound++, context.Register(ftype.Types[0]), mask, context.Register(ftype));
        context.AddName(func, name);
        var result = new SpirvFunction(func.ResultId!.Value, name, ftype);
        if(!parameters.IsEmpty)
            foreach(var p in parameters)
            {
                var i = Buffer.AddOpFunctionParameter(context.Bound++, context.Register(p.Type));
                context.AddName(i, p.Id.Name);
            }
        Buffer.AddOpFunctionEnd();
        return result;
    }
    public SpirvFunction CreateEntryPoint(SpirvContext context, ExecutionModel execModel, string name, FunctionTypeSymbol type, ReadOnlySpan<Symbol> variables, FunctionControlMask mask = FunctionControlMask.MaskNone)
    {
        var func = Buffer.AddOpFunction(context.Bound++, context.Register(type.Types[0]), mask, context.Register(type));
        context.AddName(func, name);
        context.SetEntryPoint(execModel, func, name, variables);
        var result = new SpirvFunction(func.ResultId!.Value, name, type);
        if(!variables.IsEmpty)
            foreach(var p in variables)
                context.AddName(context.Variables[p.Id.Name], p.Id.Name);
        Buffer.AddOpFunctionEnd();
        return result;
    }
    public SpirvFunction CreateBlock(SpirvContext context, string name)
    {
        var func = Buffer.AddOpFunction(context.Bound++, context.Register(type.Types[0]), mask, context.Register(type));
        context.AddName(func, name);
        context.SetEntryPoint(execModel, func, name, variables);
        var result = new SpirvFunction(func.ResultId!.Value, name, type);
        if(!variables.IsEmpty)
            foreach(var p in variables)
                context.AddName(context.Variables[p.Id.Name], p.Id.Name);
        Buffer.AddOpFunctionEnd();
        return result;
    }
    
}