using Stride.Shaders.Core;
using Stride.Shaders.Core.Analysis;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.Analysis;

public partial class SymbolTable
{
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
        {
            foreach (var member in c.Elements)
            {
                if(member is ShaderMethod func)
                {
                    func.Type = func.ReturnTypeName.ToSymbol();
                    RootSymbols.Add(new(func.Name, SymbolKind.Method), new(func.Name, func.Type, SymbolKind.Method));
                    DeclaredTypes.TryAdd(func.Type.ToString(), func.Type);
                }
                else if(member is ShaderMember svar)
                {
                    svar.Type = svar.TypeName.ToSymbol();
                    RootSymbols.Add(
                        new(
                            svar.Name, 
                            svar.TypeModifier == TypeModifier.Const ? SymbolKind.Constant : SymbolKind.Variable
                        ),
                        new(svar.Name, svar.TypeName.ToSymbol(), 
                        SymbolKind.Variable)
                    );
                    DeclaredTypes.TryAdd(svar.Type.ToString(), svar.Type);
                }
            }
            foreach (var member in c.Elements)
                Process(member);
        }
        else if (node is ShaderBuffer cbuff)
        {
            var sym = new Symbol(cbuff.Name.ToString() ?? "", new BufferSymbol(cbuff.Name.ToString() ?? "", []), SymbolKind.CBuffer);

            DeclaredTypes.TryAdd(sym.ToString(), sym.Type);
            var kind = cbuff switch
            {
                CBuffer => SymbolKind.CBuffer,
                TBuffer => SymbolKind.TBuffer,
                RGroup => SymbolKind.RGroup,
                _ => throw new NotSupportedException()
            };
            RootSymbols.Add(new(cbuff.Name.ToString() ?? "", kind), sym);
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
            RootSymbols.Add(new(str.TypeName.ToString() ?? "", SymbolKind.Struct), sym);
            foreach (var smem in str.Members)
            {
                var msym = smem.TypeName.ToSymbol();
                DeclaredTypes.TryAdd(sym.ToString(), sym.Type);
                smem.Type = msym;
            }
        }
        else if (node is ShaderMethod method)
        {
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
        }
        else if (node is BlockStatement block)
            foreach (var s in block.Statements)
                Process(s);
        else if (node is ConditionalFlow flow)
        {
            Process(flow.If.Condition);
            Process(flow.If.Body);
            if (flow.ElseIfs.Count > 0)
            {
                foreach (var ei in flow.ElseIfs)
                {
                    Process(ei.Condition);
                    Process(ei.Body);
                }
            }
            if (flow.Else != null)
                Process(flow.Else.Body);
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
                    if (d.Value is not null)
                    {
                        Process(d.Value!);
                        var isConstExpr = IsConstantExpression(d.Value);
                    }
                    CurrentTable.Add(new(d.Variable, SymbolKind.Variable), new(d.Variable, declare.Type, SymbolKind.Variable));
                }
            }
        }
        else if (node is BinaryExpression bexp)
        {
            Process(bexp.Left);
            Process(bexp.Right);
            if (
                OperatorTable.BinaryOperationResultingType(
                    bexp.Left.Type ?? new Undefined("undefined"),
                    bexp.Right.Type ?? new Undefined("undefined"),
                    bexp.Op,
                    out var t
                )
            )
                bexp.Type = t;
            else
                Errors.Add(new(bexp.Info, SDSLErrorMessages.SDSL0104));
        }
        else if (node is Identifier id)
        {
            for (int i = Symbols.Count - 1; i >= 0; i -= 1)
            {
                if (Symbols[i].TryGetValue(id, SymbolKind.Variable, out var symbol))
                {
                    if (symbol.Type.GetType() != typeof(Undefined) && symbol.Type != null)
                        id.Type = symbol.Type;
                    else
                        id.Type = symbol.Type ?? new Undefined(id);
                    break;
                }
            }
        }
        else if (node is IntegerLiteral ilit)
        {
            ilit.Type = ilit.Suffix switch
            {
                { Signed:  true, Size:  8 } => Scalar.From("sbyte"),
                { Signed:  true, Size: 16 } => Scalar.From("short"),
                { Signed:  true, Size: 32 } => Scalar.From("int"),
                { Signed:  true, Size: 64 } => Scalar.From("long"),
                { Signed: false, Size:  8 } => Scalar.From("byte"),
                { Signed: false, Size: 16 } => Scalar.From("ushort"),
                { Signed: false, Size: 32 } => Scalar.From("uint"),
                { Signed: false, Size: 64 } => Scalar.From("ulong"),
                _ => throw new NotImplementedException("Unsupported integer suffix")
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
        else if(node is BoolLiteral boolLit)
            boolLit.Type = Scalar.From("bool");
        else throw new NotImplementedException($"{node.GetType()} is not supported.");
        // else Errors.Add(new(node.Info, SDSLErrorMessages.SDSL0105));
    }
}