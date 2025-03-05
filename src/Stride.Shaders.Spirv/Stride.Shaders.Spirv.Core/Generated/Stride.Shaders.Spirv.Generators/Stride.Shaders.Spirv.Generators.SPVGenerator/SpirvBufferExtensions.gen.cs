using static Spv.Specification;

namespace Stride.Shaders.Spirv.Core.Buffers;
public static class SpirvBufferExtensions
{
    public static Instruction AddOpNop<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpNop]);
    }

    public static Instruction AddOpUndef<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUndef, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSourceContinued<TBuffer>(this TBuffer buffer, LiteralString continuedSource)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(continuedSource);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSourceContinued, ..continuedSource.AsSpirvSpan()]);
    }

    public static Instruction AddOpSource<TBuffer>(this TBuffer buffer, SourceLanguage sourcelanguage, LiteralInteger version, IdRef? file, LiteralString? source)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(sourcelanguage) + buffer.GetWordLength(version) + buffer.GetWordLength(file) + buffer.GetWordLength(source);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSource, ..sourcelanguage.AsSpirvSpan(), ..version.AsSpirvSpan(), ..file.AsSpirvSpan(), ..source.AsSpirvSpan()]);
    }

    public static Instruction AddOpSourceExtension<TBuffer>(this TBuffer buffer, LiteralString extension)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(extension);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSourceExtension, ..extension.AsSpirvSpan()]);
    }

    public static Instruction AddOpName<TBuffer>(this TBuffer buffer, IdRef target, LiteralString name)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(name);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpName, ..target.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction AddOpMemberName<TBuffer>(this TBuffer buffer, IdRef type, LiteralInteger member, LiteralString name)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(type) + buffer.GetWordLength(member) + buffer.GetWordLength(name);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMemberName, ..type.AsSpirvSpan(), ..member.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction AddOpString<TBuffer>(this TBuffer buffer, IdResult resultId, LiteralString value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpString, ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpLine<TBuffer>(this TBuffer buffer, IdRef file, LiteralInteger line, LiteralInteger column)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(file) + buffer.GetWordLength(line) + buffer.GetWordLength(column);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLine, ..file.AsSpirvSpan(), ..line.AsSpirvSpan(), ..column.AsSpirvSpan()]);
    }

    public static Instruction AddOpExtension<TBuffer>(this TBuffer buffer, LiteralString name)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(name);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExtension, ..name.AsSpirvSpan()]);
    }

    public static Instruction AddOpExtInstImport<TBuffer>(this TBuffer buffer, IdResult resultId, LiteralString name)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(name);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExtInstImport, ..resultId.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction AddOpExtInst<TBuffer>(this TBuffer buffer, IdRef set, LiteralInteger instruction, IdResult? resultId, IdResultType? resultType, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(set) + buffer.GetWordLength(instruction) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExtInst, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..set.AsSpirvSpan(), ..instruction.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpMemoryModel<TBuffer>(this TBuffer buffer, AddressingModel addressingmodel, MemoryModel memorymodel)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(addressingmodel) + buffer.GetWordLength(memorymodel);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMemoryModel, ..addressingmodel.AsSpirvSpan(), ..memorymodel.AsSpirvSpan()]);
    }

    public static Instruction AddOpEntryPoint<TBuffer>(this TBuffer buffer, ExecutionModel executionmodel, IdRef entryPoint, LiteralString name, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(executionmodel) + buffer.GetWordLength(entryPoint) + buffer.GetWordLength(name) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpEntryPoint, ..executionmodel.AsSpirvSpan(), ..entryPoint.AsSpirvSpan(), ..name.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpExecutionMode<TBuffer>(this TBuffer buffer, IdRef entryPoint, ExecutionMode mode)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(entryPoint) + buffer.GetWordLength(mode);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExecutionMode, ..entryPoint.AsSpirvSpan(), ..mode.AsSpirvSpan()]);
    }

    public static Instruction AddOpCapability<TBuffer>(this TBuffer buffer, Capability capability)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(capability);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCapability, ..capability.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeVoid<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeVoid, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeBool<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeBool, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeInt<TBuffer>(this TBuffer buffer, IdResult resultId, LiteralInteger width, LiteralInteger signedness)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(width) + buffer.GetWordLength(signedness);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeInt, ..resultId.AsSpirvSpan(), ..width.AsSpirvSpan(), ..signedness.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeFloat<TBuffer>(this TBuffer buffer, IdResult resultId, LiteralInteger width, FPEncoding? floatingPointEncoding)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(width) + buffer.GetWordLength(floatingPointEncoding);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeFloat, ..resultId.AsSpirvSpan(), ..width.AsSpirvSpan(), ..floatingPointEncoding.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeVector<TBuffer>(this TBuffer buffer, IdResult resultId, IdRef componentType, LiteralInteger componentCount)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(componentType) + buffer.GetWordLength(componentCount);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeVector, ..resultId.AsSpirvSpan(), ..componentType.AsSpirvSpan(), ..componentCount.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeMatrix<TBuffer>(this TBuffer buffer, IdResult resultId, IdRef columnType, LiteralInteger columnCount)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(columnType) + buffer.GetWordLength(columnCount);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeMatrix, ..resultId.AsSpirvSpan(), ..columnType.AsSpirvSpan(), ..columnCount.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeImage<TBuffer>(this TBuffer buffer, IdResult resultId, IdRef sampledType, Dim dim, LiteralInteger depth, LiteralInteger arrayed, LiteralInteger mS, LiteralInteger sampled, ImageFormat imageformat, AccessQualifier? accessqualifier)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledType) + buffer.GetWordLength(dim) + buffer.GetWordLength(depth) + buffer.GetWordLength(arrayed) + buffer.GetWordLength(mS) + buffer.GetWordLength(sampled) + buffer.GetWordLength(imageformat) + buffer.GetWordLength(accessqualifier);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeImage, ..resultId.AsSpirvSpan(), ..sampledType.AsSpirvSpan(), ..dim.AsSpirvSpan(), ..depth.AsSpirvSpan(), ..arrayed.AsSpirvSpan(), ..mS.AsSpirvSpan(), ..sampled.AsSpirvSpan(), ..imageformat.AsSpirvSpan(), ..accessqualifier.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeSampler<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeSampler, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeSampledImage<TBuffer>(this TBuffer buffer, IdResult resultId, IdRef imageType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(imageType);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeSampledImage, ..resultId.AsSpirvSpan(), ..imageType.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeArray<TBuffer>(this TBuffer buffer, IdResult resultId, IdRef elementType, IdRef length)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(elementType) + buffer.GetWordLength(length);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeArray, ..resultId.AsSpirvSpan(), ..elementType.AsSpirvSpan(), ..length.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeRuntimeArray<TBuffer>(this TBuffer buffer, IdResult resultId, IdRef elementType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(elementType);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeRuntimeArray, ..resultId.AsSpirvSpan(), ..elementType.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeStruct<TBuffer>(this TBuffer buffer, IdResult resultId, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeStruct, ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeOpaque<TBuffer>(this TBuffer buffer, IdResult resultId, LiteralString thenameoftheopaquetype)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(thenameoftheopaquetype);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeOpaque, ..resultId.AsSpirvSpan(), ..thenameoftheopaquetype.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypePointer<TBuffer>(this TBuffer buffer, IdResult resultId, StorageClass storageclass, IdRef type)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass) + buffer.GetWordLength(type);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypePointer, ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan(), ..type.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeFunction<TBuffer>(this TBuffer buffer, IdResult resultId, IdRef returnType, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(returnType) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeFunction, ..resultId.AsSpirvSpan(), ..returnType.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeEvent<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeEvent, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeDeviceEvent<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeDeviceEvent, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeReserveId<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeReserveId, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeQueue<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeQueue, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypePipe<TBuffer>(this TBuffer buffer, IdResult resultId, AccessQualifier qualifier)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(qualifier);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypePipe, ..resultId.AsSpirvSpan(), ..qualifier.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeForwardPointer<TBuffer>(this TBuffer buffer, IdRef pointerType, StorageClass storageclass)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(pointerType) + buffer.GetWordLength(storageclass);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeForwardPointer, ..pointerType.AsSpirvSpan(), ..storageclass.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantTrue<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantTrue, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantFalse<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantFalse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstant<TBuffer, TValue>(this TBuffer buffer, IdResult resultId, IdResultType? resultType, TValue value)
        where TBuffer : IMutSpirvBuffer where TValue : struct, ILiteralNumber
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + value.WordCount;
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstant, ..resultType.AsSpirvSpan(), resultId, ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantComposite<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantComposite, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantSampler<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, SamplerAddressingMode sampleraddressingmode, LiteralInteger param, SamplerFilterMode samplerfiltermode)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampleraddressingmode) + buffer.GetWordLength(param) + buffer.GetWordLength(samplerfiltermode);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantSampler, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampleraddressingmode.AsSpirvSpan(), ..param.AsSpirvSpan(), ..samplerfiltermode.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantNull<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantNull, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSpecConstantTrue<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSpecConstantTrue, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSpecConstantFalse<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSpecConstantFalse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSpecConstant<TBuffer, TValue>(this TBuffer buffer, IdResult resultId, IdResultType? resultType, TValue value)
        where TBuffer : IMutSpirvBuffer where TValue : struct, ILiteralNumber
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + value.WordCount;
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSpecConstant, ..resultType.AsSpirvSpan(), resultId, ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpSpecConstantComposite<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSpecConstantComposite, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpSpecConstantOp<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, Op opcode)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(opcode);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSpecConstantOp, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..opcode.AsSpirvSpan()]);
    }

    public static Instruction AddOpFunction<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, FunctionControlMask functioncontrol, IdRef functionType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(functioncontrol) + buffer.GetWordLength(functionType);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFunction, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..functioncontrol.AsSpirvSpan(), ..functionType.AsSpirvSpan()]);
    }

    public static Instruction AddOpFunctionParameter<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFunctionParameter, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpFunctionEnd<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpFunctionEnd]);
    }

    public static Instruction AddOpFunctionCall<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef function, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(function) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFunctionCall, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..function.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpVariable<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, StorageClass storageclass, IdRef? initializer)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass) + buffer.GetWordLength(initializer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpVariable, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan(), ..initializer.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageTexelPointer<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, IdRef sample)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(sample);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageTexelPointer, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..sample.AsSpirvSpan()]);
    }

    public static Instruction AddOpLoad<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, MemoryAccessMask? memoryaccess)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memoryaccess);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLoad, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan()]);
    }

    public static Instruction AddOpStore<TBuffer>(this TBuffer buffer, IdRef pointer, IdRef objectId, MemoryAccessMask? memoryaccess)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(objectId) + buffer.GetWordLength(memoryaccess);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpStore, ..pointer.AsSpirvSpan(), ..objectId.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan()]);
    }

    public static Instruction AddOpCopyMemory<TBuffer>(this TBuffer buffer, IdRef target, IdRef source, MemoryAccessMask? memoryaccess, MemoryAccessMask? memoryaccess1)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(source) + buffer.GetWordLength(memoryaccess) + buffer.GetWordLength(memoryaccess1);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCopyMemory, ..target.AsSpirvSpan(), ..source.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan(), ..memoryaccess1.AsSpirvSpan()]);
    }

    public static Instruction AddOpCopyMemorySized<TBuffer>(this TBuffer buffer, IdRef target, IdRef source, IdRef size, MemoryAccessMask? memoryaccess, MemoryAccessMask? memoryaccess1)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(source) + buffer.GetWordLength(size) + buffer.GetWordLength(memoryaccess) + buffer.GetWordLength(memoryaccess1);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCopyMemorySized, ..target.AsSpirvSpan(), ..source.AsSpirvSpan(), ..size.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan(), ..memoryaccess1.AsSpirvSpan()]);
    }

    public static Instruction AddOpAccessChain<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAccessChain, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpInBoundsAccessChain<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpInBoundsAccessChain, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpPtrAccessChain<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef element, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(element) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpPtrAccessChain, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..element.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpArrayLength<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef structure, LiteralInteger arraymember)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(structure) + buffer.GetWordLength(arraymember);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArrayLength, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..structure.AsSpirvSpan(), ..arraymember.AsSpirvSpan()]);
    }

    public static Instruction AddOpGenericPtrMemSemantics<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGenericPtrMemSemantics, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction AddOpInBoundsPtrAccessChain<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef element, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(element) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpInBoundsPtrAccessChain, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..element.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpDecorate<TBuffer>(this TBuffer buffer, IdRef target, Decoration decoration, int? additional1 = null, int? additional2 = null, string? additionalString = null)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(decoration) + buffer.GetWordLength(additional1) + buffer.GetWordLength(additional2) + buffer.GetWordLength(additionalString);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDecorate, target, ..decoration.AsSpirvSpan(), ..additional1.AsSpirvSpan(), ..additional2.AsSpirvSpan(), ..additionalString.AsSpirvSpan()]);
    }

    public static Instruction AddOpMemberDecorate<TBuffer>(this TBuffer buffer, IdRef structureType, LiteralInteger member, Decoration decoration, int? additional1 = null, int? additional2 = null, string? additionalString = null)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(structureType) + buffer.GetWordLength(member) + buffer.GetWordLength(decoration) + buffer.GetWordLength(additional1) + buffer.GetWordLength(additional2) + buffer.GetWordLength(additionalString);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMemberDecorate, ..structureType.AsSpirvSpan(), ..member.AsSpirvSpan(), ..decoration.AsSpirvSpan(), ..additional1.AsSpirvSpan(), ..additional2.AsSpirvSpan(), ..additionalString.AsSpirvSpan()]);
    }

    public static Instruction AddOpDecorationGroup<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDecorationGroup, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupDecorate<TBuffer>(this TBuffer buffer, IdRef decorationGroup, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(decorationGroup) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupDecorate, ..decorationGroup.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupMemberDecorate<TBuffer>(this TBuffer buffer, IdRef decorationGroup, Span<PairIdRefLiteralInteger> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(decorationGroup) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupMemberDecorate, ..decorationGroup.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpVectorExtractDynamic<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector, IdRef index)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector) + buffer.GetWordLength(index);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpVectorExtractDynamic, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan(), ..index.AsSpirvSpan()]);
    }

    public static Instruction AddOpVectorInsertDynamic<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector, IdRef component, IdRef index)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector) + buffer.GetWordLength(component) + buffer.GetWordLength(index);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpVectorInsertDynamic, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan(), ..component.AsSpirvSpan(), ..index.AsSpirvSpan()]);
    }

    public static Instruction AddOpVectorShuffle<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, Span<LiteralInteger> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpVectorShuffle, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpCompositeConstruct<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCompositeConstruct, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpCompositeExtract<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef composite, Span<LiteralInteger> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(composite) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCompositeExtract, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..composite.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpCompositeInsert<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef objectId, IdRef composite, Span<LiteralInteger> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(objectId) + buffer.GetWordLength(composite) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCompositeInsert, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..objectId.AsSpirvSpan(), ..composite.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpCopyObject<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCopyObject, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpTranspose<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef matrix)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(matrix);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTranspose, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..matrix.AsSpirvSpan()]);
    }

    public static Instruction AddOpSampledImage<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef sampler)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(sampler);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSampledImage, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..sampler.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleImplicitLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleExplicitLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleDrefImplicitLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleDrefImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleDrefExplicitLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleDrefExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleProjImplicitLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleProjImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleProjExplicitLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleProjExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleProjDrefImplicitLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleProjDrefImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleProjDrefExplicitLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleProjDrefExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageFetch<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageFetch, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageGather<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef component, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(component) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageGather, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..component.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageDrefGather<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageDrefGather, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageRead<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageRead, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageWrite<TBuffer>(this TBuffer buffer, IdRef image, IdRef coordinate, IdRef texel, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(texel) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageWrite, ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..texel.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImage<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImage, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageQueryFormat<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageQueryFormat, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageQueryOrder<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageQueryOrder, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageQuerySizeLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef levelofDetail)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(levelofDetail);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageQuerySizeLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..levelofDetail.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageQuerySize<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageQuerySize, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageQueryLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageQueryLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageQueryLevels<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageQueryLevels, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageQuerySamples<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageQuerySamples, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertFToU<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef floatValue)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(floatValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertFToU, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..floatValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertFToS<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef floatValue)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(floatValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertFToS, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..floatValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertSToF<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef signedValue)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(signedValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertSToF, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..signedValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertUToF<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef unsignedValue)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(unsignedValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertUToF, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..unsignedValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpUConvert<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef unsignedValue)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(unsignedValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUConvert, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..unsignedValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpSConvert<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef signedValue)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(signedValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSConvert, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..signedValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpFConvert<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef floatValue)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(floatValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFConvert, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..floatValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpQuantizeToF16<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpQuantizeToF16, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertPtrToU<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertPtrToU, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction AddOpSatConvertSToU<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef signedValue)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(signedValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSatConvertSToU, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..signedValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpSatConvertUToS<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef unsignedValue)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(unsignedValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSatConvertUToS, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..unsignedValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertUToPtr<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef integerValue)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(integerValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertUToPtr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..integerValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpPtrCastToGeneric<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpPtrCastToGeneric, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction AddOpGenericCastToPtr<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGenericCastToPtr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction AddOpGenericCastToPtrExplicit<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, StorageClass storage)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(storage);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGenericCastToPtrExplicit, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..storage.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitcast<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitcast, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpSNegate<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSNegate, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpFNegate<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFNegate, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpIAdd<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFAdd<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpISub<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpISub, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFSub<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFSub, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpIMul<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIMul, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFMul<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFMul, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUDiv<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUDiv, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDiv<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDiv, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFDiv<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFDiv, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUMod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUMod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpSRem<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSRem, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpSMod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSMod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFRem<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFRem, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFMod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFMod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpVectorTimesScalar<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector, IdRef scalar)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector) + buffer.GetWordLength(scalar);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpVectorTimesScalar, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan(), ..scalar.AsSpirvSpan()]);
    }

    public static Instruction AddOpMatrixTimesScalar<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef matrix, IdRef scalar)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(matrix) + buffer.GetWordLength(scalar);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMatrixTimesScalar, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..matrix.AsSpirvSpan(), ..scalar.AsSpirvSpan()]);
    }

    public static Instruction AddOpVectorTimesMatrix<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector, IdRef matrix)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector) + buffer.GetWordLength(matrix);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpVectorTimesMatrix, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan(), ..matrix.AsSpirvSpan()]);
    }

    public static Instruction AddOpMatrixTimesVector<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef matrix, IdRef vector)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(matrix) + buffer.GetWordLength(vector);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMatrixTimesVector, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..matrix.AsSpirvSpan(), ..vector.AsSpirvSpan()]);
    }

    public static Instruction AddOpMatrixTimesMatrix<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef leftMatrix, IdRef rightMatrix)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(leftMatrix) + buffer.GetWordLength(rightMatrix);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMatrixTimesMatrix, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..leftMatrix.AsSpirvSpan(), ..rightMatrix.AsSpirvSpan()]);
    }

    public static Instruction AddOpOuterProduct<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpOuterProduct, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan()]);
    }

    public static Instruction AddOpDot<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan()]);
    }

    public static Instruction AddOpIAddCarry<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIAddCarry, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpISubBorrow<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpISubBorrow, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUMulExtended<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUMulExtended, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpSMulExtended<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSMulExtended, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpAny<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAny, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan()]);
    }

    public static Instruction AddOpAll<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAll, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan()]);
    }

    public static Instruction AddOpIsNan<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIsNan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpIsInf<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIsInf, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpIsFinite<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIsFinite, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpIsNormal<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIsNormal, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpSignBitSet<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSignBitSet, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpLessOrGreater<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef x, IdRef y)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x) + buffer.GetWordLength(y);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLessOrGreater, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan(), ..y.AsSpirvSpan()]);
    }

    public static Instruction AddOpOrdered<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef x, IdRef y)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x) + buffer.GetWordLength(y);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpOrdered, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan(), ..y.AsSpirvSpan()]);
    }

    public static Instruction AddOpUnordered<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef x, IdRef y)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x) + buffer.GetWordLength(y);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUnordered, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan(), ..y.AsSpirvSpan()]);
    }

    public static Instruction AddOpLogicalEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLogicalEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpLogicalNotEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLogicalNotEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpLogicalOr<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLogicalOr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpLogicalAnd<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLogicalAnd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpLogicalNot<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLogicalNot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpSelect<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef condition, IdRef object1, IdRef object2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(condition) + buffer.GetWordLength(object1) + buffer.GetWordLength(object2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSelect, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..condition.AsSpirvSpan(), ..object1.AsSpirvSpan(), ..object2.AsSpirvSpan()]);
    }

    public static Instruction AddOpIEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpINotEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpINotEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUGreaterThan<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUGreaterThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpSGreaterThan<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSGreaterThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUGreaterThanEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUGreaterThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpSGreaterThanEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSGreaterThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpULessThan<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpULessThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpSLessThan<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSLessThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpULessThanEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpULessThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpSLessThanEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSLessThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFOrdEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFOrdEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFUnordEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFUnordEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFOrdNotEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFOrdNotEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFUnordNotEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFUnordNotEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFOrdLessThan<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFOrdLessThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFUnordLessThan<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFUnordLessThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFOrdGreaterThan<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFOrdGreaterThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFUnordGreaterThan<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFUnordGreaterThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFOrdLessThanEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFOrdLessThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFUnordLessThanEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFUnordLessThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFOrdGreaterThanEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFOrdGreaterThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFUnordGreaterThanEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFUnordGreaterThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpShiftRightLogical<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef shift)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(shift);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpShiftRightLogical, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..shift.AsSpirvSpan()]);
    }

    public static Instruction AddOpShiftRightArithmetic<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef shift)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(shift);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpShiftRightArithmetic, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..shift.AsSpirvSpan()]);
    }

    public static Instruction AddOpShiftLeftLogical<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef shift)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(shift);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpShiftLeftLogical, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..shift.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitwiseOr<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitwiseOr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitwiseXor<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitwiseXor, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitwiseAnd<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitwiseAnd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpNot<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpNot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitFieldInsert<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef insert, IdRef offset, IdRef count)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(insert) + buffer.GetWordLength(offset) + buffer.GetWordLength(count);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitFieldInsert, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..insert.AsSpirvSpan(), ..offset.AsSpirvSpan(), ..count.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitFieldSExtract<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef offset, IdRef count)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(offset) + buffer.GetWordLength(count);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitFieldSExtract, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..offset.AsSpirvSpan(), ..count.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitFieldUExtract<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef offset, IdRef count)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(offset) + buffer.GetWordLength(count);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitFieldUExtract, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..offset.AsSpirvSpan(), ..count.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitReverse<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitReverse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitCount<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitCount, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan()]);
    }

    public static Instruction AddOpDPdx<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDPdx, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpDPdy<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDPdy, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpFwidth<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFwidth, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpDPdxFine<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDPdxFine, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpDPdyFine<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDPdyFine, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpFwidthFine<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFwidthFine, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpDPdxCoarse<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDPdxCoarse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpDPdyCoarse<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDPdyCoarse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpFwidthCoarse<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFwidthCoarse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpEmitVertex<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpEmitVertex]);
    }

    public static Instruction AddOpEndPrimitive<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpEndPrimitive]);
    }

    public static Instruction AddOpEmitStreamVertex<TBuffer>(this TBuffer buffer, IdRef stream)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(stream);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpEmitStreamVertex, ..stream.AsSpirvSpan()]);
    }

    public static Instruction AddOpEndStreamPrimitive<TBuffer>(this TBuffer buffer, IdRef stream)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(stream);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpEndStreamPrimitive, ..stream.AsSpirvSpan()]);
    }

    public static Instruction AddOpControlBarrier<TBuffer>(this TBuffer buffer, IdScope execution, IdScope memory, IdMemorySemantics semantics)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpControlBarrier, ..execution.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpMemoryBarrier<TBuffer>(this TBuffer buffer, IdScope memory, IdMemorySemantics semantics)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMemoryBarrier, ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicLoad<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicLoad, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicStore<TBuffer>(this TBuffer buffer, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicStore, ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicExchange<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicExchange, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicCompareExchange<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics equal, IdMemorySemantics unequal, IdRef value, IdRef comparator)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(equal) + buffer.GetWordLength(unequal) + buffer.GetWordLength(value) + buffer.GetWordLength(comparator);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicCompareExchange, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..equal.AsSpirvSpan(), ..unequal.AsSpirvSpan(), ..value.AsSpirvSpan(), ..comparator.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicCompareExchangeWeak<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics equal, IdMemorySemantics unequal, IdRef value, IdRef comparator)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(equal) + buffer.GetWordLength(unequal) + buffer.GetWordLength(value) + buffer.GetWordLength(comparator);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicCompareExchangeWeak, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..equal.AsSpirvSpan(), ..unequal.AsSpirvSpan(), ..value.AsSpirvSpan(), ..comparator.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicIIncrement<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicIIncrement, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicIDecrement<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicIDecrement, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicIAdd<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicIAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicISub<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicISub, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicSMin<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicSMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicUMin<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicUMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicSMax<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicSMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicUMax<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicUMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicAnd<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicAnd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicOr<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicOr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicXor<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicXor, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpPhi<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, Span<PairIdRefIdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpPhi, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpLoopMerge<TBuffer>(this TBuffer buffer, IdRef mergeBlock, IdRef continueTarget, LoopControlMask loopcontrol)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(mergeBlock) + buffer.GetWordLength(continueTarget) + buffer.GetWordLength(loopcontrol);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLoopMerge, ..mergeBlock.AsSpirvSpan(), ..continueTarget.AsSpirvSpan(), ..loopcontrol.AsSpirvSpan()]);
    }

    public static Instruction AddOpSelectionMerge<TBuffer>(this TBuffer buffer, IdRef mergeBlock, SelectionControlMask selectioncontrol)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(mergeBlock) + buffer.GetWordLength(selectioncontrol);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSelectionMerge, ..mergeBlock.AsSpirvSpan(), ..selectioncontrol.AsSpirvSpan()]);
    }

    public static Instruction AddOpLabel<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLabel, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpBranch<TBuffer>(this TBuffer buffer, IdRef targetLabel)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(targetLabel);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBranch, ..targetLabel.AsSpirvSpan()]);
    }

    public static Instruction AddOpBranchConditional<TBuffer>(this TBuffer buffer, IdRef condition, IdRef trueLabel, IdRef falseLabel, Span<LiteralInteger> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(condition) + buffer.GetWordLength(trueLabel) + buffer.GetWordLength(falseLabel) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBranchConditional, ..condition.AsSpirvSpan(), ..trueLabel.AsSpirvSpan(), ..falseLabel.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpSwitch<TBuffer>(this TBuffer buffer, IdRef selector, IdRef defaultId, Span<PairLiteralIntegerIdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(selector) + buffer.GetWordLength(defaultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSwitch, ..selector.AsSpirvSpan(), ..defaultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpKill<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpKill]);
    }

    public static Instruction AddOpReturn<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpReturn]);
    }

    public static Instruction AddOpReturnValue<TBuffer>(this TBuffer buffer, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReturnValue, ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpUnreachable<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpUnreachable]);
    }

    public static Instruction AddOpLifetimeStart<TBuffer>(this TBuffer buffer, IdRef pointer, LiteralInteger size)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(size);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLifetimeStart, ..pointer.AsSpirvSpan(), ..size.AsSpirvSpan()]);
    }

    public static Instruction AddOpLifetimeStop<TBuffer>(this TBuffer buffer, IdRef pointer, LiteralInteger size)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(size);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLifetimeStop, ..pointer.AsSpirvSpan(), ..size.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupAsyncCopy<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef destination, IdRef source, IdRef numElements, IdRef stride, IdRef eventId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(destination) + buffer.GetWordLength(source) + buffer.GetWordLength(numElements) + buffer.GetWordLength(stride) + buffer.GetWordLength(eventId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupAsyncCopy, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..destination.AsSpirvSpan(), ..source.AsSpirvSpan(), ..numElements.AsSpirvSpan(), ..stride.AsSpirvSpan(), ..eventId.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupWaitEvents<TBuffer>(this TBuffer buffer, IdScope execution, IdRef numEvents, IdRef eventsList)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(numEvents) + buffer.GetWordLength(eventsList);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupWaitEvents, ..execution.AsSpirvSpan(), ..numEvents.AsSpirvSpan(), ..eventsList.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupAll<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef predicate)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupAll, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupAny<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef predicate)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupAny, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupBroadcast<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef localId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(localId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupBroadcast, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..localId.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupIAdd<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupIAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupFAdd<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupFAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupFMin<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupFMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupUMin<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupUMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupSMin<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupSMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupFMax<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupFMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupUMax<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupUMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupSMax<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupSMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpReadPipe<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef pointer, IdRef packetSize, IdRef packetAlignment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(pointer) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReadPipe, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpWritePipe<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef pointer, IdRef packetSize, IdRef packetAlignment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(pointer) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpWritePipe, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpReservedReadPipe<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef reserveId, IdRef index, IdRef pointer, IdRef packetSize, IdRef packetAlignment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(index) + buffer.GetWordLength(pointer) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReservedReadPipe, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..index.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpReservedWritePipe<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef reserveId, IdRef index, IdRef pointer, IdRef packetSize, IdRef packetAlignment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(index) + buffer.GetWordLength(pointer) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReservedWritePipe, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..index.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpReserveReadPipePackets<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef numPackets, IdRef packetSize, IdRef packetAlignment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(numPackets) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReserveReadPipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..numPackets.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpReserveWritePipePackets<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef numPackets, IdRef packetSize, IdRef packetAlignment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(numPackets) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReserveWritePipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..numPackets.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpCommitReadPipe<TBuffer>(this TBuffer buffer, IdRef pipe, IdRef reserveId, IdRef packetSize, IdRef packetAlignment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCommitReadPipe, ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpCommitWritePipe<TBuffer>(this TBuffer buffer, IdRef pipe, IdRef reserveId, IdRef packetSize, IdRef packetAlignment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCommitWritePipe, ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpIsValidReserveId<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef reserveId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(reserveId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIsValidReserveId, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..reserveId.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetNumPipePackets<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef packetSize, IdRef packetAlignment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetNumPipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetMaxPipePackets<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef packetSize, IdRef packetAlignment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetMaxPipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupReserveReadPipePackets<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef pipe, IdRef numPackets, IdRef packetSize, IdRef packetAlignment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(pipe) + buffer.GetWordLength(numPackets) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupReserveReadPipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..numPackets.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupReserveWritePipePackets<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef pipe, IdRef numPackets, IdRef packetSize, IdRef packetAlignment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(pipe) + buffer.GetWordLength(numPackets) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupReserveWritePipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..numPackets.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupCommitReadPipe<TBuffer>(this TBuffer buffer, IdScope execution, IdRef pipe, IdRef reserveId, IdRef packetSize, IdRef packetAlignment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupCommitReadPipe, ..execution.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupCommitWritePipe<TBuffer>(this TBuffer buffer, IdScope execution, IdRef pipe, IdRef reserveId, IdRef packetSize, IdRef packetAlignment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupCommitWritePipe, ..execution.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpEnqueueMarker<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef queue, IdRef numEvents, IdRef waitEvents, IdRef retEvent)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(queue) + buffer.GetWordLength(numEvents) + buffer.GetWordLength(waitEvents) + buffer.GetWordLength(retEvent);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpEnqueueMarker, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..queue.AsSpirvSpan(), ..numEvents.AsSpirvSpan(), ..waitEvents.AsSpirvSpan(), ..retEvent.AsSpirvSpan()]);
    }

    public static Instruction AddOpEnqueueKernel<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef queue, IdRef flags, IdRef nDRange, IdRef numEvents, IdRef waitEvents, IdRef retEvent, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(queue) + buffer.GetWordLength(flags) + buffer.GetWordLength(nDRange) + buffer.GetWordLength(numEvents) + buffer.GetWordLength(waitEvents) + buffer.GetWordLength(retEvent) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpEnqueueKernel, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..queue.AsSpirvSpan(), ..flags.AsSpirvSpan(), ..nDRange.AsSpirvSpan(), ..numEvents.AsSpirvSpan(), ..waitEvents.AsSpirvSpan(), ..retEvent.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetKernelNDrangeSubGroupCount<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef nDRange, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(nDRange) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetKernelNDrangeSubGroupCount, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..nDRange.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetKernelNDrangeMaxSubGroupSize<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef nDRange, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(nDRange) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetKernelNDrangeMaxSubGroupSize, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..nDRange.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetKernelWorkGroupSize<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetKernelWorkGroupSize, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetKernelPreferredWorkGroupSizeMultiple<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetKernelPreferredWorkGroupSizeMultiple, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction AddOpRetainEvent<TBuffer>(this TBuffer buffer, IdRef eventId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(eventId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRetainEvent, ..eventId.AsSpirvSpan()]);
    }

    public static Instruction AddOpReleaseEvent<TBuffer>(this TBuffer buffer, IdRef eventId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(eventId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReleaseEvent, ..eventId.AsSpirvSpan()]);
    }

    public static Instruction AddOpCreateUserEvent<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCreateUserEvent, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpIsValidEvent<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef eventId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(eventId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIsValidEvent, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..eventId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSetUserEventStatus<TBuffer>(this TBuffer buffer, IdRef eventId, IdRef status)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(eventId) + buffer.GetWordLength(status);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSetUserEventStatus, ..eventId.AsSpirvSpan(), ..status.AsSpirvSpan()]);
    }

    public static Instruction AddOpCaptureEventProfilingInfo<TBuffer>(this TBuffer buffer, IdRef eventId, IdRef profilingInfo, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(eventId) + buffer.GetWordLength(profilingInfo) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCaptureEventProfilingInfo, ..eventId.AsSpirvSpan(), ..profilingInfo.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetDefaultQueue<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetDefaultQueue, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpBuildNDRange<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef globalWorkSize, IdRef localWorkSize, IdRef globalWorkOffset)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(globalWorkSize) + buffer.GetWordLength(localWorkSize) + buffer.GetWordLength(globalWorkOffset);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBuildNDRange, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..globalWorkSize.AsSpirvSpan(), ..localWorkSize.AsSpirvSpan(), ..globalWorkOffset.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseSampleImplicitLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseSampleImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseSampleExplicitLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseSampleExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseSampleDrefImplicitLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseSampleDrefImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseSampleDrefExplicitLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseSampleDrefExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseSampleProjImplicitLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseSampleProjImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseSampleProjExplicitLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseSampleProjExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseSampleProjDrefImplicitLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseSampleProjDrefImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseSampleProjDrefExplicitLod<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseSampleProjDrefExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseFetch<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseFetch, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseGather<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef component, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(component) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseGather, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..component.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseDrefGather<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseDrefGather, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseTexelsResident<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef residentCode)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(residentCode);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseTexelsResident, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..residentCode.AsSpirvSpan()]);
    }

    public static Instruction AddOpNoLine<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpNoLine]);
    }

    public static Instruction AddOpAtomicFlagTestAndSet<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicFlagTestAndSet, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicFlagClear<TBuffer>(this TBuffer buffer, IdRef pointer, IdScope memory, IdMemorySemantics semantics)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicFlagClear, ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseRead<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseRead, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpSizeOf<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSizeOf, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypePipeStorage<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypePipeStorage, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantPipeStorage<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, LiteralInteger packetSize, LiteralInteger packetAlignment, LiteralInteger capacity)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment) + buffer.GetWordLength(capacity);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantPipeStorage, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan(), ..capacity.AsSpirvSpan()]);
    }

    public static Instruction AddOpCreatePipeFromPipeStorage<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipeStorage)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipeStorage);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCreatePipeFromPipeStorage, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipeStorage.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetKernelLocalSizeForSubgroupCount<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef subgroupCount, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(subgroupCount) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetKernelLocalSizeForSubgroupCount, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..subgroupCount.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetKernelMaxNumSubgroups<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetKernelMaxNumSubgroups, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeNamedBarrier<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeNamedBarrier, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpNamedBarrierInitialize<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef subgroupCount)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(subgroupCount);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpNamedBarrierInitialize, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..subgroupCount.AsSpirvSpan()]);
    }

    public static Instruction AddOpMemoryNamedBarrier<TBuffer>(this TBuffer buffer, IdRef namedBarrier, IdScope memory, IdMemorySemantics semantics)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(namedBarrier) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMemoryNamedBarrier, ..namedBarrier.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpModuleProcessed<TBuffer>(this TBuffer buffer, LiteralString process)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(process);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpModuleProcessed, ..process.AsSpirvSpan()]);
    }

    public static Instruction AddOpExecutionModeId<TBuffer>(this TBuffer buffer, IdRef entryPoint, ExecutionMode mode)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(entryPoint) + buffer.GetWordLength(mode);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExecutionModeId, ..entryPoint.AsSpirvSpan(), ..mode.AsSpirvSpan()]);
    }

    public static Instruction AddOpDecorateId<TBuffer>(this TBuffer buffer, IdRef target, Decoration decoration, int? additional1 = null, int? additional2 = null, string? additionalString = null)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(decoration) + buffer.GetWordLength(additional1) + buffer.GetWordLength(additional2) + buffer.GetWordLength(additionalString);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDecorate, target, ..decoration.AsSpirvSpan(), ..additional1.AsSpirvSpan(), ..additional2.AsSpirvSpan(), ..additionalString.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformElect<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformElect, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformAll<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef predicate)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformAll, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformAny<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef predicate)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformAny, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformAllEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformAllEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBroadcast<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef id)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(id);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBroadcast, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..id.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBroadcastFirst<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBroadcastFirst, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBallot<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef predicate)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBallot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformInverseBallot<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformInverseBallot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBallotBitExtract<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef index)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(index);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBallotBitExtract, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..index.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBallotBitCount<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBallotBitCount, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBallotFindLSB<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBallotFindLSB, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBallotFindMSB<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBallotFindMSB, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformShuffle<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef id)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(id);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformShuffle, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..id.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformShuffleXor<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef mask)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(mask);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformShuffleXor, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..mask.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformShuffleUp<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef delta)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(delta);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformShuffleUp, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..delta.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformShuffleDown<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef delta)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(delta);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformShuffleDown, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..delta.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformIAdd<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformIAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformFAdd<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformFAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformIMul<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformIMul, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformFMul<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformFMul, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformSMin<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformSMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformUMin<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformUMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformFMin<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformFMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformSMax<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformSMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformUMax<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformUMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformFMax<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformFMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBitwiseAnd<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBitwiseAnd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBitwiseOr<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBitwiseOr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBitwiseXor<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBitwiseXor, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformLogicalAnd<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformLogicalAnd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformLogicalOr<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformLogicalOr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformLogicalXor<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformLogicalXor, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformQuadBroadcast<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef index)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(index);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformQuadBroadcast, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..index.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformQuadSwap<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef direction)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(direction);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformQuadSwap, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..direction.AsSpirvSpan()]);
    }

    public static Instruction AddOpCopyLogical<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCopyLogical, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpPtrEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpPtrEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpPtrNotEqual<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpPtrNotEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpPtrDiff<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpPtrDiff, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpColorAttachmentReadEXT<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef attachment, IdRef? sample)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(attachment) + buffer.GetWordLength(sample);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpColorAttachmentReadEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..attachment.AsSpirvSpan(), ..sample.AsSpirvSpan()]);
    }

    public static Instruction AddOpDepthAttachmentReadEXT<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef? sample)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sample);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDepthAttachmentReadEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sample.AsSpirvSpan()]);
    }

    public static Instruction AddOpStencilAttachmentReadEXT<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef? sample)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sample);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpStencilAttachmentReadEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sample.AsSpirvSpan()]);
    }

    public static Instruction AddOpTerminateInvocation<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpTerminateInvocation]);
    }

    public static Instruction AddOpTypeUntypedPointerKHR<TBuffer>(this TBuffer buffer, IdResult resultId, StorageClass storageclass)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeUntypedPointerKHR, ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan()]);
    }

    public static Instruction AddOpUntypedVariableKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, StorageClass storageclass, IdRef? dataType, IdRef? initializer)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass) + buffer.GetWordLength(dataType) + buffer.GetWordLength(initializer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUntypedVariableKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan(), ..dataType.AsSpirvSpan(), ..initializer.AsSpirvSpan()]);
    }

    public static Instruction AddOpUntypedAccessChainKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseType, IdRef baseId, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseType) + buffer.GetWordLength(baseId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUntypedAccessChainKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseType.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpUntypedInBoundsAccessChainKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseType, IdRef baseId, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseType) + buffer.GetWordLength(baseId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUntypedInBoundsAccessChainKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseType.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupBallotKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef predicate)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupBallotKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupFirstInvocationKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupFirstInvocationKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpUntypedPtrAccessChainKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseType, IdRef baseId, IdRef element, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseType) + buffer.GetWordLength(baseId) + buffer.GetWordLength(element) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUntypedPtrAccessChainKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseType.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..element.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpUntypedInBoundsPtrAccessChainKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseType, IdRef baseId, IdRef element, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseType) + buffer.GetWordLength(baseId) + buffer.GetWordLength(element) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUntypedInBoundsPtrAccessChainKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseType.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..element.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpUntypedArrayLengthKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef structure, IdRef pointer, LiteralInteger arraymember)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(structure) + buffer.GetWordLength(pointer) + buffer.GetWordLength(arraymember);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUntypedArrayLengthKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..structure.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..arraymember.AsSpirvSpan()]);
    }

    public static Instruction AddOpUntypedPrefetchKHR<TBuffer>(this TBuffer buffer, IdRef pointerType, IdRef numBytes, IdRef? rW, IdRef? locality, IdRef? cacheType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(pointerType) + buffer.GetWordLength(numBytes) + buffer.GetWordLength(rW) + buffer.GetWordLength(locality) + buffer.GetWordLength(cacheType);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUntypedPrefetchKHR, ..pointerType.AsSpirvSpan(), ..numBytes.AsSpirvSpan(), ..rW.AsSpirvSpan(), ..locality.AsSpirvSpan(), ..cacheType.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAllKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef predicate)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAllKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAnyKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef predicate)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAnyKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAllEqualKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef predicate)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAllEqualKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformRotateKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef delta, IdRef? clusterSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(delta) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformRotateKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..delta.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupReadInvocationKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef value, IdRef index)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value) + buffer.GetWordLength(index);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupReadInvocationKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan(), ..index.AsSpirvSpan()]);
    }

    public static Instruction AddOpExtInstWithForwardRefsKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef set, LiteralInteger instruction, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(set) + buffer.GetWordLength(instruction) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExtInstWithForwardRefsKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..set.AsSpirvSpan(), ..instruction.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpTraceRayKHR<TBuffer>(this TBuffer buffer, IdRef accel, IdRef rayFlags, IdRef cullMask, IdRef sBTOffset, IdRef sBTStride, IdRef missIndex, IdRef rayOrigin, IdRef rayTmin, IdRef rayDirection, IdRef rayTmax, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(accel) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullMask) + buffer.GetWordLength(sBTOffset) + buffer.GetWordLength(sBTStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(rayOrigin) + buffer.GetWordLength(rayTmin) + buffer.GetWordLength(rayDirection) + buffer.GetWordLength(rayTmax) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTraceRayKHR, ..accel.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullMask.AsSpirvSpan(), ..sBTOffset.AsSpirvSpan(), ..sBTStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..rayOrigin.AsSpirvSpan(), ..rayTmin.AsSpirvSpan(), ..rayDirection.AsSpirvSpan(), ..rayTmax.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpExecuteCallableKHR<TBuffer>(this TBuffer buffer, IdRef sBTIndex, IdRef callableData)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(sBTIndex) + buffer.GetWordLength(callableData);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExecuteCallableKHR, ..sBTIndex.AsSpirvSpan(), ..callableData.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertUToAccelerationStructureKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef accel)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(accel);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertUToAccelerationStructureKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..accel.AsSpirvSpan()]);
    }

    public static Instruction AddOpIgnoreIntersectionKHR<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpIgnoreIntersectionKHR]);
    }

    public static Instruction AddOpTerminateRayKHR<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpTerminateRayKHR]);
    }

    public static Instruction AddOpSDot<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, PackedVectorFormat? packedVectorFormat)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDotKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, PackedVectorFormat? packedVectorFormat)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDotKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpUDot<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, PackedVectorFormat? packedVectorFormat)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUDot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpUDotKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, PackedVectorFormat? packedVectorFormat)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUDotKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpSUDot<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, PackedVectorFormat? packedVectorFormat)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSUDot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpSUDotKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, PackedVectorFormat? packedVectorFormat)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSUDotKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDotAccSat<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, IdRef accumulator, PackedVectorFormat? packedVectorFormat)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(accumulator) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDotAccSat, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..accumulator.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDotAccSatKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, IdRef accumulator, PackedVectorFormat? packedVectorFormat)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(accumulator) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDotAccSatKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..accumulator.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpUDotAccSat<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, IdRef accumulator, PackedVectorFormat? packedVectorFormat)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(accumulator) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUDotAccSat, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..accumulator.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpUDotAccSatKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, IdRef accumulator, PackedVectorFormat? packedVectorFormat)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(accumulator) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUDotAccSatKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..accumulator.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpSUDotAccSat<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, IdRef accumulator, PackedVectorFormat? packedVectorFormat)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(accumulator) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSUDotAccSat, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..accumulator.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpSUDotAccSatKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, IdRef accumulator, PackedVectorFormat? packedVectorFormat)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(accumulator) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSUDotAccSatKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..accumulator.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeCooperativeMatrixKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdRef componentType, IdScope scope, IdRef rows, IdRef columns, IdRef use)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(componentType) + buffer.GetWordLength(scope) + buffer.GetWordLength(rows) + buffer.GetWordLength(columns) + buffer.GetWordLength(use);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeCooperativeMatrixKHR, ..resultId.AsSpirvSpan(), ..componentType.AsSpirvSpan(), ..scope.AsSpirvSpan(), ..rows.AsSpirvSpan(), ..columns.AsSpirvSpan(), ..use.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixLoadKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdRef memoryLayout, IdRef? stride, MemoryAccessMask? memoryOperand)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memoryLayout) + buffer.GetWordLength(stride) + buffer.GetWordLength(memoryOperand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixLoadKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memoryLayout.AsSpirvSpan(), ..stride.AsSpirvSpan(), ..memoryOperand.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixStoreKHR<TBuffer>(this TBuffer buffer, IdRef pointer, IdRef objectId, IdRef memoryLayout, IdRef? stride, MemoryAccessMask? memoryOperand)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(objectId) + buffer.GetWordLength(memoryLayout) + buffer.GetWordLength(stride) + buffer.GetWordLength(memoryOperand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixStoreKHR, ..pointer.AsSpirvSpan(), ..objectId.AsSpirvSpan(), ..memoryLayout.AsSpirvSpan(), ..stride.AsSpirvSpan(), ..memoryOperand.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixMulAddKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, IdRef b, IdRef c, CooperativeMatrixOperandsMask? cooperativeMatrixOperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(b) + buffer.GetWordLength(c) + buffer.GetWordLength(cooperativeMatrixOperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixMulAddKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..b.AsSpirvSpan(), ..c.AsSpirvSpan(), ..cooperativeMatrixOperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixLengthKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef type)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(type);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixLengthKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..type.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantCompositeReplicateEXT<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantCompositeReplicateEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpSpecConstantCompositeReplicateEXT<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSpecConstantCompositeReplicateEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpCompositeConstructReplicateEXT<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCompositeConstructReplicateEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeRayQueryKHR<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeRayQueryKHR, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryInitializeKHR<TBuffer>(this TBuffer buffer, IdRef rayQuery, IdRef accel, IdRef rayFlags, IdRef cullMask, IdRef rayOrigin, IdRef rayTMin, IdRef rayDirection, IdRef rayTMax)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(accel) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullMask) + buffer.GetWordLength(rayOrigin) + buffer.GetWordLength(rayTMin) + buffer.GetWordLength(rayDirection) + buffer.GetWordLength(rayTMax);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryInitializeKHR, ..rayQuery.AsSpirvSpan(), ..accel.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullMask.AsSpirvSpan(), ..rayOrigin.AsSpirvSpan(), ..rayTMin.AsSpirvSpan(), ..rayDirection.AsSpirvSpan(), ..rayTMax.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryTerminateKHR<TBuffer>(this TBuffer buffer, IdRef rayQuery)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(rayQuery);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryTerminateKHR, ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGenerateIntersectionKHR<TBuffer>(this TBuffer buffer, IdRef rayQuery, IdRef hitT)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(hitT);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGenerateIntersectionKHR, ..rayQuery.AsSpirvSpan(), ..hitT.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryConfirmIntersectionKHR<TBuffer>(this TBuffer buffer, IdRef rayQuery)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(rayQuery);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryConfirmIntersectionKHR, ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryProceedKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryProceedKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionTypeKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionTypeKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleWeightedQCOM<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef texture, IdRef coordinates, IdRef weights)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(texture) + buffer.GetWordLength(coordinates) + buffer.GetWordLength(weights);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleWeightedQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..texture.AsSpirvSpan(), ..coordinates.AsSpirvSpan(), ..weights.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageBoxFilterQCOM<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef texture, IdRef coordinates, IdRef boxSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(texture) + buffer.GetWordLength(coordinates) + buffer.GetWordLength(boxSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageBoxFilterQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..texture.AsSpirvSpan(), ..coordinates.AsSpirvSpan(), ..boxSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageBlockMatchSSDQCOM<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef target, IdRef targetCoordinates, IdRef reference, IdRef referenceCoordinates, IdRef blockSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(target) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(reference) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageBlockMatchSSDQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..target.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..reference.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageBlockMatchSADQCOM<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef target, IdRef targetCoordinates, IdRef reference, IdRef referenceCoordinates, IdRef blockSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(target) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(reference) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageBlockMatchSADQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..target.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..reference.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageBlockMatchWindowSSDQCOM<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef targetSampledImage, IdRef targetCoordinates, IdRef referenceSampledImage, IdRef referenceCoordinates, IdRef blockSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(targetSampledImage) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(referenceSampledImage) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageBlockMatchWindowSSDQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..targetSampledImage.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..referenceSampledImage.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageBlockMatchWindowSADQCOM<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef targetSampledImage, IdRef targetCoordinates, IdRef referenceSampledImage, IdRef referenceCoordinates, IdRef blockSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(targetSampledImage) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(referenceSampledImage) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageBlockMatchWindowSADQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..targetSampledImage.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..referenceSampledImage.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageBlockMatchGatherSSDQCOM<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef targetSampledImage, IdRef targetCoordinates, IdRef referenceSampledImage, IdRef referenceCoordinates, IdRef blockSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(targetSampledImage) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(referenceSampledImage) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageBlockMatchGatherSSDQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..targetSampledImage.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..referenceSampledImage.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageBlockMatchGatherSADQCOM<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef targetSampledImage, IdRef targetCoordinates, IdRef referenceSampledImage, IdRef referenceCoordinates, IdRef blockSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(targetSampledImage) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(referenceSampledImage) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageBlockMatchGatherSADQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..targetSampledImage.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..referenceSampledImage.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupIAddNonUniformAMD<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupIAddNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupFAddNonUniformAMD<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupFAddNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupFMinNonUniformAMD<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupFMinNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupUMinNonUniformAMD<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupUMinNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupSMinNonUniformAMD<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupSMinNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupFMaxNonUniformAMD<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupFMaxNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupUMaxNonUniformAMD<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupUMaxNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupSMaxNonUniformAMD<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupSMaxNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpFragmentMaskFetchAMD<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFragmentMaskFetchAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan()]);
    }

    public static Instruction AddOpFragmentFetchAMD<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, IdRef fragmentIndex)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(fragmentIndex);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFragmentFetchAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..fragmentIndex.AsSpirvSpan()]);
    }

    public static Instruction AddOpReadClockKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope scope)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(scope);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReadClockKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..scope.AsSpirvSpan()]);
    }

    public static Instruction AddOpFinalizeNodePayloadsAMDX<TBuffer>(this TBuffer buffer, IdRef payloadArray)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(payloadArray);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFinalizeNodePayloadsAMDX, ..payloadArray.AsSpirvSpan()]);
    }

    public static Instruction AddOpFinishWritingNodePayloadAMDX<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFinishWritingNodePayloadAMDX, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpInitializeNodePayloadsAMDX<TBuffer>(this TBuffer buffer, IdRef payloadArray, IdScope visibility, IdRef payloadCount, IdRef nodeIndex)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(payloadArray) + buffer.GetWordLength(visibility) + buffer.GetWordLength(payloadCount) + buffer.GetWordLength(nodeIndex);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpInitializeNodePayloadsAMDX, ..payloadArray.AsSpirvSpan(), ..visibility.AsSpirvSpan(), ..payloadCount.AsSpirvSpan(), ..nodeIndex.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformQuadAllKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef predicate)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformQuadAllKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformQuadAnyKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef predicate)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformQuadAnyKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectRecordHitMotionNV<TBuffer>(this TBuffer buffer, IdRef hitObject, IdRef accelerationStructure, IdRef instanceId, IdRef primitiveId, IdRef geometryIndex, IdRef hitKind, IdRef sBTRecordOffset, IdRef sBTRecordStride, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef currentTime, IdRef hitObjectAttributes)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(primitiveId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(hitKind) + buffer.GetWordLength(sBTRecordOffset) + buffer.GetWordLength(sBTRecordStride) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(currentTime) + buffer.GetWordLength(hitObjectAttributes);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectRecordHitMotionNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..primitiveId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..hitKind.AsSpirvSpan(), ..sBTRecordOffset.AsSpirvSpan(), ..sBTRecordStride.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..currentTime.AsSpirvSpan(), ..hitObjectAttributes.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectRecordHitWithIndexMotionNV<TBuffer>(this TBuffer buffer, IdRef hitObject, IdRef accelerationStructure, IdRef instanceId, IdRef primitiveId, IdRef geometryIndex, IdRef hitKind, IdRef sBTRecordIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef currentTime, IdRef hitObjectAttributes)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(primitiveId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(hitKind) + buffer.GetWordLength(sBTRecordIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(currentTime) + buffer.GetWordLength(hitObjectAttributes);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectRecordHitWithIndexMotionNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..primitiveId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..hitKind.AsSpirvSpan(), ..sBTRecordIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..currentTime.AsSpirvSpan(), ..hitObjectAttributes.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectRecordMissMotionNV<TBuffer>(this TBuffer buffer, IdRef hitObject, IdRef sBTIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef currentTime)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(sBTIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(currentTime);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectRecordMissMotionNV, ..hitObject.AsSpirvSpan(), ..sBTIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..currentTime.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetWorldToObjectNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetWorldToObjectNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetObjectToWorldNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetObjectToWorldNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetObjectRayDirectionNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetObjectRayDirectionNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetObjectRayOriginNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetObjectRayOriginNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectTraceRayMotionNV<TBuffer>(this TBuffer buffer, IdRef hitObject, IdRef accelerationStructure, IdRef rayFlags, IdRef cullmask, IdRef sBTRecordOffset, IdRef sBTRecordStride, IdRef missIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef time, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullmask) + buffer.GetWordLength(sBTRecordOffset) + buffer.GetWordLength(sBTRecordStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(time) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectTraceRayMotionNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullmask.AsSpirvSpan(), ..sBTRecordOffset.AsSpirvSpan(), ..sBTRecordStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..time.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetShaderRecordBufferHandleNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetShaderRecordBufferHandleNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetShaderBindingTableRecordIndexNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetShaderBindingTableRecordIndexNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectRecordEmptyNV<TBuffer>(this TBuffer buffer, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectRecordEmptyNV, ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectTraceRayNV<TBuffer>(this TBuffer buffer, IdRef hitObject, IdRef accelerationStructure, IdRef rayFlags, IdRef cullmask, IdRef sBTRecordOffset, IdRef sBTRecordStride, IdRef missIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullmask) + buffer.GetWordLength(sBTRecordOffset) + buffer.GetWordLength(sBTRecordStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectTraceRayNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullmask.AsSpirvSpan(), ..sBTRecordOffset.AsSpirvSpan(), ..sBTRecordStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectRecordHitNV<TBuffer>(this TBuffer buffer, IdRef hitObject, IdRef accelerationStructure, IdRef instanceId, IdRef primitiveId, IdRef geometryIndex, IdRef hitKind, IdRef sBTRecordOffset, IdRef sBTRecordStride, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef hitObjectAttributes)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(primitiveId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(hitKind) + buffer.GetWordLength(sBTRecordOffset) + buffer.GetWordLength(sBTRecordStride) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(hitObjectAttributes);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectRecordHitNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..primitiveId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..hitKind.AsSpirvSpan(), ..sBTRecordOffset.AsSpirvSpan(), ..sBTRecordStride.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..hitObjectAttributes.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectRecordHitWithIndexNV<TBuffer>(this TBuffer buffer, IdRef hitObject, IdRef accelerationStructure, IdRef instanceId, IdRef primitiveId, IdRef geometryIndex, IdRef hitKind, IdRef sBTRecordIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef hitObjectAttributes)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(primitiveId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(hitKind) + buffer.GetWordLength(sBTRecordIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(hitObjectAttributes);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectRecordHitWithIndexNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..primitiveId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..hitKind.AsSpirvSpan(), ..sBTRecordIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..hitObjectAttributes.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectRecordMissNV<TBuffer>(this TBuffer buffer, IdRef hitObject, IdRef sBTIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(sBTIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectRecordMissNV, ..hitObject.AsSpirvSpan(), ..sBTIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectExecuteShaderNV<TBuffer>(this TBuffer buffer, IdRef hitObject, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectExecuteShaderNV, ..hitObject.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetCurrentTimeNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetCurrentTimeNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetAttributesNV<TBuffer>(this TBuffer buffer, IdRef hitObject, IdRef hitObjectAttribute)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(hitObjectAttribute);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetAttributesNV, ..hitObject.AsSpirvSpan(), ..hitObjectAttribute.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetHitKindNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetHitKindNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetPrimitiveIndexNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetPrimitiveIndexNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetGeometryIndexNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetGeometryIndexNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetInstanceIdNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetInstanceIdNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetInstanceCustomIndexNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetInstanceCustomIndexNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetWorldRayDirectionNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetWorldRayDirectionNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetWorldRayOriginNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetWorldRayOriginNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetRayTMaxNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetRayTMaxNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetRayTMinNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetRayTMinNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectIsEmptyNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectIsEmptyNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectIsHitNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectIsHitNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectIsMissNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectIsMissNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpReorderThreadWithHitObjectNV<TBuffer>(this TBuffer buffer, IdRef hitObject, IdRef? hint, IdRef? bits)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(hint) + buffer.GetWordLength(bits);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReorderThreadWithHitObjectNV, ..hitObject.AsSpirvSpan(), ..hint.AsSpirvSpan(), ..bits.AsSpirvSpan()]);
    }

    public static Instruction AddOpReorderThreadWithHintNV<TBuffer>(this TBuffer buffer, IdRef hint, IdRef bits)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(hint) + buffer.GetWordLength(bits);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReorderThreadWithHintNV, ..hint.AsSpirvSpan(), ..bits.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeHitObjectNV<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeHitObjectNV, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleFootprintNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef granularity, IdRef coarse, ImageOperandsMask? imageoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(granularity) + buffer.GetWordLength(coarse) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleFootprintNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..granularity.AsSpirvSpan(), ..coarse.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpEmitMeshTasksEXT<TBuffer>(this TBuffer buffer, IdRef groupCountX, IdRef groupCountY, IdRef groupCountZ, IdRef? payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(groupCountX) + buffer.GetWordLength(groupCountY) + buffer.GetWordLength(groupCountZ) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpEmitMeshTasksEXT, ..groupCountX.AsSpirvSpan(), ..groupCountY.AsSpirvSpan(), ..groupCountZ.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSetMeshOutputsEXT<TBuffer>(this TBuffer buffer, IdRef vertexCount, IdRef primitiveCount)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(vertexCount) + buffer.GetWordLength(primitiveCount);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSetMeshOutputsEXT, ..vertexCount.AsSpirvSpan(), ..primitiveCount.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformPartitionNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformPartitionNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpWritePackedPrimitiveIndices4x8NV<TBuffer>(this TBuffer buffer, IdRef indexOffset, IdRef packedIndices)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(indexOffset) + buffer.GetWordLength(packedIndices);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpWritePackedPrimitiveIndices4x8NV, ..indexOffset.AsSpirvSpan(), ..packedIndices.AsSpirvSpan()]);
    }

    public static Instruction AddOpFetchMicroTriangleVertexPositionNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef accel, IdRef instanceId, IdRef geometryIndex, IdRef primitiveIndex, IdRef barycentric)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(accel) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(primitiveIndex) + buffer.GetWordLength(barycentric);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFetchMicroTriangleVertexPositionNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..accel.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..primitiveIndex.AsSpirvSpan(), ..barycentric.AsSpirvSpan()]);
    }

    public static Instruction AddOpFetchMicroTriangleVertexBarycentricNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef accel, IdRef instanceId, IdRef geometryIndex, IdRef primitiveIndex, IdRef barycentric)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(accel) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(primitiveIndex) + buffer.GetWordLength(barycentric);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFetchMicroTriangleVertexBarycentricNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..accel.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..primitiveIndex.AsSpirvSpan(), ..barycentric.AsSpirvSpan()]);
    }

    public static Instruction AddOpReportIntersectionKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hit, IdRef hitKind)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hit) + buffer.GetWordLength(hitKind);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReportIntersectionKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hit.AsSpirvSpan(), ..hitKind.AsSpirvSpan()]);
    }

    public static Instruction AddOpReportIntersectionNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hit, IdRef hitKind)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hit) + buffer.GetWordLength(hitKind);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReportIntersectionNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hit.AsSpirvSpan(), ..hitKind.AsSpirvSpan()]);
    }

    public static Instruction AddOpIgnoreIntersectionNV<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpIgnoreIntersectionNV]);
    }

    public static Instruction AddOpTerminateRayNV<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpTerminateRayNV]);
    }

    public static Instruction AddOpTraceNV<TBuffer>(this TBuffer buffer, IdRef accel, IdRef rayFlags, IdRef cullMask, IdRef sBTOffset, IdRef sBTStride, IdRef missIndex, IdRef rayOrigin, IdRef rayTmin, IdRef rayDirection, IdRef rayTmax, IdRef payloadId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(accel) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullMask) + buffer.GetWordLength(sBTOffset) + buffer.GetWordLength(sBTStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(rayOrigin) + buffer.GetWordLength(rayTmin) + buffer.GetWordLength(rayDirection) + buffer.GetWordLength(rayTmax) + buffer.GetWordLength(payloadId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTraceNV, ..accel.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullMask.AsSpirvSpan(), ..sBTOffset.AsSpirvSpan(), ..sBTStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..rayOrigin.AsSpirvSpan(), ..rayTmin.AsSpirvSpan(), ..rayDirection.AsSpirvSpan(), ..rayTmax.AsSpirvSpan(), ..payloadId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTraceMotionNV<TBuffer>(this TBuffer buffer, IdRef accel, IdRef rayFlags, IdRef cullMask, IdRef sBTOffset, IdRef sBTStride, IdRef missIndex, IdRef rayOrigin, IdRef rayTmin, IdRef rayDirection, IdRef rayTmax, IdRef time, IdRef payloadId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(accel) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullMask) + buffer.GetWordLength(sBTOffset) + buffer.GetWordLength(sBTStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(rayOrigin) + buffer.GetWordLength(rayTmin) + buffer.GetWordLength(rayDirection) + buffer.GetWordLength(rayTmax) + buffer.GetWordLength(time) + buffer.GetWordLength(payloadId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTraceMotionNV, ..accel.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullMask.AsSpirvSpan(), ..sBTOffset.AsSpirvSpan(), ..sBTStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..rayOrigin.AsSpirvSpan(), ..rayTmin.AsSpirvSpan(), ..rayDirection.AsSpirvSpan(), ..rayTmax.AsSpirvSpan(), ..time.AsSpirvSpan(), ..payloadId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTraceRayMotionNV<TBuffer>(this TBuffer buffer, IdRef accel, IdRef rayFlags, IdRef cullMask, IdRef sBTOffset, IdRef sBTStride, IdRef missIndex, IdRef rayOrigin, IdRef rayTmin, IdRef rayDirection, IdRef rayTmax, IdRef time, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(accel) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullMask) + buffer.GetWordLength(sBTOffset) + buffer.GetWordLength(sBTStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(rayOrigin) + buffer.GetWordLength(rayTmin) + buffer.GetWordLength(rayDirection) + buffer.GetWordLength(rayTmax) + buffer.GetWordLength(time) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTraceRayMotionNV, ..accel.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullMask.AsSpirvSpan(), ..sBTOffset.AsSpirvSpan(), ..sBTStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..rayOrigin.AsSpirvSpan(), ..rayTmin.AsSpirvSpan(), ..rayDirection.AsSpirvSpan(), ..rayTmax.AsSpirvSpan(), ..time.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionTriangleVertexPositionsKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionTriangleVertexPositionsKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAccelerationStructureKHR<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAccelerationStructureKHR, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAccelerationStructureNV<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAccelerationStructureNV, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpExecuteCallableNV<TBuffer>(this TBuffer buffer, IdRef sBTIndex, IdRef callableDataId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(sBTIndex) + buffer.GetWordLength(callableDataId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExecuteCallableNV, ..sBTIndex.AsSpirvSpan(), ..callableDataId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeCooperativeMatrixNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdRef componentType, IdScope execution, IdRef rows, IdRef columns)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(componentType) + buffer.GetWordLength(execution) + buffer.GetWordLength(rows) + buffer.GetWordLength(columns);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeCooperativeMatrixNV, ..resultId.AsSpirvSpan(), ..componentType.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..rows.AsSpirvSpan(), ..columns.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixLoadNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdRef stride, IdRef columnMajor, MemoryAccessMask? memoryaccess)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(stride) + buffer.GetWordLength(columnMajor) + buffer.GetWordLength(memoryaccess);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixLoadNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..stride.AsSpirvSpan(), ..columnMajor.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixStoreNV<TBuffer>(this TBuffer buffer, IdRef pointer, IdRef objectId, IdRef stride, IdRef columnMajor, MemoryAccessMask? memoryaccess)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(objectId) + buffer.GetWordLength(stride) + buffer.GetWordLength(columnMajor) + buffer.GetWordLength(memoryaccess);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixStoreNV, ..pointer.AsSpirvSpan(), ..objectId.AsSpirvSpan(), ..stride.AsSpirvSpan(), ..columnMajor.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixMulAddNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, IdRef b, IdRef c)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(b) + buffer.GetWordLength(c);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixMulAddNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..b.AsSpirvSpan(), ..c.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixLengthNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef type)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(type);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixLengthNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..type.AsSpirvSpan()]);
    }

    public static Instruction AddOpBeginInvocationInterlockEXT<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpBeginInvocationInterlockEXT]);
    }

    public static Instruction AddOpEndInvocationInterlockEXT<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpEndInvocationInterlockEXT]);
    }

    public static Instruction AddOpDemoteToHelperInvocation<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpDemoteToHelperInvocation]);
    }

    public static Instruction AddOpDemoteToHelperInvocationEXT<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpDemoteToHelperInvocationEXT]);
    }

    public static Instruction AddOpIsHelperInvocationEXT<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIsHelperInvocationEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertUToImageNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertUToImageNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertUToSamplerNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertUToSamplerNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertImageToUNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertImageToUNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertSamplerToUNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertSamplerToUNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertUToSampledImageNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertUToSampledImageNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertSampledImageToUNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertSampledImageToUNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpSamplerImageAddressingModeNV<TBuffer>(this TBuffer buffer, LiteralInteger bitWidth)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(bitWidth);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSamplerImageAddressingModeNV, ..bitWidth.AsSpirvSpan()]);
    }

    public static Instruction AddOpRawAccessChainNV<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef bytestride, IdRef elementindex, IdRef byteoffset, RawAccessChainOperandsMask? rawaccesschainoperands)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(bytestride) + buffer.GetWordLength(elementindex) + buffer.GetWordLength(byteoffset) + buffer.GetWordLength(rawaccesschainoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRawAccessChainNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..bytestride.AsSpirvSpan(), ..elementindex.AsSpirvSpan(), ..byteoffset.AsSpirvSpan(), ..rawaccesschainoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupShuffleINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef data, IdRef invocationId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(data) + buffer.GetWordLength(invocationId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupShuffleINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..data.AsSpirvSpan(), ..invocationId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupShuffleDownINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef current, IdRef next, IdRef delta)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(current) + buffer.GetWordLength(next) + buffer.GetWordLength(delta);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupShuffleDownINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..current.AsSpirvSpan(), ..next.AsSpirvSpan(), ..delta.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupShuffleUpINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef previous, IdRef current, IdRef delta)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(previous) + buffer.GetWordLength(current) + buffer.GetWordLength(delta);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupShuffleUpINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..previous.AsSpirvSpan(), ..current.AsSpirvSpan(), ..delta.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupShuffleXorINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef data, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(data) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupShuffleXorINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..data.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupBlockReadINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef ptr)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(ptr);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupBlockReadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..ptr.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupBlockWriteINTEL<TBuffer>(this TBuffer buffer, IdRef ptr, IdRef data)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(ptr) + buffer.GetWordLength(data);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupBlockWriteINTEL, ..ptr.AsSpirvSpan(), ..data.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupImageBlockReadINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupImageBlockReadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupImageBlockWriteINTEL<TBuffer>(this TBuffer buffer, IdRef image, IdRef coordinate, IdRef data)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(data);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupImageBlockWriteINTEL, ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..data.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupImageMediaBlockReadINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, IdRef width, IdRef height)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(width) + buffer.GetWordLength(height);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupImageMediaBlockReadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..width.AsSpirvSpan(), ..height.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupImageMediaBlockWriteINTEL<TBuffer>(this TBuffer buffer, IdRef image, IdRef coordinate, IdRef width, IdRef height, IdRef data)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(width) + buffer.GetWordLength(height) + buffer.GetWordLength(data);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupImageMediaBlockWriteINTEL, ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..width.AsSpirvSpan(), ..height.AsSpirvSpan(), ..data.AsSpirvSpan()]);
    }

    public static Instruction AddOpUCountLeadingZerosINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUCountLeadingZerosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpUCountTrailingZerosINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUCountTrailingZerosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpAbsISubINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAbsISubINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpAbsUSubINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAbsUSubINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpIAddSatINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIAddSatINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUAddSatINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUAddSatINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpIAverageINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIAverageINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUAverageINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUAverageINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpIAverageRoundedINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIAverageRoundedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUAverageRoundedINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUAverageRoundedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpISubSatINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpISubSatINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUSubSatINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUSubSatINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpIMul32x16INTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIMul32x16INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUMul32x16INTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUMul32x16INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantFunctionPointerINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef function)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(function);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantFunctionPointerINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..function.AsSpirvSpan()]);
    }

    public static Instruction AddOpFunctionPointerCallINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFunctionPointerCallINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpAsmTargetINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, LiteralString asmtarget)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(asmtarget);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAsmTargetINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..asmtarget.AsSpirvSpan()]);
    }

    public static Instruction AddOpAsmINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef asmtype, IdRef target, LiteralString asminstructions, LiteralString constraints)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(asmtype) + buffer.GetWordLength(target) + buffer.GetWordLength(asminstructions) + buffer.GetWordLength(constraints);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAsmINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..asmtype.AsSpirvSpan(), ..target.AsSpirvSpan(), ..asminstructions.AsSpirvSpan(), ..constraints.AsSpirvSpan()]);
    }

    public static Instruction AddOpAsmCallINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef asm, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(asm) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAsmCallINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..asm.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicFMinEXT<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicFMinEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicFMaxEXT<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicFMaxEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAssumeTrueKHR<TBuffer>(this TBuffer buffer, IdRef condition)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(condition);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAssumeTrueKHR, ..condition.AsSpirvSpan()]);
    }

    public static Instruction AddOpExpectKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef value, IdRef expectedValue)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value) + buffer.GetWordLength(expectedValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExpectKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan(), ..expectedValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpDecorateString<TBuffer>(this TBuffer buffer, IdRef target, Decoration decoration, int? additional1 = null, int? additional2 = null, string? additionalString = null)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(decoration) + buffer.GetWordLength(additional1) + buffer.GetWordLength(additional2) + buffer.GetWordLength(additionalString);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDecorate, target, ..decoration.AsSpirvSpan(), ..additional1.AsSpirvSpan(), ..additional2.AsSpirvSpan(), ..additionalString.AsSpirvSpan()]);
    }

    public static Instruction AddOpDecorateStringGOOGLE<TBuffer>(this TBuffer buffer, IdRef target, Decoration decoration, int? additional1 = null, int? additional2 = null, string? additionalString = null)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(decoration) + buffer.GetWordLength(additional1) + buffer.GetWordLength(additional2) + buffer.GetWordLength(additionalString);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDecorate, target, ..decoration.AsSpirvSpan(), ..additional1.AsSpirvSpan(), ..additional2.AsSpirvSpan(), ..additionalString.AsSpirvSpan()]);
    }

    public static Instruction AddOpMemberDecorateString<TBuffer>(this TBuffer buffer, IdRef structureType, LiteralInteger member, Decoration decoration, int? additional1 = null, int? additional2 = null, string? additionalString = null)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(structureType) + buffer.GetWordLength(member) + buffer.GetWordLength(decoration) + buffer.GetWordLength(additional1) + buffer.GetWordLength(additional2) + buffer.GetWordLength(additionalString);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMemberDecorate, ..structureType.AsSpirvSpan(), ..member.AsSpirvSpan(), ..decoration.AsSpirvSpan(), ..additional1.AsSpirvSpan(), ..additional2.AsSpirvSpan(), ..additionalString.AsSpirvSpan()]);
    }

    public static Instruction AddOpMemberDecorateStringGOOGLE<TBuffer>(this TBuffer buffer, IdRef structureType, LiteralInteger member, Decoration decoration, int? additional1 = null, int? additional2 = null, string? additionalString = null)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(structureType) + buffer.GetWordLength(member) + buffer.GetWordLength(decoration) + buffer.GetWordLength(additional1) + buffer.GetWordLength(additional2) + buffer.GetWordLength(additionalString);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMemberDecorate, ..structureType.AsSpirvSpan(), ..member.AsSpirvSpan(), ..decoration.AsSpirvSpan(), ..additional1.AsSpirvSpan(), ..additional2.AsSpirvSpan(), ..additionalString.AsSpirvSpan()]);
    }

    public static Instruction AddOpVmeImageINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef imageType, IdRef sampler)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(imageType) + buffer.GetWordLength(sampler);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpVmeImageINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..imageType.AsSpirvSpan(), ..sampler.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeVmeImageINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdRef imageType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(imageType);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeVmeImageINTEL, ..resultId.AsSpirvSpan(), ..imageType.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcImePayloadINTEL<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcImePayloadINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcRefPayloadINTEL<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcRefPayloadINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcSicPayloadINTEL<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcSicPayloadINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcMcePayloadINTEL<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcMcePayloadINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcMceResultINTEL<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcMceResultINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcImeResultINTEL<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcImeResultINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcImeResultSingleReferenceStreamoutINTEL<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcImeResultSingleReferenceStreamoutINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcImeResultDualReferenceStreamoutINTEL<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcImeResultDualReferenceStreamoutINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcImeSingleReferenceStreaminINTEL<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcImeSingleReferenceStreaminINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcImeDualReferenceStreaminINTEL<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcImeDualReferenceStreaminINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcRefResultINTEL<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcRefResultINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcSicResultINTEL<TBuffer>(this TBuffer buffer, IdResult resultId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcSicResultINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef referenceBasePenalty, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(referenceBasePenalty) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..referenceBasePenalty.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceSetInterShapePenaltyINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef packedShapePenalty, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedShapePenalty) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetInterShapePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedShapePenalty.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceSetInterDirectionPenaltyINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef directionCost, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(directionCost) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetInterDirectionPenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..directionCost.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceSetMotionVectorCostFunctionINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef packedCostCenterDelta, IdRef packedCostTable, IdRef costPrecision, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedCostCenterDelta) + buffer.GetWordLength(packedCostTable) + buffer.GetWordLength(costPrecision) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedCostCenterDelta.AsSpirvSpan(), ..packedCostTable.AsSpirvSpan(), ..costPrecision.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceSetAcOnlyHaarINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetAcOnlyHaarINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sourceFieldPolarity, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sourceFieldPolarity) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sourceFieldPolarity.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef referenceFieldPolarity, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(referenceFieldPolarity) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..referenceFieldPolarity.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef forwardReferenceFieldPolarity, IdRef backwardReferenceFieldPolarity, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(forwardReferenceFieldPolarity) + buffer.GetWordLength(backwardReferenceFieldPolarity) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..forwardReferenceFieldPolarity.AsSpirvSpan(), ..backwardReferenceFieldPolarity.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceConvertToImePayloadINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToImePayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceConvertToImeResultINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToImeResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceConvertToRefPayloadINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToRefPayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceConvertToRefResultINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToRefResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceConvertToSicPayloadINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToSicPayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceConvertToSicResultINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToSicResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetMotionVectorsINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetMotionVectorsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetInterDistortionsINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterDistortionsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetBestInterDistortionsINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetBestInterDistortionsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetInterMajorShapeINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterMajorShapeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetInterMinorShapeINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterMinorShapeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetInterDirectionsINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterDirectionsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetInterMotionVectorCountINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterMotionVectorCountINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetInterReferenceIdsINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterReferenceIdsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef packedReferenceIds, IdRef packedReferenceParameterFieldPolarities, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedReferenceIds) + buffer.GetWordLength(packedReferenceParameterFieldPolarities) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedReferenceIds.AsSpirvSpan(), ..packedReferenceParameterFieldPolarities.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeInitializeINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcCoord, IdRef partitionMask, IdRef sADAdjustment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcCoord) + buffer.GetWordLength(partitionMask) + buffer.GetWordLength(sADAdjustment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeInitializeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcCoord.AsSpirvSpan(), ..partitionMask.AsSpirvSpan(), ..sADAdjustment.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeSetSingleReferenceINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef refOffset, IdRef searchWindowConfig, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(refOffset) + buffer.GetWordLength(searchWindowConfig) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetSingleReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..refOffset.AsSpirvSpan(), ..searchWindowConfig.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeSetDualReferenceINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef fwdRefOffset, IdRef bwdRefOffset, IdRef idSearchWindowConfig, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(fwdRefOffset) + buffer.GetWordLength(bwdRefOffset) + buffer.GetWordLength(idSearchWindowConfig) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetDualReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..fwdRefOffset.AsSpirvSpan(), ..bwdRefOffset.AsSpirvSpan(), ..idSearchWindowConfig.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeRefWindowSizeINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef searchWindowConfig, IdRef dualRef)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(searchWindowConfig) + buffer.GetWordLength(dualRef);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeRefWindowSizeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..searchWindowConfig.AsSpirvSpan(), ..dualRef.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeAdjustRefOffsetINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef refOffset, IdRef srcCoord, IdRef refWindowSize, IdRef imageSize)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(refOffset) + buffer.GetWordLength(srcCoord) + buffer.GetWordLength(refWindowSize) + buffer.GetWordLength(imageSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeAdjustRefOffsetINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..refOffset.AsSpirvSpan(), ..srcCoord.AsSpirvSpan(), ..refWindowSize.AsSpirvSpan(), ..imageSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeConvertToMcePayloadINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeConvertToMcePayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeSetMaxMotionVectorCountINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef maxMotionVectorCount, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(maxMotionVectorCount) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetMaxMotionVectorCountINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..maxMotionVectorCount.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeSetUnidirectionalMixDisableINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef threshold, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(threshold) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..threshold.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeSetWeightedSadINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef packedSadWeights, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedSadWeights) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetWeightedSadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedSadWeights.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeEvaluateWithSingleReferenceINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeEvaluateWithDualReferenceINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithDualReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload, IdRef streaminComponents)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload) + buffer.GetWordLength(streaminComponents);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..streaminComponents.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload, IdRef streaminComponents)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload) + buffer.GetWordLength(streaminComponents);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..streaminComponents.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload, IdRef streaminComponents)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload) + buffer.GetWordLength(streaminComponents);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..streaminComponents.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload, IdRef streaminComponents)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload) + buffer.GetWordLength(streaminComponents);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..streaminComponents.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeConvertToMceResultINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeConvertToMceResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetSingleReferenceStreaminINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetSingleReferenceStreaminINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetDualReferenceStreaminINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetDualReferenceStreaminINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeStripSingleReferenceStreamoutINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeStripDualReferenceStreamoutINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeStripDualReferenceStreamoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape, IdRef direction)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape) + buffer.GetWordLength(direction);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan(), ..direction.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape, IdRef direction)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape) + buffer.GetWordLength(direction);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan(), ..direction.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape, IdRef direction)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape) + buffer.GetWordLength(direction);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan(), ..direction.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetBorderReachedINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef imageSelect, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(imageSelect) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetBorderReachedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..imageSelect.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetTruncatedSearchIndicationINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcFmeInitializeINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcCoord, IdRef motionVectors, IdRef majorShapes, IdRef minorShapes, IdRef direction, IdRef pixelResolution, IdRef sadAdjustment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcCoord) + buffer.GetWordLength(motionVectors) + buffer.GetWordLength(majorShapes) + buffer.GetWordLength(minorShapes) + buffer.GetWordLength(direction) + buffer.GetWordLength(pixelResolution) + buffer.GetWordLength(sadAdjustment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcFmeInitializeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcCoord.AsSpirvSpan(), ..motionVectors.AsSpirvSpan(), ..majorShapes.AsSpirvSpan(), ..minorShapes.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..pixelResolution.AsSpirvSpan(), ..sadAdjustment.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcBmeInitializeINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcCoord, IdRef motionVectors, IdRef majorShapes, IdRef minorShapes, IdRef direction, IdRef pixelResolution, IdRef bidirectionalWeight, IdRef sadAdjustment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcCoord) + buffer.GetWordLength(motionVectors) + buffer.GetWordLength(majorShapes) + buffer.GetWordLength(minorShapes) + buffer.GetWordLength(direction) + buffer.GetWordLength(pixelResolution) + buffer.GetWordLength(bidirectionalWeight) + buffer.GetWordLength(sadAdjustment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcBmeInitializeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcCoord.AsSpirvSpan(), ..motionVectors.AsSpirvSpan(), ..majorShapes.AsSpirvSpan(), ..minorShapes.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..pixelResolution.AsSpirvSpan(), ..bidirectionalWeight.AsSpirvSpan(), ..sadAdjustment.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcRefConvertToMcePayloadINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefConvertToMcePayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcRefSetBidirectionalMixDisableINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefSetBidirectionalMixDisableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcRefSetBilinearFilterEnableINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefSetBilinearFilterEnableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcRefEvaluateWithSingleReferenceINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcRefEvaluateWithDualReferenceINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefEvaluateWithDualReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcRefEvaluateWithMultiReferenceINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef packedReferenceIds, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(packedReferenceIds) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..packedReferenceIds.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef packedReferenceIds, IdRef packedReferenceFieldPolarities, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(packedReferenceIds) + buffer.GetWordLength(packedReferenceFieldPolarities) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..packedReferenceIds.AsSpirvSpan(), ..packedReferenceFieldPolarities.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcRefConvertToMceResultINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefConvertToMceResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicInitializeINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcCoord)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcCoord);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicInitializeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcCoord.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicConfigureSkcINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef skipBlockPartitionType, IdRef skipMotionVectorMask, IdRef motionVectors, IdRef bidirectionalWeight, IdRef sadAdjustment, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(skipBlockPartitionType) + buffer.GetWordLength(skipMotionVectorMask) + buffer.GetWordLength(motionVectors) + buffer.GetWordLength(bidirectionalWeight) + buffer.GetWordLength(sadAdjustment) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicConfigureSkcINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..skipBlockPartitionType.AsSpirvSpan(), ..skipMotionVectorMask.AsSpirvSpan(), ..motionVectors.AsSpirvSpan(), ..bidirectionalWeight.AsSpirvSpan(), ..sadAdjustment.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicConfigureIpeLumaINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef lumaIntraPartitionMask, IdRef intraNeighbourAvailabilty, IdRef leftEdgeLumaPixels, IdRef upperLeftCornerLumaPixel, IdRef upperEdgeLumaPixels, IdRef upperRightEdgeLumaPixels, IdRef sadAdjustment, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(lumaIntraPartitionMask) + buffer.GetWordLength(intraNeighbourAvailabilty) + buffer.GetWordLength(leftEdgeLumaPixels) + buffer.GetWordLength(upperLeftCornerLumaPixel) + buffer.GetWordLength(upperEdgeLumaPixels) + buffer.GetWordLength(upperRightEdgeLumaPixels) + buffer.GetWordLength(sadAdjustment) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicConfigureIpeLumaINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..lumaIntraPartitionMask.AsSpirvSpan(), ..intraNeighbourAvailabilty.AsSpirvSpan(), ..leftEdgeLumaPixels.AsSpirvSpan(), ..upperLeftCornerLumaPixel.AsSpirvSpan(), ..upperEdgeLumaPixels.AsSpirvSpan(), ..upperRightEdgeLumaPixels.AsSpirvSpan(), ..sadAdjustment.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicConfigureIpeLumaChromaINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef lumaIntraPartitionMask, IdRef intraNeighbourAvailabilty, IdRef leftEdgeLumaPixels, IdRef upperLeftCornerLumaPixel, IdRef upperEdgeLumaPixels, IdRef upperRightEdgeLumaPixels, IdRef leftEdgeChromaPixels, IdRef upperLeftCornerChromaPixel, IdRef upperEdgeChromaPixels, IdRef sadAdjustment, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(lumaIntraPartitionMask) + buffer.GetWordLength(intraNeighbourAvailabilty) + buffer.GetWordLength(leftEdgeLumaPixels) + buffer.GetWordLength(upperLeftCornerLumaPixel) + buffer.GetWordLength(upperEdgeLumaPixels) + buffer.GetWordLength(upperRightEdgeLumaPixels) + buffer.GetWordLength(leftEdgeChromaPixels) + buffer.GetWordLength(upperLeftCornerChromaPixel) + buffer.GetWordLength(upperEdgeChromaPixels) + buffer.GetWordLength(sadAdjustment) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicConfigureIpeLumaChromaINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..lumaIntraPartitionMask.AsSpirvSpan(), ..intraNeighbourAvailabilty.AsSpirvSpan(), ..leftEdgeLumaPixels.AsSpirvSpan(), ..upperLeftCornerLumaPixel.AsSpirvSpan(), ..upperEdgeLumaPixels.AsSpirvSpan(), ..upperRightEdgeLumaPixels.AsSpirvSpan(), ..leftEdgeChromaPixels.AsSpirvSpan(), ..upperLeftCornerChromaPixel.AsSpirvSpan(), ..upperEdgeChromaPixels.AsSpirvSpan(), ..sadAdjustment.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetMotionVectorMaskINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef skipBlockPartitionType, IdRef direction)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(skipBlockPartitionType) + buffer.GetWordLength(direction);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetMotionVectorMaskINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..skipBlockPartitionType.AsSpirvSpan(), ..direction.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicConvertToMcePayloadINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicConvertToMcePayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef packedShapePenalty, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedShapePenalty) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedShapePenalty.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef lumaModePenalty, IdRef lumaPackedNeighborModes, IdRef lumaPackedNonDcPenalty, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(lumaModePenalty) + buffer.GetWordLength(lumaPackedNeighborModes) + buffer.GetWordLength(lumaPackedNonDcPenalty) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..lumaModePenalty.AsSpirvSpan(), ..lumaPackedNeighborModes.AsSpirvSpan(), ..lumaPackedNonDcPenalty.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef chromaModeBasePenalty, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(chromaModeBasePenalty) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..chromaModeBasePenalty.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicSetBilinearFilterEnableINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetBilinearFilterEnableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicSetSkcForwardTransformEnableINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef packedSadCoefficients, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedSadCoefficients) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedSadCoefficients.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef blockBasedSkipType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(blockBasedSkipType) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..blockBasedSkipType.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicEvaluateIpeINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicEvaluateIpeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicEvaluateWithSingleReferenceINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicEvaluateWithDualReferenceINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicEvaluateWithDualReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicEvaluateWithMultiReferenceINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef packedReferenceIds, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(packedReferenceIds) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..packedReferenceIds.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef packedReferenceIds, IdRef packedReferenceFieldPolarities, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(packedReferenceIds) + buffer.GetWordLength(packedReferenceFieldPolarities) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..packedReferenceIds.AsSpirvSpan(), ..packedReferenceFieldPolarities.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicConvertToMceResultINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicConvertToMceResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetIpeLumaShapeINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetIpeLumaShapeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetBestIpeLumaDistortionINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetBestIpeChromaDistortionINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetPackedIpeLumaModesINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetPackedIpeLumaModesINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetIpeChromaModeINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetIpeChromaModeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetInterRawSadsINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetInterRawSadsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpVariableLengthArrayINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef lenght)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(lenght);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpVariableLengthArrayINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..lenght.AsSpirvSpan()]);
    }

    public static Instruction AddOpSaveMemoryINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSaveMemoryINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpRestoreMemoryINTEL<TBuffer>(this TBuffer buffer, IdRef ptr)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(ptr);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRestoreMemoryINTEL, ..ptr.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatSinCosPiINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger fromSign, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(fromSign) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSinCosPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..fromSign.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatCastINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCastINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatCastFromIntINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger mout, LiteralInteger fromSign, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(mout) + buffer.GetWordLength(fromSign) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCastFromIntINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..fromSign.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatCastToIntINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCastToIntINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatAddINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatAddINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatSubINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSubINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatMulINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatMulINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatDivINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatDivINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatGTINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatGTINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatGEINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatGEINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatLTINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLTINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatLEINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLEINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatEQINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatEQINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatRecipINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatRecipINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatRSqrtINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatRSqrtINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatCbrtINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCbrtINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatHypotINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatHypotINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatSqrtINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSqrtINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatLogINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLogINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatLog2INTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLog2INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatLog10INTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLog10INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatLog1pINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLog1pINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatExpINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatExpINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatExp2INTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatExp2INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatExp10INTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatExp10INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatExpm1INTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatExpm1INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatSinINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSinINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatCosINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatSinCosINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSinCosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatSinPiINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSinPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatCosPiINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCosPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatASinINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatASinINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatASinPiINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatASinPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatACosINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatACosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatACosPiINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatACosPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatATanINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatATanINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatATanPiINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatATanPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatATan2INTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatATan2INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatPowINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatPowINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatPowRINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatPowRINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatPowNINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatPowNINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpLoopControlINTEL<TBuffer>(this TBuffer buffer, Span<LiteralInteger> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLoopControlINTEL, ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpAliasDomainDeclINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdRef? name)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(name);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAliasDomainDeclINTEL, ..resultId.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction AddOpAliasScopeDeclINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdRef aliasDomain, IdRef? name)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(aliasDomain) + buffer.GetWordLength(name);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAliasScopeDeclINTEL, ..resultId.AsSpirvSpan(), ..aliasDomain.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction AddOpAliasScopeListDeclINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAliasScopeListDeclINTEL, ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedSqrtINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedSqrtINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedRecipINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedRecipINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedRsqrtINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedRsqrtINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedSinINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedSinINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedCosINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedCosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedSinCosINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedSinCosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedSinPiINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedSinPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedCosPiINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedCosPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedSinCosPiINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedSinCosPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedLogINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedLogINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedExpINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedExpINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpPtrCastToCrossWorkgroupINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpPtrCastToCrossWorkgroupINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction AddOpCrossWorkgroupCastToPtrINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCrossWorkgroupCastToPtrINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction AddOpReadPipeBlockingINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef packetSize, IdRef packetAlignment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReadPipeBlockingINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpWritePipeBlockingINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef packetSize, IdRef packetAlignment)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpWritePipeBlockingINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpFPGARegINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef result, IdRef input)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(result) + buffer.GetWordLength(input);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFPGARegINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..result.AsSpirvSpan(), ..input.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetRayTMinKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetRayTMinKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetRayFlagsKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetRayFlagsKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionTKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionTKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionInstanceCustomIndexKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionInstanceCustomIndexKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionInstanceIdKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionInstanceIdKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionGeometryIndexKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionGeometryIndexKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionPrimitiveIndexKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionPrimitiveIndexKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionBarycentricsKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionBarycentricsKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionFrontFaceKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionFrontFaceKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionCandidateAABBOpaqueKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionCandidateAABBOpaqueKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionObjectRayDirectionKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionObjectRayDirectionKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionObjectRayOriginKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionObjectRayOriginKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetWorldRayDirectionKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetWorldRayDirectionKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetWorldRayOriginKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetWorldRayOriginKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionObjectToWorldKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionObjectToWorldKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionWorldToObjectKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionWorldToObjectKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicFAddEXT<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicFAddEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeBufferSurfaceINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, AccessQualifier accessQualifier)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(accessQualifier);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeBufferSurfaceINTEL, ..resultId.AsSpirvSpan(), ..accessQualifier.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeStructContinuedINTEL<TBuffer>(this TBuffer buffer, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeStructContinuedINTEL, ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantCompositeContinuedINTEL<TBuffer>(this TBuffer buffer, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantCompositeContinuedINTEL, ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpSpecConstantCompositeContinuedINTEL<TBuffer>(this TBuffer buffer, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSpecConstantCompositeContinuedINTEL, ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpCompositeConstructContinuedINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, Span<IdRef> values)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCompositeConstructContinuedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertFToBF16INTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef floatValue)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(floatValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertFToBF16INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..floatValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertBF16ToFINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef bFloat16Value)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(bFloat16Value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertBF16ToFINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..bFloat16Value.AsSpirvSpan()]);
    }

    public static Instruction AddOpControlBarrierArriveINTEL<TBuffer>(this TBuffer buffer, IdScope execution, IdScope memory, IdMemorySemantics semantics)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpControlBarrierArriveINTEL, ..execution.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpControlBarrierWaitINTEL<TBuffer>(this TBuffer buffer, IdScope execution, IdScope memory, IdMemorySemantics semantics)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpControlBarrierWaitINTEL, ..execution.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpArithmeticFenceEXT<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef target)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(target);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArithmeticFenceEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..target.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupBlockPrefetchINTEL<TBuffer>(this TBuffer buffer, IdRef ptr, IdRef numBytes, MemoryAccessMask? memoryaccess)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(ptr) + buffer.GetWordLength(numBytes) + buffer.GetWordLength(memoryaccess);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupBlockPrefetchINTEL, ..ptr.AsSpirvSpan(), ..numBytes.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupIMulKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupIMulKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupFMulKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupFMulKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupBitwiseAndKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupBitwiseAndKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupBitwiseOrKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupBitwiseOrKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupBitwiseXorKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupBitwiseXorKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupLogicalAndKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupLogicalAndKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupLogicalOrKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupLogicalOrKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupLogicalXorKHR<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupLogicalXorKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpMaskedGatherINTEL<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, IdRef ptrVector, LiteralInteger alignment, IdRef mask, IdRef fillEmpty)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(ptrVector) + buffer.GetWordLength(alignment) + buffer.GetWordLength(mask) + buffer.GetWordLength(fillEmpty);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMaskedGatherINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..ptrVector.AsSpirvSpan(), ..alignment.AsSpirvSpan(), ..mask.AsSpirvSpan(), ..fillEmpty.AsSpirvSpan()]);
    }

    public static Instruction AddOpMaskedScatterINTEL<TBuffer>(this TBuffer buffer, IdRef inputVector, IdRef ptrVector, LiteralInteger alignment, IdRef mask)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(inputVector) + buffer.GetWordLength(ptrVector) + buffer.GetWordLength(alignment) + buffer.GetWordLength(mask);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMaskedScatterINTEL, ..inputVector.AsSpirvSpan(), ..ptrVector.AsSpirvSpan(), ..alignment.AsSpirvSpan(), ..mask.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLMixinName<TBuffer>(this TBuffer buffer, LiteralString mixinName)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(mixinName);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLMixinName, ..mixinName.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLMixinEnd<TBuffer>(this TBuffer buffer)
        where TBuffer : IMutSpirvBuffer
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpSDSLMixinEnd]);
    }

    public static Instruction AddOpSDSLMixinOffset<TBuffer>(this TBuffer buffer, LiteralInteger mixinName)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(mixinName);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLMixinOffset, ..mixinName.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLMixinInherit<TBuffer>(this TBuffer buffer, LiteralString mixinName)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(mixinName);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLMixinInherit, ..mixinName.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLCompose<TBuffer>(this TBuffer buffer, LiteralString mixin, LiteralString name)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(mixin) + buffer.GetWordLength(name);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLCompose, ..mixin.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLStage<TBuffer>(this TBuffer buffer, IdRef stagedElement)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(stagedElement);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLStage, ..stagedElement.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLImportFunction<TBuffer>(this TBuffer buffer, IdResult resultId, LiteralString functionName, LiteralString mixinName, LiteralInteger id, LiteralInteger typeId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(functionName) + buffer.GetWordLength(mixinName) + buffer.GetWordLength(id) + buffer.GetWordLength(typeId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLImportFunction, ..resultId.AsSpirvSpan(), ..functionName.AsSpirvSpan(), ..mixinName.AsSpirvSpan(), ..id.AsSpirvSpan(), ..typeId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLImportVariable<TBuffer>(this TBuffer buffer, IdResult resultId, LiteralString variableName, LiteralString mixinName, LiteralInteger id)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(variableName) + buffer.GetWordLength(mixinName) + buffer.GetWordLength(id);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLImportVariable, ..resultId.AsSpirvSpan(), ..variableName.AsSpirvSpan(), ..mixinName.AsSpirvSpan(), ..id.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLImportIdRef<TBuffer>(this TBuffer buffer, IdResult resultId, LiteralString mixinName, LiteralInteger id)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(mixinName) + buffer.GetWordLength(id);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLImportIdRef, ..resultId.AsSpirvSpan(), ..mixinName.AsSpirvSpan(), ..id.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLMixinVariable<TBuffer>(this TBuffer buffer, IdResult resultId, IdRef mixinId, IdRef variableId)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(mixinId) + buffer.GetWordLength(variableId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLMixinVariable, ..resultId.AsSpirvSpan(), ..mixinId.AsSpirvSpan(), ..variableId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLVariable<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, StorageClass storageclass, LiteralString name, IdRef? initializer)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass) + buffer.GetWordLength(name) + buffer.GetWordLength(initializer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLVariable, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan(), ..name.AsSpirvSpan(), ..initializer.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLFunctionParameter<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, LiteralString name)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(name);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLFunctionParameter, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLIOVariable<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, StorageClass storageclass, ExecutionModel executionmodel, LiteralString name, LiteralString semantic, IdRef? initializer)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass) + buffer.GetWordLength(executionmodel) + buffer.GetWordLength(name) + buffer.GetWordLength(semantic) + buffer.GetWordLength(initializer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLIOVariable, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan(), ..executionmodel.AsSpirvSpan(), ..name.AsSpirvSpan(), ..semantic.AsSpirvSpan(), ..initializer.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLFunction<TBuffer>(this TBuffer buffer, IdResult resultId, IdResultType resultType, FunctionControlMask functioncontrol, IdRef functionType, LiteralString functionName)
        where TBuffer : IMutSpirvBuffer
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(functioncontrol) + buffer.GetWordLength(functionType) + buffer.GetWordLength(functionName);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLFunction, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..functioncontrol.AsSpirvSpan(), ..functionType.AsSpirvSpan(), ..functionName.AsSpirvSpan()]);
    }

    public static Instruction AddGLSLRound(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 1, resultId, resultType, refs);
    }

    public static Instruction AddGLSLRoundEven(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 2, resultId, resultType, refs);
    }

    public static Instruction AddGLSLTrunc(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 3, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFAbs(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 4, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSAbs(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 5, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFSign(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 6, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSSign(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 7, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFloor(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 8, resultId, resultType, refs);
    }

    public static Instruction AddGLSLCeil(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 9, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFract(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 10, resultId, resultType, refs);
    }

    public static Instruction AddGLSLRadians(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef degrees, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            degrees
        };
        return buffer.AddOpExtInst(set, 11, resultId, resultType, refs);
    }

    public static Instruction AddGLSLDegrees(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef radians, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            radians
        };
        return buffer.AddOpExtInst(set, 12, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSin(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 13, resultId, resultType, refs);
    }

    public static Instruction AddGLSLCos(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 14, resultId, resultType, refs);
    }

    public static Instruction AddGLSLTan(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 15, resultId, resultType, refs);
    }

    public static Instruction AddGLSLAsin(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 16, resultId, resultType, refs);
    }

    public static Instruction AddGLSLAcos(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 17, resultId, resultType, refs);
    }

    public static Instruction AddGLSLAtan(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef y_over_x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            y_over_x
        };
        return buffer.AddOpExtInst(set, 18, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSinh(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 19, resultId, resultType, refs);
    }

    public static Instruction AddGLSLCosh(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 20, resultId, resultType, refs);
    }

    public static Instruction AddGLSLTanh(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 21, resultId, resultType, refs);
    }

    public static Instruction AddGLSLAsinh(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 22, resultId, resultType, refs);
    }

    public static Instruction AddGLSLAcosh(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 23, resultId, resultType, refs);
    }

    public static Instruction AddGLSLAtanh(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 24, resultId, resultType, refs);
    }

    public static Instruction AddGLSLAtan2(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef y, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            y,
            x
        };
        return buffer.AddOpExtInst(set, 25, resultId, resultType, refs);
    }

    public static Instruction AddGLSLPow(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            y
        };
        return buffer.AddOpExtInst(set, 26, resultId, resultType, refs);
    }

    public static Instruction AddGLSLExp(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 27, resultId, resultType, refs);
    }

    public static Instruction AddGLSLLog(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 28, resultId, resultType, refs);
    }

    public static Instruction AddGLSLExp2(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 29, resultId, resultType, refs);
    }

    public static Instruction AddGLSLLog2(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 30, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSqrt(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 31, resultId, resultType, refs);
    }

    public static Instruction AddGLSLInverseSqrt(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 32, resultId, resultType, refs);
    }

    public static Instruction AddGLSLDeterminant(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 33, resultId, resultType, refs);
    }

    public static Instruction AddGLSLMatrixInverse(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 34, resultId, resultType, refs);
    }

    public static Instruction AddGLSLModf(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef i, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            i
        };
        return buffer.AddOpExtInst(set, 35, resultId, resultType, refs);
    }

    public static Instruction AddGLSLModfStruct(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 36, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFMin(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            y
        };
        return buffer.AddOpExtInst(set, 37, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUMin(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            y
        };
        return buffer.AddOpExtInst(set, 38, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSMin(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            y
        };
        return buffer.AddOpExtInst(set, 39, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFMax(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            y
        };
        return buffer.AddOpExtInst(set, 40, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUMax(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            y
        };
        return buffer.AddOpExtInst(set, 41, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSMax(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            y
        };
        return buffer.AddOpExtInst(set, 42, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFClamp(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef minVal, IdRef maxVal, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            minVal,
            maxVal
        };
        return buffer.AddOpExtInst(set, 43, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUClamp(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef minVal, IdRef maxVal, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            minVal,
            maxVal
        };
        return buffer.AddOpExtInst(set, 44, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSClamp(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef minVal, IdRef maxVal, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            minVal,
            maxVal
        };
        return buffer.AddOpExtInst(set, 45, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFMix(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, IdRef a, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            y,
            a
        };
        return buffer.AddOpExtInst(set, 46, resultId, resultType, refs);
    }

    public static Instruction AddGLSLIMix(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, IdRef a, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            y,
            a
        };
        return buffer.AddOpExtInst(set, 47, resultId, resultType, refs);
    }

    public static Instruction AddGLSLStep(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef edge, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            edge,
            x
        };
        return buffer.AddOpExtInst(set, 48, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSmoothStep(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef edge0, IdRef edge1, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            edge0,
            edge1,
            x
        };
        return buffer.AddOpExtInst(set, 49, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFma(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef a, IdRef b, IdRef c, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            a,
            b,
            c
        };
        return buffer.AddOpExtInst(set, 50, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFrexp(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef exp, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            exp
        };
        return buffer.AddOpExtInst(set, 51, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFrexpStruct(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 52, resultId, resultType, refs);
    }

    public static Instruction AddGLSLLdexp(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef exp, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            exp
        };
        return buffer.AddOpExtInst(set, 53, resultId, resultType, refs);
    }

    public static Instruction AddGLSLPackSnorm4x8(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            v
        };
        return buffer.AddOpExtInst(set, 54, resultId, resultType, refs);
    }

    public static Instruction AddGLSLPackUnorm4x8(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            v
        };
        return buffer.AddOpExtInst(set, 55, resultId, resultType, refs);
    }

    public static Instruction AddGLSLPackSnorm2x16(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            v
        };
        return buffer.AddOpExtInst(set, 56, resultId, resultType, refs);
    }

    public static Instruction AddGLSLPackUnorm2x16(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            v
        };
        return buffer.AddOpExtInst(set, 57, resultId, resultType, refs);
    }

    public static Instruction AddGLSLPackHalf2x16(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            v
        };
        return buffer.AddOpExtInst(set, 58, resultId, resultType, refs);
    }

    public static Instruction AddGLSLPackDouble2x32(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            v
        };
        return buffer.AddOpExtInst(set, 59, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUnpackSnorm2x16(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef p, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            p
        };
        return buffer.AddOpExtInst(set, 60, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUnpackUnorm2x16(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef p, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            p
        };
        return buffer.AddOpExtInst(set, 61, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUnpackHalf2x16(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            v
        };
        return buffer.AddOpExtInst(set, 62, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUnpackSnorm4x8(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef p, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            p
        };
        return buffer.AddOpExtInst(set, 63, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUnpackUnorm4x8(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef p, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            p
        };
        return buffer.AddOpExtInst(set, 64, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUnpackDouble2x32(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            v
        };
        return buffer.AddOpExtInst(set, 65, resultId, resultType, refs);
    }

    public static Instruction AddGLSLLength(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 66, resultId, resultType, refs);
    }

    public static Instruction AddGLSLDistance(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef p0, IdRef p1, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            p0,
            p1
        };
        return buffer.AddOpExtInst(set, 67, resultId, resultType, refs);
    }

    public static Instruction AddGLSLCross(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            y
        };
        return buffer.AddOpExtInst(set, 68, resultId, resultType, refs);
    }

    public static Instruction AddGLSLNormalize(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x
        };
        return buffer.AddOpExtInst(set, 69, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFaceForward(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef n, IdRef i, IdRef nref, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            n,
            i,
            nref
        };
        return buffer.AddOpExtInst(set, 70, resultId, resultType, refs);
    }

    public static Instruction AddGLSLReflect(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef i, IdRef n, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            i,
            n
        };
        return buffer.AddOpExtInst(set, 71, resultId, resultType, refs);
    }

    public static Instruction AddGLSLRefract(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef i, IdRef n, IdRef eta, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            i,
            n,
            eta
        };
        return buffer.AddOpExtInst(set, 72, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFindILsb(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef value, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            value
        };
        return buffer.AddOpExtInst(set, 73, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFindSMsb(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef value, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            value
        };
        return buffer.AddOpExtInst(set, 74, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFindUMsb(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef value, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            value
        };
        return buffer.AddOpExtInst(set, 75, resultId, resultType, refs);
    }

    public static Instruction AddGLSLInterpolateAtCentroid(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef interpolant, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            interpolant
        };
        return buffer.AddOpExtInst(set, 76, resultId, resultType, refs);
    }

    public static Instruction AddGLSLInterpolateAtSample(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef interpolant, IdRef sample, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            interpolant,
            sample
        };
        return buffer.AddOpExtInst(set, 77, resultId, resultType, refs);
    }

    public static Instruction AddGLSLInterpolateAtOffset(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef interpolant, IdRef offset, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            interpolant,
            offset
        };
        return buffer.AddOpExtInst(set, 78, resultId, resultType, refs);
    }

    public static Instruction AddGLSLNMin(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            y
        };
        return buffer.AddOpExtInst(set, 79, resultId, resultType, refs);
    }

    public static Instruction AddGLSLNMax(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            y
        };
        return buffer.AddOpExtInst(set, 80, resultId, resultType, refs);
    }

    public static Instruction AddGLSLNClamp(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef minVal, IdRef maxVal, int set)
    {
        Span<IdRef> refs = stackalloc IdRef[]
        {
            x,
            minVal,
            maxVal
        };
        return buffer.AddOpExtInst(set, 81, resultId, resultType, refs);
    }
}