using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Core;
using Stride.Shaders.Spirv.Core.Buffers;
using static Spv.Specification;

namespace Stride.Shaders.Spirv.Building;


public partial class Builder
{
    public Value BinaryOperation(SpirvContext context, in Value left, Operator op, in Value right, string? name = null)
    {

        var instruction = (op, context.ReverseTypes[left.TypeId], context.ReverseTypes[right.TypeId]) switch
        {
            (Operator.Plus, ScalarSymbol { TypeName: "byte" or "sbyte" or "short" or "ushort" or "int" or "uint" or "long" or "ulong" }, _)
                => Buffer.InsertOpIAdd(Position, context.Bound++, left.TypeId, left.Id, right.Id),

            (Operator.Plus, ScalarSymbol { TypeName: "half" or "float" or "double" }, _)
                => Buffer.InsertOpFAdd(Position, context.Bound++, left.TypeId, left.Id, right.Id),

            (Operator.Minus, ScalarSymbol { TypeName: "byte" or "sbyte" or "short" or "ushort" or "int" or "uint" or "long" or "ulong" }, _)
                => Buffer.InsertOpISub(Position, context.Bound++, left.TypeId, left.Id, right.Id),

            (Operator.Minus, ScalarSymbol { TypeName: "half" or "float" or "double" }, _)
                => Buffer.InsertOpFSub(Position, context.Bound++, left.TypeId, left.Id, right.Id),

            (Operator.Mul, ScalarSymbol { TypeName: "byte" or "sbyte" or "short" or "ushort" or "int" or "uint" or "long" or "ulong" }, _)
                => Buffer.InsertOpIMul(Position, context.Bound++, left.TypeId, left.Id, right.Id),

            (Operator.Mul, ScalarSymbol { TypeName: "half" or "float" or "double" }, _)
                => Buffer.InsertOpFMul(Position, context.Bound++, left.TypeId, left.Id, right.Id),

            (Operator.Div, ScalarSymbol { TypeName: "byte" or "ushort" or "uint" or "ulong" }, _)
                => Buffer.InsertOpUDiv(Position, context.Bound++, left.TypeId, left.Id, right.Id),

            (Operator.Div, ScalarSymbol { TypeName: "sbyte" or "short" or "int" or "long" }, _)
                => Buffer.InsertOpSDiv(Position, context.Bound++, left.TypeId, left.Id, right.Id),

            (Operator.Div, ScalarSymbol { TypeName: "half" or "float" or "double" }, _)
                => Buffer.InsertOpFDiv(Position, context.Bound++, left.TypeId, left.Id, right.Id),
            (Operator.Mod, ScalarSymbol { TypeName: "byte" or "ushort" or "uint" or "ulong" }, _)
                => Buffer.InsertOpUMod(Position, context.Bound++, left.TypeId, left.Id, right.Id),

            (Operator.Mod, ScalarSymbol { TypeName: "sbyte" or "short" or "int" or "long" }, _)
                => Buffer.InsertOpSMod(Position, context.Bound++, left.TypeId, left.Id, right.Id),

            (Operator.Mod, ScalarSymbol { TypeName: "half" or "float" or "double" }, _)
                => Buffer.InsertOpFMod(Position, context.Bound++, left.TypeId, left.Id, right.Id),
            (Operator.RightShift, ScalarSymbol { TypeName: "byte" or "sbyte" or "short" or "ushort" or "int" or "uint" or "long" or "ulong" }, _)
                => Buffer.InsertOpShiftRightLogical(Position, context.Bound++, left.TypeId, left.Id, right.Id),
            (Operator.LeftShift, ScalarSymbol { TypeName: "byte" or "sbyte" or "short" or "ushort" or "int" or "uint" or "long" or "ulong" }, _)
                => Buffer.InsertOpShiftRightLogical(Position, context.Bound++, left.TypeId, left.Id, right.Id),

            _ => throw new NotImplementedException()
        };
        Position += instruction.WordCount;
        if (instruction.ResultId is int r)
        {
            if (name is not null)
                context.AddName(instruction, name);
            return new(instruction, r, name);
        }
        else throw new NotImplementedException("Instruction should have result id");
    }


    public void Return(in Value? value = null)
    {
        Position += value switch
        {
            Value v => Buffer.InsertOpReturnValue(Position, v.Id).WordCount,
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