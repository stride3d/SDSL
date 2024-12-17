using Stride.Shaders.Core;
using Stride.Shaders.Parsing.SDSL;

namespace Stride.Shaders.Parsing.Analysis;

public static class OperatorTable
{

    public static bool CheckBinaryOperation(SymbolType left, SymbolType right, Operator op)
    {
        double a = 0;
        float b = 0;
        var c = b * a;
        return (left, right, op) switch
        {
            // Scalar operations
            (
                Scalar {TypeName: "int" or "long"}, Scalar {TypeName: "int"},
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
                or Operator.LeftShift or Operator.RightShift 
                or Operator.OR or Operator.XOR or Operator.AND
            ) => true,
            (
                Scalar {TypeName: "float" or "double"}, Scalar {TypeName: "double" or "float" or "int"},
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
            ) => true,
            (
                Scalar {TypeName: "float"} or Scalar {TypeName: "int"}, Scalar {TypeName: "float"},
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
            ) => true,

            // Vector operations
            (
                Vector {BaseType: Scalar{TypeName: "int" or "long" or "float"}} or Scalar {TypeName: "int" or "float" or "long" or "double"},
                Vector {BaseType: Scalar{TypeName: "int" or "long" or "float"}} or Scalar {TypeName: "int" or "float" or "long" or "double"},
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
            ) => true,
            // Matrix operations
            (
                Matrix {BaseType: Scalar{TypeName: "int" or "long" or "float"}} or Scalar {TypeName: "int" or "float" or "long" or "double"},
                Matrix {BaseType: Scalar{TypeName: "int" or "long" or "float"}} or Scalar {TypeName: "int" or "float" or "long" or "double"},
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
            ) => true,
            (
                Matrix {BaseType: Scalar{TypeName: "int" or "long" or "float"}} or Vector {BaseType : Scalar {TypeName: "int" or "float" or "long" or "double"}},
                Matrix {BaseType: Scalar{TypeName: "int" or "long" or "float"}} or Vector {BaseType : Scalar {TypeName: "int" or "float" or "long" or "double"}},
                Operator.Plus or Operator.Minus or Operator.Mul or Operator.Div or Operator.Mod
            ) => true,

            _ => false,
        };
    }
    // public static Dictionary<(SymbolType, SymbolType), List<Operator>> AllowedBinaryOperations { get; }
    //     = new ()
    //     {
    //         { (new Scalar("int"), new Scalar("int")), "+,-,*,/,%,<<,>>,&,|,^".ToOperators() }
    //         { (new Scalar("int"), new Scalar("float")), "+,-,*,/,%".ToOperators() }
    //         { (new Scalar("float"), new Scalar("int")), "+,-,*,/,%".ToOperators() }
    //         { (new Scalar("long"), new Scalar("int")), "+,-,*,/,%,<<,>>".ToOperators() }
    //         { (new Scalar("long"), new Scalar("int")), "+,-,*,/,%".ToOperators() }
    //         { (new Scalar("int"), new Scalar("float")), "+,-,*,/,%".ToOperators() }
    //     };

    // internal static List<Operator> ToOperators(this string operators)
    // {
    //     uint a = 0; int b = 0;
    //     var c = a << b;
    //     var result = new List<Operator>(operators.AsSpan().Count(','));
    //     foreach(var op in operators.AsSpan().Split(','))
    //         result.Add(op.ToString().ToOperator());
    //     return result;
    // }
}