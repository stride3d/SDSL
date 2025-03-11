﻿// See https://aka.ms/new-console-template for more information
using CommunityToolkit.HighPerformance.Buffers;
using Stride.Shaders.Spirv.Core;
using Stride.Shaders.Spirv.Core.Parsing;
using Stride.Shaders.Spirv.Core.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Spv.Specification;
using Stride.Shaders.Spirv.Tools;
using Stride.Shaders.Spirv.Building;
using Stride.Shaders.Core;
using System.Numerics;


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
    int id = 1;

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

    var t_func = buffer.AddOpTypeFunction(id++, t_void, []);
    var t_float = buffer.AddOpTypeFloat(id++, 32, null);
    var t_uint = buffer.AddOpTypeInt(id++, 32, 0);
    var t_int = buffer.AddOpTypeInt(id++, 32, 1);
    var t_func_add = buffer.AddOpTypeFunction(id++, t_int, [t_int, t_int]);
    var t_float4 = buffer.AddOpTypeVector(id++, t_float, 4);
    var t_p_float4_func = buffer.AddOpTypePointer(id++, StorageClass.Function, t_float4);
    var constant1 = buffer.AddOpConstant<LiteralFloat>(id++, t_float, 5);
    var constant2 = buffer.AddOpConstant<LiteralFloat>(id++, t_float, 2.23f);
    var constant3 = buffer.AddOpConstant<LiteralInteger>(id++, t_uint, 5);
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

    var constant4 = buffer.AddOpConstant<LiteralInteger>(id++, t_int, 1);

    var t_p_uint = buffer.AddOpTypePointer(id++, StorageClass.Uniform, t_uint);
    var constant5 = buffer.AddOpConstant<LiteralInteger>(id++, t_uint, 0);

    var t_p_output = buffer.AddOpTypePointer(id++, StorageClass.Output, t_float4);
    var v_output = buffer.AddOpVariable(id++, t_p_output, StorageClass.Output, null);

    var t_p_input = buffer.AddOpTypePointer(id++, StorageClass.Input, t_float4);
    var v_input = buffer.AddOpVariable(id++, t_p_input, StorageClass.Input, null);

    var constant6 = buffer.AddOpConstant<LiteralInteger>(id++, t_int, 0);
    var constant7 = buffer.AddOpConstant<LiteralInteger>(id++, t_int, 2);
    var t_p_float4_unif = buffer.AddOpTypePointer(id++, StorageClass.Uniform, t_float4);

    var v_input_2 = buffer.AddOpVariable(id++, t_p_input, StorageClass.Input, null);
    var t_p_func = buffer.AddOpTypePointer(id++, StorageClass.Function, t_int);
    var constant8 = buffer.AddOpConstant<LiteralInteger>(id++, t_int, 4);
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


    var add = buffer.AddOpFunction(id++, t_int, FunctionControlMask.MaskNone, t_func_add);
    var a = buffer.AddOpFunctionParameter(id++, t_int);
    var b = buffer.AddOpFunctionParameter(id++, t_int);
    buffer.AddOpLabel(id++);
    var res = buffer.AddOpIAdd(id++, t_int, a, b);
    buffer.AddOpReturnValue(res);
    buffer.AddOpFunctionEnd();


    
    buffer.Sort();

    var dis = new SpirvDis<SpirvBuffer>(buffer, useNames: true);

    dis.Disassemble(writeToConsole: true);

    File.WriteAllBytes(
        "test.spv",
        MemoryMarshal.Cast<int,byte>(buffer.Span)
    );

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


static void GenerateSpirv()
{
    var module = new Module();
    using var context = new SpirvContext(new());
    using var builder = new Builder();

    context.GetOrRegister(new MatrixSymbol(ScalarSymbol.From("float"), 4, 3));
    context.GetOrRegister(ScalarSymbol.From("int"));

    
    context.AddGlobalVariable(new(new("color", SymbolKind.Variable, Storage.Output), VectorSymbol.From("float4")));

    var function = builder.CreateFunction(
        context, 
        "add", 
        new([ScalarSymbol.From("int"), ScalarSymbol.From("int"), ScalarSymbol.From("int")]),
        parameters: [
            new Symbol(
                Id: new("a", SymbolKind.Variable, Storage.Function),
                ScalarSymbol.From("int")
            ),
            new Symbol(
                Id: new("b", SymbolKind.Variable, Storage.Function),
                ScalarSymbol.From("int")
            )
        ]
    );
    builder.SetPositionTo(function);
    var block = builder.CreateBlock(context, function, "sourceBlock");
    builder.SetPositionTo(block);
    var v = builder.BinaryOperation(
        context, 
        function.Parameters["a"], Operator.Plus, function.Parameters["b"]
    );
    builder.Return(v);

    var dis = new SpirvDis<SpirvBuffer>(SpirvBuffer.Merge(context.Buffer, builder.Buffer), useNames: true);
    dis.Disassemble(true);
}

CreateShader();

GenerateSpirv();
