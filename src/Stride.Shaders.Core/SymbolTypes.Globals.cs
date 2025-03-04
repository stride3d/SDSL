using System.Collections.Frozen;

namespace Stride.Shaders.Core;


public partial record ScalarSymbol
{
    public static string[] names = [
        "bool",
        "byte",
        "sbyte",
        "short",
        "ushort",
        "half",
        "int",
        "uint",
        "float",
        "long",
        "ulong",
        "double"
    ];
    public static ScalarSymbol From(string s) => Types[s];
    public static FrozenDictionary<string, ScalarSymbol> Types { get; } = Init();

    // static Scalar()
    // {
    //     var arr = new KeyValuePair<string, Scalar>[names.Length + 1];
    //     arr[0] = new("void", new("void"));
    //     for(int i = 1; i < names.Length; i++)
    //         arr[i] = new(names[i], new(names[i]));
    //     Types = FrozenDictionary.ToFrozenDictionary(arr); 
    // }
    internal static FrozenDictionary<string, ScalarSymbol> Init()
    {
        var arr = new KeyValuePair<string, ScalarSymbol>[names.Length + 1];
        arr[0] = new("void", new("void"));
        for(int i = 1; i < names.Length + 1; i++)
            arr[i] = new(names[i - 1], new(names[i - 1]));
        return arr.ToFrozenDictionary();
    }
}

public partial record VectorSymbol
{
    public static VectorSymbol From(string s) => Types[s];
    public static FrozenDictionary<string, VectorSymbol> Types { get; } = Init();

    internal static FrozenDictionary<string, VectorSymbol> Init()
    {
        var arr = new KeyValuePair<string, VectorSymbol>[ScalarSymbol.names.Length * 4];
        for(int i = 0; i < ScalarSymbol.names.Length; i++)
            for(int x = 1; x < 5; x++)
                arr[i * 4 + (x - 1)] = new($"{ScalarSymbol.names[i]}{x}", new(ScalarSymbol.From(ScalarSymbol.names[i]),x));
        return arr.ToFrozenDictionary();
    }
}


public partial record MatrixSymbol
{
    public static MatrixSymbol From(string s) => Types[s];
    public static FrozenDictionary<string, MatrixSymbol> Types { get; } = Init();
    internal static FrozenDictionary<string, MatrixSymbol> Init()
    {
        var arr = new KeyValuePair<string, MatrixSymbol>[ScalarSymbol.names.Length * 4 * 4];
        for(int i = 0; i < ScalarSymbol.names.Length; i++)
            for(int x = 1; x < 5; x++)
            for(int y = 1; y < 5; y++)
                arr[i * 16 + (x - 1) * 4 + (y - 1) * 4] = new($"{ScalarSymbol.names[i]}{x}x{y}", new(ScalarSymbol.From(ScalarSymbol.names[i]),x,y));
        return arr.ToFrozenDictionary(); 
    }
}