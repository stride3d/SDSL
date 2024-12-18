namespace Stride.Shaders.Core;


public partial record Scalar
{
    public static Scalar Bool { get; } = new("bool");
    public static Scalar Byte { get; } = new("byte");
    public static Scalar SByte { get; } = new("sbyte");
    public static Scalar Short { get; } = new("short");
    public static Scalar UShort { get; } = new("ushort");
    public static Scalar Half { get; } = new("half");
    public static Scalar Int { get; } = new("int");
    public static Scalar UInt { get; } = new("uint");
    public static Scalar Float { get; } = new("float");
    public static Scalar Long { get; } = new("long");
    public static Scalar ULong { get; } = new("ulong");
    public static Scalar Double { get; } = new("double");
}

public partial record Vector
{
    public static Vector Bool1 { get; } = new(Scalar.Bool, 1);
    public static Vector Bool2 { get; } = new(Scalar.Bool, 2);
    public static Vector Bool3 { get; } = new(Scalar.Bool, 3);
    public static Vector Bool4 { get; } = new(Scalar.Bool, 4);

    public static Vector Byte1 { get; } = new(Scalar.Byte, 1);
    public static Vector Byte2 { get; } = new(Scalar.Byte, 2);
    public static Vector Byte3 { get; } = new(Scalar.Byte, 3);
    public static Vector Byte4 { get; } = new(Scalar.Byte, 4);

    public static Vector SByte1 { get; } = new(Scalar.SByte, 1);
    public static Vector SByte2 { get; } = new(Scalar.SByte, 2);
    public static Vector SByte3 { get; } = new(Scalar.SByte, 3);
    public static Vector SByte4 { get; } = new(Scalar.SByte, 4);

    public static Vector Short1 { get; } = new(Scalar.Short, 1);
    public static Vector Short2 { get; } = new(Scalar.Short, 2);
    public static Vector Short3 { get; } = new(Scalar.Short, 3);
    public static Vector Short4 { get; } = new(Scalar.Short, 4);

    public static Vector UShort1 { get; } = new(Scalar.UShort, 1);
    public static Vector UShort2 { get; } = new(Scalar.UShort, 2);
    public static Vector UShort3 { get; } = new(Scalar.UShort, 3);
    public static Vector UShort4 { get; } = new(Scalar.UShort, 4);

    public static Vector Half1 { get; } = new(Scalar.Half, 1);
    public static Vector Half2 { get; } = new(Scalar.Half, 2);
    public static Vector Half3 { get; } = new(Scalar.Half, 3);
    public static Vector Half4 { get; } = new(Scalar.Half, 4);

    public static Vector Int1 { get; } = new(Scalar.Int, 1);
    public static Vector Int2 { get; } = new(Scalar.Int, 2);
    public static Vector Int3 { get; } = new(Scalar.Int, 3);
    public static Vector Int4 { get; } = new(Scalar.Int, 4);

    public static Vector UInt1 { get; } = new(Scalar.UInt, 1);
    public static Vector UInt2 { get; } = new(Scalar.UInt, 2);
    public static Vector UInt3 { get; } = new(Scalar.UInt, 3);
    public static Vector UInt4 { get; } = new(Scalar.UInt, 4);

    public static Vector Float1 { get; } = new(Scalar.Float, 1);
    public static Vector Float2 { get; } = new(Scalar.Float, 2);
    public static Vector Float3 { get; } = new(Scalar.Float, 3);
    public static Vector Float4 { get; } = new(Scalar.Float, 4);

    public static Vector Double1 { get; } = new(Scalar.Double, 1);
    public static Vector Double2 { get; } = new(Scalar.Double, 2);
    public static Vector Double3 { get; } = new(Scalar.Double, 3);
    public static Vector Double4 { get; } = new(Scalar.Double, 4);
}


public partial record Matrix
{
    public static Matrix Bool1x1 { get; } = new(Scalar.Bool, 1, 1);
    public static Matrix Bool2x1 { get; } = new(Scalar.Bool, 2, 1);
    public static Matrix Bool3x1 { get; } = new(Scalar.Bool, 3, 1);
    public static Matrix Bool4x1 { get; } = new(Scalar.Bool, 4, 1);

    public static Matrix Bool1x2 { get; } = new(Scalar.Bool, 1, 2);
    public static Matrix Bool2x2 { get; } = new(Scalar.Bool, 2, 2);
    public static Matrix Bool3x2 { get; } = new(Scalar.Bool, 3, 2);
    public static Matrix Bool4x2 { get; } = new(Scalar.Bool, 4, 2);

    public static Matrix Bool1x3 { get; } = new(Scalar.Bool, 1, 3);
    public static Matrix Bool2x3 { get; } = new(Scalar.Bool, 2, 3);
    public static Matrix Bool3x3 { get; } = new(Scalar.Bool, 3, 3);
    public static Matrix Bool4x3 { get; } = new(Scalar.Bool, 4, 3);

    public static Matrix Bool1x4 { get; } = new(Scalar.Bool, 1, 4);
    public static Matrix Bool2x4 { get; } = new(Scalar.Bool, 2, 4);
    public static Matrix Bool3x4 { get; } = new(Scalar.Bool, 3, 4);
    public static Matrix Bool4x4 { get; } = new(Scalar.Bool, 4, 4);



    public static Matrix Byte1x1 { get; } = new(Scalar.Byte, 1, 1);
    public static Matrix Byte2x1 { get; } = new(Scalar.Byte, 2, 1);
    public static Matrix Byte3x1 { get; } = new(Scalar.Byte, 3, 1);
    public static Matrix Byte4x1 { get; } = new(Scalar.Byte, 4, 1);

    public static Matrix Byte1x2 { get; } = new(Scalar.Byte, 1, 2);
    public static Matrix Byte2x2 { get; } = new(Scalar.Byte, 2, 2);
    public static Matrix Byte3x2 { get; } = new(Scalar.Byte, 3, 2);
    public static Matrix Byte4x2 { get; } = new(Scalar.Byte, 4, 2);

    public static Matrix Byte1x3 { get; } = new(Scalar.Byte, 1, 3);
    public static Matrix Byte2x3 { get; } = new(Scalar.Byte, 2, 3);
    public static Matrix Byte3x3 { get; } = new(Scalar.Byte, 3, 3);
    public static Matrix Byte4x3 { get; } = new(Scalar.Byte, 4, 3);

    public static Matrix Byte1x4 { get; } = new(Scalar.Byte, 1, 4);
    public static Matrix Byte2x4 { get; } = new(Scalar.Byte, 2, 4);
    public static Matrix Byte3x4 { get; } = new(Scalar.Byte, 3, 4);
    public static Matrix Byte4x4 { get; } = new(Scalar.Byte, 4, 4);

    public static Matrix SByte1x1 { get; } = new(Scalar.SByte, 1, 1);
    public static Matrix SByte2x1 { get; } = new(Scalar.SByte, 2, 1);
    public static Matrix SByte3x1 { get; } = new(Scalar.SByte, 3, 1);
    public static Matrix SByte4x1 { get; } = new(Scalar.SByte, 4, 1);

    public static Matrix SByte1x2 { get; } = new(Scalar.SByte, 1, 2);
    public static Matrix SByte2x2 { get; } = new(Scalar.SByte, 2, 2);
    public static Matrix SByte3x2 { get; } = new(Scalar.SByte, 3, 2);
    public static Matrix SByte4x2 { get; } = new(Scalar.SByte, 4, 2);

    public static Matrix SByte1x3 { get; } = new(Scalar.SByte, 1, 3);
    public static Matrix SByte2x3 { get; } = new(Scalar.SByte, 2, 3);
    public static Matrix SByte3x3 { get; } = new(Scalar.SByte, 3, 3);
    public static Matrix SByte4x3 { get; } = new(Scalar.SByte, 4, 3);

    public static Matrix SByte1x4 { get; } = new(Scalar.SByte, 1, 4);
    public static Matrix SByte2x4 { get; } = new(Scalar.SByte, 2, 4);
    public static Matrix SByte3x4 { get; } = new(Scalar.SByte, 3, 4);
    public static Matrix SByte4x4 { get; } = new(Scalar.SByte, 4, 4);

    public static Matrix Short1x1 { get; } = new(Scalar.Short, 1, 1);
    public static Matrix Short2x1 { get; } = new(Scalar.Short, 2, 1);
    public static Matrix Short3x1 { get; } = new(Scalar.Short, 3, 1);
    public static Matrix Short4x1 { get; } = new(Scalar.Short, 4, 1);

    public static Matrix Short1x2 { get; } = new(Scalar.Short, 1, 2);
    public static Matrix Short2x2 { get; } = new(Scalar.Short, 2, 2);
    public static Matrix Short3x2 { get; } = new(Scalar.Short, 3, 2);
    public static Matrix Short4x2 { get; } = new(Scalar.Short, 4, 2);

    public static Matrix Short1x3 { get; } = new(Scalar.Short, 1, 3);
    public static Matrix Short2x3 { get; } = new(Scalar.Short, 2, 3);
    public static Matrix Short3x3 { get; } = new(Scalar.Short, 3, 3);
    public static Matrix Short4x3 { get; } = new(Scalar.Short, 4, 3);

    public static Matrix Short1x4 { get; } = new(Scalar.Short, 1, 4);
    public static Matrix Short2x4 { get; } = new(Scalar.Short, 2, 4);
    public static Matrix Short3x4 { get; } = new(Scalar.Short, 3, 4);
    public static Matrix Short4x4 { get; } = new(Scalar.Short, 4, 4);

    public static Matrix UShort1x1 { get; } = new(Scalar.UShort, 1, 1);
    public static Matrix UShort2x1 { get; } = new(Scalar.UShort, 2, 1);
    public static Matrix UShort3x1 { get; } = new(Scalar.UShort, 3, 1);
    public static Matrix UShort4x1 { get; } = new(Scalar.UShort, 4, 1);

    public static Matrix UShort1x2 { get; } = new(Scalar.UShort, 1, 2);
    public static Matrix UShort2x2 { get; } = new(Scalar.UShort, 2, 2);
    public static Matrix UShort3x2 { get; } = new(Scalar.UShort, 3, 2);
    public static Matrix UShort4x2 { get; } = new(Scalar.UShort, 4, 2);

    public static Matrix UShort1x3 { get; } = new(Scalar.UShort, 1, 3);
    public static Matrix UShort2x3 { get; } = new(Scalar.UShort, 2, 3);
    public static Matrix UShort3x3 { get; } = new(Scalar.UShort, 3, 3);
    public static Matrix UShort4x3 { get; } = new(Scalar.UShort, 4, 3);

    public static Matrix UShort1x4 { get; } = new(Scalar.UShort, 1, 4);
    public static Matrix UShort2x4 { get; } = new(Scalar.UShort, 2, 4);
    public static Matrix UShort3x4 { get; } = new(Scalar.UShort, 3, 4);
    public static Matrix UShort4x4 { get; } = new(Scalar.UShort, 4, 4);

    public static Matrix Half1x1 { get; } = new(Scalar.Half, 1, 1);
    public static Matrix Half2x1 { get; } = new(Scalar.Half, 2, 1);
    public static Matrix Half3x1 { get; } = new(Scalar.Half, 3, 1);
    public static Matrix Half4x1 { get; } = new(Scalar.Half, 4, 1);

    public static Matrix Half1x2 { get; } = new(Scalar.Half, 1, 2);
    public static Matrix Half2x2 { get; } = new(Scalar.Half, 2, 2);
    public static Matrix Half3x2 { get; } = new(Scalar.Half, 3, 2);
    public static Matrix Half4x2 { get; } = new(Scalar.Half, 4, 2);

    public static Matrix Half1x3 { get; } = new(Scalar.Half, 1, 3);
    public static Matrix Half2x3 { get; } = new(Scalar.Half, 2, 3);
    public static Matrix Half3x3 { get; } = new(Scalar.Half, 3, 3);
    public static Matrix Half4x3 { get; } = new(Scalar.Half, 4, 3);

    public static Matrix Half1x4 { get; } = new(Scalar.Half, 1, 4);
    public static Matrix Half2x4 { get; } = new(Scalar.Half, 2, 4);
    public static Matrix Half3x4 { get; } = new(Scalar.Half, 3, 4);
    public static Matrix Half4x4 { get; } = new(Scalar.Half, 4, 4);

    public static Matrix Int1x1 { get; } = new(Scalar.Int, 1, 1);
    public static Matrix Int2x1 { get; } = new(Scalar.Int, 2, 1);
    public static Matrix Int3x1 { get; } = new(Scalar.Int, 3, 1);
    public static Matrix Int4x1 { get; } = new(Scalar.Int, 4, 1);

    public static Matrix Int1x2 { get; } = new(Scalar.Int, 1, 2);
    public static Matrix Int2x2 { get; } = new(Scalar.Int, 2, 2);
    public static Matrix Int3x2 { get; } = new(Scalar.Int, 3, 2);
    public static Matrix Int4x2 { get; } = new(Scalar.Int, 4, 2);

    public static Matrix Int1x3 { get; } = new(Scalar.Int, 1, 3);
    public static Matrix Int2x3 { get; } = new(Scalar.Int, 2, 3);
    public static Matrix Int3x3 { get; } = new(Scalar.Int, 3, 3);
    public static Matrix Int4x3 { get; } = new(Scalar.Int, 4, 3);

    public static Matrix Int1x4 { get; } = new(Scalar.Int, 1, 4);
    public static Matrix Int2x4 { get; } = new(Scalar.Int, 2, 4);
    public static Matrix Int3x4 { get; } = new(Scalar.Int, 3, 4);
    public static Matrix Int4x4 { get; } = new(Scalar.Int, 4, 4);

    public static Matrix UInt1x1 { get; } = new(Scalar.UInt, 1, 1);
    public static Matrix UInt2x1 { get; } = new(Scalar.UInt, 2, 1);
    public static Matrix UInt3x1 { get; } = new(Scalar.UInt, 3, 1);
    public static Matrix UInt4x1 { get; } = new(Scalar.UInt, 4, 1);

    public static Matrix UInt1x2 { get; } = new(Scalar.UInt, 1, 2);
    public static Matrix UInt2x2 { get; } = new(Scalar.UInt, 2, 2);
    public static Matrix UInt3x2 { get; } = new(Scalar.UInt, 3, 2);
    public static Matrix UInt4x2 { get; } = new(Scalar.UInt, 4, 2);

    public static Matrix UInt1x3 { get; } = new(Scalar.UInt, 1, 3);
    public static Matrix UInt2x3 { get; } = new(Scalar.UInt, 2, 3);
    public static Matrix UInt3x3 { get; } = new(Scalar.UInt, 3, 3);
    public static Matrix UInt4x3 { get; } = new(Scalar.UInt, 4, 3);

    public static Matrix UInt1x4 { get; } = new(Scalar.UInt, 1, 4);
    public static Matrix UInt2x4 { get; } = new(Scalar.UInt, 2, 4);
    public static Matrix UInt3x4 { get; } = new(Scalar.UInt, 3, 4);
    public static Matrix UInt4x4 { get; } = new(Scalar.UInt, 4, 4);

    public static Matrix Float1x1 { get; } = new(Scalar.Float, 1, 1);
    public static Matrix Float2x1 { get; } = new(Scalar.Float, 2, 1);
    public static Matrix Float3x1 { get; } = new(Scalar.Float, 3, 1);
    public static Matrix Float4x1 { get; } = new(Scalar.Float, 4, 1);

    public static Matrix Float1x2 { get; } = new(Scalar.Float, 1, 2);
    public static Matrix Float2x2 { get; } = new(Scalar.Float, 2, 2);
    public static Matrix Float3x2 { get; } = new(Scalar.Float, 3, 2);
    public static Matrix Float4x2 { get; } = new(Scalar.Float, 4, 2);

    public static Matrix Float1x3 { get; } = new(Scalar.Float, 1, 3);
    public static Matrix Float2x3 { get; } = new(Scalar.Float, 2, 3);
    public static Matrix Float3x3 { get; } = new(Scalar.Float, 3, 3);
    public static Matrix Float4x3 { get; } = new(Scalar.Float, 4, 3);

    public static Matrix Float1x4 { get; } = new(Scalar.Float, 1, 4);
    public static Matrix Float2x4 { get; } = new(Scalar.Float, 2, 4);
    public static Matrix Float3x4 { get; } = new(Scalar.Float, 3, 4);
    public static Matrix Float4x4 { get; } = new(Scalar.Float, 4, 4);

    public static Matrix Long1x1 { get; } = new(Scalar.Long, 1, 1);
    public static Matrix Long2x1 { get; } = new(Scalar.Long, 2, 1);
    public static Matrix Long3x1 { get; } = new(Scalar.Long, 3, 1);
    public static Matrix Long4x1 { get; } = new(Scalar.Long, 4, 1);

    public static Matrix Long1x2 { get; } = new(Scalar.Long, 1, 2);
    public static Matrix Long2x2 { get; } = new(Scalar.Long, 2, 2);
    public static Matrix Long3x2 { get; } = new(Scalar.Long, 3, 2);
    public static Matrix Long4x2 { get; } = new(Scalar.Long, 4, 2);

    public static Matrix Long1x3 { get; } = new(Scalar.Long, 1, 3);
    public static Matrix Long2x3 { get; } = new(Scalar.Long, 2, 3);
    public static Matrix Long3x3 { get; } = new(Scalar.Long, 3, 3);
    public static Matrix Long4x3 { get; } = new(Scalar.Long, 4, 3);

    public static Matrix Long1x4 { get; } = new(Scalar.Long, 1, 4);
    public static Matrix Long2x4 { get; } = new(Scalar.Long, 2, 4);
    public static Matrix Long3x4 { get; } = new(Scalar.Long, 3, 4);
    public static Matrix Long4x4 { get; } = new(Scalar.Long, 4, 4);

    public static Matrix ULong1x1 { get; } = new(Scalar.ULong, 1, 1);
    public static Matrix ULong2x1 { get; } = new(Scalar.ULong, 2, 1);
    public static Matrix ULong3x1 { get; } = new(Scalar.ULong, 3, 1);
    public static Matrix ULong4x1 { get; } = new(Scalar.ULong, 4, 1);

    public static Matrix ULong1x2 { get; } = new(Scalar.ULong, 1, 2);
    public static Matrix ULong2x2 { get; } = new(Scalar.ULong, 2, 2);
    public static Matrix ULong3x2 { get; } = new(Scalar.ULong, 3, 2);
    public static Matrix ULong4x2 { get; } = new(Scalar.ULong, 4, 2);

    public static Matrix ULong1x3 { get; } = new(Scalar.ULong, 1, 3);
    public static Matrix ULong2x3 { get; } = new(Scalar.ULong, 2, 3);
    public static Matrix ULong3x3 { get; } = new(Scalar.ULong, 3, 3);
    public static Matrix ULong4x3 { get; } = new(Scalar.ULong, 4, 3);

    public static Matrix ULong1x4 { get; } = new(Scalar.ULong, 1, 4);
    public static Matrix ULong2x4 { get; } = new(Scalar.ULong, 2, 4);
    public static Matrix ULong3x4 { get; } = new(Scalar.ULong, 3, 4);
    public static Matrix ULong4x4 { get; } = new(Scalar.ULong, 4, 4);

    public static Matrix Double1x1 { get; } = new(Scalar.Double, 1, 1);
    public static Matrix Double2x1 { get; } = new(Scalar.Double, 2, 1);
    public static Matrix Double3x1 { get; } = new(Scalar.Double, 3, 1);
    public static Matrix Double4x1 { get; } = new(Scalar.Double, 4, 1);

    public static Matrix Double1x2 { get; } = new(Scalar.Double, 1, 2);
    public static Matrix Double2x2 { get; } = new(Scalar.Double, 2, 2);
    public static Matrix Double3x2 { get; } = new(Scalar.Double, 3, 2);
    public static Matrix Double4x2 { get; } = new(Scalar.Double, 4, 2);

    public static Matrix Double1x3 { get; } = new(Scalar.Double, 1, 3);
    public static Matrix Double2x3 { get; } = new(Scalar.Double, 2, 3);
    public static Matrix Double3x3 { get; } = new(Scalar.Double, 3, 3);
    public static Matrix Double4x3 { get; } = new(Scalar.Double, 4, 3);

    public static Matrix Double1x4 { get; } = new(Scalar.Double, 1, 4);
    public static Matrix Double2x4 { get; } = new(Scalar.Double, 2, 4);
    public static Matrix Double3x4 { get; } = new(Scalar.Double, 3, 4);
    public static Matrix Double4x4 { get; } = new(Scalar.Double, 4, 4);



}