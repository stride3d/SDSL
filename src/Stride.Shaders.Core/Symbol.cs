namespace Stride.Shaders.Core;




public enum SymbolKind
{
    MixinParent,
    MixinChild,
    Struct,
    Method,
    Variable,
    Constant,
    ConstantGeneric,
    Composition,
    CBuffer,
    TBuffer,
    RGroup
}

public enum Storage : ushort
{
    None,
    Uniform,
    UniformConstant,
    Stream,
    Function,
    Generic,
}

public enum StreamIO : byte
{
    Input,
    Output
}



public record struct SymbolID(string Name, SymbolKind Kind, Storage Storage = 0);
public record struct StreamInfo(ushort EntryPoint, StreamIO Stream);
public record struct Symbol(SymbolID Id, SymbolType Type, object? Data = null);