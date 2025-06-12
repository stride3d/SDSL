using static Spv.Specification;

namespace Stride.Shaders.Spirv.Core;
public ref struct RefOpSDSLDecorateSemantic : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public LiteralString Semantic => Inner.GetOperand<LiteralString>("semantic") ?? default;

    public RefOpSDSLDecorateSemantic(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSDSLShader : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString ShaderName => Inner.GetOperand<LiteralString>("shaderName") ?? default;

    public RefOpSDSLShader(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSDSLShaderEnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public RefOpSDSLShaderEnd(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSDSLMixinInherit : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Shader => Inner.GetOperand<IdRef>("shader") ?? default;

    public RefOpSDSLMixinInherit(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSDSLCompose : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString Mixin => Inner.GetOperand<LiteralString>("mixin") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public RefOpSDSLCompose(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSDSLStage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef StagedElement => Inner.GetOperand<IdRef>("stagedElement") ?? default;

    public RefOpSDSLStage(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSDSLImportShader : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString ShaderName => Inner.GetOperand<LiteralString>("shaderName") ?? default;

    public RefOpSDSLImportShader(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSDSLImportFunction : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString FunctionName => Inner.GetOperand<LiteralString>("functionName") ?? default;
    public IdRef Shader => Inner.GetOperand<IdRef>("shader") ?? default;

    public RefOpSDSLImportFunction(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSDSLImportVariable : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString VariableName => Inner.GetOperand<LiteralString>("variableName") ?? default;
    public IdRef Shader => Inner.GetOperand<IdRef>("shader") ?? default;

    public RefOpSDSLImportVariable(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSDSLMixinVariable : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef MixinId => Inner.GetOperand<IdRef>("mixinId") ?? default;
    public IdRef VariableId => Inner.GetOperand<IdRef>("variableId") ?? default;

    public RefOpSDSLMixinVariable(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSDSLVariable : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;
    public IdRef Initializer => Inner.GetOperand<IdRef>("initializer") ?? default;

    public RefOpSDSLVariable(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSDSLFunctionParameter : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public RefOpSDSLFunctionParameter(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSDSLIOVariable : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");
    public ExecutionModel Executionmodel => Inner.GetEnumOperand<ExecutionModel>("executionmodel");
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;
    public LiteralString Semantic => Inner.GetOperand<LiteralString>("semantic") ?? default;
    public IdRef Initializer => Inner.GetOperand<IdRef>("initializer") ?? default;

    public RefOpSDSLIOVariable(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSDSLFunction : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public FunctionControlMask Functioncontrol => Inner.GetEnumOperand<FunctionControlMask>("functioncontrol");
    public IdRef FunctionType => Inner.GetOperand<IdRef>("functionType") ?? default;
    public LiteralString FunctionName => Inner.GetOperand<LiteralString>("functionName") ?? default;

    public RefOpSDSLFunction(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpNop : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public RefOpNop(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUndef : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpUndef(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSourceContinued : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString ContinuedSource => Inner.GetOperand<LiteralString>("continuedSource") ?? default;

    public RefOpSourceContinued(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSource : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public SourceLanguage Sourcelanguage => Inner.GetEnumOperand<SourceLanguage>("sourcelanguage");
    public LiteralInteger Version => Inner.GetOperand<LiteralInteger>("version") ?? default;
    public IdRef File => Inner.GetOperand<IdRef>("file") ?? default;
    public LiteralString Source => Inner.GetOperand<LiteralString>("source") ?? default;

    public RefOpSource(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSourceExtension : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString Extension => Inner.GetOperand<LiteralString>("extension") ?? default;

    public RefOpSourceExtension(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpName : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public RefOpName(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpMemberName : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Type => Inner.GetOperand<IdRef>("type") ?? default;
    public LiteralInteger Member => Inner.GetOperand<LiteralInteger>("member") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public RefOpMemberName(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpString : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString Value => Inner.GetOperand<LiteralString>("value") ?? default;

    public RefOpString(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpLine : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef File => Inner.GetOperand<IdRef>("file") ?? default;
    public LiteralInteger Line => Inner.GetOperand<LiteralInteger>("line") ?? default;
    public LiteralInteger Column => Inner.GetOperand<LiteralInteger>("column") ?? default;

    public RefOpLine(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpExtension : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public RefOpExtension(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpExtInstImport : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public RefOpExtInstImport(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpExtInst : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Set => Inner.GetOperand<IdRef>("set") ?? default;
    public LiteralInteger Instruction => Inner.GetOperand<LiteralInteger>("instruction") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpExtInst(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpMemoryModel : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public AddressingModel Addressingmodel => Inner.GetEnumOperand<AddressingModel>("addressingmodel");
    public MemoryModel Memorymodel => Inner.GetEnumOperand<MemoryModel>("memorymodel");

    public RefOpMemoryModel(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpEntryPoint : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public ExecutionModel Executionmodel => Inner.GetEnumOperand<ExecutionModel>("executionmodel");
    public IdRef EntryPoint => Inner.GetOperand<IdRef>("entryPoint") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpEntryPoint(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpExecutionMode : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EntryPoint => Inner.GetOperand<IdRef>("entryPoint") ?? default;
    public ExecutionMode Mode => Inner.GetEnumOperand<ExecutionMode>("mode");

    public RefOpExecutionMode(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCapability : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public Capability Capability => Inner.GetEnumOperand<Capability>("capability");

    public RefOpCapability(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeVoid : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeVoid(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeBool : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeBool(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeInt : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralInteger Width => Inner.GetOperand<LiteralInteger>("width") ?? default;
    public LiteralInteger Signedness => Inner.GetOperand<LiteralInteger>("signedness") ?? default;

    public RefOpTypeInt(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeFloat : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralInteger Width => Inner.GetOperand<LiteralInteger>("width") ?? default;
    public FPEncoding FloatingPointEncoding => Inner.GetEnumOperand<FPEncoding>("floatingPointEncoding");

    public RefOpTypeFloat(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeVector : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ComponentType => Inner.GetOperand<IdRef>("componentType") ?? default;
    public LiteralInteger ComponentCount => Inner.GetOperand<LiteralInteger>("componentCount") ?? default;

    public RefOpTypeVector(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeMatrix : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ColumnType => Inner.GetOperand<IdRef>("columnType") ?? default;
    public LiteralInteger ColumnCount => Inner.GetOperand<LiteralInteger>("columnCount") ?? default;

    public RefOpTypeMatrix(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeImage : IWrapperInstruction
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

    public RefOpTypeImage(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeSampler : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeSampler(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeSampledImage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ImageType => Inner.GetOperand<IdRef>("imageType") ?? default;

    public RefOpTypeSampledImage(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeArray : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ElementType => Inner.GetOperand<IdRef>("elementType") ?? default;
    public IdRef Length => Inner.GetOperand<IdRef>("length") ?? default;

    public RefOpTypeArray(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeRuntimeArray : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ElementType => Inner.GetOperand<IdRef>("elementType") ?? default;

    public RefOpTypeRuntimeArray(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeStruct : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTypeStruct(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeOpaque : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString Thenameoftheopaquetype => Inner.GetOperand<LiteralString>("thenameoftheopaquetype") ?? default;

    public RefOpTypeOpaque(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypePointer : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");
    public IdRef Type => Inner.GetOperand<IdRef>("type") ?? default;

    public RefOpTypePointer(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeFunction : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ReturnType => Inner.GetOperand<IdRef>("returnType") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTypeFunction(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeEvent(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeDeviceEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeDeviceEvent(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeReserveId : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeReserveId(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeQueue : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeQueue(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypePipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public AccessQualifier Qualifier => Inner.GetEnumOperand<AccessQualifier>("qualifier");

    public RefOpTypePipe(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeForwardPointer : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef PointerType => Inner.GetOperand<IdRef>("pointerType") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");

    public RefOpTypeForwardPointer(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConstantTrue : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpConstantTrue(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConstantFalse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpConstantFalse(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConstant : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpConstant(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConstantComposite : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpConstantComposite(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConstantSampler : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public SamplerAddressingMode Sampleraddressingmode => Inner.GetEnumOperand<SamplerAddressingMode>("sampleraddressingmode");
    public LiteralInteger Param => Inner.GetOperand<LiteralInteger>("param") ?? default;
    public SamplerFilterMode Samplerfiltermode => Inner.GetEnumOperand<SamplerFilterMode>("samplerfiltermode");

    public RefOpConstantSampler(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConstantNull : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpConstantNull(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSpecConstantTrue : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSpecConstantTrue(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSpecConstantFalse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSpecConstantFalse(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSpecConstant : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSpecConstant(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSpecConstantComposite : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpSpecConstantComposite(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSpecConstantOp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralInteger Opcode => Inner.GetOperand<LiteralInteger>("opcode") ?? default;

    public RefOpSpecConstantOp(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFunction : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public FunctionControlMask Functioncontrol => Inner.GetEnumOperand<FunctionControlMask>("functioncontrol");
    public IdRef FunctionType => Inner.GetOperand<IdRef>("functionType") ?? default;

    public RefOpFunction(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFunctionParameter : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpFunctionParameter(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFunctionEnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public RefOpFunctionEnd(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFunctionCall : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Function => Inner.GetOperand<IdRef>("function") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpFunctionCall(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpVariable : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");
    public IdRef Initializer => Inner.GetOperand<IdRef>("initializer") ?? default;

    public RefOpVariable(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageTexelPointer : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Sample => Inner.GetOperand<IdRef>("sample") ?? default;

    public RefOpImageTexelPointer(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpLoad : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");

    public RefOpLoad(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpStore : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");

    public RefOpStore(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCopyMemory : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public IdRef Source => Inner.GetOperand<IdRef>("source") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");
    public MemoryAccessMask Memoryaccess1 => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess1");

    public RefOpCopyMemory(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCopyMemorySized : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public IdRef Source => Inner.GetOperand<IdRef>("source") ?? default;
    public IdRef Size => Inner.GetOperand<IdRef>("size") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");
    public MemoryAccessMask Memoryaccess1 => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess1");

    public RefOpCopyMemorySized(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAccessChain : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpAccessChain(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpInBoundsAccessChain : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpInBoundsAccessChain(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpPtrAccessChain : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Element => Inner.GetOperand<IdRef>("element") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpPtrAccessChain(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArrayLength : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Structure => Inner.GetOperand<IdRef>("structure") ?? default;
    public LiteralInteger Arraymember => Inner.GetOperand<LiteralInteger>("arraymember") ?? default;

    public RefOpArrayLength(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGenericPtrMemSemantics : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public RefOpGenericPtrMemSemantics(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpInBoundsPtrAccessChain : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Element => Inner.GetOperand<IdRef>("element") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpInBoundsPtrAccessChain(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpDecorate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public Decoration Decoration => Inner.GetEnumOperand<Decoration>("decoration");

    public RefOpDecorate(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpMemberDecorate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef StructureType => Inner.GetOperand<IdRef>("structureType") ?? default;
    public LiteralInteger Member => Inner.GetOperand<LiteralInteger>("member") ?? default;
    public Decoration Decoration => Inner.GetEnumOperand<Decoration>("decoration");

    public RefOpMemberDecorate(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpDecorationGroup : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpDecorationGroup(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupDecorate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef DecorationGroup => Inner.GetOperand<IdRef>("decorationGroup") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpGroupDecorate(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupMemberDecorate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef DecorationGroup => Inner.GetOperand<IdRef>("decorationGroup") ?? default;
    public PairIdRefLiteralInteger Values => Inner.GetOperand<PairIdRefLiteralInteger>("values") ?? default;

    public RefOpGroupMemberDecorate(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpVectorExtractDynamic : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;

    public RefOpVectorExtractDynamic(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpVectorInsertDynamic : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;
    public IdRef Component => Inner.GetOperand<IdRef>("component") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;

    public RefOpVectorInsertDynamic(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpVectorShuffle : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public RefOpVectorShuffle(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCompositeConstruct : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpCompositeConstruct(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCompositeExtract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Composite => Inner.GetOperand<IdRef>("composite") ?? default;
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public RefOpCompositeExtract(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCompositeInsert : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public IdRef Composite => Inner.GetOperand<IdRef>("composite") ?? default;
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public RefOpCompositeInsert(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCopyObject : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpCopyObject(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTranspose : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;

    public RefOpTranspose(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSampledImage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Sampler => Inner.GetOperand<IdRef>("sampler") ?? default;

    public RefOpSampledImage(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSampleImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleImplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSampleExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleExplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSampleDrefImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleDrefImplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSampleDrefExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleDrefExplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSampleProjImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleProjImplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSampleProjExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleProjExplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSampleProjDrefImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleProjDrefImplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSampleProjDrefExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleProjDrefExplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageFetch : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageFetch(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageGather : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Component => Inner.GetOperand<IdRef>("component") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageGather(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageDrefGather : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageDrefGather(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageRead : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageRead(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageWrite : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Texel => Inner.GetOperand<IdRef>("texel") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageWrite(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;

    public RefOpImage(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageQueryFormat : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;

    public RefOpImageQueryFormat(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageQueryOrder : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;

    public RefOpImageQueryOrder(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageQuerySizeLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef LevelofDetail => Inner.GetOperand<IdRef>("levelofDetail") ?? default;

    public RefOpImageQuerySizeLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageQuerySize : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;

    public RefOpImageQuerySize(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageQueryLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;

    public RefOpImageQueryLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageQueryLevels : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;

    public RefOpImageQueryLevels(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageQuerySamples : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;

    public RefOpImageQuerySamples(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConvertFToU : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef FloatValue => Inner.GetOperand<IdRef>("floatValue") ?? default;

    public RefOpConvertFToU(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConvertFToS : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef FloatValue => Inner.GetOperand<IdRef>("floatValue") ?? default;

    public RefOpConvertFToS(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConvertSToF : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SignedValue => Inner.GetOperand<IdRef>("signedValue") ?? default;

    public RefOpConvertSToF(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConvertUToF : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef UnsignedValue => Inner.GetOperand<IdRef>("unsignedValue") ?? default;

    public RefOpConvertUToF(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUConvert : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef UnsignedValue => Inner.GetOperand<IdRef>("unsignedValue") ?? default;

    public RefOpUConvert(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSConvert : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SignedValue => Inner.GetOperand<IdRef>("signedValue") ?? default;

    public RefOpSConvert(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFConvert : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef FloatValue => Inner.GetOperand<IdRef>("floatValue") ?? default;

    public RefOpFConvert(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpQuantizeToF16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpQuantizeToF16(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConvertPtrToU : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public RefOpConvertPtrToU(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSatConvertSToU : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SignedValue => Inner.GetOperand<IdRef>("signedValue") ?? default;

    public RefOpSatConvertSToU(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSatConvertUToS : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef UnsignedValue => Inner.GetOperand<IdRef>("unsignedValue") ?? default;

    public RefOpSatConvertUToS(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConvertUToPtr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef IntegerValue => Inner.GetOperand<IdRef>("integerValue") ?? default;

    public RefOpConvertUToPtr(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpPtrCastToGeneric : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public RefOpPtrCastToGeneric(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGenericCastToPtr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public RefOpGenericCastToPtr(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGenericCastToPtrExplicit : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public StorageClass Storage => Inner.GetEnumOperand<StorageClass>("storage");

    public RefOpGenericCastToPtrExplicit(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpBitcast : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpBitcast(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSNegate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpSNegate(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFNegate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpFNegate(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpIAdd(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFAdd(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpISub : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpISub(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFSub : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFSub(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIMul : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpIMul(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFMul : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFMul(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUDiv : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUDiv(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSDiv : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpSDiv(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFDiv : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFDiv(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUMod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUMod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSRem : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpSRem(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSMod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpSMod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFRem : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFRem(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFMod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFMod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpVectorTimesScalar : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;
    public IdRef Scalar => Inner.GetOperand<IdRef>("scalar") ?? default;

    public RefOpVectorTimesScalar(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpMatrixTimesScalar : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;
    public IdRef Scalar => Inner.GetOperand<IdRef>("scalar") ?? default;

    public RefOpMatrixTimesScalar(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpVectorTimesMatrix : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;

    public RefOpVectorTimesMatrix(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpMatrixTimesVector : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;

    public RefOpMatrixTimesVector(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpMatrixTimesMatrix : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef LeftMatrix => Inner.GetOperand<IdRef>("leftMatrix") ?? default;
    public IdRef RightMatrix => Inner.GetOperand<IdRef>("rightMatrix") ?? default;

    public RefOpMatrixTimesMatrix(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpOuterProduct : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;

    public RefOpOuterProduct(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpDot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;

    public RefOpDot(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIAddCarry : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpIAddCarry(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpISubBorrow : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpISubBorrow(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUMulExtended : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUMulExtended(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSMulExtended : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpSMulExtended(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAny : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;

    public RefOpAny(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAll : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;

    public RefOpAll(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIsNan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpIsNan(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIsInf : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpIsInf(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIsFinite : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpIsFinite(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIsNormal : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpIsNormal(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSignBitSet : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpSignBitSet(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpLessOrGreater : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefOpLessOrGreater(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpOrdered : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefOpOrdered(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUnordered : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefOpUnordered(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpLogicalEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpLogicalEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpLogicalNotEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpLogicalNotEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpLogicalOr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpLogicalOr(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpLogicalAnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpLogicalAnd(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpLogicalNot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpLogicalNot(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSelect : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Condition => Inner.GetOperand<IdRef>("condition") ?? default;
    public IdRef Object1 => Inner.GetOperand<IdRef>("object1") ?? default;
    public IdRef Object2 => Inner.GetOperand<IdRef>("object2") ?? default;

    public RefOpSelect(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpIEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpINotEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpINotEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUGreaterThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUGreaterThan(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSGreaterThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpSGreaterThan(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUGreaterThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUGreaterThanEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSGreaterThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpSGreaterThanEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpULessThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpULessThan(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSLessThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpSLessThan(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpULessThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpULessThanEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSLessThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpSLessThanEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFOrdEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFOrdEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFUnordEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFUnordEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFOrdNotEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFOrdNotEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFUnordNotEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFUnordNotEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFOrdLessThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFOrdLessThan(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFUnordLessThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFUnordLessThan(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFOrdGreaterThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFOrdGreaterThan(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFUnordGreaterThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFUnordGreaterThan(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFOrdLessThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFOrdLessThanEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFUnordLessThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFUnordLessThanEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFOrdGreaterThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFOrdGreaterThanEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFUnordGreaterThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFUnordGreaterThanEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpShiftRightLogical : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Shift => Inner.GetOperand<IdRef>("shift") ?? default;

    public RefOpShiftRightLogical(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpShiftRightArithmetic : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Shift => Inner.GetOperand<IdRef>("shift") ?? default;

    public RefOpShiftRightArithmetic(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpShiftLeftLogical : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Shift => Inner.GetOperand<IdRef>("shift") ?? default;

    public RefOpShiftLeftLogical(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpBitwiseOr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpBitwiseOr(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpBitwiseXor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpBitwiseXor(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpBitwiseAnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpBitwiseAnd(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpNot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpNot(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpBitFieldInsert : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Insert => Inner.GetOperand<IdRef>("insert") ?? default;
    public IdRef Offset => Inner.GetOperand<IdRef>("offset") ?? default;
    public IdRef Count => Inner.GetOperand<IdRef>("count") ?? default;

    public RefOpBitFieldInsert(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpBitFieldSExtract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Offset => Inner.GetOperand<IdRef>("offset") ?? default;
    public IdRef Count => Inner.GetOperand<IdRef>("count") ?? default;

    public RefOpBitFieldSExtract(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpBitFieldUExtract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Offset => Inner.GetOperand<IdRef>("offset") ?? default;
    public IdRef Count => Inner.GetOperand<IdRef>("count") ?? default;

    public RefOpBitFieldUExtract(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpBitReverse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;

    public RefOpBitReverse(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpBitCount : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;

    public RefOpBitCount(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpDPdx : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpDPdx(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpDPdy : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpDPdy(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFwidth : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpFwidth(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpDPdxFine : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpDPdxFine(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpDPdyFine : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpDPdyFine(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFwidthFine : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpFwidthFine(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpDPdxCoarse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpDPdxCoarse(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpDPdyCoarse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpDPdyCoarse(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFwidthCoarse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpFwidthCoarse(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpEmitVertex : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public RefOpEmitVertex(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpEndPrimitive : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public RefOpEndPrimitive(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpEmitStreamVertex : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Stream => Inner.GetOperand<IdRef>("stream") ?? default;

    public RefOpEmitStreamVertex(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpEndStreamPrimitive : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Stream => Inner.GetOperand<IdRef>("stream") ?? default;

    public RefOpEndStreamPrimitive(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpControlBarrier : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpControlBarrier(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpMemoryBarrier : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpMemoryBarrier(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicLoad : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpAtomicLoad(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicStore : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicStore(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicExchange : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicExchange(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicCompareExchange : IWrapperInstruction
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

    public RefOpAtomicCompareExchange(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicCompareExchangeWeak : IWrapperInstruction
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

    public RefOpAtomicCompareExchangeWeak(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicIIncrement : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpAtomicIIncrement(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicIDecrement : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpAtomicIDecrement(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicIAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicIAdd(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicISub : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicISub(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicSMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicSMin(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicUMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicUMin(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicSMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicSMax(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicUMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicUMax(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicAnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicAnd(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicOr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicOr(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicXor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicXor(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpPhi : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public PairIdRefIdRef Values => Inner.GetOperand<PairIdRefIdRef>("values") ?? default;

    public RefOpPhi(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpLoopMerge : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef MergeBlock => Inner.GetOperand<IdRef>("mergeBlock") ?? default;
    public IdRef ContinueTarget => Inner.GetOperand<IdRef>("continueTarget") ?? default;
    public LoopControlMask Loopcontrol => Inner.GetEnumOperand<LoopControlMask>("loopcontrol");

    public RefOpLoopMerge(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSelectionMerge : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef MergeBlock => Inner.GetOperand<IdRef>("mergeBlock") ?? default;
    public SelectionControlMask Selectioncontrol => Inner.GetEnumOperand<SelectionControlMask>("selectioncontrol");

    public RefOpSelectionMerge(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpLabel : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpLabel(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpBranch : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef TargetLabel => Inner.GetOperand<IdRef>("targetLabel") ?? default;

    public RefOpBranch(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpBranchConditional : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Condition => Inner.GetOperand<IdRef>("condition") ?? default;
    public IdRef TrueLabel => Inner.GetOperand<IdRef>("trueLabel") ?? default;
    public IdRef FalseLabel => Inner.GetOperand<IdRef>("falseLabel") ?? default;
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public RefOpBranchConditional(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSwitch : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Selector => Inner.GetOperand<IdRef>("selector") ?? default;
    public IdRef DefaultId => Inner.GetOperand<IdRef>("defaultId") ?? default;
    public PairLiteralIntegerIdRef Values => Inner.GetOperand<PairLiteralIntegerIdRef>("values") ?? default;

    public RefOpSwitch(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpKill : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public RefOpKill(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpReturn : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public RefOpReturn(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpReturnValue : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpReturnValue(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUnreachable : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public RefOpUnreachable(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpLifetimeStart : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public LiteralInteger Size => Inner.GetOperand<LiteralInteger>("size") ?? default;

    public RefOpLifetimeStart(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpLifetimeStop : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public LiteralInteger Size => Inner.GetOperand<LiteralInteger>("size") ?? default;

    public RefOpLifetimeStop(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupAsyncCopy : IWrapperInstruction
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

    public RefOpGroupAsyncCopy(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupWaitEvents : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef NumEvents => Inner.GetOperand<IdRef>("numEvents") ?? default;
    public IdRef EventsList => Inner.GetOperand<IdRef>("eventsList") ?? default;

    public RefOpGroupWaitEvents(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupAll : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpGroupAll(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupAny : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpGroupAny(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupBroadcast : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef LocalId => Inner.GetOperand<IdRef>("localId") ?? default;

    public RefOpGroupBroadcast(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupIAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupIAdd(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupFAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupFAdd(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupFMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupFMin(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupUMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupUMin(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupSMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupSMin(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupFMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupFMax(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupUMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupUMax(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupSMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupSMax(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpReadPipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpReadPipe(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpWritePipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpWritePipe(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpReservedReadPipe : IWrapperInstruction
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

    public RefOpReservedReadPipe(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpReservedWritePipe : IWrapperInstruction
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

    public RefOpReservedWritePipe(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpReserveReadPipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef NumPackets => Inner.GetOperand<IdRef>("numPackets") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpReserveReadPipePackets(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpReserveWritePipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef NumPackets => Inner.GetOperand<IdRef>("numPackets") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpReserveWritePipePackets(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCommitReadPipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpCommitReadPipe(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCommitWritePipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpCommitWritePipe(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIsValidReserveId : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;

    public RefOpIsValidReserveId(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGetNumPipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpGetNumPipePackets(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGetMaxPipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpGetMaxPipePackets(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupReserveReadPipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef NumPackets => Inner.GetOperand<IdRef>("numPackets") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpGroupReserveReadPipePackets(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupReserveWritePipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef NumPackets => Inner.GetOperand<IdRef>("numPackets") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpGroupReserveWritePipePackets(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupCommitReadPipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpGroupCommitReadPipe(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupCommitWritePipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpGroupCommitWritePipe(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpEnqueueMarker : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Queue => Inner.GetOperand<IdRef>("queue") ?? default;
    public IdRef NumEvents => Inner.GetOperand<IdRef>("numEvents") ?? default;
    public IdRef WaitEvents => Inner.GetOperand<IdRef>("waitEvents") ?? default;
    public IdRef RetEvent => Inner.GetOperand<IdRef>("retEvent") ?? default;

    public RefOpEnqueueMarker(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpEnqueueKernel : IWrapperInstruction
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

    public RefOpEnqueueKernel(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGetKernelNDrangeSubGroupCount : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef NDRange => Inner.GetOperand<IdRef>("nDRange") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public RefOpGetKernelNDrangeSubGroupCount(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGetKernelNDrangeMaxSubGroupSize : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef NDRange => Inner.GetOperand<IdRef>("nDRange") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public RefOpGetKernelNDrangeMaxSubGroupSize(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGetKernelWorkGroupSize : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public RefOpGetKernelWorkGroupSize(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGetKernelPreferredWorkGroupSizeMultiple : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public RefOpGetKernelPreferredWorkGroupSizeMultiple(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRetainEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EventId => Inner.GetOperand<IdRef>("eventId") ?? default;

    public RefOpRetainEvent(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpReleaseEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EventId => Inner.GetOperand<IdRef>("eventId") ?? default;

    public RefOpReleaseEvent(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCreateUserEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpCreateUserEvent(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIsValidEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef EventId => Inner.GetOperand<IdRef>("eventId") ?? default;

    public RefOpIsValidEvent(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSetUserEventStatus : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EventId => Inner.GetOperand<IdRef>("eventId") ?? default;
    public IdRef Status => Inner.GetOperand<IdRef>("status") ?? default;

    public RefOpSetUserEventStatus(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCaptureEventProfilingInfo : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EventId => Inner.GetOperand<IdRef>("eventId") ?? default;
    public IdRef ProfilingInfo => Inner.GetOperand<IdRef>("profilingInfo") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpCaptureEventProfilingInfo(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGetDefaultQueue : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpGetDefaultQueue(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpBuildNDRange : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef GlobalWorkSize => Inner.GetOperand<IdRef>("globalWorkSize") ?? default;
    public IdRef LocalWorkSize => Inner.GetOperand<IdRef>("localWorkSize") ?? default;
    public IdRef GlobalWorkOffset => Inner.GetOperand<IdRef>("globalWorkOffset") ?? default;

    public RefOpBuildNDRange(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSparseSampleImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseSampleImplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSparseSampleExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseSampleExplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSparseSampleDrefImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseSampleDrefImplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSparseSampleDrefExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseSampleDrefExplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSparseSampleProjImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseSampleProjImplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSparseSampleProjExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseSampleProjExplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSparseSampleProjDrefImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseSampleProjDrefImplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSparseSampleProjDrefExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseSampleProjDrefExplicitLod(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSparseFetch : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseFetch(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSparseGather : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Component => Inner.GetOperand<IdRef>("component") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseGather(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSparseDrefGather : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseDrefGather(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSparseTexelsResident : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ResidentCode => Inner.GetOperand<IdRef>("residentCode") ?? default;

    public RefOpImageSparseTexelsResident(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpNoLine : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public RefOpNoLine(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicFlagTestAndSet : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpAtomicFlagTestAndSet(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicFlagClear : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpAtomicFlagClear(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSparseRead : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseRead(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSizeOf : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public RefOpSizeOf(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypePipeStorage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypePipeStorage(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConstantPipeStorage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralInteger PacketSize => Inner.GetOperand<LiteralInteger>("packetSize") ?? default;
    public LiteralInteger PacketAlignment => Inner.GetOperand<LiteralInteger>("packetAlignment") ?? default;
    public LiteralInteger Capacity => Inner.GetOperand<LiteralInteger>("capacity") ?? default;

    public RefOpConstantPipeStorage(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCreatePipeFromPipeStorage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PipeStorage => Inner.GetOperand<IdRef>("pipeStorage") ?? default;

    public RefOpCreatePipeFromPipeStorage(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGetKernelLocalSizeForSubgroupCount : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SubgroupCount => Inner.GetOperand<IdRef>("subgroupCount") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public RefOpGetKernelLocalSizeForSubgroupCount(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGetKernelMaxNumSubgroups : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public RefOpGetKernelMaxNumSubgroups(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeNamedBarrier : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeNamedBarrier(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpNamedBarrierInitialize : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SubgroupCount => Inner.GetOperand<IdRef>("subgroupCount") ?? default;

    public RefOpNamedBarrierInitialize(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpMemoryNamedBarrier : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef NamedBarrier => Inner.GetOperand<IdRef>("namedBarrier") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpMemoryNamedBarrier(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpModuleProcessed : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString Process => Inner.GetOperand<LiteralString>("process") ?? default;

    public RefOpModuleProcessed(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpExecutionModeId : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EntryPoint => Inner.GetOperand<IdRef>("entryPoint") ?? default;
    public ExecutionMode Mode => Inner.GetEnumOperand<ExecutionMode>("mode");

    public RefOpExecutionModeId(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpDecorateId : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public Decoration Decoration => Inner.GetEnumOperand<Decoration>("decoration");

    public RefOpDecorateId(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformElect : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;

    public RefOpGroupNonUniformElect(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformAll : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpGroupNonUniformAll(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformAny : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpGroupNonUniformAny(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformAllEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpGroupNonUniformAllEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformBroadcast : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Id => Inner.GetOperand<IdRef>("id") ?? default;

    public RefOpGroupNonUniformBroadcast(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformBroadcastFirst : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpGroupNonUniformBroadcastFirst(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformBallot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpGroupNonUniformBallot(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformInverseBallot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpGroupNonUniformInverseBallot(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformBallotBitExtract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;

    public RefOpGroupNonUniformBallotBitExtract(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformBallotBitCount : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpGroupNonUniformBallotBitCount(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformBallotFindLSB : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpGroupNonUniformBallotFindLSB(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformBallotFindMSB : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpGroupNonUniformBallotFindMSB(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformShuffle : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Id => Inner.GetOperand<IdRef>("id") ?? default;

    public RefOpGroupNonUniformShuffle(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformShuffleXor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Mask => Inner.GetOperand<IdRef>("mask") ?? default;

    public RefOpGroupNonUniformShuffleXor(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformShuffleUp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Delta => Inner.GetOperand<IdRef>("delta") ?? default;

    public RefOpGroupNonUniformShuffleUp(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformShuffleDown : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Delta => Inner.GetOperand<IdRef>("delta") ?? default;

    public RefOpGroupNonUniformShuffleDown(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformIAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformIAdd(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformFAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformFAdd(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformIMul : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformIMul(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformFMul : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformFMul(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformSMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformSMin(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformUMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformUMin(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformFMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformFMin(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformSMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformSMax(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformUMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformUMax(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformFMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformFMax(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformBitwiseAnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformBitwiseAnd(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformBitwiseOr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformBitwiseOr(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformBitwiseXor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformBitwiseXor(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformLogicalAnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformLogicalAnd(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformLogicalOr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformLogicalOr(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformLogicalXor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformLogicalXor(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformQuadBroadcast : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;

    public RefOpGroupNonUniformQuadBroadcast(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformQuadSwap : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;

    public RefOpGroupNonUniformQuadSwap(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCopyLogical : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpCopyLogical(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpPtrEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpPtrEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpPtrNotEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpPtrNotEqual(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpPtrDiff : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpPtrDiff(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpColorAttachmentReadEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Attachment => Inner.GetOperand<IdRef>("attachment") ?? default;
    public IdRef Sample => Inner.GetOperand<IdRef>("sample") ?? default;

    public RefOpColorAttachmentReadEXT(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpDepthAttachmentReadEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Sample => Inner.GetOperand<IdRef>("sample") ?? default;

    public RefOpDepthAttachmentReadEXT(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpStencilAttachmentReadEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Sample => Inner.GetOperand<IdRef>("sample") ?? default;

    public RefOpStencilAttachmentReadEXT(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTerminateInvocation : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public RefOpTerminateInvocation(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeUntypedPointerKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");

    public RefOpTypeUntypedPointerKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUntypedVariableKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");
    public IdRef DataType => Inner.GetOperand<IdRef>("dataType") ?? default;
    public IdRef Initializer => Inner.GetOperand<IdRef>("initializer") ?? default;

    public RefOpUntypedVariableKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUntypedAccessChainKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseType => Inner.GetOperand<IdRef>("baseType") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpUntypedAccessChainKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUntypedInBoundsAccessChainKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseType => Inner.GetOperand<IdRef>("baseType") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpUntypedInBoundsAccessChainKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupBallotKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpSubgroupBallotKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupFirstInvocationKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpSubgroupFirstInvocationKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUntypedPtrAccessChainKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseType => Inner.GetOperand<IdRef>("baseType") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Element => Inner.GetOperand<IdRef>("element") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpUntypedPtrAccessChainKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUntypedInBoundsPtrAccessChainKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseType => Inner.GetOperand<IdRef>("baseType") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Element => Inner.GetOperand<IdRef>("element") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpUntypedInBoundsPtrAccessChainKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUntypedArrayLengthKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Structure => Inner.GetOperand<IdRef>("structure") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public LiteralInteger Arraymember => Inner.GetOperand<LiteralInteger>("arraymember") ?? default;

    public RefOpUntypedArrayLengthKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUntypedPrefetchKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef PointerType => Inner.GetOperand<IdRef>("pointerType") ?? default;
    public IdRef NumBytes => Inner.GetOperand<IdRef>("numBytes") ?? default;
    public IdRef RW => Inner.GetOperand<IdRef>("rW") ?? default;
    public IdRef Locality => Inner.GetOperand<IdRef>("locality") ?? default;
    public IdRef CacheType => Inner.GetOperand<IdRef>("cacheType") ?? default;

    public RefOpUntypedPrefetchKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAllKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpSubgroupAllKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAnyKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpSubgroupAnyKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAllEqualKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpSubgroupAllEqualKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformRotateKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Delta => Inner.GetOperand<IdRef>("delta") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformRotateKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupReadInvocationKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;

    public RefOpSubgroupReadInvocationKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpExtInstWithForwardRefsKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Set => Inner.GetOperand<IdRef>("set") ?? default;
    public LiteralInteger Instruction => Inner.GetOperand<LiteralInteger>("instruction") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpExtInstWithForwardRefsKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTraceRayKHR : IWrapperInstruction
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

    public RefOpTraceRayKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpExecuteCallableKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef SBTIndex => Inner.GetOperand<IdRef>("sBTIndex") ?? default;
    public IdRef CallableData => Inner.GetOperand<IdRef>("callableData") ?? default;

    public RefOpExecuteCallableKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConvertUToAccelerationStructureKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Accel => Inner.GetOperand<IdRef>("accel") ?? default;

    public RefOpConvertUToAccelerationStructureKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIgnoreIntersectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public RefOpIgnoreIntersectionKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTerminateRayKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public RefOpTerminateRayKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSDot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public RefOpSDot(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUDot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public RefOpUDot(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSUDot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public RefOpSUDot(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSDotAccSat : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public IdRef Accumulator => Inner.GetOperand<IdRef>("accumulator") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public RefOpSDotAccSat(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUDotAccSat : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public IdRef Accumulator => Inner.GetOperand<IdRef>("accumulator") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public RefOpUDotAccSat(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSUDotAccSat : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public IdRef Accumulator => Inner.GetOperand<IdRef>("accumulator") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public RefOpSUDotAccSat(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeCooperativeMatrixKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ComponentType => Inner.GetOperand<IdRef>("componentType") ?? default;
    public IdScope Scope => Inner.GetOperand<IdScope>("scope") ?? default;
    public IdRef Rows => Inner.GetOperand<IdRef>("rows") ?? default;
    public IdRef Columns => Inner.GetOperand<IdRef>("columns") ?? default;
    public IdRef Use => Inner.GetOperand<IdRef>("use") ?? default;

    public RefOpTypeCooperativeMatrixKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCooperativeMatrixLoadKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef MemoryLayout => Inner.GetOperand<IdRef>("memoryLayout") ?? default;
    public IdRef Stride => Inner.GetOperand<IdRef>("stride") ?? default;
    public MemoryAccessMask MemoryOperand => Inner.GetEnumOperand<MemoryAccessMask>("memoryOperand");

    public RefOpCooperativeMatrixLoadKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCooperativeMatrixStoreKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public IdRef MemoryLayout => Inner.GetOperand<IdRef>("memoryLayout") ?? default;
    public IdRef Stride => Inner.GetOperand<IdRef>("stride") ?? default;
    public MemoryAccessMask MemoryOperand => Inner.GetEnumOperand<MemoryAccessMask>("memoryOperand");

    public RefOpCooperativeMatrixStoreKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCooperativeMatrixMulAddKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public IdRef C => Inner.GetOperand<IdRef>("c") ?? default;
    public CooperativeMatrixOperandsMask CooperativeMatrixOperands => Inner.GetEnumOperand<CooperativeMatrixOperandsMask>("cooperativeMatrixOperands");

    public RefOpCooperativeMatrixMulAddKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCooperativeMatrixLengthKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Type => Inner.GetOperand<IdRef>("type") ?? default;

    public RefOpCooperativeMatrixLengthKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConstantCompositeReplicateEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpConstantCompositeReplicateEXT(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSpecConstantCompositeReplicateEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpSpecConstantCompositeReplicateEXT(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCompositeConstructReplicateEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpCompositeConstructReplicateEXT(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeRayQueryKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeRayQueryKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryInitializeKHR : IWrapperInstruction
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

    public RefOpRayQueryInitializeKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryTerminateKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public RefOpRayQueryTerminateKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGenerateIntersectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef HitT => Inner.GetOperand<IdRef>("hitT") ?? default;

    public RefOpRayQueryGenerateIntersectionKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryConfirmIntersectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public RefOpRayQueryConfirmIntersectionKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryProceedKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public RefOpRayQueryProceedKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetIntersectionTypeKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionTypeKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSampleWeightedQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Texture => Inner.GetOperand<IdRef>("texture") ?? default;
    public IdRef Coordinates => Inner.GetOperand<IdRef>("coordinates") ?? default;
    public IdRef Weights => Inner.GetOperand<IdRef>("weights") ?? default;

    public RefOpImageSampleWeightedQCOM(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageBoxFilterQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Texture => Inner.GetOperand<IdRef>("texture") ?? default;
    public IdRef Coordinates => Inner.GetOperand<IdRef>("coordinates") ?? default;
    public IdRef BoxSize => Inner.GetOperand<IdRef>("boxSize") ?? default;

    public RefOpImageBoxFilterQCOM(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageBlockMatchSSDQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef Reference => Inner.GetOperand<IdRef>("reference") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public RefOpImageBlockMatchSSDQCOM(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageBlockMatchSADQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef Reference => Inner.GetOperand<IdRef>("reference") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public RefOpImageBlockMatchSADQCOM(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageBlockMatchWindowSSDQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TargetSampledImage => Inner.GetOperand<IdRef>("targetSampledImage") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef ReferenceSampledImage => Inner.GetOperand<IdRef>("referenceSampledImage") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public RefOpImageBlockMatchWindowSSDQCOM(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageBlockMatchWindowSADQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TargetSampledImage => Inner.GetOperand<IdRef>("targetSampledImage") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef ReferenceSampledImage => Inner.GetOperand<IdRef>("referenceSampledImage") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public RefOpImageBlockMatchWindowSADQCOM(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageBlockMatchGatherSSDQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TargetSampledImage => Inner.GetOperand<IdRef>("targetSampledImage") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef ReferenceSampledImage => Inner.GetOperand<IdRef>("referenceSampledImage") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public RefOpImageBlockMatchGatherSSDQCOM(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageBlockMatchGatherSADQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TargetSampledImage => Inner.GetOperand<IdRef>("targetSampledImage") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef ReferenceSampledImage => Inner.GetOperand<IdRef>("referenceSampledImage") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public RefOpImageBlockMatchGatherSADQCOM(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupIAddNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupIAddNonUniformAMD(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupFAddNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupFAddNonUniformAMD(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupFMinNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupFMinNonUniformAMD(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupUMinNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupUMinNonUniformAMD(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupSMinNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupSMinNonUniformAMD(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupFMaxNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupFMaxNonUniformAMD(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupUMaxNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupUMaxNonUniformAMD(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupSMaxNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupSMaxNonUniformAMD(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFragmentMaskFetchAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;

    public RefOpFragmentMaskFetchAMD(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFragmentFetchAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef FragmentIndex => Inner.GetOperand<IdRef>("fragmentIndex") ?? default;

    public RefOpFragmentFetchAMD(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpReadClockKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Scope => Inner.GetOperand<IdScope>("scope") ?? default;

    public RefOpReadClockKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAllocateNodePayloadsAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Visibility => Inner.GetOperand<IdScope>("visibility") ?? default;
    public IdRef PayloadCount => Inner.GetOperand<IdRef>("payloadCount") ?? default;
    public IdRef NodeIndex => Inner.GetOperand<IdRef>("nodeIndex") ?? default;

    public RefOpAllocateNodePayloadsAMDX(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpEnqueueNodePayloadsAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef PayloadArray => Inner.GetOperand<IdRef>("payloadArray") ?? default;

    public RefOpEnqueueNodePayloadsAMDX(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeNodePayloadArrayAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PayloadType => Inner.GetOperand<IdRef>("payloadType") ?? default;

    public RefOpTypeNodePayloadArrayAMDX(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFinishWritingNodePayloadAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpFinishWritingNodePayloadAMDX(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpNodePayloadArrayLengthAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PayloadArray => Inner.GetOperand<IdRef>("payloadArray") ?? default;

    public RefOpNodePayloadArrayLengthAMDX(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIsNodePayloadValidAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PayloadType => Inner.GetOperand<IdRef>("payloadType") ?? default;
    public IdRef NodeIndex => Inner.GetOperand<IdRef>("nodeIndex") ?? default;

    public RefOpIsNodePayloadValidAMDX(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConstantStringAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString LiteralString => Inner.GetOperand<LiteralString>("literalString") ?? default;

    public RefOpConstantStringAMDX(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSpecConstantStringAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString LiteralString => Inner.GetOperand<LiteralString>("literalString") ?? default;

    public RefOpSpecConstantStringAMDX(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformQuadAllKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpGroupNonUniformQuadAllKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformQuadAnyKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpGroupNonUniformQuadAnyKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectRecordHitMotionNV : IWrapperInstruction
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

    public RefOpHitObjectRecordHitMotionNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectRecordHitWithIndexMotionNV : IWrapperInstruction
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

    public RefOpHitObjectRecordHitWithIndexMotionNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectRecordMissMotionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef SBTIndex => Inner.GetOperand<IdRef>("sBTIndex") ?? default;
    public IdRef Origin => Inner.GetOperand<IdRef>("origin") ?? default;
    public IdRef TMin => Inner.GetOperand<IdRef>("tMin") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;
    public IdRef TMax => Inner.GetOperand<IdRef>("tMax") ?? default;
    public IdRef CurrentTime => Inner.GetOperand<IdRef>("currentTime") ?? default;

    public RefOpHitObjectRecordMissMotionNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectGetWorldToObjectNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetWorldToObjectNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectGetObjectToWorldNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetObjectToWorldNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectGetObjectRayDirectionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetObjectRayDirectionNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectGetObjectRayOriginNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetObjectRayOriginNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectTraceRayMotionNV : IWrapperInstruction
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

    public RefOpHitObjectTraceRayMotionNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectGetShaderRecordBufferHandleNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetShaderRecordBufferHandleNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectGetShaderBindingTableRecordIndexNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetShaderBindingTableRecordIndexNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectRecordEmptyNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectRecordEmptyNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectTraceRayNV : IWrapperInstruction
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

    public RefOpHitObjectTraceRayNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectRecordHitNV : IWrapperInstruction
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

    public RefOpHitObjectRecordHitNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectRecordHitWithIndexNV : IWrapperInstruction
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

    public RefOpHitObjectRecordHitWithIndexNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectRecordMissNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef SBTIndex => Inner.GetOperand<IdRef>("sBTIndex") ?? default;
    public IdRef Origin => Inner.GetOperand<IdRef>("origin") ?? default;
    public IdRef TMin => Inner.GetOperand<IdRef>("tMin") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;
    public IdRef TMax => Inner.GetOperand<IdRef>("tMax") ?? default;

    public RefOpHitObjectRecordMissNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectExecuteShaderNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpHitObjectExecuteShaderNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectGetCurrentTimeNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetCurrentTimeNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectGetAttributesNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef HitObjectAttribute => Inner.GetOperand<IdRef>("hitObjectAttribute") ?? default;

    public RefOpHitObjectGetAttributesNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectGetHitKindNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetHitKindNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectGetPrimitiveIndexNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetPrimitiveIndexNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectGetGeometryIndexNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetGeometryIndexNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectGetInstanceIdNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetInstanceIdNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectGetInstanceCustomIndexNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetInstanceCustomIndexNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectGetWorldRayDirectionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetWorldRayDirectionNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectGetWorldRayOriginNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetWorldRayOriginNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectGetRayTMaxNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetRayTMaxNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectGetRayTMinNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetRayTMinNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectIsEmptyNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectIsEmptyNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectIsHitNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectIsHitNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpHitObjectIsMissNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectIsMissNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpReorderThreadWithHitObjectNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef Hint => Inner.GetOperand<IdRef>("hint") ?? default;
    public IdRef Bits => Inner.GetOperand<IdRef>("bits") ?? default;

    public RefOpReorderThreadWithHitObjectNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpReorderThreadWithHintNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Hint => Inner.GetOperand<IdRef>("hint") ?? default;
    public IdRef Bits => Inner.GetOperand<IdRef>("bits") ?? default;

    public RefOpReorderThreadWithHintNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeHitObjectNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeHitObjectNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpImageSampleFootprintNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Granularity => Inner.GetOperand<IdRef>("granularity") ?? default;
    public IdRef Coarse => Inner.GetOperand<IdRef>("coarse") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleFootprintNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCooperativeMatrixConvertNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;

    public RefOpCooperativeMatrixConvertNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpEmitMeshTasksEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef GroupCountX => Inner.GetOperand<IdRef>("groupCountX") ?? default;
    public IdRef GroupCountY => Inner.GetOperand<IdRef>("groupCountY") ?? default;
    public IdRef GroupCountZ => Inner.GetOperand<IdRef>("groupCountZ") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpEmitMeshTasksEXT(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSetMeshOutputsEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef VertexCount => Inner.GetOperand<IdRef>("vertexCount") ?? default;
    public IdRef PrimitiveCount => Inner.GetOperand<IdRef>("primitiveCount") ?? default;

    public RefOpSetMeshOutputsEXT(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupNonUniformPartitionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpGroupNonUniformPartitionNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpWritePackedPrimitiveIndices4x8NV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef IndexOffset => Inner.GetOperand<IdRef>("indexOffset") ?? default;
    public IdRef PackedIndices => Inner.GetOperand<IdRef>("packedIndices") ?? default;

    public RefOpWritePackedPrimitiveIndices4x8NV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFetchMicroTriangleVertexPositionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Accel => Inner.GetOperand<IdRef>("accel") ?? default;
    public IdRef InstanceId => Inner.GetOperand<IdRef>("instanceId") ?? default;
    public IdRef GeometryIndex => Inner.GetOperand<IdRef>("geometryIndex") ?? default;
    public IdRef PrimitiveIndex => Inner.GetOperand<IdRef>("primitiveIndex") ?? default;
    public IdRef Barycentric => Inner.GetOperand<IdRef>("barycentric") ?? default;

    public RefOpFetchMicroTriangleVertexPositionNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFetchMicroTriangleVertexBarycentricNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Accel => Inner.GetOperand<IdRef>("accel") ?? default;
    public IdRef InstanceId => Inner.GetOperand<IdRef>("instanceId") ?? default;
    public IdRef GeometryIndex => Inner.GetOperand<IdRef>("geometryIndex") ?? default;
    public IdRef PrimitiveIndex => Inner.GetOperand<IdRef>("primitiveIndex") ?? default;
    public IdRef Barycentric => Inner.GetOperand<IdRef>("barycentric") ?? default;

    public RefOpFetchMicroTriangleVertexBarycentricNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpReportIntersectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Hit => Inner.GetOperand<IdRef>("hit") ?? default;
    public IdRef HitKind => Inner.GetOperand<IdRef>("hitKind") ?? default;

    public RefOpReportIntersectionKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIgnoreIntersectionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public RefOpIgnoreIntersectionNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTerminateRayNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public RefOpTerminateRayNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTraceNV : IWrapperInstruction
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

    public RefOpTraceNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTraceMotionNV : IWrapperInstruction
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

    public RefOpTraceMotionNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTraceRayMotionNV : IWrapperInstruction
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

    public RefOpTraceRayMotionNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetIntersectionTriangleVertexPositionsKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionTriangleVertexPositionsKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeAccelerationStructureKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAccelerationStructureKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpExecuteCallableNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef SBTIndex => Inner.GetOperand<IdRef>("sBTIndex") ?? default;
    public IdRef CallableDataId => Inner.GetOperand<IdRef>("callableDataId") ?? default;

    public RefOpExecuteCallableNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeCooperativeMatrixNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ComponentType => Inner.GetOperand<IdRef>("componentType") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Rows => Inner.GetOperand<IdRef>("rows") ?? default;
    public IdRef Columns => Inner.GetOperand<IdRef>("columns") ?? default;

    public RefOpTypeCooperativeMatrixNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCooperativeMatrixLoadNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef Stride => Inner.GetOperand<IdRef>("stride") ?? default;
    public IdRef ColumnMajor => Inner.GetOperand<IdRef>("columnMajor") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");

    public RefOpCooperativeMatrixLoadNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCooperativeMatrixStoreNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public IdRef Stride => Inner.GetOperand<IdRef>("stride") ?? default;
    public IdRef ColumnMajor => Inner.GetOperand<IdRef>("columnMajor") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");

    public RefOpCooperativeMatrixStoreNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCooperativeMatrixMulAddNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public IdRef C => Inner.GetOperand<IdRef>("c") ?? default;

    public RefOpCooperativeMatrixMulAddNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCooperativeMatrixLengthNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Type => Inner.GetOperand<IdRef>("type") ?? default;

    public RefOpCooperativeMatrixLengthNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpBeginInvocationInterlockEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public RefOpBeginInvocationInterlockEXT(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpEndInvocationInterlockEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public RefOpEndInvocationInterlockEXT(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCooperativeMatrixReduceNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;
    public CooperativeMatrixReduceMask Reduce => Inner.GetEnumOperand<CooperativeMatrixReduceMask>("reduce");
    public IdRef CombineFunc => Inner.GetOperand<IdRef>("combineFunc") ?? default;

    public RefOpCooperativeMatrixReduceNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCooperativeMatrixLoadTensorNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public MemoryAccessMask MemoryOperand => Inner.GetEnumOperand<MemoryAccessMask>("memoryOperand");
    public TensorAddressingOperandsMask TensorAddressingOperands => Inner.GetEnumOperand<TensorAddressingOperandsMask>("tensorAddressingOperands");

    public RefOpCooperativeMatrixLoadTensorNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCooperativeMatrixStoreTensorNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public MemoryAccessMask MemoryOperand => Inner.GetEnumOperand<MemoryAccessMask>("memoryOperand");
    public TensorAddressingOperandsMask TensorAddressingOperands => Inner.GetEnumOperand<TensorAddressingOperandsMask>("tensorAddressingOperands");

    public RefOpCooperativeMatrixStoreTensorNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCooperativeMatrixPerElementOpNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;
    public IdRef Func => Inner.GetOperand<IdRef>("func") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpCooperativeMatrixPerElementOpNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeTensorLayoutNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Dim => Inner.GetOperand<IdRef>("dim") ?? default;
    public IdRef ClampMode => Inner.GetOperand<IdRef>("clampMode") ?? default;

    public RefOpTypeTensorLayoutNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeTensorViewNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Dim => Inner.GetOperand<IdRef>("dim") ?? default;
    public IdRef HasDimensions => Inner.GetOperand<IdRef>("hasDimensions") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTypeTensorViewNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCreateTensorLayoutNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpCreateTensorLayoutNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTensorLayoutSetDimensionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTensorLayoutSetDimensionNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTensorLayoutSetStrideNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTensorLayoutSetStrideNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTensorLayoutSliceNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTensorLayoutSliceNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTensorLayoutSetClampValueNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpTensorLayoutSetClampValueNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCreateTensorViewNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpCreateTensorViewNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTensorViewSetDimensionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorView => Inner.GetOperand<IdRef>("tensorView") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTensorViewSetDimensionNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTensorViewSetStrideNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorView => Inner.GetOperand<IdRef>("tensorView") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTensorViewSetStrideNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpDemoteToHelperInvocation : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public RefOpDemoteToHelperInvocation(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIsHelperInvocationEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpIsHelperInvocationEXT(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTensorViewSetClipNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorView => Inner.GetOperand<IdRef>("tensorView") ?? default;
    public IdRef ClipRowOffset => Inner.GetOperand<IdRef>("clipRowOffset") ?? default;
    public IdRef ClipRowSpan => Inner.GetOperand<IdRef>("clipRowSpan") ?? default;
    public IdRef ClipColOffset => Inner.GetOperand<IdRef>("clipColOffset") ?? default;
    public IdRef ClipColSpan => Inner.GetOperand<IdRef>("clipColSpan") ?? default;

    public RefOpTensorViewSetClipNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTensorLayoutSetBlockSizeNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTensorLayoutSetBlockSizeNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCooperativeMatrixTransposeNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;

    public RefOpCooperativeMatrixTransposeNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConvertUToImageNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpConvertUToImageNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConvertUToSamplerNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpConvertUToSamplerNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConvertImageToUNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpConvertImageToUNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConvertSamplerToUNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpConvertSamplerToUNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConvertUToSampledImageNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpConvertUToSampledImageNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConvertSampledImageToUNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpConvertSampledImageToUNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSamplerImageAddressingModeNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralInteger BitWidth => Inner.GetOperand<LiteralInteger>("bitWidth") ?? default;

    public RefOpSamplerImageAddressingModeNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRawAccessChainNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Bytestride => Inner.GetOperand<IdRef>("bytestride") ?? default;
    public IdRef Elementindex => Inner.GetOperand<IdRef>("elementindex") ?? default;
    public IdRef Byteoffset => Inner.GetOperand<IdRef>("byteoffset") ?? default;
    public RawAccessChainOperandsMask Rawaccesschainoperands => Inner.GetEnumOperand<RawAccessChainOperandsMask>("rawaccesschainoperands");

    public RefOpRawAccessChainNV(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupShuffleINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Data => Inner.GetOperand<IdRef>("data") ?? default;
    public IdRef InvocationId => Inner.GetOperand<IdRef>("invocationId") ?? default;

    public RefOpSubgroupShuffleINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupShuffleDownINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Current => Inner.GetOperand<IdRef>("current") ?? default;
    public IdRef Next => Inner.GetOperand<IdRef>("next") ?? default;
    public IdRef Delta => Inner.GetOperand<IdRef>("delta") ?? default;

    public RefOpSubgroupShuffleDownINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupShuffleUpINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Previous => Inner.GetOperand<IdRef>("previous") ?? default;
    public IdRef Current => Inner.GetOperand<IdRef>("current") ?? default;
    public IdRef Delta => Inner.GetOperand<IdRef>("delta") ?? default;

    public RefOpSubgroupShuffleUpINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupShuffleXorINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Data => Inner.GetOperand<IdRef>("data") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpSubgroupShuffleXorINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupBlockReadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Ptr => Inner.GetOperand<IdRef>("ptr") ?? default;

    public RefOpSubgroupBlockReadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupBlockWriteINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Ptr => Inner.GetOperand<IdRef>("ptr") ?? default;
    public IdRef Data => Inner.GetOperand<IdRef>("data") ?? default;

    public RefOpSubgroupBlockWriteINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupImageBlockReadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;

    public RefOpSubgroupImageBlockReadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupImageBlockWriteINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Data => Inner.GetOperand<IdRef>("data") ?? default;

    public RefOpSubgroupImageBlockWriteINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupImageMediaBlockReadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Width => Inner.GetOperand<IdRef>("width") ?? default;
    public IdRef Height => Inner.GetOperand<IdRef>("height") ?? default;

    public RefOpSubgroupImageMediaBlockReadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupImageMediaBlockWriteINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Width => Inner.GetOperand<IdRef>("width") ?? default;
    public IdRef Height => Inner.GetOperand<IdRef>("height") ?? default;
    public IdRef Data => Inner.GetOperand<IdRef>("data") ?? default;

    public RefOpSubgroupImageMediaBlockWriteINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUCountLeadingZerosINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpUCountLeadingZerosINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUCountTrailingZerosINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpUCountTrailingZerosINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAbsISubINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpAbsISubINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAbsUSubINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpAbsUSubINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIAddSatINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpIAddSatINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUAddSatINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUAddSatINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIAverageINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpIAverageINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUAverageINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUAverageINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIAverageRoundedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpIAverageRoundedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUAverageRoundedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUAverageRoundedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpISubSatINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpISubSatINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUSubSatINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUSubSatINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpIMul32x16INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpIMul32x16INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpUMul32x16INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUMul32x16INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConstantFunctionPointerINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Function => Inner.GetOperand<IdRef>("function") ?? default;

    public RefOpConstantFunctionPointerINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFunctionPointerCallINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpFunctionPointerCallINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAsmTargetINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString Asmtarget => Inner.GetOperand<LiteralString>("asmtarget") ?? default;

    public RefOpAsmTargetINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAsmINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Asmtype => Inner.GetOperand<IdRef>("asmtype") ?? default;
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public LiteralString Asminstructions => Inner.GetOperand<LiteralString>("asminstructions") ?? default;
    public LiteralString Constraints => Inner.GetOperand<LiteralString>("constraints") ?? default;

    public RefOpAsmINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAsmCallINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Asm => Inner.GetOperand<IdRef>("asm") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpAsmCallINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicFMinEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicFMinEXT(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicFMaxEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicFMaxEXT(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAssumeTrueKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Condition => Inner.GetOperand<IdRef>("condition") ?? default;

    public RefOpAssumeTrueKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpExpectKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ExpectedValue => Inner.GetOperand<IdRef>("expectedValue") ?? default;

    public RefOpExpectKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpDecorateString : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public Decoration Decoration => Inner.GetEnumOperand<Decoration>("decoration");

    public RefOpDecorateString(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpMemberDecorateString : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef StructType => Inner.GetOperand<IdRef>("structType") ?? default;
    public LiteralInteger Member => Inner.GetOperand<LiteralInteger>("member") ?? default;
    public Decoration Decoration => Inner.GetEnumOperand<Decoration>("decoration");

    public RefOpMemberDecorateString(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpVmeImageINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ImageType => Inner.GetOperand<IdRef>("imageType") ?? default;
    public IdRef Sampler => Inner.GetOperand<IdRef>("sampler") ?? default;

    public RefOpVmeImageINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeVmeImageINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ImageType => Inner.GetOperand<IdRef>("imageType") ?? default;

    public RefOpTypeVmeImageINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeAvcImePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcImePayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeAvcRefPayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcRefPayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeAvcSicPayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcSicPayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeAvcMcePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcMcePayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeAvcMceResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcMceResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeAvcImeResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcImeResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeAvcImeResultSingleReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcImeResultSingleReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeAvcImeResultDualReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcImeResultDualReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeAvcImeSingleReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcImeSingleReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeAvcImeDualReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcImeDualReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeAvcRefResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcRefResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeAvcSicResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcSicResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public RefOpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ReferenceBasePenalty => Inner.GetOperand<IdRef>("referenceBasePenalty") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public RefOpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceSetInterShapePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedShapePenalty => Inner.GetOperand<IdRef>("packedShapePenalty") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceSetInterShapePenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public RefOpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceSetInterDirectionPenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef DirectionCost => Inner.GetOperand<IdRef>("directionCost") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceSetInterDirectionPenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public RefOpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public RefOpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceSetMotionVectorCostFunctionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedCostCenterDelta => Inner.GetOperand<IdRef>("packedCostCenterDelta") ?? default;
    public IdRef PackedCostTable => Inner.GetOperand<IdRef>("packedCostTable") ?? default;
    public IdRef CostPrecision => Inner.GetOperand<IdRef>("costPrecision") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceSetMotionVectorCostFunctionINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public RefOpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceSetAcOnlyHaarINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceSetAcOnlyHaarINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SourceFieldPolarity => Inner.GetOperand<IdRef>("sourceFieldPolarity") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ReferenceFieldPolarity => Inner.GetOperand<IdRef>("referenceFieldPolarity") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ForwardReferenceFieldPolarity => Inner.GetOperand<IdRef>("forwardReferenceFieldPolarity") ?? default;
    public IdRef BackwardReferenceFieldPolarity => Inner.GetOperand<IdRef>("backwardReferenceFieldPolarity") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceConvertToImePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceConvertToImePayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceConvertToImeResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceConvertToImeResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceConvertToRefPayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceConvertToRefPayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceConvertToRefResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceConvertToRefResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceConvertToSicPayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceConvertToSicPayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceConvertToSicResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceConvertToSicResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetMotionVectorsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetMotionVectorsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetInterDistortionsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetInterDistortionsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetBestInterDistortionsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetBestInterDistortionsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetInterMajorShapeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetInterMajorShapeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetInterMinorShapeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetInterMinorShapeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetInterDirectionsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetInterDirectionsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetInterMotionVectorCountINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetInterMotionVectorCountINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetInterReferenceIdsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetInterReferenceIdsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedReferenceIds => Inner.GetOperand<IdRef>("packedReferenceIds") ?? default;
    public IdRef PackedReferenceParameterFieldPolarities => Inner.GetOperand<IdRef>("packedReferenceParameterFieldPolarities") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeInitializeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcCoord => Inner.GetOperand<IdRef>("srcCoord") ?? default;
    public IdRef PartitionMask => Inner.GetOperand<IdRef>("partitionMask") ?? default;
    public IdRef SADAdjustment => Inner.GetOperand<IdRef>("sADAdjustment") ?? default;

    public RefOpSubgroupAvcImeInitializeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeSetSingleReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RefOffset => Inner.GetOperand<IdRef>("refOffset") ?? default;
    public IdRef SearchWindowConfig => Inner.GetOperand<IdRef>("searchWindowConfig") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeSetSingleReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeSetDualReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef FwdRefOffset => Inner.GetOperand<IdRef>("fwdRefOffset") ?? default;
    public IdRef BwdRefOffset => Inner.GetOperand<IdRef>("bwdRefOffset") ?? default;
    public IdRef IdSearchWindowConfig => Inner.GetOperand<IdRef>("idSearchWindowConfig") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeSetDualReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeRefWindowSizeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SearchWindowConfig => Inner.GetOperand<IdRef>("searchWindowConfig") ?? default;
    public IdRef DualRef => Inner.GetOperand<IdRef>("dualRef") ?? default;

    public RefOpSubgroupAvcImeRefWindowSizeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeAdjustRefOffsetINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RefOffset => Inner.GetOperand<IdRef>("refOffset") ?? default;
    public IdRef SrcCoord => Inner.GetOperand<IdRef>("srcCoord") ?? default;
    public IdRef RefWindowSize => Inner.GetOperand<IdRef>("refWindowSize") ?? default;
    public IdRef ImageSize => Inner.GetOperand<IdRef>("imageSize") ?? default;

    public RefOpSubgroupAvcImeAdjustRefOffsetINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeConvertToMcePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeConvertToMcePayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeSetMaxMotionVectorCountINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef MaxMotionVectorCount => Inner.GetOperand<IdRef>("maxMotionVectorCount") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeSetMaxMotionVectorCountINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeSetUnidirectionalMixDisableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeSetUnidirectionalMixDisableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Threshold => Inner.GetOperand<IdRef>("threshold") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeSetWeightedSadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedSadWeights => Inner.GetOperand<IdRef>("packedSadWeights") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeSetWeightedSadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeEvaluateWithSingleReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeEvaluateWithSingleReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeEvaluateWithDualReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeEvaluateWithDualReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef StreaminComponents => Inner.GetOperand<IdRef>("streaminComponents") ?? default;

    public RefOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef StreaminComponents => Inner.GetOperand<IdRef>("streaminComponents") ?? default;

    public RefOpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef StreaminComponents => Inner.GetOperand<IdRef>("streaminComponents") ?? default;

    public RefOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef StreaminComponents => Inner.GetOperand<IdRef>("streaminComponents") ?? default;

    public RefOpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeConvertToMceResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeConvertToMceResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeGetSingleReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeGetSingleReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeGetDualReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeGetDualReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeStripSingleReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeStripSingleReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeStripDualReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeStripDualReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;

    public RefOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;

    public RefOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;

    public RefOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;

    public RefOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;

    public RefOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;

    public RefOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeGetBorderReachedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ImageSelect => Inner.GetOperand<IdRef>("imageSelect") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeGetBorderReachedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeGetTruncatedSearchIndicationINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeGetTruncatedSearchIndicationINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcFmeInitializeINTEL : IWrapperInstruction
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

    public RefOpSubgroupAvcFmeInitializeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcBmeInitializeINTEL : IWrapperInstruction
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

    public RefOpSubgroupAvcBmeInitializeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcRefConvertToMcePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcRefConvertToMcePayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcRefSetBidirectionalMixDisableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcRefSetBidirectionalMixDisableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcRefSetBilinearFilterEnableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcRefSetBilinearFilterEnableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcRefEvaluateWithSingleReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcRefEvaluateWithSingleReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcRefEvaluateWithDualReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcRefEvaluateWithDualReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcRefEvaluateWithMultiReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef PackedReferenceIds => Inner.GetOperand<IdRef>("packedReferenceIds") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcRefEvaluateWithMultiReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef PackedReferenceIds => Inner.GetOperand<IdRef>("packedReferenceIds") ?? default;
    public IdRef PackedReferenceFieldPolarities => Inner.GetOperand<IdRef>("packedReferenceFieldPolarities") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcRefConvertToMceResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcRefConvertToMceResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicInitializeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcCoord => Inner.GetOperand<IdRef>("srcCoord") ?? default;

    public RefOpSubgroupAvcSicInitializeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicConfigureSkcINTEL : IWrapperInstruction
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

    public RefOpSubgroupAvcSicConfigureSkcINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicConfigureIpeLumaINTEL : IWrapperInstruction
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

    public RefOpSubgroupAvcSicConfigureIpeLumaINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicConfigureIpeLumaChromaINTEL : IWrapperInstruction
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

    public RefOpSubgroupAvcSicConfigureIpeLumaChromaINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicGetMotionVectorMaskINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SkipBlockPartitionType => Inner.GetOperand<IdRef>("skipBlockPartitionType") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;

    public RefOpSubgroupAvcSicGetMotionVectorMaskINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicConvertToMcePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicConvertToMcePayloadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedShapePenalty => Inner.GetOperand<IdRef>("packedShapePenalty") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef LumaModePenalty => Inner.GetOperand<IdRef>("lumaModePenalty") ?? default;
    public IdRef LumaPackedNeighborModes => Inner.GetOperand<IdRef>("lumaPackedNeighborModes") ?? default;
    public IdRef LumaPackedNonDcPenalty => Inner.GetOperand<IdRef>("lumaPackedNonDcPenalty") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ChromaModeBasePenalty => Inner.GetOperand<IdRef>("chromaModeBasePenalty") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicSetBilinearFilterEnableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicSetBilinearFilterEnableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicSetSkcForwardTransformEnableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedSadCoefficients => Inner.GetOperand<IdRef>("packedSadCoefficients") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicSetSkcForwardTransformEnableINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BlockBasedSkipType => Inner.GetOperand<IdRef>("blockBasedSkipType") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicEvaluateIpeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicEvaluateIpeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicEvaluateWithSingleReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicEvaluateWithSingleReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicEvaluateWithDualReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicEvaluateWithDualReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicEvaluateWithMultiReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef PackedReferenceIds => Inner.GetOperand<IdRef>("packedReferenceIds") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicEvaluateWithMultiReferenceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef PackedReferenceIds => Inner.GetOperand<IdRef>("packedReferenceIds") ?? default;
    public IdRef PackedReferenceFieldPolarities => Inner.GetOperand<IdRef>("packedReferenceFieldPolarities") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicConvertToMceResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicConvertToMceResultINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicGetIpeLumaShapeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicGetIpeLumaShapeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicGetBestIpeLumaDistortionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicGetBestIpeLumaDistortionINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicGetBestIpeChromaDistortionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicGetBestIpeChromaDistortionINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicGetPackedIpeLumaModesINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicGetPackedIpeLumaModesINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicGetIpeChromaModeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicGetIpeChromaModeINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupAvcSicGetInterRawSadsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicGetInterRawSadsINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpVariableLengthArrayINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Lenght => Inner.GetOperand<IdRef>("lenght") ?? default;

    public RefOpVariableLengthArrayINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSaveMemoryINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSaveMemoryINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRestoreMemoryINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Ptr => Inner.GetOperand<IdRef>("ptr") ?? default;

    public RefOpRestoreMemoryINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatSinCosPiINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatSinCosPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatCastINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatCastINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatCastFromIntINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatCastFromIntINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatCastToIntINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatCastToIntINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatAddINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatAddINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatSubINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatSubINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatMulINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatMulINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatDivINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatDivINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatGTINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public RefOpArbitraryFloatGTINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatGEINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public RefOpArbitraryFloatGEINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatLTINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public RefOpArbitraryFloatLTINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatLEINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public RefOpArbitraryFloatLEINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatEQINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public RefOpArbitraryFloatEQINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatRecipINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatRecipINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatRSqrtINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatRSqrtINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatCbrtINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatCbrtINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatHypotINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatHypotINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatSqrtINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatSqrtINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatLogINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatLogINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatLog2INTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatLog2INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatLog10INTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatLog10INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatLog1pINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatLog1pINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatExpINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatExpINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatExp2INTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatExp2INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatExp10INTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatExp10INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatExpm1INTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatExpm1INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatSinINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatSinINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatCosINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatCosINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatSinCosINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatSinCosINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatSinPiINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatSinPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatCosPiINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatCosPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatASinINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatASinINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatASinPiINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatASinPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatACosINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatACosINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatACosPiINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatACosPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatATanINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatATanINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatATanPiINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatATanPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatATan2INTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatATan2INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatPowINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatPowINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatPowRINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatPowRINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArbitraryFloatPowNINTEL : IWrapperInstruction
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

    public RefOpArbitraryFloatPowNINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpLoopControlINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public RefOpLoopControlINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAliasDomainDeclINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Name => Inner.GetOperand<IdRef>("name") ?? default;

    public RefOpAliasDomainDeclINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAliasScopeDeclINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef AliasDomain => Inner.GetOperand<IdRef>("aliasDomain") ?? default;
    public IdRef Name => Inner.GetOperand<IdRef>("name") ?? default;

    public RefOpAliasScopeDeclINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAliasScopeListDeclINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpAliasScopeListDeclINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFixedSqrtINTEL : IWrapperInstruction
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

    public RefOpFixedSqrtINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFixedRecipINTEL : IWrapperInstruction
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

    public RefOpFixedRecipINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFixedRsqrtINTEL : IWrapperInstruction
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

    public RefOpFixedRsqrtINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFixedSinINTEL : IWrapperInstruction
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

    public RefOpFixedSinINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFixedCosINTEL : IWrapperInstruction
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

    public RefOpFixedCosINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFixedSinCosINTEL : IWrapperInstruction
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

    public RefOpFixedSinCosINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFixedSinPiINTEL : IWrapperInstruction
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

    public RefOpFixedSinPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFixedCosPiINTEL : IWrapperInstruction
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

    public RefOpFixedCosPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFixedSinCosPiINTEL : IWrapperInstruction
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

    public RefOpFixedSinCosPiINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFixedLogINTEL : IWrapperInstruction
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

    public RefOpFixedLogINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFixedExpINTEL : IWrapperInstruction
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

    public RefOpFixedExpINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpPtrCastToCrossWorkgroupINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public RefOpPtrCastToCrossWorkgroupINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCrossWorkgroupCastToPtrINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public RefOpCrossWorkgroupCastToPtrINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpReadPipeBlockingINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpReadPipeBlockingINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpWritePipeBlockingINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpWritePipeBlockingINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpFPGARegINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Result => Inner.GetOperand<IdRef>("result") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;

    public RefOpFPGARegINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetRayTMinKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public RefOpRayQueryGetRayTMinKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetRayFlagsKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public RefOpRayQueryGetRayFlagsKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetIntersectionTKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionTKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetIntersectionInstanceCustomIndexKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionInstanceCustomIndexKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetIntersectionInstanceIdKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionInstanceIdKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetIntersectionGeometryIndexKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionGeometryIndexKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetIntersectionPrimitiveIndexKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionPrimitiveIndexKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetIntersectionBarycentricsKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionBarycentricsKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetIntersectionFrontFaceKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionFrontFaceKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetIntersectionCandidateAABBOpaqueKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public RefOpRayQueryGetIntersectionCandidateAABBOpaqueKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetIntersectionObjectRayDirectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionObjectRayDirectionKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetIntersectionObjectRayOriginKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionObjectRayOriginKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetWorldRayDirectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public RefOpRayQueryGetWorldRayDirectionKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetWorldRayOriginKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public RefOpRayQueryGetWorldRayOriginKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetIntersectionObjectToWorldKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionObjectToWorldKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpRayQueryGetIntersectionWorldToObjectKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionWorldToObjectKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpAtomicFAddEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicFAddEXT(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeBufferSurfaceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public AccessQualifier AccessQualifier => Inner.GetEnumOperand<AccessQualifier>("accessQualifier");

    public RefOpTypeBufferSurfaceINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpTypeStructContinuedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTypeStructContinuedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConstantCompositeContinuedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpConstantCompositeContinuedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSpecConstantCompositeContinuedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpSpecConstantCompositeContinuedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpCompositeConstructContinuedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpCompositeConstructContinuedINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConvertFToBF16INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef FloatValue => Inner.GetOperand<IdRef>("floatValue") ?? default;

    public RefOpConvertFToBF16INTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpConvertBF16ToFINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BFloat16Value => Inner.GetOperand<IdRef>("bFloat16Value") ?? default;

    public RefOpConvertBF16ToFINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpControlBarrierArriveINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpControlBarrierArriveINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpControlBarrierWaitINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpControlBarrierWaitINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpArithmeticFenceEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;

    public RefOpArithmeticFenceEXT(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpSubgroupBlockPrefetchINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Ptr => Inner.GetOperand<IdRef>("ptr") ?? default;
    public IdRef NumBytes => Inner.GetOperand<IdRef>("numBytes") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");

    public RefOpSubgroupBlockPrefetchINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupIMulKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupIMulKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupFMulKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupFMulKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupBitwiseAndKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupBitwiseAndKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupBitwiseOrKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupBitwiseOrKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupBitwiseXorKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupBitwiseXorKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupLogicalAndKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupLogicalAndKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupLogicalOrKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupLogicalOrKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpGroupLogicalXorKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupLogicalXorKHR(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpMaskedGatherINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PtrVector => Inner.GetOperand<IdRef>("ptrVector") ?? default;
    public LiteralInteger Alignment => Inner.GetOperand<LiteralInteger>("alignment") ?? default;
    public IdRef Mask => Inner.GetOperand<IdRef>("mask") ?? default;
    public IdRef FillEmpty => Inner.GetOperand<IdRef>("fillEmpty") ?? default;

    public RefOpMaskedGatherINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefOpMaskedScatterINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef InputVector => Inner.GetOperand<IdRef>("inputVector") ?? default;
    public IdRef PtrVector => Inner.GetOperand<IdRef>("ptrVector") ?? default;
    public LiteralInteger Alignment => Inner.GetOperand<LiteralInteger>("alignment") ?? default;
    public IdRef Mask => Inner.GetOperand<IdRef>("mask") ?? default;

    public RefOpMaskedScatterINTEL(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLRound : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLRound(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLRoundEven : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLRoundEven(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLTrunc : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLTrunc(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLFAbs : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLFAbs(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLSAbs : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLSAbs(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLFSign : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLFSign(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLSSign : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLSSign(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLFloor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLFloor(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLCeil : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLCeil(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLFract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLFract(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLRadians : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Degrees => Inner.GetOperand<IdRef>("degrees") ?? default;

    public RefGLSLRadians(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLDegrees : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Radians => Inner.GetOperand<IdRef>("radians") ?? default;

    public RefGLSLDegrees(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLSin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLSin(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLCos : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLCos(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLTan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLTan(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLAsin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLAsin(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLAcos : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLAcos(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLAtan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Y_over_x => Inner.GetOperand<IdRef>("y_over_x") ?? default;

    public RefGLSLAtan(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLSinh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLSinh(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLCosh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLCosh(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLTanh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLTanh(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLAsinh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLAsinh(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLAcosh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLAcosh(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLAtanh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLAtanh(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLAtan2 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLAtan2(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLPow : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLPow(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLExp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLExp(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLLog : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLLog(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLExp2 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLExp2(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLLog2 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLLog2(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLSqrt : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLSqrt(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLInverseSqrt : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLInverseSqrt(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLDeterminant : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLDeterminant(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLMatrixInverse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLMatrixInverse(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLModf : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef I => Inner.GetOperand<IdRef>("i") ?? default;

    public RefGLSLModf(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLModfStruct : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLModfStruct(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLFMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLFMin(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLUMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLUMin(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLSMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLSMin(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLFMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLFMax(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLUMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLUMax(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLSMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLSMax(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLFClamp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef MinVal => Inner.GetOperand<IdRef>("minVal") ?? default;
    public IdRef MaxVal => Inner.GetOperand<IdRef>("maxVal") ?? default;

    public RefGLSLFClamp(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLUClamp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef MinVal => Inner.GetOperand<IdRef>("minVal") ?? default;
    public IdRef MaxVal => Inner.GetOperand<IdRef>("maxVal") ?? default;

    public RefGLSLUClamp(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLSClamp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef MinVal => Inner.GetOperand<IdRef>("minVal") ?? default;
    public IdRef MaxVal => Inner.GetOperand<IdRef>("maxVal") ?? default;

    public RefGLSLSClamp(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLFMix : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;

    public RefGLSLFMix(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLIMix : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;

    public RefGLSLIMix(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLStep : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Edge => Inner.GetOperand<IdRef>("edge") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLStep(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLSmoothStep : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Edge0 => Inner.GetOperand<IdRef>("edge0") ?? default;
    public IdRef Edge1 => Inner.GetOperand<IdRef>("edge1") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLSmoothStep(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLFma : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public IdRef C => Inner.GetOperand<IdRef>("c") ?? default;

    public RefGLSLFma(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLFrexp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Exp => Inner.GetOperand<IdRef>("exp") ?? default;

    public RefGLSLFrexp(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLFrexpStruct : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLFrexpStruct(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLLdexp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Exp => Inner.GetOperand<IdRef>("exp") ?? default;

    public RefGLSLLdexp(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLPackSnorm4x8 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public RefGLSLPackSnorm4x8(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLPackUnorm4x8 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public RefGLSLPackUnorm4x8(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLPackSnorm2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public RefGLSLPackSnorm2x16(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLPackUnorm2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public RefGLSLPackUnorm2x16(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLPackHalf2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public RefGLSLPackHalf2x16(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLPackDouble2x32 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public RefGLSLPackDouble2x32(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLUnpackSnorm2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefGLSLUnpackSnorm2x16(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLUnpackUnorm2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefGLSLUnpackUnorm2x16(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLUnpackHalf2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public RefGLSLUnpackHalf2x16(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLUnpackSnorm4x8 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefGLSLUnpackSnorm4x8(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLUnpackUnorm4x8 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefGLSLUnpackUnorm4x8(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLUnpackDouble2x32 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public RefGLSLUnpackDouble2x32(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLLength : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLLength(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLDistance : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef P0 => Inner.GetOperand<IdRef>("p0") ?? default;
    public IdRef P1 => Inner.GetOperand<IdRef>("p1") ?? default;

    public RefGLSLDistance(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLCross : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLCross(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLNormalize : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLNormalize(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLFaceForward : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef N => Inner.GetOperand<IdRef>("n") ?? default;
    public IdRef I => Inner.GetOperand<IdRef>("i") ?? default;
    public IdRef Nref => Inner.GetOperand<IdRef>("nref") ?? default;

    public RefGLSLFaceForward(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLReflect : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef I => Inner.GetOperand<IdRef>("i") ?? default;
    public IdRef N => Inner.GetOperand<IdRef>("n") ?? default;

    public RefGLSLReflect(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLRefract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef I => Inner.GetOperand<IdRef>("i") ?? default;
    public IdRef N => Inner.GetOperand<IdRef>("n") ?? default;
    public IdRef Eta => Inner.GetOperand<IdRef>("eta") ?? default;

    public RefGLSLRefract(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLFindILsb : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefGLSLFindILsb(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLFindSMsb : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefGLSLFindSMsb(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLFindUMsb : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefGLSLFindUMsb(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLInterpolateAtCentroid : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Interpolant => Inner.GetOperand<IdRef>("interpolant") ?? default;

    public RefGLSLInterpolateAtCentroid(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLInterpolateAtSample : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Interpolant => Inner.GetOperand<IdRef>("interpolant") ?? default;
    public IdRef Sample => Inner.GetOperand<IdRef>("sample") ?? default;

    public RefGLSLInterpolateAtSample(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLInterpolateAtOffset : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Interpolant => Inner.GetOperand<IdRef>("interpolant") ?? default;
    public IdRef Offset => Inner.GetOperand<IdRef>("offset") ?? default;

    public RefGLSLInterpolateAtOffset(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLNMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLNMin(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLNMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLNMax(Instruction instruction) => Inner = instruction;
}

public ref struct RefGLSLNClamp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef MinVal => Inner.GetOperand<IdRef>("minVal") ?? default;
    public IdRef MaxVal => Inner.GetOperand<IdRef>("maxVal") ?? default;

    public RefGLSLNClamp(Instruction instruction) => Inner = instruction;
}