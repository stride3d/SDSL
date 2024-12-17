using Stride.Shaders.Core;
using Stride.Shaders.Parsing.SDSL;

namespace Stride.Shaders.Parsing.Analysis;

public static class OperatorTable
{

    public static bool CheckBinaryOperation(SymbolType left, SymbolType right, Operator op)
    {
        int a = 0;
        float b = 0;
        var c = b * a;
        return (left, right, op) switch
        {
            // Scalar operations
            (
                Scalar { TypeName: "int" or "long" }, Scalar { TypeName: "int" },
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
                or Operator.LeftShift or Operator.RightShift
                or Operator.OR or Operator.XOR or Operator.AND
            ) => true,
            (
                Scalar { TypeName: "float" or "double" }, Scalar { TypeName: "double" or "float" or "int" },
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
            ) => true,
            (
                Scalar { TypeName: "float" } or Scalar { TypeName: "int" }, Scalar { TypeName: "float" },
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
            ) => true,

            // Vector operations
            (
                Vector { BaseType: Scalar { TypeName: "int" or "long" or "float" } } or Scalar { TypeName: "int" or "float" or "long" or "double" },
                Vector { BaseType: Scalar { TypeName: "int" or "long" or "float" } } or Scalar { TypeName: "int" or "float" or "long" or "double" },
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
            ) => true,
            // Matrix operations
            (
                Matrix { BaseType: Scalar { TypeName: "int" or "long" or "float" } } or Scalar { TypeName: "int" or "float" or "long" or "double" },
                Matrix { BaseType: Scalar { TypeName: "int" or "long" or "float" } } or Scalar { TypeName: "int" or "float" or "long" or "double" },
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
            ) => true,
            (
                Matrix { BaseType: Scalar { TypeName: "int" or "long" or "float" } } or Vector { BaseType: Scalar { TypeName: "int" or "float" or "long" or "double" } },
                Matrix { BaseType: Scalar { TypeName: "int" or "long" or "float" } } or Vector { BaseType: Scalar { TypeName: "int" or "float" or "long" or "double" } },
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
            ) => true,

            _ => false,
        };
    }
    public static SymbolType BinaryOperationResultingType(SymbolType left, SymbolType right, Operator op)
    {
        int a = 0;
        float b = 0;
        var c = b * a;
        return (left, right) switch
        {
            (Scalar { TypeName: "int" or "float" }, Scalar { TypeName: "float" }) => right,
            (Scalar { TypeName: "float" }, Scalar { TypeName: "int" or "float" }) => left,
            (Vector { BaseType: Scalar{ TypeName : "float" }}, Scalar { TypeName: "int" or "float" }) => right,
            (Vector { BaseType: Scalar{ TypeName : "int" }} l, Scalar { TypeName: "int" or "float" } r) => new Vector(r, l.Size),            
            _ => throw new NotImplementedException(),
        };
    }
}