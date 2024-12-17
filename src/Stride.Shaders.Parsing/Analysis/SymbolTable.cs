using System.Text.RegularExpressions;
using Stride.Shaders.Core;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.Analysis;


public partial class SymbolTable : ISymbolProvider
{
    public Dictionary<string, SymbolType> DeclaredTypes { get; } = [];
    public Dictionary<string, Symbol> CurrentTable => Symbols[^1];
    public Dictionary<string, Symbol> RootSymbols => Symbols[0];
    public List<Dictionary<string, Symbol>> Symbols { get; } = [[]];


    public void Push() => Symbols.Add([]);
    public Dictionary<string, Symbol> Pop()
    {
        var scope = Symbols[^1];
        Symbols.Remove(scope);
        return scope;
    }

    public void Import(ISymbolProvider symbols)
    {
        foreach (var (name, type) in symbols.DeclaredTypes)
            DeclaredTypes.TryAdd(name, type);
        foreach (var (name, symbol) in symbols.RootSymbols)
            RootSymbols.Add(name, symbol);
    }

    public void Process(ShaderClass sclass)
    {
        foreach (var member in sclass.Elements)
        {
            if (member is ShaderMethod method)
            {
                var typeString = method.ReturnType.ToString();
                var sym = ParseType(typeString);
                DeclaredTypes.TryAdd(typeString, sym);
                RootSymbols.Add(method.Name, new(method.Name, sym, SymbolKind.Method));
            }
            else if (member is ShaderMember variable)
            {
                var typeString = variable.Type.ToString();
                var sym = ParseType(typeString);
                DeclaredTypes.TryAdd(typeString, sym);
                RootSymbols.Add(variable.Name, new(variable.Name, sym, SymbolKind.Variable));
            }
        }
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