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


public record struct Symbol(string Name, SymbolType Type, SymbolKind Kind);