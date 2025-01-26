using System.Text.RegularExpressions;
using Stride.Shaders.Core;
using Stride.Shaders.Core.Analysis;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.Analysis;

public record struct SemanticErrors(TextLocation Location, string Message);

public partial class SymbolTable : ISymbolProvider
{
    public Dictionary<string, SymbolType> DeclaredTypes { get; } = [];
    public Dictionary<string, Symbol> CurrentTable => Symbols[^1];
    public Dictionary<string, Symbol> RootSymbols => Symbols[0];
    public List<Dictionary<string, Symbol>> Symbols { get; } = [[]];

    public List<SemanticErrors> Errors { get; } = [];


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
            foreach (var e in f.RootDeclarations)
                Process(e);
        }
        else if (node is ShaderNamespace ns)
            foreach (var e in ns.Declarations)
                Process(e);
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
        else if (node is ShaderBuffer cbuff)
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
        else if (node is ShaderStruct str)
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
            {
                Push();
                foreach (var s in method.Body.Statements)
                    Process(s);
                Pop();
            }
            method.ReturnType = sym;
        }
        else if (node is Declare declare)
        {
            if (declare.TypeName == "var")
            {
                if (declare.Variables.Count == 1 && declare.Variables[0].Value is not null)
                {
                    Process(declare.Variables[0].Value!);
                    declare.Type = declare.Variables[0].Value!.Type;
                }
                else
                    Errors.Add(new(declare.Info, SDSLErrorMessages.SDSL0104));
            }
            else
            {
                declare.Type = declare.TypeName.ToSymbol();
                DeclaredTypes.TryAdd(declare.TypeName.ToString(), declare.Type);
                foreach (var d in declare.Variables)
                {
                    if(d.Value is not null)
                        Process(d.Value!);
                    CurrentTable.Add(d.Variable, new(d.Variable, declare.Type, SymbolKind.Variable));
                }
            }
        }
        else if (node is IntegerLiteral ilit)
        {
            ilit.Type = ilit.Suffix switch
            {
                { Signed: true, Size: 8 } => Scalar.From("sbyte"),
                { Signed: true, Size: 16 } => Scalar.From("short"),
                { Signed: true, Size: 32 } => Scalar.From("int"),
                { Signed: true, Size: 64 } => Scalar.From("long"),
                { Signed: false, Size: 8 } => Scalar.From("byte"),
                { Signed: false, Size: 16 } => Scalar.From("ushort"),
                { Signed: false, Size: 32 } => Scalar.From("uint"),
                { Signed: false, Size: 64 } => Scalar.From("ulong"),
                _ => throw new NotImplementedException("Unsupported integer")
            };
        }
        else if (node is FloatLiteral flit)
        {
            flit.Type = flit.Suffix.Size switch
            {
                16 => Scalar.From("half"),
                32 => Scalar.From("float"),
                64 => Scalar.From("double"),
                _ => throw new NotImplementedException("Unsupported float")
            };
        }
        else Errors.Add(new(node.Info, SDSLErrorMessages.SDSL0105));
    }
}