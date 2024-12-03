using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.Analysis;




public enum SymbolKind
{
    Effect,
    Params,
    Shader,
    MixinParent,
    MixinChild,
    Method,
    Variable,
    Constant,
    ConstantGeneric,
    Composition,
}


public record struct Symbol(string Name, SymbolType Type, SymbolKind Kind);