using Stride.Shaders.Core;
using Stride.Shaders.Core.Analysis;
using Stride.Shaders.Parsing.Analysis;

namespace Stride.Shaders.Parsing.SDSL.AST;


public abstract class MethodOrMember(TextLocation info, bool isStaged = false) : ShaderElement(info)
{
    public bool IsStaged { get; set; } = isStaged;
    public List<ShaderAttribute> Attributes { get; set; } = [];
}


public class SamplerStateAssign(Identifier name, Expression value, TextLocation info) : ShaderElement(info)
{
    public Identifier Name { get; set; } = name;
    public Expression Value { get; set; } = value;

    public override string ToString()
    {
        return $"{Name} = {Value}";
    }
}

public class ShaderSamplerState(Identifier name, TextLocation info) : MethodOrMember(info)
{
    public Identifier Name { get; set; } = name;
    public List<SamplerStateAssign> Members { get; set; } = [];

    public override string ToString()
    {
        return $"SamplerState {Name} ({string.Join(", ", Members)})";
    }
}
public class ShaderSamplerComparisonState(Identifier name, TextLocation info) : MethodOrMember(info)
{
    public Identifier Name { get; set; } = name;
    public List<SamplerStateAssign> Members { get; set; } = [];

    public override string ToString()
    {
        return $"SamplerState {Name} ({string.Join(", ", Members)})";
    }
}


public class ShaderCompose(Identifier name, Mixin mixin, bool isArray, TextLocation info) : MethodOrMember(info)
{
    public Identifier Name { get; set; } = name;
    public Mixin Mixin { get; set; } = mixin;
    public bool IsArray { get; set; } = isArray;
    public override string ToString() => $"compose {Mixin}{(IsArray ? "[]" : "")} {Name}";
}

public sealed class ShaderMember(TypeName type,
        Identifier name,
        Expression? initialValue,
        bool isArray,
        TextLocation location,
        bool isStaged = false,
        StreamKind streamKind = StreamKind.None,
        Identifier? semantic = null,
        List<Expression>? arraySizes = null,
        InterpolationModifier interpolation = InterpolationModifier.None,
        StorageClass storageClass = StorageClass.None,
        TypeModifier typeModifier = TypeModifier.None
    ) : MethodOrMember(location, isStaged)
{
    public TypeName TypeName { get; set; } = type;
    public Identifier Name { get; set; } = name;
    public Identifier? Semantic { get; set; } = semantic;
    public StreamKind StreamKind { get; set; } = streamKind;
    public bool IsArray { get; set; } = isArray;
    public List<Expression>? ArraySizes { get; set; } = arraySizes;
    public Expression? Value { get; set; } = initialValue;
    public TypeModifier TypeModifier { get; set; } = typeModifier;
    public StorageClass StorageClass { get; set; } = storageClass;
    public InterpolationModifier Interpolation { get; set; } = interpolation;

    public override string ToString()
    {
        if(Attributes != null)
            return $"[{string.Join(" ", Attributes.Select(x => x.ToString()))}]\n{TypeName} {Name}";
        else
            return $"{TypeName} {Name}";
    }
}

public class MethodParameter(TypeName type, Identifier name, TextLocation info, string? storage = null, Expression? arraySize = null, Identifier? semantic = null) : Node(info)
{
    public TypeName TypeName { get; set; } = type;
    public SymbolType? Type { get; set; }
    public Identifier Name { get; set; } = name;
    public Identifier? Semantic { get; set; } = semantic;
    public Expression? ArraySize { get; set; } = arraySize;
    public string? Storage { get; set; } = storage;

    public override string ToString()
    {
        return $"{Type} {Name}";
    }
}

public class ShaderMethod(
        TypeName returnType,
        Identifier name,
        TextLocation info,
        Identifier? visibility = null,
        Identifier? storage = null,
        bool isStaged = false,
        bool isAbstract = false,
        bool isVirtual = false,
        bool isStatic = false,
        bool isOverride = false,
        bool isClone = false
    ) : MethodOrMember(info, isStaged)
{

    public SymbolType? ReturnType { get; set; }
    public TypeName ReturnTypeName { get; set; } = returnType;
    public Identifier Name { get; set; } = name;
    public Identifier? Visibility { get; set; } = visibility;
    public Identifier? Storage { get; set; } = storage;
    public bool? IsAbstract { get; set; } = isAbstract;
    public bool IsStatic { get; set; } = isStatic;
    public bool? IsVirtual { get; set; } = isVirtual;
    public bool? IsOverride { get; set; } = isOverride;
    public bool? IsClone { get; set; } = isClone;
    public List<MethodParameter> Parameters { get; set; } = [];
    public BlockStatement? Body { get; set; }


    public override void ProcessSymbol(SymbolTable table)
    {
        foreach (var arg in Parameters)
        {
            arg.TypeName.ProcessSymbol(table);
            var argSym = arg.TypeName.Type;
            table.DeclaredTypes.TryAdd(argSym.ToString(), argSym);
            arg.Type = argSym;
        }
        if (Body is not null)
        {
            table.Push();
            foreach (var s in Body.Statements)
                s.ProcessSymbol(table);
            table.Pop();
        }
    }

    public override string ToString()
    {
        return $"{ReturnTypeName} {Name}()\n{Body}\n";
    }
}

public record struct ShaderParameter(TypeName TypeName, Identifier Name);


public abstract class ParameterListNode(TextLocation info) : Node(info);

public class ShaderParameterDeclarations(TextLocation info) : ParameterListNode(info)
{
    public List<ShaderParameter> Parameters { get; set; } = [];
}

public class ShaderExpressionList(TextLocation info) : ParameterListNode(info)
{
    public List<Expression> Values { get; set; } = [];

    public override string ToString()
    {
        return string.Join(", ", Values);
    }
}
