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
        if (node is ShaderFile f)
        {
            foreach (var ns in f.Namespaces)
                Process(ns);
            foreach(var e in f.RootDeclarations)
                Process(e);
        }
        else if (node is ShaderClass c)
            foreach (var member in c.Elements)
                Process(member);
        else if (node is ShaderMember variable)
        {
            var sym = variable.TypeName.ToSymbol();
            DeclaredTypes.TryAdd(sym.ToString(), sym);
            RootSymbols.Add(variable.Name, new(variable.Name, sym, SymbolKind.Variable));
            variable.Type = sym;
        }
        else if(node is ShaderBuffer cbuff)
        {
            var sym = new Symbol(cbuff.Name.ToString() ?? "", new BufferSymbol(cbuff.Name.ToString() ?? "", []), SymbolKind.CBuffer);

            DeclaredTypes.TryAdd(sym.ToString(), sym.Type);
            RootSymbols.Add(cbuff.Name.ToString() ?? "", sym);
            foreach (var cbmem in cbuff.Members)
            {
                var msym = cbmem.TypeName.ToSymbol();
                DeclaredTypes.TryAdd(sym.ToString(), sym.Type);
                cbmem.Type = msym;
            }
        }
        else if(node is ShaderStruct str)
        {
            var sym = new Symbol(str.TypeName.ToString() ?? "", new Struct(str.TypeName.ToString() ?? "", []), SymbolKind.Struct);
            DeclaredTypes.TryAdd(sym.ToString(), sym.Type);
            RootSymbols.Add(str.TypeName.ToString() ?? "", sym);
            foreach (var smem in str.Members)
            {
                var msym = smem.TypeName.ToSymbol();
                DeclaredTypes.TryAdd(sym.ToString(), sym.Type);
                smem.Type = msym;
            }
        }
        else if (node is ShaderMethod method)
        {
            var sym = method.ReturnTypeName.ToSymbol();
            DeclaredTypes.TryAdd(sym.ToString(), sym);
            RootSymbols.Add(method.Name, new(method.Name, sym, SymbolKind.Method));
            foreach (var arg in method.Parameters)
            {
                var argSym = arg.TypeName.ToSymbol();
                DeclaredTypes.TryAdd(argSym.ToString(), argSym);
                arg.Type = argSym;
            }
            if (method.Body is not null)
                foreach (var s in method.Body.Statements)
                    Process(s);
            method.ReturnType = sym;
        }
        else if(node is Declaration declaration)
        {
            declaration.Type = declaration.TypeName.ToSymbol();
            DeclaredTypes.TryAdd(declaration.TypeName.ToString(), declaration.Type);
        }
    }
}