using Stride.Shaders.Core;
using Stride.Shaders.Core.Analysis;
using Stride.Shaders.Parsing.Analysis;
using Stride.Shaders.Spirv.Building;

namespace Stride.Shaders.Parsing.SDSL.AST;




public class ShaderClass(Identifier name, TextLocation info) : ShaderDeclaration(info)
{
    public Identifier Name { get; set; } = name;
    public List<ShaderElement> Elements { get; set; } = [];
    public ShaderParameterDeclarations? Generics { get; set; }
    public List<Mixin> Mixins { get; set; } = [];


    public override void ProcessSymbol(SymbolTable table)
    {
        foreach (var member in Elements)
        {
            if (member is ShaderMethod func)
            {
                func.ReturnTypeName.ProcessSymbol(table);
                var ftype = new FunctionTypeSymbol([func.ReturnTypeName.Type]);
                foreach (var arg in func.Parameters)
                {
                    arg.TypeName.ProcessSymbol(table);
                    var argSym = arg.TypeName.Type;
                    table.DeclaredTypes.TryAdd(argSym.ToString(), argSym);
                    arg.Type = argSym;
                    ftype.Types.Add(arg.Type);
                }
                func.Type = ftype;

                table.RootSymbols.Add(new(func.Name, SymbolKind.Method), new(new(func.Name, SymbolKind.Method), func.Type));
                table.DeclaredTypes.TryAdd(func.Type.ToString(), func.Type);
            }
            else if (member is ShaderMember svar)
            {
                svar.TypeName.ProcessSymbol(table);
                svar.Type = svar.TypeName.Type;
                var sid = 
                    new SymbolID
                    (
                        svar.Name,
                        svar.TypeModifier == TypeModifier.Const ? SymbolKind.Constant : SymbolKind.Variable,
                        svar.StreamKind switch
                        {
                            StreamKind.Stream or StreamKind.PatchStream => Storage.Stream,
                            _ => Storage.None
                        }
                    );
                table.RootSymbols.Add
                    (
                        sid,
                        new(sid, svar.Type)
                    );
                table.DeclaredTypes.TryAdd(svar.Type.ToString(), svar.Type);
            }
        }

        foreach (var member in Elements)
        {
            if (member is not ShaderMember)
                member.ProcessSymbol(table);
        }
    }


    public void Compile(CompilerUnit compiler, SymbolTable table)
    {
        throw new NotImplementedException();
    }


    public override string ToString()
    {
        return
$"""
Class : {Name}
Generics : {string.Join(", ", Generics)}
Inherits from : {string.Join(", ", Mixins)}
Body :
{string.Join("\n", Elements)}
""";
    }
}


public class ShaderGenerics(Identifier typename, Identifier name, TextLocation info) : Node(info)
{
    public Identifier Name { get; set; } = name;
    public Identifier TypeName { get; set; } = typename;
}

public class Mixin(Identifier name, TextLocation info) : Node(info)
{
    public List<Identifier> Path { get; set; } = [];
    public Identifier Name { get; set; } = name;
    public ShaderExpressionList? Generics { get; set; }
    public override string ToString()
        => Generics switch
        {
            null => Name.Name,
            _ => $"{Name}<{Generics}>"
        };
}

public abstract class ShaderMixinValue(TextLocation info) : Node(info);
public class ShaderMixinExpression(Expression expression, TextLocation info) : ShaderMixinValue(info)
{
    public Expression Value { get; set; } = expression;
}
public class ShaderMixinIdentifier(Identifier identifier, TextLocation info) : ShaderMixinValue(info)
{
    public Identifier Value { get; set; } = identifier;
}