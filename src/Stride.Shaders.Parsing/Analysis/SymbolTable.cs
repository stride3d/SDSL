using System.Text.RegularExpressions;
using Stride.Shaders.Core;
using Stride.Shaders.Core.Analysis;
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

    public void Process(Node node)
    {
        if (node is ShaderClass c)
            Process(c);
        else if (node is ShaderFile f)
            Process(f.RootDeclarations.OfType<ShaderClass>().First());
    }

    public void Process(ShaderClass sclass)
    {
        foreach (var member in sclass.Elements)
        {
            if (member is ShaderMethod method)
            {
                var sym = method.ReturnType.ToSymbol();
                DeclaredTypes.TryAdd(sym.ToString(), sym);
                RootSymbols.Add(method.Name, new(method.Name, sym, SymbolKind.Method));
            }
            else if (member is ShaderMember variable)
            {
                var sym = variable.Type.ToSymbol();
                DeclaredTypes.TryAdd(sym.ToString(), sym);
                RootSymbols.Add(variable.Name, new(variable.Name, sym, SymbolKind.Variable));
            }
        }
    }
}