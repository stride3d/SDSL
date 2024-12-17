using System.Text.RegularExpressions;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Core.Analysis;

public static partial class TypeNameExtensions
{
    public static SymbolType ToSymbol(this TypeName typeName)
    {

        var t =  typeName switch
        {
            var v when !v.IsArray && v.Generics.Count == 0 && ScalarPattern().IsMatch(v.Name) => ParseType(v.Name),
            _ => throw new NotImplementedException()
        };
        typeName.Type = t;
        return t;
    }
    
    #region symbol type parsing

    [GeneratedRegex(@"^((s?byte)|(u?(short|int|long))|(half|float|double))$")]
    private static partial Regex ScalarPattern();
    [GeneratedRegex(@"^((s?byte)|(u?(short|int|long))|(half|float|double))([2-4])$")]
    private static partial Regex VectorPattern();
    [GeneratedRegex(@"^((s?byte)|(u?(short|int|long))|(half|float|double))([2-4])x([2-4])$")]
    private static partial Regex MatrixPattern();
    [GeneratedRegex(@"^((s?byte)|(u?(short|int|long))|(half|float|double))[\s\n]*\[[\s\n]*([0-9]+)?[\s\n]*\]$")]
    private static partial Regex ArrayPattern();
    public static SymbolType ParseType(string typename)
    {
        if (ScalarPattern().IsMatch(typename))
            return new Scalar(typename);
        else if (VectorPattern().IsMatch(typename))
        {
            var matches = VectorPattern().Match(typename);
            var size = int.Parse(matches.Groups[6].ValueSpan);
            var baseType = matches.Groups[1].Value;
            return new Vector(new Scalar(baseType), size);
        }
        else if (MatrixPattern().IsMatch(typename))
        {
            var matches = MatrixPattern().Match(typename);
            var width = int.Parse(matches.Groups[6].ValueSpan);
            var length = int.Parse(matches.Groups[7].ValueSpan);
            var baseType = matches.Groups[1].Value;
            return new Matrix(new Scalar(baseType), width, length);
        }
        else if (ArrayPattern().IsMatch(typename))
        {
            var matches = ArrayPattern().Match(typename);
            return new Core.Array(ParseType(matches.Groups[1].Value), int.Parse(matches.Groups[6].ValueSpan));
        }
        else throw new NotImplementedException();
    }
    #endregion

}