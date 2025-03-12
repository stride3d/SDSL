namespace Stride.Shaders.Core;




public enum SymbolKind
{
    MixinParent,
    MixinChild,
    Struct,
    Method,
    StreamVariable,
    Variable,
    Constant,
    ConstantGeneric,
    Composition,
    CBuffer,
    TBuffer,
    RGroup
}

public enum Storage
{
    UniformConstant = 0,
    Input = 1,
    Uniform = 2,
    Output = 3,
    Function = 7,
    Generic = 8,
}



public record struct SymbolID(string Name, SymbolKind Kind, Storage? Storage = null);
public record struct Symbol(SymbolID Id, SymbolType Type);