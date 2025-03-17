using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Core;
using Stride.Shaders.Spirv.Core.Buffers;
using static Spv.Specification;

namespace Stride.Shaders.Spirv.Building;

// Should contain internal data not seen by the client but helpful for the generation like type symbols and other 
// SPIR-V parameters
public class SpirvContext(Module module, ISymbolProvider symbolProvider) : IDisposable
{
    public int Bound { get; internal set; } = 1;
    public Module Module { get; } = module;
    public SortedList<string, int> Variables { get; } = [];
    public Dictionary<SymbolType, int> Types { get; } = [];
    public Dictionary<int, SymbolType> ReverseTypes { get; } = [];
    public SpirvBuffer Buffer { get; set; } = new();

    public ISymbolProvider SymbolProvider { get; } = symbolProvider;

    public void AddName(IdRef target, string name)
        => Buffer.AddOpName(target, name);

    public void AddMemberName(IdRef target, int accessor, string name)
        => Buffer.AddOpMemberName(target, accessor, name);

    public void AddGlobalVariable(Symbol variable)
    {
        var t = GetOrRegister(variable.Type);
        if (variable.Id.Storage == Storage.Stream)
        {
            foreach(var usage in SymbolProvider.RootSymbols.StreamUsages[variable.Id])
            {
                var i = Buffer.AddOpVariable(
                    Bound++, 
                    t, 
                    usage.IO switch
                    {
                        StreamIO.Input => StorageClass.Input,
                        StreamIO.Output => StorageClass.Output,
                        _ => throw new NotImplementedException()
                    }, 
                    null
                );
                Variables[variable.Id.Name] = i.ResultId!.Value;
                AddName(i, $"{usage.EntryPoint.ToString()}_{usage.IO.ToString()}_{variable.Id.Name}");
            }
        }
        else
        {
            var storage = variable.Id.Storage switch
            {
                Storage.UniformConstant => StorageClass.UniformConstant,
                Storage.Uniform => StorageClass.Uniform,
                Storage.Function => StorageClass.Function,
                Storage.Generic => StorageClass.Generic,
                _ => throw new NotImplementedException("Variable has to have a storage class")
            };
            var i = Buffer.AddOpVariable(Bound++, t, storage, null);
            Variables[variable.Id.Name] = i.ResultId!.Value;
            AddName(i, $"{variable.Id.Name}");
        }
    }


    public void SetEntryPoint(ExecutionModel model, IdRef function, string name, ReadOnlySpan<Symbol> variables)
    {
        Span<IdRef> pvariables = stackalloc IdRef[variables.Length];
        int pos = 0;
        foreach (var v in variables)
            pvariables[pos++] = Variables[v.Id.Name];
        Buffer.AddOpEntryPoint(model, function, name, pvariables);
    }

    public IdRef GetOrRegister(SymbolType type)
    {
        if (Types.TryGetValue(type, out var res))
            return res;
        else
        {
            var instruction = type switch
            {
                ScalarSymbol s =>
                    s.TypeName switch
                    {
                        "void" => Buffer.AddOpTypeVoid(Bound++),
                        "bool" => Buffer.AddOpTypeBool(Bound++),
                        "sbyte" => Buffer.AddOpTypeInt(Bound++, 8, 1),
                        "byte" => Buffer.AddOpTypeInt(Bound++, 8, 0),
                        "ushort" => Buffer.AddOpTypeInt(Bound++, 16, 1),
                        "short" => Buffer.AddOpTypeInt(Bound++, 16, 0),
                        "int" => Buffer.AddOpTypeInt(Bound++, 32, 1),
                        "uint" => Buffer.AddOpTypeInt(Bound++, 32, 0),
                        "long" => Buffer.AddOpTypeInt(Bound++, 64, 1),
                        "ulong" => Buffer.AddOpTypeInt(Bound++, 64, 0),
                        "half" => Buffer.AddOpTypeFloat(Bound++, 16, null),
                        "float" => Buffer.AddOpTypeFloat(Bound++, 32, null),
                        "double" => Buffer.AddOpTypeFloat(Bound++, 64, null),
                        _ => throw new NotImplementedException($"Can't add type {type}")

                    },
                VectorSymbol v => Buffer.AddOpTypeVector(Bound++, GetOrRegister(v.BaseType), v.Size),
                MatrixSymbol m => Buffer.AddOpTypeVector(Bound++, GetOrRegister(new VectorSymbol(m.BaseType, m.Rows)), m.Columns),
                ArraySymbol a => Buffer.AddOpTypeArray(Bound++, GetOrRegister(a.BaseType), a.Size),
                StructSymbol st => RegisterStruct(st),
                FunctionTypeSymbol f => RegisterFunctionType(f),
                // TextureSymbol t => Buffer.AddOpTypeImage(Bound++, Register(t.BaseType), t.),
                // StructSymbol st => RegisterStruct(st),
                _ => throw new NotImplementedException($"Can't add type {type}")
            };
            Types[type] = instruction;
            ReverseTypes[instruction] = type;
            return instruction;
        }
    }

    IdRef RegisterStruct(StructSymbol structSymbol)
    {
        Span<IdRef> types = stackalloc IdRef[structSymbol.Fields.Count];
        int tmp = 0;
        foreach (var f in structSymbol.Fields)
        {
            types[tmp] = GetOrRegister(f.Value);
            AddMemberName(types[tmp], tmp, f.Key);
        }
        var result = Buffer.AddOpTypeStruct(Bound++, types);
        AddName(result, structSymbol.Name);
        return result;
    }

    IdRef RegisterFunctionType(FunctionTypeSymbol functionType)
    {
        Span<IdRef> types = stackalloc IdRef[functionType.Types.Count];
        int tmp = 0;
        foreach (var f in functionType.Types)
            types[tmp] = GetOrRegister(f);
        var result = Buffer.AddOpTypeStruct(Bound++, types);
        AddName(result, functionType.ToString());
        return result;
    }

    public void Dispose() => Buffer.Dispose();
}