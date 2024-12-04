namespace Stride.Shaders.Parsing.Analysis;


public interface ISymbolProvider
{
    public Dictionary<string, SymbolType> DeclaredTypes { get; }
    public Dictionary<string, Symbol> Symbols { get; }
}