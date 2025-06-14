using static Stride.Shaders.Spirv.Specification;

namespace Stride.Shaders.Spirv.Core;
public ref struct InstOpSDSLDecorateSemantic : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public LiteralString Semantic => Inner.GetOperand<LiteralString>("semantic") ?? default;

    public InstOpSDSLDecorateSemantic(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSDSLShader : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString ShaderName => Inner.GetOperand<LiteralString>("shaderName") ?? default;

    public InstOpSDSLShader(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSDSLShaderEnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpSDSLShaderEnd(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSDSLMixinInherit : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Shader => Inner.GetOperand<IdRef>("shader") ?? default;

    public InstOpSDSLMixinInherit(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSDSLCompose : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString Mixin => Inner.GetOperand<LiteralString>("mixin") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public InstOpSDSLCompose(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSDSLStage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef StagedElement => Inner.GetOperand<IdRef>("stagedElement") ?? default;

    public InstOpSDSLStage(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSDSLImportShader : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString ShaderName => Inner.GetOperand<LiteralString>("shaderName") ?? default;

    public InstOpSDSLImportShader(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSDSLImportFunction : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString FunctionName => Inner.GetOperand<LiteralString>("functionName") ?? default;
    public IdRef Shader => Inner.GetOperand<IdRef>("shader") ?? default;

    public InstOpSDSLImportFunction(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSDSLImportVariable : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString VariableName => Inner.GetOperand<LiteralString>("variableName") ?? default;
    public IdRef Shader => Inner.GetOperand<IdRef>("shader") ?? default;

    public InstOpSDSLImportVariable(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSDSLMixinVariable : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef MixinId => Inner.GetOperand<IdRef>("mixinId") ?? default;
    public IdRef VariableId => Inner.GetOperand<IdRef>("variableId") ?? default;

    public InstOpSDSLMixinVariable(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSDSLVariable : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;
    public IdRef Initializer => Inner.GetOperand<IdRef>("initializer") ?? default;

    public InstOpSDSLVariable(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSDSLFunctionParameter : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public InstOpSDSLFunctionParameter(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSDSLIOVariable : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");
    public ExecutionModel Executionmodel => Inner.GetEnumOperand<ExecutionModel>("executionmodel");
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;
    public LiteralString Semantic => Inner.GetOperand<LiteralString>("semantic") ?? default;
    public IdRef Initializer => Inner.GetOperand<IdRef>("initializer") ?? default;

    public InstOpSDSLIOVariable(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSDSLFunction : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public FunctionControlMask Functioncontrol => Inner.GetEnumOperand<FunctionControlMask>("functioncontrol");
    public IdRef FunctionType => Inner.GetOperand<IdRef>("functionType") ?? default;
    public LiteralString FunctionName => Inner.GetOperand<LiteralString>("functionName") ?? default;

    public InstOpSDSLFunction(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpNop : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpNop(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUndef : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpUndef(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSourceContinued : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString ContinuedSource => Inner.GetOperand<LiteralString>("continuedSource") ?? default;

    public InstOpSourceContinued(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSource : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public SourceLanguage Sourcelanguage => Inner.GetEnumOperand<SourceLanguage>("sourcelanguage");
    public LiteralInteger Version => Inner.GetOperand<LiteralInteger>("version") ?? default;
    public IdRef File => Inner.GetOperand<IdRef>("file") ?? default;
    public LiteralString Source => Inner.GetOperand<LiteralString>("source") ?? default;

    public InstOpSource(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSourceExtension : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString Extension => Inner.GetOperand<LiteralString>("extension") ?? default;

    public InstOpSourceExtension(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpName : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public InstOpName(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpMemberName : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Type => Inner.GetOperand<IdRef>("type") ?? default;
    public LiteralInteger Member => Inner.GetOperand<LiteralInteger>("member") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public InstOpMemberName(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpString : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString Value => Inner.GetOperand<LiteralString>("value") ?? default;

    public InstOpString(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpLine : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef File => Inner.GetOperand<IdRef>("file") ?? default;
    public LiteralInteger Line => Inner.GetOperand<LiteralInteger>("line") ?? default;
    public LiteralInteger Column => Inner.GetOperand<LiteralInteger>("column") ?? default;

    public InstOpLine(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpExtension : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public InstOpExtension(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpExtInstImport : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public InstOpExtInstImport(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpExtInst : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Set => Inner.GetOperand<IdRef>("set") ?? default;
    public LiteralInteger Instruction => Inner.GetOperand<LiteralInteger>("instruction") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpExtInst(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpMemoryModel : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public AddressingModel Addressingmodel => Inner.GetEnumOperand<AddressingModel>("addressingmodel");
    public MemoryModel Memorymodel => Inner.GetEnumOperand<MemoryModel>("memorymodel");

    public InstOpMemoryModel(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpEntryPoint : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public ExecutionModel Executionmodel => Inner.GetEnumOperand<ExecutionModel>("executionmodel");
    public IdRef EntryPoint => Inner.GetOperand<IdRef>("entryPoint") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpEntryPoint(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpExecutionMode : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EntryPoint => Inner.GetOperand<IdRef>("entryPoint") ?? default;
    public ExecutionMode Mode => Inner.GetEnumOperand<ExecutionMode>("mode");

    public InstOpExecutionMode(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCapability : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public Capability Capability => Inner.GetEnumOperand<Capability>("capability");

    public InstOpCapability(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeVoid : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeVoid(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeBool : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeBool(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeInt : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralInteger Width => Inner.GetOperand<LiteralInteger>("width") ?? default;
    public LiteralInteger Signedness => Inner.GetOperand<LiteralInteger>("signedness") ?? default;

    public InstOpTypeInt(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeFloat : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralInteger Width => Inner.GetOperand<LiteralInteger>("width") ?? default;
    public FPEncoding FloatingPointEncoding => Inner.GetEnumOperand<FPEncoding>("floatingPointEncoding");

    public InstOpTypeFloat(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeVector : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ComponentType => Inner.GetOperand<IdRef>("componentType") ?? default;
    public LiteralInteger ComponentCount => Inner.GetOperand<LiteralInteger>("componentCount") ?? default;

    public InstOpTypeVector(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeMatrix : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ColumnType => Inner.GetOperand<IdRef>("columnType") ?? default;
    public LiteralInteger ColumnCount => Inner.GetOperand<LiteralInteger>("columnCount") ?? default;

    public InstOpTypeMatrix(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeImage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledType => Inner.GetOperand<IdRef>("sampledType") ?? default;
    public Dim Dim => Inner.GetEnumOperand<Dim>("dim");
    public LiteralInteger Depth => Inner.GetOperand<LiteralInteger>("depth") ?? default;
    public LiteralInteger Arrayed => Inner.GetOperand<LiteralInteger>("arrayed") ?? default;
    public LiteralInteger MS => Inner.GetOperand<LiteralInteger>("mS") ?? default;
    public LiteralInteger Sampled => Inner.GetOperand<LiteralInteger>("sampled") ?? default;
    public ImageFormat Imageformat => Inner.GetEnumOperand<ImageFormat>("imageformat");
    public AccessQualifier Accessqualifier => Inner.GetEnumOperand<AccessQualifier>("accessqualifier");

    public InstOpTypeImage(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeSampler : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeSampler(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeSampledImage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ImageType => Inner.GetOperand<IdRef>("imageType") ?? default;

    public InstOpTypeSampledImage(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeArray : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ElementType => Inner.GetOperand<IdRef>("elementType") ?? default;
    public IdRef Length => Inner.GetOperand<IdRef>("length") ?? default;

    public InstOpTypeArray(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeRuntimeArray : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ElementType => Inner.GetOperand<IdRef>("elementType") ?? default;

    public InstOpTypeRuntimeArray(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeStruct : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpTypeStruct(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeOpaque : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString Thenameoftheopaquetype => Inner.GetOperand<LiteralString>("thenameoftheopaquetype") ?? default;

    public InstOpTypeOpaque(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypePointer : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");
    public IdRef Type => Inner.GetOperand<IdRef>("type") ?? default;

    public InstOpTypePointer(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeFunction : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ReturnType => Inner.GetOperand<IdRef>("returnType") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpTypeFunction(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeEvent(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeDeviceEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeDeviceEvent(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeReserveId : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeReserveId(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeQueue : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeQueue(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypePipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public AccessQualifier Qualifier => Inner.GetEnumOperand<AccessQualifier>("qualifier");

    public InstOpTypePipe(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeForwardPointer : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef PointerType => Inner.GetOperand<IdRef>("pointerType") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");

    public InstOpTypeForwardPointer(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConstantTrue : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpConstantTrue(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConstantFalse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpConstantFalse(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConstant : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpConstant(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConstantComposite : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpConstantComposite(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConstantSampler : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public SamplerAddressingMode Sampleraddressingmode => Inner.GetEnumOperand<SamplerAddressingMode>("sampleraddressingmode");
    public LiteralInteger Param => Inner.GetOperand<LiteralInteger>("param") ?? default;
    public SamplerFilterMode Samplerfiltermode => Inner.GetEnumOperand<SamplerFilterMode>("samplerfiltermode");

    public InstOpConstantSampler(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConstantNull : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpConstantNull(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSpecConstantTrue : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpSpecConstantTrue(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSpecConstantFalse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpSpecConstantFalse(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSpecConstant : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpSpecConstant(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSpecConstantComposite : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpSpecConstantComposite(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSpecConstantOp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralInteger Opcode => Inner.GetOperand<LiteralInteger>("opcode") ?? default;

    public InstOpSpecConstantOp(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFunction : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public FunctionControlMask Functioncontrol => Inner.GetEnumOperand<FunctionControlMask>("functioncontrol");
    public IdRef FunctionType => Inner.GetOperand<IdRef>("functionType") ?? default;

    public InstOpFunction(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFunctionParameter : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpFunctionParameter(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFunctionEnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpFunctionEnd(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFunctionCall : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Function => Inner.GetOperand<IdRef>("function") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpFunctionCall(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpVariable : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");
    public IdRef Initializer => Inner.GetOperand<IdRef>("initializer") ?? default;

    public InstOpVariable(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageTexelPointer : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Sample => Inner.GetOperand<IdRef>("sample") ?? default;

    public InstOpImageTexelPointer(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpLoad : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");

    public InstOpLoad(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpStore : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");

    public InstOpStore(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCopyMemory : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public IdRef Source => Inner.GetOperand<IdRef>("source") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");
    public MemoryAccessMask Memoryaccess1 => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess1");

    public InstOpCopyMemory(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCopyMemorySized : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public IdRef Source => Inner.GetOperand<IdRef>("source") ?? default;
    public IdRef Size => Inner.GetOperand<IdRef>("size") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");
    public MemoryAccessMask Memoryaccess1 => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess1");

    public InstOpCopyMemorySized(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAccessChain : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpAccessChain(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpInBoundsAccessChain : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpInBoundsAccessChain(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpPtrAccessChain : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Element => Inner.GetOperand<IdRef>("element") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpPtrAccessChain(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArrayLength : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Structure => Inner.GetOperand<IdRef>("structure") ?? default;
    public LiteralInteger Arraymember => Inner.GetOperand<LiteralInteger>("arraymember") ?? default;

    public InstOpArrayLength(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGenericPtrMemSemantics : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public InstOpGenericPtrMemSemantics(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpInBoundsPtrAccessChain : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Element => Inner.GetOperand<IdRef>("element") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpInBoundsPtrAccessChain(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpDecorate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public Decoration Decoration => Inner.GetEnumOperand<Decoration>("decoration");

    public InstOpDecorate(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpMemberDecorate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef StructureType => Inner.GetOperand<IdRef>("structureType") ?? default;
    public LiteralInteger Member => Inner.GetOperand<LiteralInteger>("member") ?? default;
    public Decoration Decoration => Inner.GetEnumOperand<Decoration>("decoration");

    public InstOpMemberDecorate(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpDecorationGroup : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpDecorationGroup(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupDecorate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef DecorationGroup => Inner.GetOperand<IdRef>("decorationGroup") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpGroupDecorate(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupMemberDecorate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef DecorationGroup => Inner.GetOperand<IdRef>("decorationGroup") ?? default;
    public PairIdRefLiteralInteger Values => Inner.GetOperand<PairIdRefLiteralInteger>("values") ?? default;

    public InstOpGroupMemberDecorate(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpVectorExtractDynamic : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;

    public InstOpVectorExtractDynamic(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpVectorInsertDynamic : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;
    public IdRef Component => Inner.GetOperand<IdRef>("component") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;

    public InstOpVectorInsertDynamic(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpVectorShuffle : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public InstOpVectorShuffle(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCompositeConstruct : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpCompositeConstruct(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCompositeExtract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Composite => Inner.GetOperand<IdRef>("composite") ?? default;
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public InstOpCompositeExtract(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCompositeInsert : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public IdRef Composite => Inner.GetOperand<IdRef>("composite") ?? default;
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public InstOpCompositeInsert(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCopyObject : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public InstOpCopyObject(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTranspose : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;

    public InstOpTranspose(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSampledImage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Sampler => Inner.GetOperand<IdRef>("sampler") ?? default;

    public InstOpSampledImage(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSampleImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSampleImplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSampleExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSampleExplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSampleDrefImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSampleDrefImplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSampleDrefExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSampleDrefExplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSampleProjImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSampleProjImplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSampleProjExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSampleProjExplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSampleProjDrefImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSampleProjDrefImplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSampleProjDrefExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSampleProjDrefExplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageFetch : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageFetch(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageGather : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Component => Inner.GetOperand<IdRef>("component") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageGather(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageDrefGather : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageDrefGather(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageRead : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageRead(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageWrite : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Texel => Inner.GetOperand<IdRef>("texel") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageWrite(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;

    public InstOpImage(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageQueryFormat : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;

    public InstOpImageQueryFormat(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageQueryOrder : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;

    public InstOpImageQueryOrder(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageQuerySizeLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef LevelofDetail => Inner.GetOperand<IdRef>("levelofDetail") ?? default;

    public InstOpImageQuerySizeLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageQuerySize : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;

    public InstOpImageQuerySize(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageQueryLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;

    public InstOpImageQueryLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageQueryLevels : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;

    public InstOpImageQueryLevels(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageQuerySamples : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;

    public InstOpImageQuerySamples(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConvertFToU : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef FloatValue => Inner.GetOperand<IdRef>("floatValue") ?? default;

    public InstOpConvertFToU(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConvertFToS : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef FloatValue => Inner.GetOperand<IdRef>("floatValue") ?? default;

    public InstOpConvertFToS(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConvertSToF : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SignedValue => Inner.GetOperand<IdRef>("signedValue") ?? default;

    public InstOpConvertSToF(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConvertUToF : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef UnsignedValue => Inner.GetOperand<IdRef>("unsignedValue") ?? default;

    public InstOpConvertUToF(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUConvert : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef UnsignedValue => Inner.GetOperand<IdRef>("unsignedValue") ?? default;

    public InstOpUConvert(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSConvert : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SignedValue => Inner.GetOperand<IdRef>("signedValue") ?? default;

    public InstOpSConvert(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFConvert : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef FloatValue => Inner.GetOperand<IdRef>("floatValue") ?? default;

    public InstOpFConvert(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpQuantizeToF16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpQuantizeToF16(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConvertPtrToU : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public InstOpConvertPtrToU(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSatConvertSToU : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SignedValue => Inner.GetOperand<IdRef>("signedValue") ?? default;

    public InstOpSatConvertSToU(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSatConvertUToS : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef UnsignedValue => Inner.GetOperand<IdRef>("unsignedValue") ?? default;

    public InstOpSatConvertUToS(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConvertUToPtr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef IntegerValue => Inner.GetOperand<IdRef>("integerValue") ?? default;

    public InstOpConvertUToPtr(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpPtrCastToGeneric : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public InstOpPtrCastToGeneric(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGenericCastToPtr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public InstOpGenericCastToPtr(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGenericCastToPtrExplicit : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public StorageClass Storage => Inner.GetEnumOperand<StorageClass>("storage");

    public InstOpGenericCastToPtrExplicit(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpBitcast : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public InstOpBitcast(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSNegate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public InstOpSNegate(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFNegate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public InstOpFNegate(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpIAdd(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFAdd(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpISub : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpISub(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFSub : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFSub(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIMul : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpIMul(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFMul : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFMul(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUDiv : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpUDiv(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSDiv : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpSDiv(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFDiv : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFDiv(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUMod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpUMod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSRem : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpSRem(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSMod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpSMod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFRem : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFRem(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFMod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFMod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpVectorTimesScalar : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;
    public IdRef Scalar => Inner.GetOperand<IdRef>("scalar") ?? default;

    public InstOpVectorTimesScalar(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpMatrixTimesScalar : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;
    public IdRef Scalar => Inner.GetOperand<IdRef>("scalar") ?? default;

    public InstOpMatrixTimesScalar(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpVectorTimesMatrix : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;

    public InstOpVectorTimesMatrix(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpMatrixTimesVector : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;

    public InstOpMatrixTimesVector(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpMatrixTimesMatrix : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef LeftMatrix => Inner.GetOperand<IdRef>("leftMatrix") ?? default;
    public IdRef RightMatrix => Inner.GetOperand<IdRef>("rightMatrix") ?? default;

    public InstOpMatrixTimesMatrix(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpOuterProduct : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;

    public InstOpOuterProduct(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpDot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;

    public InstOpDot(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIAddCarry : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpIAddCarry(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpISubBorrow : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpISubBorrow(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUMulExtended : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpUMulExtended(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSMulExtended : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpSMulExtended(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAny : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;

    public InstOpAny(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAll : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;

    public InstOpAll(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIsNan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpIsNan(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIsInf : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpIsInf(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIsFinite : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpIsFinite(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIsNormal : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpIsNormal(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSignBitSet : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpSignBitSet(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpLessOrGreater : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public InstOpLessOrGreater(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpOrdered : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public InstOpOrdered(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUnordered : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public InstOpUnordered(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpLogicalEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpLogicalEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpLogicalNotEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpLogicalNotEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpLogicalOr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpLogicalOr(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpLogicalAnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpLogicalAnd(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpLogicalNot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public InstOpLogicalNot(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSelect : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Condition => Inner.GetOperand<IdRef>("condition") ?? default;
    public IdRef Object1 => Inner.GetOperand<IdRef>("object1") ?? default;
    public IdRef Object2 => Inner.GetOperand<IdRef>("object2") ?? default;

    public InstOpSelect(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpIEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpINotEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpINotEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUGreaterThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpUGreaterThan(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSGreaterThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpSGreaterThan(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUGreaterThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpUGreaterThanEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSGreaterThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpSGreaterThanEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpULessThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpULessThan(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSLessThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpSLessThan(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpULessThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpULessThanEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSLessThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpSLessThanEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFOrdEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFOrdEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFUnordEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFUnordEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFOrdNotEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFOrdNotEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFUnordNotEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFUnordNotEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFOrdLessThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFOrdLessThan(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFUnordLessThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFUnordLessThan(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFOrdGreaterThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFOrdGreaterThan(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFUnordGreaterThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFUnordGreaterThan(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFOrdLessThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFOrdLessThanEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFUnordLessThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFUnordLessThanEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFOrdGreaterThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFOrdGreaterThanEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFUnordGreaterThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpFUnordGreaterThanEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpShiftRightLogical : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Shift => Inner.GetOperand<IdRef>("shift") ?? default;

    public InstOpShiftRightLogical(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpShiftRightArithmetic : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Shift => Inner.GetOperand<IdRef>("shift") ?? default;

    public InstOpShiftRightArithmetic(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpShiftLeftLogical : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Shift => Inner.GetOperand<IdRef>("shift") ?? default;

    public InstOpShiftLeftLogical(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpBitwiseOr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpBitwiseOr(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpBitwiseXor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpBitwiseXor(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpBitwiseAnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpBitwiseAnd(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpNot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public InstOpNot(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpBitFieldInsert : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Insert => Inner.GetOperand<IdRef>("insert") ?? default;
    public IdRef Offset => Inner.GetOperand<IdRef>("offset") ?? default;
    public IdRef Count => Inner.GetOperand<IdRef>("count") ?? default;

    public InstOpBitFieldInsert(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpBitFieldSExtract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Offset => Inner.GetOperand<IdRef>("offset") ?? default;
    public IdRef Count => Inner.GetOperand<IdRef>("count") ?? default;

    public InstOpBitFieldSExtract(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpBitFieldUExtract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Offset => Inner.GetOperand<IdRef>("offset") ?? default;
    public IdRef Count => Inner.GetOperand<IdRef>("count") ?? default;

    public InstOpBitFieldUExtract(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpBitReverse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;

    public InstOpBitReverse(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpBitCount : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;

    public InstOpBitCount(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpDPdx : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public InstOpDPdx(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpDPdy : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public InstOpDPdy(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFwidth : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public InstOpFwidth(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpDPdxFine : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public InstOpDPdxFine(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpDPdyFine : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public InstOpDPdyFine(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFwidthFine : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public InstOpFwidthFine(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpDPdxCoarse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public InstOpDPdxCoarse(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpDPdyCoarse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public InstOpDPdyCoarse(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFwidthCoarse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public InstOpFwidthCoarse(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpEmitVertex : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpEmitVertex(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpEndPrimitive : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpEndPrimitive(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpEmitStreamVertex : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Stream => Inner.GetOperand<IdRef>("stream") ?? default;

    public InstOpEmitStreamVertex(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpEndStreamPrimitive : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Stream => Inner.GetOperand<IdRef>("stream") ?? default;

    public InstOpEndStreamPrimitive(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpControlBarrier : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public InstOpControlBarrier(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpMemoryBarrier : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public InstOpMemoryBarrier(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicLoad : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public InstOpAtomicLoad(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicStore : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpAtomicStore(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicExchange : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpAtomicExchange(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicCompareExchange : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Equal => Inner.GetOperand<IdMemorySemantics>("equal") ?? default;
    public IdMemorySemantics Unequal => Inner.GetOperand<IdMemorySemantics>("unequal") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Comparator => Inner.GetOperand<IdRef>("comparator") ?? default;

    public InstOpAtomicCompareExchange(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicCompareExchangeWeak : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Equal => Inner.GetOperand<IdMemorySemantics>("equal") ?? default;
    public IdMemorySemantics Unequal => Inner.GetOperand<IdMemorySemantics>("unequal") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Comparator => Inner.GetOperand<IdRef>("comparator") ?? default;

    public InstOpAtomicCompareExchangeWeak(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicIIncrement : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public InstOpAtomicIIncrement(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicIDecrement : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public InstOpAtomicIDecrement(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicIAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpAtomicIAdd(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicISub : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpAtomicISub(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicSMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpAtomicSMin(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicUMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpAtomicUMin(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicSMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpAtomicSMax(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicUMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpAtomicUMax(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicAnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpAtomicAnd(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicOr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpAtomicOr(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicXor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpAtomicXor(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpPhi : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public PairIdRefIdRef Values => Inner.GetOperand<PairIdRefIdRef>("values") ?? default;

    public InstOpPhi(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpLoopMerge : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef MergeBlock => Inner.GetOperand<IdRef>("mergeBlock") ?? default;
    public IdRef ContinueTarget => Inner.GetOperand<IdRef>("continueTarget") ?? default;
    public LoopControlMask Loopcontrol => Inner.GetEnumOperand<LoopControlMask>("loopcontrol");

    public InstOpLoopMerge(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSelectionMerge : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef MergeBlock => Inner.GetOperand<IdRef>("mergeBlock") ?? default;
    public SelectionControlMask Selectioncontrol => Inner.GetEnumOperand<SelectionControlMask>("selectioncontrol");

    public InstOpSelectionMerge(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpLabel : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpLabel(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpBranch : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef TargetLabel => Inner.GetOperand<IdRef>("targetLabel") ?? default;

    public InstOpBranch(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpBranchConditional : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Condition => Inner.GetOperand<IdRef>("condition") ?? default;
    public IdRef TrueLabel => Inner.GetOperand<IdRef>("trueLabel") ?? default;
    public IdRef FalseLabel => Inner.GetOperand<IdRef>("falseLabel") ?? default;
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public InstOpBranchConditional(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSwitch : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Selector => Inner.GetOperand<IdRef>("selector") ?? default;
    public IdRef DefaultId => Inner.GetOperand<IdRef>("defaultId") ?? default;
    public PairLiteralIntegerIdRef Values => Inner.GetOperand<PairLiteralIntegerIdRef>("values") ?? default;

    public InstOpSwitch(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpKill : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpKill(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpReturn : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpReturn(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpReturnValue : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpReturnValue(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUnreachable : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpUnreachable(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpLifetimeStart : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public LiteralInteger Size => Inner.GetOperand<LiteralInteger>("size") ?? default;

    public InstOpLifetimeStart(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpLifetimeStop : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public LiteralInteger Size => Inner.GetOperand<LiteralInteger>("size") ?? default;

    public InstOpLifetimeStop(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupAsyncCopy : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Destination => Inner.GetOperand<IdRef>("destination") ?? default;
    public IdRef Source => Inner.GetOperand<IdRef>("source") ?? default;
    public IdRef NumElements => Inner.GetOperand<IdRef>("numElements") ?? default;
    public IdRef Stride => Inner.GetOperand<IdRef>("stride") ?? default;
    public IdRef EventId => Inner.GetOperand<IdRef>("eventId") ?? default;

    public InstOpGroupAsyncCopy(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupWaitEvents : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef NumEvents => Inner.GetOperand<IdRef>("numEvents") ?? default;
    public IdRef EventsList => Inner.GetOperand<IdRef>("eventsList") ?? default;

    public InstOpGroupWaitEvents(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupAll : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public InstOpGroupAll(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupAny : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public InstOpGroupAny(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupBroadcast : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef LocalId => Inner.GetOperand<IdRef>("localId") ?? default;

    public InstOpGroupBroadcast(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupIAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupIAdd(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupFAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupFAdd(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupFMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupFMin(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupUMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupUMin(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupSMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupSMin(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupFMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupFMax(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupUMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupUMax(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupSMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupSMax(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpReadPipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public InstOpReadPipe(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpWritePipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public InstOpWritePipe(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpReservedReadPipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public InstOpReservedReadPipe(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpReservedWritePipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public InstOpReservedWritePipe(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpReserveReadPipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef NumPackets => Inner.GetOperand<IdRef>("numPackets") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public InstOpReserveReadPipePackets(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpReserveWritePipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef NumPackets => Inner.GetOperand<IdRef>("numPackets") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public InstOpReserveWritePipePackets(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCommitReadPipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public InstOpCommitReadPipe(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCommitWritePipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public InstOpCommitWritePipe(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIsValidReserveId : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;

    public InstOpIsValidReserveId(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGetNumPipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public InstOpGetNumPipePackets(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGetMaxPipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public InstOpGetMaxPipePackets(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupReserveReadPipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef NumPackets => Inner.GetOperand<IdRef>("numPackets") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public InstOpGroupReserveReadPipePackets(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupReserveWritePipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef NumPackets => Inner.GetOperand<IdRef>("numPackets") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public InstOpGroupReserveWritePipePackets(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupCommitReadPipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public InstOpGroupCommitReadPipe(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupCommitWritePipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public InstOpGroupCommitWritePipe(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpEnqueueMarker : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Queue => Inner.GetOperand<IdRef>("queue") ?? default;
    public IdRef NumEvents => Inner.GetOperand<IdRef>("numEvents") ?? default;
    public IdRef WaitEvents => Inner.GetOperand<IdRef>("waitEvents") ?? default;
    public IdRef RetEvent => Inner.GetOperand<IdRef>("retEvent") ?? default;

    public InstOpEnqueueMarker(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpEnqueueKernel : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Queue => Inner.GetOperand<IdRef>("queue") ?? default;
    public IdRef Flags => Inner.GetOperand<IdRef>("flags") ?? default;
    public IdRef NDRange => Inner.GetOperand<IdRef>("nDRange") ?? default;
    public IdRef NumEvents => Inner.GetOperand<IdRef>("numEvents") ?? default;
    public IdRef WaitEvents => Inner.GetOperand<IdRef>("waitEvents") ?? default;
    public IdRef RetEvent => Inner.GetOperand<IdRef>("retEvent") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpEnqueueKernel(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGetKernelNDrangeSubGroupCount : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef NDRange => Inner.GetOperand<IdRef>("nDRange") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public InstOpGetKernelNDrangeSubGroupCount(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGetKernelNDrangeMaxSubGroupSize : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef NDRange => Inner.GetOperand<IdRef>("nDRange") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public InstOpGetKernelNDrangeMaxSubGroupSize(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGetKernelWorkGroupSize : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public InstOpGetKernelWorkGroupSize(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGetKernelPreferredWorkGroupSizeMultiple : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public InstOpGetKernelPreferredWorkGroupSizeMultiple(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRetainEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EventId => Inner.GetOperand<IdRef>("eventId") ?? default;

    public InstOpRetainEvent(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpReleaseEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EventId => Inner.GetOperand<IdRef>("eventId") ?? default;

    public InstOpReleaseEvent(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCreateUserEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpCreateUserEvent(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIsValidEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef EventId => Inner.GetOperand<IdRef>("eventId") ?? default;

    public InstOpIsValidEvent(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSetUserEventStatus : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EventId => Inner.GetOperand<IdRef>("eventId") ?? default;
    public IdRef Status => Inner.GetOperand<IdRef>("status") ?? default;

    public InstOpSetUserEventStatus(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCaptureEventProfilingInfo : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EventId => Inner.GetOperand<IdRef>("eventId") ?? default;
    public IdRef ProfilingInfo => Inner.GetOperand<IdRef>("profilingInfo") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpCaptureEventProfilingInfo(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGetDefaultQueue : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpGetDefaultQueue(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpBuildNDRange : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef GlobalWorkSize => Inner.GetOperand<IdRef>("globalWorkSize") ?? default;
    public IdRef LocalWorkSize => Inner.GetOperand<IdRef>("localWorkSize") ?? default;
    public IdRef GlobalWorkOffset => Inner.GetOperand<IdRef>("globalWorkOffset") ?? default;

    public InstOpBuildNDRange(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSparseSampleImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSparseSampleImplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSparseSampleExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSparseSampleExplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSparseSampleDrefImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSparseSampleDrefImplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSparseSampleDrefExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSparseSampleDrefExplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSparseSampleProjImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSparseSampleProjImplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSparseSampleProjExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSparseSampleProjExplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSparseSampleProjDrefImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSparseSampleProjDrefImplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSparseSampleProjDrefExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSparseSampleProjDrefExplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSparseFetch : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSparseFetch(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSparseGather : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Component => Inner.GetOperand<IdRef>("component") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSparseGather(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSparseDrefGather : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSparseDrefGather(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSparseTexelsResident : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ResidentCode => Inner.GetOperand<IdRef>("residentCode") ?? default;

    public InstOpImageSparseTexelsResident(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpNoLine : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpNoLine(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicFlagTestAndSet : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public InstOpAtomicFlagTestAndSet(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicFlagClear : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public InstOpAtomicFlagClear(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSparseRead : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSparseRead(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSizeOf : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public InstOpSizeOf(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypePipeStorage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypePipeStorage(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConstantPipeStorage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralInteger PacketSize => Inner.GetOperand<LiteralInteger>("packetSize") ?? default;
    public LiteralInteger PacketAlignment => Inner.GetOperand<LiteralInteger>("packetAlignment") ?? default;
    public LiteralInteger Capacity => Inner.GetOperand<LiteralInteger>("capacity") ?? default;

    public InstOpConstantPipeStorage(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCreatePipeFromPipeStorage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PipeStorage => Inner.GetOperand<IdRef>("pipeStorage") ?? default;

    public InstOpCreatePipeFromPipeStorage(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGetKernelLocalSizeForSubgroupCount : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SubgroupCount => Inner.GetOperand<IdRef>("subgroupCount") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public InstOpGetKernelLocalSizeForSubgroupCount(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGetKernelMaxNumSubgroups : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public InstOpGetKernelMaxNumSubgroups(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeNamedBarrier : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeNamedBarrier(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpNamedBarrierInitialize : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SubgroupCount => Inner.GetOperand<IdRef>("subgroupCount") ?? default;

    public InstOpNamedBarrierInitialize(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpMemoryNamedBarrier : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef NamedBarrier => Inner.GetOperand<IdRef>("namedBarrier") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public InstOpMemoryNamedBarrier(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpModuleProcessed : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString Process => Inner.GetOperand<LiteralString>("process") ?? default;

    public InstOpModuleProcessed(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpExecutionModeId : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EntryPoint => Inner.GetOperand<IdRef>("entryPoint") ?? default;
    public ExecutionMode Mode => Inner.GetEnumOperand<ExecutionMode>("mode");

    public InstOpExecutionModeId(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpDecorateId : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public Decoration Decoration => Inner.GetEnumOperand<Decoration>("decoration");

    public InstOpDecorateId(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformElect : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;

    public InstOpGroupNonUniformElect(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformAll : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public InstOpGroupNonUniformAll(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformAny : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public InstOpGroupNonUniformAny(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformAllEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpGroupNonUniformAllEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformBroadcast : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Id => Inner.GetOperand<IdRef>("id") ?? default;

    public InstOpGroupNonUniformBroadcast(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformBroadcastFirst : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpGroupNonUniformBroadcastFirst(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformBallot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public InstOpGroupNonUniformBallot(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformInverseBallot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpGroupNonUniformInverseBallot(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformBallotBitExtract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;

    public InstOpGroupNonUniformBallotBitExtract(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformBallotBitCount : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpGroupNonUniformBallotBitCount(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformBallotFindLSB : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpGroupNonUniformBallotFindLSB(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformBallotFindMSB : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpGroupNonUniformBallotFindMSB(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformShuffle : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Id => Inner.GetOperand<IdRef>("id") ?? default;

    public InstOpGroupNonUniformShuffle(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformShuffleXor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Mask => Inner.GetOperand<IdRef>("mask") ?? default;

    public InstOpGroupNonUniformShuffleXor(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformShuffleUp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Delta => Inner.GetOperand<IdRef>("delta") ?? default;

    public InstOpGroupNonUniformShuffleUp(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformShuffleDown : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Delta => Inner.GetOperand<IdRef>("delta") ?? default;

    public InstOpGroupNonUniformShuffleDown(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformIAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public InstOpGroupNonUniformIAdd(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformFAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public InstOpGroupNonUniformFAdd(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformIMul : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public InstOpGroupNonUniformIMul(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformFMul : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public InstOpGroupNonUniformFMul(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformSMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public InstOpGroupNonUniformSMin(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformUMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public InstOpGroupNonUniformUMin(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformFMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public InstOpGroupNonUniformFMin(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformSMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public InstOpGroupNonUniformSMax(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformUMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public InstOpGroupNonUniformUMax(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformFMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public InstOpGroupNonUniformFMax(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformBitwiseAnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public InstOpGroupNonUniformBitwiseAnd(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformBitwiseOr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public InstOpGroupNonUniformBitwiseOr(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformBitwiseXor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public InstOpGroupNonUniformBitwiseXor(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformLogicalAnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public InstOpGroupNonUniformLogicalAnd(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformLogicalOr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public InstOpGroupNonUniformLogicalOr(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformLogicalXor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public InstOpGroupNonUniformLogicalXor(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformQuadBroadcast : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;

    public InstOpGroupNonUniformQuadBroadcast(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformQuadSwap : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;

    public InstOpGroupNonUniformQuadSwap(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCopyLogical : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public InstOpCopyLogical(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpPtrEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpPtrEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpPtrNotEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpPtrNotEqual(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpPtrDiff : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpPtrDiff(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpColorAttachmentReadEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Attachment => Inner.GetOperand<IdRef>("attachment") ?? default;
    public IdRef Sample => Inner.GetOperand<IdRef>("sample") ?? default;

    public InstOpColorAttachmentReadEXT(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpDepthAttachmentReadEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Sample => Inner.GetOperand<IdRef>("sample") ?? default;

    public InstOpDepthAttachmentReadEXT(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpStencilAttachmentReadEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Sample => Inner.GetOperand<IdRef>("sample") ?? default;

    public InstOpStencilAttachmentReadEXT(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTerminateInvocation : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpTerminateInvocation(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeUntypedPointerKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");

    public InstOpTypeUntypedPointerKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUntypedVariableKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");
    public IdRef DataType => Inner.GetOperand<IdRef>("dataType") ?? default;
    public IdRef Initializer => Inner.GetOperand<IdRef>("initializer") ?? default;

    public InstOpUntypedVariableKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUntypedAccessChainKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseType => Inner.GetOperand<IdRef>("baseType") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpUntypedAccessChainKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUntypedInBoundsAccessChainKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseType => Inner.GetOperand<IdRef>("baseType") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpUntypedInBoundsAccessChainKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupBallotKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public InstOpSubgroupBallotKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupFirstInvocationKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpSubgroupFirstInvocationKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUntypedPtrAccessChainKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseType => Inner.GetOperand<IdRef>("baseType") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Element => Inner.GetOperand<IdRef>("element") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpUntypedPtrAccessChainKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUntypedInBoundsPtrAccessChainKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseType => Inner.GetOperand<IdRef>("baseType") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Element => Inner.GetOperand<IdRef>("element") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpUntypedInBoundsPtrAccessChainKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUntypedArrayLengthKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Structure => Inner.GetOperand<IdRef>("structure") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public LiteralInteger Arraymember => Inner.GetOperand<LiteralInteger>("arraymember") ?? default;

    public InstOpUntypedArrayLengthKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUntypedPrefetchKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef PointerType => Inner.GetOperand<IdRef>("pointerType") ?? default;
    public IdRef NumBytes => Inner.GetOperand<IdRef>("numBytes") ?? default;
    public IdRef RW => Inner.GetOperand<IdRef>("rW") ?? default;
    public IdRef Locality => Inner.GetOperand<IdRef>("locality") ?? default;
    public IdRef CacheType => Inner.GetOperand<IdRef>("cacheType") ?? default;

    public InstOpUntypedPrefetchKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAllKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public InstOpSubgroupAllKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAnyKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public InstOpSubgroupAnyKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAllEqualKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public InstOpSubgroupAllEqualKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformRotateKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Delta => Inner.GetOperand<IdRef>("delta") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public InstOpGroupNonUniformRotateKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupReadInvocationKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;

    public InstOpSubgroupReadInvocationKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpExtInstWithForwardRefsKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Set => Inner.GetOperand<IdRef>("set") ?? default;
    public LiteralInteger Instruction => Inner.GetOperand<LiteralInteger>("instruction") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpExtInstWithForwardRefsKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTraceRayKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Accel => Inner.GetOperand<IdRef>("accel") ?? default;
    public IdRef RayFlags => Inner.GetOperand<IdRef>("rayFlags") ?? default;
    public IdRef CullMask => Inner.GetOperand<IdRef>("cullMask") ?? default;
    public IdRef SBTOffset => Inner.GetOperand<IdRef>("sBTOffset") ?? default;
    public IdRef SBTStride => Inner.GetOperand<IdRef>("sBTStride") ?? default;
    public IdRef MissIndex => Inner.GetOperand<IdRef>("missIndex") ?? default;
    public IdRef RayOrigin => Inner.GetOperand<IdRef>("rayOrigin") ?? default;
    public IdRef RayTmin => Inner.GetOperand<IdRef>("rayTmin") ?? default;
    public IdRef RayDirection => Inner.GetOperand<IdRef>("rayDirection") ?? default;
    public IdRef RayTmax => Inner.GetOperand<IdRef>("rayTmax") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpTraceRayKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpExecuteCallableKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef SBTIndex => Inner.GetOperand<IdRef>("sBTIndex") ?? default;
    public IdRef CallableData => Inner.GetOperand<IdRef>("callableData") ?? default;

    public InstOpExecuteCallableKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConvertUToAccelerationStructureKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Accel => Inner.GetOperand<IdRef>("accel") ?? default;

    public InstOpConvertUToAccelerationStructureKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIgnoreIntersectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpIgnoreIntersectionKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTerminateRayKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpTerminateRayKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSDot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public InstOpSDot(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUDot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public InstOpUDot(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSUDot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public InstOpSUDot(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSDotAccSat : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public IdRef Accumulator => Inner.GetOperand<IdRef>("accumulator") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public InstOpSDotAccSat(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUDotAccSat : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public IdRef Accumulator => Inner.GetOperand<IdRef>("accumulator") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public InstOpUDotAccSat(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSUDotAccSat : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public IdRef Accumulator => Inner.GetOperand<IdRef>("accumulator") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public InstOpSUDotAccSat(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeCooperativeMatrixKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ComponentType => Inner.GetOperand<IdRef>("componentType") ?? default;
    public IdScope Scope => Inner.GetOperand<IdScope>("scope") ?? default;
    public IdRef Rows => Inner.GetOperand<IdRef>("rows") ?? default;
    public IdRef Columns => Inner.GetOperand<IdRef>("columns") ?? default;
    public IdRef Use => Inner.GetOperand<IdRef>("use") ?? default;

    public InstOpTypeCooperativeMatrixKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCooperativeMatrixLoadKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef MemoryLayout => Inner.GetOperand<IdRef>("memoryLayout") ?? default;
    public IdRef Stride => Inner.GetOperand<IdRef>("stride") ?? default;
    public MemoryAccessMask MemoryOperand => Inner.GetEnumOperand<MemoryAccessMask>("memoryOperand");

    public InstOpCooperativeMatrixLoadKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCooperativeMatrixStoreKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public IdRef MemoryLayout => Inner.GetOperand<IdRef>("memoryLayout") ?? default;
    public IdRef Stride => Inner.GetOperand<IdRef>("stride") ?? default;
    public MemoryAccessMask MemoryOperand => Inner.GetEnumOperand<MemoryAccessMask>("memoryOperand");

    public InstOpCooperativeMatrixStoreKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCooperativeMatrixMulAddKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public IdRef C => Inner.GetOperand<IdRef>("c") ?? default;
    public CooperativeMatrixOperandsMask CooperativeMatrixOperands => Inner.GetEnumOperand<CooperativeMatrixOperandsMask>("cooperativeMatrixOperands");

    public InstOpCooperativeMatrixMulAddKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCooperativeMatrixLengthKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Type => Inner.GetOperand<IdRef>("type") ?? default;

    public InstOpCooperativeMatrixLengthKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConstantCompositeReplicateEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpConstantCompositeReplicateEXT(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSpecConstantCompositeReplicateEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpSpecConstantCompositeReplicateEXT(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCompositeConstructReplicateEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpCompositeConstructReplicateEXT(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeRayQueryKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeRayQueryKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryInitializeKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Accel => Inner.GetOperand<IdRef>("accel") ?? default;
    public IdRef RayFlags => Inner.GetOperand<IdRef>("rayFlags") ?? default;
    public IdRef CullMask => Inner.GetOperand<IdRef>("cullMask") ?? default;
    public IdRef RayOrigin => Inner.GetOperand<IdRef>("rayOrigin") ?? default;
    public IdRef RayTMin => Inner.GetOperand<IdRef>("rayTMin") ?? default;
    public IdRef RayDirection => Inner.GetOperand<IdRef>("rayDirection") ?? default;
    public IdRef RayTMax => Inner.GetOperand<IdRef>("rayTMax") ?? default;

    public InstOpRayQueryInitializeKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryTerminateKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public InstOpRayQueryTerminateKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGenerateIntersectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef HitT => Inner.GetOperand<IdRef>("hitT") ?? default;

    public InstOpRayQueryGenerateIntersectionKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryConfirmIntersectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public InstOpRayQueryConfirmIntersectionKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryProceedKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public InstOpRayQueryProceedKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetIntersectionTypeKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public InstOpRayQueryGetIntersectionTypeKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSampleWeightedQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Texture => Inner.GetOperand<IdRef>("texture") ?? default;
    public IdRef Coordinates => Inner.GetOperand<IdRef>("coordinates") ?? default;
    public IdRef Weights => Inner.GetOperand<IdRef>("weights") ?? default;

    public InstOpImageSampleWeightedQCOM(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageBoxFilterQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Texture => Inner.GetOperand<IdRef>("texture") ?? default;
    public IdRef Coordinates => Inner.GetOperand<IdRef>("coordinates") ?? default;
    public IdRef BoxSize => Inner.GetOperand<IdRef>("boxSize") ?? default;

    public InstOpImageBoxFilterQCOM(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageBlockMatchSSDQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef Reference => Inner.GetOperand<IdRef>("reference") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public InstOpImageBlockMatchSSDQCOM(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageBlockMatchSADQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef Reference => Inner.GetOperand<IdRef>("reference") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public InstOpImageBlockMatchSADQCOM(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageBlockMatchWindowSSDQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TargetSampledImage => Inner.GetOperand<IdRef>("targetSampledImage") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef ReferenceSampledImage => Inner.GetOperand<IdRef>("referenceSampledImage") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public InstOpImageBlockMatchWindowSSDQCOM(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageBlockMatchWindowSADQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TargetSampledImage => Inner.GetOperand<IdRef>("targetSampledImage") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef ReferenceSampledImage => Inner.GetOperand<IdRef>("referenceSampledImage") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public InstOpImageBlockMatchWindowSADQCOM(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageBlockMatchGatherSSDQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TargetSampledImage => Inner.GetOperand<IdRef>("targetSampledImage") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef ReferenceSampledImage => Inner.GetOperand<IdRef>("referenceSampledImage") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public InstOpImageBlockMatchGatherSSDQCOM(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageBlockMatchGatherSADQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TargetSampledImage => Inner.GetOperand<IdRef>("targetSampledImage") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef ReferenceSampledImage => Inner.GetOperand<IdRef>("referenceSampledImage") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public InstOpImageBlockMatchGatherSADQCOM(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupIAddNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupIAddNonUniformAMD(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupFAddNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupFAddNonUniformAMD(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupFMinNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupFMinNonUniformAMD(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupUMinNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupUMinNonUniformAMD(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupSMinNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupSMinNonUniformAMD(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupFMaxNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupFMaxNonUniformAMD(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupUMaxNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupUMaxNonUniformAMD(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupSMaxNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupSMaxNonUniformAMD(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFragmentMaskFetchAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;

    public InstOpFragmentMaskFetchAMD(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFragmentFetchAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef FragmentIndex => Inner.GetOperand<IdRef>("fragmentIndex") ?? default;

    public InstOpFragmentFetchAMD(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpReadClockKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Scope => Inner.GetOperand<IdScope>("scope") ?? default;

    public InstOpReadClockKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAllocateNodePayloadsAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Visibility => Inner.GetOperand<IdScope>("visibility") ?? default;
    public IdRef PayloadCount => Inner.GetOperand<IdRef>("payloadCount") ?? default;
    public IdRef NodeIndex => Inner.GetOperand<IdRef>("nodeIndex") ?? default;

    public InstOpAllocateNodePayloadsAMDX(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpEnqueueNodePayloadsAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef PayloadArray => Inner.GetOperand<IdRef>("payloadArray") ?? default;

    public InstOpEnqueueNodePayloadsAMDX(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeNodePayloadArrayAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PayloadType => Inner.GetOperand<IdRef>("payloadType") ?? default;

    public InstOpTypeNodePayloadArrayAMDX(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFinishWritingNodePayloadAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpFinishWritingNodePayloadAMDX(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpNodePayloadArrayLengthAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PayloadArray => Inner.GetOperand<IdRef>("payloadArray") ?? default;

    public InstOpNodePayloadArrayLengthAMDX(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIsNodePayloadValidAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PayloadType => Inner.GetOperand<IdRef>("payloadType") ?? default;
    public IdRef NodeIndex => Inner.GetOperand<IdRef>("nodeIndex") ?? default;

    public InstOpIsNodePayloadValidAMDX(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConstantStringAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString LiteralString => Inner.GetOperand<LiteralString>("literalString") ?? default;

    public InstOpConstantStringAMDX(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSpecConstantStringAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString LiteralString => Inner.GetOperand<LiteralString>("literalString") ?? default;

    public InstOpSpecConstantStringAMDX(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformQuadAllKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public InstOpGroupNonUniformQuadAllKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformQuadAnyKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public InstOpGroupNonUniformQuadAnyKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectRecordHitMotionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef AccelerationStructure => Inner.GetOperand<IdRef>("accelerationStructure") ?? default;
    public IdRef InstanceId => Inner.GetOperand<IdRef>("instanceId") ?? default;
    public IdRef PrimitiveId => Inner.GetOperand<IdRef>("primitiveId") ?? default;
    public IdRef GeometryIndex => Inner.GetOperand<IdRef>("geometryIndex") ?? default;
    public IdRef HitKind => Inner.GetOperand<IdRef>("hitKind") ?? default;
    public IdRef SBTRecordOffset => Inner.GetOperand<IdRef>("sBTRecordOffset") ?? default;
    public IdRef SBTRecordStride => Inner.GetOperand<IdRef>("sBTRecordStride") ?? default;
    public IdRef Origin => Inner.GetOperand<IdRef>("origin") ?? default;
    public IdRef TMin => Inner.GetOperand<IdRef>("tMin") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;
    public IdRef TMax => Inner.GetOperand<IdRef>("tMax") ?? default;
    public IdRef CurrentTime => Inner.GetOperand<IdRef>("currentTime") ?? default;
    public IdRef HitObjectAttributes => Inner.GetOperand<IdRef>("hitObjectAttributes") ?? default;

    public InstOpHitObjectRecordHitMotionNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectRecordHitWithIndexMotionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef AccelerationStructure => Inner.GetOperand<IdRef>("accelerationStructure") ?? default;
    public IdRef InstanceId => Inner.GetOperand<IdRef>("instanceId") ?? default;
    public IdRef PrimitiveId => Inner.GetOperand<IdRef>("primitiveId") ?? default;
    public IdRef GeometryIndex => Inner.GetOperand<IdRef>("geometryIndex") ?? default;
    public IdRef HitKind => Inner.GetOperand<IdRef>("hitKind") ?? default;
    public IdRef SBTRecordIndex => Inner.GetOperand<IdRef>("sBTRecordIndex") ?? default;
    public IdRef Origin => Inner.GetOperand<IdRef>("origin") ?? default;
    public IdRef TMin => Inner.GetOperand<IdRef>("tMin") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;
    public IdRef TMax => Inner.GetOperand<IdRef>("tMax") ?? default;
    public IdRef CurrentTime => Inner.GetOperand<IdRef>("currentTime") ?? default;
    public IdRef HitObjectAttributes => Inner.GetOperand<IdRef>("hitObjectAttributes") ?? default;

    public InstOpHitObjectRecordHitWithIndexMotionNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectRecordMissMotionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef SBTIndex => Inner.GetOperand<IdRef>("sBTIndex") ?? default;
    public IdRef Origin => Inner.GetOperand<IdRef>("origin") ?? default;
    public IdRef TMin => Inner.GetOperand<IdRef>("tMin") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;
    public IdRef TMax => Inner.GetOperand<IdRef>("tMax") ?? default;
    public IdRef CurrentTime => Inner.GetOperand<IdRef>("currentTime") ?? default;

    public InstOpHitObjectRecordMissMotionNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectGetWorldToObjectNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectGetWorldToObjectNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectGetObjectToWorldNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectGetObjectToWorldNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectGetObjectRayDirectionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectGetObjectRayDirectionNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectGetObjectRayOriginNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectGetObjectRayOriginNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectTraceRayMotionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef AccelerationStructure => Inner.GetOperand<IdRef>("accelerationStructure") ?? default;
    public IdRef RayFlags => Inner.GetOperand<IdRef>("rayFlags") ?? default;
    public IdRef Cullmask => Inner.GetOperand<IdRef>("cullmask") ?? default;
    public IdRef SBTRecordOffset => Inner.GetOperand<IdRef>("sBTRecordOffset") ?? default;
    public IdRef SBTRecordStride => Inner.GetOperand<IdRef>("sBTRecordStride") ?? default;
    public IdRef MissIndex => Inner.GetOperand<IdRef>("missIndex") ?? default;
    public IdRef Origin => Inner.GetOperand<IdRef>("origin") ?? default;
    public IdRef TMin => Inner.GetOperand<IdRef>("tMin") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;
    public IdRef TMax => Inner.GetOperand<IdRef>("tMax") ?? default;
    public IdRef Time => Inner.GetOperand<IdRef>("time") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpHitObjectTraceRayMotionNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectGetShaderRecordBufferHandleNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectGetShaderRecordBufferHandleNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectGetShaderBindingTableRecordIndexNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectGetShaderBindingTableRecordIndexNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectRecordEmptyNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectRecordEmptyNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectTraceRayNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef AccelerationStructure => Inner.GetOperand<IdRef>("accelerationStructure") ?? default;
    public IdRef RayFlags => Inner.GetOperand<IdRef>("rayFlags") ?? default;
    public IdRef Cullmask => Inner.GetOperand<IdRef>("cullmask") ?? default;
    public IdRef SBTRecordOffset => Inner.GetOperand<IdRef>("sBTRecordOffset") ?? default;
    public IdRef SBTRecordStride => Inner.GetOperand<IdRef>("sBTRecordStride") ?? default;
    public IdRef MissIndex => Inner.GetOperand<IdRef>("missIndex") ?? default;
    public IdRef Origin => Inner.GetOperand<IdRef>("origin") ?? default;
    public IdRef TMin => Inner.GetOperand<IdRef>("tMin") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;
    public IdRef TMax => Inner.GetOperand<IdRef>("tMax") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpHitObjectTraceRayNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectRecordHitNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef AccelerationStructure => Inner.GetOperand<IdRef>("accelerationStructure") ?? default;
    public IdRef InstanceId => Inner.GetOperand<IdRef>("instanceId") ?? default;
    public IdRef PrimitiveId => Inner.GetOperand<IdRef>("primitiveId") ?? default;
    public IdRef GeometryIndex => Inner.GetOperand<IdRef>("geometryIndex") ?? default;
    public IdRef HitKind => Inner.GetOperand<IdRef>("hitKind") ?? default;
    public IdRef SBTRecordOffset => Inner.GetOperand<IdRef>("sBTRecordOffset") ?? default;
    public IdRef SBTRecordStride => Inner.GetOperand<IdRef>("sBTRecordStride") ?? default;
    public IdRef Origin => Inner.GetOperand<IdRef>("origin") ?? default;
    public IdRef TMin => Inner.GetOperand<IdRef>("tMin") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;
    public IdRef TMax => Inner.GetOperand<IdRef>("tMax") ?? default;
    public IdRef HitObjectAttributes => Inner.GetOperand<IdRef>("hitObjectAttributes") ?? default;

    public InstOpHitObjectRecordHitNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectRecordHitWithIndexNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef AccelerationStructure => Inner.GetOperand<IdRef>("accelerationStructure") ?? default;
    public IdRef InstanceId => Inner.GetOperand<IdRef>("instanceId") ?? default;
    public IdRef PrimitiveId => Inner.GetOperand<IdRef>("primitiveId") ?? default;
    public IdRef GeometryIndex => Inner.GetOperand<IdRef>("geometryIndex") ?? default;
    public IdRef HitKind => Inner.GetOperand<IdRef>("hitKind") ?? default;
    public IdRef SBTRecordIndex => Inner.GetOperand<IdRef>("sBTRecordIndex") ?? default;
    public IdRef Origin => Inner.GetOperand<IdRef>("origin") ?? default;
    public IdRef TMin => Inner.GetOperand<IdRef>("tMin") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;
    public IdRef TMax => Inner.GetOperand<IdRef>("tMax") ?? default;
    public IdRef HitObjectAttributes => Inner.GetOperand<IdRef>("hitObjectAttributes") ?? default;

    public InstOpHitObjectRecordHitWithIndexNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectRecordMissNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef SBTIndex => Inner.GetOperand<IdRef>("sBTIndex") ?? default;
    public IdRef Origin => Inner.GetOperand<IdRef>("origin") ?? default;
    public IdRef TMin => Inner.GetOperand<IdRef>("tMin") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;
    public IdRef TMax => Inner.GetOperand<IdRef>("tMax") ?? default;

    public InstOpHitObjectRecordMissNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectExecuteShaderNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpHitObjectExecuteShaderNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectGetCurrentTimeNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectGetCurrentTimeNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectGetAttributesNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef HitObjectAttribute => Inner.GetOperand<IdRef>("hitObjectAttribute") ?? default;

    public InstOpHitObjectGetAttributesNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectGetHitKindNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectGetHitKindNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectGetPrimitiveIndexNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectGetPrimitiveIndexNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectGetGeometryIndexNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectGetGeometryIndexNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectGetInstanceIdNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectGetInstanceIdNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectGetInstanceCustomIndexNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectGetInstanceCustomIndexNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectGetWorldRayDirectionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectGetWorldRayDirectionNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectGetWorldRayOriginNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectGetWorldRayOriginNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectGetRayTMaxNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectGetRayTMaxNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectGetRayTMinNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectGetRayTMinNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectIsEmptyNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectIsEmptyNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectIsHitNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectIsHitNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpHitObjectIsMissNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public InstOpHitObjectIsMissNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpReorderThreadWithHitObjectNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef Hint => Inner.GetOperand<IdRef>("hint") ?? default;
    public IdRef Bits => Inner.GetOperand<IdRef>("bits") ?? default;

    public InstOpReorderThreadWithHitObjectNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpReorderThreadWithHintNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Hint => Inner.GetOperand<IdRef>("hint") ?? default;
    public IdRef Bits => Inner.GetOperand<IdRef>("bits") ?? default;

    public InstOpReorderThreadWithHintNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeHitObjectNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeHitObjectNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpImageSampleFootprintNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Granularity => Inner.GetOperand<IdRef>("granularity") ?? default;
    public IdRef Coarse => Inner.GetOperand<IdRef>("coarse") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public InstOpImageSampleFootprintNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCooperativeMatrixConvertNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;

    public InstOpCooperativeMatrixConvertNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpEmitMeshTasksEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef GroupCountX => Inner.GetOperand<IdRef>("groupCountX") ?? default;
    public IdRef GroupCountY => Inner.GetOperand<IdRef>("groupCountY") ?? default;
    public IdRef GroupCountZ => Inner.GetOperand<IdRef>("groupCountZ") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpEmitMeshTasksEXT(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSetMeshOutputsEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef VertexCount => Inner.GetOperand<IdRef>("vertexCount") ?? default;
    public IdRef PrimitiveCount => Inner.GetOperand<IdRef>("primitiveCount") ?? default;

    public InstOpSetMeshOutputsEXT(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupNonUniformPartitionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpGroupNonUniformPartitionNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpWritePackedPrimitiveIndices4x8NV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef IndexOffset => Inner.GetOperand<IdRef>("indexOffset") ?? default;
    public IdRef PackedIndices => Inner.GetOperand<IdRef>("packedIndices") ?? default;

    public InstOpWritePackedPrimitiveIndices4x8NV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFetchMicroTriangleVertexPositionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Accel => Inner.GetOperand<IdRef>("accel") ?? default;
    public IdRef InstanceId => Inner.GetOperand<IdRef>("instanceId") ?? default;
    public IdRef GeometryIndex => Inner.GetOperand<IdRef>("geometryIndex") ?? default;
    public IdRef PrimitiveIndex => Inner.GetOperand<IdRef>("primitiveIndex") ?? default;
    public IdRef Barycentric => Inner.GetOperand<IdRef>("barycentric") ?? default;

    public InstOpFetchMicroTriangleVertexPositionNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFetchMicroTriangleVertexBarycentricNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Accel => Inner.GetOperand<IdRef>("accel") ?? default;
    public IdRef InstanceId => Inner.GetOperand<IdRef>("instanceId") ?? default;
    public IdRef GeometryIndex => Inner.GetOperand<IdRef>("geometryIndex") ?? default;
    public IdRef PrimitiveIndex => Inner.GetOperand<IdRef>("primitiveIndex") ?? default;
    public IdRef Barycentric => Inner.GetOperand<IdRef>("barycentric") ?? default;

    public InstOpFetchMicroTriangleVertexBarycentricNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpReportIntersectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Hit => Inner.GetOperand<IdRef>("hit") ?? default;
    public IdRef HitKind => Inner.GetOperand<IdRef>("hitKind") ?? default;

    public InstOpReportIntersectionKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIgnoreIntersectionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpIgnoreIntersectionNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTerminateRayNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpTerminateRayNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTraceNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Accel => Inner.GetOperand<IdRef>("accel") ?? default;
    public IdRef RayFlags => Inner.GetOperand<IdRef>("rayFlags") ?? default;
    public IdRef CullMask => Inner.GetOperand<IdRef>("cullMask") ?? default;
    public IdRef SBTOffset => Inner.GetOperand<IdRef>("sBTOffset") ?? default;
    public IdRef SBTStride => Inner.GetOperand<IdRef>("sBTStride") ?? default;
    public IdRef MissIndex => Inner.GetOperand<IdRef>("missIndex") ?? default;
    public IdRef RayOrigin => Inner.GetOperand<IdRef>("rayOrigin") ?? default;
    public IdRef RayTmin => Inner.GetOperand<IdRef>("rayTmin") ?? default;
    public IdRef RayDirection => Inner.GetOperand<IdRef>("rayDirection") ?? default;
    public IdRef RayTmax => Inner.GetOperand<IdRef>("rayTmax") ?? default;
    public IdRef PayloadId => Inner.GetOperand<IdRef>("payloadId") ?? default;

    public InstOpTraceNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTraceMotionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Accel => Inner.GetOperand<IdRef>("accel") ?? default;
    public IdRef RayFlags => Inner.GetOperand<IdRef>("rayFlags") ?? default;
    public IdRef CullMask => Inner.GetOperand<IdRef>("cullMask") ?? default;
    public IdRef SBTOffset => Inner.GetOperand<IdRef>("sBTOffset") ?? default;
    public IdRef SBTStride => Inner.GetOperand<IdRef>("sBTStride") ?? default;
    public IdRef MissIndex => Inner.GetOperand<IdRef>("missIndex") ?? default;
    public IdRef RayOrigin => Inner.GetOperand<IdRef>("rayOrigin") ?? default;
    public IdRef RayTmin => Inner.GetOperand<IdRef>("rayTmin") ?? default;
    public IdRef RayDirection => Inner.GetOperand<IdRef>("rayDirection") ?? default;
    public IdRef RayTmax => Inner.GetOperand<IdRef>("rayTmax") ?? default;
    public IdRef Time => Inner.GetOperand<IdRef>("time") ?? default;
    public IdRef PayloadId => Inner.GetOperand<IdRef>("payloadId") ?? default;

    public InstOpTraceMotionNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTraceRayMotionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Accel => Inner.GetOperand<IdRef>("accel") ?? default;
    public IdRef RayFlags => Inner.GetOperand<IdRef>("rayFlags") ?? default;
    public IdRef CullMask => Inner.GetOperand<IdRef>("cullMask") ?? default;
    public IdRef SBTOffset => Inner.GetOperand<IdRef>("sBTOffset") ?? default;
    public IdRef SBTStride => Inner.GetOperand<IdRef>("sBTStride") ?? default;
    public IdRef MissIndex => Inner.GetOperand<IdRef>("missIndex") ?? default;
    public IdRef RayOrigin => Inner.GetOperand<IdRef>("rayOrigin") ?? default;
    public IdRef RayTmin => Inner.GetOperand<IdRef>("rayTmin") ?? default;
    public IdRef RayDirection => Inner.GetOperand<IdRef>("rayDirection") ?? default;
    public IdRef RayTmax => Inner.GetOperand<IdRef>("rayTmax") ?? default;
    public IdRef Time => Inner.GetOperand<IdRef>("time") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpTraceRayMotionNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetIntersectionTriangleVertexPositionsKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public InstOpRayQueryGetIntersectionTriangleVertexPositionsKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeAccelerationStructureKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeAccelerationStructureKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpExecuteCallableNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef SBTIndex => Inner.GetOperand<IdRef>("sBTIndex") ?? default;
    public IdRef CallableDataId => Inner.GetOperand<IdRef>("callableDataId") ?? default;

    public InstOpExecuteCallableNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeCooperativeMatrixNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ComponentType => Inner.GetOperand<IdRef>("componentType") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Rows => Inner.GetOperand<IdRef>("rows") ?? default;
    public IdRef Columns => Inner.GetOperand<IdRef>("columns") ?? default;

    public InstOpTypeCooperativeMatrixNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCooperativeMatrixLoadNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef Stride => Inner.GetOperand<IdRef>("stride") ?? default;
    public IdRef ColumnMajor => Inner.GetOperand<IdRef>("columnMajor") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");

    public InstOpCooperativeMatrixLoadNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCooperativeMatrixStoreNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public IdRef Stride => Inner.GetOperand<IdRef>("stride") ?? default;
    public IdRef ColumnMajor => Inner.GetOperand<IdRef>("columnMajor") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");

    public InstOpCooperativeMatrixStoreNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCooperativeMatrixMulAddNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public IdRef C => Inner.GetOperand<IdRef>("c") ?? default;

    public InstOpCooperativeMatrixMulAddNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCooperativeMatrixLengthNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Type => Inner.GetOperand<IdRef>("type") ?? default;

    public InstOpCooperativeMatrixLengthNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpBeginInvocationInterlockEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpBeginInvocationInterlockEXT(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpEndInvocationInterlockEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpEndInvocationInterlockEXT(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCooperativeMatrixReduceNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;
    public CooperativeMatrixReduceMask Reduce => Inner.GetEnumOperand<CooperativeMatrixReduceMask>("reduce");
    public IdRef CombineFunc => Inner.GetOperand<IdRef>("combineFunc") ?? default;

    public InstOpCooperativeMatrixReduceNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCooperativeMatrixLoadTensorNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public MemoryAccessMask MemoryOperand => Inner.GetEnumOperand<MemoryAccessMask>("memoryOperand");
    public TensorAddressingOperandsMask TensorAddressingOperands => Inner.GetEnumOperand<TensorAddressingOperandsMask>("tensorAddressingOperands");

    public InstOpCooperativeMatrixLoadTensorNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCooperativeMatrixStoreTensorNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public MemoryAccessMask MemoryOperand => Inner.GetEnumOperand<MemoryAccessMask>("memoryOperand");
    public TensorAddressingOperandsMask TensorAddressingOperands => Inner.GetEnumOperand<TensorAddressingOperandsMask>("tensorAddressingOperands");

    public InstOpCooperativeMatrixStoreTensorNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCooperativeMatrixPerElementOpNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;
    public IdRef Func => Inner.GetOperand<IdRef>("func") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpCooperativeMatrixPerElementOpNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeTensorLayoutNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Dim => Inner.GetOperand<IdRef>("dim") ?? default;
    public IdRef ClampMode => Inner.GetOperand<IdRef>("clampMode") ?? default;

    public InstOpTypeTensorLayoutNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeTensorViewNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Dim => Inner.GetOperand<IdRef>("dim") ?? default;
    public IdRef HasDimensions => Inner.GetOperand<IdRef>("hasDimensions") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpTypeTensorViewNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCreateTensorLayoutNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpCreateTensorLayoutNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTensorLayoutSetDimensionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpTensorLayoutSetDimensionNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTensorLayoutSetStrideNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpTensorLayoutSetStrideNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTensorLayoutSliceNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpTensorLayoutSliceNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTensorLayoutSetClampValueNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpTensorLayoutSetClampValueNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCreateTensorViewNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpCreateTensorViewNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTensorViewSetDimensionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorView => Inner.GetOperand<IdRef>("tensorView") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpTensorViewSetDimensionNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTensorViewSetStrideNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorView => Inner.GetOperand<IdRef>("tensorView") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpTensorViewSetStrideNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpDemoteToHelperInvocation : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpDemoteToHelperInvocation(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIsHelperInvocationEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpIsHelperInvocationEXT(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTensorViewSetClipNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorView => Inner.GetOperand<IdRef>("tensorView") ?? default;
    public IdRef ClipRowOffset => Inner.GetOperand<IdRef>("clipRowOffset") ?? default;
    public IdRef ClipRowSpan => Inner.GetOperand<IdRef>("clipRowSpan") ?? default;
    public IdRef ClipColOffset => Inner.GetOperand<IdRef>("clipColOffset") ?? default;
    public IdRef ClipColSpan => Inner.GetOperand<IdRef>("clipColSpan") ?? default;

    public InstOpTensorViewSetClipNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTensorLayoutSetBlockSizeNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpTensorLayoutSetBlockSizeNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCooperativeMatrixTransposeNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;

    public InstOpCooperativeMatrixTransposeNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConvertUToImageNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public InstOpConvertUToImageNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConvertUToSamplerNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public InstOpConvertUToSamplerNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConvertImageToUNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public InstOpConvertImageToUNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConvertSamplerToUNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public InstOpConvertSamplerToUNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConvertUToSampledImageNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public InstOpConvertUToSampledImageNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConvertSampledImageToUNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public InstOpConvertSampledImageToUNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSamplerImageAddressingModeNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralInteger BitWidth => Inner.GetOperand<LiteralInteger>("bitWidth") ?? default;

    public InstOpSamplerImageAddressingModeNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRawAccessChainNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Bytestride => Inner.GetOperand<IdRef>("bytestride") ?? default;
    public IdRef Elementindex => Inner.GetOperand<IdRef>("elementindex") ?? default;
    public IdRef Byteoffset => Inner.GetOperand<IdRef>("byteoffset") ?? default;
    public RawAccessChainOperandsMask Rawaccesschainoperands => Inner.GetEnumOperand<RawAccessChainOperandsMask>("rawaccesschainoperands");

    public InstOpRawAccessChainNV(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupShuffleINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Data => Inner.GetOperand<IdRef>("data") ?? default;
    public IdRef InvocationId => Inner.GetOperand<IdRef>("invocationId") ?? default;

    public InstOpSubgroupShuffleINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupShuffleDownINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Current => Inner.GetOperand<IdRef>("current") ?? default;
    public IdRef Next => Inner.GetOperand<IdRef>("next") ?? default;
    public IdRef Delta => Inner.GetOperand<IdRef>("delta") ?? default;

    public InstOpSubgroupShuffleDownINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupShuffleUpINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Previous => Inner.GetOperand<IdRef>("previous") ?? default;
    public IdRef Current => Inner.GetOperand<IdRef>("current") ?? default;
    public IdRef Delta => Inner.GetOperand<IdRef>("delta") ?? default;

    public InstOpSubgroupShuffleUpINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupShuffleXorINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Data => Inner.GetOperand<IdRef>("data") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpSubgroupShuffleXorINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupBlockReadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Ptr => Inner.GetOperand<IdRef>("ptr") ?? default;

    public InstOpSubgroupBlockReadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupBlockWriteINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Ptr => Inner.GetOperand<IdRef>("ptr") ?? default;
    public IdRef Data => Inner.GetOperand<IdRef>("data") ?? default;

    public InstOpSubgroupBlockWriteINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupImageBlockReadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;

    public InstOpSubgroupImageBlockReadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupImageBlockWriteINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Data => Inner.GetOperand<IdRef>("data") ?? default;

    public InstOpSubgroupImageBlockWriteINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupImageMediaBlockReadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Width => Inner.GetOperand<IdRef>("width") ?? default;
    public IdRef Height => Inner.GetOperand<IdRef>("height") ?? default;

    public InstOpSubgroupImageMediaBlockReadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupImageMediaBlockWriteINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Width => Inner.GetOperand<IdRef>("width") ?? default;
    public IdRef Height => Inner.GetOperand<IdRef>("height") ?? default;
    public IdRef Data => Inner.GetOperand<IdRef>("data") ?? default;

    public InstOpSubgroupImageMediaBlockWriteINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUCountLeadingZerosINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public InstOpUCountLeadingZerosINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUCountTrailingZerosINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public InstOpUCountTrailingZerosINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAbsISubINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpAbsISubINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAbsUSubINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpAbsUSubINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIAddSatINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpIAddSatINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUAddSatINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpUAddSatINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIAverageINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpIAverageINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUAverageINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpUAverageINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIAverageRoundedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpIAverageRoundedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUAverageRoundedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpUAverageRoundedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpISubSatINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpISubSatINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUSubSatINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpUSubSatINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpIMul32x16INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpIMul32x16INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpUMul32x16INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public InstOpUMul32x16INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConstantFunctionPointerINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Function => Inner.GetOperand<IdRef>("function") ?? default;

    public InstOpConstantFunctionPointerINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFunctionPointerCallINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpFunctionPointerCallINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAsmTargetINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString Asmtarget => Inner.GetOperand<LiteralString>("asmtarget") ?? default;

    public InstOpAsmTargetINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAsmINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Asmtype => Inner.GetOperand<IdRef>("asmtype") ?? default;
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public LiteralString Asminstructions => Inner.GetOperand<LiteralString>("asminstructions") ?? default;
    public LiteralString Constraints => Inner.GetOperand<LiteralString>("constraints") ?? default;

    public InstOpAsmINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAsmCallINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Asm => Inner.GetOperand<IdRef>("asm") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpAsmCallINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicFMinEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpAtomicFMinEXT(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicFMaxEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpAtomicFMaxEXT(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAssumeTrueKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Condition => Inner.GetOperand<IdRef>("condition") ?? default;

    public InstOpAssumeTrueKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpExpectKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ExpectedValue => Inner.GetOperand<IdRef>("expectedValue") ?? default;

    public InstOpExpectKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpDecorateString : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public Decoration Decoration => Inner.GetEnumOperand<Decoration>("decoration");

    public InstOpDecorateString(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpMemberDecorateString : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef StructType => Inner.GetOperand<IdRef>("structType") ?? default;
    public LiteralInteger Member => Inner.GetOperand<LiteralInteger>("member") ?? default;
    public Decoration Decoration => Inner.GetEnumOperand<Decoration>("decoration");

    public InstOpMemberDecorateString(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpVmeImageINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ImageType => Inner.GetOperand<IdRef>("imageType") ?? default;
    public IdRef Sampler => Inner.GetOperand<IdRef>("sampler") ?? default;

    public InstOpVmeImageINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeVmeImageINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ImageType => Inner.GetOperand<IdRef>("imageType") ?? default;

    public InstOpTypeVmeImageINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeAvcImePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeAvcImePayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeAvcRefPayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeAvcRefPayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeAvcSicPayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeAvcSicPayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeAvcMcePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeAvcMcePayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeAvcMceResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeAvcMceResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeAvcImeResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeAvcImeResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeAvcImeResultSingleReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeAvcImeResultSingleReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeAvcImeResultDualReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeAvcImeResultDualReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeAvcImeSingleReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeAvcImeSingleReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeAvcImeDualReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeAvcImeDualReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeAvcRefResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeAvcRefResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeAvcSicResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpTypeAvcSicResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public InstOpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ReferenceBasePenalty => Inner.GetOperand<IdRef>("referenceBasePenalty") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public InstOpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceSetInterShapePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedShapePenalty => Inner.GetOperand<IdRef>("packedShapePenalty") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceSetInterShapePenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public InstOpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceSetInterDirectionPenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef DirectionCost => Inner.GetOperand<IdRef>("directionCost") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceSetInterDirectionPenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public InstOpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public InstOpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceSetMotionVectorCostFunctionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedCostCenterDelta => Inner.GetOperand<IdRef>("packedCostCenterDelta") ?? default;
    public IdRef PackedCostTable => Inner.GetOperand<IdRef>("packedCostTable") ?? default;
    public IdRef CostPrecision => Inner.GetOperand<IdRef>("costPrecision") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceSetMotionVectorCostFunctionINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public InstOpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceSetAcOnlyHaarINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceSetAcOnlyHaarINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SourceFieldPolarity => Inner.GetOperand<IdRef>("sourceFieldPolarity") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ReferenceFieldPolarity => Inner.GetOperand<IdRef>("referenceFieldPolarity") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ForwardReferenceFieldPolarity => Inner.GetOperand<IdRef>("forwardReferenceFieldPolarity") ?? default;
    public IdRef BackwardReferenceFieldPolarity => Inner.GetOperand<IdRef>("backwardReferenceFieldPolarity") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceConvertToImePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceConvertToImePayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceConvertToImeResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceConvertToImeResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceConvertToRefPayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceConvertToRefPayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceConvertToRefResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceConvertToRefResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceConvertToSicPayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceConvertToSicPayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceConvertToSicResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceConvertToSicResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetMotionVectorsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceGetMotionVectorsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetInterDistortionsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceGetInterDistortionsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetBestInterDistortionsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceGetBestInterDistortionsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetInterMajorShapeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceGetInterMajorShapeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetInterMinorShapeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceGetInterMinorShapeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetInterDirectionsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceGetInterDirectionsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetInterMotionVectorCountINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceGetInterMotionVectorCountINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetInterReferenceIdsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceGetInterReferenceIdsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedReferenceIds => Inner.GetOperand<IdRef>("packedReferenceIds") ?? default;
    public IdRef PackedReferenceParameterFieldPolarities => Inner.GetOperand<IdRef>("packedReferenceParameterFieldPolarities") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeInitializeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcCoord => Inner.GetOperand<IdRef>("srcCoord") ?? default;
    public IdRef PartitionMask => Inner.GetOperand<IdRef>("partitionMask") ?? default;
    public IdRef SADAdjustment => Inner.GetOperand<IdRef>("sADAdjustment") ?? default;

    public InstOpSubgroupAvcImeInitializeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeSetSingleReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RefOffset => Inner.GetOperand<IdRef>("refOffset") ?? default;
    public IdRef SearchWindowConfig => Inner.GetOperand<IdRef>("searchWindowConfig") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeSetSingleReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeSetDualReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef FwdRefOffset => Inner.GetOperand<IdRef>("fwdRefOffset") ?? default;
    public IdRef BwdRefOffset => Inner.GetOperand<IdRef>("bwdRefOffset") ?? default;
    public IdRef IdSearchWindowConfig => Inner.GetOperand<IdRef>("idSearchWindowConfig") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeSetDualReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeRefWindowSizeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SearchWindowConfig => Inner.GetOperand<IdRef>("searchWindowConfig") ?? default;
    public IdRef DualRef => Inner.GetOperand<IdRef>("dualRef") ?? default;

    public InstOpSubgroupAvcImeRefWindowSizeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeAdjustRefOffsetINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RefOffset => Inner.GetOperand<IdRef>("refOffset") ?? default;
    public IdRef SrcCoord => Inner.GetOperand<IdRef>("srcCoord") ?? default;
    public IdRef RefWindowSize => Inner.GetOperand<IdRef>("refWindowSize") ?? default;
    public IdRef ImageSize => Inner.GetOperand<IdRef>("imageSize") ?? default;

    public InstOpSubgroupAvcImeAdjustRefOffsetINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeConvertToMcePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeConvertToMcePayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeSetMaxMotionVectorCountINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef MaxMotionVectorCount => Inner.GetOperand<IdRef>("maxMotionVectorCount") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeSetMaxMotionVectorCountINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeSetUnidirectionalMixDisableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeSetUnidirectionalMixDisableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Threshold => Inner.GetOperand<IdRef>("threshold") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeSetWeightedSadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedSadWeights => Inner.GetOperand<IdRef>("packedSadWeights") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeSetWeightedSadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeEvaluateWithSingleReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeEvaluateWithSingleReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeEvaluateWithDualReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeEvaluateWithDualReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef StreaminComponents => Inner.GetOperand<IdRef>("streaminComponents") ?? default;

    public InstOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef StreaminComponents => Inner.GetOperand<IdRef>("streaminComponents") ?? default;

    public InstOpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef StreaminComponents => Inner.GetOperand<IdRef>("streaminComponents") ?? default;

    public InstOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef StreaminComponents => Inner.GetOperand<IdRef>("streaminComponents") ?? default;

    public InstOpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeConvertToMceResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeConvertToMceResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeGetSingleReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeGetSingleReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeGetDualReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeGetDualReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeStripSingleReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeStripSingleReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeStripDualReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeStripDualReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;

    public InstOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;

    public InstOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;

    public InstOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;

    public InstOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;

    public InstOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;

    public InstOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeGetBorderReachedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ImageSelect => Inner.GetOperand<IdRef>("imageSelect") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeGetBorderReachedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeGetTruncatedSearchIndicationINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeGetTruncatedSearchIndicationINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcFmeInitializeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcCoord => Inner.GetOperand<IdRef>("srcCoord") ?? default;
    public IdRef MotionVectors => Inner.GetOperand<IdRef>("motionVectors") ?? default;
    public IdRef MajorShapes => Inner.GetOperand<IdRef>("majorShapes") ?? default;
    public IdRef MinorShapes => Inner.GetOperand<IdRef>("minorShapes") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;
    public IdRef PixelResolution => Inner.GetOperand<IdRef>("pixelResolution") ?? default;
    public IdRef SadAdjustment => Inner.GetOperand<IdRef>("sadAdjustment") ?? default;

    public InstOpSubgroupAvcFmeInitializeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcBmeInitializeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcCoord => Inner.GetOperand<IdRef>("srcCoord") ?? default;
    public IdRef MotionVectors => Inner.GetOperand<IdRef>("motionVectors") ?? default;
    public IdRef MajorShapes => Inner.GetOperand<IdRef>("majorShapes") ?? default;
    public IdRef MinorShapes => Inner.GetOperand<IdRef>("minorShapes") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;
    public IdRef PixelResolution => Inner.GetOperand<IdRef>("pixelResolution") ?? default;
    public IdRef BidirectionalWeight => Inner.GetOperand<IdRef>("bidirectionalWeight") ?? default;
    public IdRef SadAdjustment => Inner.GetOperand<IdRef>("sadAdjustment") ?? default;

    public InstOpSubgroupAvcBmeInitializeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcRefConvertToMcePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcRefConvertToMcePayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcRefSetBidirectionalMixDisableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcRefSetBidirectionalMixDisableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcRefSetBilinearFilterEnableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcRefSetBilinearFilterEnableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcRefEvaluateWithSingleReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcRefEvaluateWithSingleReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcRefEvaluateWithDualReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcRefEvaluateWithDualReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcRefEvaluateWithMultiReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef PackedReferenceIds => Inner.GetOperand<IdRef>("packedReferenceIds") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcRefEvaluateWithMultiReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef PackedReferenceIds => Inner.GetOperand<IdRef>("packedReferenceIds") ?? default;
    public IdRef PackedReferenceFieldPolarities => Inner.GetOperand<IdRef>("packedReferenceFieldPolarities") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcRefConvertToMceResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcRefConvertToMceResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicInitializeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcCoord => Inner.GetOperand<IdRef>("srcCoord") ?? default;

    public InstOpSubgroupAvcSicInitializeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicConfigureSkcINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SkipBlockPartitionType => Inner.GetOperand<IdRef>("skipBlockPartitionType") ?? default;
    public IdRef SkipMotionVectorMask => Inner.GetOperand<IdRef>("skipMotionVectorMask") ?? default;
    public IdRef MotionVectors => Inner.GetOperand<IdRef>("motionVectors") ?? default;
    public IdRef BidirectionalWeight => Inner.GetOperand<IdRef>("bidirectionalWeight") ?? default;
    public IdRef SadAdjustment => Inner.GetOperand<IdRef>("sadAdjustment") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicConfigureSkcINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicConfigureIpeLumaINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef LumaIntraPartitionMask => Inner.GetOperand<IdRef>("lumaIntraPartitionMask") ?? default;
    public IdRef IntraNeighbourAvailabilty => Inner.GetOperand<IdRef>("intraNeighbourAvailabilty") ?? default;
    public IdRef LeftEdgeLumaPixels => Inner.GetOperand<IdRef>("leftEdgeLumaPixels") ?? default;
    public IdRef UpperLeftCornerLumaPixel => Inner.GetOperand<IdRef>("upperLeftCornerLumaPixel") ?? default;
    public IdRef UpperEdgeLumaPixels => Inner.GetOperand<IdRef>("upperEdgeLumaPixels") ?? default;
    public IdRef UpperRightEdgeLumaPixels => Inner.GetOperand<IdRef>("upperRightEdgeLumaPixels") ?? default;
    public IdRef SadAdjustment => Inner.GetOperand<IdRef>("sadAdjustment") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicConfigureIpeLumaINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicConfigureIpeLumaChromaINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef LumaIntraPartitionMask => Inner.GetOperand<IdRef>("lumaIntraPartitionMask") ?? default;
    public IdRef IntraNeighbourAvailabilty => Inner.GetOperand<IdRef>("intraNeighbourAvailabilty") ?? default;
    public IdRef LeftEdgeLumaPixels => Inner.GetOperand<IdRef>("leftEdgeLumaPixels") ?? default;
    public IdRef UpperLeftCornerLumaPixel => Inner.GetOperand<IdRef>("upperLeftCornerLumaPixel") ?? default;
    public IdRef UpperEdgeLumaPixels => Inner.GetOperand<IdRef>("upperEdgeLumaPixels") ?? default;
    public IdRef UpperRightEdgeLumaPixels => Inner.GetOperand<IdRef>("upperRightEdgeLumaPixels") ?? default;
    public IdRef LeftEdgeChromaPixels => Inner.GetOperand<IdRef>("leftEdgeChromaPixels") ?? default;
    public IdRef UpperLeftCornerChromaPixel => Inner.GetOperand<IdRef>("upperLeftCornerChromaPixel") ?? default;
    public IdRef UpperEdgeChromaPixels => Inner.GetOperand<IdRef>("upperEdgeChromaPixels") ?? default;
    public IdRef SadAdjustment => Inner.GetOperand<IdRef>("sadAdjustment") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicConfigureIpeLumaChromaINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicGetMotionVectorMaskINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SkipBlockPartitionType => Inner.GetOperand<IdRef>("skipBlockPartitionType") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;

    public InstOpSubgroupAvcSicGetMotionVectorMaskINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicConvertToMcePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicConvertToMcePayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedShapePenalty => Inner.GetOperand<IdRef>("packedShapePenalty") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef LumaModePenalty => Inner.GetOperand<IdRef>("lumaModePenalty") ?? default;
    public IdRef LumaPackedNeighborModes => Inner.GetOperand<IdRef>("lumaPackedNeighborModes") ?? default;
    public IdRef LumaPackedNonDcPenalty => Inner.GetOperand<IdRef>("lumaPackedNonDcPenalty") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ChromaModeBasePenalty => Inner.GetOperand<IdRef>("chromaModeBasePenalty") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicSetBilinearFilterEnableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicSetBilinearFilterEnableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicSetSkcForwardTransformEnableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedSadCoefficients => Inner.GetOperand<IdRef>("packedSadCoefficients") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicSetSkcForwardTransformEnableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BlockBasedSkipType => Inner.GetOperand<IdRef>("blockBasedSkipType") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicEvaluateIpeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicEvaluateIpeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicEvaluateWithSingleReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicEvaluateWithSingleReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicEvaluateWithDualReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicEvaluateWithDualReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicEvaluateWithMultiReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef PackedReferenceIds => Inner.GetOperand<IdRef>("packedReferenceIds") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicEvaluateWithMultiReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef PackedReferenceIds => Inner.GetOperand<IdRef>("packedReferenceIds") ?? default;
    public IdRef PackedReferenceFieldPolarities => Inner.GetOperand<IdRef>("packedReferenceFieldPolarities") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicConvertToMceResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicConvertToMceResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicGetIpeLumaShapeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicGetIpeLumaShapeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicGetBestIpeLumaDistortionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicGetBestIpeLumaDistortionINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicGetBestIpeChromaDistortionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicGetBestIpeChromaDistortionINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicGetPackedIpeLumaModesINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicGetPackedIpeLumaModesINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicGetIpeChromaModeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicGetIpeChromaModeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupAvcSicGetInterRawSadsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public InstOpSubgroupAvcSicGetInterRawSadsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpVariableLengthArrayINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Lenght => Inner.GetOperand<IdRef>("lenght") ?? default;

    public InstOpVariableLengthArrayINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSaveMemoryINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public InstOpSaveMemoryINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRestoreMemoryINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Ptr => Inner.GetOperand<IdRef>("ptr") ?? default;

    public InstOpRestoreMemoryINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatSinCosPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger FromSign => Inner.GetOperand<LiteralInteger>("fromSign") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatSinCosPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatCastINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatCastINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatCastFromIntINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger FromSign => Inner.GetOperand<LiteralInteger>("fromSign") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatCastFromIntINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatCastToIntINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatCastToIntINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatAddINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatAddINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatSubINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatSubINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatMulINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatMulINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatDivINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatDivINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatGTINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public InstOpArbitraryFloatGTINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatGEINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public InstOpArbitraryFloatGEINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatLTINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public InstOpArbitraryFloatLTINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatLEINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public InstOpArbitraryFloatLEINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatEQINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public InstOpArbitraryFloatEQINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatRecipINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatRecipINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatRSqrtINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatRSqrtINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatCbrtINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatCbrtINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatHypotINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatHypotINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatSqrtINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatSqrtINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatLogINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatLogINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatLog2INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatLog2INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatLog10INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatLog10INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatLog1pINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatLog1pINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatExpINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatExpINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatExp2INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatExp2INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatExp10INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatExp10INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatExpm1INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatExpm1INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatSinINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatSinINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatCosINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatCosINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatSinCosINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatSinCosINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatSinPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatSinPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatCosPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatCosPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatASinINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatASinINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatASinPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatASinPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatACosINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatACosINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatACosPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatACosPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatATanINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatATanINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatATanPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatATanPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatATan2INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatATan2INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatPowINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatPowINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatPowRINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatPowRINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArbitraryFloatPowNINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatPowNINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpLoopControlINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public InstOpLoopControlINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAliasDomainDeclINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Name => Inner.GetOperand<IdRef>("name") ?? default;

    public InstOpAliasDomainDeclINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAliasScopeDeclINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef AliasDomain => Inner.GetOperand<IdRef>("aliasDomain") ?? default;
    public IdRef Name => Inner.GetOperand<IdRef>("name") ?? default;

    public InstOpAliasScopeDeclINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAliasScopeListDeclINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpAliasScopeListDeclINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFixedSqrtINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedSqrtINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFixedRecipINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedRecipINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFixedRsqrtINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedRsqrtINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFixedSinINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedSinINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFixedCosINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedCosINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFixedSinCosINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedSinCosINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFixedSinPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedSinPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFixedCosPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedCosPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFixedSinCosPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedSinCosPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFixedLogINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedLogINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFixedExpINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedExpINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpPtrCastToCrossWorkgroupINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public InstOpPtrCastToCrossWorkgroupINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCrossWorkgroupCastToPtrINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public InstOpCrossWorkgroupCastToPtrINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpReadPipeBlockingINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public InstOpReadPipeBlockingINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpWritePipeBlockingINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public InstOpWritePipeBlockingINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpFPGARegINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Result => Inner.GetOperand<IdRef>("result") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;

    public InstOpFPGARegINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetRayTMinKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public InstOpRayQueryGetRayTMinKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetRayFlagsKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public InstOpRayQueryGetRayFlagsKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetIntersectionTKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public InstOpRayQueryGetIntersectionTKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetIntersectionInstanceCustomIndexKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public InstOpRayQueryGetIntersectionInstanceCustomIndexKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetIntersectionInstanceIdKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public InstOpRayQueryGetIntersectionInstanceIdKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public InstOpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetIntersectionGeometryIndexKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public InstOpRayQueryGetIntersectionGeometryIndexKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetIntersectionPrimitiveIndexKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public InstOpRayQueryGetIntersectionPrimitiveIndexKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetIntersectionBarycentricsKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public InstOpRayQueryGetIntersectionBarycentricsKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetIntersectionFrontFaceKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public InstOpRayQueryGetIntersectionFrontFaceKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetIntersectionCandidateAABBOpaqueKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public InstOpRayQueryGetIntersectionCandidateAABBOpaqueKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetIntersectionObjectRayDirectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public InstOpRayQueryGetIntersectionObjectRayDirectionKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetIntersectionObjectRayOriginKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public InstOpRayQueryGetIntersectionObjectRayOriginKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetWorldRayDirectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public InstOpRayQueryGetWorldRayDirectionKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetWorldRayOriginKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public InstOpRayQueryGetWorldRayOriginKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetIntersectionObjectToWorldKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public InstOpRayQueryGetIntersectionObjectToWorldKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpRayQueryGetIntersectionWorldToObjectKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public InstOpRayQueryGetIntersectionWorldToObjectKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpAtomicFAddEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstOpAtomicFAddEXT(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeBufferSurfaceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public AccessQualifier AccessQualifier => Inner.GetEnumOperand<AccessQualifier>("accessQualifier");

    public InstOpTypeBufferSurfaceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpTypeStructContinuedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpTypeStructContinuedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConstantCompositeContinuedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpConstantCompositeContinuedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSpecConstantCompositeContinuedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpSpecConstantCompositeContinuedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpCompositeConstructContinuedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpCompositeConstructContinuedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConvertFToBF16INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef FloatValue => Inner.GetOperand<IdRef>("floatValue") ?? default;

    public InstOpConvertFToBF16INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpConvertBF16ToFINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BFloat16Value => Inner.GetOperand<IdRef>("bFloat16Value") ?? default;

    public InstOpConvertBF16ToFINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpControlBarrierArriveINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public InstOpControlBarrierArriveINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpControlBarrierWaitINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public InstOpControlBarrierWaitINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpArithmeticFenceEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;

    public InstOpArithmeticFenceEXT(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpSubgroupBlockPrefetchINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Ptr => Inner.GetOperand<IdRef>("ptr") ?? default;
    public IdRef NumBytes => Inner.GetOperand<IdRef>("numBytes") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");

    public InstOpSubgroupBlockPrefetchINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupIMulKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupIMulKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupFMulKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupFMulKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupBitwiseAndKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupBitwiseAndKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupBitwiseOrKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupBitwiseOrKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupBitwiseXorKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupBitwiseXorKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupLogicalAndKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupLogicalAndKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupLogicalOrKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupLogicalOrKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpGroupLogicalXorKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstOpGroupLogicalXorKHR(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpMaskedGatherINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PtrVector => Inner.GetOperand<IdRef>("ptrVector") ?? default;
    public LiteralInteger Alignment => Inner.GetOperand<LiteralInteger>("alignment") ?? default;
    public IdRef Mask => Inner.GetOperand<IdRef>("mask") ?? default;
    public IdRef FillEmpty => Inner.GetOperand<IdRef>("fillEmpty") ?? default;

    public InstOpMaskedGatherINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstOpMaskedScatterINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef InputVector => Inner.GetOperand<IdRef>("inputVector") ?? default;
    public IdRef PtrVector => Inner.GetOperand<IdRef>("ptrVector") ?? default;
    public LiteralInteger Alignment => Inner.GetOperand<LiteralInteger>("alignment") ?? default;
    public IdRef Mask => Inner.GetOperand<IdRef>("mask") ?? default;

    public InstOpMaskedScatterINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLRound : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLRound(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLRoundEven : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLRoundEven(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLTrunc : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLTrunc(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLFAbs : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLFAbs(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLSAbs : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLSAbs(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLFSign : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLFSign(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLSSign : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLSSign(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLFloor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLFloor(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLCeil : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLCeil(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLFract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLFract(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLRadians : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Degrees => Inner.GetOperand<IdRef>("degrees") ?? default;

    public InstGLSLRadians(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLDegrees : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Radians => Inner.GetOperand<IdRef>("radians") ?? default;

    public InstGLSLDegrees(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLSin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLSin(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLCos : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLCos(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLTan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLTan(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLAsin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLAsin(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLAcos : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLAcos(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLAtan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Y_over_x => Inner.GetOperand<IdRef>("y_over_x") ?? default;

    public InstGLSLAtan(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLSinh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLSinh(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLCosh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLCosh(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLTanh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLTanh(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLAsinh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLAsinh(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLAcosh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLAcosh(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLAtanh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLAtanh(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLAtan2 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLAtan2(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLPow : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public InstGLSLPow(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLExp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLExp(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLLog : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLLog(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLExp2 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLExp2(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLLog2 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLLog2(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLSqrt : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLSqrt(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLInverseSqrt : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLInverseSqrt(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLDeterminant : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLDeterminant(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLMatrixInverse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLMatrixInverse(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLModf : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef I => Inner.GetOperand<IdRef>("i") ?? default;

    public InstGLSLModf(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLModfStruct : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLModfStruct(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLFMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public InstGLSLFMin(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLUMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public InstGLSLUMin(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLSMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public InstGLSLSMin(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLFMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public InstGLSLFMax(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLUMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public InstGLSLUMax(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLSMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public InstGLSLSMax(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLFClamp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef MinVal => Inner.GetOperand<IdRef>("minVal") ?? default;
    public IdRef MaxVal => Inner.GetOperand<IdRef>("maxVal") ?? default;

    public InstGLSLFClamp(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLUClamp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef MinVal => Inner.GetOperand<IdRef>("minVal") ?? default;
    public IdRef MaxVal => Inner.GetOperand<IdRef>("maxVal") ?? default;

    public InstGLSLUClamp(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLSClamp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef MinVal => Inner.GetOperand<IdRef>("minVal") ?? default;
    public IdRef MaxVal => Inner.GetOperand<IdRef>("maxVal") ?? default;

    public InstGLSLSClamp(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLFMix : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;

    public InstGLSLFMix(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLIMix : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;

    public InstGLSLIMix(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLStep : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Edge => Inner.GetOperand<IdRef>("edge") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLStep(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLSmoothStep : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Edge0 => Inner.GetOperand<IdRef>("edge0") ?? default;
    public IdRef Edge1 => Inner.GetOperand<IdRef>("edge1") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLSmoothStep(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLFma : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public IdRef C => Inner.GetOperand<IdRef>("c") ?? default;

    public InstGLSLFma(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLFrexp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Exp => Inner.GetOperand<IdRef>("exp") ?? default;

    public InstGLSLFrexp(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLFrexpStruct : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLFrexpStruct(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLLdexp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Exp => Inner.GetOperand<IdRef>("exp") ?? default;

    public InstGLSLLdexp(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLPackSnorm4x8 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public InstGLSLPackSnorm4x8(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLPackUnorm4x8 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public InstGLSLPackUnorm4x8(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLPackSnorm2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public InstGLSLPackSnorm2x16(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLPackUnorm2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public InstGLSLPackUnorm2x16(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLPackHalf2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public InstGLSLPackHalf2x16(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLPackDouble2x32 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public InstGLSLPackDouble2x32(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLUnpackSnorm2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public InstGLSLUnpackSnorm2x16(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLUnpackUnorm2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public InstGLSLUnpackUnorm2x16(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLUnpackHalf2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public InstGLSLUnpackHalf2x16(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLUnpackSnorm4x8 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public InstGLSLUnpackSnorm4x8(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLUnpackUnorm4x8 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public InstGLSLUnpackUnorm4x8(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLUnpackDouble2x32 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public InstGLSLUnpackDouble2x32(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLLength : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLLength(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLDistance : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef P0 => Inner.GetOperand<IdRef>("p0") ?? default;
    public IdRef P1 => Inner.GetOperand<IdRef>("p1") ?? default;

    public InstGLSLDistance(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLCross : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public InstGLSLCross(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLNormalize : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public InstGLSLNormalize(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLFaceForward : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef N => Inner.GetOperand<IdRef>("n") ?? default;
    public IdRef I => Inner.GetOperand<IdRef>("i") ?? default;
    public IdRef Nref => Inner.GetOperand<IdRef>("nref") ?? default;

    public InstGLSLFaceForward(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLReflect : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef I => Inner.GetOperand<IdRef>("i") ?? default;
    public IdRef N => Inner.GetOperand<IdRef>("n") ?? default;

    public InstGLSLReflect(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLRefract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef I => Inner.GetOperand<IdRef>("i") ?? default;
    public IdRef N => Inner.GetOperand<IdRef>("n") ?? default;
    public IdRef Eta => Inner.GetOperand<IdRef>("eta") ?? default;

    public InstGLSLRefract(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLFindILsb : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstGLSLFindILsb(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLFindSMsb : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstGLSLFindSMsb(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLFindUMsb : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public InstGLSLFindUMsb(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLInterpolateAtCentroid : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Interpolant => Inner.GetOperand<IdRef>("interpolant") ?? default;

    public InstGLSLInterpolateAtCentroid(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLInterpolateAtSample : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Interpolant => Inner.GetOperand<IdRef>("interpolant") ?? default;
    public IdRef Sample => Inner.GetOperand<IdRef>("sample") ?? default;

    public InstGLSLInterpolateAtSample(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLInterpolateAtOffset : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Interpolant => Inner.GetOperand<IdRef>("interpolant") ?? default;
    public IdRef Offset => Inner.GetOperand<IdRef>("offset") ?? default;

    public InstGLSLInterpolateAtOffset(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLNMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public InstGLSLNMin(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLNMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public InstGLSLNMax(Instruction instruction) => Inner = instruction;
}

public ref struct InstGLSLNClamp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef MinVal => Inner.GetOperand<IdRef>("minVal") ?? default;
    public IdRef MaxVal => Inner.GetOperand<IdRef>("maxVal") ?? default;

    public InstGLSLNClamp(Instruction instruction) => Inner = instruction;
}