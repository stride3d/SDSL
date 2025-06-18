using static Stride.Shaders.Spirv.Specification;

namespace Stride.Shaders.Spirv.Core;
public ref struct InstOpSDSLShader : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString ShaderName => Inner.GetOperand<LiteralString>("shaderName") ?? default;

    public InstOpSDSLShader(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSDSLShader(Instruction instruction) => new(instruction);
}

public ref struct InstOpSDSLShaderEnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpSDSLShaderEnd(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSDSLShaderEnd(Instruction instruction) => new(instruction);
}

public ref struct InstOpSDSLMixinInherit : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Shader { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpSDSLMixinInherit(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSDSLMixinInherit(Instruction instruction) => new(instruction);
}

public ref struct InstOpSDSLCompose : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString Mixin => Inner.GetOperand<LiteralString>("mixin") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public InstOpSDSLCompose(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSDSLCompose(Instruction instruction) => new(instruction);
}

public ref struct InstOpSDSLStage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef StagedElement { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpSDSLStage(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSDSLStage(Instruction instruction) => new(instruction);
}

public ref struct InstOpSDSLImportShader : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public LiteralString ShaderName => Inner.GetOperand<LiteralString>("shaderName") ?? default;

    public InstOpSDSLImportShader(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSDSLImportShader(Instruction instruction) => new(instruction);
}

public ref struct InstOpSDSLImportFunction : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public LiteralString FunctionName => Inner.GetOperand<LiteralString>("functionName") ?? default;
    public IdRef Shader => Inner.GetOperand<IdRef>("shader") ?? default;

    public InstOpSDSLImportFunction(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSDSLImportFunction(Instruction instruction) => new(instruction);
}

public ref struct InstOpSDSLImportVariable : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public LiteralString VariableName => Inner.GetOperand<LiteralString>("variableName") ?? default;
    public IdRef Shader => Inner.GetOperand<IdRef>("shader") ?? default;

    public InstOpSDSLImportVariable(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSDSLImportVariable(Instruction instruction) => new(instruction);
}

public ref struct InstOpNop : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpNop(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpNop(Instruction instruction) => new(instruction);
}

public ref struct InstOpUndef : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpUndef(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUndef(Instruction instruction) => new(instruction);
}

public ref struct InstOpSourceContinued : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString ContinuedSource => Inner.GetOperand<LiteralString>("continuedSource") ?? default;

    public InstOpSourceContinued(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSourceContinued(Instruction instruction) => new(instruction);
}

public ref struct InstOpSource : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public SourceLanguage Sourcelanguage { get => (SourceLanguage)Inner.Memory.Span[1]; set => Inner.Memory.Span[1] = (int)value; }
    public LiteralInteger Version => Inner.GetOperand<LiteralInteger>("version") ?? default;
    public IdRef File { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public LiteralString Source => Inner.GetOperand<LiteralString>("source") ?? default;

    public InstOpSource(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSource(Instruction instruction) => new(instruction);
}

public ref struct InstOpSourceExtension : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString Extension => Inner.GetOperand<LiteralString>("extension") ?? default;

    public InstOpSourceExtension(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSourceExtension(Instruction instruction) => new(instruction);
}

public ref struct InstOpName : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public InstOpName(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpName(Instruction instruction) => new(instruction);
}

public ref struct InstOpMemberName : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Type { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public LiteralInteger Member => Inner.GetOperand<LiteralInteger>("member") ?? default;
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public InstOpMemberName(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpMemberName(Instruction instruction) => new(instruction);
}

public ref struct InstOpString : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public LiteralString Value => Inner.GetOperand<LiteralString>("value") ?? default;

    public InstOpString(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpString(Instruction instruction) => new(instruction);
}

public ref struct InstOpLine : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef File { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public LiteralInteger Line => Inner.GetOperand<LiteralInteger>("line") ?? default;
    public LiteralInteger Column => Inner.GetOperand<LiteralInteger>("column") ?? default;

    public InstOpLine(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpLine(Instruction instruction) => new(instruction);
}

public ref struct InstOpExtension : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public InstOpExtension(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpExtension(Instruction instruction) => new(instruction);
}

public ref struct InstOpExtInstImport : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;

    public InstOpExtInstImport(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpExtInstImport(Instruction instruction) => new(instruction);
}

public ref struct InstOpExtInst : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Set { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public int Instruction { get => Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpExtInst(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpExtInst(Instruction instruction) => new(instruction);
}

public ref struct InstOpMemoryModel : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public AddressingModel Addressingmodel { get => (AddressingModel)Inner.Memory.Span[1]; set => Inner.Memory.Span[1] = (int)value; }
    public MemoryModel Memorymodel { get => (MemoryModel)Inner.Memory.Span[2]; set => Inner.Memory.Span[2] = (int)value; }

    public InstOpMemoryModel(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpMemoryModel(Instruction instruction) => new(instruction);
}

public ref struct InstOpEntryPoint : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public ExecutionModel Executionmodel { get => (ExecutionModel)Inner.Memory.Span[1]; set => Inner.Memory.Span[1] = (int)value; }
    public IdRef EntryPoint { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public LiteralString Name => Inner.GetOperand<LiteralString>("name") ?? default;
    public IdRef Values => Inner.GetOperand<IdRef>("values") ?? default;

    public InstOpEntryPoint(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpEntryPoint(Instruction instruction) => new(instruction);
}

public ref struct InstOpExecutionMode : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EntryPoint { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public ExecutionMode Mode { get => (ExecutionMode)Inner.Memory.Span[2]; set => Inner.Memory.Span[2] = (int)value; }

    public InstOpExecutionMode(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpExecutionMode(Instruction instruction) => new(instruction);
}

public ref struct InstOpCapability : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public Capability Capability { get => (Capability)Inner.Memory.Span[1]; set => Inner.Memory.Span[1] = (int)value; }

    public InstOpCapability(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCapability(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeVoid : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeVoid(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeVoid(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeBool : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeBool(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeBool(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeInt : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public LiteralInteger Width => Inner.GetOperand<LiteralInteger>("width") ?? default;
    public LiteralInteger Signedness => Inner.GetOperand<LiteralInteger>("signedness") ?? default;

    public InstOpTypeInt(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeInt(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeFloat : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public LiteralInteger Width => Inner.GetOperand<LiteralInteger>("width") ?? default;
    public FPEncoding FloatingPointEncoding { get => (FPEncoding)Inner.Memory.Span[2]; set => Inner.Memory.Span[2] = (int)value; }

    public InstOpTypeFloat(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeFloat(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeVector : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef ComponentType { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public LiteralInteger ComponentCount => Inner.GetOperand<LiteralInteger>("componentCount") ?? default;

    public InstOpTypeVector(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeVector(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeMatrix : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef ColumnType { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public LiteralInteger ColumnCount => Inner.GetOperand<LiteralInteger>("columnCount") ?? default;

    public InstOpTypeMatrix(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeMatrix(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeImage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef SampledType { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public Dim Dim { get => (Dim)Inner.Memory.Span[3]; set => Inner.Memory.Span[3] = (int)value; }
    public LiteralInteger Depth => Inner.GetOperand<LiteralInteger>("depth") ?? default;
    public LiteralInteger Arrayed => Inner.GetOperand<LiteralInteger>("arrayed") ?? default;
    public LiteralInteger MS => Inner.GetOperand<LiteralInteger>("mS") ?? default;
    public LiteralInteger Sampled => Inner.GetOperand<LiteralInteger>("sampled") ?? default;
    public ImageFormat Imageformat { get => (ImageFormat)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public AccessQualifier Accessqualifier { get => (AccessQualifier)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpTypeImage(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeImage(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeSampler : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeSampler(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeSampler(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeSampledImage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef ImageType { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpTypeSampledImage(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeSampledImage(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeArray : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef ElementType { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Length { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpTypeArray(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeArray(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeRuntimeArray : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef ElementType { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpTypeRuntimeArray(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeRuntimeArray(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeStruct : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpTypeStruct(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeStruct(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeOpaque : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public LiteralString Thenameoftheopaquetype => Inner.GetOperand<LiteralString>("thenameoftheopaquetype") ?? default;

    public InstOpTypeOpaque(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeOpaque(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypePointer : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public StorageClass Storageclass { get => (StorageClass)Inner.Memory.Span[2]; set => Inner.Memory.Span[2] = (int)value; }
    public IdRef Type { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpTypePointer(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypePointer(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeFunction : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef ReturnType { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpTypeFunction(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeFunction(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeEvent(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeEvent(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeDeviceEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeDeviceEvent(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeDeviceEvent(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeReserveId : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeReserveId(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeReserveId(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeQueue : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeQueue(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeQueue(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypePipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public AccessQualifier Qualifier { get => (AccessQualifier)Inner.Memory.Span[2]; set => Inner.Memory.Span[2] = (int)value; }

    public InstOpTypePipe(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypePipe(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeForwardPointer : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef PointerType { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public StorageClass Storageclass { get => (StorageClass)Inner.Memory.Span[2]; set => Inner.Memory.Span[2] = (int)value; }

    public InstOpTypeForwardPointer(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeForwardPointer(Instruction instruction) => new(instruction);
}

public ref struct InstOpConstantTrue : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpConstantTrue(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConstantTrue(Instruction instruction) => new(instruction);
}

public ref struct InstOpConstantFalse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpConstantFalse(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConstantFalse(Instruction instruction) => new(instruction);
}

public ref struct InstOpConstant : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpConstant(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConstant(Instruction instruction) => new(instruction);
}

public ref struct InstOpConstantComposite : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConstantComposite(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConstantComposite(Instruction instruction) => new(instruction);
}

public ref struct InstOpConstantSampler : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public SamplerAddressingMode Sampleraddressingmode { get => (SamplerAddressingMode)Inner.Memory.Span[3]; set => Inner.Memory.Span[3] = (int)value; }
    public LiteralInteger Param => Inner.GetOperand<LiteralInteger>("param") ?? default;
    public SamplerFilterMode Samplerfiltermode { get => (SamplerFilterMode)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }

    public InstOpConstantSampler(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConstantSampler(Instruction instruction) => new(instruction);
}

public ref struct InstOpConstantNull : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpConstantNull(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConstantNull(Instruction instruction) => new(instruction);
}

public ref struct InstOpSpecConstantTrue : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpSpecConstantTrue(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSpecConstantTrue(Instruction instruction) => new(instruction);
}

public ref struct InstOpSpecConstantFalse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpSpecConstantFalse(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSpecConstantFalse(Instruction instruction) => new(instruction);
}

public ref struct InstOpSpecConstant : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpSpecConstant(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSpecConstant(Instruction instruction) => new(instruction);
}

public ref struct InstOpSpecConstantComposite : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSpecConstantComposite(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSpecConstantComposite(Instruction instruction) => new(instruction);
}

public ref struct InstOpSpecConstantOp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public int Opcode { get => Inner.Memory.Span[3]; set => Inner.Memory.Span[3] = value; }

    public InstOpSpecConstantOp(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSpecConstantOp(Instruction instruction) => new(instruction);
}

public ref struct InstOpFunction : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public FunctionControlMask Functioncontrol { get => (FunctionControlMask)Inner.Memory.Span[3]; set => Inner.Memory.Span[3] = (int)value; }
    public IdRef FunctionType { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFunction(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFunction(Instruction instruction) => new(instruction);
}

public ref struct InstOpFunctionParameter : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpFunctionParameter(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFunctionParameter(Instruction instruction) => new(instruction);
}

public ref struct InstOpFunctionEnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpFunctionEnd(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFunctionEnd(Instruction instruction) => new(instruction);
}

public ref struct InstOpFunctionCall : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Function { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFunctionCall(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFunctionCall(Instruction instruction) => new(instruction);
}

public ref struct InstOpVariable : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public StorageClass Storageclass { get => (StorageClass)Inner.Memory.Span[3]; set => Inner.Memory.Span[3] = (int)value; }
    public IdRef Initializer { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpVariable(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpVariable(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageTexelPointer : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Sample { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpImageTexelPointer(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageTexelPointer(Instruction instruction) => new(instruction);
}

public ref struct InstOpLoad : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public MemoryAccessMask Memoryaccess { get => (MemoryAccessMask)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }

    public InstOpLoad(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpLoad(Instruction instruction) => new(instruction);
}

public ref struct InstOpStore : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef ObjectId { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public MemoryAccessMask Memoryaccess { get => (MemoryAccessMask)Inner.Memory.Span[3]; set => Inner.Memory.Span[3] = (int)value; }

    public InstOpStore(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpStore(Instruction instruction) => new(instruction);
}

public ref struct InstOpCopyMemory : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Source { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public MemoryAccessMask Memoryaccess { get => (MemoryAccessMask)Inner.Memory.Span[3]; set => Inner.Memory.Span[3] = (int)value; }
    public MemoryAccessMask Memoryaccess1 { get => (MemoryAccessMask)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }

    public InstOpCopyMemory(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCopyMemory(Instruction instruction) => new(instruction);
}

public ref struct InstOpCopyMemorySized : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Source { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Size { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public MemoryAccessMask Memoryaccess { get => (MemoryAccessMask)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public MemoryAccessMask Memoryaccess1 { get => (MemoryAccessMask)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpCopyMemorySized(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCopyMemorySized(Instruction instruction) => new(instruction);
}

public ref struct InstOpAccessChain : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BaseId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpAccessChain(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAccessChain(Instruction instruction) => new(instruction);
}

public ref struct InstOpInBoundsAccessChain : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BaseId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpInBoundsAccessChain(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpInBoundsAccessChain(Instruction instruction) => new(instruction);
}

public ref struct InstOpPtrAccessChain : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BaseId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Element { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpPtrAccessChain(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpPtrAccessChain(Instruction instruction) => new(instruction);
}

public ref struct InstOpArrayLength : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Structure { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger Arraymember => Inner.GetOperand<LiteralInteger>("arraymember") ?? default;

    public InstOpArrayLength(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArrayLength(Instruction instruction) => new(instruction);
}

public ref struct InstOpGenericPtrMemSemantics : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpGenericPtrMemSemantics(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGenericPtrMemSemantics(Instruction instruction) => new(instruction);
}

public ref struct InstOpInBoundsPtrAccessChain : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BaseId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Element { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpInBoundsPtrAccessChain(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpInBoundsPtrAccessChain(Instruction instruction) => new(instruction);
}

public ref struct InstOpDecorate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public Decoration Decoration { get => (Decoration)Inner.Memory.Span[2]; set => Inner.Memory.Span[2] = (int)value; }

    public InstOpDecorate(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpDecorate(Instruction instruction) => new(instruction);
}

public ref struct InstOpMemberDecorate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef StructureType { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public LiteralInteger Member => Inner.GetOperand<LiteralInteger>("member") ?? default;
    public Decoration Decoration { get => (Decoration)Inner.Memory.Span[2]; set => Inner.Memory.Span[2] = (int)value; }

    public InstOpMemberDecorate(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpMemberDecorate(Instruction instruction) => new(instruction);
}

public ref struct InstOpDecorationGroup : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpDecorationGroup(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpDecorationGroup(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupDecorate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef DecorationGroup { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpGroupDecorate(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupDecorate(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupMemberDecorate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef DecorationGroup { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public PairIdRefLiteralInteger Values => Inner.GetOperand<PairIdRefLiteralInteger>("values") ?? default;

    public InstOpGroupMemberDecorate(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupMemberDecorate(Instruction instruction) => new(instruction);
}

public ref struct InstOpVectorExtractDynamic : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Vector { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Index { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpVectorExtractDynamic(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpVectorExtractDynamic(Instruction instruction) => new(instruction);
}

public ref struct InstOpVectorInsertDynamic : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Vector { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Component { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Index { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpVectorInsertDynamic(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpVectorInsertDynamic(Instruction instruction) => new(instruction);
}

public ref struct InstOpVectorShuffle : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Vector1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Vector2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public InstOpVectorShuffle(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpVectorShuffle(Instruction instruction) => new(instruction);
}

public ref struct InstOpCompositeConstruct : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpCompositeConstruct(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCompositeConstruct(Instruction instruction) => new(instruction);
}

public ref struct InstOpCompositeExtract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Composite { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public InstOpCompositeExtract(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCompositeExtract(Instruction instruction) => new(instruction);
}

public ref struct InstOpCompositeInsert : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef ObjectId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Composite { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public InstOpCompositeInsert(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCompositeInsert(Instruction instruction) => new(instruction);
}

public ref struct InstOpCopyObject : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpCopyObject(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCopyObject(Instruction instruction) => new(instruction);
}

public ref struct InstOpTranspose : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Matrix { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpTranspose(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTranspose(Instruction instruction) => new(instruction);
}

public ref struct InstOpSampledImage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Sampler { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSampledImage(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSampledImage(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSampleImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpImageSampleImplicitLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSampleImplicitLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSampleExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpImageSampleExplicitLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSampleExplicitLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSampleDrefImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Dref { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpImageSampleDrefImplicitLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSampleDrefImplicitLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSampleDrefExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Dref { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpImageSampleDrefExplicitLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSampleDrefExplicitLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSampleProjImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpImageSampleProjImplicitLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSampleProjImplicitLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSampleProjExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpImageSampleProjExplicitLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSampleProjExplicitLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSampleProjDrefImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Dref { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpImageSampleProjDrefImplicitLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSampleProjDrefImplicitLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSampleProjDrefExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Dref { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpImageSampleProjDrefExplicitLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSampleProjDrefExplicitLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageFetch : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpImageFetch(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageFetch(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageGather : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Component { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpImageGather(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageGather(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageDrefGather : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Dref { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpImageDrefGather(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageDrefGather(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageRead : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpImageRead(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageRead(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageWrite : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Texel { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }

    public InstOpImageWrite(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageWrite(Instruction instruction) => new(instruction);
}

public ref struct InstOpImage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpImage(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImage(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageQueryFormat : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpImageQueryFormat(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageQueryFormat(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageQueryOrder : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpImageQueryOrder(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageQueryOrder(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageQuerySizeLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef LevelofDetail { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpImageQuerySizeLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageQuerySizeLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageQuerySize : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpImageQuerySize(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageQuerySize(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageQueryLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpImageQueryLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageQueryLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageQueryLevels : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpImageQueryLevels(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageQueryLevels(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageQuerySamples : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpImageQuerySamples(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageQuerySamples(Instruction instruction) => new(instruction);
}

public ref struct InstOpConvertFToU : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef FloatValue { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConvertFToU(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConvertFToU(Instruction instruction) => new(instruction);
}

public ref struct InstOpConvertFToS : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef FloatValue { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConvertFToS(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConvertFToS(Instruction instruction) => new(instruction);
}

public ref struct InstOpConvertSToF : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SignedValue { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConvertSToF(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConvertSToF(Instruction instruction) => new(instruction);
}

public ref struct InstOpConvertUToF : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef UnsignedValue { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConvertUToF(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConvertUToF(Instruction instruction) => new(instruction);
}

public ref struct InstOpUConvert : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef UnsignedValue { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpUConvert(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUConvert(Instruction instruction) => new(instruction);
}

public ref struct InstOpSConvert : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SignedValue { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSConvert(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSConvert(Instruction instruction) => new(instruction);
}

public ref struct InstOpFConvert : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef FloatValue { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpFConvert(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFConvert(Instruction instruction) => new(instruction);
}

public ref struct InstOpQuantizeToF16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpQuantizeToF16(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpQuantizeToF16(Instruction instruction) => new(instruction);
}

public ref struct InstOpConvertPtrToU : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConvertPtrToU(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConvertPtrToU(Instruction instruction) => new(instruction);
}

public ref struct InstOpSatConvertSToU : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SignedValue { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSatConvertSToU(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSatConvertSToU(Instruction instruction) => new(instruction);
}

public ref struct InstOpSatConvertUToS : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef UnsignedValue { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSatConvertUToS(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSatConvertUToS(Instruction instruction) => new(instruction);
}

public ref struct InstOpConvertUToPtr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef IntegerValue { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConvertUToPtr(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConvertUToPtr(Instruction instruction) => new(instruction);
}

public ref struct InstOpPtrCastToGeneric : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpPtrCastToGeneric(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpPtrCastToGeneric(Instruction instruction) => new(instruction);
}

public ref struct InstOpGenericCastToPtr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpGenericCastToPtr(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGenericCastToPtr(Instruction instruction) => new(instruction);
}

public ref struct InstOpGenericCastToPtrExplicit : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public StorageClass Storage { get => (StorageClass)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }

    public InstOpGenericCastToPtrExplicit(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGenericCastToPtrExplicit(Instruction instruction) => new(instruction);
}

public ref struct InstOpBitcast : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpBitcast(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpBitcast(Instruction instruction) => new(instruction);
}

public ref struct InstOpSNegate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSNegate(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSNegate(Instruction instruction) => new(instruction);
}

public ref struct InstOpFNegate : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpFNegate(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFNegate(Instruction instruction) => new(instruction);
}

public ref struct InstOpIAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpIAdd(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIAdd(Instruction instruction) => new(instruction);
}

public ref struct InstOpFAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFAdd(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFAdd(Instruction instruction) => new(instruction);
}

public ref struct InstOpISub : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpISub(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpISub(Instruction instruction) => new(instruction);
}

public ref struct InstOpFSub : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFSub(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFSub(Instruction instruction) => new(instruction);
}

public ref struct InstOpIMul : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpIMul(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIMul(Instruction instruction) => new(instruction);
}

public ref struct InstOpFMul : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFMul(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFMul(Instruction instruction) => new(instruction);
}

public ref struct InstOpUDiv : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpUDiv(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUDiv(Instruction instruction) => new(instruction);
}

public ref struct InstOpSDiv : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSDiv(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSDiv(Instruction instruction) => new(instruction);
}

public ref struct InstOpFDiv : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFDiv(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFDiv(Instruction instruction) => new(instruction);
}

public ref struct InstOpUMod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpUMod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUMod(Instruction instruction) => new(instruction);
}

public ref struct InstOpSRem : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSRem(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSRem(Instruction instruction) => new(instruction);
}

public ref struct InstOpSMod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSMod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSMod(Instruction instruction) => new(instruction);
}

public ref struct InstOpFRem : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFRem(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFRem(Instruction instruction) => new(instruction);
}

public ref struct InstOpFMod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFMod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFMod(Instruction instruction) => new(instruction);
}

public ref struct InstOpVectorTimesScalar : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Vector { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Scalar { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpVectorTimesScalar(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpVectorTimesScalar(Instruction instruction) => new(instruction);
}

public ref struct InstOpMatrixTimesScalar : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Matrix { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Scalar { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpMatrixTimesScalar(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpMatrixTimesScalar(Instruction instruction) => new(instruction);
}

public ref struct InstOpVectorTimesMatrix : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Vector { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Matrix { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpVectorTimesMatrix(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpVectorTimesMatrix(Instruction instruction) => new(instruction);
}

public ref struct InstOpMatrixTimesVector : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Matrix { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Vector { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpMatrixTimesVector(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpMatrixTimesVector(Instruction instruction) => new(instruction);
}

public ref struct InstOpMatrixTimesMatrix : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef LeftMatrix { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef RightMatrix { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpMatrixTimesMatrix(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpMatrixTimesMatrix(Instruction instruction) => new(instruction);
}

public ref struct InstOpOuterProduct : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Vector1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Vector2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpOuterProduct(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpOuterProduct(Instruction instruction) => new(instruction);
}

public ref struct InstOpDot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Vector1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Vector2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpDot(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpDot(Instruction instruction) => new(instruction);
}

public ref struct InstOpIAddCarry : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpIAddCarry(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIAddCarry(Instruction instruction) => new(instruction);
}

public ref struct InstOpISubBorrow : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpISubBorrow(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpISubBorrow(Instruction instruction) => new(instruction);
}

public ref struct InstOpUMulExtended : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpUMulExtended(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUMulExtended(Instruction instruction) => new(instruction);
}

public ref struct InstOpSMulExtended : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSMulExtended(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSMulExtended(Instruction instruction) => new(instruction);
}

public ref struct InstOpAny : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Vector { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpAny(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAny(Instruction instruction) => new(instruction);
}

public ref struct InstOpAll : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Vector { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpAll(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAll(Instruction instruction) => new(instruction);
}

public ref struct InstOpIsNan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpIsNan(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIsNan(Instruction instruction) => new(instruction);
}

public ref struct InstOpIsInf : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpIsInf(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIsInf(Instruction instruction) => new(instruction);
}

public ref struct InstOpIsFinite : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpIsFinite(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIsFinite(Instruction instruction) => new(instruction);
}

public ref struct InstOpIsNormal : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpIsNormal(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIsNormal(Instruction instruction) => new(instruction);
}

public ref struct InstOpSignBitSet : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSignBitSet(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSignBitSet(Instruction instruction) => new(instruction);
}

public ref struct InstOpLessOrGreater : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Y { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpLessOrGreater(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpLessOrGreater(Instruction instruction) => new(instruction);
}

public ref struct InstOpOrdered : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Y { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpOrdered(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpOrdered(Instruction instruction) => new(instruction);
}

public ref struct InstOpUnordered : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Y { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpUnordered(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUnordered(Instruction instruction) => new(instruction);
}

public ref struct InstOpLogicalEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpLogicalEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpLogicalEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpLogicalNotEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpLogicalNotEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpLogicalNotEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpLogicalOr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpLogicalOr(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpLogicalOr(Instruction instruction) => new(instruction);
}

public ref struct InstOpLogicalAnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpLogicalAnd(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpLogicalAnd(Instruction instruction) => new(instruction);
}

public ref struct InstOpLogicalNot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpLogicalNot(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpLogicalNot(Instruction instruction) => new(instruction);
}

public ref struct InstOpSelect : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Condition { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Object1 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Object2 { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpSelect(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSelect(Instruction instruction) => new(instruction);
}

public ref struct InstOpIEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpIEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpINotEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpINotEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpINotEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpUGreaterThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpUGreaterThan(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUGreaterThan(Instruction instruction) => new(instruction);
}

public ref struct InstOpSGreaterThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSGreaterThan(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSGreaterThan(Instruction instruction) => new(instruction);
}

public ref struct InstOpUGreaterThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpUGreaterThanEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUGreaterThanEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpSGreaterThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSGreaterThanEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSGreaterThanEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpULessThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpULessThan(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpULessThan(Instruction instruction) => new(instruction);
}

public ref struct InstOpSLessThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSLessThan(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSLessThan(Instruction instruction) => new(instruction);
}

public ref struct InstOpULessThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpULessThanEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpULessThanEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpSLessThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSLessThanEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSLessThanEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpFOrdEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFOrdEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFOrdEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpFUnordEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFUnordEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFUnordEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpFOrdNotEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFOrdNotEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFOrdNotEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpFUnordNotEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFUnordNotEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFUnordNotEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpFOrdLessThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFOrdLessThan(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFOrdLessThan(Instruction instruction) => new(instruction);
}

public ref struct InstOpFUnordLessThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFUnordLessThan(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFUnordLessThan(Instruction instruction) => new(instruction);
}

public ref struct InstOpFOrdGreaterThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFOrdGreaterThan(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFOrdGreaterThan(Instruction instruction) => new(instruction);
}

public ref struct InstOpFUnordGreaterThan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFUnordGreaterThan(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFUnordGreaterThan(Instruction instruction) => new(instruction);
}

public ref struct InstOpFOrdLessThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFOrdLessThanEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFOrdLessThanEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpFUnordLessThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFUnordLessThanEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFUnordLessThanEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpFOrdGreaterThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFOrdGreaterThanEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFOrdGreaterThanEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpFUnordGreaterThanEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFUnordGreaterThanEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFUnordGreaterThanEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpShiftRightLogical : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BaseId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Shift { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpShiftRightLogical(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpShiftRightLogical(Instruction instruction) => new(instruction);
}

public ref struct InstOpShiftRightArithmetic : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BaseId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Shift { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpShiftRightArithmetic(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpShiftRightArithmetic(Instruction instruction) => new(instruction);
}

public ref struct InstOpShiftLeftLogical : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BaseId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Shift { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpShiftLeftLogical(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpShiftLeftLogical(Instruction instruction) => new(instruction);
}

public ref struct InstOpBitwiseOr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpBitwiseOr(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpBitwiseOr(Instruction instruction) => new(instruction);
}

public ref struct InstOpBitwiseXor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpBitwiseXor(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpBitwiseXor(Instruction instruction) => new(instruction);
}

public ref struct InstOpBitwiseAnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpBitwiseAnd(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpBitwiseAnd(Instruction instruction) => new(instruction);
}

public ref struct InstOpNot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpNot(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpNot(Instruction instruction) => new(instruction);
}

public ref struct InstOpBitFieldInsert : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BaseId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Insert { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Offset { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Count { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpBitFieldInsert(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpBitFieldInsert(Instruction instruction) => new(instruction);
}

public ref struct InstOpBitFieldSExtract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BaseId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Offset { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Count { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpBitFieldSExtract(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpBitFieldSExtract(Instruction instruction) => new(instruction);
}

public ref struct InstOpBitFieldUExtract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BaseId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Offset { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Count { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpBitFieldUExtract(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpBitFieldUExtract(Instruction instruction) => new(instruction);
}

public ref struct InstOpBitReverse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BaseId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpBitReverse(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpBitReverse(Instruction instruction) => new(instruction);
}

public ref struct InstOpBitCount : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BaseId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpBitCount(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpBitCount(Instruction instruction) => new(instruction);
}

public ref struct InstOpDPdx : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef P { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpDPdx(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpDPdx(Instruction instruction) => new(instruction);
}

public ref struct InstOpDPdy : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef P { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpDPdy(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpDPdy(Instruction instruction) => new(instruction);
}

public ref struct InstOpFwidth : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef P { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpFwidth(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFwidth(Instruction instruction) => new(instruction);
}

public ref struct InstOpDPdxFine : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef P { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpDPdxFine(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpDPdxFine(Instruction instruction) => new(instruction);
}

public ref struct InstOpDPdyFine : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef P { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpDPdyFine(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpDPdyFine(Instruction instruction) => new(instruction);
}

public ref struct InstOpFwidthFine : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef P { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpFwidthFine(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFwidthFine(Instruction instruction) => new(instruction);
}

public ref struct InstOpDPdxCoarse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef P { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpDPdxCoarse(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpDPdxCoarse(Instruction instruction) => new(instruction);
}

public ref struct InstOpDPdyCoarse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef P { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpDPdyCoarse(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpDPdyCoarse(Instruction instruction) => new(instruction);
}

public ref struct InstOpFwidthCoarse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef P { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpFwidthCoarse(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFwidthCoarse(Instruction instruction) => new(instruction);
}

public ref struct InstOpEmitVertex : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpEmitVertex(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpEmitVertex(Instruction instruction) => new(instruction);
}

public ref struct InstOpEndPrimitive : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpEndPrimitive(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpEndPrimitive(Instruction instruction) => new(instruction);
}

public ref struct InstOpEmitStreamVertex : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Stream { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpEmitStreamVertex(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpEmitStreamVertex(Instruction instruction) => new(instruction);
}

public ref struct InstOpEndStreamPrimitive : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Stream { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpEndStreamPrimitive(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpEndStreamPrimitive(Instruction instruction) => new(instruction);
}

public ref struct InstOpControlBarrier : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpControlBarrier(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpControlBarrier(Instruction instruction) => new(instruction);
}

public ref struct InstOpMemoryBarrier : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpMemoryBarrier(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpMemoryBarrier(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicLoad : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpAtomicLoad(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicLoad(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicStore : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpAtomicStore(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicStore(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicExchange : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpAtomicExchange(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicExchange(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicCompareExchange : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Equal { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdMemorySemantics Unequal { get => new IdMemorySemantics(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef Comparator { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }

    public InstOpAtomicCompareExchange(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicCompareExchange(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicCompareExchangeWeak : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Equal { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdMemorySemantics Unequal { get => new IdMemorySemantics(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef Comparator { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }

    public InstOpAtomicCompareExchangeWeak(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicCompareExchangeWeak(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicIIncrement : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpAtomicIIncrement(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicIIncrement(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicIDecrement : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpAtomicIDecrement(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicIDecrement(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicIAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpAtomicIAdd(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicIAdd(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicISub : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpAtomicISub(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicISub(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicSMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpAtomicSMin(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicSMin(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicUMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpAtomicUMin(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicUMin(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicSMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpAtomicSMax(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicSMax(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicUMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpAtomicUMax(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicUMax(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicAnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpAtomicAnd(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicAnd(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicOr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpAtomicOr(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicOr(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicXor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpAtomicXor(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicXor(Instruction instruction) => new(instruction);
}

public ref struct InstOpPhi : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public PairIdRefIdRef Values => Inner.GetOperand<PairIdRefIdRef>("values") ?? default;

    public InstOpPhi(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpPhi(Instruction instruction) => new(instruction);
}

public ref struct InstOpLoopMerge : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef MergeBlock { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef ContinueTarget { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public LoopControlMask Loopcontrol { get => (LoopControlMask)Inner.Memory.Span[3]; set => Inner.Memory.Span[3] = (int)value; }

    public InstOpLoopMerge(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpLoopMerge(Instruction instruction) => new(instruction);
}

public ref struct InstOpSelectionMerge : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef MergeBlock { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public SelectionControlMask Selectioncontrol { get => (SelectionControlMask)Inner.Memory.Span[2]; set => Inner.Memory.Span[2] = (int)value; }

    public InstOpSelectionMerge(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSelectionMerge(Instruction instruction) => new(instruction);
}

public ref struct InstOpLabel : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpLabel(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpLabel(Instruction instruction) => new(instruction);
}

public ref struct InstOpBranch : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef TargetLabel { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpBranch(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpBranch(Instruction instruction) => new(instruction);
}

public ref struct InstOpBranchConditional : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Condition { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef TrueLabel { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef FalseLabel { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public InstOpBranchConditional(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpBranchConditional(Instruction instruction) => new(instruction);
}

public ref struct InstOpSwitch : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Selector { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef DefaultId { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public PairLiteralIntegerIdRef Values => Inner.GetOperand<PairLiteralIntegerIdRef>("values") ?? default;

    public InstOpSwitch(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSwitch(Instruction instruction) => new(instruction);
}

public ref struct InstOpKill : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpKill(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpKill(Instruction instruction) => new(instruction);
}

public ref struct InstOpReturn : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpReturn(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpReturn(Instruction instruction) => new(instruction);
}

public ref struct InstOpReturnValue : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpReturnValue(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpReturnValue(Instruction instruction) => new(instruction);
}

public ref struct InstOpUnreachable : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpUnreachable(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUnreachable(Instruction instruction) => new(instruction);
}

public ref struct InstOpLifetimeStart : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public LiteralInteger Size => Inner.GetOperand<LiteralInteger>("size") ?? default;

    public InstOpLifetimeStart(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpLifetimeStart(Instruction instruction) => new(instruction);
}

public ref struct InstOpLifetimeStop : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public LiteralInteger Size => Inner.GetOperand<LiteralInteger>("size") ?? default;

    public InstOpLifetimeStop(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpLifetimeStop(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupAsyncCopy : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Destination { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Source { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef NumElements { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef Stride { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef EventId { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }

    public InstOpGroupAsyncCopy(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupAsyncCopy(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupWaitEvents : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef NumEvents { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef EventsList { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpGroupWaitEvents(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupWaitEvents(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupAll : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Predicate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpGroupAll(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupAll(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupAny : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Predicate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpGroupAny(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupAny(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupBroadcast : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef LocalId { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupBroadcast(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupBroadcast(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupIAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupIAdd(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupIAdd(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupFAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupFAdd(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupFAdd(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupFMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupFMin(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupFMin(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupUMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupUMin(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupUMin(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupSMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupSMin(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupSMin(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupFMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupFMax(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupFMax(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupUMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupUMax(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupUMax(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupSMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupSMax(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupSMax(Instruction instruction) => new(instruction);
}

public ref struct InstOpReadPipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pipe { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef PacketSize { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef PacketAlignment { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpReadPipe(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpReadPipe(Instruction instruction) => new(instruction);
}

public ref struct InstOpWritePipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pipe { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef PacketSize { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef PacketAlignment { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpWritePipe(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpWritePipe(Instruction instruction) => new(instruction);
}

public ref struct InstOpReservedReadPipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pipe { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef ReserveId { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Index { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef PacketSize { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef PacketAlignment { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }

    public InstOpReservedReadPipe(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpReservedReadPipe(Instruction instruction) => new(instruction);
}

public ref struct InstOpReservedWritePipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pipe { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef ReserveId { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Index { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef PacketSize { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef PacketAlignment { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }

    public InstOpReservedWritePipe(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpReservedWritePipe(Instruction instruction) => new(instruction);
}

public ref struct InstOpReserveReadPipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pipe { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef NumPackets { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef PacketSize { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef PacketAlignment { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpReserveReadPipePackets(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpReserveReadPipePackets(Instruction instruction) => new(instruction);
}

public ref struct InstOpReserveWritePipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pipe { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef NumPackets { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef PacketSize { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef PacketAlignment { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpReserveWritePipePackets(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpReserveWritePipePackets(Instruction instruction) => new(instruction);
}

public ref struct InstOpCommitReadPipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pipe { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef ReserveId { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef PacketSize { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PacketAlignment { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpCommitReadPipe(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCommitReadPipe(Instruction instruction) => new(instruction);
}

public ref struct InstOpCommitWritePipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pipe { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef ReserveId { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef PacketSize { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PacketAlignment { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpCommitWritePipe(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCommitWritePipe(Instruction instruction) => new(instruction);
}

public ref struct InstOpIsValidReserveId : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef ReserveId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpIsValidReserveId(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIsValidReserveId(Instruction instruction) => new(instruction);
}

public ref struct InstOpGetNumPipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pipe { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PacketSize { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef PacketAlignment { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGetNumPipePackets(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGetNumPipePackets(Instruction instruction) => new(instruction);
}

public ref struct InstOpGetMaxPipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pipe { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PacketSize { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef PacketAlignment { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGetMaxPipePackets(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGetMaxPipePackets(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupReserveReadPipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Pipe { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef NumPackets { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef PacketSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef PacketAlignment { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }

    public InstOpGroupReserveReadPipePackets(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupReserveReadPipePackets(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupReserveWritePipePackets : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Pipe { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef NumPackets { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef PacketSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef PacketAlignment { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }

    public InstOpGroupReserveWritePipePackets(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupReserveWritePipePackets(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupCommitReadPipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Pipe { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef ReserveId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PacketSize { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef PacketAlignment { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupCommitReadPipe(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupCommitReadPipe(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupCommitWritePipe : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Pipe { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef ReserveId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PacketSize { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef PacketAlignment { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupCommitWritePipe(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupCommitWritePipe(Instruction instruction) => new(instruction);
}

public ref struct InstOpEnqueueMarker : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Queue { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef NumEvents { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef WaitEvents { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef RetEvent { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpEnqueueMarker(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpEnqueueMarker(Instruction instruction) => new(instruction);
}

public ref struct InstOpEnqueueKernel : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Queue { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Flags { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef NDRange { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef NumEvents { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef WaitEvents { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef RetEvent { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }
    public IdRef Invoke { get => new IdRef(Inner.Memory.Span[9]); set => Inner.Memory.Span[9] = value; }
    public IdRef Param { get => new IdRef(Inner.Memory.Span[10]); set => Inner.Memory.Span[10] = value; }
    public IdRef ParamSize { get => new IdRef(Inner.Memory.Span[11]); set => Inner.Memory.Span[11] = value; }
    public IdRef ParamAlign { get => new IdRef(Inner.Memory.Span[12]); set => Inner.Memory.Span[12] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[13]); set => Inner.Memory.Span[13] = value; }

    public InstOpEnqueueKernel(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpEnqueueKernel(Instruction instruction) => new(instruction);
}

public ref struct InstOpGetKernelNDrangeSubGroupCount : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef NDRange { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Invoke { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Param { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ParamSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef ParamAlign { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }

    public InstOpGetKernelNDrangeSubGroupCount(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGetKernelNDrangeSubGroupCount(Instruction instruction) => new(instruction);
}

public ref struct InstOpGetKernelNDrangeMaxSubGroupSize : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef NDRange { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Invoke { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Param { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ParamSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef ParamAlign { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }

    public InstOpGetKernelNDrangeMaxSubGroupSize(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGetKernelNDrangeMaxSubGroupSize(Instruction instruction) => new(instruction);
}

public ref struct InstOpGetKernelWorkGroupSize : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Invoke { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Param { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef ParamSize { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ParamAlign { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGetKernelWorkGroupSize(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGetKernelWorkGroupSize(Instruction instruction) => new(instruction);
}

public ref struct InstOpGetKernelPreferredWorkGroupSizeMultiple : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Invoke { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Param { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef ParamSize { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ParamAlign { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGetKernelPreferredWorkGroupSizeMultiple(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGetKernelPreferredWorkGroupSizeMultiple(Instruction instruction) => new(instruction);
}

public ref struct InstOpRetainEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EventId { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpRetainEvent(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRetainEvent(Instruction instruction) => new(instruction);
}

public ref struct InstOpReleaseEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EventId { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpReleaseEvent(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpReleaseEvent(Instruction instruction) => new(instruction);
}

public ref struct InstOpCreateUserEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpCreateUserEvent(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCreateUserEvent(Instruction instruction) => new(instruction);
}

public ref struct InstOpIsValidEvent : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef EventId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpIsValidEvent(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIsValidEvent(Instruction instruction) => new(instruction);
}

public ref struct InstOpSetUserEventStatus : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EventId { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Status { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpSetUserEventStatus(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSetUserEventStatus(Instruction instruction) => new(instruction);
}

public ref struct InstOpCaptureEventProfilingInfo : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EventId { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef ProfilingInfo { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpCaptureEventProfilingInfo(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCaptureEventProfilingInfo(Instruction instruction) => new(instruction);
}

public ref struct InstOpGetDefaultQueue : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpGetDefaultQueue(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGetDefaultQueue(Instruction instruction) => new(instruction);
}

public ref struct InstOpBuildNDRange : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef GlobalWorkSize { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef LocalWorkSize { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef GlobalWorkOffset { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpBuildNDRange(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpBuildNDRange(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSparseSampleImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpImageSparseSampleImplicitLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSparseSampleImplicitLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSparseSampleExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpImageSparseSampleExplicitLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSparseSampleExplicitLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSparseSampleDrefImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Dref { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpImageSparseSampleDrefImplicitLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSparseSampleDrefImplicitLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSparseSampleDrefExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Dref { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpImageSparseSampleDrefExplicitLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSparseSampleDrefExplicitLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSparseSampleProjImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpImageSparseSampleProjImplicitLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSparseSampleProjImplicitLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSparseSampleProjExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpImageSparseSampleProjExplicitLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSparseSampleProjExplicitLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSparseSampleProjDrefImplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Dref { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpImageSparseSampleProjDrefImplicitLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSparseSampleProjDrefImplicitLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSparseSampleProjDrefExplicitLod : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Dref { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpImageSparseSampleProjDrefExplicitLod(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSparseSampleProjDrefExplicitLod(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSparseFetch : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpImageSparseFetch(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSparseFetch(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSparseGather : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Component { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpImageSparseGather(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSparseGather(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSparseDrefGather : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Dref { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpImageSparseDrefGather(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSparseDrefGather(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSparseTexelsResident : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef ResidentCode { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpImageSparseTexelsResident(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSparseTexelsResident(Instruction instruction) => new(instruction);
}

public ref struct InstOpNoLine : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpNoLine(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpNoLine(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicFlagTestAndSet : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpAtomicFlagTestAndSet(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicFlagTestAndSet(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicFlagClear : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpAtomicFlagClear(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicFlagClear(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSparseRead : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpImageSparseRead(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSparseRead(Instruction instruction) => new(instruction);
}

public ref struct InstOpSizeOf : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSizeOf(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSizeOf(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypePipeStorage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypePipeStorage(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypePipeStorage(Instruction instruction) => new(instruction);
}

public ref struct InstOpConstantPipeStorage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public LiteralInteger PacketSize => Inner.GetOperand<LiteralInteger>("packetSize") ?? default;
    public LiteralInteger PacketAlignment => Inner.GetOperand<LiteralInteger>("packetAlignment") ?? default;
    public LiteralInteger Capacity => Inner.GetOperand<LiteralInteger>("capacity") ?? default;

    public InstOpConstantPipeStorage(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConstantPipeStorage(Instruction instruction) => new(instruction);
}

public ref struct InstOpCreatePipeFromPipeStorage : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef PipeStorage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpCreatePipeFromPipeStorage(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCreatePipeFromPipeStorage(Instruction instruction) => new(instruction);
}

public ref struct InstOpGetKernelLocalSizeForSubgroupCount : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SubgroupCount { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Invoke { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Param { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ParamSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef ParamAlign { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }

    public InstOpGetKernelLocalSizeForSubgroupCount(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGetKernelLocalSizeForSubgroupCount(Instruction instruction) => new(instruction);
}

public ref struct InstOpGetKernelMaxNumSubgroups : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Invoke { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Param { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef ParamSize { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ParamAlign { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGetKernelMaxNumSubgroups(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGetKernelMaxNumSubgroups(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeNamedBarrier : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeNamedBarrier(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeNamedBarrier(Instruction instruction) => new(instruction);
}

public ref struct InstOpNamedBarrierInitialize : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SubgroupCount { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpNamedBarrierInitialize(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpNamedBarrierInitialize(Instruction instruction) => new(instruction);
}

public ref struct InstOpMemoryNamedBarrier : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef NamedBarrier { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpMemoryNamedBarrier(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpMemoryNamedBarrier(Instruction instruction) => new(instruction);
}

public ref struct InstOpModuleProcessed : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralString Process => Inner.GetOperand<LiteralString>("process") ?? default;

    public InstOpModuleProcessed(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpModuleProcessed(Instruction instruction) => new(instruction);
}

public ref struct InstOpExecutionModeId : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef EntryPoint { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public ExecutionMode Mode { get => (ExecutionMode)Inner.Memory.Span[2]; set => Inner.Memory.Span[2] = (int)value; }

    public InstOpExecutionModeId(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpExecutionModeId(Instruction instruction) => new(instruction);
}

public ref struct InstOpDecorateId : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public Decoration Decoration { get => (Decoration)Inner.Memory.Span[2]; set => Inner.Memory.Span[2] = (int)value; }

    public InstOpDecorateId(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpDecorateId(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformElect : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpGroupNonUniformElect(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformElect(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformAll : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Predicate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpGroupNonUniformAll(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformAll(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformAny : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Predicate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpGroupNonUniformAny(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformAny(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformAllEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpGroupNonUniformAllEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformAllEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformBroadcast : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Id { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupNonUniformBroadcast(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformBroadcast(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformBroadcastFirst : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpGroupNonUniformBroadcastFirst(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformBroadcastFirst(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformBallot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Predicate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpGroupNonUniformBallot(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformBallot(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformInverseBallot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpGroupNonUniformInverseBallot(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformInverseBallot(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformBallotBitExtract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Index { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupNonUniformBallotBitExtract(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformBallotBitExtract(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformBallotBitCount : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupNonUniformBallotBitCount(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformBallotBitCount(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformBallotFindLSB : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpGroupNonUniformBallotFindLSB(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformBallotFindLSB(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformBallotFindMSB : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpGroupNonUniformBallotFindMSB(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformBallotFindMSB(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformShuffle : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Id { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupNonUniformShuffle(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformShuffle(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformShuffleXor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Mask { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupNonUniformShuffleXor(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformShuffleXor(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformShuffleUp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Delta { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupNonUniformShuffleUp(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformShuffleUp(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformShuffleDown : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Delta { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupNonUniformShuffleDown(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformShuffleDown(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformIAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClusterSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGroupNonUniformIAdd(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformIAdd(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformFAdd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClusterSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGroupNonUniformFAdd(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformFAdd(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformIMul : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClusterSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGroupNonUniformIMul(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformIMul(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformFMul : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClusterSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGroupNonUniformFMul(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformFMul(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformSMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClusterSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGroupNonUniformSMin(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformSMin(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformUMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClusterSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGroupNonUniformUMin(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformUMin(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformFMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClusterSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGroupNonUniformFMin(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformFMin(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformSMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClusterSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGroupNonUniformSMax(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformSMax(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformUMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClusterSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGroupNonUniformUMax(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformUMax(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformFMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClusterSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGroupNonUniformFMax(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformFMax(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformBitwiseAnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClusterSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGroupNonUniformBitwiseAnd(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformBitwiseAnd(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformBitwiseOr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClusterSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGroupNonUniformBitwiseOr(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformBitwiseOr(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformBitwiseXor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClusterSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGroupNonUniformBitwiseXor(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformBitwiseXor(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformLogicalAnd : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClusterSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGroupNonUniformLogicalAnd(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformLogicalAnd(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformLogicalOr : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClusterSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGroupNonUniformLogicalOr(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformLogicalOr(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformLogicalXor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClusterSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGroupNonUniformLogicalXor(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformLogicalXor(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformQuadBroadcast : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Index { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupNonUniformQuadBroadcast(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformQuadBroadcast(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformQuadSwap : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Direction { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupNonUniformQuadSwap(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformQuadSwap(Instruction instruction) => new(instruction);
}

public ref struct InstOpCopyLogical : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpCopyLogical(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCopyLogical(Instruction instruction) => new(instruction);
}

public ref struct InstOpPtrEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpPtrEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpPtrEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpPtrNotEqual : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpPtrNotEqual(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpPtrNotEqual(Instruction instruction) => new(instruction);
}

public ref struct InstOpPtrDiff : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpPtrDiff(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpPtrDiff(Instruction instruction) => new(instruction);
}

public ref struct InstOpColorAttachmentReadEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Attachment { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Sample { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpColorAttachmentReadEXT(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpColorAttachmentReadEXT(Instruction instruction) => new(instruction);
}

public ref struct InstOpDepthAttachmentReadEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Sample { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpDepthAttachmentReadEXT(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpDepthAttachmentReadEXT(Instruction instruction) => new(instruction);
}

public ref struct InstOpStencilAttachmentReadEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Sample { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpStencilAttachmentReadEXT(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpStencilAttachmentReadEXT(Instruction instruction) => new(instruction);
}

public ref struct InstOpTerminateInvocation : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpTerminateInvocation(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTerminateInvocation(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeUntypedPointerKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public StorageClass Storageclass { get => (StorageClass)Inner.Memory.Span[2]; set => Inner.Memory.Span[2] = (int)value; }

    public InstOpTypeUntypedPointerKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeUntypedPointerKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpUntypedVariableKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public StorageClass Storageclass { get => (StorageClass)Inner.Memory.Span[3]; set => Inner.Memory.Span[3] = (int)value; }
    public IdRef DataType { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Initializer { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpUntypedVariableKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUntypedVariableKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpUntypedAccessChainKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BaseType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef BaseId { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpUntypedAccessChainKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUntypedAccessChainKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpUntypedInBoundsAccessChainKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BaseType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef BaseId { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpUntypedInBoundsAccessChainKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUntypedInBoundsAccessChainKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupBallotKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Predicate { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupBallotKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupBallotKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupFirstInvocationKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupFirstInvocationKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupFirstInvocationKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpUntypedPtrAccessChainKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BaseType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef BaseId { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Element { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpUntypedPtrAccessChainKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUntypedPtrAccessChainKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpUntypedInBoundsPtrAccessChainKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BaseType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef BaseId { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Element { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpUntypedInBoundsPtrAccessChainKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUntypedInBoundsPtrAccessChainKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpUntypedArrayLengthKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Structure { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger Arraymember => Inner.GetOperand<LiteralInteger>("arraymember") ?? default;

    public InstOpUntypedArrayLengthKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUntypedArrayLengthKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpUntypedPrefetchKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef PointerType { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef NumBytes { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RW { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Locality { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef CacheType { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpUntypedPrefetchKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUntypedPrefetchKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAllKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Predicate { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAllKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAllKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAnyKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Predicate { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAnyKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAnyKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAllEqualKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Predicate { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAllEqualKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAllEqualKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformRotateKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Delta { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClusterSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpGroupNonUniformRotateKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformRotateKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupReadInvocationKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Index { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupReadInvocationKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupReadInvocationKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpExtInstWithForwardRefsKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Set { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public int Instruction { get => Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpExtInstWithForwardRefsKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpExtInstWithForwardRefsKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpTraceRayKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Accel { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef RayFlags { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef CullMask { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef SBTOffset { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef SBTStride { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef MissIndex { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef RayOrigin { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef RayTmin { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }
    public IdRef RayDirection { get => new IdRef(Inner.Memory.Span[9]); set => Inner.Memory.Span[9] = value; }
    public IdRef RayTmax { get => new IdRef(Inner.Memory.Span[10]); set => Inner.Memory.Span[10] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[11]); set => Inner.Memory.Span[11] = value; }

    public InstOpTraceRayKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTraceRayKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpExecuteCallableKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef SBTIndex { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef CallableData { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpExecuteCallableKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpExecuteCallableKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpConvertUToAccelerationStructureKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Accel { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConvertUToAccelerationStructureKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConvertUToAccelerationStructureKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpIgnoreIntersectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpIgnoreIntersectionKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIgnoreIntersectionKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpTerminateRayKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpTerminateRayKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTerminateRayKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpSDot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Vector1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Vector2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public PackedVectorFormat PackedVectorFormat { get => (PackedVectorFormat)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpSDot(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSDot(Instruction instruction) => new(instruction);
}

public ref struct InstOpUDot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Vector1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Vector2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public PackedVectorFormat PackedVectorFormat { get => (PackedVectorFormat)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpUDot(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUDot(Instruction instruction) => new(instruction);
}

public ref struct InstOpSUDot : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Vector1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Vector2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public PackedVectorFormat PackedVectorFormat { get => (PackedVectorFormat)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpSUDot(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSUDot(Instruction instruction) => new(instruction);
}

public ref struct InstOpSDotAccSat : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Vector1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Vector2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Accumulator { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public PackedVectorFormat PackedVectorFormat { get => (PackedVectorFormat)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpSDotAccSat(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSDotAccSat(Instruction instruction) => new(instruction);
}

public ref struct InstOpUDotAccSat : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Vector1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Vector2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Accumulator { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public PackedVectorFormat PackedVectorFormat { get => (PackedVectorFormat)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpUDotAccSat(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUDotAccSat(Instruction instruction) => new(instruction);
}

public ref struct InstOpSUDotAccSat : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Vector1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Vector2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Accumulator { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public PackedVectorFormat PackedVectorFormat { get => (PackedVectorFormat)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpSUDotAccSat(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSUDotAccSat(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeCooperativeMatrixKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef ComponentType { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Scope { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Rows { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Columns { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Use { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpTypeCooperativeMatrixKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeCooperativeMatrixKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpCooperativeMatrixLoadKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef MemoryLayout { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Stride { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public MemoryAccessMask MemoryOperand { get => (MemoryAccessMask)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpCooperativeMatrixLoadKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCooperativeMatrixLoadKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpCooperativeMatrixStoreKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef ObjectId { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef MemoryLayout { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Stride { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public MemoryAccessMask MemoryOperand { get => (MemoryAccessMask)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpCooperativeMatrixStoreKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCooperativeMatrixStoreKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpCooperativeMatrixMulAddKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef B { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef C { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public CooperativeMatrixOperandsMask CooperativeMatrixOperands { get => (CooperativeMatrixOperandsMask)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpCooperativeMatrixMulAddKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCooperativeMatrixMulAddKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpCooperativeMatrixLengthKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Type { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpCooperativeMatrixLengthKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCooperativeMatrixLengthKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpConstantCompositeReplicateEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConstantCompositeReplicateEXT(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConstantCompositeReplicateEXT(Instruction instruction) => new(instruction);
}

public ref struct InstOpSpecConstantCompositeReplicateEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSpecConstantCompositeReplicateEXT(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSpecConstantCompositeReplicateEXT(Instruction instruction) => new(instruction);
}

public ref struct InstOpCompositeConstructReplicateEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpCompositeConstructReplicateEXT(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCompositeConstructReplicateEXT(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeRayQueryKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeRayQueryKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeRayQueryKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryInitializeKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Accel { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayFlags { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef CullMask { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef RayOrigin { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef RayTMin { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef RayDirection { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef RayTMax { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }

    public InstOpRayQueryInitializeKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryInitializeKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryTerminateKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpRayQueryTerminateKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryTerminateKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGenerateIntersectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef HitT { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpRayQueryGenerateIntersectionKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGenerateIntersectionKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryConfirmIntersectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpRayQueryConfirmIntersectionKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryConfirmIntersectionKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryProceedKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpRayQueryProceedKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryProceedKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetIntersectionTypeKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Intersection { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpRayQueryGetIntersectionTypeKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetIntersectionTypeKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSampleWeightedQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Texture { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinates { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Weights { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpImageSampleWeightedQCOM(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSampleWeightedQCOM(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageBoxFilterQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Texture { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinates { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef BoxSize { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpImageBoxFilterQCOM(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageBoxFilterQCOM(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageBlockMatchSSDQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Target { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef TargetCoordinates { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Reference { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ReferenceCoordinates { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef BlockSize { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }

    public InstOpImageBlockMatchSSDQCOM(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageBlockMatchSSDQCOM(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageBlockMatchSADQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Target { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef TargetCoordinates { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Reference { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ReferenceCoordinates { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef BlockSize { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }

    public InstOpImageBlockMatchSADQCOM(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageBlockMatchSADQCOM(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageBlockMatchWindowSSDQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef TargetSampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef TargetCoordinates { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef ReferenceSampledImage { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ReferenceCoordinates { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef BlockSize { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }

    public InstOpImageBlockMatchWindowSSDQCOM(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageBlockMatchWindowSSDQCOM(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageBlockMatchWindowSADQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef TargetSampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef TargetCoordinates { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef ReferenceSampledImage { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ReferenceCoordinates { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef BlockSize { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }

    public InstOpImageBlockMatchWindowSADQCOM(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageBlockMatchWindowSADQCOM(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageBlockMatchGatherSSDQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef TargetSampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef TargetCoordinates { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef ReferenceSampledImage { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ReferenceCoordinates { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef BlockSize { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }

    public InstOpImageBlockMatchGatherSSDQCOM(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageBlockMatchGatherSSDQCOM(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageBlockMatchGatherSADQCOM : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef TargetSampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef TargetCoordinates { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef ReferenceSampledImage { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ReferenceCoordinates { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef BlockSize { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }

    public InstOpImageBlockMatchGatherSADQCOM(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageBlockMatchGatherSADQCOM(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupIAddNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupIAddNonUniformAMD(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupIAddNonUniformAMD(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupFAddNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupFAddNonUniformAMD(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupFAddNonUniformAMD(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupFMinNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupFMinNonUniformAMD(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupFMinNonUniformAMD(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupUMinNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupUMinNonUniformAMD(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupUMinNonUniformAMD(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupSMinNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupSMinNonUniformAMD(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupSMinNonUniformAMD(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupFMaxNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupFMaxNonUniformAMD(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupFMaxNonUniformAMD(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupUMaxNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupUMaxNonUniformAMD(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupUMaxNonUniformAMD(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupSMaxNonUniformAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupSMaxNonUniformAMD(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupSMaxNonUniformAMD(Instruction instruction) => new(instruction);
}

public ref struct InstOpFragmentMaskFetchAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFragmentMaskFetchAMD(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFragmentMaskFetchAMD(Instruction instruction) => new(instruction);
}

public ref struct InstOpFragmentFetchAMD : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef FragmentIndex { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpFragmentFetchAMD(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFragmentFetchAMD(Instruction instruction) => new(instruction);
}

public ref struct InstOpReadClockKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Scope { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpReadClockKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpReadClockKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpAllocateNodePayloadsAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Visibility { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PayloadCount { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef NodeIndex { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpAllocateNodePayloadsAMDX(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAllocateNodePayloadsAMDX(Instruction instruction) => new(instruction);
}

public ref struct InstOpEnqueueNodePayloadsAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef PayloadArray { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpEnqueueNodePayloadsAMDX(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpEnqueueNodePayloadsAMDX(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeNodePayloadArrayAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef PayloadType { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpTypeNodePayloadArrayAMDX(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeNodePayloadArrayAMDX(Instruction instruction) => new(instruction);
}

public ref struct InstOpFinishWritingNodePayloadAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpFinishWritingNodePayloadAMDX(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFinishWritingNodePayloadAMDX(Instruction instruction) => new(instruction);
}

public ref struct InstOpNodePayloadArrayLengthAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef PayloadArray { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpNodePayloadArrayLengthAMDX(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpNodePayloadArrayLengthAMDX(Instruction instruction) => new(instruction);
}

public ref struct InstOpIsNodePayloadValidAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef PayloadType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef NodeIndex { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpIsNodePayloadValidAMDX(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIsNodePayloadValidAMDX(Instruction instruction) => new(instruction);
}

public ref struct InstOpConstantStringAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public LiteralString LiteralString => Inner.GetOperand<LiteralString>("literalString") ?? default;

    public InstOpConstantStringAMDX(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConstantStringAMDX(Instruction instruction) => new(instruction);
}

public ref struct InstOpSpecConstantStringAMDX : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public LiteralString LiteralString => Inner.GetOperand<LiteralString>("literalString") ?? default;

    public InstOpSpecConstantStringAMDX(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSpecConstantStringAMDX(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformQuadAllKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Predicate { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpGroupNonUniformQuadAllKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformQuadAllKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformQuadAnyKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Predicate { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpGroupNonUniformQuadAnyKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformQuadAnyKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectRecordHitMotionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef AccelerationStructure { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef InstanceId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PrimitiveId { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef GeometryIndex { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef HitKind { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef SBTRecordOffset { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef SBTRecordStride { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }
    public IdRef Origin { get => new IdRef(Inner.Memory.Span[9]); set => Inner.Memory.Span[9] = value; }
    public IdRef TMin { get => new IdRef(Inner.Memory.Span[10]); set => Inner.Memory.Span[10] = value; }
    public IdRef Direction { get => new IdRef(Inner.Memory.Span[11]); set => Inner.Memory.Span[11] = value; }
    public IdRef TMax { get => new IdRef(Inner.Memory.Span[12]); set => Inner.Memory.Span[12] = value; }
    public IdRef CurrentTime { get => new IdRef(Inner.Memory.Span[13]); set => Inner.Memory.Span[13] = value; }
    public IdRef HitObjectAttributes { get => new IdRef(Inner.Memory.Span[14]); set => Inner.Memory.Span[14] = value; }

    public InstOpHitObjectRecordHitMotionNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectRecordHitMotionNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectRecordHitWithIndexMotionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef AccelerationStructure { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef InstanceId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PrimitiveId { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef GeometryIndex { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef HitKind { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef SBTRecordIndex { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef Origin { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }
    public IdRef TMin { get => new IdRef(Inner.Memory.Span[9]); set => Inner.Memory.Span[9] = value; }
    public IdRef Direction { get => new IdRef(Inner.Memory.Span[10]); set => Inner.Memory.Span[10] = value; }
    public IdRef TMax { get => new IdRef(Inner.Memory.Span[11]); set => Inner.Memory.Span[11] = value; }
    public IdRef CurrentTime { get => new IdRef(Inner.Memory.Span[12]); set => Inner.Memory.Span[12] = value; }
    public IdRef HitObjectAttributes { get => new IdRef(Inner.Memory.Span[13]); set => Inner.Memory.Span[13] = value; }

    public InstOpHitObjectRecordHitWithIndexMotionNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectRecordHitWithIndexMotionNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectRecordMissMotionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef SBTIndex { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Origin { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef TMin { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Direction { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef TMax { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef CurrentTime { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }

    public InstOpHitObjectRecordMissMotionNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectRecordMissMotionNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectGetWorldToObjectNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectGetWorldToObjectNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectGetWorldToObjectNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectGetObjectToWorldNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectGetObjectToWorldNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectGetObjectToWorldNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectGetObjectRayDirectionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectGetObjectRayDirectionNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectGetObjectRayDirectionNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectGetObjectRayOriginNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectGetObjectRayOriginNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectGetObjectRayOriginNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectTraceRayMotionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef AccelerationStructure { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayFlags { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Cullmask { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef SBTRecordOffset { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef SBTRecordStride { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef MissIndex { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef Origin { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }
    public IdRef TMin { get => new IdRef(Inner.Memory.Span[9]); set => Inner.Memory.Span[9] = value; }
    public IdRef Direction { get => new IdRef(Inner.Memory.Span[10]); set => Inner.Memory.Span[10] = value; }
    public IdRef TMax { get => new IdRef(Inner.Memory.Span[11]); set => Inner.Memory.Span[11] = value; }
    public IdRef Time { get => new IdRef(Inner.Memory.Span[12]); set => Inner.Memory.Span[12] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[13]); set => Inner.Memory.Span[13] = value; }

    public InstOpHitObjectTraceRayMotionNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectTraceRayMotionNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectGetShaderRecordBufferHandleNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectGetShaderRecordBufferHandleNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectGetShaderRecordBufferHandleNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectGetShaderBindingTableRecordIndexNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectGetShaderBindingTableRecordIndexNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectGetShaderBindingTableRecordIndexNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectRecordEmptyNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpHitObjectRecordEmptyNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectRecordEmptyNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectTraceRayNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef AccelerationStructure { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayFlags { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Cullmask { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef SBTRecordOffset { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef SBTRecordStride { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef MissIndex { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef Origin { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }
    public IdRef TMin { get => new IdRef(Inner.Memory.Span[9]); set => Inner.Memory.Span[9] = value; }
    public IdRef Direction { get => new IdRef(Inner.Memory.Span[10]); set => Inner.Memory.Span[10] = value; }
    public IdRef TMax { get => new IdRef(Inner.Memory.Span[11]); set => Inner.Memory.Span[11] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[12]); set => Inner.Memory.Span[12] = value; }

    public InstOpHitObjectTraceRayNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectTraceRayNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectRecordHitNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef AccelerationStructure { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef InstanceId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PrimitiveId { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef GeometryIndex { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef HitKind { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef SBTRecordOffset { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef SBTRecordStride { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }
    public IdRef Origin { get => new IdRef(Inner.Memory.Span[9]); set => Inner.Memory.Span[9] = value; }
    public IdRef TMin { get => new IdRef(Inner.Memory.Span[10]); set => Inner.Memory.Span[10] = value; }
    public IdRef Direction { get => new IdRef(Inner.Memory.Span[11]); set => Inner.Memory.Span[11] = value; }
    public IdRef TMax { get => new IdRef(Inner.Memory.Span[12]); set => Inner.Memory.Span[12] = value; }
    public IdRef HitObjectAttributes { get => new IdRef(Inner.Memory.Span[13]); set => Inner.Memory.Span[13] = value; }

    public InstOpHitObjectRecordHitNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectRecordHitNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectRecordHitWithIndexNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef AccelerationStructure { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef InstanceId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PrimitiveId { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef GeometryIndex { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef HitKind { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef SBTRecordIndex { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef Origin { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }
    public IdRef TMin { get => new IdRef(Inner.Memory.Span[9]); set => Inner.Memory.Span[9] = value; }
    public IdRef Direction { get => new IdRef(Inner.Memory.Span[10]); set => Inner.Memory.Span[10] = value; }
    public IdRef TMax { get => new IdRef(Inner.Memory.Span[11]); set => Inner.Memory.Span[11] = value; }
    public IdRef HitObjectAttributes { get => new IdRef(Inner.Memory.Span[12]); set => Inner.Memory.Span[12] = value; }

    public InstOpHitObjectRecordHitWithIndexNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectRecordHitWithIndexNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectRecordMissNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef SBTIndex { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Origin { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef TMin { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Direction { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef TMax { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpHitObjectRecordMissNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectRecordMissNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectExecuteShaderNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpHitObjectExecuteShaderNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectExecuteShaderNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectGetCurrentTimeNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectGetCurrentTimeNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectGetCurrentTimeNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectGetAttributesNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef HitObjectAttribute { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpHitObjectGetAttributesNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectGetAttributesNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectGetHitKindNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectGetHitKindNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectGetHitKindNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectGetPrimitiveIndexNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectGetPrimitiveIndexNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectGetPrimitiveIndexNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectGetGeometryIndexNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectGetGeometryIndexNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectGetGeometryIndexNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectGetInstanceIdNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectGetInstanceIdNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectGetInstanceIdNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectGetInstanceCustomIndexNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectGetInstanceCustomIndexNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectGetInstanceCustomIndexNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectGetWorldRayDirectionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectGetWorldRayDirectionNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectGetWorldRayDirectionNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectGetWorldRayOriginNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectGetWorldRayOriginNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectGetWorldRayOriginNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectGetRayTMaxNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectGetRayTMaxNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectGetRayTMaxNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectGetRayTMinNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectGetRayTMinNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectGetRayTMinNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectIsEmptyNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectIsEmptyNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectIsEmptyNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectIsHitNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectIsHitNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectIsHitNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpHitObjectIsMissNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpHitObjectIsMissNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpHitObjectIsMissNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpReorderThreadWithHitObjectNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef HitObject { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Hint { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Bits { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpReorderThreadWithHitObjectNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpReorderThreadWithHitObjectNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpReorderThreadWithHintNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Hint { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Bits { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpReorderThreadWithHintNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpReorderThreadWithHintNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeHitObjectNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeHitObjectNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeHitObjectNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpImageSampleFootprintNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SampledImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Granularity { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Coarse { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public ImageOperandsMask Imageoperands { get => (ImageOperandsMask)Inner.Memory.Span[7]; set => Inner.Memory.Span[7] = (int)value; }

    public InstOpImageSampleFootprintNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpImageSampleFootprintNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpCooperativeMatrixConvertNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Matrix { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpCooperativeMatrixConvertNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCooperativeMatrixConvertNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpEmitMeshTasksEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef GroupCountX { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef GroupCountY { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef GroupCountZ { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpEmitMeshTasksEXT(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpEmitMeshTasksEXT(Instruction instruction) => new(instruction);
}

public ref struct InstOpSetMeshOutputsEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef VertexCount { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef PrimitiveCount { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpSetMeshOutputsEXT(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSetMeshOutputsEXT(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupNonUniformPartitionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpGroupNonUniformPartitionNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupNonUniformPartitionNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpWritePackedPrimitiveIndices4x8NV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef IndexOffset { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef PackedIndices { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpWritePackedPrimitiveIndices4x8NV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpWritePackedPrimitiveIndices4x8NV(Instruction instruction) => new(instruction);
}

public ref struct InstOpFetchMicroTriangleVertexPositionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Accel { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef InstanceId { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef GeometryIndex { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef PrimitiveIndex { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef Barycentric { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }

    public InstOpFetchMicroTriangleVertexPositionNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFetchMicroTriangleVertexPositionNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpFetchMicroTriangleVertexBarycentricNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Accel { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef InstanceId { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef GeometryIndex { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef PrimitiveIndex { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef Barycentric { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }

    public InstOpFetchMicroTriangleVertexBarycentricNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFetchMicroTriangleVertexBarycentricNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpReportIntersectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Hit { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef HitKind { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpReportIntersectionKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpReportIntersectionKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpIgnoreIntersectionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpIgnoreIntersectionNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIgnoreIntersectionNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpTerminateRayNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpTerminateRayNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTerminateRayNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpTraceNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Accel { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef RayFlags { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef CullMask { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef SBTOffset { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef SBTStride { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef MissIndex { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef RayOrigin { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef RayTmin { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }
    public IdRef RayDirection { get => new IdRef(Inner.Memory.Span[9]); set => Inner.Memory.Span[9] = value; }
    public IdRef RayTmax { get => new IdRef(Inner.Memory.Span[10]); set => Inner.Memory.Span[10] = value; }
    public IdRef PayloadId { get => new IdRef(Inner.Memory.Span[11]); set => Inner.Memory.Span[11] = value; }

    public InstOpTraceNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTraceNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpTraceMotionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Accel { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef RayFlags { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef CullMask { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef SBTOffset { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef SBTStride { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef MissIndex { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef RayOrigin { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef RayTmin { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }
    public IdRef RayDirection { get => new IdRef(Inner.Memory.Span[9]); set => Inner.Memory.Span[9] = value; }
    public IdRef RayTmax { get => new IdRef(Inner.Memory.Span[10]); set => Inner.Memory.Span[10] = value; }
    public IdRef Time { get => new IdRef(Inner.Memory.Span[11]); set => Inner.Memory.Span[11] = value; }
    public IdRef PayloadId { get => new IdRef(Inner.Memory.Span[12]); set => Inner.Memory.Span[12] = value; }

    public InstOpTraceMotionNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTraceMotionNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpTraceRayMotionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Accel { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef RayFlags { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef CullMask { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef SBTOffset { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef SBTStride { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef MissIndex { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef RayOrigin { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef RayTmin { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }
    public IdRef RayDirection { get => new IdRef(Inner.Memory.Span[9]); set => Inner.Memory.Span[9] = value; }
    public IdRef RayTmax { get => new IdRef(Inner.Memory.Span[10]); set => Inner.Memory.Span[10] = value; }
    public IdRef Time { get => new IdRef(Inner.Memory.Span[11]); set => Inner.Memory.Span[11] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[12]); set => Inner.Memory.Span[12] = value; }

    public InstOpTraceRayMotionNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTraceRayMotionNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetIntersectionTriangleVertexPositionsKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Intersection { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpRayQueryGetIntersectionTriangleVertexPositionsKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetIntersectionTriangleVertexPositionsKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeAccelerationStructureKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeAccelerationStructureKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeAccelerationStructureKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpExecuteCallableNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef SBTIndex { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef CallableDataId { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpExecuteCallableNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpExecuteCallableNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeCooperativeMatrixNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef ComponentType { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Rows { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Columns { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpTypeCooperativeMatrixNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeCooperativeMatrixNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpCooperativeMatrixLoadNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Stride { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef ColumnMajor { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public MemoryAccessMask Memoryaccess { get => (MemoryAccessMask)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }

    public InstOpCooperativeMatrixLoadNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCooperativeMatrixLoadNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpCooperativeMatrixStoreNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef ObjectId { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Stride { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef ColumnMajor { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public MemoryAccessMask Memoryaccess { get => (MemoryAccessMask)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpCooperativeMatrixStoreNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCooperativeMatrixStoreNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpCooperativeMatrixMulAddNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef B { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef C { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpCooperativeMatrixMulAddNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCooperativeMatrixMulAddNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpCooperativeMatrixLengthNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Type { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpCooperativeMatrixLengthNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCooperativeMatrixLengthNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpBeginInvocationInterlockEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpBeginInvocationInterlockEXT(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpBeginInvocationInterlockEXT(Instruction instruction) => new(instruction);
}

public ref struct InstOpEndInvocationInterlockEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpEndInvocationInterlockEXT(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpEndInvocationInterlockEXT(Instruction instruction) => new(instruction);
}

public ref struct InstOpCooperativeMatrixReduceNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Matrix { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public CooperativeMatrixReduceMask Reduce { get => (CooperativeMatrixReduceMask)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef CombineFunc { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpCooperativeMatrixReduceNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCooperativeMatrixReduceNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpCooperativeMatrixLoadTensorNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef ObjectId { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef TensorLayout { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public MemoryAccessMask MemoryOperand { get => (MemoryAccessMask)Inner.Memory.Span[6]; set => Inner.Memory.Span[6] = (int)value; }
    public TensorAddressingOperandsMask TensorAddressingOperands { get => (TensorAddressingOperandsMask)Inner.Memory.Span[7]; set => Inner.Memory.Span[7] = (int)value; }

    public InstOpCooperativeMatrixLoadTensorNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCooperativeMatrixLoadTensorNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpCooperativeMatrixStoreTensorNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef ObjectId { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef TensorLayout { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public MemoryAccessMask MemoryOperand { get => (MemoryAccessMask)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public TensorAddressingOperandsMask TensorAddressingOperands { get => (TensorAddressingOperandsMask)Inner.Memory.Span[5]; set => Inner.Memory.Span[5] = (int)value; }

    public InstOpCooperativeMatrixStoreTensorNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCooperativeMatrixStoreTensorNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpCooperativeMatrixPerElementOpNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Matrix { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Func { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpCooperativeMatrixPerElementOpNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCooperativeMatrixPerElementOpNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeTensorLayoutNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Dim { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef ClampMode { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpTypeTensorLayoutNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeTensorLayoutNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeTensorViewNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Dim { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef HasDimensions { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpTypeTensorViewNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeTensorViewNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpCreateTensorLayoutNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpCreateTensorLayoutNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCreateTensorLayoutNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpTensorLayoutSetDimensionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef TensorLayout { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpTensorLayoutSetDimensionNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTensorLayoutSetDimensionNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpTensorLayoutSetStrideNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef TensorLayout { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpTensorLayoutSetStrideNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTensorLayoutSetStrideNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpTensorLayoutSliceNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef TensorLayout { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpTensorLayoutSliceNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTensorLayoutSliceNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpTensorLayoutSetClampValueNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef TensorLayout { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpTensorLayoutSetClampValueNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTensorLayoutSetClampValueNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpCreateTensorViewNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpCreateTensorViewNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCreateTensorViewNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpTensorViewSetDimensionNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef TensorView { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpTensorViewSetDimensionNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTensorViewSetDimensionNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpTensorViewSetStrideNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef TensorView { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpTensorViewSetStrideNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTensorViewSetStrideNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpDemoteToHelperInvocation : IWrapperInstruction
{
    public Instruction Inner { get; set; }

    public InstOpDemoteToHelperInvocation(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpDemoteToHelperInvocation(Instruction instruction) => new(instruction);
}

public ref struct InstOpIsHelperInvocationEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpIsHelperInvocationEXT(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIsHelperInvocationEXT(Instruction instruction) => new(instruction);
}

public ref struct InstOpTensorViewSetClipNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef TensorView { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef ClipRowOffset { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef ClipRowSpan { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ClipColOffset { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef ClipColSpan { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }

    public InstOpTensorViewSetClipNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTensorViewSetClipNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpTensorLayoutSetBlockSizeNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef TensorLayout { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpTensorLayoutSetBlockSizeNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTensorLayoutSetBlockSizeNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpCooperativeMatrixTransposeNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Matrix { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpCooperativeMatrixTransposeNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCooperativeMatrixTransposeNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpConvertUToImageNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConvertUToImageNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConvertUToImageNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpConvertUToSamplerNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConvertUToSamplerNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConvertUToSamplerNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpConvertImageToUNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConvertImageToUNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConvertImageToUNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpConvertSamplerToUNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConvertSamplerToUNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConvertSamplerToUNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpConvertUToSampledImageNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConvertUToSampledImageNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConvertUToSampledImageNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpConvertSampledImageToUNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConvertSampledImageToUNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConvertSampledImageToUNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpSamplerImageAddressingModeNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralInteger BitWidth => Inner.GetOperand<LiteralInteger>("bitWidth") ?? default;

    public InstOpSamplerImageAddressingModeNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSamplerImageAddressingModeNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpRawAccessChainNV : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BaseId { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Bytestride { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Elementindex { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Byteoffset { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public RawAccessChainOperandsMask Rawaccesschainoperands { get => (RawAccessChainOperandsMask)Inner.Memory.Span[7]; set => Inner.Memory.Span[7] = (int)value; }

    public InstOpRawAccessChainNV(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRawAccessChainNV(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupShuffleINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Data { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef InvocationId { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupShuffleINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupShuffleINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupShuffleDownINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Current { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Next { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Delta { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpSubgroupShuffleDownINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupShuffleDownINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupShuffleUpINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Previous { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Current { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Delta { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpSubgroupShuffleUpINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupShuffleUpINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupShuffleXorINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Data { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupShuffleXorINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupShuffleXorINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupBlockReadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Ptr { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupBlockReadINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupBlockReadINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupBlockWriteINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Ptr { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Data { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpSubgroupBlockWriteINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupBlockWriteINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupImageBlockReadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupImageBlockReadINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupImageBlockReadINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupImageBlockWriteINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Data { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupImageBlockWriteINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupImageBlockWriteINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupImageMediaBlockReadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Width { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Height { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpSubgroupImageMediaBlockReadINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupImageMediaBlockReadINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupImageMediaBlockWriteINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Image { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Coordinate { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Width { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Height { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Data { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpSubgroupImageMediaBlockWriteINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupImageMediaBlockWriteINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpUCountLeadingZerosINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpUCountLeadingZerosINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUCountLeadingZerosINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpUCountTrailingZerosINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpUCountTrailingZerosINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUCountTrailingZerosINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpAbsISubINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpAbsISubINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAbsISubINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpAbsUSubINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpAbsUSubINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAbsUSubINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpIAddSatINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpIAddSatINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIAddSatINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpUAddSatINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpUAddSatINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUAddSatINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpIAverageINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpIAverageINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIAverageINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpUAverageINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpUAverageINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUAverageINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpIAverageRoundedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpIAverageRoundedINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIAverageRoundedINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpUAverageRoundedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpUAverageRoundedINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUAverageRoundedINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpISubSatINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpISubSatINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpISubSatINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpUSubSatINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpUSubSatINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUSubSatINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpIMul32x16INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpIMul32x16INTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpIMul32x16INTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpUMul32x16INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Operand1 { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Operand2 { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpUMul32x16INTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpUMul32x16INTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpConstantFunctionPointerINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Function { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConstantFunctionPointerINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConstantFunctionPointerINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpFunctionPointerCallINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpFunctionPointerCallINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFunctionPointerCallINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpAsmTargetINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public LiteralString Asmtarget => Inner.GetOperand<LiteralString>("asmtarget") ?? default;

    public InstOpAsmTargetINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAsmTargetINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpAsmINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Asmtype { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Target { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralString Asminstructions => Inner.GetOperand<LiteralString>("asminstructions") ?? default;
    public LiteralString Constraints => Inner.GetOperand<LiteralString>("constraints") ?? default;

    public InstOpAsmINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAsmINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpAsmCallINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Asm { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpAsmCallINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAsmCallINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicFMinEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpAtomicFMinEXT(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicFMinEXT(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicFMaxEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpAtomicFMaxEXT(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicFMaxEXT(Instruction instruction) => new(instruction);
}

public ref struct InstOpAssumeTrueKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Condition { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpAssumeTrueKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAssumeTrueKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpExpectKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef ExpectedValue { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpExpectKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpExpectKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpDecorateString : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Target { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public Decoration Decoration { get => (Decoration)Inner.Memory.Span[2]; set => Inner.Memory.Span[2] = (int)value; }

    public InstOpDecorateString(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpDecorateString(Instruction instruction) => new(instruction);
}

public ref struct InstOpMemberDecorateString : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef StructType { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public LiteralInteger Member => Inner.GetOperand<LiteralInteger>("member") ?? default;
    public Decoration Decoration { get => (Decoration)Inner.Memory.Span[2]; set => Inner.Memory.Span[2] = (int)value; }

    public InstOpMemberDecorateString(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpMemberDecorateString(Instruction instruction) => new(instruction);
}

public ref struct InstOpVmeImageINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef ImageType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Sampler { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpVmeImageINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpVmeImageINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeVmeImageINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef ImageType { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpTypeVmeImageINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeVmeImageINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeAvcImePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeAvcImePayloadINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeAvcImePayloadINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeAvcRefPayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeAvcRefPayloadINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeAvcRefPayloadINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeAvcSicPayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeAvcSicPayloadINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeAvcSicPayloadINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeAvcMcePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeAvcMcePayloadINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeAvcMcePayloadINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeAvcMceResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeAvcMceResultINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeAvcMceResultINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeAvcImeResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeAvcImeResultINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeAvcImeResultINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeAvcImeResultSingleReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeAvcImeResultSingleReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeAvcImeResultSingleReferenceStreamoutINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeAvcImeResultDualReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeAvcImeResultDualReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeAvcImeResultDualReferenceStreamoutINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeAvcImeSingleReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeAvcImeSingleReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeAvcImeSingleReferenceStreaminINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeAvcImeDualReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeAvcImeDualReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeAvcImeDualReferenceStreaminINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeAvcRefResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeAvcRefResultINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeAvcRefResultINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeAvcSicResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeAvcSicResultINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeAvcSicResultINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SliceType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Qp { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef ReferenceBasePenalty { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SliceType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Qp { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceSetInterShapePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef PackedShapePenalty { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcMceSetInterShapePenaltyINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceSetInterShapePenaltyINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SliceType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Qp { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceSetInterDirectionPenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef DirectionCost { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcMceSetInterDirectionPenaltyINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceSetInterDirectionPenaltyINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SliceType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Qp { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SliceType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Qp { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceSetMotionVectorCostFunctionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef PackedCostCenterDelta { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PackedCostTable { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef CostPrecision { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpSubgroupAvcMceSetMotionVectorCostFunctionINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceSetMotionVectorCostFunctionINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SliceType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Qp { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceSetAcOnlyHaarINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcMceSetAcOnlyHaarINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceSetAcOnlyHaarINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SourceFieldPolarity { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef ReferenceFieldPolarity { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef ForwardReferenceFieldPolarity { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef BackwardReferenceFieldPolarity { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceConvertToImePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcMceConvertToImePayloadINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceConvertToImePayloadINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceConvertToImeResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcMceConvertToImeResultINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceConvertToImeResultINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceConvertToRefPayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcMceConvertToRefPayloadINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceConvertToRefPayloadINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceConvertToRefResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcMceConvertToRefResultINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceConvertToRefResultINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceConvertToSicPayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcMceConvertToSicPayloadINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceConvertToSicPayloadINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceConvertToSicResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcMceConvertToSicResultINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceConvertToSicResultINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetMotionVectorsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcMceGetMotionVectorsINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetMotionVectorsINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetInterDistortionsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcMceGetInterDistortionsINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetInterDistortionsINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetBestInterDistortionsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcMceGetBestInterDistortionsINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetBestInterDistortionsINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetInterMajorShapeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcMceGetInterMajorShapeINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetInterMajorShapeINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetInterMinorShapeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcMceGetInterMinorShapeINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetInterMinorShapeINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetInterDirectionsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcMceGetInterDirectionsINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetInterDirectionsINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetInterMotionVectorCountINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcMceGetInterMotionVectorCountINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetInterMotionVectorCountINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetInterReferenceIdsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcMceGetInterReferenceIdsINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetInterReferenceIdsINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef PackedReferenceIds { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PackedReferenceParameterFieldPolarities { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeInitializeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcCoord { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PartitionMask { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef SADAdjustment { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpSubgroupAvcImeInitializeINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeInitializeINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeSetSingleReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RefOffset { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef SearchWindowConfig { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpSubgroupAvcImeSetSingleReferenceINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeSetSingleReferenceINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeSetDualReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef FwdRefOffset { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef BwdRefOffset { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef IdSearchWindowConfig { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpSubgroupAvcImeSetDualReferenceINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeSetDualReferenceINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeRefWindowSizeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SearchWindowConfig { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef DualRef { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcImeRefWindowSizeINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeRefWindowSizeINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeAdjustRefOffsetINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RefOffset { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef SrcCoord { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef RefWindowSize { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef ImageSize { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpSubgroupAvcImeAdjustRefOffsetINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeAdjustRefOffsetINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeConvertToMcePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcImeConvertToMcePayloadINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeConvertToMcePayloadINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeSetMaxMotionVectorCountINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef MaxMotionVectorCount { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcImeSetMaxMotionVectorCountINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeSetMaxMotionVectorCountINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeSetUnidirectionalMixDisableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcImeSetUnidirectionalMixDisableINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeSetUnidirectionalMixDisableINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Threshold { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeSetWeightedSadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef PackedSadWeights { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcImeSetWeightedSadINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeSetWeightedSadINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeEvaluateWithSingleReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef RefImage { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpSubgroupAvcImeEvaluateWithSingleReferenceINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeEvaluateWithSingleReferenceINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeEvaluateWithDualReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef FwdRefImage { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef BwdRefImage { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpSubgroupAvcImeEvaluateWithDualReferenceINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeEvaluateWithDualReferenceINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef RefImage { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef StreaminComponents { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef FwdRefImage { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef BwdRefImage { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef StreaminComponents { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }

    public InstOpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef RefImage { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef FwdRefImage { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef BwdRefImage { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef RefImage { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef StreaminComponents { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef FwdRefImage { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef BwdRefImage { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef StreaminComponents { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }

    public InstOpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeConvertToMceResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcImeConvertToMceResultINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeConvertToMceResultINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeGetSingleReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcImeGetSingleReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeGetSingleReferenceStreaminINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeGetDualReferenceStreaminINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcImeGetDualReferenceStreaminINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeGetDualReferenceStreaminINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeStripSingleReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcImeStripSingleReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeStripSingleReferenceStreamoutINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeStripDualReferenceStreamoutINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcImeStripDualReferenceStreamoutINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeStripDualReferenceStreamoutINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef MajorShape { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef MajorShape { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef MajorShape { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef MajorShape { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Direction { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef MajorShape { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Direction { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef MajorShape { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Direction { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeGetBorderReachedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef ImageSelect { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcImeGetBorderReachedINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeGetBorderReachedINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeGetTruncatedSearchIndicationINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcImeGetTruncatedSearchIndicationINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeGetTruncatedSearchIndicationINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcFmeInitializeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcCoord { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef MotionVectors { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef MajorShapes { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef MinorShapes { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef Direction { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef PixelResolution { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }
    public IdRef SadAdjustment { get => new IdRef(Inner.Memory.Span[9]); set => Inner.Memory.Span[9] = value; }

    public InstOpSubgroupAvcFmeInitializeINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcFmeInitializeINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcBmeInitializeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcCoord { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef MotionVectors { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef MajorShapes { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef MinorShapes { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef Direction { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef PixelResolution { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }
    public IdRef BidirectionalWeight { get => new IdRef(Inner.Memory.Span[9]); set => Inner.Memory.Span[9] = value; }
    public IdRef SadAdjustment { get => new IdRef(Inner.Memory.Span[10]); set => Inner.Memory.Span[10] = value; }

    public InstOpSubgroupAvcBmeInitializeINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcBmeInitializeINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcRefConvertToMcePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcRefConvertToMcePayloadINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcRefConvertToMcePayloadINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcRefSetBidirectionalMixDisableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcRefSetBidirectionalMixDisableINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcRefSetBidirectionalMixDisableINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcRefSetBilinearFilterEnableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcRefSetBilinearFilterEnableINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcRefSetBilinearFilterEnableINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcRefEvaluateWithSingleReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef RefImage { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpSubgroupAvcRefEvaluateWithSingleReferenceINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcRefEvaluateWithSingleReferenceINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcRefEvaluateWithDualReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef FwdRefImage { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef BwdRefImage { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpSubgroupAvcRefEvaluateWithDualReferenceINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcRefEvaluateWithDualReferenceINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcRefEvaluateWithMultiReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PackedReferenceIds { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpSubgroupAvcRefEvaluateWithMultiReferenceINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcRefEvaluateWithMultiReferenceINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PackedReferenceIds { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef PackedReferenceFieldPolarities { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcRefConvertToMceResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcRefConvertToMceResultINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcRefConvertToMceResultINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicInitializeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcCoord { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcSicInitializeINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicInitializeINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicConfigureSkcINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SkipBlockPartitionType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef SkipMotionVectorMask { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef MotionVectors { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef BidirectionalWeight { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef SadAdjustment { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }

    public InstOpSubgroupAvcSicConfigureSkcINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicConfigureSkcINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicConfigureIpeLumaINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef LumaIntraPartitionMask { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef IntraNeighbourAvailabilty { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef LeftEdgeLumaPixels { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef UpperLeftCornerLumaPixel { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef UpperEdgeLumaPixels { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef UpperRightEdgeLumaPixels { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }
    public IdRef SadAdjustment { get => new IdRef(Inner.Memory.Span[9]); set => Inner.Memory.Span[9] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[10]); set => Inner.Memory.Span[10] = value; }

    public InstOpSubgroupAvcSicConfigureIpeLumaINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicConfigureIpeLumaINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicConfigureIpeLumaChromaINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef LumaIntraPartitionMask { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef IntraNeighbourAvailabilty { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef LeftEdgeLumaPixels { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef UpperLeftCornerLumaPixel { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }
    public IdRef UpperEdgeLumaPixels { get => new IdRef(Inner.Memory.Span[7]); set => Inner.Memory.Span[7] = value; }
    public IdRef UpperRightEdgeLumaPixels { get => new IdRef(Inner.Memory.Span[8]); set => Inner.Memory.Span[8] = value; }
    public IdRef LeftEdgeChromaPixels { get => new IdRef(Inner.Memory.Span[9]); set => Inner.Memory.Span[9] = value; }
    public IdRef UpperLeftCornerChromaPixel { get => new IdRef(Inner.Memory.Span[10]); set => Inner.Memory.Span[10] = value; }
    public IdRef UpperEdgeChromaPixels { get => new IdRef(Inner.Memory.Span[11]); set => Inner.Memory.Span[11] = value; }
    public IdRef SadAdjustment { get => new IdRef(Inner.Memory.Span[12]); set => Inner.Memory.Span[12] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[13]); set => Inner.Memory.Span[13] = value; }

    public InstOpSubgroupAvcSicConfigureIpeLumaChromaINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicConfigureIpeLumaChromaINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicGetMotionVectorMaskINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SkipBlockPartitionType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Direction { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcSicGetMotionVectorMaskINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicGetMotionVectorMaskINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicConvertToMcePayloadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcSicConvertToMcePayloadINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicConvertToMcePayloadINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef PackedShapePenalty { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef LumaModePenalty { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef LumaPackedNeighborModes { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef LumaPackedNonDcPenalty { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef ChromaModeBasePenalty { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicSetBilinearFilterEnableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcSicSetBilinearFilterEnableINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicSetBilinearFilterEnableINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicSetSkcForwardTransformEnableINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef PackedSadCoefficients { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcSicSetSkcForwardTransformEnableINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicSetSkcForwardTransformEnableINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BlockBasedSkipType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicEvaluateIpeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpSubgroupAvcSicEvaluateIpeINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicEvaluateIpeINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicEvaluateWithSingleReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef RefImage { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpSubgroupAvcSicEvaluateWithSingleReferenceINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicEvaluateWithSingleReferenceINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicEvaluateWithDualReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef FwdRefImage { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef BwdRefImage { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpSubgroupAvcSicEvaluateWithDualReferenceINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicEvaluateWithDualReferenceINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicEvaluateWithMultiReferenceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PackedReferenceIds { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpSubgroupAvcSicEvaluateWithMultiReferenceINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicEvaluateWithMultiReferenceINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef SrcImage { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PackedReferenceIds { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef PackedReferenceFieldPolarities { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicConvertToMceResultINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcSicConvertToMceResultINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicConvertToMceResultINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicGetIpeLumaShapeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcSicGetIpeLumaShapeINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicGetIpeLumaShapeINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicGetBestIpeLumaDistortionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcSicGetBestIpeLumaDistortionINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicGetBestIpeLumaDistortionINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicGetBestIpeChromaDistortionINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcSicGetBestIpeChromaDistortionINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicGetBestIpeChromaDistortionINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicGetPackedIpeLumaModesINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcSicGetPackedIpeLumaModesINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicGetPackedIpeLumaModesINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicGetIpeChromaModeINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcSicGetIpeChromaModeINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicGetIpeChromaModeINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupAvcSicGetInterRawSadsINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Payload { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpSubgroupAvcSicGetInterRawSadsINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupAvcSicGetInterRawSadsINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpVariableLengthArrayINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Lenght { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpVariableLengthArrayINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpVariableLengthArrayINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSaveMemoryINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpSaveMemoryINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSaveMemoryINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpRestoreMemoryINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Ptr { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpRestoreMemoryINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRestoreMemoryINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatSinCosPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger FromSign => Inner.GetOperand<LiteralInteger>("fromSign") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatSinCosPiINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatSinCosPiINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatCastINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatCastINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatCastINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatCastFromIntINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger FromSign => Inner.GetOperand<LiteralInteger>("fromSign") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatCastFromIntINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatCastFromIntINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatCastToIntINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatCastToIntINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatCastToIntINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatAddINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatAddINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatAddINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatSubINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatSubINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatSubINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatMulINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatMulINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatMulINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatDivINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatDivINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatDivINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatGTINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public InstOpArbitraryFloatGTINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatGTINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatGEINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public InstOpArbitraryFloatGEINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatGEINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatLTINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public InstOpArbitraryFloatLTINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatLTINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatLEINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public InstOpArbitraryFloatLEINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatLEINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatEQINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;

    public InstOpArbitraryFloatEQINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatEQINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatRecipINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatRecipINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatRecipINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatRSqrtINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatRSqrtINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatRSqrtINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatCbrtINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatCbrtINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatCbrtINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatHypotINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatHypotINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatHypotINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatSqrtINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatSqrtINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatSqrtINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatLogINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatLogINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatLogINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatLog2INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatLog2INTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatLog2INTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatLog10INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatLog10INTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatLog10INTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatLog1pINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatLog1pINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatLog1pINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatExpINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatExpINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatExpINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatExp2INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatExp2INTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatExp2INTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatExp10INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatExp10INTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatExp10INTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatExpm1INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatExpm1INTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatExpm1INTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatSinINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatSinINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatSinINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatCosINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatCosINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatCosINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatSinCosINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatSinCosINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatSinCosINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatSinPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatSinPiINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatSinPiINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatCosPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatCosPiINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatCosPiINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatASinINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatASinINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatASinINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatASinPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatASinPiINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatASinPiINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatACosINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatACosINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatACosINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatACosPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatACosPiINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatACosPiINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatATanINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatATanINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatATanINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatATanPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatATanPiINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatATanPiINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatATan2INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatATan2INTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatATan2INTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatPowINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatPowINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatPowINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatPowRINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger M2 => Inner.GetOperand<LiteralInteger>("m2") ?? default;
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatPowRINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatPowRINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArbitraryFloatPowNINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger M1 => Inner.GetOperand<LiteralInteger>("m1") ?? default;
    public IdRef B { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger Mout => Inner.GetOperand<LiteralInteger>("mout") ?? default;
    public LiteralInteger EnableSubnormals => Inner.GetOperand<LiteralInteger>("enableSubnormals") ?? default;
    public LiteralInteger RoundingMode => Inner.GetOperand<LiteralInteger>("roundingMode") ?? default;
    public LiteralInteger RoundingAccuracy => Inner.GetOperand<LiteralInteger>("roundingAccuracy") ?? default;

    public InstOpArbitraryFloatPowNINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArbitraryFloatPowNINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpLoopControlINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public LiteralInteger Values => Inner.GetOperand<LiteralInteger>("values") ?? default;

    public InstOpLoopControlINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpLoopControlINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpAliasDomainDeclINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Name { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpAliasDomainDeclINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAliasDomainDeclINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpAliasScopeDeclINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef AliasDomain { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Name { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpAliasScopeDeclINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAliasScopeDeclINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpAliasScopeListDeclINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstOpAliasScopeListDeclINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAliasScopeListDeclINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpFixedSqrtINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef InputType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Input { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedSqrtINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFixedSqrtINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpFixedRecipINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef InputType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Input { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedRecipINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFixedRecipINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpFixedRsqrtINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef InputType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Input { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedRsqrtINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFixedRsqrtINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpFixedSinINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef InputType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Input { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedSinINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFixedSinINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpFixedCosINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef InputType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Input { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedCosINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFixedCosINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpFixedSinCosINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef InputType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Input { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedSinCosINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFixedSinCosINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpFixedSinPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef InputType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Input { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedSinPiINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFixedSinPiINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpFixedCosPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef InputType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Input { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedCosPiINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFixedCosPiINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpFixedSinCosPiINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef InputType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Input { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedSinCosPiINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFixedSinCosPiINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpFixedLogINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef InputType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Input { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedLogINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFixedLogINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpFixedExpINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef InputType { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Input { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public LiteralInteger S => Inner.GetOperand<LiteralInteger>("s") ?? default;
    public LiteralInteger I => Inner.GetOperand<LiteralInteger>("i") ?? default;
    public LiteralInteger RI => Inner.GetOperand<LiteralInteger>("rI") ?? default;
    public LiteralInteger Q => Inner.GetOperand<LiteralInteger>("q") ?? default;
    public LiteralInteger O => Inner.GetOperand<LiteralInteger>("o") ?? default;

    public InstOpFixedExpINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFixedExpINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpPtrCastToCrossWorkgroupINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpPtrCastToCrossWorkgroupINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpPtrCastToCrossWorkgroupINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpCrossWorkgroupCastToPtrINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpCrossWorkgroupCastToPtrINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCrossWorkgroupCastToPtrINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpReadPipeBlockingINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef PacketSize { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PacketAlignment { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpReadPipeBlockingINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpReadPipeBlockingINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpWritePipeBlockingINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef PacketSize { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef PacketAlignment { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpWritePipeBlockingINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpWritePipeBlockingINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpFPGARegINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Result { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Input { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpFPGARegINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpFPGARegINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetRayTMinKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpRayQueryGetRayTMinKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetRayTMinKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetRayFlagsKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpRayQueryGetRayFlagsKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetRayFlagsKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetIntersectionTKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Intersection { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpRayQueryGetIntersectionTKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetIntersectionTKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetIntersectionInstanceCustomIndexKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Intersection { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpRayQueryGetIntersectionInstanceCustomIndexKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetIntersectionInstanceCustomIndexKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetIntersectionInstanceIdKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Intersection { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpRayQueryGetIntersectionInstanceIdKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetIntersectionInstanceIdKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Intersection { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetIntersectionGeometryIndexKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Intersection { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpRayQueryGetIntersectionGeometryIndexKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetIntersectionGeometryIndexKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetIntersectionPrimitiveIndexKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Intersection { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpRayQueryGetIntersectionPrimitiveIndexKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetIntersectionPrimitiveIndexKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetIntersectionBarycentricsKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Intersection { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpRayQueryGetIntersectionBarycentricsKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetIntersectionBarycentricsKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetIntersectionFrontFaceKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Intersection { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpRayQueryGetIntersectionFrontFaceKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetIntersectionFrontFaceKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetIntersectionCandidateAABBOpaqueKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpRayQueryGetIntersectionCandidateAABBOpaqueKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetIntersectionCandidateAABBOpaqueKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetIntersectionObjectRayDirectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Intersection { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpRayQueryGetIntersectionObjectRayDirectionKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetIntersectionObjectRayDirectionKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetIntersectionObjectRayOriginKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Intersection { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpRayQueryGetIntersectionObjectRayOriginKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetIntersectionObjectRayOriginKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetWorldRayDirectionKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpRayQueryGetWorldRayDirectionKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetWorldRayDirectionKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetWorldRayOriginKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpRayQueryGetWorldRayOriginKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetWorldRayOriginKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetIntersectionObjectToWorldKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Intersection { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpRayQueryGetIntersectionObjectToWorldKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetIntersectionObjectToWorldKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpRayQueryGetIntersectionWorldToObjectKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef RayQuery { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdRef Intersection { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }

    public InstOpRayQueryGetIntersectionWorldToObjectKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpRayQueryGetIntersectionWorldToObjectKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpAtomicFAddEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Pointer { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[6]); set => Inner.Memory.Span[6] = value; }

    public InstOpAtomicFAddEXT(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpAtomicFAddEXT(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeBufferSurfaceINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public AccessQualifier AccessQualifier { get => (AccessQualifier)Inner.Memory.Span[2]; set => Inner.Memory.Span[2] = (int)value; }

    public InstOpTypeBufferSurfaceINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeBufferSurfaceINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpTypeStructContinuedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpTypeStructContinuedINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpTypeStructContinuedINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpConstantCompositeContinuedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpConstantCompositeContinuedINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConstantCompositeContinuedINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpSpecConstantCompositeContinuedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstOpSpecConstantCompositeContinuedINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSpecConstantCompositeContinuedINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpCompositeConstructContinuedINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Values { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpCompositeConstructContinuedINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpCompositeConstructContinuedINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpConvertFToBF16INTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef FloatValue { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConvertFToBF16INTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConvertFToBF16INTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpConvertBF16ToFINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef BFloat16Value { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpConvertBF16ToFINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpConvertBF16ToFINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpControlBarrierArriveINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpControlBarrierArriveINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpControlBarrierArriveINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpControlBarrierWaitINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdScope Memory { get => new IdScope(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdMemorySemantics Semantics { get => new IdMemorySemantics(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpControlBarrierWaitINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpControlBarrierWaitINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpArithmeticFenceEXT : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Target { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpArithmeticFenceEXT(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpArithmeticFenceEXT(Instruction instruction) => new(instruction);
}

public ref struct InstOpSubgroupBlockPrefetchINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Ptr { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef NumBytes { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public MemoryAccessMask Memoryaccess { get => (MemoryAccessMask)Inner.Memory.Span[3]; set => Inner.Memory.Span[3] = (int)value; }

    public InstOpSubgroupBlockPrefetchINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpSubgroupBlockPrefetchINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupIMulKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupIMulKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupIMulKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupFMulKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupFMulKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupFMulKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupBitwiseAndKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupBitwiseAndKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupBitwiseAndKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupBitwiseOrKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupBitwiseOrKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupBitwiseOrKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupBitwiseXorKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupBitwiseXorKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupBitwiseXorKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupLogicalAndKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupLogicalAndKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupLogicalAndKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupLogicalOrKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupLogicalOrKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupLogicalOrKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpGroupLogicalXorKHR : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdScope Execution { get => new IdScope(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public GroupOperation Operation { get => (GroupOperation)Inner.Memory.Span[4]; set => Inner.Memory.Span[4] = (int)value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpGroupLogicalXorKHR(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpGroupLogicalXorKHR(Instruction instruction) => new(instruction);
}

public ref struct InstOpMaskedGatherINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdResultType ResultType { get => new IdResultType(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdResult ResultId { get => new IdResult(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef PtrVector { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }
    public LiteralInteger Alignment => Inner.GetOperand<LiteralInteger>("alignment") ?? default;
    public IdRef Mask { get => new IdRef(Inner.Memory.Span[4]); set => Inner.Memory.Span[4] = value; }
    public IdRef FillEmpty { get => new IdRef(Inner.Memory.Span[5]); set => Inner.Memory.Span[5] = value; }

    public InstOpMaskedGatherINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpMaskedGatherINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstOpMaskedScatterINTEL : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef InputVector { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef PtrVector { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public LiteralInteger Alignment => Inner.GetOperand<LiteralInteger>("alignment") ?? default;
    public IdRef Mask { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstOpMaskedScatterINTEL(Instruction instruction) => Inner = instruction;
    public static implicit operator InstOpMaskedScatterINTEL(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLRound : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLRound(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLRound(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLRoundEven : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLRoundEven(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLRoundEven(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLTrunc : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLTrunc(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLTrunc(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLFAbs : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLFAbs(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLFAbs(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLSAbs : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLSAbs(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLSAbs(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLFSign : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLFSign(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLFSign(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLSSign : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLSSign(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLSSign(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLFloor : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLFloor(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLFloor(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLCeil : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLCeil(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLCeil(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLFract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLFract(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLFract(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLRadians : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Degrees { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLRadians(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLRadians(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLDegrees : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Radians { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLDegrees(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLDegrees(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLSin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLSin(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLSin(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLCos : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLCos(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLCos(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLTan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLTan(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLTan(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLAsin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLAsin(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLAsin(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLAcos : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLAcos(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLAcos(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLAtan : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Y_over_x { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLAtan(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLAtan(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLSinh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLSinh(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLSinh(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLCosh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLCosh(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLCosh(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLTanh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLTanh(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLTanh(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLAsinh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLAsinh(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLAsinh(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLAcosh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLAcosh(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLAcosh(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLAtanh : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLAtanh(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLAtanh(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLAtan2 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Y { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLAtan2(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLAtan2(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLPow : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Y { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLPow(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLPow(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLExp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLExp(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLExp(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLLog : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLLog(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLLog(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLExp2 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLExp2(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLExp2(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLLog2 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLLog2(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLLog2(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLSqrt : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLSqrt(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLSqrt(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLInverseSqrt : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLInverseSqrt(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLInverseSqrt(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLDeterminant : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLDeterminant(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLDeterminant(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLMatrixInverse : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLMatrixInverse(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLMatrixInverse(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLModf : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef I { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLModf(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLModf(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLModfStruct : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLModfStruct(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLModfStruct(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLFMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Y { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLFMin(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLFMin(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLUMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Y { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLUMin(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLUMin(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLSMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Y { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLSMin(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLSMin(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLFMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Y { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLFMax(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLFMax(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLUMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Y { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLUMax(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLUMax(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLSMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Y { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLSMax(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLSMax(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLFClamp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef MinVal { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef MaxVal { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstGLSLFClamp(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLFClamp(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLUClamp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef MinVal { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef MaxVal { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstGLSLUClamp(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLUClamp(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLSClamp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef MinVal { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef MaxVal { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstGLSLSClamp(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLSClamp(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLFMix : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Y { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstGLSLFMix(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLFMix(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLIMix : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Y { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstGLSLIMix(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLIMix(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLStep : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Edge { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLStep(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLStep(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLSmoothStep : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Edge0 { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Edge1 { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstGLSLSmoothStep(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLSmoothStep(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLFma : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef A { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef B { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef C { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstGLSLFma(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLFma(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLFrexp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Exp { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLFrexp(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLFrexp(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLFrexpStruct : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLFrexpStruct(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLFrexpStruct(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLLdexp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Exp { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLLdexp(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLLdexp(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLPackSnorm4x8 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLPackSnorm4x8(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLPackSnorm4x8(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLPackUnorm4x8 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLPackUnorm4x8(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLPackUnorm4x8(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLPackSnorm2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLPackSnorm2x16(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLPackSnorm2x16(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLPackUnorm2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLPackUnorm2x16(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLPackUnorm2x16(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLPackHalf2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLPackHalf2x16(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLPackHalf2x16(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLPackDouble2x32 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLPackDouble2x32(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLPackDouble2x32(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLUnpackSnorm2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef P { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLUnpackSnorm2x16(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLUnpackSnorm2x16(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLUnpackUnorm2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef P { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLUnpackUnorm2x16(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLUnpackUnorm2x16(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLUnpackHalf2x16 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLUnpackHalf2x16(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLUnpackHalf2x16(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLUnpackSnorm4x8 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef P { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLUnpackSnorm4x8(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLUnpackSnorm4x8(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLUnpackUnorm4x8 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef P { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLUnpackUnorm4x8(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLUnpackUnorm4x8(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLUnpackDouble2x32 : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef V { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLUnpackDouble2x32(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLUnpackDouble2x32(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLLength : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLLength(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLLength(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLDistance : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef P0 { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef P1 { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLDistance(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLDistance(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLCross : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Y { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLCross(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLCross(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLNormalize : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLNormalize(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLNormalize(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLFaceForward : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef N { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef I { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Nref { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstGLSLFaceForward(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLFaceForward(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLReflect : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef I { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef N { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLReflect(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLReflect(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLRefract : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef I { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef N { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef Eta { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstGLSLRefract(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLRefract(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLFindILsb : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLFindILsb(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLFindILsb(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLFindSMsb : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLFindSMsb(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLFindSMsb(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLFindUMsb : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Value { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLFindUMsb(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLFindUMsb(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLInterpolateAtCentroid : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Interpolant { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }

    public InstGLSLInterpolateAtCentroid(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLInterpolateAtCentroid(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLInterpolateAtSample : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Interpolant { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Sample { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLInterpolateAtSample(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLInterpolateAtSample(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLInterpolateAtOffset : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef Interpolant { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Offset { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLInterpolateAtOffset(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLInterpolateAtOffset(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLNMin : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Y { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLNMin(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLNMin(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLNMax : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef Y { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }

    public InstGLSLNMax(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLNMax(Instruction instruction) => new(instruction);
}

public ref struct InstGLSLNClamp : IWrapperInstruction
{
    public Instruction Inner { get; set; }
    public IdRef X { get => new IdRef(Inner.Memory.Span[1]); set => Inner.Memory.Span[1] = value; }
    public IdRef MinVal { get => new IdRef(Inner.Memory.Span[2]); set => Inner.Memory.Span[2] = value; }
    public IdRef MaxVal { get => new IdRef(Inner.Memory.Span[3]); set => Inner.Memory.Span[3] = value; }

    public InstGLSLNClamp(Instruction instruction) => Inner = instruction;
    public static implicit operator InstGLSLNClamp(Instruction instruction) => new(instruction);
}