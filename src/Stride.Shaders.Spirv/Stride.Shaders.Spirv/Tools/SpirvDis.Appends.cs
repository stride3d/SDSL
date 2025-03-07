using static Spv.Specification;
using Stride.Shaders.Spirv.Core;

namespace Stride.Shaders.Spirv.Tools;


public partial struct SpirvDis<TBuffer>
{
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
            builder.Append(' ', IdOffset - 1 - size).Append('%').Append(result.Value);
            if (WriteToTerminal)
                Console.Write($"{new string(' ', IdOffset - 1 - size)} %{result.Value.Value} ");

        }
        else
        {
            builder.Append(' ', IdOffset);
            Console.Write(new string(' ', IdOffset + 2));
        }

    }
    internal readonly void Append(NameId name)
    {
        builder.Append(' ', IdOffset - 2 - name.Name.Length).Append('%').Append(name.Name);
        if (WriteToTerminal)
            Console.Write($"{new string(' ', IdOffset - 2 - name.Name.Length)} %{name.Name} ");
    }

    public readonly void Append<T>(T value) where T : Enum
    {
        var name = Enum.GetName(typeof(T), value);
        builder.Append(' ').Append(name);
        if(WriteToTerminal)
            Console.Write($" {name}");
    }
    public readonly void Append(IdRef id)
    {
        if (WriteToTerminal)
            Console.ForegroundColor = ConsoleColor.DarkYellow;

        if (UseNames && nameTable.TryGetValue(id, out var name))
        {
            builder.Append(" %").Append(name.Name);
            if (WriteToTerminal)
                Console.Write($" %{name.Name}");
        }
        else
        {
            builder.Append(' ').Append('%').Append(id.Value);
            if (WriteToTerminal)
                Console.Write($" %{id.Value}");
        }

        if (WriteToTerminal)
            Console.ResetColor();
    }
    public readonly void Append(IdResultType id)
    {
        if (WriteToTerminal)
            Console.ForegroundColor = ConsoleColor.DarkYellow;

        if (UseNames && nameTable.TryGetValue(id, out var name))
        {
            builder.Append(" %").Append(name.Name);
            if (WriteToTerminal)
                Console.Write($" %{name.Name}");
        }
        else
        {
            builder.Append(' ').Append('%').Append(id.Value);
            if (WriteToTerminal)
                Console.Write($" %{id.Value}");
        }

        if (WriteToTerminal)
            Console.ResetColor();
    }
    public readonly void AppendInt(int v)
    {
        builder.Append(' ').Append(v);
        if (WriteToTerminal)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($" {v}");
            Console.ResetColor();
        }
    }
    public readonly void AppendConst(int typeId, Span<int> words)
    {
        builder.Append(' ');
        foreach (var e in buffer)
        {
            if (e.ResultId is int rid && rid == typeId)
            {
                if (e.OpCode == SDSLOp.OpTypeInt)
                {
                    builder.Append(words.Length == 1 ? words[0] : words[0] << 32 | words[1]);
                    if (WriteToTerminal)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($" {(words.Length == 1 ? words[0] : words[0] << 32 | words[1])}");
                        Console.ResetColor();
                    }
                    return;
                }
                else if (e.OpCode == SDSLOp.OpTypeFloat)
                {
                    builder.Append(
                        words.Length == 1 ?
                            BitConverter.Int32BitsToSingle(words[0])
                            : BitConverter.Int64BitsToDouble(words[0] << 32 | words[1])
                        );
                    if (WriteToTerminal)
                    {
                        var v = words.Length == 1 ?
                            BitConverter.Int32BitsToSingle(words[0])
                            : BitConverter.Int64BitsToDouble(words[0] << 32 | words[1]);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($" {v}");
                        Console.ResetColor();
                    }
                    return;
                }
            }
        }
    }
    public readonly void AppendLiteral(LiteralInteger v)
    {
        builder.Append(' ').Append(v.Words);
        if (WriteToTerminal)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($" {v.Words}");
            Console.ResetColor();
        }
    }

    public readonly void AppendLiteral(LiteralFloat v)
    {
        if (WriteToTerminal)
            Console.ForegroundColor = ConsoleColor.Red;

        if (v.WordCount == 1)
        {
            builder.Append(' ').Append(Convert.ToSingle(v.Words & 0xFFFF));
            Console.Write($" {Convert.ToSingle(v.Words & 0xFFFF)}");
        }
        else if (v.WordCount == 2)
        {
            builder.Append(' ').Append(Convert.ToDouble(v.Words));
            Console.Write($" {Convert.ToDouble(v.Words)}");
        }

        if (WriteToTerminal)
            Console.ResetColor();
    }
    public readonly void AppendLiteral(LiteralString v, bool quoted = false)
    {
        if (!quoted)
            builder.Append(' ').Append(v.Value);
        else
            builder.Append(' ').Append('"').Append(v.Value).Append('"');

        if (WriteToTerminal)
        {
            if (quoted)
            {
                Console.Write($" \"");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
                Console.Write(' ');

            Console.Write($"{v.Value}");
            
            if (quoted)
            {
                Console.ResetColor();
                Console.Write("\"");
            }
        }
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

    public readonly void Append(in SpvOperand o, in RefInstruction instruction)
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
        else if (
                o.Kind == OperandKind.LiteralContextDependentNumber
                && (instruction.OpCode == SDSLOp.OpConstant || instruction.OpCode == SDSLOp.OpSpecConstant)
                && instruction.ResultType is int rtype
            )
        {
            AppendConst(rtype, o.Words);
        }
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
        else if (o.Kind == OperandKind.LiteralString)
            AppendLiteral(new LiteralString(o.Words), quoted: true);

    }
}