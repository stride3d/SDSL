namespace Stride.Shaders.Core;




public enum SymbolKind
{
    MixinParent,
    MixinChild,
    Method,
    Variable,
    Constant,
    ConstantGeneric,
    Composition
}


public record struct Symbol(string Name, SymbolType Type, SymbolKind Kind);