using System.Dynamic;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.Analysis;



public abstract record SymbolType();

public sealed record Scalar(string TypeName) : SymbolType();
public sealed record Vector(Scalar BaseType, int Size) : SymbolType();
public sealed record Matrix(Scalar BaseType, int Rows, int Columns) : SymbolType();
public sealed record Array(SymbolType BaseType, int Size) : SymbolType();
public sealed record Struct(string Name, Dictionary<string, SymbolType> Fields) : SymbolType();
public sealed record Buffer(SymbolType BaseType, int Size) : SymbolType();


public abstract record Texture(SymbolType BaseType) : SymbolType();
public sealed record Texture1D(SymbolType BaseType, int Size) : SymbolType();
public sealed record Texture2D(SymbolType BaseType, int Width, int Height) : SymbolType();
public sealed record Texture3D(SymbolType BaseType, int Width, int Height, int Depth) : SymbolType();


public sealed record ParamsSymbol(string Name, List<Symbol> Symbols) : SymbolType;
public sealed record EffectSymbol(string Name, List<Symbol> Symbols) : SymbolType;
public sealed record ShaderSymbol(string Name, List<Symbol> Components) : SymbolType
{
    public Symbol Get(string name, SymbolKind kind)
    {
        foreach (var e in Components)
            if (e.Kind == kind && e.Name == name)
                return e;
        throw new ArgumentException($"{name} not found in Mixin {Name}");
    }
    public bool TryGet(string name, SymbolKind kind, out Symbol? value)
    {
        foreach (var e in Components)
            if (e.Kind == kind && e.Name == name)
            {
                value = e;
                return true;
            }
        value = null!;
        return false;
    }
}
