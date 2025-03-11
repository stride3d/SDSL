using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace Stride.Shaders.Core;



public abstract record SymbolType()
{
    public static bool TryGetNumeric(string name, out SymbolType? result)
    {
        if(ScalarSymbol.Types.TryGetValue(name, out var s))
        {
            result = s;
            return true;
        }
        else if(VectorSymbol.Types.TryGetValue(name, out var v))
        {
            result = v;
            return true;
        }
        else if(MatrixSymbol.Types.TryGetValue(name, out var m))
        {
            result = m;
            return true;
        }
        else if (name == "void")
        {
            result = ScalarSymbol.From("void");
            return true;
        }
        else
        {
            result = null;
            return true;
        }
    }
}

public sealed record UndefinedSymbol(string TypeName) : SymbolType()
{
    public override string ToString()
    {
        return TypeName;
    }
}

public sealed record PointerSymbol(SymbolType BaseType) : SymbolType()
{
    public override string ToString() => $"*{BaseType}";
}

public sealed partial record ScalarSymbol(string TypeName) : SymbolType()
{
    public override string ToString() => TypeName;
}
public sealed partial record VectorSymbol(ScalarSymbol BaseType, int Size) : SymbolType()
{    
    public override string ToString() => $"{BaseType}{Size}";
}
public sealed partial record MatrixSymbol(ScalarSymbol BaseType, int Rows, int Columns) : SymbolType()
{
    public override string ToString() => $"{BaseType}{Rows}x{Columns}";
}
public sealed record ArraySymbol(SymbolType BaseType, int Size) : SymbolType()
{
    public override string ToString() => $"{BaseType}[{Size}]";
}
public sealed record StructSymbol(string Name, SortedList<string, SymbolType> Fields) : SymbolType()
{
    public override string ToString() => $"{Name}{{{string.Join(", ", Fields.Select(x => $"{x.Value} {x.Key}"))}}}";
}
public sealed record BufferSymbol(SymbolType BaseType, int Size) : SymbolType()
{
    public override string ToString() => $"Buffer<{BaseType}, {Size}>";
}


public abstract record TextureSymbol(SymbolType BaseType) : SymbolType()
{
    public override string ToString() => $"Texture<{BaseType}>";
}
public sealed record Texture1DSymbol(SymbolType BaseType, int Size) : TextureSymbol(BaseType)
{
    public override string ToString() => $"Texture<{BaseType}, {Size}>";
}
public sealed record Texture2DSymbol(SymbolType BaseType, int Width, int Height) : TextureSymbol(BaseType)
{
    public override string ToString() => $"Texture<{BaseType}, {Width}, {Height}>";
}
public sealed record Texture3DSymbol(SymbolType BaseType, int Width, int Height, int Depth) : TextureSymbol(BaseType)
{
    public override string ToString() => $"Texture<{BaseType}, {Width}, {Height}, {Depth}>";
}


public sealed record FunctionTypeSymbol(List<SymbolType> Types) : SymbolType()
{
    public bool Equals(FunctionTypeSymbol? other)
    {
        if(other is null)
            return false;
        
        if (Types == null && other.Types == null)
            return true;
        if (Types == null || other.Types == null)
            return false;
        return Types.SequenceEqual(other.Types);
    }

    public override int GetHashCode()
    {
        int hash = 17;
        foreach (var item in Types)
        {
            hash = hash * 31 + item.GetHashCode();
        }
        return hash;
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append("TypeFunction<");
        for(int i = 0; i < Types.Count; i++)
        {
            builder.Append(Types[i]);
            if(i < Types.Count - 1)
                builder.Append(", ");
        }
        return builder.Append('>').ToString();
    }
}

public sealed record ConstantBufferSymbol(string Name, List<Symbol> Symbols) : SymbolType;
public sealed record ParamsSymbol(string Name, List<Symbol> Symbols) : SymbolType;
public sealed record EffectSymbol(string Name, List<Symbol> Symbols) : SymbolType;
public sealed record ShaderSymbol(string Name, List<Symbol> Components) : SymbolType
{
    public Symbol Get(string name, SymbolKind kind)
    {
        foreach (var e in Components)
            if (e.Id.Kind == kind && e.Id.Name == name)
                return e;
        throw new ArgumentException($"{name} not found in Mixin {Name}");
    }
    public bool TryGet(string name, SymbolKind kind, out Symbol? value)
    {
        foreach (var e in Components)
            if (e.Id.Kind == kind && e.Id.Name == name)
            {
                value = e;
                return true;
            }
        value = null!;
        return false;
    }
}
