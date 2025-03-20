using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Core;
using Stride.Shaders.Spirv.Core.Buffers;
using static Spv.Specification;

namespace Stride.Shaders.Spirv.Building;


public partial class Builder
{
    public SpirvValue BinaryOperation(SpirvContext context, int resultType, in SpirvValue left, Operator op, in SpirvValue right, string? name = null)
    {

        var instruction = (op, context.ReverseTypes[left.TypeId], context.ReverseTypes[right.TypeId]) switch
        {
            (Operator.Plus, SymbolType l, SymbolType r)
                when l.IsIntegerVector() && r.IsIntegerVector() && SymbolExtensions.SameComponentCountAndWidth(l, r)
                => Buffer.InsertOpIAdd(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.Plus, ScalarSymbol l, ScalarSymbol r)
                when l.IsFloatingVector() && r.IsFloatingVector() && SymbolExtensions.SameComponentCountAndWidth(l, r)
                => Buffer.InsertOpFAdd(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.Minus, SymbolType l, SymbolType r)
                when l.IsIntegerVector() && r.IsIntegerVector() && SymbolExtensions.SameComponentCountAndWidth(l, r)
                => Buffer.InsertOpISub(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.Minus, SymbolType l, SymbolType r)
                when l.IsFloatingVector() && r.IsFloatingVector() && SymbolExtensions.SameComponentCountAndWidth(l, r)
                => Buffer.InsertOpFSub(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.Mul, SymbolType l, SymbolType r)
                when l.IsIntegerVector() && r.IsIntegerVector() && SymbolExtensions.SameComponentCountAndWidth(l, r)
                => Buffer.InsertOpIMul(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.Mul, SymbolType l, SymbolType r)
                when l.IsFloatingVector() && r.IsFloatingVector() && SymbolExtensions.SameComponentCountAndWidth(l, r)
                => Buffer.InsertOpFMul(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.Div, SymbolType l, SymbolType r)
                when l.IsUnsignedIntegerVector() && r.IsUnsignedIntegerVector() && SymbolExtensions.SameComponentCount(l, r)
                => Buffer.InsertOpUDiv(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.Div, SymbolType l, SymbolType r)
                when l.IsIntegerVector() && r.IsIntegerVector() && SymbolExtensions.SameComponentCountAndWidth(l, r)
                => Buffer.InsertOpSDiv(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.Div, SymbolType l, SymbolType r)
                when l.IsFloatingVector() && r.IsFloatingVector()
                => Buffer.InsertOpFDiv(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.Mod, SymbolType l, SymbolType r)
                when l.IsUnsignedIntegerVector() && r.IsUnsignedIntegerVector()
                => Buffer.InsertOpUMod(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.Mod, SymbolType l, SymbolType r)
                when l.IsInteger() && r.IsInteger() && SymbolExtensions.SameComponentCountAndWidth(l, r)
                => Buffer.InsertOpSMod(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.Mod, SymbolType l, SymbolType r)
                when l.IsFloating() && r.IsNumber()
                => Buffer.InsertOpFMod(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.RightShift, SymbolType l, SymbolType r)
                when l.IsInteger() && r.IsInteger()
                => Buffer.InsertOpShiftRightLogical(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.LeftShift, SymbolType l, SymbolType r)
                when l.IsInteger() && r.IsInteger()
                => Buffer.InsertOpShiftRightLogical(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.AND, SymbolType l, SymbolType r)
                when l.IsInteger() && r.IsInteger()
                => Buffer.InsertOpBitwiseAnd(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.OR, SymbolType l, SymbolType r)
                when l.IsInteger() && r.IsInteger()
                => Buffer.InsertOpBitwiseOr(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.XOR, SymbolType l, SymbolType r)
                when l.IsInteger() && r.IsInteger()
                => Buffer.InsertOpBitwiseXor(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.LogicalAND, ScalarSymbol { TypeName: "bool" }, ScalarSymbol { TypeName: "bool" })
                => Buffer.InsertOpLogicalAnd(Position, context.Bound++, resultType, left.Id, right.Id),

            (Operator.LogicalOR, ScalarSymbol { TypeName: "bool" }, ScalarSymbol { TypeName: "bool" })
                => Buffer.InsertOpLogicalOr(Position, context.Bound++, resultType, left.Id, right.Id),
                
            _ => throw new NotImplementedException()
        };
        Position += instruction.WordCount;
        if (instruction.ResultId is int resultId)
        {
            if (name is not null)
                context.AddName(instruction, name);
            return new(instruction, resultId, name);
        }
        else throw new NotImplementedException("Instruction should have result id");
    }


    
}




internal static class SymbolExtensions
{

    public static bool IsSignedInteger(this SymbolType symbol) => symbol is ScalarSymbol { TypeName: "sbyte" or "short" or "int" or "long" };
    public static bool IsUnsignedInteger(this SymbolType symbol) => symbol is ScalarSymbol { TypeName: "byte" or "ushort" or "uint" or "ulong" };
    public static bool IsFloating(this SymbolType symbol) => symbol is ScalarSymbol { TypeName: "half" or "float" or "double" };
    public static bool IsInteger(this SymbolType symbol) => symbol.IsSignedInteger() || symbol.IsUnsignedInteger();
    public static bool IsNumber(this SymbolType symbol) => symbol.IsInteger() || symbol.IsFloating();
    public static bool IsSigned(this SymbolType symbol) => symbol.IsSignedInteger() || symbol.IsFloating();
    public static bool IsUnsigned(this SymbolType symbol) => symbol.IsUnsignedInteger();
    public static bool IsSignedIntegerVector(this SymbolType symbol)
        => symbol.IsSignedInteger() || symbol is VectorSymbol v && v.BaseType.IsSignedInteger();
    public static bool IsUnsignedIntegerVector(this SymbolType symbol)
        => symbol.IsUnsignedInteger() || symbol is VectorSymbol v && v.BaseType.IsUnsignedInteger();
    public static bool IsIntegerVector(this SymbolType symbol)
        => symbol.IsInteger() || symbol is VectorSymbol v && v.BaseType.IsInteger();
    public static bool IsFloatingVector(this SymbolType symbol)
        => symbol.IsFloating() || symbol is VectorSymbol v && v.BaseType.IsFloating();
    public static bool IsNumberVector(this SymbolType symbol)
        => symbol.IsNumber() || symbol is VectorSymbol v && v.BaseType.IsNumber();
    public static bool IsSignedVector(this SymbolType symbol)
        => symbol.IsSignedIntegerVector() || symbol.IsFloatingVector();
    public static bool IsUnsignedVector(this SymbolType symbol)
        => symbol.IsUnsignedIntegerVector();

    public static bool SameComponentCount(SymbolType left, SymbolType right)
        => (right, left) switch
        {
            (ScalarSymbol l, ScalarSymbol r) => true,
            (VectorSymbol l, ScalarSymbol r) => l.Size == 1,
            (ScalarSymbol l, VectorSymbol r) => r.Size == 1,
            (VectorSymbol l, VectorSymbol r) => l.Size == r.Size,
            (MatrixSymbol l, VectorSymbol r) => l.Columns == 1 && l.Rows == r.Size,
            (VectorSymbol l, MatrixSymbol r) => r.Columns == 1 && r.Rows == l.Size,
            (MatrixSymbol l, MatrixSymbol r) => r.Columns == l.Columns && r.Rows == l.Rows,
            _ => false
        };
    public static bool SameBaseTypeWidth(SymbolType left, SymbolType right)
        => (right, left) switch
        {
            (ScalarSymbol { TypeName: "byte" or "sbyte" }, ScalarSymbol { TypeName: "byte" or "sbyte" }) => true,
            (ScalarSymbol { TypeName: "ushort" or "short" or "half" }, ScalarSymbol { TypeName: "ushort" or "short" or "half" }) => true,
            (ScalarSymbol { TypeName: "uint" or "int" or "float" }, ScalarSymbol { TypeName: "uint" or "int" or "float" }) => true,
            (ScalarSymbol { TypeName: "ulong" or "long" or "double" }, ScalarSymbol { TypeName: "ulong" or "long" or "double" }) => true,
            (VectorSymbol l, ScalarSymbol r) => SameBaseType(l.BaseType, r),
            (ScalarSymbol l, VectorSymbol r) => SameBaseType(l, r.BaseType),
            (VectorSymbol l, VectorSymbol r) => SameBaseType(l.BaseType, r.BaseType),
            (MatrixSymbol l, VectorSymbol r) => SameBaseType(l.BaseType, r.BaseType),
            (VectorSymbol l, MatrixSymbol r) => SameBaseType(l.BaseType, r.BaseType),
            (MatrixSymbol l, MatrixSymbol r) => SameBaseType(l.BaseType, r.BaseType),
            _ => false
        };

    public static bool SameComponentCountAndWidth(SymbolType left, SymbolType right)
        => SameComponentCount(left, right) && SameBaseTypeWidth(left, right);
    public static bool SameBaseType(SymbolType left, SymbolType right)
        => (right, left) switch
        {
            (ScalarSymbol l, ScalarSymbol r) => l == r,
            (VectorSymbol l, ScalarSymbol r) => l.BaseType == r,
            (ScalarSymbol l, VectorSymbol r) => r.BaseType == l,
            (VectorSymbol l, VectorSymbol r) => l.BaseType == r.BaseType,
            (MatrixSymbol l, VectorSymbol r) => l.BaseType == r.BaseType,
            (VectorSymbol l, MatrixSymbol r) => l.BaseType == r.BaseType,
            (MatrixSymbol l, MatrixSymbol r) => l.BaseType == r.BaseType,
            _ => false
        };
    public static bool SameSignage(SymbolType left, SymbolType right)
        => (right, left) switch
        {
            (ScalarSymbol l, ScalarSymbol r) => l.IsInteger() && l.IsInteger(),
            (VectorSymbol l, ScalarSymbol r) => l.BaseType == r,
            (ScalarSymbol l, VectorSymbol r) => r.BaseType == l,
            (VectorSymbol l, VectorSymbol r) => l.BaseType == r.BaseType,
            (MatrixSymbol l, VectorSymbol r) => l.BaseType == r.BaseType,
            (VectorSymbol l, MatrixSymbol r) => l.BaseType == r.BaseType,
            (MatrixSymbol l, MatrixSymbol r) => l.BaseType == r.BaseType,
            _ => false
        };
}