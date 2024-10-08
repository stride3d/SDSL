namespace Stride.Shaders.Parsing.SDSL.AST;


public abstract class ShaderElement(TextLocation info) : Node(info);


public abstract class ShaderBuffer(Identifier name, TextLocation info) : ShaderElement(info)
{
    public Identifier Name { get; set; } = name;
}

public class ShaderStructMember(TypeName typename, Identifier identifier, TextLocation info) : Node(info)
{
    public TypeName TypeName { get; set; } = typename;
    public Identifier Name { get; set; } = identifier;

    public override string ToString()
    {
        return $"{TypeName} {Name}";
    }
}

public class ShaderStruct(Identifier typename, TextLocation info) : ShaderElement(info)
{
    public Identifier TypeName { get; set; } = typename;
    public List<ShaderStructMember> Members { get; set; } = [];

    public override string ToString()
    {
        return $"struct {TypeName} ({string.Join(", ", Members)})";
    }
}

public sealed class CBuffer(Identifier name, TextLocation info) : ShaderBuffer(name, info)
{
    public List<ShaderMember> Members { get; set; } = [];
}
public sealed class TBuffer(Identifier name, TextLocation info) : ShaderBuffer(name, info)
{
    public List<ShaderMember> Members { get; set; } = [];
}
