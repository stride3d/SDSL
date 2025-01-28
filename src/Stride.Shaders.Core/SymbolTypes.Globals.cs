using System.Collections.Frozen;

namespace Stride.Shaders.Core;


public partial record Scalar
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
    public static Scalar From(string s) => Types[s];
    public static FrozenDictionary<string, Scalar> Types { get; }

    static Scalar()
    {
        var arr = new KeyValuePair<string, Scalar>[names.Length + 1];
        arr[0] = new("void", new("void"));
        for(int i = 1; i < names.Length; i++)
            arr[i] = new(names[i], new(names[i]));
        Types = FrozenDictionary.ToFrozenDictionary(arr); 
    }
}

public partial record Vector
{
    public static Vector From(string s) => Types[s];
    public static FrozenDictionary<string, Vector> Types { get; }

    static Vector()
    {
        var arr = new KeyValuePair<string, Vector>[Scalar.names.Length];
        for(int i = 0; i < Scalar.names.Length; i++)
            for(int x = 1; x < 5; x++)
                arr[i] = new($"{Scalar.names[i]}{x}", new(Scalar.From(Scalar.names[i]),x));
        Types = FrozenDictionary.ToFrozenDictionary(arr); 
    }
}


public partial record Matrix
{
    public static Matrix From(string s) => Types[s];
    public static FrozenDictionary<string, Matrix> Types { get; }
    static Matrix()
    {
        var arr = new KeyValuePair<string, Matrix>[Scalar.names.Length];
        for(int i = 0; i < Scalar.names.Length; i++)
            for(int x = 1; x < 5; x++)
            for(int y = 1; y < 5; y++)
                arr[i] = new($"{Scalar.names[i]}{x}x{y}", new(Scalar.From(Scalar.names[i]),x,y));
        Types = FrozenDictionary.ToFrozenDictionary(arr); 
    }
}