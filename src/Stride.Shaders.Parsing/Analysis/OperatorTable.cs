using Stride.Shaders.Core;
using Stride.Shaders.Parsing.SDSL;

namespace Stride.Shaders.Parsing.Analysis;

public static class OperatorTable
{

    public static bool CheckBinaryOperation(SymbolType left, SymbolType right, Operator op)
    {
        return (left, right, op) switch
        {
            // Scalar operations
            (
                ScalarSymbol { TypeName: "int" or "long" }, ScalarSymbol { TypeName: "int" },
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
                or Operator.LeftShift or Operator.RightShift
                or Operator.OR or Operator.XOR or Operator.AND
            ) => true,
            (
                ScalarSymbol { TypeName: "float" or "double" }, ScalarSymbol { TypeName: "double" or "float" or "int" },
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
            ) => true,
            (
                ScalarSymbol { TypeName: "float" } or ScalarSymbol { TypeName: "int" }, ScalarSymbol { TypeName: "float" },
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
            ) => true,

            // Vector operations
            (
                VectorSymbol { BaseType: ScalarSymbol { TypeName: "int" or "long" or "float" } } or ScalarSymbol { TypeName: "int" or "float" or "long" or "double" },
                VectorSymbol { BaseType: ScalarSymbol { TypeName: "int" or "long" or "float" } } or ScalarSymbol { TypeName: "int" or "float" or "long" or "double" },
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
            ) => true,
            // Matrix operations
            (
                MatrixSymbol { BaseType: ScalarSymbol { TypeName: "int" or "long" or "float" } } or ScalarSymbol { TypeName: "int" or "float" or "long" or "double" },
                MatrixSymbol { BaseType: ScalarSymbol { TypeName: "int" or "long" or "float" } } or ScalarSymbol { TypeName: "int" or "float" or "long" or "double" },
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
            ) => true,
            (
                MatrixSymbol { BaseType: ScalarSymbol { TypeName: "int" or "long" or "float" } } or VectorSymbol { BaseType: ScalarSymbol { TypeName: "int" or "float" or "long" or "double" } },
                MatrixSymbol { BaseType: ScalarSymbol { TypeName: "int" or "long" or "float" } } or VectorSymbol { BaseType: ScalarSymbol { TypeName: "int" or "float" or "long" or "double" } },
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
            ) => true,

            _ => false,
        };
    }
    public static bool BinaryOperationResultingType(SymbolType left, SymbolType right, Operator op, out SymbolType? result)
    {
        // TODO : correct that part
        result = ((int)op, left, right) switch
        {
            // Boolean operations
            (>= 22 and < 26, ScalarSymbol{ TypeName : "bool"}, ScalarSymbol {TypeName: "bool"}) => left,
            // Linear algebra
            (>=8 and < 13, ScalarSymbol {TypeName: "int" or "uint" or "float" or "long" or "ulong" or "double"} l, ScalarSymbol r) when l.TypeName == r.TypeName => right,
            (>=8 and < 13, ScalarSymbol { TypeName: "int" or "uint" or "long" or "ulong" }, ScalarSymbol { TypeName: "float" or "double"}) => right,
            (>=8 and < 13, ScalarSymbol { TypeName: "float" }, ScalarSymbol { TypeName: "int" or "float" }) => left,
            (>=8 and < 13, VectorSymbol l, VectorSymbol r) when l.BaseType == r.BaseType => right,
            (>=8 and < 13, VectorSymbol, ScalarSymbol) => left,
            (>=8 and < 13, MatrixSymbol l, MatrixSymbol r) when l.BaseType == r.BaseType => right,
            (>=8 and < 13, MatrixSymbol l, ScalarSymbol r) => l,
            (>=8 and < 13, MatrixSymbol l, VectorSymbol r) => l,
            (>=8 and < 13, MatrixSymbol { BaseType: ScalarSymbol { TypeName: "int" } } l, MatrixSymbol { BaseType: ScalarSymbol { TypeName: "int" or "float" } } r) => l,
            // Comparison
            (>=18 and < 22, SymbolType l, SymbolType r) when l == r => ScalarSymbol.From("bool"),
            _ => null,
        };
        return result != null;
    }
}