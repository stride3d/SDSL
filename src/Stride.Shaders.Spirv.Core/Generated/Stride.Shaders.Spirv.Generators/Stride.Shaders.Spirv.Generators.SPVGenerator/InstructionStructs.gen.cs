using static Spv.Specification;

namespace Stride.Shaders.Spirv.Core;
public ref struct RefOpSDSLDecorateSemantic : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public LiteralString Semantic => Inner.GetOperand<LiteralString>("semantic") ?? default;

    public RefOpSDSLDecorateSemantic(RefInstruction instruction) => Inner = instruction;
    public RefOpSDSLDecorateSemantic(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSDSLMixinName : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public LiteralString MixinName => Inner.GetOperand<LiteralString>("mixinName") ?? default;

    public RefOpSDSLMixinName(RefInstruction instruction) => Inner = instruction;
    public RefOpSDSLMixinName(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSDSLMixinEnd : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }

    public RefOpSDSLMixinEnd(RefInstruction instruction) => Inner = instruction;
    public RefOpSDSLMixinEnd(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSDSLMixinOffset : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public LiteralInteger MixinName => Inner.GetOperand<LiteralInteger>("mixinName") ?? default;

    public RefOpSDSLMixinOffset(RefInstruction instruction) => Inner = instruction;
    public RefOpSDSLMixinOffset(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSDSLMixinInherit : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public LiteralString MixinName => Inner.GetOperand<LiteralString>("mixinName") ?? default;

    public RefOpSDSLMixinInherit(RefInstruction instruction) => Inner = instruction;
    public RefOpSDSLMixinInherit(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSDSLCompose : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public LiteralString Mixin => Inner.GetOperand<LiteralString>("mixin") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public RefOpSDSLCompose(RefInstruction instruction) => Inner = instruction;
    public RefOpSDSLCompose(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSDSLStage : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef StagedElement => Inner.GetOperand<IdRef>("stagedElement") ?? default;

    public RefOpSDSLStage(RefInstruction instruction) => Inner = instruction;
    public RefOpSDSLStage(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSDSLImportFunction : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString FunctionName => Inner.GetOperand<LiteralString>("functionName") ?? default;
    public LiteralString MixinName => Inner.GetOperand<LiteralString>("mixinName") ?? default;
    public LiteralInteger Id => Inner.GetOperand<LiteralInteger>("id") ?? default;
    public LiteralInteger TypeId => Inner.GetOperand<LiteralInteger>("typeId") ?? default;

    public RefOpSDSLImportFunction(RefInstruction instruction) => Inner = instruction;
    public RefOpSDSLImportFunction(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSDSLImportVariable : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString VariableName => Inner.GetOperand<LiteralString>("variableName") ?? default;
    public LiteralString MixinName => Inner.GetOperand<LiteralString>("mixinName") ?? default;
    public LiteralInteger Id => Inner.GetOperand<LiteralInteger>("id") ?? default;

    public RefOpSDSLImportVariable(RefInstruction instruction) => Inner = instruction;
    public RefOpSDSLImportVariable(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSDSLImportIdRef : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString MixinName => Inner.GetOperand<LiteralString>("mixinName") ?? default;
    public LiteralInteger Id => Inner.GetOperand<LiteralInteger>("id") ?? default;

    public RefOpSDSLImportIdRef(RefInstruction instruction) => Inner = instruction;
    public RefOpSDSLImportIdRef(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSDSLMixinVariable : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef MixinId => Inner.GetOperand<IdRef>("mixinId") ?? default;
    public IdRef VariableId => Inner.GetOperand<IdRef>("variableId") ?? default;

    public RefOpSDSLMixinVariable(RefInstruction instruction) => Inner = instruction;
    public RefOpSDSLMixinVariable(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSDSLVariable : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;
    public IdRef Initializer => Inner.GetOperand<IdRef>("initializer") ?? default;

    public RefOpSDSLVariable(RefInstruction instruction) => Inner = instruction;
    public RefOpSDSLVariable(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSDSLFunctionParameter : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public RefOpSDSLFunctionParameter(RefInstruction instruction) => Inner = instruction;
    public RefOpSDSLFunctionParameter(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSDSLIOVariable : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");
    public ExecutionModel Executionmodel => Inner.GetEnumOperand<ExecutionModel>("executionmodel");
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;
    public LiteralString Semantic => Inner.GetOperand<LiteralString>("semantic") ?? default;
    public IdRef Initializer => Inner.GetOperand<IdRef>("initializer") ?? default;

    public RefOpSDSLIOVariable(RefInstruction instruction) => Inner = instruction;
    public RefOpSDSLIOVariable(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSDSLFunction : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public FunctionControlMask Functioncontrol => Inner.GetEnumOperand<FunctionControlMask>("functioncontrol");
    public IdRef FunctionType => Inner.GetOperand<IdRef>("functionType") ?? default;
    public LiteralString FunctionName => Inner.GetOperand<LiteralString>("functionName") ?? default;

    public RefOpSDSLFunction(RefInstruction instruction) => Inner = instruction;
    public RefOpSDSLFunction(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpNop : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }

    public RefOpNop(RefInstruction instruction) => Inner = instruction;
    public RefOpNop(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUndef : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpUndef(RefInstruction instruction) => Inner = instruction;
    public RefOpUndef(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSourceContinued : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public LiteralString ContinuedSource => Inner.GetOperand<LiteralString>("continuedSource") ?? default;

    public RefOpSourceContinued(RefInstruction instruction) => Inner = instruction;
    public RefOpSourceContinued(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSource : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public SourceLanguage Sourcelanguage => Inner.GetEnumOperand<SourceLanguage>("sourcelanguage");
    public LiteralInteger Version => Inner.GetOperand<LiteralInteger>("version") ?? default;
    public IdRef File => Inner.GetOperand<IdRef>("file") ?? default;
    public LiteralString Source => Inner.GetOperand<LiteralString>("source") ?? default;

    public RefOpSource(RefInstruction instruction) => Inner = instruction;
    public RefOpSource(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSourceExtension : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public LiteralString Extension => Inner.GetOperand<LiteralString>("extension") ?? default;

    public RefOpSourceExtension(RefInstruction instruction) => Inner = instruction;
    public RefOpSourceExtension(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpName : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public RefOpName(RefInstruction instruction) => Inner = instruction;
    public RefOpName(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpMemberName : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Type => Inner.GetOperand<IdRef>("type") ?? default;
    public LiteralInteger Member => Inner.GetOperand<LiteralInteger>("member") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public RefOpMemberName(RefInstruction instruction) => Inner = instruction;
    public RefOpMemberName(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpString : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString Value => Inner.GetOperand<LiteralString>("value") ?? default;

    public RefOpString(RefInstruction instruction) => Inner = instruction;
    public RefOpString(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpLine : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef File => Inner.GetOperand<IdRef>("file") ?? default;
    public LiteralInteger Line => Inner.GetOperand<LiteralInteger>("line") ?? default;
    public LiteralInteger Column => Inner.GetOperand<LiteralInteger>("column") ?? default;

    public RefOpLine(RefInstruction instruction) => Inner = instruction;
    public RefOpLine(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpExtension : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public RefOpExtension(RefInstruction instruction) => Inner = instruction;
    public RefOpExtension(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpExtInstImport : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public RefOpExtInstImport(RefInstruction instruction) => Inner = instruction;
    public RefOpExtInstImport(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpExtInst : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Set => Inner.GetOperand<IdRef>("set") ?? default;
    public LiteralInteger Instruction => Inner.GetOperand<LiteralInteger>("instruction") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpExtInst(RefInstruction instruction) => Inner = instruction;
    public RefOpExtInst(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpMemoryModel : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public AddressingModel Addressingmodel => Inner.GetEnumOperand<AddressingModel>("addressingmodel");
    public MemoryModel Memorymodel => Inner.GetEnumOperand<MemoryModel>("memorymodel");

    public RefOpMemoryModel(RefInstruction instruction) => Inner = instruction;
    public RefOpMemoryModel(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpEntryPoint : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public ExecutionModel Executionmodel => Inner.GetEnumOperand<ExecutionModel>("executionmodel");
    public IdRef EntryPoint => Inner.GetOperand<IdRef>("entryPoint") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpEntryPoint(RefInstruction instruction) => Inner = instruction;
    public RefOpEntryPoint(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpExecutionMode : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef EntryPoint => Inner.GetOperand<IdRef>("entryPoint") ?? default;
    public ExecutionMode Mode => Inner.GetEnumOperand<ExecutionMode>("mode");

    public RefOpExecutionMode(RefInstruction instruction) => Inner = instruction;
    public RefOpExecutionMode(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCapability : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public Capability Capability => Inner.GetEnumOperand<Capability>("capability");

    public RefOpCapability(RefInstruction instruction) => Inner = instruction;
    public RefOpCapability(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeVoid : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeVoid(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeVoid(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeBool : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeBool(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeBool(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeInt : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralInteger Width => Inner.GetOperand<LiteralInteger>("width") ?? default;
    public LiteralInteger Signedness => Inner.GetOperand<LiteralInteger>("signedness") ?? default;

    public RefOpTypeInt(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeInt(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeFloat : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralInteger Width => Inner.GetOperand<LiteralInteger>("width") ?? default;
    public FPEncoding FloatingPointEncoding => Inner.GetEnumOperand<FPEncoding>("floatingPointEncoding");

    public RefOpTypeFloat(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeFloat(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeVector : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ComponentType => Inner.GetOperand<IdRef>("componentType") ?? default;
    public LiteralInteger ComponentCount => Inner.GetOperand<LiteralInteger>("componentCount") ?? default;

    public RefOpTypeVector(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeVector(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeMatrix : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ColumnType => Inner.GetOperand<IdRef>("columnType") ?? default;
    public LiteralInteger ColumnCount => Inner.GetOperand<LiteralInteger>("columnCount") ?? default;

    public RefOpTypeMatrix(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeMatrix(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeImage : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledType => Inner.GetOperand<IdRef>("sampledType") ?? default;
    public Dim Dim => Inner.GetEnumOperand<Dim>("dim");
    public LiteralInteger Depth => Inner.GetOperand<LiteralInteger>("depth") ?? default;
    public LiteralInteger Arrayed => Inner.GetOperand<LiteralInteger>("arrayed") ?? default;
    public LiteralInteger MS => Inner.GetOperand<LiteralInteger>("mS") ?? default;
    public LiteralInteger Sampled => Inner.GetOperand<LiteralInteger>("sampled") ?? default;
    public ImageFormat Imageformat => Inner.GetEnumOperand<ImageFormat>("imageformat");
    public AccessQualifier Accessqualifier => Inner.GetEnumOperand<AccessQualifier>("accessqualifier");

    public RefOpTypeImage(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeImage(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeSampler : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeSampler(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeSampler(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeSampledImage : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ImageType => Inner.GetOperand<IdRef>("imageType") ?? default;

    public RefOpTypeSampledImage(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeSampledImage(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeArray : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ElementType => Inner.GetOperand<IdRef>("elementType") ?? default;
    public IdRef Length => Inner.GetOperand<IdRef>("length") ?? default;

    public RefOpTypeArray(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeArray(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeRuntimeArray : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ElementType => Inner.GetOperand<IdRef>("elementType") ?? default;

    public RefOpTypeRuntimeArray(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeRuntimeArray(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeStruct : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTypeStruct(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeStruct(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeOpaque : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString Thenameoftheopaquetype => Inner.GetOperand<LiteralString>("thenameoftheopaquetype") ?? default;

    public RefOpTypeOpaque(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeOpaque(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypePointer : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");
    public IdRef Type => Inner.GetOperand<IdRef>("type") ?? default;

    public RefOpTypePointer(RefInstruction instruction) => Inner = instruction;
    public RefOpTypePointer(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeFunction : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ReturnType => Inner.GetOperand<IdRef>("returnType") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTypeFunction(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeFunction(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeEvent : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeEvent(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeEvent(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeDeviceEvent : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeDeviceEvent(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeDeviceEvent(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeReserveId : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeReserveId(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeReserveId(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeQueue : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeQueue(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeQueue(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypePipe : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public AccessQualifier Qualifier => Inner.GetEnumOperand<AccessQualifier>("qualifier");

    public RefOpTypePipe(RefInstruction instruction) => Inner = instruction;
    public RefOpTypePipe(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeForwardPointer : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef PointerType => Inner.GetOperand<IdRef>("pointerType") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");

    public RefOpTypeForwardPointer(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeForwardPointer(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConstantTrue : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpConstantTrue(RefInstruction instruction) => Inner = instruction;
    public RefOpConstantTrue(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConstantFalse : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpConstantFalse(RefInstruction instruction) => Inner = instruction;
    public RefOpConstantFalse(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConstant : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpConstant(RefInstruction instruction) => Inner = instruction;
    public RefOpConstant(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConstantComposite : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpConstantComposite(RefInstruction instruction) => Inner = instruction;
    public RefOpConstantComposite(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConstantSampler : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public SamplerAddressingMode Sampleraddressingmode => Inner.GetEnumOperand<SamplerAddressingMode>("sampleraddressingmode");
    public LiteralInteger Param => Inner.GetOperand<LiteralInteger>("param") ?? default;
    public SamplerFilterMode Samplerfiltermode => Inner.GetEnumOperand<SamplerFilterMode>("samplerfiltermode");

    public RefOpConstantSampler(RefInstruction instruction) => Inner = instruction;
    public RefOpConstantSampler(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConstantNull : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpConstantNull(RefInstruction instruction) => Inner = instruction;
    public RefOpConstantNull(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSpecConstantTrue : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSpecConstantTrue(RefInstruction instruction) => Inner = instruction;
    public RefOpSpecConstantTrue(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSpecConstantFalse : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSpecConstantFalse(RefInstruction instruction) => Inner = instruction;
    public RefOpSpecConstantFalse(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSpecConstant : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSpecConstant(RefInstruction instruction) => Inner = instruction;
    public RefOpSpecConstant(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSpecConstantComposite : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpSpecConstantComposite(RefInstruction instruction) => Inner = instruction;
    public RefOpSpecConstantComposite(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSpecConstantOp : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralInteger Opcode => Inner.GetOperand<LiteralInteger>("opcode") ?? default;

    public RefOpSpecConstantOp(RefInstruction instruction) => Inner = instruction;
    public RefOpSpecConstantOp(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFunction : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public FunctionControlMask Functioncontrol => Inner.GetEnumOperand<FunctionControlMask>("functioncontrol");
    public IdRef FunctionType => Inner.GetOperand<IdRef>("functionType") ?? default;

    public RefOpFunction(RefInstruction instruction) => Inner = instruction;
    public RefOpFunction(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFunctionParameter : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpFunctionParameter(RefInstruction instruction) => Inner = instruction;
    public RefOpFunctionParameter(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFunctionEnd : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }

    public RefOpFunctionEnd(RefInstruction instruction) => Inner = instruction;
    public RefOpFunctionEnd(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFunctionCall : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Function => Inner.GetOperand<IdRef>("function") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpFunctionCall(RefInstruction instruction) => Inner = instruction;
    public RefOpFunctionCall(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpVariable : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");
    public IdRef Initializer => Inner.GetOperand<IdRef>("initializer") ?? default;

    public RefOpVariable(RefInstruction instruction) => Inner = instruction;
    public RefOpVariable(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageTexelPointer : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Sample => Inner.GetOperand<IdRef>("sample") ?? default;

    public RefOpImageTexelPointer(RefInstruction instruction) => Inner = instruction;
    public RefOpImageTexelPointer(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpLoad : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");

    public RefOpLoad(RefInstruction instruction) => Inner = instruction;
    public RefOpLoad(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpStore : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");

    public RefOpStore(RefInstruction instruction) => Inner = instruction;
    public RefOpStore(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCopyMemory : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public IdRef Source => Inner.GetOperand<IdRef>("source") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");
    public MemoryAccessMask Memoryaccess1 => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess1");

    public RefOpCopyMemory(RefInstruction instruction) => Inner = instruction;
    public RefOpCopyMemory(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCopyMemorySized : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public IdRef Source => Inner.GetOperand<IdRef>("source") ?? default;
    public IdRef Size => Inner.GetOperand<IdRef>("size") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");
    public MemoryAccessMask Memoryaccess1 => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess1");

    public RefOpCopyMemorySized(RefInstruction instruction) => Inner = instruction;
    public RefOpCopyMemorySized(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAccessChain : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpAccessChain(RefInstruction instruction) => Inner = instruction;
    public RefOpAccessChain(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpInBoundsAccessChain : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpInBoundsAccessChain(RefInstruction instruction) => Inner = instruction;
    public RefOpInBoundsAccessChain(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpPtrAccessChain : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Element => Inner.GetOperand<IdRef>("element") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpPtrAccessChain(RefInstruction instruction) => Inner = instruction;
    public RefOpPtrAccessChain(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArrayLength : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Structure => Inner.GetOperand<IdRef>("structure") ?? default;
    public LiteralInteger Arraymember => Inner.GetOperand<LiteralInteger>("arraymember") ?? default;

    public RefOpArrayLength(RefInstruction instruction) => Inner = instruction;
    public RefOpArrayLength(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGenericPtrMemSemantics : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public RefOpGenericPtrMemSemantics(RefInstruction instruction) => Inner = instruction;
    public RefOpGenericPtrMemSemantics(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpInBoundsPtrAccessChain : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Element => Inner.GetOperand<IdRef>("element") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpInBoundsPtrAccessChain(RefInstruction instruction) => Inner = instruction;
    public RefOpInBoundsPtrAccessChain(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpDecorate : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public Decoration Decoration => Inner.GetEnumOperand<Decoration>("decoration");

    public RefOpDecorate(RefInstruction instruction) => Inner = instruction;
    public RefOpDecorate(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpMemberDecorate : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef StructureType => Inner.GetOperand<IdRef>("structureType") ?? default;
    public LiteralInteger Member => Inner.GetOperand<LiteralInteger>("member") ?? default;
    public Decoration Decoration => Inner.GetEnumOperand<Decoration>("decoration");

    public RefOpMemberDecorate(RefInstruction instruction) => Inner = instruction;
    public RefOpMemberDecorate(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpDecorationGroup : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpDecorationGroup(RefInstruction instruction) => Inner = instruction;
    public RefOpDecorationGroup(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupDecorate : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef DecorationGroup => Inner.GetOperand<IdRef>("decorationGroup") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpGroupDecorate(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupDecorate(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupMemberDecorate : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef DecorationGroup => Inner.GetOperand<IdRef>("decorationGroup") ?? default;
    public PairIdRefLiteralInteger Values => Inner.GetOperand<PairIdRefLiteralInteger>("values") ?? default;

    public RefOpGroupMemberDecorate(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupMemberDecorate(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpVectorExtractDynamic : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;

    public RefOpVectorExtractDynamic(RefInstruction instruction) => Inner = instruction;
    public RefOpVectorExtractDynamic(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpVectorInsertDynamic : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;
    public IdRef Component => Inner.GetOperand<IdRef>("component") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;

    public RefOpVectorInsertDynamic(RefInstruction instruction) => Inner = instruction;
    public RefOpVectorInsertDynamic(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpVectorShuffle : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public RefOpVectorShuffle(RefInstruction instruction) => Inner = instruction;
    public RefOpVectorShuffle(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCompositeConstruct : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpCompositeConstruct(RefInstruction instruction) => Inner = instruction;
    public RefOpCompositeConstruct(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCompositeExtract : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Composite => Inner.GetOperand<IdRef>("composite") ?? default;
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public RefOpCompositeExtract(RefInstruction instruction) => Inner = instruction;
    public RefOpCompositeExtract(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCompositeInsert : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public IdRef Composite => Inner.GetOperand<IdRef>("composite") ?? default;
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public RefOpCompositeInsert(RefInstruction instruction) => Inner = instruction;
    public RefOpCompositeInsert(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCopyObject : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpCopyObject(RefInstruction instruction) => Inner = instruction;
    public RefOpCopyObject(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTranspose : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;

    public RefOpTranspose(RefInstruction instruction) => Inner = instruction;
    public RefOpTranspose(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSampledImage : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Sampler => Inner.GetOperand<IdRef>("sampler") ?? default;

    public RefOpSampledImage(RefInstruction instruction) => Inner = instruction;
    public RefOpSampledImage(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSampleImplicitLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleImplicitLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSampleImplicitLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSampleExplicitLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleExplicitLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSampleExplicitLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSampleDrefImplicitLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleDrefImplicitLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSampleDrefImplicitLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSampleDrefExplicitLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleDrefExplicitLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSampleDrefExplicitLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSampleProjImplicitLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleProjImplicitLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSampleProjImplicitLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSampleProjExplicitLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleProjExplicitLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSampleProjExplicitLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSampleProjDrefImplicitLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleProjDrefImplicitLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSampleProjDrefImplicitLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSampleProjDrefExplicitLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleProjDrefExplicitLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSampleProjDrefExplicitLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageFetch : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageFetch(RefInstruction instruction) => Inner = instruction;
    public RefOpImageFetch(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageGather : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Component => Inner.GetOperand<IdRef>("component") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageGather(RefInstruction instruction) => Inner = instruction;
    public RefOpImageGather(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageDrefGather : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageDrefGather(RefInstruction instruction) => Inner = instruction;
    public RefOpImageDrefGather(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageRead : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageRead(RefInstruction instruction) => Inner = instruction;
    public RefOpImageRead(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageWrite : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Texel => Inner.GetOperand<IdRef>("texel") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageWrite(RefInstruction instruction) => Inner = instruction;
    public RefOpImageWrite(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImage : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;

    public RefOpImage(RefInstruction instruction) => Inner = instruction;
    public RefOpImage(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageQueryFormat : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;

    public RefOpImageQueryFormat(RefInstruction instruction) => Inner = instruction;
    public RefOpImageQueryFormat(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageQueryOrder : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;

    public RefOpImageQueryOrder(RefInstruction instruction) => Inner = instruction;
    public RefOpImageQueryOrder(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageQuerySizeLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef LevelofDetail => Inner.GetOperand<IdRef>("levelofDetail") ?? default;

    public RefOpImageQuerySizeLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageQuerySizeLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageQuerySize : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;

    public RefOpImageQuerySize(RefInstruction instruction) => Inner = instruction;
    public RefOpImageQuerySize(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageQueryLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;

    public RefOpImageQueryLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageQueryLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageQueryLevels : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;

    public RefOpImageQueryLevels(RefInstruction instruction) => Inner = instruction;
    public RefOpImageQueryLevels(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageQuerySamples : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;

    public RefOpImageQuerySamples(RefInstruction instruction) => Inner = instruction;
    public RefOpImageQuerySamples(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConvertFToU : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef FloatValue => Inner.GetOperand<IdRef>("floatValue") ?? default;

    public RefOpConvertFToU(RefInstruction instruction) => Inner = instruction;
    public RefOpConvertFToU(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConvertFToS : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef FloatValue => Inner.GetOperand<IdRef>("floatValue") ?? default;

    public RefOpConvertFToS(RefInstruction instruction) => Inner = instruction;
    public RefOpConvertFToS(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConvertSToF : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SignedValue => Inner.GetOperand<IdRef>("signedValue") ?? default;

    public RefOpConvertSToF(RefInstruction instruction) => Inner = instruction;
    public RefOpConvertSToF(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConvertUToF : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef UnsignedValue => Inner.GetOperand<IdRef>("unsignedValue") ?? default;

    public RefOpConvertUToF(RefInstruction instruction) => Inner = instruction;
    public RefOpConvertUToF(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUConvert : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef UnsignedValue => Inner.GetOperand<IdRef>("unsignedValue") ?? default;

    public RefOpUConvert(RefInstruction instruction) => Inner = instruction;
    public RefOpUConvert(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSConvert : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SignedValue => Inner.GetOperand<IdRef>("signedValue") ?? default;

    public RefOpSConvert(RefInstruction instruction) => Inner = instruction;
    public RefOpSConvert(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFConvert : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef FloatValue => Inner.GetOperand<IdRef>("floatValue") ?? default;

    public RefOpFConvert(RefInstruction instruction) => Inner = instruction;
    public RefOpFConvert(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpQuantizeToF16 : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpQuantizeToF16(RefInstruction instruction) => Inner = instruction;
    public RefOpQuantizeToF16(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConvertPtrToU : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public RefOpConvertPtrToU(RefInstruction instruction) => Inner = instruction;
    public RefOpConvertPtrToU(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSatConvertSToU : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SignedValue => Inner.GetOperand<IdRef>("signedValue") ?? default;

    public RefOpSatConvertSToU(RefInstruction instruction) => Inner = instruction;
    public RefOpSatConvertSToU(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSatConvertUToS : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef UnsignedValue => Inner.GetOperand<IdRef>("unsignedValue") ?? default;

    public RefOpSatConvertUToS(RefInstruction instruction) => Inner = instruction;
    public RefOpSatConvertUToS(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConvertUToPtr : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef IntegerValue => Inner.GetOperand<IdRef>("integerValue") ?? default;

    public RefOpConvertUToPtr(RefInstruction instruction) => Inner = instruction;
    public RefOpConvertUToPtr(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpPtrCastToGeneric : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public RefOpPtrCastToGeneric(RefInstruction instruction) => Inner = instruction;
    public RefOpPtrCastToGeneric(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGenericCastToPtr : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public RefOpGenericCastToPtr(RefInstruction instruction) => Inner = instruction;
    public RefOpGenericCastToPtr(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGenericCastToPtrExplicit : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public StorageClass Storage => Inner.GetEnumOperand<StorageClass>("storage");

    public RefOpGenericCastToPtrExplicit(RefInstruction instruction) => Inner = instruction;
    public RefOpGenericCastToPtrExplicit(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpBitcast : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpBitcast(RefInstruction instruction) => Inner = instruction;
    public RefOpBitcast(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSNegate : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpSNegate(RefInstruction instruction) => Inner = instruction;
    public RefOpSNegate(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFNegate : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpFNegate(RefInstruction instruction) => Inner = instruction;
    public RefOpFNegate(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIAdd : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpIAdd(RefInstruction instruction) => Inner = instruction;
    public RefOpIAdd(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFAdd : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFAdd(RefInstruction instruction) => Inner = instruction;
    public RefOpFAdd(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpISub : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpISub(RefInstruction instruction) => Inner = instruction;
    public RefOpISub(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFSub : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFSub(RefInstruction instruction) => Inner = instruction;
    public RefOpFSub(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIMul : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpIMul(RefInstruction instruction) => Inner = instruction;
    public RefOpIMul(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFMul : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFMul(RefInstruction instruction) => Inner = instruction;
    public RefOpFMul(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUDiv : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUDiv(RefInstruction instruction) => Inner = instruction;
    public RefOpUDiv(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSDiv : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpSDiv(RefInstruction instruction) => Inner = instruction;
    public RefOpSDiv(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFDiv : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFDiv(RefInstruction instruction) => Inner = instruction;
    public RefOpFDiv(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUMod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUMod(RefInstruction instruction) => Inner = instruction;
    public RefOpUMod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSRem : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpSRem(RefInstruction instruction) => Inner = instruction;
    public RefOpSRem(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSMod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpSMod(RefInstruction instruction) => Inner = instruction;
    public RefOpSMod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFRem : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFRem(RefInstruction instruction) => Inner = instruction;
    public RefOpFRem(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFMod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFMod(RefInstruction instruction) => Inner = instruction;
    public RefOpFMod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpVectorTimesScalar : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;
    public IdRef Scalar => Inner.GetOperand<IdRef>("scalar") ?? default;

    public RefOpVectorTimesScalar(RefInstruction instruction) => Inner = instruction;
    public RefOpVectorTimesScalar(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpMatrixTimesScalar : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;
    public IdRef Scalar => Inner.GetOperand<IdRef>("scalar") ?? default;

    public RefOpMatrixTimesScalar(RefInstruction instruction) => Inner = instruction;
    public RefOpMatrixTimesScalar(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpVectorTimesMatrix : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;

    public RefOpVectorTimesMatrix(RefInstruction instruction) => Inner = instruction;
    public RefOpVectorTimesMatrix(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpMatrixTimesVector : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;

    public RefOpMatrixTimesVector(RefInstruction instruction) => Inner = instruction;
    public RefOpMatrixTimesVector(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpMatrixTimesMatrix : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef LeftMatrix => Inner.GetOperand<IdRef>("leftMatrix") ?? default;
    public IdRef RightMatrix => Inner.GetOperand<IdRef>("rightMatrix") ?? default;

    public RefOpMatrixTimesMatrix(RefInstruction instruction) => Inner = instruction;
    public RefOpMatrixTimesMatrix(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpOuterProduct : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;

    public RefOpOuterProduct(RefInstruction instruction) => Inner = instruction;
    public RefOpOuterProduct(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpDot : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;

    public RefOpDot(RefInstruction instruction) => Inner = instruction;
    public RefOpDot(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIAddCarry : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpIAddCarry(RefInstruction instruction) => Inner = instruction;
    public RefOpIAddCarry(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpISubBorrow : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpISubBorrow(RefInstruction instruction) => Inner = instruction;
    public RefOpISubBorrow(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUMulExtended : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUMulExtended(RefInstruction instruction) => Inner = instruction;
    public RefOpUMulExtended(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSMulExtended : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpSMulExtended(RefInstruction instruction) => Inner = instruction;
    public RefOpSMulExtended(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAny : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;

    public RefOpAny(RefInstruction instruction) => Inner = instruction;
    public RefOpAny(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAll : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector => Inner.GetOperand<IdRef>("vector") ?? default;

    public RefOpAll(RefInstruction instruction) => Inner = instruction;
    public RefOpAll(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIsNan : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpIsNan(RefInstruction instruction) => Inner = instruction;
    public RefOpIsNan(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIsInf : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpIsInf(RefInstruction instruction) => Inner = instruction;
    public RefOpIsInf(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIsFinite : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpIsFinite(RefInstruction instruction) => Inner = instruction;
    public RefOpIsFinite(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIsNormal : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpIsNormal(RefInstruction instruction) => Inner = instruction;
    public RefOpIsNormal(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSignBitSet : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpSignBitSet(RefInstruction instruction) => Inner = instruction;
    public RefOpSignBitSet(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpLessOrGreater : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefOpLessOrGreater(RefInstruction instruction) => Inner = instruction;
    public RefOpLessOrGreater(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpOrdered : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefOpOrdered(RefInstruction instruction) => Inner = instruction;
    public RefOpOrdered(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUnordered : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefOpUnordered(RefInstruction instruction) => Inner = instruction;
    public RefOpUnordered(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpLogicalEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpLogicalEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpLogicalEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpLogicalNotEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpLogicalNotEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpLogicalNotEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpLogicalOr : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpLogicalOr(RefInstruction instruction) => Inner = instruction;
    public RefOpLogicalOr(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpLogicalAnd : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpLogicalAnd(RefInstruction instruction) => Inner = instruction;
    public RefOpLogicalAnd(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpLogicalNot : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpLogicalNot(RefInstruction instruction) => Inner = instruction;
    public RefOpLogicalNot(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSelect : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Condition => Inner.GetOperand<IdRef>("condition") ?? default;
    public IdRef Object1 => Inner.GetOperand<IdRef>("object1") ?? default;
    public IdRef Object2 => Inner.GetOperand<IdRef>("object2") ?? default;

    public RefOpSelect(RefInstruction instruction) => Inner = instruction;
    public RefOpSelect(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpIEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpIEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpINotEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpINotEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpINotEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUGreaterThan : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUGreaterThan(RefInstruction instruction) => Inner = instruction;
    public RefOpUGreaterThan(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSGreaterThan : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpSGreaterThan(RefInstruction instruction) => Inner = instruction;
    public RefOpSGreaterThan(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUGreaterThanEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUGreaterThanEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpUGreaterThanEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSGreaterThanEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpSGreaterThanEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpSGreaterThanEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpULessThan : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpULessThan(RefInstruction instruction) => Inner = instruction;
    public RefOpULessThan(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSLessThan : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpSLessThan(RefInstruction instruction) => Inner = instruction;
    public RefOpSLessThan(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpULessThanEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpULessThanEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpULessThanEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSLessThanEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpSLessThanEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpSLessThanEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFOrdEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFOrdEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpFOrdEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFUnordEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFUnordEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpFUnordEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFOrdNotEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFOrdNotEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpFOrdNotEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFUnordNotEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFUnordNotEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpFUnordNotEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFOrdLessThan : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFOrdLessThan(RefInstruction instruction) => Inner = instruction;
    public RefOpFOrdLessThan(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFUnordLessThan : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFUnordLessThan(RefInstruction instruction) => Inner = instruction;
    public RefOpFUnordLessThan(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFOrdGreaterThan : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFOrdGreaterThan(RefInstruction instruction) => Inner = instruction;
    public RefOpFOrdGreaterThan(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFUnordGreaterThan : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFUnordGreaterThan(RefInstruction instruction) => Inner = instruction;
    public RefOpFUnordGreaterThan(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFOrdLessThanEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFOrdLessThanEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpFOrdLessThanEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFUnordLessThanEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFUnordLessThanEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpFUnordLessThanEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFOrdGreaterThanEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFOrdGreaterThanEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpFOrdGreaterThanEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFUnordGreaterThanEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpFUnordGreaterThanEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpFUnordGreaterThanEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpShiftRightLogical : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Shift => Inner.GetOperand<IdRef>("shift") ?? default;

    public RefOpShiftRightLogical(RefInstruction instruction) => Inner = instruction;
    public RefOpShiftRightLogical(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpShiftRightArithmetic : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Shift => Inner.GetOperand<IdRef>("shift") ?? default;

    public RefOpShiftRightArithmetic(RefInstruction instruction) => Inner = instruction;
    public RefOpShiftRightArithmetic(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpShiftLeftLogical : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Shift => Inner.GetOperand<IdRef>("shift") ?? default;

    public RefOpShiftLeftLogical(RefInstruction instruction) => Inner = instruction;
    public RefOpShiftLeftLogical(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpBitwiseOr : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpBitwiseOr(RefInstruction instruction) => Inner = instruction;
    public RefOpBitwiseOr(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpBitwiseXor : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpBitwiseXor(RefInstruction instruction) => Inner = instruction;
    public RefOpBitwiseXor(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpBitwiseAnd : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpBitwiseAnd(RefInstruction instruction) => Inner = instruction;
    public RefOpBitwiseAnd(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpNot : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpNot(RefInstruction instruction) => Inner = instruction;
    public RefOpNot(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpBitFieldInsert : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Insert => Inner.GetOperand<IdRef>("insert") ?? default;
    public IdRef Offset => Inner.GetOperand<IdRef>("offset") ?? default;
    public IdRef Count => Inner.GetOperand<IdRef>("count") ?? default;

    public RefOpBitFieldInsert(RefInstruction instruction) => Inner = instruction;
    public RefOpBitFieldInsert(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpBitFieldSExtract : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Offset => Inner.GetOperand<IdRef>("offset") ?? default;
    public IdRef Count => Inner.GetOperand<IdRef>("count") ?? default;

    public RefOpBitFieldSExtract(RefInstruction instruction) => Inner = instruction;
    public RefOpBitFieldSExtract(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpBitFieldUExtract : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Offset => Inner.GetOperand<IdRef>("offset") ?? default;
    public IdRef Count => Inner.GetOperand<IdRef>("count") ?? default;

    public RefOpBitFieldUExtract(RefInstruction instruction) => Inner = instruction;
    public RefOpBitFieldUExtract(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpBitReverse : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;

    public RefOpBitReverse(RefInstruction instruction) => Inner = instruction;
    public RefOpBitReverse(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpBitCount : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;

    public RefOpBitCount(RefInstruction instruction) => Inner = instruction;
    public RefOpBitCount(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpDPdx : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpDPdx(RefInstruction instruction) => Inner = instruction;
    public RefOpDPdx(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpDPdy : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpDPdy(RefInstruction instruction) => Inner = instruction;
    public RefOpDPdy(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFwidth : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpFwidth(RefInstruction instruction) => Inner = instruction;
    public RefOpFwidth(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpDPdxFine : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpDPdxFine(RefInstruction instruction) => Inner = instruction;
    public RefOpDPdxFine(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpDPdyFine : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpDPdyFine(RefInstruction instruction) => Inner = instruction;
    public RefOpDPdyFine(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFwidthFine : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpFwidthFine(RefInstruction instruction) => Inner = instruction;
    public RefOpFwidthFine(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpDPdxCoarse : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpDPdxCoarse(RefInstruction instruction) => Inner = instruction;
    public RefOpDPdxCoarse(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpDPdyCoarse : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpDPdyCoarse(RefInstruction instruction) => Inner = instruction;
    public RefOpDPdyCoarse(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFwidthCoarse : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefOpFwidthCoarse(RefInstruction instruction) => Inner = instruction;
    public RefOpFwidthCoarse(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpEmitVertex : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }

    public RefOpEmitVertex(RefInstruction instruction) => Inner = instruction;
    public RefOpEmitVertex(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpEndPrimitive : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }

    public RefOpEndPrimitive(RefInstruction instruction) => Inner = instruction;
    public RefOpEndPrimitive(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpEmitStreamVertex : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Stream => Inner.GetOperand<IdRef>("stream") ?? default;

    public RefOpEmitStreamVertex(RefInstruction instruction) => Inner = instruction;
    public RefOpEmitStreamVertex(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpEndStreamPrimitive : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Stream => Inner.GetOperand<IdRef>("stream") ?? default;

    public RefOpEndStreamPrimitive(RefInstruction instruction) => Inner = instruction;
    public RefOpEndStreamPrimitive(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpControlBarrier : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpControlBarrier(RefInstruction instruction) => Inner = instruction;
    public RefOpControlBarrier(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpMemoryBarrier : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpMemoryBarrier(RefInstruction instruction) => Inner = instruction;
    public RefOpMemoryBarrier(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicLoad : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpAtomicLoad(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicLoad(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicStore : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicStore(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicStore(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicExchange : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicExchange(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicExchange(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicCompareExchange : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Equal => Inner.GetOperand<IdMemorySemantics>("equal") ?? default;
    public IdMemorySemantics Unequal => Inner.GetOperand<IdMemorySemantics>("unequal") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Comparator => Inner.GetOperand<IdRef>("comparator") ?? default;

    public RefOpAtomicCompareExchange(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicCompareExchange(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicCompareExchangeWeak : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Equal => Inner.GetOperand<IdMemorySemantics>("equal") ?? default;
    public IdMemorySemantics Unequal => Inner.GetOperand<IdMemorySemantics>("unequal") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Comparator => Inner.GetOperand<IdRef>("comparator") ?? default;

    public RefOpAtomicCompareExchangeWeak(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicCompareExchangeWeak(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicIIncrement : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpAtomicIIncrement(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicIIncrement(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicIDecrement : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpAtomicIDecrement(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicIDecrement(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicIAdd : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicIAdd(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicIAdd(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicISub : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicISub(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicISub(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicSMin : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicSMin(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicSMin(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicUMin : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicUMin(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicUMin(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicSMax : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicSMax(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicSMax(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicUMax : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicUMax(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicUMax(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicAnd : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicAnd(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicAnd(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicOr : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicOr(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicOr(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicXor : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicXor(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicXor(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpPhi : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public PairIdRefIdRef Values => Inner.GetOperand<PairIdRefIdRef>("values") ?? default;

    public RefOpPhi(RefInstruction instruction) => Inner = instruction;
    public RefOpPhi(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpLoopMerge : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef MergeBlock => Inner.GetOperand<IdRef>("mergeBlock") ?? default;
    public IdRef ContinueTarget => Inner.GetOperand<IdRef>("continueTarget") ?? default;
    public LoopControlMask Loopcontrol => Inner.GetEnumOperand<LoopControlMask>("loopcontrol");

    public RefOpLoopMerge(RefInstruction instruction) => Inner = instruction;
    public RefOpLoopMerge(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSelectionMerge : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef MergeBlock => Inner.GetOperand<IdRef>("mergeBlock") ?? default;
    public SelectionControlMask Selectioncontrol => Inner.GetEnumOperand<SelectionControlMask>("selectioncontrol");

    public RefOpSelectionMerge(RefInstruction instruction) => Inner = instruction;
    public RefOpSelectionMerge(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpLabel : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpLabel(RefInstruction instruction) => Inner = instruction;
    public RefOpLabel(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpBranch : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef TargetLabel => Inner.GetOperand<IdRef>("targetLabel") ?? default;

    public RefOpBranch(RefInstruction instruction) => Inner = instruction;
    public RefOpBranch(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpBranchConditional : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Condition => Inner.GetOperand<IdRef>("condition") ?? default;
    public IdRef TrueLabel => Inner.GetOperand<IdRef>("trueLabel") ?? default;
    public IdRef FalseLabel => Inner.GetOperand<IdRef>("falseLabel") ?? default;
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public RefOpBranchConditional(RefInstruction instruction) => Inner = instruction;
    public RefOpBranchConditional(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSwitch : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Selector => Inner.GetOperand<IdRef>("selector") ?? default;
    public IdRef DefaultId => Inner.GetOperand<IdRef>("defaultId") ?? default;
    public PairLiteralIntegerIdRef Values => Inner.GetOperand<PairLiteralIntegerIdRef>("values") ?? default;

    public RefOpSwitch(RefInstruction instruction) => Inner = instruction;
    public RefOpSwitch(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpKill : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }

    public RefOpKill(RefInstruction instruction) => Inner = instruction;
    public RefOpKill(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpReturn : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }

    public RefOpReturn(RefInstruction instruction) => Inner = instruction;
    public RefOpReturn(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpReturnValue : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpReturnValue(RefInstruction instruction) => Inner = instruction;
    public RefOpReturnValue(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUnreachable : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }

    public RefOpUnreachable(RefInstruction instruction) => Inner = instruction;
    public RefOpUnreachable(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpLifetimeStart : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public LiteralInteger Size => Inner.GetOperand<LiteralInteger>("size") ?? default;

    public RefOpLifetimeStart(RefInstruction instruction) => Inner = instruction;
    public RefOpLifetimeStart(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpLifetimeStop : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public LiteralInteger Size => Inner.GetOperand<LiteralInteger>("size") ?? default;

    public RefOpLifetimeStop(RefInstruction instruction) => Inner = instruction;
    public RefOpLifetimeStop(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupAsyncCopy : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Destination => Inner.GetOperand<IdRef>("destination") ?? default;
    public IdRef Source => Inner.GetOperand<IdRef>("source") ?? default;
    public IdRef NumElements => Inner.GetOperand<IdRef>("numElements") ?? default;
    public IdRef Stride => Inner.GetOperand<IdRef>("stride") ?? default;
    public IdRef EventId => Inner.GetOperand<IdRef>("eventId") ?? default;

    public RefOpGroupAsyncCopy(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupAsyncCopy(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupWaitEvents : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef NumEvents => Inner.GetOperand<IdRef>("numEvents") ?? default;
    public IdRef EventsList => Inner.GetOperand<IdRef>("eventsList") ?? default;

    public RefOpGroupWaitEvents(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupWaitEvents(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupAll : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpGroupAll(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupAll(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupAny : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpGroupAny(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupAny(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupBroadcast : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef LocalId => Inner.GetOperand<IdRef>("localId") ?? default;

    public RefOpGroupBroadcast(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupBroadcast(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupIAdd : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupIAdd(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupIAdd(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupFAdd : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupFAdd(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupFAdd(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupFMin : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupFMin(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupFMin(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupUMin : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupUMin(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupUMin(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupSMin : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupSMin(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupSMin(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupFMax : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupFMax(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupFMax(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupUMax : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupUMax(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupUMax(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupSMax : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupSMax(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupSMax(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpReadPipe : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpReadPipe(RefInstruction instruction) => Inner = instruction;
    public RefOpReadPipe(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpWritePipe : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpWritePipe(RefInstruction instruction) => Inner = instruction;
    public RefOpWritePipe(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpReservedReadPipe : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpReservedReadPipe(RefInstruction instruction) => Inner = instruction;
    public RefOpReservedReadPipe(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpReservedWritePipe : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpReservedWritePipe(RefInstruction instruction) => Inner = instruction;
    public RefOpReservedWritePipe(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpReserveReadPipePackets : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef NumPackets => Inner.GetOperand<IdRef>("numPackets") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpReserveReadPipePackets(RefInstruction instruction) => Inner = instruction;
    public RefOpReserveReadPipePackets(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpReserveWritePipePackets : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef NumPackets => Inner.GetOperand<IdRef>("numPackets") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpReserveWritePipePackets(RefInstruction instruction) => Inner = instruction;
    public RefOpReserveWritePipePackets(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCommitReadPipe : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpCommitReadPipe(RefInstruction instruction) => Inner = instruction;
    public RefOpCommitReadPipe(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCommitWritePipe : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpCommitWritePipe(RefInstruction instruction) => Inner = instruction;
    public RefOpCommitWritePipe(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIsValidReserveId : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;

    public RefOpIsValidReserveId(RefInstruction instruction) => Inner = instruction;
    public RefOpIsValidReserveId(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGetNumPipePackets : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpGetNumPipePackets(RefInstruction instruction) => Inner = instruction;
    public RefOpGetNumPipePackets(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGetMaxPipePackets : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpGetMaxPipePackets(RefInstruction instruction) => Inner = instruction;
    public RefOpGetMaxPipePackets(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupReserveReadPipePackets : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef NumPackets => Inner.GetOperand<IdRef>("numPackets") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpGroupReserveReadPipePackets(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupReserveReadPipePackets(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupReserveWritePipePackets : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef NumPackets => Inner.GetOperand<IdRef>("numPackets") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpGroupReserveWritePipePackets(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupReserveWritePipePackets(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupCommitReadPipe : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpGroupCommitReadPipe(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupCommitReadPipe(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupCommitWritePipe : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Pipe => Inner.GetOperand<IdRef>("pipe") ?? default;
    public IdRef ReserveId => Inner.GetOperand<IdRef>("reserveId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpGroupCommitWritePipe(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupCommitWritePipe(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpEnqueueMarker : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Queue => Inner.GetOperand<IdRef>("queue") ?? default;
    public IdRef NumEvents => Inner.GetOperand<IdRef>("numEvents") ?? default;
    public IdRef WaitEvents => Inner.GetOperand<IdRef>("waitEvents") ?? default;
    public IdRef RetEvent => Inner.GetOperand<IdRef>("retEvent") ?? default;

    public RefOpEnqueueMarker(RefInstruction instruction) => Inner = instruction;
    public RefOpEnqueueMarker(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpEnqueueKernel : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpEnqueueKernel(RefInstruction instruction) => Inner = instruction;
    public RefOpEnqueueKernel(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGetKernelNDrangeSubGroupCount : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef NDRange => Inner.GetOperand<IdRef>("nDRange") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public RefOpGetKernelNDrangeSubGroupCount(RefInstruction instruction) => Inner = instruction;
    public RefOpGetKernelNDrangeSubGroupCount(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGetKernelNDrangeMaxSubGroupSize : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef NDRange => Inner.GetOperand<IdRef>("nDRange") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public RefOpGetKernelNDrangeMaxSubGroupSize(RefInstruction instruction) => Inner = instruction;
    public RefOpGetKernelNDrangeMaxSubGroupSize(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGetKernelWorkGroupSize : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public RefOpGetKernelWorkGroupSize(RefInstruction instruction) => Inner = instruction;
    public RefOpGetKernelWorkGroupSize(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGetKernelPreferredWorkGroupSizeMultiple : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public RefOpGetKernelPreferredWorkGroupSizeMultiple(RefInstruction instruction) => Inner = instruction;
    public RefOpGetKernelPreferredWorkGroupSizeMultiple(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRetainEvent : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef EventId => Inner.GetOperand<IdRef>("eventId") ?? default;

    public RefOpRetainEvent(RefInstruction instruction) => Inner = instruction;
    public RefOpRetainEvent(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpReleaseEvent : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef EventId => Inner.GetOperand<IdRef>("eventId") ?? default;

    public RefOpReleaseEvent(RefInstruction instruction) => Inner = instruction;
    public RefOpReleaseEvent(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCreateUserEvent : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpCreateUserEvent(RefInstruction instruction) => Inner = instruction;
    public RefOpCreateUserEvent(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIsValidEvent : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef EventId => Inner.GetOperand<IdRef>("eventId") ?? default;

    public RefOpIsValidEvent(RefInstruction instruction) => Inner = instruction;
    public RefOpIsValidEvent(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSetUserEventStatus : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef EventId => Inner.GetOperand<IdRef>("eventId") ?? default;
    public IdRef Status => Inner.GetOperand<IdRef>("status") ?? default;

    public RefOpSetUserEventStatus(RefInstruction instruction) => Inner = instruction;
    public RefOpSetUserEventStatus(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCaptureEventProfilingInfo : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef EventId => Inner.GetOperand<IdRef>("eventId") ?? default;
    public IdRef ProfilingInfo => Inner.GetOperand<IdRef>("profilingInfo") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpCaptureEventProfilingInfo(RefInstruction instruction) => Inner = instruction;
    public RefOpCaptureEventProfilingInfo(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGetDefaultQueue : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpGetDefaultQueue(RefInstruction instruction) => Inner = instruction;
    public RefOpGetDefaultQueue(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpBuildNDRange : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef GlobalWorkSize => Inner.GetOperand<IdRef>("globalWorkSize") ?? default;
    public IdRef LocalWorkSize => Inner.GetOperand<IdRef>("localWorkSize") ?? default;
    public IdRef GlobalWorkOffset => Inner.GetOperand<IdRef>("globalWorkOffset") ?? default;

    public RefOpBuildNDRange(RefInstruction instruction) => Inner = instruction;
    public RefOpBuildNDRange(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSparseSampleImplicitLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseSampleImplicitLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSparseSampleImplicitLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSparseSampleExplicitLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseSampleExplicitLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSparseSampleExplicitLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSparseSampleDrefImplicitLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseSampleDrefImplicitLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSparseSampleDrefImplicitLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSparseSampleDrefExplicitLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseSampleDrefExplicitLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSparseSampleDrefExplicitLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSparseSampleProjImplicitLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseSampleProjImplicitLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSparseSampleProjImplicitLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSparseSampleProjExplicitLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseSampleProjExplicitLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSparseSampleProjExplicitLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSparseSampleProjDrefImplicitLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseSampleProjDrefImplicitLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSparseSampleProjDrefImplicitLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSparseSampleProjDrefExplicitLod : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseSampleProjDrefExplicitLod(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSparseSampleProjDrefExplicitLod(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSparseFetch : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseFetch(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSparseFetch(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSparseGather : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Component => Inner.GetOperand<IdRef>("component") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseGather(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSparseGather(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSparseDrefGather : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Dref => Inner.GetOperand<IdRef>("dref") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseDrefGather(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSparseDrefGather(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSparseTexelsResident : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ResidentCode => Inner.GetOperand<IdRef>("residentCode") ?? default;

    public RefOpImageSparseTexelsResident(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSparseTexelsResident(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpNoLine : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }

    public RefOpNoLine(RefInstruction instruction) => Inner = instruction;
    public RefOpNoLine(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicFlagTestAndSet : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpAtomicFlagTestAndSet(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicFlagTestAndSet(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicFlagClear : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpAtomicFlagClear(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicFlagClear(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSparseRead : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSparseRead(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSparseRead(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSizeOf : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public RefOpSizeOf(RefInstruction instruction) => Inner = instruction;
    public RefOpSizeOf(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypePipeStorage : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypePipeStorage(RefInstruction instruction) => Inner = instruction;
    public RefOpTypePipeStorage(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConstantPipeStorage : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralInteger PacketSize => Inner.GetOperand<LiteralInteger>("packetSize") ?? default;
    public LiteralInteger PacketAlignment => Inner.GetOperand<LiteralInteger>("packetAlignment") ?? default;
    public LiteralInteger Capacity => Inner.GetOperand<LiteralInteger>("capacity") ?? default;

    public RefOpConstantPipeStorage(RefInstruction instruction) => Inner = instruction;
    public RefOpConstantPipeStorage(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCreatePipeFromPipeStorage : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PipeStorage => Inner.GetOperand<IdRef>("pipeStorage") ?? default;

    public RefOpCreatePipeFromPipeStorage(RefInstruction instruction) => Inner = instruction;
    public RefOpCreatePipeFromPipeStorage(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGetKernelLocalSizeForSubgroupCount : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SubgroupCount => Inner.GetOperand<IdRef>("subgroupCount") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public RefOpGetKernelLocalSizeForSubgroupCount(RefInstruction instruction) => Inner = instruction;
    public RefOpGetKernelLocalSizeForSubgroupCount(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGetKernelMaxNumSubgroups : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Invoke => Inner.GetOperand<IdRef>("invoke") ?? default;
    public IdRef Param => Inner.GetOperand<IdRef>("param") ?? default;
    public IdRef ParamSize => Inner.GetOperand<IdRef>("paramSize") ?? default;
    public IdRef ParamAlign => Inner.GetOperand<IdRef>("paramAlign") ?? default;

    public RefOpGetKernelMaxNumSubgroups(RefInstruction instruction) => Inner = instruction;
    public RefOpGetKernelMaxNumSubgroups(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeNamedBarrier : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeNamedBarrier(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeNamedBarrier(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpNamedBarrierInitialize : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SubgroupCount => Inner.GetOperand<IdRef>("subgroupCount") ?? default;

    public RefOpNamedBarrierInitialize(RefInstruction instruction) => Inner = instruction;
    public RefOpNamedBarrierInitialize(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpMemoryNamedBarrier : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef NamedBarrier => Inner.GetOperand<IdRef>("namedBarrier") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpMemoryNamedBarrier(RefInstruction instruction) => Inner = instruction;
    public RefOpMemoryNamedBarrier(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpModuleProcessed : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public LiteralString Process => Inner.GetOperand<LiteralString>("process") ?? default;

    public RefOpModuleProcessed(RefInstruction instruction) => Inner = instruction;
    public RefOpModuleProcessed(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpExecutionModeId : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef EntryPoint => Inner.GetOperand<IdRef>("entryPoint") ?? default;
    public ExecutionMode Mode => Inner.GetEnumOperand<ExecutionMode>("mode");

    public RefOpExecutionModeId(RefInstruction instruction) => Inner = instruction;
    public RefOpExecutionModeId(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpDecorateId : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public Decoration Decoration => Inner.GetEnumOperand<Decoration>("decoration");

    public RefOpDecorateId(RefInstruction instruction) => Inner = instruction;
    public RefOpDecorateId(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformElect : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;

    public RefOpGroupNonUniformElect(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformElect(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformAll : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpGroupNonUniformAll(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformAll(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformAny : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpGroupNonUniformAny(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformAny(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformAllEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpGroupNonUniformAllEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformAllEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformBroadcast : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Id => Inner.GetOperand<IdRef>("id") ?? default;

    public RefOpGroupNonUniformBroadcast(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformBroadcast(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformBroadcastFirst : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpGroupNonUniformBroadcastFirst(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformBroadcastFirst(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformBallot : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpGroupNonUniformBallot(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformBallot(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformInverseBallot : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpGroupNonUniformInverseBallot(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformInverseBallot(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformBallotBitExtract : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;

    public RefOpGroupNonUniformBallotBitExtract(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformBallotBitExtract(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformBallotBitCount : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpGroupNonUniformBallotBitCount(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformBallotBitCount(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformBallotFindLSB : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpGroupNonUniformBallotFindLSB(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformBallotFindLSB(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformBallotFindMSB : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpGroupNonUniformBallotFindMSB(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformBallotFindMSB(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformShuffle : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Id => Inner.GetOperand<IdRef>("id") ?? default;

    public RefOpGroupNonUniformShuffle(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformShuffle(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformShuffleXor : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Mask => Inner.GetOperand<IdRef>("mask") ?? default;

    public RefOpGroupNonUniformShuffleXor(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformShuffleXor(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformShuffleUp : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Delta => Inner.GetOperand<IdRef>("delta") ?? default;

    public RefOpGroupNonUniformShuffleUp(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformShuffleUp(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformShuffleDown : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Delta => Inner.GetOperand<IdRef>("delta") ?? default;

    public RefOpGroupNonUniformShuffleDown(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformShuffleDown(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformIAdd : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformIAdd(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformIAdd(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformFAdd : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformFAdd(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformFAdd(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformIMul : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformIMul(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformIMul(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformFMul : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformFMul(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformFMul(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformSMin : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformSMin(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformSMin(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformUMin : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformUMin(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformUMin(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformFMin : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformFMin(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformFMin(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformSMax : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformSMax(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformSMax(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformUMax : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformUMax(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformUMax(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformFMax : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformFMax(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformFMax(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformBitwiseAnd : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformBitwiseAnd(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformBitwiseAnd(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformBitwiseOr : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformBitwiseOr(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformBitwiseOr(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformBitwiseXor : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformBitwiseXor(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformBitwiseXor(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformLogicalAnd : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformLogicalAnd(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformLogicalAnd(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformLogicalOr : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformLogicalOr(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformLogicalOr(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformLogicalXor : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformLogicalXor(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformLogicalXor(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformQuadBroadcast : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;

    public RefOpGroupNonUniformQuadBroadcast(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformQuadBroadcast(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformQuadSwap : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;

    public RefOpGroupNonUniformQuadSwap(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformQuadSwap(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCopyLogical : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpCopyLogical(RefInstruction instruction) => Inner = instruction;
    public RefOpCopyLogical(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpPtrEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpPtrEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpPtrEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpPtrNotEqual : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpPtrNotEqual(RefInstruction instruction) => Inner = instruction;
    public RefOpPtrNotEqual(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpPtrDiff : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpPtrDiff(RefInstruction instruction) => Inner = instruction;
    public RefOpPtrDiff(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpColorAttachmentReadEXT : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Attachment => Inner.GetOperand<IdRef>("attachment") ?? default;
    public IdRef Sample => Inner.GetOperand<IdRef>("sample") ?? default;

    public RefOpColorAttachmentReadEXT(RefInstruction instruction) => Inner = instruction;
    public RefOpColorAttachmentReadEXT(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpDepthAttachmentReadEXT : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Sample => Inner.GetOperand<IdRef>("sample") ?? default;

    public RefOpDepthAttachmentReadEXT(RefInstruction instruction) => Inner = instruction;
    public RefOpDepthAttachmentReadEXT(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpStencilAttachmentReadEXT : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Sample => Inner.GetOperand<IdRef>("sample") ?? default;

    public RefOpStencilAttachmentReadEXT(RefInstruction instruction) => Inner = instruction;
    public RefOpStencilAttachmentReadEXT(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTerminateInvocation : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }

    public RefOpTerminateInvocation(RefInstruction instruction) => Inner = instruction;
    public RefOpTerminateInvocation(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeUntypedPointerKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");

    public RefOpTypeUntypedPointerKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeUntypedPointerKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUntypedVariableKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public StorageClass Storageclass => Inner.GetEnumOperand<StorageClass>("storageclass");
    public IdRef DataType => Inner.GetOperand<IdRef>("dataType") ?? default;
    public IdRef Initializer => Inner.GetOperand<IdRef>("initializer") ?? default;

    public RefOpUntypedVariableKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpUntypedVariableKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUntypedAccessChainKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseType => Inner.GetOperand<IdRef>("baseType") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpUntypedAccessChainKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpUntypedAccessChainKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUntypedInBoundsAccessChainKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseType => Inner.GetOperand<IdRef>("baseType") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpUntypedInBoundsAccessChainKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpUntypedInBoundsAccessChainKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupBallotKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpSubgroupBallotKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupBallotKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupFirstInvocationKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpSubgroupFirstInvocationKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupFirstInvocationKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUntypedPtrAccessChainKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseType => Inner.GetOperand<IdRef>("baseType") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Element => Inner.GetOperand<IdRef>("element") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpUntypedPtrAccessChainKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpUntypedPtrAccessChainKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUntypedInBoundsPtrAccessChainKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseType => Inner.GetOperand<IdRef>("baseType") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Element => Inner.GetOperand<IdRef>("element") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpUntypedInBoundsPtrAccessChainKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpUntypedInBoundsPtrAccessChainKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUntypedArrayLengthKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Structure => Inner.GetOperand<IdRef>("structure") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public LiteralInteger Arraymember => Inner.GetOperand<LiteralInteger>("arraymember") ?? default;

    public RefOpUntypedArrayLengthKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpUntypedArrayLengthKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUntypedPrefetchKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef PointerType => Inner.GetOperand<IdRef>("pointerType") ?? default;
    public IdRef NumBytes => Inner.GetOperand<IdRef>("numBytes") ?? default;
    public IdRef RW => Inner.GetOperand<IdRef>("rW") ?? default;
    public IdRef Locality => Inner.GetOperand<IdRef>("locality") ?? default;
    public IdRef CacheType => Inner.GetOperand<IdRef>("cacheType") ?? default;

    public RefOpUntypedPrefetchKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpUntypedPrefetchKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAllKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpSubgroupAllKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAllKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAnyKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpSubgroupAnyKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAnyKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAllEqualKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpSubgroupAllEqualKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAllEqualKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformRotateKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Delta => Inner.GetOperand<IdRef>("delta") ?? default;
    public IdRef ClusterSize => Inner.GetOperand<IdRef>("clusterSize") ?? default;

    public RefOpGroupNonUniformRotateKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformRotateKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupReadInvocationKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef Index => Inner.GetOperand<IdRef>("index") ?? default;

    public RefOpSubgroupReadInvocationKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupReadInvocationKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpExtInstWithForwardRefsKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Set => Inner.GetOperand<IdRef>("set") ?? default;
    public LiteralInteger Instruction => Inner.GetOperand<LiteralInteger>("instruction") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpExtInstWithForwardRefsKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpExtInstWithForwardRefsKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTraceRayKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpTraceRayKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpTraceRayKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpExecuteCallableKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef SBTIndex => Inner.GetOperand<IdRef>("sBTIndex") ?? default;
    public IdRef CallableData => Inner.GetOperand<IdRef>("callableData") ?? default;

    public RefOpExecuteCallableKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpExecuteCallableKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConvertUToAccelerationStructureKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Accel => Inner.GetOperand<IdRef>("accel") ?? default;

    public RefOpConvertUToAccelerationStructureKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpConvertUToAccelerationStructureKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIgnoreIntersectionKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }

    public RefOpIgnoreIntersectionKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpIgnoreIntersectionKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTerminateRayKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }

    public RefOpTerminateRayKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpTerminateRayKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSDot : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public RefOpSDot(RefInstruction instruction) => Inner = instruction;
    public RefOpSDot(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUDot : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public RefOpUDot(RefInstruction instruction) => Inner = instruction;
    public RefOpUDot(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSUDot : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public RefOpSUDot(RefInstruction instruction) => Inner = instruction;
    public RefOpSUDot(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSDotAccSat : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public IdRef Accumulator => Inner.GetOperand<IdRef>("accumulator") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public RefOpSDotAccSat(RefInstruction instruction) => Inner = instruction;
    public RefOpSDotAccSat(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUDotAccSat : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public IdRef Accumulator => Inner.GetOperand<IdRef>("accumulator") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public RefOpUDotAccSat(RefInstruction instruction) => Inner = instruction;
    public RefOpUDotAccSat(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSUDotAccSat : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Vector1 => Inner.GetOperand<IdRef>("vector1") ?? default;
    public IdRef Vector2 => Inner.GetOperand<IdRef>("vector2") ?? default;
    public IdRef Accumulator => Inner.GetOperand<IdRef>("accumulator") ?? default;
    public PackedVectorFormat PackedVectorFormat => Inner.GetEnumOperand<PackedVectorFormat>("packedVectorFormat");

    public RefOpSUDotAccSat(RefInstruction instruction) => Inner = instruction;
    public RefOpSUDotAccSat(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeCooperativeMatrixKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ComponentType => Inner.GetOperand<IdRef>("componentType") ?? default;
    public IdScope Scope => Inner.GetOperand<IdScope>("scope") ?? default;
    public IdRef Rows => Inner.GetOperand<IdRef>("rows") ?? default;
    public IdRef Columns => Inner.GetOperand<IdRef>("columns") ?? default;
    public IdRef Use => Inner.GetOperand<IdRef>("use") ?? default;

    public RefOpTypeCooperativeMatrixKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeCooperativeMatrixKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCooperativeMatrixLoadKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef MemoryLayout => Inner.GetOperand<IdRef>("memoryLayout") ?? default;
    public IdRef Stride => Inner.GetOperand<IdRef>("stride") ?? default;
    public MemoryAccessMask MemoryOperand => Inner.GetEnumOperand<MemoryAccessMask>("memoryOperand");

    public RefOpCooperativeMatrixLoadKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpCooperativeMatrixLoadKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCooperativeMatrixStoreKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public IdRef MemoryLayout => Inner.GetOperand<IdRef>("memoryLayout") ?? default;
    public IdRef Stride => Inner.GetOperand<IdRef>("stride") ?? default;
    public MemoryAccessMask MemoryOperand => Inner.GetEnumOperand<MemoryAccessMask>("memoryOperand");

    public RefOpCooperativeMatrixStoreKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpCooperativeMatrixStoreKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCooperativeMatrixMulAddKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public IdRef C => Inner.GetOperand<IdRef>("c") ?? default;
    public CooperativeMatrixOperandsMask CooperativeMatrixOperands => Inner.GetEnumOperand<CooperativeMatrixOperandsMask>("cooperativeMatrixOperands");

    public RefOpCooperativeMatrixMulAddKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpCooperativeMatrixMulAddKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCooperativeMatrixLengthKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Type => Inner.GetOperand<IdRef>("type") ?? default;

    public RefOpCooperativeMatrixLengthKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpCooperativeMatrixLengthKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConstantCompositeReplicateEXT : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpConstantCompositeReplicateEXT(RefInstruction instruction) => Inner = instruction;
    public RefOpConstantCompositeReplicateEXT(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSpecConstantCompositeReplicateEXT : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpSpecConstantCompositeReplicateEXT(RefInstruction instruction) => Inner = instruction;
    public RefOpSpecConstantCompositeReplicateEXT(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCompositeConstructReplicateEXT : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpCompositeConstructReplicateEXT(RefInstruction instruction) => Inner = instruction;
    public RefOpCompositeConstructReplicateEXT(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeRayQueryKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeRayQueryKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeRayQueryKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryInitializeKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Accel => Inner.GetOperand<IdRef>("accel") ?? default;
    public IdRef RayFlags => Inner.GetOperand<IdRef>("rayFlags") ?? default;
    public IdRef CullMask => Inner.GetOperand<IdRef>("cullMask") ?? default;
    public IdRef RayOrigin => Inner.GetOperand<IdRef>("rayOrigin") ?? default;
    public IdRef RayTMin => Inner.GetOperand<IdRef>("rayTMin") ?? default;
    public IdRef RayDirection => Inner.GetOperand<IdRef>("rayDirection") ?? default;
    public IdRef RayTMax => Inner.GetOperand<IdRef>("rayTMax") ?? default;

    public RefOpRayQueryInitializeKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryInitializeKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryTerminateKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public RefOpRayQueryTerminateKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryTerminateKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGenerateIntersectionKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef HitT => Inner.GetOperand<IdRef>("hitT") ?? default;

    public RefOpRayQueryGenerateIntersectionKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGenerateIntersectionKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryConfirmIntersectionKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public RefOpRayQueryConfirmIntersectionKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryConfirmIntersectionKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryProceedKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public RefOpRayQueryProceedKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryProceedKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetIntersectionTypeKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionTypeKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetIntersectionTypeKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSampleWeightedQCOM : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Texture => Inner.GetOperand<IdRef>("texture") ?? default;
    public IdRef Coordinates => Inner.GetOperand<IdRef>("coordinates") ?? default;
    public IdRef Weights => Inner.GetOperand<IdRef>("weights") ?? default;

    public RefOpImageSampleWeightedQCOM(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSampleWeightedQCOM(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageBoxFilterQCOM : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Texture => Inner.GetOperand<IdRef>("texture") ?? default;
    public IdRef Coordinates => Inner.GetOperand<IdRef>("coordinates") ?? default;
    public IdRef BoxSize => Inner.GetOperand<IdRef>("boxSize") ?? default;

    public RefOpImageBoxFilterQCOM(RefInstruction instruction) => Inner = instruction;
    public RefOpImageBoxFilterQCOM(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageBlockMatchSSDQCOM : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef Reference => Inner.GetOperand<IdRef>("reference") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public RefOpImageBlockMatchSSDQCOM(RefInstruction instruction) => Inner = instruction;
    public RefOpImageBlockMatchSSDQCOM(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageBlockMatchSADQCOM : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef Reference => Inner.GetOperand<IdRef>("reference") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public RefOpImageBlockMatchSADQCOM(RefInstruction instruction) => Inner = instruction;
    public RefOpImageBlockMatchSADQCOM(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageBlockMatchWindowSSDQCOM : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TargetSampledImage => Inner.GetOperand<IdRef>("targetSampledImage") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef ReferenceSampledImage => Inner.GetOperand<IdRef>("referenceSampledImage") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public RefOpImageBlockMatchWindowSSDQCOM(RefInstruction instruction) => Inner = instruction;
    public RefOpImageBlockMatchWindowSSDQCOM(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageBlockMatchWindowSADQCOM : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TargetSampledImage => Inner.GetOperand<IdRef>("targetSampledImage") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef ReferenceSampledImage => Inner.GetOperand<IdRef>("referenceSampledImage") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public RefOpImageBlockMatchWindowSADQCOM(RefInstruction instruction) => Inner = instruction;
    public RefOpImageBlockMatchWindowSADQCOM(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageBlockMatchGatherSSDQCOM : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TargetSampledImage => Inner.GetOperand<IdRef>("targetSampledImage") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef ReferenceSampledImage => Inner.GetOperand<IdRef>("referenceSampledImage") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public RefOpImageBlockMatchGatherSSDQCOM(RefInstruction instruction) => Inner = instruction;
    public RefOpImageBlockMatchGatherSSDQCOM(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageBlockMatchGatherSADQCOM : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TargetSampledImage => Inner.GetOperand<IdRef>("targetSampledImage") ?? default;
    public IdRef TargetCoordinates => Inner.GetOperand<IdRef>("targetCoordinates") ?? default;
    public IdRef ReferenceSampledImage => Inner.GetOperand<IdRef>("referenceSampledImage") ?? default;
    public IdRef ReferenceCoordinates => Inner.GetOperand<IdRef>("referenceCoordinates") ?? default;
    public IdRef BlockSize => Inner.GetOperand<IdRef>("blockSize") ?? default;

    public RefOpImageBlockMatchGatherSADQCOM(RefInstruction instruction) => Inner = instruction;
    public RefOpImageBlockMatchGatherSADQCOM(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupIAddNonUniformAMD : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupIAddNonUniformAMD(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupIAddNonUniformAMD(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupFAddNonUniformAMD : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupFAddNonUniformAMD(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupFAddNonUniformAMD(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupFMinNonUniformAMD : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupFMinNonUniformAMD(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupFMinNonUniformAMD(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupUMinNonUniformAMD : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupUMinNonUniformAMD(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupUMinNonUniformAMD(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupSMinNonUniformAMD : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupSMinNonUniformAMD(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupSMinNonUniformAMD(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupFMaxNonUniformAMD : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupFMaxNonUniformAMD(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupFMaxNonUniformAMD(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupUMaxNonUniformAMD : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupUMaxNonUniformAMD(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupUMaxNonUniformAMD(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupSMaxNonUniformAMD : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupSMaxNonUniformAMD(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupSMaxNonUniformAMD(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFragmentMaskFetchAMD : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;

    public RefOpFragmentMaskFetchAMD(RefInstruction instruction) => Inner = instruction;
    public RefOpFragmentMaskFetchAMD(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFragmentFetchAMD : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef FragmentIndex => Inner.GetOperand<IdRef>("fragmentIndex") ?? default;

    public RefOpFragmentFetchAMD(RefInstruction instruction) => Inner = instruction;
    public RefOpFragmentFetchAMD(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpReadClockKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Scope => Inner.GetOperand<IdScope>("scope") ?? default;

    public RefOpReadClockKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpReadClockKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAllocateNodePayloadsAMDX : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Visibility => Inner.GetOperand<IdScope>("visibility") ?? default;
    public IdRef PayloadCount => Inner.GetOperand<IdRef>("payloadCount") ?? default;
    public IdRef NodeIndex => Inner.GetOperand<IdRef>("nodeIndex") ?? default;

    public RefOpAllocateNodePayloadsAMDX(RefInstruction instruction) => Inner = instruction;
    public RefOpAllocateNodePayloadsAMDX(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpEnqueueNodePayloadsAMDX : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef PayloadArray => Inner.GetOperand<IdRef>("payloadArray") ?? default;

    public RefOpEnqueueNodePayloadsAMDX(RefInstruction instruction) => Inner = instruction;
    public RefOpEnqueueNodePayloadsAMDX(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeNodePayloadArrayAMDX : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PayloadType => Inner.GetOperand<IdRef>("payloadType") ?? default;

    public RefOpTypeNodePayloadArrayAMDX(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeNodePayloadArrayAMDX(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFinishWritingNodePayloadAMDX : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpFinishWritingNodePayloadAMDX(RefInstruction instruction) => Inner = instruction;
    public RefOpFinishWritingNodePayloadAMDX(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpNodePayloadArrayLengthAMDX : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PayloadArray => Inner.GetOperand<IdRef>("payloadArray") ?? default;

    public RefOpNodePayloadArrayLengthAMDX(RefInstruction instruction) => Inner = instruction;
    public RefOpNodePayloadArrayLengthAMDX(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIsNodePayloadValidAMDX : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PayloadType => Inner.GetOperand<IdRef>("payloadType") ?? default;
    public IdRef NodeIndex => Inner.GetOperand<IdRef>("nodeIndex") ?? default;

    public RefOpIsNodePayloadValidAMDX(RefInstruction instruction) => Inner = instruction;
    public RefOpIsNodePayloadValidAMDX(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConstantStringAMDX : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString LiteralString => Inner.GetOperand<LiteralString>("literalString") ?? default;

    public RefOpConstantStringAMDX(RefInstruction instruction) => Inner = instruction;
    public RefOpConstantStringAMDX(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSpecConstantStringAMDX : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString LiteralString => Inner.GetOperand<LiteralString>("literalString") ?? default;

    public RefOpSpecConstantStringAMDX(RefInstruction instruction) => Inner = instruction;
    public RefOpSpecConstantStringAMDX(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformQuadAllKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpGroupNonUniformQuadAllKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformQuadAllKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformQuadAnyKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Predicate => Inner.GetOperand<IdRef>("predicate") ?? default;

    public RefOpGroupNonUniformQuadAnyKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformQuadAnyKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectRecordHitMotionNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpHitObjectRecordHitMotionNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectRecordHitMotionNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectRecordHitWithIndexMotionNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpHitObjectRecordHitWithIndexMotionNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectRecordHitWithIndexMotionNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectRecordMissMotionNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef SBTIndex => Inner.GetOperand<IdRef>("sBTIndex") ?? default;
    public IdRef Origin => Inner.GetOperand<IdRef>("origin") ?? default;
    public IdRef TMin => Inner.GetOperand<IdRef>("tMin") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;
    public IdRef TMax => Inner.GetOperand<IdRef>("tMax") ?? default;
    public IdRef CurrentTime => Inner.GetOperand<IdRef>("currentTime") ?? default;

    public RefOpHitObjectRecordMissMotionNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectRecordMissMotionNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectGetWorldToObjectNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetWorldToObjectNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectGetWorldToObjectNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectGetObjectToWorldNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetObjectToWorldNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectGetObjectToWorldNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectGetObjectRayDirectionNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetObjectRayDirectionNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectGetObjectRayDirectionNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectGetObjectRayOriginNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetObjectRayOriginNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectGetObjectRayOriginNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectTraceRayMotionNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpHitObjectTraceRayMotionNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectTraceRayMotionNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectGetShaderRecordBufferHandleNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetShaderRecordBufferHandleNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectGetShaderRecordBufferHandleNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectGetShaderBindingTableRecordIndexNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetShaderBindingTableRecordIndexNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectGetShaderBindingTableRecordIndexNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectRecordEmptyNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectRecordEmptyNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectRecordEmptyNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectTraceRayNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpHitObjectTraceRayNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectTraceRayNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectRecordHitNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpHitObjectRecordHitNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectRecordHitNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectRecordHitWithIndexNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpHitObjectRecordHitWithIndexNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectRecordHitWithIndexNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectRecordMissNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef SBTIndex => Inner.GetOperand<IdRef>("sBTIndex") ?? default;
    public IdRef Origin => Inner.GetOperand<IdRef>("origin") ?? default;
    public IdRef TMin => Inner.GetOperand<IdRef>("tMin") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;
    public IdRef TMax => Inner.GetOperand<IdRef>("tMax") ?? default;

    public RefOpHitObjectRecordMissNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectRecordMissNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectExecuteShaderNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpHitObjectExecuteShaderNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectExecuteShaderNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectGetCurrentTimeNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetCurrentTimeNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectGetCurrentTimeNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectGetAttributesNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef HitObjectAttribute => Inner.GetOperand<IdRef>("hitObjectAttribute") ?? default;

    public RefOpHitObjectGetAttributesNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectGetAttributesNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectGetHitKindNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetHitKindNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectGetHitKindNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectGetPrimitiveIndexNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetPrimitiveIndexNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectGetPrimitiveIndexNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectGetGeometryIndexNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetGeometryIndexNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectGetGeometryIndexNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectGetInstanceIdNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetInstanceIdNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectGetInstanceIdNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectGetInstanceCustomIndexNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetInstanceCustomIndexNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectGetInstanceCustomIndexNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectGetWorldRayDirectionNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetWorldRayDirectionNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectGetWorldRayDirectionNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectGetWorldRayOriginNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetWorldRayOriginNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectGetWorldRayOriginNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectGetRayTMaxNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetRayTMaxNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectGetRayTMaxNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectGetRayTMinNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectGetRayTMinNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectGetRayTMinNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectIsEmptyNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectIsEmptyNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectIsEmptyNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectIsHitNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectIsHitNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectIsHitNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpHitObjectIsMissNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;

    public RefOpHitObjectIsMissNV(RefInstruction instruction) => Inner = instruction;
    public RefOpHitObjectIsMissNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpReorderThreadWithHitObjectNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef HitObject => Inner.GetOperand<IdRef>("hitObject") ?? default;
    public IdRef Hint => Inner.GetOperand<IdRef>("hint") ?? default;
    public IdRef Bits => Inner.GetOperand<IdRef>("bits") ?? default;

    public RefOpReorderThreadWithHitObjectNV(RefInstruction instruction) => Inner = instruction;
    public RefOpReorderThreadWithHitObjectNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpReorderThreadWithHintNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Hint => Inner.GetOperand<IdRef>("hint") ?? default;
    public IdRef Bits => Inner.GetOperand<IdRef>("bits") ?? default;

    public RefOpReorderThreadWithHintNV(RefInstruction instruction) => Inner = instruction;
    public RefOpReorderThreadWithHintNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeHitObjectNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeHitObjectNV(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeHitObjectNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpImageSampleFootprintNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SampledImage => Inner.GetOperand<IdRef>("sampledImage") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Granularity => Inner.GetOperand<IdRef>("granularity") ?? default;
    public IdRef Coarse => Inner.GetOperand<IdRef>("coarse") ?? default;
    public ImageOperandsMask Imageoperands => Inner.GetEnumOperand<ImageOperandsMask>("imageoperands");

    public RefOpImageSampleFootprintNV(RefInstruction instruction) => Inner = instruction;
    public RefOpImageSampleFootprintNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCooperativeMatrixConvertNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;

    public RefOpCooperativeMatrixConvertNV(RefInstruction instruction) => Inner = instruction;
    public RefOpCooperativeMatrixConvertNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpEmitMeshTasksEXT : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef GroupCountX => Inner.GetOperand<IdRef>("groupCountX") ?? default;
    public IdRef GroupCountY => Inner.GetOperand<IdRef>("groupCountY") ?? default;
    public IdRef GroupCountZ => Inner.GetOperand<IdRef>("groupCountZ") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpEmitMeshTasksEXT(RefInstruction instruction) => Inner = instruction;
    public RefOpEmitMeshTasksEXT(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSetMeshOutputsEXT : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef VertexCount => Inner.GetOperand<IdRef>("vertexCount") ?? default;
    public IdRef PrimitiveCount => Inner.GetOperand<IdRef>("primitiveCount") ?? default;

    public RefOpSetMeshOutputsEXT(RefInstruction instruction) => Inner = instruction;
    public RefOpSetMeshOutputsEXT(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupNonUniformPartitionNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpGroupNonUniformPartitionNV(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupNonUniformPartitionNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpWritePackedPrimitiveIndices4x8NV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef IndexOffset => Inner.GetOperand<IdRef>("indexOffset") ?? default;
    public IdRef PackedIndices => Inner.GetOperand<IdRef>("packedIndices") ?? default;

    public RefOpWritePackedPrimitiveIndices4x8NV(RefInstruction instruction) => Inner = instruction;
    public RefOpWritePackedPrimitiveIndices4x8NV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFetchMicroTriangleVertexPositionNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Accel => Inner.GetOperand<IdRef>("accel") ?? default;
    public IdRef InstanceId => Inner.GetOperand<IdRef>("instanceId") ?? default;
    public IdRef GeometryIndex => Inner.GetOperand<IdRef>("geometryIndex") ?? default;
    public IdRef PrimitiveIndex => Inner.GetOperand<IdRef>("primitiveIndex") ?? default;
    public IdRef Barycentric => Inner.GetOperand<IdRef>("barycentric") ?? default;

    public RefOpFetchMicroTriangleVertexPositionNV(RefInstruction instruction) => Inner = instruction;
    public RefOpFetchMicroTriangleVertexPositionNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFetchMicroTriangleVertexBarycentricNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Accel => Inner.GetOperand<IdRef>("accel") ?? default;
    public IdRef InstanceId => Inner.GetOperand<IdRef>("instanceId") ?? default;
    public IdRef GeometryIndex => Inner.GetOperand<IdRef>("geometryIndex") ?? default;
    public IdRef PrimitiveIndex => Inner.GetOperand<IdRef>("primitiveIndex") ?? default;
    public IdRef Barycentric => Inner.GetOperand<IdRef>("barycentric") ?? default;

    public RefOpFetchMicroTriangleVertexBarycentricNV(RefInstruction instruction) => Inner = instruction;
    public RefOpFetchMicroTriangleVertexBarycentricNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpReportIntersectionKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Hit => Inner.GetOperand<IdRef>("hit") ?? default;
    public IdRef HitKind => Inner.GetOperand<IdRef>("hitKind") ?? default;

    public RefOpReportIntersectionKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpReportIntersectionKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIgnoreIntersectionNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }

    public RefOpIgnoreIntersectionNV(RefInstruction instruction) => Inner = instruction;
    public RefOpIgnoreIntersectionNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTerminateRayNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }

    public RefOpTerminateRayNV(RefInstruction instruction) => Inner = instruction;
    public RefOpTerminateRayNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTraceNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpTraceNV(RefInstruction instruction) => Inner = instruction;
    public RefOpTraceNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTraceMotionNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpTraceMotionNV(RefInstruction instruction) => Inner = instruction;
    public RefOpTraceMotionNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTraceRayMotionNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpTraceRayMotionNV(RefInstruction instruction) => Inner = instruction;
    public RefOpTraceRayMotionNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetIntersectionTriangleVertexPositionsKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionTriangleVertexPositionsKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetIntersectionTriangleVertexPositionsKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeAccelerationStructureKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAccelerationStructureKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeAccelerationStructureKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpExecuteCallableNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef SBTIndex => Inner.GetOperand<IdRef>("sBTIndex") ?? default;
    public IdRef CallableDataId => Inner.GetOperand<IdRef>("callableDataId") ?? default;

    public RefOpExecuteCallableNV(RefInstruction instruction) => Inner = instruction;
    public RefOpExecuteCallableNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeCooperativeMatrixNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ComponentType => Inner.GetOperand<IdRef>("componentType") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdRef Rows => Inner.GetOperand<IdRef>("rows") ?? default;
    public IdRef Columns => Inner.GetOperand<IdRef>("columns") ?? default;

    public RefOpTypeCooperativeMatrixNV(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeCooperativeMatrixNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCooperativeMatrixLoadNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef Stride => Inner.GetOperand<IdRef>("stride") ?? default;
    public IdRef ColumnMajor => Inner.GetOperand<IdRef>("columnMajor") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");

    public RefOpCooperativeMatrixLoadNV(RefInstruction instruction) => Inner = instruction;
    public RefOpCooperativeMatrixLoadNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCooperativeMatrixStoreNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public IdRef Stride => Inner.GetOperand<IdRef>("stride") ?? default;
    public IdRef ColumnMajor => Inner.GetOperand<IdRef>("columnMajor") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");

    public RefOpCooperativeMatrixStoreNV(RefInstruction instruction) => Inner = instruction;
    public RefOpCooperativeMatrixStoreNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCooperativeMatrixMulAddNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public IdRef C => Inner.GetOperand<IdRef>("c") ?? default;

    public RefOpCooperativeMatrixMulAddNV(RefInstruction instruction) => Inner = instruction;
    public RefOpCooperativeMatrixMulAddNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCooperativeMatrixLengthNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Type => Inner.GetOperand<IdRef>("type") ?? default;

    public RefOpCooperativeMatrixLengthNV(RefInstruction instruction) => Inner = instruction;
    public RefOpCooperativeMatrixLengthNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpBeginInvocationInterlockEXT : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }

    public RefOpBeginInvocationInterlockEXT(RefInstruction instruction) => Inner = instruction;
    public RefOpBeginInvocationInterlockEXT(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpEndInvocationInterlockEXT : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }

    public RefOpEndInvocationInterlockEXT(RefInstruction instruction) => Inner = instruction;
    public RefOpEndInvocationInterlockEXT(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCooperativeMatrixReduceNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;
    public CooperativeMatrixReduceMask Reduce => Inner.GetEnumOperand<CooperativeMatrixReduceMask>("reduce");
    public IdRef CombineFunc => Inner.GetOperand<IdRef>("combineFunc") ?? default;

    public RefOpCooperativeMatrixReduceNV(RefInstruction instruction) => Inner = instruction;
    public RefOpCooperativeMatrixReduceNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCooperativeMatrixLoadTensorNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public MemoryAccessMask MemoryOperand => Inner.GetEnumOperand<MemoryAccessMask>("memoryOperand");
    public TensorAddressingOperandsMask TensorAddressingOperands => Inner.GetEnumOperand<TensorAddressingOperandsMask>("tensorAddressingOperands");

    public RefOpCooperativeMatrixLoadTensorNV(RefInstruction instruction) => Inner = instruction;
    public RefOpCooperativeMatrixLoadTensorNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCooperativeMatrixStoreTensorNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdRef ObjectId => Inner.GetOperand<IdRef>("objectId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public MemoryAccessMask MemoryOperand => Inner.GetEnumOperand<MemoryAccessMask>("memoryOperand");
    public TensorAddressingOperandsMask TensorAddressingOperands => Inner.GetEnumOperand<TensorAddressingOperandsMask>("tensorAddressingOperands");

    public RefOpCooperativeMatrixStoreTensorNV(RefInstruction instruction) => Inner = instruction;
    public RefOpCooperativeMatrixStoreTensorNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCooperativeMatrixPerElementOpNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;
    public IdRef Func => Inner.GetOperand<IdRef>("func") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpCooperativeMatrixPerElementOpNV(RefInstruction instruction) => Inner = instruction;
    public RefOpCooperativeMatrixPerElementOpNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeTensorLayoutNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Dim => Inner.GetOperand<IdRef>("dim") ?? default;
    public IdRef ClampMode => Inner.GetOperand<IdRef>("clampMode") ?? default;

    public RefOpTypeTensorLayoutNV(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeTensorLayoutNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeTensorViewNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Dim => Inner.GetOperand<IdRef>("dim") ?? default;
    public IdRef HasDimensions => Inner.GetOperand<IdRef>("hasDimensions") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTypeTensorViewNV(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeTensorViewNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCreateTensorLayoutNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpCreateTensorLayoutNV(RefInstruction instruction) => Inner = instruction;
    public RefOpCreateTensorLayoutNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTensorLayoutSetDimensionNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTensorLayoutSetDimensionNV(RefInstruction instruction) => Inner = instruction;
    public RefOpTensorLayoutSetDimensionNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTensorLayoutSetStrideNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTensorLayoutSetStrideNV(RefInstruction instruction) => Inner = instruction;
    public RefOpTensorLayoutSetStrideNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTensorLayoutSliceNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTensorLayoutSliceNV(RefInstruction instruction) => Inner = instruction;
    public RefOpTensorLayoutSliceNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTensorLayoutSetClampValueNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpTensorLayoutSetClampValueNV(RefInstruction instruction) => Inner = instruction;
    public RefOpTensorLayoutSetClampValueNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCreateTensorViewNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpCreateTensorViewNV(RefInstruction instruction) => Inner = instruction;
    public RefOpCreateTensorViewNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTensorViewSetDimensionNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorView => Inner.GetOperand<IdRef>("tensorView") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTensorViewSetDimensionNV(RefInstruction instruction) => Inner = instruction;
    public RefOpTensorViewSetDimensionNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTensorViewSetStrideNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorView => Inner.GetOperand<IdRef>("tensorView") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTensorViewSetStrideNV(RefInstruction instruction) => Inner = instruction;
    public RefOpTensorViewSetStrideNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpDemoteToHelperInvocation : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }

    public RefOpDemoteToHelperInvocation(RefInstruction instruction) => Inner = instruction;
    public RefOpDemoteToHelperInvocation(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIsHelperInvocationEXT : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpIsHelperInvocationEXT(RefInstruction instruction) => Inner = instruction;
    public RefOpIsHelperInvocationEXT(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTensorViewSetClipNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorView => Inner.GetOperand<IdRef>("tensorView") ?? default;
    public IdRef ClipRowOffset => Inner.GetOperand<IdRef>("clipRowOffset") ?? default;
    public IdRef ClipRowSpan => Inner.GetOperand<IdRef>("clipRowSpan") ?? default;
    public IdRef ClipColOffset => Inner.GetOperand<IdRef>("clipColOffset") ?? default;
    public IdRef ClipColSpan => Inner.GetOperand<IdRef>("clipColSpan") ?? default;

    public RefOpTensorViewSetClipNV(RefInstruction instruction) => Inner = instruction;
    public RefOpTensorViewSetClipNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTensorLayoutSetBlockSizeNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef TensorLayout => Inner.GetOperand<IdRef>("tensorLayout") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTensorLayoutSetBlockSizeNV(RefInstruction instruction) => Inner = instruction;
    public RefOpTensorLayoutSetBlockSizeNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCooperativeMatrixTransposeNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Matrix => Inner.GetOperand<IdRef>("matrix") ?? default;

    public RefOpCooperativeMatrixTransposeNV(RefInstruction instruction) => Inner = instruction;
    public RefOpCooperativeMatrixTransposeNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConvertUToImageNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpConvertUToImageNV(RefInstruction instruction) => Inner = instruction;
    public RefOpConvertUToImageNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConvertUToSamplerNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpConvertUToSamplerNV(RefInstruction instruction) => Inner = instruction;
    public RefOpConvertUToSamplerNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConvertImageToUNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpConvertImageToUNV(RefInstruction instruction) => Inner = instruction;
    public RefOpConvertImageToUNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConvertSamplerToUNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpConvertSamplerToUNV(RefInstruction instruction) => Inner = instruction;
    public RefOpConvertSamplerToUNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConvertUToSampledImageNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpConvertUToSampledImageNV(RefInstruction instruction) => Inner = instruction;
    public RefOpConvertUToSampledImageNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConvertSampledImageToUNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpConvertSampledImageToUNV(RefInstruction instruction) => Inner = instruction;
    public RefOpConvertSampledImageToUNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSamplerImageAddressingModeNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public LiteralInteger BitWidth => Inner.GetOperand<LiteralInteger>("bitWidth") ?? default;

    public RefOpSamplerImageAddressingModeNV(RefInstruction instruction) => Inner = instruction;
    public RefOpSamplerImageAddressingModeNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRawAccessChainNV : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BaseId => Inner.GetOperand<IdRef>("baseId") ?? default;
    public IdRef Bytestride => Inner.GetOperand<IdRef>("bytestride") ?? default;
    public IdRef Elementindex => Inner.GetOperand<IdRef>("elementindex") ?? default;
    public IdRef Byteoffset => Inner.GetOperand<IdRef>("byteoffset") ?? default;
    public RawAccessChainOperandsMask Rawaccesschainoperands => Inner.GetEnumOperand<RawAccessChainOperandsMask>("rawaccesschainoperands");

    public RefOpRawAccessChainNV(RefInstruction instruction) => Inner = instruction;
    public RefOpRawAccessChainNV(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupShuffleINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Data => Inner.GetOperand<IdRef>("data") ?? default;
    public IdRef InvocationId => Inner.GetOperand<IdRef>("invocationId") ?? default;

    public RefOpSubgroupShuffleINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupShuffleINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupShuffleDownINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Current => Inner.GetOperand<IdRef>("current") ?? default;
    public IdRef Next => Inner.GetOperand<IdRef>("next") ?? default;
    public IdRef Delta => Inner.GetOperand<IdRef>("delta") ?? default;

    public RefOpSubgroupShuffleDownINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupShuffleDownINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupShuffleUpINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Previous => Inner.GetOperand<IdRef>("previous") ?? default;
    public IdRef Current => Inner.GetOperand<IdRef>("current") ?? default;
    public IdRef Delta => Inner.GetOperand<IdRef>("delta") ?? default;

    public RefOpSubgroupShuffleUpINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupShuffleUpINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupShuffleXorINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Data => Inner.GetOperand<IdRef>("data") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpSubgroupShuffleXorINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupShuffleXorINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupBlockReadINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Ptr => Inner.GetOperand<IdRef>("ptr") ?? default;

    public RefOpSubgroupBlockReadINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupBlockReadINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupBlockWriteINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Ptr => Inner.GetOperand<IdRef>("ptr") ?? default;
    public IdRef Data => Inner.GetOperand<IdRef>("data") ?? default;

    public RefOpSubgroupBlockWriteINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupBlockWriteINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupImageBlockReadINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;

    public RefOpSubgroupImageBlockReadINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupImageBlockReadINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupImageBlockWriteINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Data => Inner.GetOperand<IdRef>("data") ?? default;

    public RefOpSubgroupImageBlockWriteINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupImageBlockWriteINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupImageMediaBlockReadINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Width => Inner.GetOperand<IdRef>("width") ?? default;
    public IdRef Height => Inner.GetOperand<IdRef>("height") ?? default;

    public RefOpSubgroupImageMediaBlockReadINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupImageMediaBlockReadINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupImageMediaBlockWriteINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Image => Inner.GetOperand<IdRef>("image") ?? default;
    public IdRef Coordinate => Inner.GetOperand<IdRef>("coordinate") ?? default;
    public IdRef Width => Inner.GetOperand<IdRef>("width") ?? default;
    public IdRef Height => Inner.GetOperand<IdRef>("height") ?? default;
    public IdRef Data => Inner.GetOperand<IdRef>("data") ?? default;

    public RefOpSubgroupImageMediaBlockWriteINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupImageMediaBlockWriteINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUCountLeadingZerosINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpUCountLeadingZerosINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpUCountLeadingZerosINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUCountTrailingZerosINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand => Inner.GetOperand<IdRef>("operand") ?? default;

    public RefOpUCountTrailingZerosINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpUCountTrailingZerosINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAbsISubINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpAbsISubINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpAbsISubINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAbsUSubINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpAbsUSubINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpAbsUSubINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIAddSatINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpIAddSatINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpIAddSatINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUAddSatINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUAddSatINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpUAddSatINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIAverageINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpIAverageINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpIAverageINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUAverageINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUAverageINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpUAverageINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIAverageRoundedINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpIAverageRoundedINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpIAverageRoundedINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUAverageRoundedINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUAverageRoundedINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpUAverageRoundedINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpISubSatINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpISubSatINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpISubSatINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUSubSatINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUSubSatINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpUSubSatINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpIMul32x16INTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpIMul32x16INTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpIMul32x16INTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpUMul32x16INTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Operand1 => Inner.GetOperand<IdRef>("operand1") ?? default;
    public IdRef Operand2 => Inner.GetOperand<IdRef>("operand2") ?? default;

    public RefOpUMul32x16INTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpUMul32x16INTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConstantFunctionPointerINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Function => Inner.GetOperand<IdRef>("function") ?? default;

    public RefOpConstantFunctionPointerINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpConstantFunctionPointerINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFunctionPointerCallINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpFunctionPointerCallINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpFunctionPointerCallINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAsmTargetINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public LiteralString Asmtarget => Inner.GetOperand<LiteralString>("asmtarget") ?? default;

    public RefOpAsmTargetINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpAsmTargetINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAsmINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Asmtype => Inner.GetOperand<IdRef>("asmtype") ?? default;
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public LiteralString Asminstructions => Inner.GetOperand<LiteralString>("asminstructions") ?? default;
    public LiteralString Constraints => Inner.GetOperand<LiteralString>("constraints") ?? default;

    public RefOpAsmINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpAsmINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAsmCallINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Asm => Inner.GetOperand<IdRef>("asm") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpAsmCallINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpAsmCallINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicFMinEXT : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicFMinEXT(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicFMinEXT(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicFMaxEXT : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicFMaxEXT(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicFMaxEXT(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAssumeTrueKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Condition => Inner.GetOperand<IdRef>("condition") ?? default;

    public RefOpAssumeTrueKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpAssumeTrueKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpExpectKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;
    public IdRef ExpectedValue => Inner.GetOperand<IdRef>("expectedValue") ?? default;

    public RefOpExpectKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpExpectKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpDecorateString : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;
    public Decoration Decoration => Inner.GetEnumOperand<Decoration>("decoration");

    public RefOpDecorateString(RefInstruction instruction) => Inner = instruction;
    public RefOpDecorateString(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpMemberDecorateString : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef StructType => Inner.GetOperand<IdRef>("structType") ?? default;
    public LiteralInteger Member => Inner.GetOperand<LiteralInteger>("member") ?? default;
    public Decoration Decoration => Inner.GetEnumOperand<Decoration>("decoration");

    public RefOpMemberDecorateString(RefInstruction instruction) => Inner = instruction;
    public RefOpMemberDecorateString(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpVmeImageINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ImageType => Inner.GetOperand<IdRef>("imageType") ?? default;
    public IdRef Sampler => Inner.GetOperand<IdRef>("sampler") ?? default;

    public RefOpVmeImageINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpVmeImageINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeVmeImageINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ImageType => Inner.GetOperand<IdRef>("imageType") ?? default;

    public RefOpTypeVmeImageINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeVmeImageINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeAvcImePayloadINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcImePayloadINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeAvcImePayloadINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeAvcRefPayloadINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcRefPayloadINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeAvcRefPayloadINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeAvcSicPayloadINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcSicPayloadINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeAvcSicPayloadINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeAvcMcePayloadINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcMcePayloadINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeAvcMcePayloadINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeAvcMceResultINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcMceResultINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeAvcMceResultINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeAvcImeResultINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcImeResultINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeAvcImeResultINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeAvcImeResultSingleReferenceStreamoutINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcImeResultSingleReferenceStreamoutINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeAvcImeResultSingleReferenceStreamoutINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeAvcImeResultDualReferenceStreamoutINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcImeResultDualReferenceStreamoutINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeAvcImeResultDualReferenceStreamoutINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeAvcImeSingleReferenceStreaminINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcImeSingleReferenceStreaminINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeAvcImeSingleReferenceStreaminINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeAvcImeDualReferenceStreaminINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcImeDualReferenceStreaminINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeAvcImeDualReferenceStreaminINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeAvcRefResultINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcRefResultINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeAvcRefResultINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeAvcSicResultINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpTypeAvcSicResultINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeAvcSicResultINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public RefOpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ReferenceBasePenalty => Inner.GetOperand<IdRef>("referenceBasePenalty") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public RefOpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceSetInterShapePenaltyINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedShapePenalty => Inner.GetOperand<IdRef>("packedShapePenalty") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceSetInterShapePenaltyINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceSetInterShapePenaltyINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public RefOpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceSetInterDirectionPenaltyINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef DirectionCost => Inner.GetOperand<IdRef>("directionCost") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceSetInterDirectionPenaltyINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceSetInterDirectionPenaltyINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public RefOpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public RefOpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceSetMotionVectorCostFunctionINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedCostCenterDelta => Inner.GetOperand<IdRef>("packedCostCenterDelta") ?? default;
    public IdRef PackedCostTable => Inner.GetOperand<IdRef>("packedCostTable") ?? default;
    public IdRef CostPrecision => Inner.GetOperand<IdRef>("costPrecision") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceSetMotionVectorCostFunctionINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceSetMotionVectorCostFunctionINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SliceType => Inner.GetOperand<IdRef>("sliceType") ?? default;
    public IdRef Qp => Inner.GetOperand<IdRef>("qp") ?? default;

    public RefOpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceSetAcOnlyHaarINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceSetAcOnlyHaarINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceSetAcOnlyHaarINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SourceFieldPolarity => Inner.GetOperand<IdRef>("sourceFieldPolarity") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ReferenceFieldPolarity => Inner.GetOperand<IdRef>("referenceFieldPolarity") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ForwardReferenceFieldPolarity => Inner.GetOperand<IdRef>("forwardReferenceFieldPolarity") ?? default;
    public IdRef BackwardReferenceFieldPolarity => Inner.GetOperand<IdRef>("backwardReferenceFieldPolarity") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceConvertToImePayloadINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceConvertToImePayloadINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceConvertToImePayloadINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceConvertToImeResultINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceConvertToImeResultINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceConvertToImeResultINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceConvertToRefPayloadINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceConvertToRefPayloadINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceConvertToRefPayloadINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceConvertToRefResultINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceConvertToRefResultINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceConvertToRefResultINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceConvertToSicPayloadINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceConvertToSicPayloadINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceConvertToSicPayloadINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceConvertToSicResultINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceConvertToSicResultINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceConvertToSicResultINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetMotionVectorsINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetMotionVectorsINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetMotionVectorsINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetInterDistortionsINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetInterDistortionsINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetInterDistortionsINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetBestInterDistortionsINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetBestInterDistortionsINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetBestInterDistortionsINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetInterMajorShapeINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetInterMajorShapeINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetInterMajorShapeINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetInterMinorShapeINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetInterMinorShapeINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetInterMinorShapeINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetInterDirectionsINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetInterDirectionsINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetInterDirectionsINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetInterMotionVectorCountINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetInterMotionVectorCountINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetInterMotionVectorCountINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetInterReferenceIdsINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetInterReferenceIdsINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetInterReferenceIdsINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedReferenceIds => Inner.GetOperand<IdRef>("packedReferenceIds") ?? default;
    public IdRef PackedReferenceParameterFieldPolarities => Inner.GetOperand<IdRef>("packedReferenceParameterFieldPolarities") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeInitializeINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcCoord => Inner.GetOperand<IdRef>("srcCoord") ?? default;
    public IdRef PartitionMask => Inner.GetOperand<IdRef>("partitionMask") ?? default;
    public IdRef SADAdjustment => Inner.GetOperand<IdRef>("sADAdjustment") ?? default;

    public RefOpSubgroupAvcImeInitializeINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeInitializeINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeSetSingleReferenceINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RefOffset => Inner.GetOperand<IdRef>("refOffset") ?? default;
    public IdRef SearchWindowConfig => Inner.GetOperand<IdRef>("searchWindowConfig") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeSetSingleReferenceINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeSetSingleReferenceINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeSetDualReferenceINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef FwdRefOffset => Inner.GetOperand<IdRef>("fwdRefOffset") ?? default;
    public IdRef BwdRefOffset => Inner.GetOperand<IdRef>("bwdRefOffset") ?? default;
    public IdRef IdSearchWindowConfig => Inner.GetOperand<IdRef>("idSearchWindowConfig") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeSetDualReferenceINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeSetDualReferenceINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeRefWindowSizeINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SearchWindowConfig => Inner.GetOperand<IdRef>("searchWindowConfig") ?? default;
    public IdRef DualRef => Inner.GetOperand<IdRef>("dualRef") ?? default;

    public RefOpSubgroupAvcImeRefWindowSizeINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeRefWindowSizeINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeAdjustRefOffsetINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RefOffset => Inner.GetOperand<IdRef>("refOffset") ?? default;
    public IdRef SrcCoord => Inner.GetOperand<IdRef>("srcCoord") ?? default;
    public IdRef RefWindowSize => Inner.GetOperand<IdRef>("refWindowSize") ?? default;
    public IdRef ImageSize => Inner.GetOperand<IdRef>("imageSize") ?? default;

    public RefOpSubgroupAvcImeAdjustRefOffsetINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeAdjustRefOffsetINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeConvertToMcePayloadINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeConvertToMcePayloadINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeConvertToMcePayloadINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeSetMaxMotionVectorCountINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef MaxMotionVectorCount => Inner.GetOperand<IdRef>("maxMotionVectorCount") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeSetMaxMotionVectorCountINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeSetMaxMotionVectorCountINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeSetUnidirectionalMixDisableINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeSetUnidirectionalMixDisableINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeSetUnidirectionalMixDisableINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Threshold => Inner.GetOperand<IdRef>("threshold") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeSetWeightedSadINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedSadWeights => Inner.GetOperand<IdRef>("packedSadWeights") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeSetWeightedSadINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeSetWeightedSadINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeEvaluateWithSingleReferenceINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeEvaluateWithSingleReferenceINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeEvaluateWithSingleReferenceINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeEvaluateWithDualReferenceINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeEvaluateWithDualReferenceINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeEvaluateWithDualReferenceINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef StreaminComponents => Inner.GetOperand<IdRef>("streaminComponents") ?? default;

    public RefOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef StreaminComponents => Inner.GetOperand<IdRef>("streaminComponents") ?? default;

    public RefOpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef StreaminComponents => Inner.GetOperand<IdRef>("streaminComponents") ?? default;

    public RefOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef StreaminComponents => Inner.GetOperand<IdRef>("streaminComponents") ?? default;

    public RefOpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeConvertToMceResultINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeConvertToMceResultINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeConvertToMceResultINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeGetSingleReferenceStreaminINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeGetSingleReferenceStreaminINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeGetSingleReferenceStreaminINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeGetDualReferenceStreaminINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeGetDualReferenceStreaminINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeGetDualReferenceStreaminINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeStripSingleReferenceStreamoutINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeStripSingleReferenceStreamoutINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeStripSingleReferenceStreamoutINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeStripDualReferenceStreamoutINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeStripDualReferenceStreamoutINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeStripDualReferenceStreamoutINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;

    public RefOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;

    public RefOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;

    public RefOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;

    public RefOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;

    public RefOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;
    public IdRef MajorShape => Inner.GetOperand<IdRef>("majorShape") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;

    public RefOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeGetBorderReachedINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ImageSelect => Inner.GetOperand<IdRef>("imageSelect") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeGetBorderReachedINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeGetBorderReachedINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeGetTruncatedSearchIndicationINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeGetTruncatedSearchIndicationINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeGetTruncatedSearchIndicationINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcFmeInitializeINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcCoord => Inner.GetOperand<IdRef>("srcCoord") ?? default;
    public IdRef MotionVectors => Inner.GetOperand<IdRef>("motionVectors") ?? default;
    public IdRef MajorShapes => Inner.GetOperand<IdRef>("majorShapes") ?? default;
    public IdRef MinorShapes => Inner.GetOperand<IdRef>("minorShapes") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;
    public IdRef PixelResolution => Inner.GetOperand<IdRef>("pixelResolution") ?? default;
    public IdRef SadAdjustment => Inner.GetOperand<IdRef>("sadAdjustment") ?? default;

    public RefOpSubgroupAvcFmeInitializeINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcFmeInitializeINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcBmeInitializeINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpSubgroupAvcBmeInitializeINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcBmeInitializeINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcRefConvertToMcePayloadINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcRefConvertToMcePayloadINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcRefConvertToMcePayloadINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcRefSetBidirectionalMixDisableINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcRefSetBidirectionalMixDisableINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcRefSetBidirectionalMixDisableINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcRefSetBilinearFilterEnableINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcRefSetBilinearFilterEnableINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcRefSetBilinearFilterEnableINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcRefEvaluateWithSingleReferenceINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcRefEvaluateWithSingleReferenceINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcRefEvaluateWithSingleReferenceINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcRefEvaluateWithDualReferenceINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcRefEvaluateWithDualReferenceINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcRefEvaluateWithDualReferenceINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcRefEvaluateWithMultiReferenceINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef PackedReferenceIds => Inner.GetOperand<IdRef>("packedReferenceIds") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcRefEvaluateWithMultiReferenceINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcRefEvaluateWithMultiReferenceINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef PackedReferenceIds => Inner.GetOperand<IdRef>("packedReferenceIds") ?? default;
    public IdRef PackedReferenceFieldPolarities => Inner.GetOperand<IdRef>("packedReferenceFieldPolarities") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcRefConvertToMceResultINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcRefConvertToMceResultINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcRefConvertToMceResultINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicInitializeINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcCoord => Inner.GetOperand<IdRef>("srcCoord") ?? default;

    public RefOpSubgroupAvcSicInitializeINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicInitializeINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicConfigureSkcINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SkipBlockPartitionType => Inner.GetOperand<IdRef>("skipBlockPartitionType") ?? default;
    public IdRef SkipMotionVectorMask => Inner.GetOperand<IdRef>("skipMotionVectorMask") ?? default;
    public IdRef MotionVectors => Inner.GetOperand<IdRef>("motionVectors") ?? default;
    public IdRef BidirectionalWeight => Inner.GetOperand<IdRef>("bidirectionalWeight") ?? default;
    public IdRef SadAdjustment => Inner.GetOperand<IdRef>("sadAdjustment") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicConfigureSkcINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicConfigureSkcINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicConfigureIpeLumaINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpSubgroupAvcSicConfigureIpeLumaINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicConfigureIpeLumaINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicConfigureIpeLumaChromaINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpSubgroupAvcSicConfigureIpeLumaChromaINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicConfigureIpeLumaChromaINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicGetMotionVectorMaskINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SkipBlockPartitionType => Inner.GetOperand<IdRef>("skipBlockPartitionType") ?? default;
    public IdRef Direction => Inner.GetOperand<IdRef>("direction") ?? default;

    public RefOpSubgroupAvcSicGetMotionVectorMaskINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicGetMotionVectorMaskINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicConvertToMcePayloadINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicConvertToMcePayloadINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicConvertToMcePayloadINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedShapePenalty => Inner.GetOperand<IdRef>("packedShapePenalty") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef LumaModePenalty => Inner.GetOperand<IdRef>("lumaModePenalty") ?? default;
    public IdRef LumaPackedNeighborModes => Inner.GetOperand<IdRef>("lumaPackedNeighborModes") ?? default;
    public IdRef LumaPackedNonDcPenalty => Inner.GetOperand<IdRef>("lumaPackedNonDcPenalty") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef ChromaModeBasePenalty => Inner.GetOperand<IdRef>("chromaModeBasePenalty") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicSetBilinearFilterEnableINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicSetBilinearFilterEnableINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicSetBilinearFilterEnableINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicSetSkcForwardTransformEnableINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PackedSadCoefficients => Inner.GetOperand<IdRef>("packedSadCoefficients") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicSetSkcForwardTransformEnableINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicSetSkcForwardTransformEnableINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BlockBasedSkipType => Inner.GetOperand<IdRef>("blockBasedSkipType") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicEvaluateIpeINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicEvaluateIpeINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicEvaluateIpeINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicEvaluateWithSingleReferenceINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef RefImage => Inner.GetOperand<IdRef>("refImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicEvaluateWithSingleReferenceINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicEvaluateWithSingleReferenceINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicEvaluateWithDualReferenceINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef FwdRefImage => Inner.GetOperand<IdRef>("fwdRefImage") ?? default;
    public IdRef BwdRefImage => Inner.GetOperand<IdRef>("bwdRefImage") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicEvaluateWithDualReferenceINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicEvaluateWithDualReferenceINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicEvaluateWithMultiReferenceINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef PackedReferenceIds => Inner.GetOperand<IdRef>("packedReferenceIds") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicEvaluateWithMultiReferenceINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicEvaluateWithMultiReferenceINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef SrcImage => Inner.GetOperand<IdRef>("srcImage") ?? default;
    public IdRef PackedReferenceIds => Inner.GetOperand<IdRef>("packedReferenceIds") ?? default;
    public IdRef PackedReferenceFieldPolarities => Inner.GetOperand<IdRef>("packedReferenceFieldPolarities") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicConvertToMceResultINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicConvertToMceResultINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicConvertToMceResultINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicGetIpeLumaShapeINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicGetIpeLumaShapeINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicGetIpeLumaShapeINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicGetBestIpeLumaDistortionINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicGetBestIpeLumaDistortionINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicGetBestIpeLumaDistortionINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicGetBestIpeChromaDistortionINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicGetBestIpeChromaDistortionINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicGetBestIpeChromaDistortionINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicGetPackedIpeLumaModesINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicGetPackedIpeLumaModesINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicGetPackedIpeLumaModesINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicGetIpeChromaModeINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicGetIpeChromaModeINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicGetIpeChromaModeINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupAvcSicGetInterRawSadsINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Payload => Inner.GetOperand<IdRef>("payload") ?? default;

    public RefOpSubgroupAvcSicGetInterRawSadsINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupAvcSicGetInterRawSadsINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpVariableLengthArrayINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Lenght => Inner.GetOperand<IdRef>("lenght") ?? default;

    public RefOpVariableLengthArrayINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpVariableLengthArrayINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSaveMemoryINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;

    public RefOpSaveMemoryINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSaveMemoryINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRestoreMemoryINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Ptr => Inner.GetOperand<IdRef>("ptr") ?? default;

    public RefOpRestoreMemoryINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpRestoreMemoryINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatSinCosPiINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger FromSign => Inner.GetOperand<LiteralInteger>("fromSign") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatSinCosPiINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatSinCosPiINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatCastINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatCastINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatCastINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatCastFromIntINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger FromSign => Inner.GetOperand<LiteralInteger>("fromSign") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatCastFromIntINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatCastFromIntINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatCastToIntINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatCastToIntINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatCastToIntINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatAddINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpArbitraryFloatAddINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatAddINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatSubINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpArbitraryFloatSubINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatSubINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatMulINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpArbitraryFloatMulINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatMulINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatDivINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpArbitraryFloatDivINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatDivINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatGTINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public RefOpArbitraryFloatGTINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatGTINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatGEINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public RefOpArbitraryFloatGEINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatGEINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatLTINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public RefOpArbitraryFloatLTINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatLTINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatLEINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public RefOpArbitraryFloatLEINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatLEINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatEQINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public RefOpArbitraryFloatEQINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatEQINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatRecipINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatRecipINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatRecipINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatRSqrtINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatRSqrtINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatRSqrtINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatCbrtINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatCbrtINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatCbrtINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatHypotINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpArbitraryFloatHypotINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatHypotINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatSqrtINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatSqrtINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatSqrtINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatLogINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatLogINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatLogINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatLog2INTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatLog2INTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatLog2INTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatLog10INTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatLog10INTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatLog10INTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatLog1pINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatLog1pINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatLog1pINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatExpINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatExpINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatExpINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatExp2INTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatExp2INTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatExp2INTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatExp10INTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatExp10INTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatExp10INTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatExpm1INTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatExpm1INTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatExpm1INTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatSinINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatSinINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatSinINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatCosINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatCosINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatCosINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatSinCosINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatSinCosINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatSinCosINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatSinPiINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatSinPiINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatSinPiINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatCosPiINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatCosPiINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatCosPiINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatASinINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatASinINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatASinINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatASinPiINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatASinPiINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatASinPiINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatACosINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatACosINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatACosINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatACosPiINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatACosPiINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatACosPiINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatATanINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatATanINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatATanINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatATanPiINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatATanPiINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatATanPiINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatATan2INTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpArbitraryFloatATan2INTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatATan2INTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatPowINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpArbitraryFloatPowINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatPowINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatPowRINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
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

    public RefOpArbitraryFloatPowRINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatPowRINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArbitraryFloatPowNINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public RefOpArbitraryFloatPowNINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpArbitraryFloatPowNINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpLoopControlINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public RefOpLoopControlINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpLoopControlINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAliasDomainDeclINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Name => Inner.GetOperand<IdRef>("name") ?? default;

    public RefOpAliasDomainDeclINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpAliasDomainDeclINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAliasScopeDeclINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef AliasDomain => Inner.GetOperand<IdRef>("aliasDomain") ?? default;
    public IdRef Name => Inner.GetOperand<IdRef>("name") ?? default;

    public RefOpAliasScopeDeclINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpAliasScopeDeclINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAliasScopeListDeclINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpAliasScopeListDeclINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpAliasScopeListDeclINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFixedSqrtINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public RefOpFixedSqrtINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpFixedSqrtINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFixedRecipINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public RefOpFixedRecipINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpFixedRecipINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFixedRsqrtINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public RefOpFixedRsqrtINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpFixedRsqrtINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFixedSinINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public RefOpFixedSinINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpFixedSinINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFixedCosINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public RefOpFixedCosINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpFixedCosINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFixedSinCosINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public RefOpFixedSinCosINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpFixedSinCosINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFixedSinPiINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public RefOpFixedSinPiINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpFixedSinPiINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFixedCosPiINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public RefOpFixedCosPiINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpFixedCosPiINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFixedSinCosPiINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public RefOpFixedSinCosPiINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpFixedSinCosPiINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFixedLogINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public RefOpFixedLogINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpFixedLogINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFixedExpINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef InputType => Inner.GetOperand<IdRef>("inputType") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public RefOpFixedExpINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpFixedExpINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpPtrCastToCrossWorkgroupINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public RefOpPtrCastToCrossWorkgroupINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpPtrCastToCrossWorkgroupINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCrossWorkgroupCastToPtrINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;

    public RefOpCrossWorkgroupCastToPtrINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpCrossWorkgroupCastToPtrINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpReadPipeBlockingINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpReadPipeBlockingINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpReadPipeBlockingINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpWritePipeBlockingINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PacketSize => Inner.GetOperand<IdRef>("packetSize") ?? default;
    public IdRef PacketAlignment => Inner.GetOperand<IdRef>("packetAlignment") ?? default;

    public RefOpWritePipeBlockingINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpWritePipeBlockingINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpFPGARegINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Result => Inner.GetOperand<IdRef>("result") ?? default;
    public IdRef Input => Inner.GetOperand<IdRef>("input") ?? default;

    public RefOpFPGARegINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpFPGARegINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetRayTMinKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public RefOpRayQueryGetRayTMinKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetRayTMinKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetRayFlagsKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public RefOpRayQueryGetRayFlagsKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetRayFlagsKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetIntersectionTKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionTKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetIntersectionTKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetIntersectionInstanceCustomIndexKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionInstanceCustomIndexKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetIntersectionInstanceCustomIndexKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetIntersectionInstanceIdKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionInstanceIdKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetIntersectionInstanceIdKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetIntersectionGeometryIndexKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionGeometryIndexKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetIntersectionGeometryIndexKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetIntersectionPrimitiveIndexKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionPrimitiveIndexKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetIntersectionPrimitiveIndexKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetIntersectionBarycentricsKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionBarycentricsKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetIntersectionBarycentricsKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetIntersectionFrontFaceKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionFrontFaceKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetIntersectionFrontFaceKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetIntersectionCandidateAABBOpaqueKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public RefOpRayQueryGetIntersectionCandidateAABBOpaqueKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetIntersectionCandidateAABBOpaqueKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetIntersectionObjectRayDirectionKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionObjectRayDirectionKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetIntersectionObjectRayDirectionKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetIntersectionObjectRayOriginKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionObjectRayOriginKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetIntersectionObjectRayOriginKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetWorldRayDirectionKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public RefOpRayQueryGetWorldRayDirectionKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetWorldRayDirectionKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetWorldRayOriginKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;

    public RefOpRayQueryGetWorldRayOriginKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetWorldRayOriginKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetIntersectionObjectToWorldKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionObjectToWorldKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetIntersectionObjectToWorldKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpRayQueryGetIntersectionWorldToObjectKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef RayQuery => Inner.GetOperand<IdRef>("rayQuery") ?? default;
    public IdRef Intersection => Inner.GetOperand<IdRef>("intersection") ?? default;

    public RefOpRayQueryGetIntersectionWorldToObjectKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpRayQueryGetIntersectionWorldToObjectKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpAtomicFAddEXT : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Pointer => Inner.GetOperand<IdRef>("pointer") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefOpAtomicFAddEXT(RefInstruction instruction) => Inner = instruction;
    public RefOpAtomicFAddEXT(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeBufferSurfaceINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public AccessQualifier AccessQualifier => Inner.GetEnumOperand<AccessQualifier>("accessQualifier");

    public RefOpTypeBufferSurfaceINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeBufferSurfaceINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpTypeStructContinuedINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpTypeStructContinuedINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpTypeStructContinuedINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConstantCompositeContinuedINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpConstantCompositeContinuedINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpConstantCompositeContinuedINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSpecConstantCompositeContinuedINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpSpecConstantCompositeContinuedINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSpecConstantCompositeContinuedINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpCompositeConstructContinuedINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public RefOpCompositeConstructContinuedINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpCompositeConstructContinuedINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConvertFToBF16INTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef FloatValue => Inner.GetOperand<IdRef>("floatValue") ?? default;

    public RefOpConvertFToBF16INTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpConvertFToBF16INTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpConvertBF16ToFINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef BFloat16Value => Inner.GetOperand<IdRef>("bFloat16Value") ?? default;

    public RefOpConvertBF16ToFINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpConvertBF16ToFINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpControlBarrierArriveINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpControlBarrierArriveINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpControlBarrierArriveINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpControlBarrierWaitINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public IdScope Memory => Inner.GetOperand<IdScope>("memory") ?? default;
    public IdMemorySemantics Semantics => Inner.GetOperand<IdMemorySemantics>("semantics") ?? default;

    public RefOpControlBarrierWaitINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpControlBarrierWaitINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpArithmeticFenceEXT : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef Target => Inner.GetOperand<IdRef>("target") ?? default;

    public RefOpArithmeticFenceEXT(RefInstruction instruction) => Inner = instruction;
    public RefOpArithmeticFenceEXT(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpSubgroupBlockPrefetchINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Ptr => Inner.GetOperand<IdRef>("ptr") ?? default;
    public IdRef NumBytes => Inner.GetOperand<IdRef>("numBytes") ?? default;
    public MemoryAccessMask Memoryaccess => Inner.GetEnumOperand<MemoryAccessMask>("memoryaccess");

    public RefOpSubgroupBlockPrefetchINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpSubgroupBlockPrefetchINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupIMulKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupIMulKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupIMulKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupFMulKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupFMulKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupFMulKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupBitwiseAndKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupBitwiseAndKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupBitwiseAndKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupBitwiseOrKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupBitwiseOrKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupBitwiseOrKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupBitwiseXorKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupBitwiseXorKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupBitwiseXorKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupLogicalAndKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupLogicalAndKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupLogicalAndKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupLogicalOrKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupLogicalOrKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupLogicalOrKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpGroupLogicalXorKHR : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdScope Execution => Inner.GetOperand<IdScope>("execution") ?? default;
    public GroupOperation Operation => Inner.GetEnumOperand<GroupOperation>("operation");
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefOpGroupLogicalXorKHR(RefInstruction instruction) => Inner = instruction;
    public RefOpGroupLogicalXorKHR(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpMaskedGatherINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdResultType ResultType => Inner.GetOperand<IdResultType>("resultType") ?? default;
    public IdResult ResultId => Inner.GetOperand<IdResult>("resultId") ?? default;
    public IdRef PtrVector => Inner.GetOperand<IdRef>("ptrVector") ?? default;
    public LiteralInteger Alignment => Inner.GetOperand<LiteralInteger>("alignment") ?? default;
    public IdRef Mask => Inner.GetOperand<IdRef>("mask") ?? default;
    public IdRef FillEmpty => Inner.GetOperand<IdRef>("fillEmpty") ?? default;

    public RefOpMaskedGatherINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpMaskedGatherINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefOpMaskedScatterINTEL : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef InputVector => Inner.GetOperand<IdRef>("inputVector") ?? default;
    public IdRef PtrVector => Inner.GetOperand<IdRef>("ptrVector") ?? default;
    public LiteralInteger Alignment => Inner.GetOperand<LiteralInteger>("alignment") ?? default;
    public IdRef Mask => Inner.GetOperand<IdRef>("mask") ?? default;

    public RefOpMaskedScatterINTEL(RefInstruction instruction) => Inner = instruction;
    public RefOpMaskedScatterINTEL(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLRound : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLRound(RefInstruction instruction) => Inner = instruction;
    public RefGLSLRound(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLRoundEven : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLRoundEven(RefInstruction instruction) => Inner = instruction;
    public RefGLSLRoundEven(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLTrunc : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLTrunc(RefInstruction instruction) => Inner = instruction;
    public RefGLSLTrunc(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLFAbs : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLFAbs(RefInstruction instruction) => Inner = instruction;
    public RefGLSLFAbs(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLSAbs : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLSAbs(RefInstruction instruction) => Inner = instruction;
    public RefGLSLSAbs(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLFSign : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLFSign(RefInstruction instruction) => Inner = instruction;
    public RefGLSLFSign(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLSSign : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLSSign(RefInstruction instruction) => Inner = instruction;
    public RefGLSLSSign(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLFloor : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLFloor(RefInstruction instruction) => Inner = instruction;
    public RefGLSLFloor(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLCeil : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLCeil(RefInstruction instruction) => Inner = instruction;
    public RefGLSLCeil(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLFract : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLFract(RefInstruction instruction) => Inner = instruction;
    public RefGLSLFract(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLRadians : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Degrees => Inner.GetOperand<IdRef>("degrees") ?? default;

    public RefGLSLRadians(RefInstruction instruction) => Inner = instruction;
    public RefGLSLRadians(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLDegrees : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Radians => Inner.GetOperand<IdRef>("radians") ?? default;

    public RefGLSLDegrees(RefInstruction instruction) => Inner = instruction;
    public RefGLSLDegrees(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLSin : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLSin(RefInstruction instruction) => Inner = instruction;
    public RefGLSLSin(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLCos : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLCos(RefInstruction instruction) => Inner = instruction;
    public RefGLSLCos(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLTan : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLTan(RefInstruction instruction) => Inner = instruction;
    public RefGLSLTan(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLAsin : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLAsin(RefInstruction instruction) => Inner = instruction;
    public RefGLSLAsin(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLAcos : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLAcos(RefInstruction instruction) => Inner = instruction;
    public RefGLSLAcos(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLAtan : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Y_over_x => Inner.GetOperand<IdRef>("y_over_x") ?? default;

    public RefGLSLAtan(RefInstruction instruction) => Inner = instruction;
    public RefGLSLAtan(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLSinh : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLSinh(RefInstruction instruction) => Inner = instruction;
    public RefGLSLSinh(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLCosh : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLCosh(RefInstruction instruction) => Inner = instruction;
    public RefGLSLCosh(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLTanh : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLTanh(RefInstruction instruction) => Inner = instruction;
    public RefGLSLTanh(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLAsinh : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLAsinh(RefInstruction instruction) => Inner = instruction;
    public RefGLSLAsinh(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLAcosh : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLAcosh(RefInstruction instruction) => Inner = instruction;
    public RefGLSLAcosh(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLAtanh : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLAtanh(RefInstruction instruction) => Inner = instruction;
    public RefGLSLAtanh(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLAtan2 : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLAtan2(RefInstruction instruction) => Inner = instruction;
    public RefGLSLAtan2(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLPow : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLPow(RefInstruction instruction) => Inner = instruction;
    public RefGLSLPow(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLExp : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLExp(RefInstruction instruction) => Inner = instruction;
    public RefGLSLExp(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLLog : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLLog(RefInstruction instruction) => Inner = instruction;
    public RefGLSLLog(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLExp2 : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLExp2(RefInstruction instruction) => Inner = instruction;
    public RefGLSLExp2(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLLog2 : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLLog2(RefInstruction instruction) => Inner = instruction;
    public RefGLSLLog2(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLSqrt : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLSqrt(RefInstruction instruction) => Inner = instruction;
    public RefGLSLSqrt(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLInverseSqrt : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLInverseSqrt(RefInstruction instruction) => Inner = instruction;
    public RefGLSLInverseSqrt(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLDeterminant : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLDeterminant(RefInstruction instruction) => Inner = instruction;
    public RefGLSLDeterminant(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLMatrixInverse : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLMatrixInverse(RefInstruction instruction) => Inner = instruction;
    public RefGLSLMatrixInverse(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLModf : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef I => Inner.GetOperand<IdRef>("i") ?? default;

    public RefGLSLModf(RefInstruction instruction) => Inner = instruction;
    public RefGLSLModf(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLModfStruct : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLModfStruct(RefInstruction instruction) => Inner = instruction;
    public RefGLSLModfStruct(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLFMin : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLFMin(RefInstruction instruction) => Inner = instruction;
    public RefGLSLFMin(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLUMin : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLUMin(RefInstruction instruction) => Inner = instruction;
    public RefGLSLUMin(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLSMin : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLSMin(RefInstruction instruction) => Inner = instruction;
    public RefGLSLSMin(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLFMax : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLFMax(RefInstruction instruction) => Inner = instruction;
    public RefGLSLFMax(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLUMax : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLUMax(RefInstruction instruction) => Inner = instruction;
    public RefGLSLUMax(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLSMax : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLSMax(RefInstruction instruction) => Inner = instruction;
    public RefGLSLSMax(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLFClamp : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef MinVal => Inner.GetOperand<IdRef>("minVal") ?? default;
    public IdRef MaxVal => Inner.GetOperand<IdRef>("maxVal") ?? default;

    public RefGLSLFClamp(RefInstruction instruction) => Inner = instruction;
    public RefGLSLFClamp(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLUClamp : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef MinVal => Inner.GetOperand<IdRef>("minVal") ?? default;
    public IdRef MaxVal => Inner.GetOperand<IdRef>("maxVal") ?? default;

    public RefGLSLUClamp(RefInstruction instruction) => Inner = instruction;
    public RefGLSLUClamp(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLSClamp : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef MinVal => Inner.GetOperand<IdRef>("minVal") ?? default;
    public IdRef MaxVal => Inner.GetOperand<IdRef>("maxVal") ?? default;

    public RefGLSLSClamp(RefInstruction instruction) => Inner = instruction;
    public RefGLSLSClamp(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLFMix : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;

    public RefGLSLFMix(RefInstruction instruction) => Inner = instruction;
    public RefGLSLFMix(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLIMix : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;

    public RefGLSLIMix(RefInstruction instruction) => Inner = instruction;
    public RefGLSLIMix(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLStep : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Edge => Inner.GetOperand<IdRef>("edge") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLStep(RefInstruction instruction) => Inner = instruction;
    public RefGLSLStep(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLSmoothStep : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Edge0 => Inner.GetOperand<IdRef>("edge0") ?? default;
    public IdRef Edge1 => Inner.GetOperand<IdRef>("edge1") ?? default;
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLSmoothStep(RefInstruction instruction) => Inner = instruction;
    public RefGLSLSmoothStep(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLFma : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef A => Inner.GetOperand<IdRef>("a") ?? default;
    public IdRef B => Inner.GetOperand<IdRef>("b") ?? default;
    public IdRef C => Inner.GetOperand<IdRef>("c") ?? default;

    public RefGLSLFma(RefInstruction instruction) => Inner = instruction;
    public RefGLSLFma(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLFrexp : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Exp => Inner.GetOperand<IdRef>("exp") ?? default;

    public RefGLSLFrexp(RefInstruction instruction) => Inner = instruction;
    public RefGLSLFrexp(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLFrexpStruct : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLFrexpStruct(RefInstruction instruction) => Inner = instruction;
    public RefGLSLFrexpStruct(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLLdexp : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Exp => Inner.GetOperand<IdRef>("exp") ?? default;

    public RefGLSLLdexp(RefInstruction instruction) => Inner = instruction;
    public RefGLSLLdexp(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLPackSnorm4x8 : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public RefGLSLPackSnorm4x8(RefInstruction instruction) => Inner = instruction;
    public RefGLSLPackSnorm4x8(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLPackUnorm4x8 : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public RefGLSLPackUnorm4x8(RefInstruction instruction) => Inner = instruction;
    public RefGLSLPackUnorm4x8(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLPackSnorm2x16 : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public RefGLSLPackSnorm2x16(RefInstruction instruction) => Inner = instruction;
    public RefGLSLPackSnorm2x16(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLPackUnorm2x16 : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public RefGLSLPackUnorm2x16(RefInstruction instruction) => Inner = instruction;
    public RefGLSLPackUnorm2x16(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLPackHalf2x16 : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public RefGLSLPackHalf2x16(RefInstruction instruction) => Inner = instruction;
    public RefGLSLPackHalf2x16(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLPackDouble2x32 : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public RefGLSLPackDouble2x32(RefInstruction instruction) => Inner = instruction;
    public RefGLSLPackDouble2x32(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLUnpackSnorm2x16 : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefGLSLUnpackSnorm2x16(RefInstruction instruction) => Inner = instruction;
    public RefGLSLUnpackSnorm2x16(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLUnpackUnorm2x16 : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefGLSLUnpackUnorm2x16(RefInstruction instruction) => Inner = instruction;
    public RefGLSLUnpackUnorm2x16(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLUnpackHalf2x16 : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public RefGLSLUnpackHalf2x16(RefInstruction instruction) => Inner = instruction;
    public RefGLSLUnpackHalf2x16(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLUnpackSnorm4x8 : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefGLSLUnpackSnorm4x8(RefInstruction instruction) => Inner = instruction;
    public RefGLSLUnpackSnorm4x8(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLUnpackUnorm4x8 : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef P => Inner.GetOperand<IdRef>("p") ?? default;

    public RefGLSLUnpackUnorm4x8(RefInstruction instruction) => Inner = instruction;
    public RefGLSLUnpackUnorm4x8(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLUnpackDouble2x32 : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef V => Inner.GetOperand<IdRef>("v") ?? default;

    public RefGLSLUnpackDouble2x32(RefInstruction instruction) => Inner = instruction;
    public RefGLSLUnpackDouble2x32(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLLength : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLLength(RefInstruction instruction) => Inner = instruction;
    public RefGLSLLength(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLDistance : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef P0 => Inner.GetOperand<IdRef>("p0") ?? default;
    public IdRef P1 => Inner.GetOperand<IdRef>("p1") ?? default;

    public RefGLSLDistance(RefInstruction instruction) => Inner = instruction;
    public RefGLSLDistance(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLCross : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLCross(RefInstruction instruction) => Inner = instruction;
    public RefGLSLCross(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLNormalize : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;

    public RefGLSLNormalize(RefInstruction instruction) => Inner = instruction;
    public RefGLSLNormalize(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLFaceForward : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef N => Inner.GetOperand<IdRef>("n") ?? default;
    public IdRef I => Inner.GetOperand<IdRef>("i") ?? default;
    public IdRef Nref => Inner.GetOperand<IdRef>("nref") ?? default;

    public RefGLSLFaceForward(RefInstruction instruction) => Inner = instruction;
    public RefGLSLFaceForward(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLReflect : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef I => Inner.GetOperand<IdRef>("i") ?? default;
    public IdRef N => Inner.GetOperand<IdRef>("n") ?? default;

    public RefGLSLReflect(RefInstruction instruction) => Inner = instruction;
    public RefGLSLReflect(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLRefract : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef I => Inner.GetOperand<IdRef>("i") ?? default;
    public IdRef N => Inner.GetOperand<IdRef>("n") ?? default;
    public IdRef Eta => Inner.GetOperand<IdRef>("eta") ?? default;

    public RefGLSLRefract(RefInstruction instruction) => Inner = instruction;
    public RefGLSLRefract(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLFindILsb : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefGLSLFindILsb(RefInstruction instruction) => Inner = instruction;
    public RefGLSLFindILsb(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLFindSMsb : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefGLSLFindSMsb(RefInstruction instruction) => Inner = instruction;
    public RefGLSLFindSMsb(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLFindUMsb : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Value => Inner.GetOperand<IdRef>("value") ?? default;

    public RefGLSLFindUMsb(RefInstruction instruction) => Inner = instruction;
    public RefGLSLFindUMsb(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLInterpolateAtCentroid : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Interpolant => Inner.GetOperand<IdRef>("interpolant") ?? default;

    public RefGLSLInterpolateAtCentroid(RefInstruction instruction) => Inner = instruction;
    public RefGLSLInterpolateAtCentroid(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLInterpolateAtSample : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Interpolant => Inner.GetOperand<IdRef>("interpolant") ?? default;
    public IdRef Sample => Inner.GetOperand<IdRef>("sample") ?? default;

    public RefGLSLInterpolateAtSample(RefInstruction instruction) => Inner = instruction;
    public RefGLSLInterpolateAtSample(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLInterpolateAtOffset : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef Interpolant => Inner.GetOperand<IdRef>("interpolant") ?? default;
    public IdRef Offset => Inner.GetOperand<IdRef>("offset") ?? default;

    public RefGLSLInterpolateAtOffset(RefInstruction instruction) => Inner = instruction;
    public RefGLSLInterpolateAtOffset(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLNMin : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLNMin(RefInstruction instruction) => Inner = instruction;
    public RefGLSLNMin(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLNMax : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef Y => Inner.GetOperand<IdRef>("y") ?? default;

    public RefGLSLNMax(RefInstruction instruction) => Inner = instruction;
    public RefGLSLNMax(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}

public ref struct RefGLSLNClamp : IWrapperInstruction
{
    public RefInstruction Inner { get; set; }
    public IdRef X => Inner.GetOperand<IdRef>("x") ?? default;
    public IdRef MinVal => Inner.GetOperand<IdRef>("minVal") ?? default;
    public IdRef MaxVal => Inner.GetOperand<IdRef>("maxVal") ?? default;

    public RefGLSLNClamp(RefInstruction instruction) => Inner = instruction;
    public RefGLSLNClamp(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);
}