using Eto.Parse;
using Eto.Parse.Parsers;
using static Eto.Parse.Terminals;

namespace Stride.Shader.Parser;
public partial class SDSLGrammar : Grammar
{
    public AlternativeParser IncOperators = new();

    public AlternativeParser Operators = new();  
    public AlternativeParser AssignOperators = new();

    public AlternativeParser BoolTypes = new();

    public AlternativeParser HalfTypes = new();

    public AlternativeParser FloatTypes = new();

    public AlternativeParser DoubleTypes = new();

    public AlternativeParser IntTypes = new();

    public AlternativeParser UintTypes = new();

    public AlternativeParser ValueTypes = new();

    public AlternativeParser Keywords = new();
    
    public void CreateTokenGroups()
    {
        IncOperators =
            PlusPlus
            | MinusMinus;

        Operators =
            Plus
            | Minus
            | Star
            | Div
            | Mod
            | LeftShift
            | RightShift;
        
        AssignOperators =
            Assign
            | StarAssign
            | DivAssign
            | ModAssign
            | PlusAssign
            | MinusAssign
            | LeftShiftAssign
            | RightShiftAssign
            | AndAssign
            | XorAssign
            | OrAssign;

        BoolTypes =
            Bool - BoolVec
            | BoolVec - BoolMat
            | BoolMat;

        HalfTypes =
            Half - HalfVec
            | HalfVec - HalfMat
            | HalfMat;

        FloatTypes =
            Float - FloatVec
            | FloatVec - FloatMat
            | FloatMat;

        DoubleTypes =
            Double - DoubleVec
            | DoubleVec - DoubleMat
            | DoubleMat;

        IntTypes =
            Int - IntVec
            | IntVec - IntMat
            | IntMat;

        UintTypes =
            Uint - UintVec
            | UintVec - UintMat
            | UintMat;

        ValueTypes =
            BoolTypes
            | HalfTypes
            | FloatTypes
            | DoubleTypes
            | IntTypes
            | UintTypes;

        Keywords =
            AppendStructuredBuffer
            |   Buffer - ByteAddressBuffer
            |   ByteAddressBuffer - Break
            |   Break
            |   Case - CBuffer
            |   CBuffer - Centroid
            |   Centroid - Class
            |   Class - ColumnMajor
            |   ColumnMajor - Const
            |   Const - ConsumeStructuredBuffer
            |   ConsumeStructuredBuffer - Continue
            |   Continue
            |   Default - Discard
            |   Discard
            |   Do
            |   Else
            |   Extern
            |   For
            |   Groupshared
            |   If
            |   In
            |   Inout
            |   InputPatch
            |   Interface
            |   Line_
            |   LineAdj
            |   Linear
            |   LineStream
            |   Matrix
            |   Nointerpolation
            |   Noperspective
            |   Out
            |   OutputPatch
            |   Packoffset
            |   Point
            |   PointStream
            |   Precise
            |   Register
            |   Return
            |   RowMajor
            |   RWBuffer
            |   RWByteAddressBuffer
            |   RWStructuredBuffer
            |   Sample - Sampler
            |   Sampler
            |   SamplerComparisonState
            |   SamplerState
            |   Shared
            |   Static
            |   Struct
            |   StructuredBuffer
            |   Switch
            |   TextureTypes
            |   Triangle
            |   TriangleAdj
            |   TriangleStream
            |   Uniform
            |   ValueTypes
            |   Vector
            |   Volatile
            |   Void
            |   While;
        
    }
}