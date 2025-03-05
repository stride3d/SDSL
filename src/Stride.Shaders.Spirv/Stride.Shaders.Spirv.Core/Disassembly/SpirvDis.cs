using System.Text;
using Stride.Shaders.Spirv.Core.Buffers;
using static Spv.Specification;

namespace Stride.Shaders.Spirv.Core;


internal record struct NameId(string Name);

public readonly struct SpirvDis<TBuffer>
    where TBuffer : ISpirvBuffer

{
    readonly TBuffer buffer;
    readonly StringBuilder builder;
    int IdOffset { get; init; }
    bool UseNames { get; init; }

    readonly SortedList<int, NameId> nameTable = [];

    public SpirvDis(TBuffer buff, bool useNames = false)
    {
        buffer = buff;
        builder = new();
        UseNames = useNames;
        IdOffset = 3;
        if (!useNames)
        {
            var bound = buff.Header.Bound;
            IdOffset = 3;
            while (bound > 0)
            {
                bound /= 10;
                IdOffset += 1;
            }
        }
        else
        {
            var maxName = 0;
            if (buffer is ISpirvEnumerable membuff)
            {
                foreach (var i in membuff)
                {
                    if (
                        (i.OpCode == SDSLOp.OpName || i.OpCode == SDSLOp.OpMemberName)
                        && i.TryGetOperand("name", out LiteralString? name)
                        && name is not null
                    )
                    {
                        maxName = maxName > name.Value.Value.Length ? maxName : name.Value.Value.Length;
                    }
                }
                IdOffset += maxName;
            }
            else if (buffer is ISpirvEnumerable refbuff)
            {
                foreach (var i in refbuff)
                {
                    if (
                        (i.OpCode == SDSLOp.OpName || i.OpCode == SDSLOp.OpMemberName)
                        && i.TryGetOperand("name", out LiteralString? name)
                        && name is not null
                    )
                    {
                        maxName = maxName > name.Value.Value.Length ? maxName : name.Value.Value.Length;
                    }
                }
                IdOffset += maxName;
            }

        }
    }

    public readonly string Disassemble()
    {
        builder.Clear();
        if (buffer is ISpirvEnumerable membuff)
        {
            foreach (var e in membuff)
            {
                if (
                    UseNames
                    && (e.OpCode == SDSLOp.OpName || e.OpCode == SDSLOp.OpMemberName)
                    && e.TryGetOperand("target", out IdRef? target) && target is IdRef t
                    && e.TryGetOperand("name", out LiteralString? name) && name is LiteralString n
                )
                    nameTable[t] = new(n.Value);

                if (UseNames && e.ResultId is int id && nameTable.TryGetValue(id, out var nid))
                    Append(nid);
                else
                    Append(e.ResultId != null ? new IdResult(e.ResultId.Value) : null);

                AppendLiteral(Enum.GetName(e.OpCode) ?? "Op.OpNop");
                foreach (var o in e)
                    Append(o);
                AppendLine();
            }
        }
        else if (buffer is IRefSpirvEnumerable refbuff)
        {
            foreach (var e in refbuff)
            {
                if (
                    UseNames
                    && e.ResultId is int rid
                    && (e.OpCode == SDSLOp.OpName || e.OpCode == SDSLOp.OpMemberName)
                    && e.TryGetOperand("name", out LiteralString? name) && name is LiteralString n
                )
                    nameTable[rid] = new(n.Value);

                if (UseNames && e.ResultId is int id)
                    Append(nameTable[id]);
                else
                    Append(e.ResultId != null ? new IdResult(e.ResultId.Value) : null);

                AppendLiteral(Enum.GetName(e.OpCode) ?? "Op.OpNop");
                foreach (var o in e)
                    Append(o);
                AppendLine();
            }
        }
        return builder.ToString();
    }



    public readonly void Append(IdResult? result)
    {
        if (result != null)
        {
            var tmp = result.Value;
            var size = 1;
            while (tmp > 0)
            {
                tmp /= 10;
                size += 1;
            }
            builder.Append('%').Append(result.Value).Append(' ', IdOffset - 1 - size).Append('=');
        }
        else
            builder.Append(' ', IdOffset);
    }
    internal readonly void Append(NameId name)
    {
        builder.Append('%').Append(name.Name).Append(' ', IdOffset - 2 - name.Name.Length).Append('=');
    }

    public readonly void Append<T>(T value) where T : Enum
    {
        var name = Enum.GetName(typeof(T), value);
        builder.Append(' ').Append(name);
    }
    public readonly void Append(IdRef id)
    {
        if(UseNames && nameTable.TryGetValue(id, out var name))
            builder.Append(" %").Append(name.Name);
        else
            builder.Append(' ').Append('%').Append(id.Value);
    }
    public readonly void Append(IdResultType id)
    {
        builder.Append(' ').Append('%').Append(id.Value);
    }
    public readonly void AppendInt(int v)
    {
        builder.Append(' ').Append(v);
    }
    public readonly void AppendLiteral(LiteralInteger v)
    {
        builder.Append(' ').Append(v.Words);
    }

    public readonly void AppendLiteral(LiteralFloat v)
    {
        if (v.WordCount == 1)
            builder.Append(' ').Append(Convert.ToSingle(v.Words & 0xFFFF));
        if (v.WordCount == 2)
            builder.Append(' ').Append(Convert.ToDouble(v.Words));
    }
    public readonly void AppendLiteral(LiteralString v, bool quoted = false)
    {
        if (!quoted)
            builder.Append(' ').Append(v.Value);
        else
            builder.Append(' ').Append('"').Append(v.Value).Append('"');
    }
    public readonly void Append(PairLiteralIntegerIdRef v)
    {
        (int, int) value = v;
        AppendInt(value.Item1);
        Append(new IdRef(value.Item2));
    }
    public readonly void Append(PairIdRefLiteralInteger v)
    {
        (int, int) value = v;
        Append(new IdRef(value.Item1));
        AppendInt(value.Item2);
    }
    public readonly void Append(PairIdRefIdRef v)
    {
        (int, int) value = v;
        Append(new IdRef(value.Item1));
        Append(new IdRef(value.Item2));
    }
    public readonly void AppendLine() => builder.AppendLine();

    public readonly void Append(in SpvOperand o)
    {

        if (o.Kind == OperandKind.IdRef)
            foreach (var e in o.Words)
                Append(new IdRef(e));
        else if (o.Kind == OperandKind.IdResultType)
            foreach (var e in o.Words)
                Append((IdResultType)e);
        else if (o.Kind == OperandKind.PairLiteralIntegerIdRef)
            for (int i = 0; i < o.Words.Length; i += 2)
                Append(new PairLiteralIntegerIdRef((o.Words[i], o.Words[i + 1])));
        else if (o.Kind == OperandKind.PairIdRefLiteralInteger)
            for (int i = 0; i < o.Words.Length; i += 2)
                Append(new PairIdRefLiteralInteger((o.Words[i], o.Words[i + 1])));
        else if (o.Kind == OperandKind.PairIdRefIdRef)
            for (int i = 0; i < o.Words.Length; i += 2)
                Append(new PairIdRefIdRef((o.Words[i], o.Words[i + 1])));
        else if (o.Kind == OperandKind.LiteralContextDependentNumber)
            AppendLiteral(o.To<LiteralInteger>());
        else if (o.Kind == OperandKind.PackedVectorFormat)
            foreach (var e in o.Words)
                Append((PackedVectorFormat)e);
        else if (o.Kind == OperandKind.ImageOperands)
            foreach (var e in o.Words)
                Append((ImageOperandsMask)e);
        else if (o.Kind == OperandKind.FPFastMathMode)
            foreach (var e in o.Words)
                Append((FPFastMathModeMask)e);
        else if (o.Kind == OperandKind.SelectionControl)
            foreach (var e in o.Words)
                Append((SelectionControlMask)e);
        else if (o.Kind == OperandKind.LoopControl)
            foreach (var e in o.Words)
                Append((LoopControlMask)e);
        else if (o.Kind == OperandKind.FunctionControl)
            foreach (var e in o.Words)
                Append((FunctionControlMask)e);
        else if (o.Kind == OperandKind.MemorySemantics)
            foreach (var e in o.Words)
                Append((MemorySemanticsMask)e);
        else if (o.Kind == OperandKind.MemoryAccess)
            foreach (var e in o.Words)
                Append((MemoryAccessMask)e);
        else if (o.Kind == OperandKind.KernelProfilingInfo)
            foreach (var e in o.Words)
                Append((KernelProfilingInfoMask)e);
        else if (o.Kind == OperandKind.RayFlags)
            foreach (var e in o.Words)
                Append((RayFlagsMask)e);
        else if (o.Kind == OperandKind.FragmentShadingRate)
            foreach (var e in o.Words)
                Append((FragmentShadingRateMask)e);
        else if (o.Kind == OperandKind.SourceLanguage)
            foreach (var e in o.Words)
                Append((SourceLanguage)e);
        else if (o.Kind == OperandKind.ExecutionModel)
            foreach (var e in o.Words)
                Append((ExecutionModel)e);
        else if (o.Kind == OperandKind.AddressingModel)
            foreach (var e in o.Words)
                Append((AddressingModel)e);
        else if (o.Kind == OperandKind.MemoryModel)
            foreach (var e in o.Words)
                Append((MemoryModel)e);
        else if (o.Kind == OperandKind.ExecutionMode)
            foreach (var e in o.Words)
                Append((ExecutionMode)e);
        else if (o.Kind == OperandKind.StorageClass)
            foreach (var e in o.Words)
                Append((StorageClass)e);
        else if (o.Kind == OperandKind.Dim)
            foreach (var e in o.Words)
                Append((Dim)e);
        else if (o.Kind == OperandKind.SamplerAddressingMode)
            foreach (var e in o.Words)
                Append((SamplerAddressingMode)e);
        else if (o.Kind == OperandKind.SamplerFilterMode)
            foreach (var e in o.Words)
                Append((SamplerFilterMode)e);
        else if (o.Kind == OperandKind.ImageFormat)
            foreach (var e in o.Words)
                Append((ImageFormat)e);
        else if (o.Kind == OperandKind.ImageChannelOrder)
            foreach (var e in o.Words)
                Append((ImageChannelOrder)e);
        else if (o.Kind == OperandKind.ImageChannelDataType)
            foreach (var e in o.Words)
                Append((ImageChannelDataType)e);
        else if (o.Kind == OperandKind.FPRoundingMode)
            foreach (var e in o.Words)
                Append((FPRoundingMode)e);
        else if (o.Kind == OperandKind.LinkageType)
            foreach (var e in o.Words)
                Append((LinkageType)e);
        else if (o.Kind == OperandKind.AccessQualifier)
            foreach (var e in o.Words)
                Append((AccessQualifier)e);
        else if (o.Kind == OperandKind.FunctionParameterAttribute)
            foreach (var e in o.Words)
                Append((FunctionParameterAttribute)e);
        else if (o.Kind == OperandKind.Decoration)
            foreach (var e in o.Words)
                Append((Decoration)e);
        else if (o.Kind == OperandKind.BuiltIn)
            foreach (var e in o.Words)
                Append((BuiltIn)e);
        else if (o.Kind == OperandKind.Scope)
            foreach (var e in o.Words)
                Append((Scope)e);
        else if (o.Kind == OperandKind.GroupOperation)
            foreach (var e in o.Words)
                Append((GroupOperation)e);
        else if (o.Kind == OperandKind.KernelEnqueueFlags)
            foreach (var e in o.Words)
                Append((KernelEnqueueFlags)e);
        else if (o.Kind == OperandKind.Capability)
            foreach (var e in o.Words)
                Append((Capability)e);
        else if (o.Kind == OperandKind.RayQueryIntersection)
            foreach (var e in o.Words)
                Append((RayQueryIntersection)e);
        else if (o.Kind == OperandKind.RayQueryCommittedIntersectionType)
            foreach (var e in o.Words)
                Append((RayQueryCommittedIntersectionType)e);
        else if (o.Kind == OperandKind.RayQueryCandidateIntersectionType)
            foreach (var e in o.Words)
                Append((RayQueryCandidateIntersectionType)e);
        else if (o.Kind == OperandKind.IdMemorySemantics)
            foreach (var e in o.Words)
                AppendInt((IdMemorySemantics)e);
        else if (o.Kind == OperandKind.IdScope)
            foreach (var e in o.Words)
                AppendInt((IdScope)e);
        else if (o.Kind == OperandKind.IdRef)
            foreach (var e in o.Words)
                Append((IdRef)e);
        else if (o.Kind == OperandKind.LiteralInteger)
            foreach (var e in o.Words)
                AppendInt(e);

    }

    public readonly override string ToString()
    {
        return builder.ToString();
    }
}