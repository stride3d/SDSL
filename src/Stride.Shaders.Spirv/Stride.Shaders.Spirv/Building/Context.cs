using System.Reflection.Metadata.Ecma335;
using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Core;
using Stride.Shaders.Spirv.Core.Buffers;
using static Spv.Specification;

namespace Stride.Shaders.Spirv.Building;

// Should contain internal data not seen by the client but helpful for the generation like type symbols and other 
// SPIR-V parameters
public class SpirvContext(Module module) : IDisposable
{
    public int Bound { get; internal set; } = 1;
    public Module Module { get; } = module;
    public SortedList<string, int> Variables { get; } = [];
    public SortedList<SymbolType, int> Types { get; } = [];
    public SpirvBuffer Buffer { get; set; } = new();

    public void AddName(IdRef target, string name)
        => Buffer.AddOpName(target, name);

    public void AddGlobalVariable(Symbol variable)
    {
        if (Types.TryGetValue(variable.Type, out var t))
        {
            var storage = variable.Id.Storage switch 
            {
                Storage.UniformConstant => StorageClass.UniformConstant,
                Storage.Input => StorageClass.Input,
                Storage.Uniform => StorageClass.Uniform,
                Storage.Output => StorageClass.Output,
                Storage.Function => StorageClass.Function,
                Storage.Generic => StorageClass.Generic,
                _ => throw new NotImplementedException("Variable has to have a storage class")
            };
            var i = Buffer.AddOpVariable(Bound++, t, storage, null);
            Variables[variable.Id.Name] = i.ResultId!.Value;
        }
    }

    public void Dispose() => Buffer.Dispose();
}