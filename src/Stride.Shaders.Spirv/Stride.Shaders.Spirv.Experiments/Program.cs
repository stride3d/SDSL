// See https://aka.ms/new-console-template for more information
using CommunityToolkit.HighPerformance.Buffers;
using Stride.Shaders.Spirv.Core;
using Stride.Shaders.Spirv.Core.Parsing;
using Stride.Shaders.Spirv.Core.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Spv.Specification;


Console.WriteLine("Hello, world!");


//var doc = JsonParser.Parse/*("{\"*/hello\" : \"world\"}");
//Console.WriteLine(doc.RootElement.GetProperty("hello").GetString());

static void ParseShader()
{
    Console.WriteLine(Unsafe.SizeOf<Memory<int>>());

    InstructionInfo.GetInfo(SDSLOp.OpCapability);

    var shader = File.ReadAllBytes("../../shader.spv");


    SpirvReader.ParseToList(shader, new(8));

    var x = 0;
}


static void CreateShader()
{
    LiteralString sname = "S";

    int id = 1;

    var ssize = sname.WordCount;
    var array = new byte[] {0,0,0,8};

    var s = array.AsSpan();
    Span<int> ints = MemoryMarshal.Cast<byte,int>(s);

    // var bound = new Bound();
    var buffer = new SpirvBuffer();
    // // Capabilities

    buffer.AddOpCapability(Capability.Shader);
    var extInstImport = buffer.AddOpExtInstImport(id++, "GLSL.std.450");
    buffer.AddOpMemoryModel(AddressingModel.Logical, MemoryModel.GLSL450);


    // declarations

    Span<IdRef> c = stackalloc IdRef[10]; // This is for use in parameters


    var t_void = buffer.AddOpTypeVoid(id++);

    var t_bool = buffer.AddOpTypeBool(id++);

    var t_func = buffer.AddOpTypeFunction(id++, t_void, Span<IdRef>.Empty);
    var t_float = buffer.AddOpTypeFloat(id++, 32, null);
    var t_uint = buffer.AddOpTypeInt(id++, 32, 0);
    var t_int = buffer.AddOpTypeInt(id++, 32, 1);
    var t_float4 = buffer.AddOpTypeVector(id++, t_float, 4);
    var t_p_float4_func = buffer.AddOpTypePointer(id++, StorageClass.Function, t_float4);
    var constant1 = buffer.AddOpConstant<SpirvBuffer, LiteralFloat>(id++, t_float, 5);
    var constant2 = buffer.AddOpConstant<SpirvBuffer, LiteralFloat>(id++, t_float, 2);
    var constant3 = buffer.AddOpConstant<SpirvBuffer, LiteralInteger>(id++, t_uint, 5);
    var compositeType = buffer.AddOpConstantComposite(
        id++, 
        t_float4, 
        [constant1, constant1, constant2, constant1]
    );

    var t_array = buffer.AddOpTypeArray(id++, t_float4, constant3);

    var t_struct = buffer.AddOpTypeStruct(id++, [t_uint, t_array, t_int]);
    var t_struct2 = buffer.AddOpTypeStruct(id++, [t_struct, t_uint]);

    var t_p_struct2 = buffer.AddOpTypePointer(id++, StorageClass.Uniform, t_struct2);

    var v_struct2 = buffer.AddOpVariable(id++, t_p_struct2, StorageClass.Uniform, null);

    var constant4 = buffer.AddOpConstant<SpirvBuffer, LiteralInteger>(id++, t_int, 1);

    var t_p_uint = buffer.AddOpTypePointer(id++, StorageClass.Uniform, t_uint);
    var constant5 = buffer.AddOpConstant<SpirvBuffer, LiteralInteger>(id++, t_uint, 0);

    var t_p_output = buffer.AddOpTypePointer(id++, StorageClass.Output, t_float4);
    var v_output = buffer.AddOpVariable(id++, t_p_output, StorageClass.Output, null);

    var t_p_input = buffer.AddOpTypePointer(id++, StorageClass.Input, t_float4);
    var v_input = buffer.AddOpVariable(id++, t_p_input, StorageClass.Input, null);

    var constant6 = buffer.AddOpConstant<SpirvBuffer, LiteralInteger>(id++, t_int, 0);
    var constant7 = buffer.AddOpConstant<SpirvBuffer, LiteralInteger>(id++, t_int, 2);
    var t_p_float4_unif = buffer.AddOpTypePointer(id++, StorageClass.Uniform, t_float4);

    var v_input_2 = buffer.AddOpVariable(id++, t_p_input, StorageClass.Input, null);
    var t_p_func = buffer.AddOpTypePointer(id++, StorageClass.Function, t_int);
    var constant8 = buffer.AddOpConstant<SpirvBuffer, LiteralInteger>(id++, t_int, 4);
    var v_input_3 = buffer.AddOpVariable(id++, t_p_input, StorageClass.Input, null);




    buffer.AddOpDecorate(t_array, Decoration.ArrayStride, 16);
    buffer.AddOpMemberDecorate(t_struct, 0, Decoration.Offset, 0);
    buffer.AddOpMemberDecorate(t_struct, 1, Decoration.Offset, 16);
    buffer.AddOpMemberDecorate(t_struct, 2, Decoration.Offset, 96);
    buffer.AddOpMemberDecorate(t_struct2, 0, Decoration.Offset, 0);
    buffer.AddOpMemberDecorate(t_struct2, 1, Decoration.Offset, 112);
    buffer.AddOpDecorate(t_struct2, Decoration.Block);
    buffer.AddOpDecorate(v_struct2, Decoration.DescriptorSet, 0);
    buffer.AddOpDecorate(v_input_2, Decoration.NoPerspective);




    buffer.AddOpName(t_p_func, "main");
    buffer.AddOpName(t_struct, "S");
    buffer.AddOpMemberName(t_struct, 0, "b");
    buffer.AddOpMemberName(t_struct, 1, "v");
    buffer.AddOpMemberName(t_struct, 2, "i");


    var main = buffer.AddOpFunction(id++, t_void, FunctionControlMask.MaskNone, t_func);
    buffer.AddOpEntryPoint(ExecutionModel.Fragment, main, "PSMain", [v_output, v_input, v_input_2, v_input_3]);
    buffer.AddOpExecutionMode(main, ExecutionMode.OriginLowerLeft);

    buffer.AddOpLabel(id++);
    buffer.AddOpReturn();
    buffer.AddOpFunctionEnd();

    var main2 = buffer.AddOpFunction(id++, t_void, FunctionControlMask.MaskNone, t_func);
    buffer.AddOpEntryPoint(ExecutionModel.Vertex, main, "VSMain", [v_output, v_input, v_input_2, v_input_3]);

    // #error sorting makes error for disassembler
    buffer.Sort();

    var dis = new SpirvDis<SpirvBuffer>(buffer, useNames: true);

    Console.WriteLine(dis.Disassemble());
    
    //var list = new List<Instruction>(buffer.Count);
    //foreach(var e in buffer)
    //    list.Add(e);

    //var bytes = buffer.GenerateSpirv();

    //File.WriteAllBytes("C:\\Users\\kafia\\source\\repos\\Stride.Shaders.Spirv\\shader.spv", bytes); ;

    var x = 0;
}


static void ParseWorking()
{
    // var path = @"C:\Users\youness_kafia\Documents\dotnetProjs\SDSLParser\src\Stride.Shaders.Spirv\working1-6.spv";
    var path = @"C:\Users\kafia\source\repos\SDSLParser\src\Stride.Shaders.Spirv\working1-6.spv";

    var bytes = File.ReadAllBytes(path);

    var buffer = new SpirvBuffer(MemoryMarshal.Cast<byte, int>(bytes));
    var extInst = buffer[1];
    foreach(var o in extInst)
    {
        if(o.Kind == OperandKind.LiteralString)
        {
            Console.WriteLine(o.To<LiteralString>().Value);
        }
    }
    var tmp = 0;
}

CreateShader();

//ParseWorking();
