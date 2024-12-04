using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.Analysis;


public static class GlobalShaderTypes
{
    static Dictionary<string, ShaderSymbol> mixins = [];


    public static void Register(ShaderSymbol symbol)
    {
        mixins.Add(symbol.Name, symbol);
    }

    public static bool TryRegister(ShaderSymbol symbol)
    {
        return mixins.TryAdd(symbol.Name, symbol);
    }

    public static ShaderSymbol Get(string name)
    {
        return mixins[name];
    }
    
    public static bool TryGet(string name, out ShaderSymbol? symbol)
    {
        return mixins.TryGetValue(name, out symbol);
    }
}