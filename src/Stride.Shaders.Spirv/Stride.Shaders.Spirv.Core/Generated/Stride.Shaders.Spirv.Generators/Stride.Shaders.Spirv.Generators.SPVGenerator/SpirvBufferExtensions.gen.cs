using static Spv.Specification;

namespace Stride.Shaders.Spirv.Core.Buffers;
public static class SpirvBufferExtensions
{
    public static Instruction AddOpNop(this SpirvBuffer buffer)
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpNop]);
    }

    public static Instruction InsertOpNop(this SpirvBuffer buffer, int position)
    {
        return buffer.Insert(position, [1 << 16 | (int)SDSLOp.OpNop]);
    }

    public static Instruction AddOpUndef(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUndef, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUndef(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUndef, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSourceContinued(this SpirvBuffer buffer, LiteralString continuedSource)
    {
        var wordLength = 1 + buffer.GetWordLength(continuedSource);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSourceContinued, ..continuedSource.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSourceContinued(this SpirvBuffer buffer, int position, LiteralString continuedSource)
    {
        var wordLength = 1 + buffer.GetWordLength(continuedSource);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSourceContinued, ..continuedSource.AsSpirvSpan()]);
    }

    public static Instruction AddOpSource(this SpirvBuffer buffer, SourceLanguage sourcelanguage, LiteralInteger version, IdRef? file, LiteralString? source)
    {
        var wordLength = 1 + buffer.GetWordLength(sourcelanguage) + buffer.GetWordLength(version) + buffer.GetWordLength(file) + buffer.GetWordLength(source);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSource, ..sourcelanguage.AsSpirvSpan(), ..version.AsSpirvSpan(), ..file.AsSpirvSpan(), ..source.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSource(this SpirvBuffer buffer, int position, SourceLanguage sourcelanguage, LiteralInteger version, IdRef? file, LiteralString? source)
    {
        var wordLength = 1 + buffer.GetWordLength(sourcelanguage) + buffer.GetWordLength(version) + buffer.GetWordLength(file) + buffer.GetWordLength(source);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSource, ..sourcelanguage.AsSpirvSpan(), ..version.AsSpirvSpan(), ..file.AsSpirvSpan(), ..source.AsSpirvSpan()]);
    }

    public static Instruction AddOpSourceExtension(this SpirvBuffer buffer, LiteralString extension)
    {
        var wordLength = 1 + buffer.GetWordLength(extension);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSourceExtension, ..extension.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSourceExtension(this SpirvBuffer buffer, int position, LiteralString extension)
    {
        var wordLength = 1 + buffer.GetWordLength(extension);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSourceExtension, ..extension.AsSpirvSpan()]);
    }

    public static Instruction AddOpName(this SpirvBuffer buffer, IdRef target, LiteralString name)
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(name);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpName, ..target.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction InsertOpName(this SpirvBuffer buffer, int position, IdRef target, LiteralString name)
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(name);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpName, ..target.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction AddOpMemberName(this SpirvBuffer buffer, IdRef type, LiteralInteger member, LiteralString name)
    {
        var wordLength = 1 + buffer.GetWordLength(type) + buffer.GetWordLength(member) + buffer.GetWordLength(name);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMemberName, ..type.AsSpirvSpan(), ..member.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction InsertOpMemberName(this SpirvBuffer buffer, int position, IdRef type, LiteralInteger member, LiteralString name)
    {
        var wordLength = 1 + buffer.GetWordLength(type) + buffer.GetWordLength(member) + buffer.GetWordLength(name);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpMemberName, ..type.AsSpirvSpan(), ..member.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction AddOpString(this SpirvBuffer buffer, IdResult resultId, LiteralString value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpString, ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpString(this SpirvBuffer buffer, int position, IdResult resultId, LiteralString value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpString, ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpLine(this SpirvBuffer buffer, IdRef file, LiteralInteger line, LiteralInteger column)
    {
        var wordLength = 1 + buffer.GetWordLength(file) + buffer.GetWordLength(line) + buffer.GetWordLength(column);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLine, ..file.AsSpirvSpan(), ..line.AsSpirvSpan(), ..column.AsSpirvSpan()]);
    }

    public static Instruction InsertOpLine(this SpirvBuffer buffer, int position, IdRef file, LiteralInteger line, LiteralInteger column)
    {
        var wordLength = 1 + buffer.GetWordLength(file) + buffer.GetWordLength(line) + buffer.GetWordLength(column);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpLine, ..file.AsSpirvSpan(), ..line.AsSpirvSpan(), ..column.AsSpirvSpan()]);
    }

    public static Instruction AddOpExtension(this SpirvBuffer buffer, LiteralString name)
    {
        var wordLength = 1 + buffer.GetWordLength(name);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExtension, ..name.AsSpirvSpan()]);
    }

    public static Instruction InsertOpExtension(this SpirvBuffer buffer, int position, LiteralString name)
    {
        var wordLength = 1 + buffer.GetWordLength(name);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpExtension, ..name.AsSpirvSpan()]);
    }

    public static Instruction AddOpExtInstImport(this SpirvBuffer buffer, IdResult resultId, LiteralString name)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(name);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExtInstImport, ..resultId.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction InsertOpExtInstImport(this SpirvBuffer buffer, int position, IdResult resultId, LiteralString name)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(name);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpExtInstImport, ..resultId.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction AddOpExtInst(this SpirvBuffer buffer, IdRef set, LiteralInteger instruction, IdResult? resultId, IdResultType? resultType, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(set) + buffer.GetWordLength(instruction) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExtInst, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..set.AsSpirvSpan(), ..instruction.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpExtInst(this SpirvBuffer buffer, int position, IdRef set, LiteralInteger instruction, IdResult? resultId, IdResultType? resultType, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(set) + buffer.GetWordLength(instruction) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpExtInst, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..set.AsSpirvSpan(), ..instruction.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpMemoryModel(this SpirvBuffer buffer, AddressingModel addressingmodel, MemoryModel memorymodel)
    {
        var wordLength = 1 + buffer.GetWordLength(addressingmodel) + buffer.GetWordLength(memorymodel);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMemoryModel, ..addressingmodel.AsSpirvSpan(), ..memorymodel.AsSpirvSpan()]);
    }

    public static Instruction InsertOpMemoryModel(this SpirvBuffer buffer, int position, AddressingModel addressingmodel, MemoryModel memorymodel)
    {
        var wordLength = 1 + buffer.GetWordLength(addressingmodel) + buffer.GetWordLength(memorymodel);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpMemoryModel, ..addressingmodel.AsSpirvSpan(), ..memorymodel.AsSpirvSpan()]);
    }

    public static Instruction AddOpEntryPoint(this SpirvBuffer buffer, ExecutionModel executionmodel, IdRef entryPoint, LiteralString name, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(executionmodel) + buffer.GetWordLength(entryPoint) + buffer.GetWordLength(name) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpEntryPoint, ..executionmodel.AsSpirvSpan(), ..entryPoint.AsSpirvSpan(), ..name.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpEntryPoint(this SpirvBuffer buffer, int position, ExecutionModel executionmodel, IdRef entryPoint, LiteralString name, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(executionmodel) + buffer.GetWordLength(entryPoint) + buffer.GetWordLength(name) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpEntryPoint, ..executionmodel.AsSpirvSpan(), ..entryPoint.AsSpirvSpan(), ..name.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpExecutionMode(this SpirvBuffer buffer, IdRef entryPoint, ExecutionMode mode)
    {
        var wordLength = 1 + buffer.GetWordLength(entryPoint) + buffer.GetWordLength(mode);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExecutionMode, ..entryPoint.AsSpirvSpan(), ..mode.AsSpirvSpan()]);
    }

    public static Instruction InsertOpExecutionMode(this SpirvBuffer buffer, int position, IdRef entryPoint, ExecutionMode mode)
    {
        var wordLength = 1 + buffer.GetWordLength(entryPoint) + buffer.GetWordLength(mode);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpExecutionMode, ..entryPoint.AsSpirvSpan(), ..mode.AsSpirvSpan()]);
    }

    public static Instruction AddOpCapability(this SpirvBuffer buffer, Capability capability)
    {
        var wordLength = 1 + buffer.GetWordLength(capability);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCapability, ..capability.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCapability(this SpirvBuffer buffer, int position, Capability capability)
    {
        var wordLength = 1 + buffer.GetWordLength(capability);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCapability, ..capability.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeVoid(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeVoid, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeVoid(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeVoid, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeBool(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeBool, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeBool(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeBool, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeInt(this SpirvBuffer buffer, IdResult resultId, LiteralInteger width, LiteralInteger signedness)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(width) + buffer.GetWordLength(signedness);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeInt, ..resultId.AsSpirvSpan(), ..width.AsSpirvSpan(), ..signedness.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeInt(this SpirvBuffer buffer, int position, IdResult resultId, LiteralInteger width, LiteralInteger signedness)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(width) + buffer.GetWordLength(signedness);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeInt, ..resultId.AsSpirvSpan(), ..width.AsSpirvSpan(), ..signedness.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeFloat(this SpirvBuffer buffer, IdResult resultId, LiteralInteger width, FPEncoding? floatingPointEncoding)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(width) + buffer.GetWordLength(floatingPointEncoding);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeFloat, ..resultId.AsSpirvSpan(), ..width.AsSpirvSpan(), ..floatingPointEncoding.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeFloat(this SpirvBuffer buffer, int position, IdResult resultId, LiteralInteger width, FPEncoding? floatingPointEncoding)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(width) + buffer.GetWordLength(floatingPointEncoding);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeFloat, ..resultId.AsSpirvSpan(), ..width.AsSpirvSpan(), ..floatingPointEncoding.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeVector(this SpirvBuffer buffer, IdResult resultId, IdRef componentType, LiteralInteger componentCount)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(componentType) + buffer.GetWordLength(componentCount);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeVector, ..resultId.AsSpirvSpan(), ..componentType.AsSpirvSpan(), ..componentCount.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeVector(this SpirvBuffer buffer, int position, IdResult resultId, IdRef componentType, LiteralInteger componentCount)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(componentType) + buffer.GetWordLength(componentCount);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeVector, ..resultId.AsSpirvSpan(), ..componentType.AsSpirvSpan(), ..componentCount.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeMatrix(this SpirvBuffer buffer, IdResult resultId, IdRef columnType, LiteralInteger columnCount)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(columnType) + buffer.GetWordLength(columnCount);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeMatrix, ..resultId.AsSpirvSpan(), ..columnType.AsSpirvSpan(), ..columnCount.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeMatrix(this SpirvBuffer buffer, int position, IdResult resultId, IdRef columnType, LiteralInteger columnCount)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(columnType) + buffer.GetWordLength(columnCount);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeMatrix, ..resultId.AsSpirvSpan(), ..columnType.AsSpirvSpan(), ..columnCount.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeImage(this SpirvBuffer buffer, IdResult resultId, IdRef sampledType, Dim dim, LiteralInteger depth, LiteralInteger arrayed, LiteralInteger mS, LiteralInteger sampled, ImageFormat imageformat, AccessQualifier? accessqualifier)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledType) + buffer.GetWordLength(dim) + buffer.GetWordLength(depth) + buffer.GetWordLength(arrayed) + buffer.GetWordLength(mS) + buffer.GetWordLength(sampled) + buffer.GetWordLength(imageformat) + buffer.GetWordLength(accessqualifier);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeImage, ..resultId.AsSpirvSpan(), ..sampledType.AsSpirvSpan(), ..dim.AsSpirvSpan(), ..depth.AsSpirvSpan(), ..arrayed.AsSpirvSpan(), ..mS.AsSpirvSpan(), ..sampled.AsSpirvSpan(), ..imageformat.AsSpirvSpan(), ..accessqualifier.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeImage(this SpirvBuffer buffer, int position, IdResult resultId, IdRef sampledType, Dim dim, LiteralInteger depth, LiteralInteger arrayed, LiteralInteger mS, LiteralInteger sampled, ImageFormat imageformat, AccessQualifier? accessqualifier)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledType) + buffer.GetWordLength(dim) + buffer.GetWordLength(depth) + buffer.GetWordLength(arrayed) + buffer.GetWordLength(mS) + buffer.GetWordLength(sampled) + buffer.GetWordLength(imageformat) + buffer.GetWordLength(accessqualifier);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeImage, ..resultId.AsSpirvSpan(), ..sampledType.AsSpirvSpan(), ..dim.AsSpirvSpan(), ..depth.AsSpirvSpan(), ..arrayed.AsSpirvSpan(), ..mS.AsSpirvSpan(), ..sampled.AsSpirvSpan(), ..imageformat.AsSpirvSpan(), ..accessqualifier.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeSampler(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeSampler, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeSampler(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeSampler, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeSampledImage(this SpirvBuffer buffer, IdResult resultId, IdRef imageType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(imageType);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeSampledImage, ..resultId.AsSpirvSpan(), ..imageType.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeSampledImage(this SpirvBuffer buffer, int position, IdResult resultId, IdRef imageType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(imageType);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeSampledImage, ..resultId.AsSpirvSpan(), ..imageType.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeArray(this SpirvBuffer buffer, IdResult resultId, IdRef elementType, IdRef length)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(elementType) + buffer.GetWordLength(length);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeArray, ..resultId.AsSpirvSpan(), ..elementType.AsSpirvSpan(), ..length.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeArray(this SpirvBuffer buffer, int position, IdResult resultId, IdRef elementType, IdRef length)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(elementType) + buffer.GetWordLength(length);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeArray, ..resultId.AsSpirvSpan(), ..elementType.AsSpirvSpan(), ..length.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeRuntimeArray(this SpirvBuffer buffer, IdResult resultId, IdRef elementType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(elementType);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeRuntimeArray, ..resultId.AsSpirvSpan(), ..elementType.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeRuntimeArray(this SpirvBuffer buffer, int position, IdResult resultId, IdRef elementType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(elementType);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeRuntimeArray, ..resultId.AsSpirvSpan(), ..elementType.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeStruct(this SpirvBuffer buffer, IdResult resultId, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeStruct, ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeStruct(this SpirvBuffer buffer, int position, IdResult resultId, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeStruct, ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeOpaque(this SpirvBuffer buffer, IdResult resultId, LiteralString thenameoftheopaquetype)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(thenameoftheopaquetype);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeOpaque, ..resultId.AsSpirvSpan(), ..thenameoftheopaquetype.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeOpaque(this SpirvBuffer buffer, int position, IdResult resultId, LiteralString thenameoftheopaquetype)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(thenameoftheopaquetype);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeOpaque, ..resultId.AsSpirvSpan(), ..thenameoftheopaquetype.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypePointer(this SpirvBuffer buffer, IdResult resultId, StorageClass storageclass, IdRef type)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass) + buffer.GetWordLength(type);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypePointer, ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan(), ..type.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypePointer(this SpirvBuffer buffer, int position, IdResult resultId, StorageClass storageclass, IdRef type)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass) + buffer.GetWordLength(type);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypePointer, ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan(), ..type.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeFunction(this SpirvBuffer buffer, IdResult resultId, IdRef returnType, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(returnType) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeFunction, ..resultId.AsSpirvSpan(), ..returnType.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeFunction(this SpirvBuffer buffer, int position, IdResult resultId, IdRef returnType, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(returnType) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeFunction, ..resultId.AsSpirvSpan(), ..returnType.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeEvent(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeEvent, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeEvent(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeEvent, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeDeviceEvent(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeDeviceEvent, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeDeviceEvent(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeDeviceEvent, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeReserveId(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeReserveId, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeReserveId(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeReserveId, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeQueue(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeQueue, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeQueue(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeQueue, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypePipe(this SpirvBuffer buffer, IdResult resultId, AccessQualifier qualifier)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(qualifier);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypePipe, ..resultId.AsSpirvSpan(), ..qualifier.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypePipe(this SpirvBuffer buffer, int position, IdResult resultId, AccessQualifier qualifier)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(qualifier);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypePipe, ..resultId.AsSpirvSpan(), ..qualifier.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeForwardPointer(this SpirvBuffer buffer, IdRef pointerType, StorageClass storageclass)
    {
        var wordLength = 1 + buffer.GetWordLength(pointerType) + buffer.GetWordLength(storageclass);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeForwardPointer, ..pointerType.AsSpirvSpan(), ..storageclass.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeForwardPointer(this SpirvBuffer buffer, int position, IdRef pointerType, StorageClass storageclass)
    {
        var wordLength = 1 + buffer.GetWordLength(pointerType) + buffer.GetWordLength(storageclass);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeForwardPointer, ..pointerType.AsSpirvSpan(), ..storageclass.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantTrue(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantTrue, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConstantTrue(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConstantTrue, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantFalse(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantFalse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConstantFalse(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConstantFalse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstant<TValue>(this SpirvBuffer buffer, IdResult resultId, IdResultType? resultType, TValue value)
        where TValue : struct, ILiteralNumber
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + value.WordCount;
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstant, ..resultType.AsSpirvSpan(), resultId, ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConstant<TValue>(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType? resultType, TValue value)
        where TValue : struct, ILiteralNumber
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + value.WordCount;
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConstant, ..resultType.AsSpirvSpan(), resultId, ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantComposite(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantComposite, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConstantComposite(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConstantComposite, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantSampler(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, SamplerAddressingMode sampleraddressingmode, LiteralInteger param, SamplerFilterMode samplerfiltermode)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampleraddressingmode) + buffer.GetWordLength(param) + buffer.GetWordLength(samplerfiltermode);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantSampler, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampleraddressingmode.AsSpirvSpan(), ..param.AsSpirvSpan(), ..samplerfiltermode.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConstantSampler(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, SamplerAddressingMode sampleraddressingmode, LiteralInteger param, SamplerFilterMode samplerfiltermode)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampleraddressingmode) + buffer.GetWordLength(param) + buffer.GetWordLength(samplerfiltermode);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConstantSampler, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampleraddressingmode.AsSpirvSpan(), ..param.AsSpirvSpan(), ..samplerfiltermode.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantNull(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantNull, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConstantNull(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConstantNull, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSpecConstantTrue(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSpecConstantTrue, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSpecConstantTrue(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSpecConstantTrue, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSpecConstantFalse(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSpecConstantFalse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSpecConstantFalse(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSpecConstantFalse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSpecConstant<TValue>(this SpirvBuffer buffer, IdResult resultId, IdResultType? resultType, TValue value)
        where TValue : struct, ILiteralNumber
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + value.WordCount;
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSpecConstant, ..resultType.AsSpirvSpan(), resultId, ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSpecConstant<TValue>(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType? resultType, TValue value)
        where TValue : struct, ILiteralNumber
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + value.WordCount;
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSpecConstant, ..resultType.AsSpirvSpan(), resultId, ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpSpecConstantComposite(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSpecConstantComposite, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSpecConstantComposite(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSpecConstantComposite, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpSpecConstantOp(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, Op opcode)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(opcode);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSpecConstantOp, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..opcode.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSpecConstantOp(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, Op opcode)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(opcode);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSpecConstantOp, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..opcode.AsSpirvSpan()]);
    }

    public static Instruction AddOpFunction(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, FunctionControlMask functioncontrol, IdRef functionType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(functioncontrol) + buffer.GetWordLength(functionType);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFunction, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..functioncontrol.AsSpirvSpan(), ..functionType.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFunction(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, FunctionControlMask functioncontrol, IdRef functionType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(functioncontrol) + buffer.GetWordLength(functionType);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFunction, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..functioncontrol.AsSpirvSpan(), ..functionType.AsSpirvSpan()]);
    }

    public static Instruction AddOpFunctionParameter(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFunctionParameter, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFunctionParameter(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFunctionParameter, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpFunctionEnd(this SpirvBuffer buffer)
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpFunctionEnd]);
    }

    public static Instruction InsertOpFunctionEnd(this SpirvBuffer buffer, int position)
    {
        return buffer.Insert(position, [1 << 16 | (int)SDSLOp.OpFunctionEnd]);
    }

    public static Instruction AddOpFunctionCall(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef function, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(function) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFunctionCall, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..function.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFunctionCall(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef function, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(function) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFunctionCall, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..function.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpVariable(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, StorageClass storageclass, IdRef? initializer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass) + buffer.GetWordLength(initializer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpVariable, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan(), ..initializer.AsSpirvSpan()]);
    }

    public static Instruction InsertOpVariable(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, StorageClass storageclass, IdRef? initializer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass) + buffer.GetWordLength(initializer);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpVariable, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan(), ..initializer.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageTexelPointer(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, IdRef sample)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(sample);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageTexelPointer, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..sample.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageTexelPointer(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, IdRef sample)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(sample);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageTexelPointer, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..sample.AsSpirvSpan()]);
    }

    public static Instruction AddOpLoad(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, MemoryAccessMask? memoryaccess)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memoryaccess);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLoad, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan()]);
    }

    public static Instruction InsertOpLoad(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, MemoryAccessMask? memoryaccess)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memoryaccess);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpLoad, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan()]);
    }

    public static Instruction AddOpStore(this SpirvBuffer buffer, IdRef pointer, IdRef objectId, MemoryAccessMask? memoryaccess)
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(objectId) + buffer.GetWordLength(memoryaccess);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpStore, ..pointer.AsSpirvSpan(), ..objectId.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan()]);
    }

    public static Instruction InsertOpStore(this SpirvBuffer buffer, int position, IdRef pointer, IdRef objectId, MemoryAccessMask? memoryaccess)
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(objectId) + buffer.GetWordLength(memoryaccess);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpStore, ..pointer.AsSpirvSpan(), ..objectId.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan()]);
    }

    public static Instruction AddOpCopyMemory(this SpirvBuffer buffer, IdRef target, IdRef source, MemoryAccessMask? memoryaccess, MemoryAccessMask? memoryaccess1)
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(source) + buffer.GetWordLength(memoryaccess) + buffer.GetWordLength(memoryaccess1);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCopyMemory, ..target.AsSpirvSpan(), ..source.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan(), ..memoryaccess1.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCopyMemory(this SpirvBuffer buffer, int position, IdRef target, IdRef source, MemoryAccessMask? memoryaccess, MemoryAccessMask? memoryaccess1)
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(source) + buffer.GetWordLength(memoryaccess) + buffer.GetWordLength(memoryaccess1);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCopyMemory, ..target.AsSpirvSpan(), ..source.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan(), ..memoryaccess1.AsSpirvSpan()]);
    }

    public static Instruction AddOpCopyMemorySized(this SpirvBuffer buffer, IdRef target, IdRef source, IdRef size, MemoryAccessMask? memoryaccess, MemoryAccessMask? memoryaccess1)
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(source) + buffer.GetWordLength(size) + buffer.GetWordLength(memoryaccess) + buffer.GetWordLength(memoryaccess1);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCopyMemorySized, ..target.AsSpirvSpan(), ..source.AsSpirvSpan(), ..size.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan(), ..memoryaccess1.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCopyMemorySized(this SpirvBuffer buffer, int position, IdRef target, IdRef source, IdRef size, MemoryAccessMask? memoryaccess, MemoryAccessMask? memoryaccess1)
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(source) + buffer.GetWordLength(size) + buffer.GetWordLength(memoryaccess) + buffer.GetWordLength(memoryaccess1);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCopyMemorySized, ..target.AsSpirvSpan(), ..source.AsSpirvSpan(), ..size.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan(), ..memoryaccess1.AsSpirvSpan()]);
    }

    public static Instruction AddOpAccessChain(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAccessChain, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAccessChain(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef baseId, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAccessChain, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpInBoundsAccessChain(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpInBoundsAccessChain, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpInBoundsAccessChain(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef baseId, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpInBoundsAccessChain, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpPtrAccessChain(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef element, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(element) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpPtrAccessChain, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..element.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpPtrAccessChain(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef element, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(element) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpPtrAccessChain, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..element.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpArrayLength(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef structure, LiteralInteger arraymember)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(structure) + buffer.GetWordLength(arraymember);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArrayLength, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..structure.AsSpirvSpan(), ..arraymember.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArrayLength(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef structure, LiteralInteger arraymember)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(structure) + buffer.GetWordLength(arraymember);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArrayLength, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..structure.AsSpirvSpan(), ..arraymember.AsSpirvSpan()]);
    }

    public static Instruction AddOpGenericPtrMemSemantics(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGenericPtrMemSemantics, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGenericPtrMemSemantics(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGenericPtrMemSemantics, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction AddOpInBoundsPtrAccessChain(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef element, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(element) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpInBoundsPtrAccessChain, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..element.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpInBoundsPtrAccessChain(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef element, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(element) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpInBoundsPtrAccessChain, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..element.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpDecorate(this SpirvBuffer buffer, IdRef target, Decoration decoration, int? additional1 = null, int? additional2 = null, string? additionalString = null)
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(decoration) + buffer.GetWordLength(additional1) + buffer.GetWordLength(additional2) + buffer.GetWordLength(additionalString);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDecorate, target, ..decoration.AsSpirvSpan(), ..additional1.AsSpirvSpan(), ..additional2.AsSpirvSpan(), ..additionalString.AsSpirvSpan()]);
    }

    public static Instruction InsertOpDecorate(this SpirvBuffer buffer, int position, IdRef target, Decoration decoration, int? additional1 = null, int? additional2 = null, string? additionalString = null)
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(decoration) + buffer.GetWordLength(additional1) + buffer.GetWordLength(additional2) + buffer.GetWordLength(additionalString);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpDecorate, target, ..decoration.AsSpirvSpan(), ..additional1.AsSpirvSpan(), ..additional2.AsSpirvSpan(), ..additionalString.AsSpirvSpan()]);
    }

    public static Instruction AddOpMemberDecorate(this SpirvBuffer buffer, IdRef structureType, LiteralInteger member, Decoration decoration, int? additional1 = null, int? additional2 = null, string? additionalString = null)
    {
        var wordLength = 1 + buffer.GetWordLength(structureType) + buffer.GetWordLength(member) + buffer.GetWordLength(decoration) + buffer.GetWordLength(additional1) + buffer.GetWordLength(additional2) + buffer.GetWordLength(additionalString);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMemberDecorate, ..structureType.AsSpirvSpan(), ..member.AsSpirvSpan(), ..decoration.AsSpirvSpan(), ..additional1.AsSpirvSpan(), ..additional2.AsSpirvSpan(), ..additionalString.AsSpirvSpan()]);
    }

    public static Instruction InsertOpMemberDecorate(this SpirvBuffer buffer, int position, IdRef structureType, LiteralInteger member, Decoration decoration, int? additional1 = null, int? additional2 = null, string? additionalString = null)
    {
        var wordLength = 1 + buffer.GetWordLength(structureType) + buffer.GetWordLength(member) + buffer.GetWordLength(decoration) + buffer.GetWordLength(additional1) + buffer.GetWordLength(additional2) + buffer.GetWordLength(additionalString);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpMemberDecorate, ..structureType.AsSpirvSpan(), ..member.AsSpirvSpan(), ..decoration.AsSpirvSpan(), ..additional1.AsSpirvSpan(), ..additional2.AsSpirvSpan(), ..additionalString.AsSpirvSpan()]);
    }

    public static Instruction AddOpDecorationGroup(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDecorationGroup, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpDecorationGroup(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpDecorationGroup, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupDecorate(this SpirvBuffer buffer, IdRef decorationGroup, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(decorationGroup) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupDecorate, ..decorationGroup.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupDecorate(this SpirvBuffer buffer, int position, IdRef decorationGroup, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(decorationGroup) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupDecorate, ..decorationGroup.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupMemberDecorate(this SpirvBuffer buffer, IdRef decorationGroup, Span<PairIdRefLiteralInteger> values)
    {
        var wordLength = 1 + buffer.GetWordLength(decorationGroup) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupMemberDecorate, ..decorationGroup.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupMemberDecorate(this SpirvBuffer buffer, int position, IdRef decorationGroup, Span<PairIdRefLiteralInteger> values)
    {
        var wordLength = 1 + buffer.GetWordLength(decorationGroup) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupMemberDecorate, ..decorationGroup.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpVectorExtractDynamic(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector, IdRef index)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector) + buffer.GetWordLength(index);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpVectorExtractDynamic, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan(), ..index.AsSpirvSpan()]);
    }

    public static Instruction InsertOpVectorExtractDynamic(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef vector, IdRef index)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector) + buffer.GetWordLength(index);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpVectorExtractDynamic, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan(), ..index.AsSpirvSpan()]);
    }

    public static Instruction AddOpVectorInsertDynamic(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector, IdRef component, IdRef index)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector) + buffer.GetWordLength(component) + buffer.GetWordLength(index);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpVectorInsertDynamic, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan(), ..component.AsSpirvSpan(), ..index.AsSpirvSpan()]);
    }

    public static Instruction InsertOpVectorInsertDynamic(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef vector, IdRef component, IdRef index)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector) + buffer.GetWordLength(component) + buffer.GetWordLength(index);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpVectorInsertDynamic, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan(), ..component.AsSpirvSpan(), ..index.AsSpirvSpan()]);
    }

    public static Instruction AddOpVectorShuffle(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, Span<LiteralInteger> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpVectorShuffle, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpVectorShuffle(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, Span<LiteralInteger> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpVectorShuffle, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpCompositeConstruct(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCompositeConstruct, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCompositeConstruct(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCompositeConstruct, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpCompositeExtract(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef composite, Span<LiteralInteger> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(composite) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCompositeExtract, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..composite.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCompositeExtract(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef composite, Span<LiteralInteger> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(composite) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCompositeExtract, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..composite.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpCompositeInsert(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef objectId, IdRef composite, Span<LiteralInteger> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(objectId) + buffer.GetWordLength(composite) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCompositeInsert, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..objectId.AsSpirvSpan(), ..composite.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCompositeInsert(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef objectId, IdRef composite, Span<LiteralInteger> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(objectId) + buffer.GetWordLength(composite) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCompositeInsert, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..objectId.AsSpirvSpan(), ..composite.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpCopyObject(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCopyObject, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCopyObject(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCopyObject, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpTranspose(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef matrix)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(matrix);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTranspose, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..matrix.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTranspose(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef matrix)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(matrix);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTranspose, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..matrix.AsSpirvSpan()]);
    }

    public static Instruction AddOpSampledImage(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef sampler)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(sampler);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSampledImage, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..sampler.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSampledImage(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef image, IdRef sampler)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(sampler);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSampledImage, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..sampler.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleImplicitLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSampleImplicitLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSampleImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleExplicitLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSampleExplicitLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSampleExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleDrefImplicitLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleDrefImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSampleDrefImplicitLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSampleDrefImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleDrefExplicitLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleDrefExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSampleDrefExplicitLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSampleDrefExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleProjImplicitLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleProjImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSampleProjImplicitLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSampleProjImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleProjExplicitLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleProjExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSampleProjExplicitLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSampleProjExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleProjDrefImplicitLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleProjDrefImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSampleProjDrefImplicitLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSampleProjDrefImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleProjDrefExplicitLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleProjDrefExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSampleProjDrefExplicitLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSampleProjDrefExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageFetch(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageFetch, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageFetch(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageFetch, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageGather(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef component, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(component) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageGather, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..component.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageGather(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef component, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(component) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageGather, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..component.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageDrefGather(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageDrefGather, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageDrefGather(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageDrefGather, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageRead(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageRead, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageRead(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageRead, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageWrite(this SpirvBuffer buffer, IdRef image, IdRef coordinate, IdRef texel, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(texel) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageWrite, ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..texel.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageWrite(this SpirvBuffer buffer, int position, IdRef image, IdRef coordinate, IdRef texel, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(texel) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageWrite, ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..texel.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImage(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImage, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImage(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImage, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageQueryFormat(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageQueryFormat, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageQueryFormat(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef image)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageQueryFormat, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageQueryOrder(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageQueryOrder, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageQueryOrder(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef image)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageQueryOrder, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageQuerySizeLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef levelofDetail)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(levelofDetail);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageQuerySizeLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..levelofDetail.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageQuerySizeLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef image, IdRef levelofDetail)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(levelofDetail);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageQuerySizeLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..levelofDetail.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageQuerySize(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageQuerySize, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageQuerySize(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef image)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageQuerySize, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageQueryLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageQueryLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageQueryLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageQueryLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageQueryLevels(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageQueryLevels, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageQueryLevels(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef image)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageQueryLevels, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageQuerySamples(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageQuerySamples, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageQuerySamples(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef image)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageQuerySamples, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertFToU(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef floatValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(floatValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertFToU, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..floatValue.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConvertFToU(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef floatValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(floatValue);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConvertFToU, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..floatValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertFToS(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef floatValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(floatValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertFToS, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..floatValue.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConvertFToS(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef floatValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(floatValue);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConvertFToS, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..floatValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertSToF(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef signedValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(signedValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertSToF, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..signedValue.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConvertSToF(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef signedValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(signedValue);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConvertSToF, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..signedValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertUToF(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef unsignedValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(unsignedValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertUToF, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..unsignedValue.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConvertUToF(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef unsignedValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(unsignedValue);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConvertUToF, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..unsignedValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpUConvert(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef unsignedValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(unsignedValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUConvert, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..unsignedValue.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUConvert(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef unsignedValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(unsignedValue);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUConvert, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..unsignedValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpSConvert(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef signedValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(signedValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSConvert, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..signedValue.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSConvert(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef signedValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(signedValue);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSConvert, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..signedValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpFConvert(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef floatValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(floatValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFConvert, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..floatValue.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFConvert(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef floatValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(floatValue);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFConvert, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..floatValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpQuantizeToF16(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpQuantizeToF16, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpQuantizeToF16(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpQuantizeToF16, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertPtrToU(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertPtrToU, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConvertPtrToU(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConvertPtrToU, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction AddOpSatConvertSToU(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef signedValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(signedValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSatConvertSToU, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..signedValue.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSatConvertSToU(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef signedValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(signedValue);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSatConvertSToU, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..signedValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpSatConvertUToS(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef unsignedValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(unsignedValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSatConvertUToS, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..unsignedValue.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSatConvertUToS(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef unsignedValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(unsignedValue);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSatConvertUToS, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..unsignedValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertUToPtr(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef integerValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(integerValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertUToPtr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..integerValue.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConvertUToPtr(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef integerValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(integerValue);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConvertUToPtr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..integerValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpPtrCastToGeneric(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpPtrCastToGeneric, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction InsertOpPtrCastToGeneric(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpPtrCastToGeneric, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction AddOpGenericCastToPtr(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGenericCastToPtr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGenericCastToPtr(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGenericCastToPtr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction AddOpGenericCastToPtrExplicit(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, StorageClass storage)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(storage);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGenericCastToPtrExplicit, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..storage.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGenericCastToPtrExplicit(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, StorageClass storage)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(storage);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGenericCastToPtrExplicit, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..storage.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitcast(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitcast, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction InsertOpBitcast(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpBitcast, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpSNegate(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSNegate, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSNegate(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSNegate, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpFNegate(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFNegate, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFNegate(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFNegate, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpIAdd(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpIAdd(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpIAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFAdd(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFAdd(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpISub(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpISub, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpISub(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpISub, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFSub(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFSub, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFSub(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFSub, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpIMul(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIMul, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpIMul(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpIMul, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFMul(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFMul, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFMul(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFMul, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUDiv(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUDiv, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUDiv(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUDiv, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDiv(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDiv, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSDiv(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSDiv, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFDiv(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFDiv, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFDiv(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFDiv, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUMod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUMod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUMod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUMod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpSRem(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSRem, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSRem(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSRem, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpSMod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSMod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSMod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSMod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFRem(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFRem, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFRem(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFRem, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFMod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFMod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFMod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFMod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpVectorTimesScalar(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector, IdRef scalar)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector) + buffer.GetWordLength(scalar);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpVectorTimesScalar, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan(), ..scalar.AsSpirvSpan()]);
    }

    public static Instruction InsertOpVectorTimesScalar(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef vector, IdRef scalar)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector) + buffer.GetWordLength(scalar);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpVectorTimesScalar, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan(), ..scalar.AsSpirvSpan()]);
    }

    public static Instruction AddOpMatrixTimesScalar(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef matrix, IdRef scalar)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(matrix) + buffer.GetWordLength(scalar);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMatrixTimesScalar, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..matrix.AsSpirvSpan(), ..scalar.AsSpirvSpan()]);
    }

    public static Instruction InsertOpMatrixTimesScalar(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef matrix, IdRef scalar)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(matrix) + buffer.GetWordLength(scalar);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpMatrixTimesScalar, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..matrix.AsSpirvSpan(), ..scalar.AsSpirvSpan()]);
    }

    public static Instruction AddOpVectorTimesMatrix(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector, IdRef matrix)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector) + buffer.GetWordLength(matrix);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpVectorTimesMatrix, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan(), ..matrix.AsSpirvSpan()]);
    }

    public static Instruction InsertOpVectorTimesMatrix(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef vector, IdRef matrix)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector) + buffer.GetWordLength(matrix);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpVectorTimesMatrix, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan(), ..matrix.AsSpirvSpan()]);
    }

    public static Instruction AddOpMatrixTimesVector(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef matrix, IdRef vector)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(matrix) + buffer.GetWordLength(vector);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMatrixTimesVector, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..matrix.AsSpirvSpan(), ..vector.AsSpirvSpan()]);
    }

    public static Instruction InsertOpMatrixTimesVector(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef matrix, IdRef vector)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(matrix) + buffer.GetWordLength(vector);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpMatrixTimesVector, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..matrix.AsSpirvSpan(), ..vector.AsSpirvSpan()]);
    }

    public static Instruction AddOpMatrixTimesMatrix(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef leftMatrix, IdRef rightMatrix)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(leftMatrix) + buffer.GetWordLength(rightMatrix);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMatrixTimesMatrix, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..leftMatrix.AsSpirvSpan(), ..rightMatrix.AsSpirvSpan()]);
    }

    public static Instruction InsertOpMatrixTimesMatrix(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef leftMatrix, IdRef rightMatrix)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(leftMatrix) + buffer.GetWordLength(rightMatrix);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpMatrixTimesMatrix, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..leftMatrix.AsSpirvSpan(), ..rightMatrix.AsSpirvSpan()]);
    }

    public static Instruction AddOpOuterProduct(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpOuterProduct, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpOuterProduct(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpOuterProduct, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan()]);
    }

    public static Instruction AddOpDot(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpDot(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpDot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan()]);
    }

    public static Instruction AddOpIAddCarry(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIAddCarry, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpIAddCarry(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpIAddCarry, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpISubBorrow(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpISubBorrow, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpISubBorrow(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpISubBorrow, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUMulExtended(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUMulExtended, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUMulExtended(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUMulExtended, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpSMulExtended(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSMulExtended, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSMulExtended(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSMulExtended, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpAny(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAny, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAny(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef vector)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAny, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan()]);
    }

    public static Instruction AddOpAll(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAll, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAll(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef vector)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAll, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector.AsSpirvSpan()]);
    }

    public static Instruction AddOpIsNan(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIsNan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpIsNan(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpIsNan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpIsInf(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIsInf, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpIsInf(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpIsInf, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpIsFinite(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIsFinite, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpIsFinite(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpIsFinite, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpIsNormal(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIsNormal, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpIsNormal(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpIsNormal, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpSignBitSet(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSignBitSet, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSignBitSet(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSignBitSet, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpLessOrGreater(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef x, IdRef y)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x) + buffer.GetWordLength(y);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLessOrGreater, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan(), ..y.AsSpirvSpan()]);
    }

    public static Instruction InsertOpLessOrGreater(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef x, IdRef y)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x) + buffer.GetWordLength(y);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpLessOrGreater, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan(), ..y.AsSpirvSpan()]);
    }

    public static Instruction AddOpOrdered(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef x, IdRef y)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x) + buffer.GetWordLength(y);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpOrdered, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan(), ..y.AsSpirvSpan()]);
    }

    public static Instruction InsertOpOrdered(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef x, IdRef y)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x) + buffer.GetWordLength(y);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpOrdered, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan(), ..y.AsSpirvSpan()]);
    }

    public static Instruction AddOpUnordered(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef x, IdRef y)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x) + buffer.GetWordLength(y);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUnordered, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan(), ..y.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUnordered(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef x, IdRef y)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(x) + buffer.GetWordLength(y);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUnordered, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..x.AsSpirvSpan(), ..y.AsSpirvSpan()]);
    }

    public static Instruction AddOpLogicalEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLogicalEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpLogicalEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpLogicalEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpLogicalNotEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLogicalNotEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpLogicalNotEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpLogicalNotEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpLogicalOr(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLogicalOr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpLogicalOr(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpLogicalOr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpLogicalAnd(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLogicalAnd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpLogicalAnd(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpLogicalAnd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpLogicalNot(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLogicalNot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction InsertOpLogicalNot(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpLogicalNot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpSelect(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef condition, IdRef object1, IdRef object2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(condition) + buffer.GetWordLength(object1) + buffer.GetWordLength(object2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSelect, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..condition.AsSpirvSpan(), ..object1.AsSpirvSpan(), ..object2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSelect(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef condition, IdRef object1, IdRef object2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(condition) + buffer.GetWordLength(object1) + buffer.GetWordLength(object2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSelect, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..condition.AsSpirvSpan(), ..object1.AsSpirvSpan(), ..object2.AsSpirvSpan()]);
    }

    public static Instruction AddOpIEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpIEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpIEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpINotEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpINotEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpINotEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpINotEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUGreaterThan(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUGreaterThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUGreaterThan(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUGreaterThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpSGreaterThan(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSGreaterThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSGreaterThan(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSGreaterThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUGreaterThanEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUGreaterThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUGreaterThanEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUGreaterThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpSGreaterThanEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSGreaterThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSGreaterThanEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSGreaterThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpULessThan(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpULessThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpULessThan(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpULessThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpSLessThan(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSLessThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSLessThan(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSLessThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpULessThanEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpULessThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpULessThanEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpULessThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpSLessThanEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSLessThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSLessThanEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSLessThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFOrdEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFOrdEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFOrdEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFOrdEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFUnordEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFUnordEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFUnordEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFUnordEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFOrdNotEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFOrdNotEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFOrdNotEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFOrdNotEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFUnordNotEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFUnordNotEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFUnordNotEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFUnordNotEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFOrdLessThan(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFOrdLessThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFOrdLessThan(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFOrdLessThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFUnordLessThan(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFUnordLessThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFUnordLessThan(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFUnordLessThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFOrdGreaterThan(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFOrdGreaterThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFOrdGreaterThan(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFOrdGreaterThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFUnordGreaterThan(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFUnordGreaterThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFUnordGreaterThan(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFUnordGreaterThan, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFOrdLessThanEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFOrdLessThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFOrdLessThanEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFOrdLessThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFUnordLessThanEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFUnordLessThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFUnordLessThanEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFUnordLessThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFOrdGreaterThanEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFOrdGreaterThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFOrdGreaterThanEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFOrdGreaterThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpFUnordGreaterThanEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFUnordGreaterThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFUnordGreaterThanEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFUnordGreaterThanEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpShiftRightLogical(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef shift)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(shift);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpShiftRightLogical, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..shift.AsSpirvSpan()]);
    }

    public static Instruction InsertOpShiftRightLogical(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef shift)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(shift);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpShiftRightLogical, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..shift.AsSpirvSpan()]);
    }

    public static Instruction AddOpShiftRightArithmetic(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef shift)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(shift);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpShiftRightArithmetic, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..shift.AsSpirvSpan()]);
    }

    public static Instruction InsertOpShiftRightArithmetic(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef shift)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(shift);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpShiftRightArithmetic, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..shift.AsSpirvSpan()]);
    }

    public static Instruction AddOpShiftLeftLogical(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef shift)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(shift);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpShiftLeftLogical, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..shift.AsSpirvSpan()]);
    }

    public static Instruction InsertOpShiftLeftLogical(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef shift)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(shift);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpShiftLeftLogical, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..shift.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitwiseOr(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitwiseOr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpBitwiseOr(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpBitwiseOr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitwiseXor(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitwiseXor, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpBitwiseXor(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpBitwiseXor, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitwiseAnd(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitwiseAnd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpBitwiseAnd(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpBitwiseAnd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpNot(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpNot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction InsertOpNot(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpNot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitFieldInsert(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef insert, IdRef offset, IdRef count)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(insert) + buffer.GetWordLength(offset) + buffer.GetWordLength(count);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitFieldInsert, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..insert.AsSpirvSpan(), ..offset.AsSpirvSpan(), ..count.AsSpirvSpan()]);
    }

    public static Instruction InsertOpBitFieldInsert(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef insert, IdRef offset, IdRef count)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(insert) + buffer.GetWordLength(offset) + buffer.GetWordLength(count);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpBitFieldInsert, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..insert.AsSpirvSpan(), ..offset.AsSpirvSpan(), ..count.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitFieldSExtract(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef offset, IdRef count)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(offset) + buffer.GetWordLength(count);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitFieldSExtract, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..offset.AsSpirvSpan(), ..count.AsSpirvSpan()]);
    }

    public static Instruction InsertOpBitFieldSExtract(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef offset, IdRef count)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(offset) + buffer.GetWordLength(count);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpBitFieldSExtract, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..offset.AsSpirvSpan(), ..count.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitFieldUExtract(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef offset, IdRef count)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(offset) + buffer.GetWordLength(count);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitFieldUExtract, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..offset.AsSpirvSpan(), ..count.AsSpirvSpan()]);
    }

    public static Instruction InsertOpBitFieldUExtract(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef offset, IdRef count)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(offset) + buffer.GetWordLength(count);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpBitFieldUExtract, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..offset.AsSpirvSpan(), ..count.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitReverse(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitReverse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpBitReverse(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef baseId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpBitReverse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan()]);
    }

    public static Instruction AddOpBitCount(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBitCount, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpBitCount(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef baseId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpBitCount, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan()]);
    }

    public static Instruction AddOpDPdx(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDPdx, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction InsertOpDPdx(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpDPdx, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpDPdy(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDPdy, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction InsertOpDPdy(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpDPdy, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpFwidth(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFwidth, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFwidth(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFwidth, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpDPdxFine(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDPdxFine, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction InsertOpDPdxFine(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpDPdxFine, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpDPdyFine(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDPdyFine, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction InsertOpDPdyFine(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpDPdyFine, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpFwidthFine(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFwidthFine, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFwidthFine(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFwidthFine, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpDPdxCoarse(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDPdxCoarse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction InsertOpDPdxCoarse(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpDPdxCoarse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpDPdyCoarse(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDPdyCoarse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction InsertOpDPdyCoarse(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpDPdyCoarse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpFwidthCoarse(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFwidthCoarse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFwidthCoarse(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef p)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(p);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFwidthCoarse, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..p.AsSpirvSpan()]);
    }

    public static Instruction AddOpEmitVertex(this SpirvBuffer buffer)
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpEmitVertex]);
    }

    public static Instruction InsertOpEmitVertex(this SpirvBuffer buffer, int position)
    {
        return buffer.Insert(position, [1 << 16 | (int)SDSLOp.OpEmitVertex]);
    }

    public static Instruction AddOpEndPrimitive(this SpirvBuffer buffer)
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpEndPrimitive]);
    }

    public static Instruction InsertOpEndPrimitive(this SpirvBuffer buffer, int position)
    {
        return buffer.Insert(position, [1 << 16 | (int)SDSLOp.OpEndPrimitive]);
    }

    public static Instruction AddOpEmitStreamVertex(this SpirvBuffer buffer, IdRef stream)
    {
        var wordLength = 1 + buffer.GetWordLength(stream);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpEmitStreamVertex, ..stream.AsSpirvSpan()]);
    }

    public static Instruction InsertOpEmitStreamVertex(this SpirvBuffer buffer, int position, IdRef stream)
    {
        var wordLength = 1 + buffer.GetWordLength(stream);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpEmitStreamVertex, ..stream.AsSpirvSpan()]);
    }

    public static Instruction AddOpEndStreamPrimitive(this SpirvBuffer buffer, IdRef stream)
    {
        var wordLength = 1 + buffer.GetWordLength(stream);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpEndStreamPrimitive, ..stream.AsSpirvSpan()]);
    }

    public static Instruction InsertOpEndStreamPrimitive(this SpirvBuffer buffer, int position, IdRef stream)
    {
        var wordLength = 1 + buffer.GetWordLength(stream);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpEndStreamPrimitive, ..stream.AsSpirvSpan()]);
    }

    public static Instruction AddOpControlBarrier(this SpirvBuffer buffer, IdScope execution, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpControlBarrier, ..execution.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction InsertOpControlBarrier(this SpirvBuffer buffer, int position, IdScope execution, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpControlBarrier, ..execution.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpMemoryBarrier(this SpirvBuffer buffer, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMemoryBarrier, ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction InsertOpMemoryBarrier(this SpirvBuffer buffer, int position, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpMemoryBarrier, ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicLoad(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicLoad, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicLoad(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicLoad, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicStore(this SpirvBuffer buffer, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicStore, ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicStore(this SpirvBuffer buffer, int position, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicStore, ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicExchange(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicExchange, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicExchange(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicExchange, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicCompareExchange(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics equal, IdMemorySemantics unequal, IdRef value, IdRef comparator)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(equal) + buffer.GetWordLength(unequal) + buffer.GetWordLength(value) + buffer.GetWordLength(comparator);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicCompareExchange, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..equal.AsSpirvSpan(), ..unequal.AsSpirvSpan(), ..value.AsSpirvSpan(), ..comparator.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicCompareExchange(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics equal, IdMemorySemantics unequal, IdRef value, IdRef comparator)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(equal) + buffer.GetWordLength(unequal) + buffer.GetWordLength(value) + buffer.GetWordLength(comparator);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicCompareExchange, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..equal.AsSpirvSpan(), ..unequal.AsSpirvSpan(), ..value.AsSpirvSpan(), ..comparator.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicCompareExchangeWeak(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics equal, IdMemorySemantics unequal, IdRef value, IdRef comparator)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(equal) + buffer.GetWordLength(unequal) + buffer.GetWordLength(value) + buffer.GetWordLength(comparator);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicCompareExchangeWeak, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..equal.AsSpirvSpan(), ..unequal.AsSpirvSpan(), ..value.AsSpirvSpan(), ..comparator.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicCompareExchangeWeak(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics equal, IdMemorySemantics unequal, IdRef value, IdRef comparator)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(equal) + buffer.GetWordLength(unequal) + buffer.GetWordLength(value) + buffer.GetWordLength(comparator);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicCompareExchangeWeak, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..equal.AsSpirvSpan(), ..unequal.AsSpirvSpan(), ..value.AsSpirvSpan(), ..comparator.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicIIncrement(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicIIncrement, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicIIncrement(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicIIncrement, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicIDecrement(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicIDecrement, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicIDecrement(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicIDecrement, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicIAdd(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicIAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicIAdd(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicIAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicISub(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicISub, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicISub(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicISub, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicSMin(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicSMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicSMin(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicSMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicUMin(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicUMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicUMin(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicUMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicSMax(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicSMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicSMax(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicSMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicUMax(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicUMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicUMax(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicUMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicAnd(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicAnd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicAnd(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicAnd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicOr(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicOr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicOr(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicOr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicXor(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicXor, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicXor(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicXor, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpPhi(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, Span<PairIdRefIdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpPhi, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpPhi(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, Span<PairIdRefIdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpPhi, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpLoopMerge(this SpirvBuffer buffer, IdRef mergeBlock, IdRef continueTarget, LoopControlMask loopcontrol)
    {
        var wordLength = 1 + buffer.GetWordLength(mergeBlock) + buffer.GetWordLength(continueTarget) + buffer.GetWordLength(loopcontrol);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLoopMerge, ..mergeBlock.AsSpirvSpan(), ..continueTarget.AsSpirvSpan(), ..loopcontrol.AsSpirvSpan()]);
    }

    public static Instruction InsertOpLoopMerge(this SpirvBuffer buffer, int position, IdRef mergeBlock, IdRef continueTarget, LoopControlMask loopcontrol)
    {
        var wordLength = 1 + buffer.GetWordLength(mergeBlock) + buffer.GetWordLength(continueTarget) + buffer.GetWordLength(loopcontrol);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpLoopMerge, ..mergeBlock.AsSpirvSpan(), ..continueTarget.AsSpirvSpan(), ..loopcontrol.AsSpirvSpan()]);
    }

    public static Instruction AddOpSelectionMerge(this SpirvBuffer buffer, IdRef mergeBlock, SelectionControlMask selectioncontrol)
    {
        var wordLength = 1 + buffer.GetWordLength(mergeBlock) + buffer.GetWordLength(selectioncontrol);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSelectionMerge, ..mergeBlock.AsSpirvSpan(), ..selectioncontrol.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSelectionMerge(this SpirvBuffer buffer, int position, IdRef mergeBlock, SelectionControlMask selectioncontrol)
    {
        var wordLength = 1 + buffer.GetWordLength(mergeBlock) + buffer.GetWordLength(selectioncontrol);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSelectionMerge, ..mergeBlock.AsSpirvSpan(), ..selectioncontrol.AsSpirvSpan()]);
    }

    public static Instruction AddOpLabel(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLabel, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpLabel(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpLabel, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpBranch(this SpirvBuffer buffer, IdRef targetLabel)
    {
        var wordLength = 1 + buffer.GetWordLength(targetLabel);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBranch, ..targetLabel.AsSpirvSpan()]);
    }

    public static Instruction InsertOpBranch(this SpirvBuffer buffer, int position, IdRef targetLabel)
    {
        var wordLength = 1 + buffer.GetWordLength(targetLabel);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpBranch, ..targetLabel.AsSpirvSpan()]);
    }

    public static Instruction AddOpBranchConditional(this SpirvBuffer buffer, IdRef condition, IdRef trueLabel, IdRef falseLabel, Span<LiteralInteger> values)
    {
        var wordLength = 1 + buffer.GetWordLength(condition) + buffer.GetWordLength(trueLabel) + buffer.GetWordLength(falseLabel) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBranchConditional, ..condition.AsSpirvSpan(), ..trueLabel.AsSpirvSpan(), ..falseLabel.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpBranchConditional(this SpirvBuffer buffer, int position, IdRef condition, IdRef trueLabel, IdRef falseLabel, Span<LiteralInteger> values)
    {
        var wordLength = 1 + buffer.GetWordLength(condition) + buffer.GetWordLength(trueLabel) + buffer.GetWordLength(falseLabel) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpBranchConditional, ..condition.AsSpirvSpan(), ..trueLabel.AsSpirvSpan(), ..falseLabel.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpSwitch(this SpirvBuffer buffer, IdRef selector, IdRef defaultId, Span<PairLiteralIntegerIdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(selector) + buffer.GetWordLength(defaultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSwitch, ..selector.AsSpirvSpan(), ..defaultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSwitch(this SpirvBuffer buffer, int position, IdRef selector, IdRef defaultId, Span<PairLiteralIntegerIdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(selector) + buffer.GetWordLength(defaultId) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSwitch, ..selector.AsSpirvSpan(), ..defaultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpKill(this SpirvBuffer buffer)
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpKill]);
    }

    public static Instruction InsertOpKill(this SpirvBuffer buffer, int position)
    {
        return buffer.Insert(position, [1 << 16 | (int)SDSLOp.OpKill]);
    }

    public static Instruction AddOpReturn(this SpirvBuffer buffer)
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpReturn]);
    }

    public static Instruction InsertOpReturn(this SpirvBuffer buffer, int position)
    {
        return buffer.Insert(position, [1 << 16 | (int)SDSLOp.OpReturn]);
    }

    public static Instruction AddOpReturnValue(this SpirvBuffer buffer, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReturnValue, ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpReturnValue(this SpirvBuffer buffer, int position, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpReturnValue, ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpUnreachable(this SpirvBuffer buffer)
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpUnreachable]);
    }

    public static Instruction InsertOpUnreachable(this SpirvBuffer buffer, int position)
    {
        return buffer.Insert(position, [1 << 16 | (int)SDSLOp.OpUnreachable]);
    }

    public static Instruction AddOpLifetimeStart(this SpirvBuffer buffer, IdRef pointer, LiteralInteger size)
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(size);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLifetimeStart, ..pointer.AsSpirvSpan(), ..size.AsSpirvSpan()]);
    }

    public static Instruction InsertOpLifetimeStart(this SpirvBuffer buffer, int position, IdRef pointer, LiteralInteger size)
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(size);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpLifetimeStart, ..pointer.AsSpirvSpan(), ..size.AsSpirvSpan()]);
    }

    public static Instruction AddOpLifetimeStop(this SpirvBuffer buffer, IdRef pointer, LiteralInteger size)
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(size);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLifetimeStop, ..pointer.AsSpirvSpan(), ..size.AsSpirvSpan()]);
    }

    public static Instruction InsertOpLifetimeStop(this SpirvBuffer buffer, int position, IdRef pointer, LiteralInteger size)
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(size);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpLifetimeStop, ..pointer.AsSpirvSpan(), ..size.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupAsyncCopy(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef destination, IdRef source, IdRef numElements, IdRef stride, IdRef eventId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(destination) + buffer.GetWordLength(source) + buffer.GetWordLength(numElements) + buffer.GetWordLength(stride) + buffer.GetWordLength(eventId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupAsyncCopy, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..destination.AsSpirvSpan(), ..source.AsSpirvSpan(), ..numElements.AsSpirvSpan(), ..stride.AsSpirvSpan(), ..eventId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupAsyncCopy(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef destination, IdRef source, IdRef numElements, IdRef stride, IdRef eventId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(destination) + buffer.GetWordLength(source) + buffer.GetWordLength(numElements) + buffer.GetWordLength(stride) + buffer.GetWordLength(eventId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupAsyncCopy, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..destination.AsSpirvSpan(), ..source.AsSpirvSpan(), ..numElements.AsSpirvSpan(), ..stride.AsSpirvSpan(), ..eventId.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupWaitEvents(this SpirvBuffer buffer, IdScope execution, IdRef numEvents, IdRef eventsList)
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(numEvents) + buffer.GetWordLength(eventsList);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupWaitEvents, ..execution.AsSpirvSpan(), ..numEvents.AsSpirvSpan(), ..eventsList.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupWaitEvents(this SpirvBuffer buffer, int position, IdScope execution, IdRef numEvents, IdRef eventsList)
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(numEvents) + buffer.GetWordLength(eventsList);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupWaitEvents, ..execution.AsSpirvSpan(), ..numEvents.AsSpirvSpan(), ..eventsList.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupAll(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupAll, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupAll(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(predicate);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupAll, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupAny(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupAny, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupAny(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(predicate);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupAny, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupBroadcast(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef localId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(localId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupBroadcast, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..localId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupBroadcast(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef localId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(localId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupBroadcast, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..localId.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupIAdd(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupIAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupIAdd(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupIAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupFAdd(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupFAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupFAdd(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupFAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupFMin(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupFMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupFMin(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupFMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupUMin(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupUMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupUMin(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupUMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupSMin(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupSMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupSMin(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupSMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupFMax(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupFMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupFMax(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupFMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupUMax(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupUMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupUMax(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupUMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupSMax(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupSMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupSMax(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupSMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpReadPipe(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef pointer, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(pointer) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReadPipe, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpReadPipe(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef pointer, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(pointer) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpReadPipe, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpWritePipe(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef pointer, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(pointer) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpWritePipe, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpWritePipe(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef pointer, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(pointer) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpWritePipe, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpReservedReadPipe(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef reserveId, IdRef index, IdRef pointer, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(index) + buffer.GetWordLength(pointer) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReservedReadPipe, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..index.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpReservedReadPipe(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef reserveId, IdRef index, IdRef pointer, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(index) + buffer.GetWordLength(pointer) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpReservedReadPipe, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..index.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpReservedWritePipe(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef reserveId, IdRef index, IdRef pointer, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(index) + buffer.GetWordLength(pointer) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReservedWritePipe, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..index.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpReservedWritePipe(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef reserveId, IdRef index, IdRef pointer, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(index) + buffer.GetWordLength(pointer) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpReservedWritePipe, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..index.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpReserveReadPipePackets(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef numPackets, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(numPackets) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReserveReadPipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..numPackets.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpReserveReadPipePackets(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef numPackets, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(numPackets) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpReserveReadPipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..numPackets.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpReserveWritePipePackets(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef numPackets, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(numPackets) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReserveWritePipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..numPackets.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpReserveWritePipePackets(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef numPackets, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(numPackets) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpReserveWritePipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..numPackets.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpCommitReadPipe(this SpirvBuffer buffer, IdRef pipe, IdRef reserveId, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCommitReadPipe, ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCommitReadPipe(this SpirvBuffer buffer, int position, IdRef pipe, IdRef reserveId, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCommitReadPipe, ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpCommitWritePipe(this SpirvBuffer buffer, IdRef pipe, IdRef reserveId, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCommitWritePipe, ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCommitWritePipe(this SpirvBuffer buffer, int position, IdRef pipe, IdRef reserveId, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCommitWritePipe, ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpIsValidReserveId(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef reserveId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(reserveId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIsValidReserveId, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..reserveId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpIsValidReserveId(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef reserveId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(reserveId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpIsValidReserveId, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..reserveId.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetNumPipePackets(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetNumPipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGetNumPipePackets(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGetNumPipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetMaxPipePackets(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetMaxPipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGetMaxPipePackets(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pipe, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipe) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGetMaxPipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupReserveReadPipePackets(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef pipe, IdRef numPackets, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(pipe) + buffer.GetWordLength(numPackets) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupReserveReadPipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..numPackets.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupReserveReadPipePackets(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef pipe, IdRef numPackets, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(pipe) + buffer.GetWordLength(numPackets) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupReserveReadPipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..numPackets.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupReserveWritePipePackets(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef pipe, IdRef numPackets, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(pipe) + buffer.GetWordLength(numPackets) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupReserveWritePipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..numPackets.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupReserveWritePipePackets(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef pipe, IdRef numPackets, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(pipe) + buffer.GetWordLength(numPackets) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupReserveWritePipePackets, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..numPackets.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupCommitReadPipe(this SpirvBuffer buffer, IdScope execution, IdRef pipe, IdRef reserveId, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupCommitReadPipe, ..execution.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupCommitReadPipe(this SpirvBuffer buffer, int position, IdScope execution, IdRef pipe, IdRef reserveId, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupCommitReadPipe, ..execution.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupCommitWritePipe(this SpirvBuffer buffer, IdScope execution, IdRef pipe, IdRef reserveId, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupCommitWritePipe, ..execution.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupCommitWritePipe(this SpirvBuffer buffer, int position, IdScope execution, IdRef pipe, IdRef reserveId, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(pipe) + buffer.GetWordLength(reserveId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupCommitWritePipe, ..execution.AsSpirvSpan(), ..pipe.AsSpirvSpan(), ..reserveId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpEnqueueMarker(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef queue, IdRef numEvents, IdRef waitEvents, IdRef retEvent)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(queue) + buffer.GetWordLength(numEvents) + buffer.GetWordLength(waitEvents) + buffer.GetWordLength(retEvent);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpEnqueueMarker, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..queue.AsSpirvSpan(), ..numEvents.AsSpirvSpan(), ..waitEvents.AsSpirvSpan(), ..retEvent.AsSpirvSpan()]);
    }

    public static Instruction InsertOpEnqueueMarker(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef queue, IdRef numEvents, IdRef waitEvents, IdRef retEvent)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(queue) + buffer.GetWordLength(numEvents) + buffer.GetWordLength(waitEvents) + buffer.GetWordLength(retEvent);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpEnqueueMarker, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..queue.AsSpirvSpan(), ..numEvents.AsSpirvSpan(), ..waitEvents.AsSpirvSpan(), ..retEvent.AsSpirvSpan()]);
    }

    public static Instruction AddOpEnqueueKernel(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef queue, IdRef flags, IdRef nDRange, IdRef numEvents, IdRef waitEvents, IdRef retEvent, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(queue) + buffer.GetWordLength(flags) + buffer.GetWordLength(nDRange) + buffer.GetWordLength(numEvents) + buffer.GetWordLength(waitEvents) + buffer.GetWordLength(retEvent) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpEnqueueKernel, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..queue.AsSpirvSpan(), ..flags.AsSpirvSpan(), ..nDRange.AsSpirvSpan(), ..numEvents.AsSpirvSpan(), ..waitEvents.AsSpirvSpan(), ..retEvent.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpEnqueueKernel(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef queue, IdRef flags, IdRef nDRange, IdRef numEvents, IdRef waitEvents, IdRef retEvent, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(queue) + buffer.GetWordLength(flags) + buffer.GetWordLength(nDRange) + buffer.GetWordLength(numEvents) + buffer.GetWordLength(waitEvents) + buffer.GetWordLength(retEvent) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpEnqueueKernel, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..queue.AsSpirvSpan(), ..flags.AsSpirvSpan(), ..nDRange.AsSpirvSpan(), ..numEvents.AsSpirvSpan(), ..waitEvents.AsSpirvSpan(), ..retEvent.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetKernelNDrangeSubGroupCount(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef nDRange, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(nDRange) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetKernelNDrangeSubGroupCount, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..nDRange.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGetKernelNDrangeSubGroupCount(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef nDRange, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(nDRange) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGetKernelNDrangeSubGroupCount, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..nDRange.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetKernelNDrangeMaxSubGroupSize(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef nDRange, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(nDRange) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetKernelNDrangeMaxSubGroupSize, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..nDRange.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGetKernelNDrangeMaxSubGroupSize(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef nDRange, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(nDRange) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGetKernelNDrangeMaxSubGroupSize, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..nDRange.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetKernelWorkGroupSize(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetKernelWorkGroupSize, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGetKernelWorkGroupSize(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGetKernelWorkGroupSize, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetKernelPreferredWorkGroupSizeMultiple(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetKernelPreferredWorkGroupSizeMultiple, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGetKernelPreferredWorkGroupSizeMultiple(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGetKernelPreferredWorkGroupSizeMultiple, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction AddOpRetainEvent(this SpirvBuffer buffer, IdRef eventId)
    {
        var wordLength = 1 + buffer.GetWordLength(eventId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRetainEvent, ..eventId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRetainEvent(this SpirvBuffer buffer, int position, IdRef eventId)
    {
        var wordLength = 1 + buffer.GetWordLength(eventId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRetainEvent, ..eventId.AsSpirvSpan()]);
    }

    public static Instruction AddOpReleaseEvent(this SpirvBuffer buffer, IdRef eventId)
    {
        var wordLength = 1 + buffer.GetWordLength(eventId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReleaseEvent, ..eventId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpReleaseEvent(this SpirvBuffer buffer, int position, IdRef eventId)
    {
        var wordLength = 1 + buffer.GetWordLength(eventId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpReleaseEvent, ..eventId.AsSpirvSpan()]);
    }

    public static Instruction AddOpCreateUserEvent(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCreateUserEvent, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCreateUserEvent(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCreateUserEvent, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpIsValidEvent(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef eventId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(eventId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIsValidEvent, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..eventId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpIsValidEvent(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef eventId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(eventId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpIsValidEvent, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..eventId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSetUserEventStatus(this SpirvBuffer buffer, IdRef eventId, IdRef status)
    {
        var wordLength = 1 + buffer.GetWordLength(eventId) + buffer.GetWordLength(status);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSetUserEventStatus, ..eventId.AsSpirvSpan(), ..status.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSetUserEventStatus(this SpirvBuffer buffer, int position, IdRef eventId, IdRef status)
    {
        var wordLength = 1 + buffer.GetWordLength(eventId) + buffer.GetWordLength(status);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSetUserEventStatus, ..eventId.AsSpirvSpan(), ..status.AsSpirvSpan()]);
    }

    public static Instruction AddOpCaptureEventProfilingInfo(this SpirvBuffer buffer, IdRef eventId, IdRef profilingInfo, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(eventId) + buffer.GetWordLength(profilingInfo) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCaptureEventProfilingInfo, ..eventId.AsSpirvSpan(), ..profilingInfo.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCaptureEventProfilingInfo(this SpirvBuffer buffer, int position, IdRef eventId, IdRef profilingInfo, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(eventId) + buffer.GetWordLength(profilingInfo) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCaptureEventProfilingInfo, ..eventId.AsSpirvSpan(), ..profilingInfo.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetDefaultQueue(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetDefaultQueue, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGetDefaultQueue(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGetDefaultQueue, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpBuildNDRange(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef globalWorkSize, IdRef localWorkSize, IdRef globalWorkOffset)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(globalWorkSize) + buffer.GetWordLength(localWorkSize) + buffer.GetWordLength(globalWorkOffset);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpBuildNDRange, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..globalWorkSize.AsSpirvSpan(), ..localWorkSize.AsSpirvSpan(), ..globalWorkOffset.AsSpirvSpan()]);
    }

    public static Instruction InsertOpBuildNDRange(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef globalWorkSize, IdRef localWorkSize, IdRef globalWorkOffset)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(globalWorkSize) + buffer.GetWordLength(localWorkSize) + buffer.GetWordLength(globalWorkOffset);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpBuildNDRange, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..globalWorkSize.AsSpirvSpan(), ..localWorkSize.AsSpirvSpan(), ..globalWorkOffset.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseSampleImplicitLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseSampleImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSparseSampleImplicitLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSparseSampleImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseSampleExplicitLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseSampleExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSparseSampleExplicitLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSparseSampleExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseSampleDrefImplicitLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseSampleDrefImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSparseSampleDrefImplicitLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSparseSampleDrefImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseSampleDrefExplicitLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseSampleDrefExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSparseSampleDrefExplicitLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSparseSampleDrefExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseSampleProjImplicitLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseSampleProjImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSparseSampleProjImplicitLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSparseSampleProjImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseSampleProjExplicitLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseSampleProjExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSparseSampleProjExplicitLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, ImageOperandsMask imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSparseSampleProjExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseSampleProjDrefImplicitLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseSampleProjDrefImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSparseSampleProjDrefImplicitLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSparseSampleProjDrefImplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseSampleProjDrefExplicitLod(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseSampleProjDrefExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSparseSampleProjDrefExplicitLod(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSparseSampleProjDrefExplicitLod, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseFetch(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseFetch, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSparseFetch(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSparseFetch, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseGather(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef component, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(component) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseGather, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..component.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSparseGather(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef component, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(component) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSparseGather, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..component.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseDrefGather(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseDrefGather, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSparseDrefGather(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef dref, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(dref) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSparseDrefGather, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..dref.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseTexelsResident(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef residentCode)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(residentCode);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseTexelsResident, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..residentCode.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSparseTexelsResident(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef residentCode)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(residentCode);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSparseTexelsResident, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..residentCode.AsSpirvSpan()]);
    }

    public static Instruction AddOpNoLine(this SpirvBuffer buffer)
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpNoLine]);
    }

    public static Instruction InsertOpNoLine(this SpirvBuffer buffer, int position)
    {
        return buffer.Insert(position, [1 << 16 | (int)SDSLOp.OpNoLine]);
    }

    public static Instruction AddOpAtomicFlagTestAndSet(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicFlagTestAndSet, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicFlagTestAndSet(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicFlagTestAndSet, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicFlagClear(this SpirvBuffer buffer, IdRef pointer, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicFlagClear, ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicFlagClear(this SpirvBuffer buffer, int position, IdRef pointer, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicFlagClear, ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSparseRead(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSparseRead, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSparseRead(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSparseRead, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpSizeOf(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSizeOf, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSizeOf(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSizeOf, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypePipeStorage(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypePipeStorage, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypePipeStorage(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypePipeStorage, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantPipeStorage(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, LiteralInteger packetSize, LiteralInteger packetAlignment, LiteralInteger capacity)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment) + buffer.GetWordLength(capacity);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantPipeStorage, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan(), ..capacity.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConstantPipeStorage(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, LiteralInteger packetSize, LiteralInteger packetAlignment, LiteralInteger capacity)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment) + buffer.GetWordLength(capacity);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConstantPipeStorage, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan(), ..capacity.AsSpirvSpan()]);
    }

    public static Instruction AddOpCreatePipeFromPipeStorage(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pipeStorage)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipeStorage);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCreatePipeFromPipeStorage, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipeStorage.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCreatePipeFromPipeStorage(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pipeStorage)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pipeStorage);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCreatePipeFromPipeStorage, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pipeStorage.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetKernelLocalSizeForSubgroupCount(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef subgroupCount, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(subgroupCount) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetKernelLocalSizeForSubgroupCount, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..subgroupCount.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGetKernelLocalSizeForSubgroupCount(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef subgroupCount, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(subgroupCount) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGetKernelLocalSizeForSubgroupCount, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..subgroupCount.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction AddOpGetKernelMaxNumSubgroups(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGetKernelMaxNumSubgroups, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGetKernelMaxNumSubgroups(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef invoke, IdRef param, IdRef paramSize, IdRef paramAlign)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(invoke) + buffer.GetWordLength(param) + buffer.GetWordLength(paramSize) + buffer.GetWordLength(paramAlign);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGetKernelMaxNumSubgroups, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..invoke.AsSpirvSpan(), ..param.AsSpirvSpan(), ..paramSize.AsSpirvSpan(), ..paramAlign.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeNamedBarrier(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeNamedBarrier, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeNamedBarrier(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeNamedBarrier, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpNamedBarrierInitialize(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef subgroupCount)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(subgroupCount);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpNamedBarrierInitialize, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..subgroupCount.AsSpirvSpan()]);
    }

    public static Instruction InsertOpNamedBarrierInitialize(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef subgroupCount)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(subgroupCount);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpNamedBarrierInitialize, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..subgroupCount.AsSpirvSpan()]);
    }

    public static Instruction AddOpMemoryNamedBarrier(this SpirvBuffer buffer, IdRef namedBarrier, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(namedBarrier) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMemoryNamedBarrier, ..namedBarrier.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction InsertOpMemoryNamedBarrier(this SpirvBuffer buffer, int position, IdRef namedBarrier, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(namedBarrier) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpMemoryNamedBarrier, ..namedBarrier.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpModuleProcessed(this SpirvBuffer buffer, LiteralString process)
    {
        var wordLength = 1 + buffer.GetWordLength(process);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpModuleProcessed, ..process.AsSpirvSpan()]);
    }

    public static Instruction InsertOpModuleProcessed(this SpirvBuffer buffer, int position, LiteralString process)
    {
        var wordLength = 1 + buffer.GetWordLength(process);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpModuleProcessed, ..process.AsSpirvSpan()]);
    }

    public static Instruction AddOpExecutionModeId(this SpirvBuffer buffer, IdRef entryPoint, ExecutionMode mode)
    {
        var wordLength = 1 + buffer.GetWordLength(entryPoint) + buffer.GetWordLength(mode);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExecutionModeId, ..entryPoint.AsSpirvSpan(), ..mode.AsSpirvSpan()]);
    }

    public static Instruction InsertOpExecutionModeId(this SpirvBuffer buffer, int position, IdRef entryPoint, ExecutionMode mode)
    {
        var wordLength = 1 + buffer.GetWordLength(entryPoint) + buffer.GetWordLength(mode);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpExecutionModeId, ..entryPoint.AsSpirvSpan(), ..mode.AsSpirvSpan()]);
    }

    public static Instruction AddOpDecorateId(this SpirvBuffer buffer, IdRef target, Decoration decoration, int? additional1 = null, int? additional2 = null, string? additionalString = null)
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(decoration) + buffer.GetWordLength(additional1) + buffer.GetWordLength(additional2) + buffer.GetWordLength(additionalString);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDecorate, target, ..decoration.AsSpirvSpan(), ..additional1.AsSpirvSpan(), ..additional2.AsSpirvSpan(), ..additionalString.AsSpirvSpan()]);
    }

    public static Instruction InsertOpDecorateId(this SpirvBuffer buffer, int position, IdRef target, Decoration decoration, int? additional1 = null, int? additional2 = null, string? additionalString = null)
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(decoration) + buffer.GetWordLength(additional1) + buffer.GetWordLength(additional2) + buffer.GetWordLength(additionalString);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpDecorate, target, ..decoration.AsSpirvSpan(), ..additional1.AsSpirvSpan(), ..additional2.AsSpirvSpan(), ..additionalString.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformElect(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformElect, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformElect(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformElect, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformAll(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformAll, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformAll(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(predicate);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformAll, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformAny(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformAny, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformAny(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(predicate);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformAny, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformAllEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformAllEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformAllEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformAllEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBroadcast(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef id)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(id);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBroadcast, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..id.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformBroadcast(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef id)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(id);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBroadcast, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..id.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBroadcastFirst(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBroadcastFirst, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformBroadcastFirst(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBroadcastFirst, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBallot(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBallot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformBallot(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(predicate);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBallot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformInverseBallot(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformInverseBallot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformInverseBallot(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformInverseBallot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBallotBitExtract(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef index)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(index);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBallotBitExtract, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..index.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformBallotBitExtract(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef index)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(index);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBallotBitExtract, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..index.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBallotBitCount(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBallotBitCount, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformBallotBitCount(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBallotBitCount, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBallotFindLSB(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBallotFindLSB, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformBallotFindLSB(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBallotFindLSB, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBallotFindMSB(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBallotFindMSB, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformBallotFindMSB(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBallotFindMSB, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformShuffle(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef id)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(id);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformShuffle, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..id.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformShuffle(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef id)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(id);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformShuffle, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..id.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformShuffleXor(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef mask)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(mask);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformShuffleXor, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..mask.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformShuffleXor(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef mask)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(mask);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformShuffleXor, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..mask.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformShuffleUp(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef delta)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(delta);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformShuffleUp, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..delta.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformShuffleUp(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef delta)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(delta);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformShuffleUp, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..delta.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformShuffleDown(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef delta)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(delta);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformShuffleDown, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..delta.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformShuffleDown(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef delta)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(delta);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformShuffleDown, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..delta.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformIAdd(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformIAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformIAdd(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformIAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformFAdd(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformFAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformFAdd(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformFAdd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformIMul(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformIMul, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformIMul(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformIMul, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformFMul(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformFMul, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformFMul(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformFMul, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformSMin(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformSMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformSMin(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformSMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformUMin(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformUMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformUMin(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformUMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformFMin(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformFMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformFMin(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformFMin, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformSMax(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformSMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformSMax(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformSMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformUMax(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformUMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformUMax(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformUMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformFMax(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformFMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformFMax(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformFMax, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBitwiseAnd(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBitwiseAnd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformBitwiseAnd(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBitwiseAnd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBitwiseOr(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBitwiseOr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformBitwiseOr(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBitwiseOr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformBitwiseXor(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBitwiseXor, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformBitwiseXor(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformBitwiseXor, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformLogicalAnd(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformLogicalAnd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformLogicalAnd(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformLogicalAnd, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformLogicalOr(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformLogicalOr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformLogicalOr(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformLogicalOr, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformLogicalXor(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformLogicalXor, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformLogicalXor(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef value, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(value) + buffer.GetWordLength(clusterSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformLogicalXor, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..value.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformQuadBroadcast(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef index)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(index);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformQuadBroadcast, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..index.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformQuadBroadcast(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef index)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(index);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformQuadBroadcast, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..index.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformQuadSwap(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef direction)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(direction);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformQuadSwap, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..direction.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformQuadSwap(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef direction)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(direction);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformQuadSwap, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..direction.AsSpirvSpan()]);
    }

    public static Instruction AddOpCopyLogical(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCopyLogical, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCopyLogical(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCopyLogical, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpPtrEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpPtrEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpPtrEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpPtrEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpPtrNotEqual(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpPtrNotEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpPtrNotEqual(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpPtrNotEqual, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpPtrDiff(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpPtrDiff, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpPtrDiff(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpPtrDiff, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpColorAttachmentReadEXT(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef attachment, IdRef? sample)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(attachment) + buffer.GetWordLength(sample);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpColorAttachmentReadEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..attachment.AsSpirvSpan(), ..sample.AsSpirvSpan()]);
    }

    public static Instruction InsertOpColorAttachmentReadEXT(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef attachment, IdRef? sample)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(attachment) + buffer.GetWordLength(sample);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpColorAttachmentReadEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..attachment.AsSpirvSpan(), ..sample.AsSpirvSpan()]);
    }

    public static Instruction AddOpDepthAttachmentReadEXT(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef? sample)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sample);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDepthAttachmentReadEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sample.AsSpirvSpan()]);
    }

    public static Instruction InsertOpDepthAttachmentReadEXT(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef? sample)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sample);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpDepthAttachmentReadEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sample.AsSpirvSpan()]);
    }

    public static Instruction AddOpStencilAttachmentReadEXT(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef? sample)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sample);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpStencilAttachmentReadEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sample.AsSpirvSpan()]);
    }

    public static Instruction InsertOpStencilAttachmentReadEXT(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef? sample)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sample);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpStencilAttachmentReadEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sample.AsSpirvSpan()]);
    }

    public static Instruction AddOpTerminateInvocation(this SpirvBuffer buffer)
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpTerminateInvocation]);
    }

    public static Instruction InsertOpTerminateInvocation(this SpirvBuffer buffer, int position)
    {
        return buffer.Insert(position, [1 << 16 | (int)SDSLOp.OpTerminateInvocation]);
    }

    public static Instruction AddOpTypeUntypedPointerKHR(this SpirvBuffer buffer, IdResult resultId, StorageClass storageclass)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeUntypedPointerKHR, ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeUntypedPointerKHR(this SpirvBuffer buffer, int position, IdResult resultId, StorageClass storageclass)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeUntypedPointerKHR, ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan()]);
    }

    public static Instruction AddOpUntypedVariableKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, StorageClass storageclass, IdRef? dataType, IdRef? initializer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass) + buffer.GetWordLength(dataType) + buffer.GetWordLength(initializer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUntypedVariableKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan(), ..dataType.AsSpirvSpan(), ..initializer.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUntypedVariableKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, StorageClass storageclass, IdRef? dataType, IdRef? initializer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass) + buffer.GetWordLength(dataType) + buffer.GetWordLength(initializer);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUntypedVariableKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan(), ..dataType.AsSpirvSpan(), ..initializer.AsSpirvSpan()]);
    }

    public static Instruction AddOpUntypedAccessChainKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseType, IdRef baseId, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseType) + buffer.GetWordLength(baseId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUntypedAccessChainKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseType.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUntypedAccessChainKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef baseType, IdRef baseId, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseType) + buffer.GetWordLength(baseId) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUntypedAccessChainKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseType.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpUntypedInBoundsAccessChainKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseType, IdRef baseId, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseType) + buffer.GetWordLength(baseId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUntypedInBoundsAccessChainKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseType.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUntypedInBoundsAccessChainKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef baseType, IdRef baseId, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseType) + buffer.GetWordLength(baseId) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUntypedInBoundsAccessChainKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseType.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupBallotKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupBallotKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupBallotKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupBallotKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupFirstInvocationKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupFirstInvocationKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupFirstInvocationKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupFirstInvocationKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpUntypedPtrAccessChainKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseType, IdRef baseId, IdRef element, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseType) + buffer.GetWordLength(baseId) + buffer.GetWordLength(element) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUntypedPtrAccessChainKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseType.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..element.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUntypedPtrAccessChainKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef baseType, IdRef baseId, IdRef element, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseType) + buffer.GetWordLength(baseId) + buffer.GetWordLength(element) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUntypedPtrAccessChainKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseType.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..element.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpUntypedInBoundsPtrAccessChainKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseType, IdRef baseId, IdRef element, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseType) + buffer.GetWordLength(baseId) + buffer.GetWordLength(element) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUntypedInBoundsPtrAccessChainKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseType.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..element.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUntypedInBoundsPtrAccessChainKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef baseType, IdRef baseId, IdRef element, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseType) + buffer.GetWordLength(baseId) + buffer.GetWordLength(element) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUntypedInBoundsPtrAccessChainKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseType.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..element.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpUntypedArrayLengthKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef structure, IdRef pointer, LiteralInteger arraymember)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(structure) + buffer.GetWordLength(pointer) + buffer.GetWordLength(arraymember);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUntypedArrayLengthKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..structure.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..arraymember.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUntypedArrayLengthKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef structure, IdRef pointer, LiteralInteger arraymember)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(structure) + buffer.GetWordLength(pointer) + buffer.GetWordLength(arraymember);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUntypedArrayLengthKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..structure.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..arraymember.AsSpirvSpan()]);
    }

    public static Instruction AddOpUntypedPrefetchKHR(this SpirvBuffer buffer, IdRef pointerType, IdRef numBytes, IdRef? rW, IdRef? locality, IdRef? cacheType)
    {
        var wordLength = 1 + buffer.GetWordLength(pointerType) + buffer.GetWordLength(numBytes) + buffer.GetWordLength(rW) + buffer.GetWordLength(locality) + buffer.GetWordLength(cacheType);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUntypedPrefetchKHR, ..pointerType.AsSpirvSpan(), ..numBytes.AsSpirvSpan(), ..rW.AsSpirvSpan(), ..locality.AsSpirvSpan(), ..cacheType.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUntypedPrefetchKHR(this SpirvBuffer buffer, int position, IdRef pointerType, IdRef numBytes, IdRef? rW, IdRef? locality, IdRef? cacheType)
    {
        var wordLength = 1 + buffer.GetWordLength(pointerType) + buffer.GetWordLength(numBytes) + buffer.GetWordLength(rW) + buffer.GetWordLength(locality) + buffer.GetWordLength(cacheType);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUntypedPrefetchKHR, ..pointerType.AsSpirvSpan(), ..numBytes.AsSpirvSpan(), ..rW.AsSpirvSpan(), ..locality.AsSpirvSpan(), ..cacheType.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAllKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAllKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAllKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAllKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAnyKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAnyKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAnyKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAnyKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAllEqualKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAllEqualKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAllEqualKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAllEqualKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformRotateKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef delta, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(delta) + buffer.GetWordLength(clusterSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformRotateKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..delta.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformRotateKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, IdRef value, IdRef delta, IdRef? clusterSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(value) + buffer.GetWordLength(delta) + buffer.GetWordLength(clusterSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformRotateKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..value.AsSpirvSpan(), ..delta.AsSpirvSpan(), ..clusterSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupReadInvocationKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef value, IdRef index)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value) + buffer.GetWordLength(index);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupReadInvocationKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan(), ..index.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupReadInvocationKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef value, IdRef index)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value) + buffer.GetWordLength(index);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupReadInvocationKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan(), ..index.AsSpirvSpan()]);
    }

    public static Instruction AddOpExtInstWithForwardRefsKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef set, LiteralInteger instruction, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(set) + buffer.GetWordLength(instruction) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExtInstWithForwardRefsKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..set.AsSpirvSpan(), ..instruction.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpExtInstWithForwardRefsKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef set, LiteralInteger instruction, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(set) + buffer.GetWordLength(instruction) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpExtInstWithForwardRefsKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..set.AsSpirvSpan(), ..instruction.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpTraceRayKHR(this SpirvBuffer buffer, IdRef accel, IdRef rayFlags, IdRef cullMask, IdRef sBTOffset, IdRef sBTStride, IdRef missIndex, IdRef rayOrigin, IdRef rayTmin, IdRef rayDirection, IdRef rayTmax, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(accel) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullMask) + buffer.GetWordLength(sBTOffset) + buffer.GetWordLength(sBTStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(rayOrigin) + buffer.GetWordLength(rayTmin) + buffer.GetWordLength(rayDirection) + buffer.GetWordLength(rayTmax) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTraceRayKHR, ..accel.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullMask.AsSpirvSpan(), ..sBTOffset.AsSpirvSpan(), ..sBTStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..rayOrigin.AsSpirvSpan(), ..rayTmin.AsSpirvSpan(), ..rayDirection.AsSpirvSpan(), ..rayTmax.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTraceRayKHR(this SpirvBuffer buffer, int position, IdRef accel, IdRef rayFlags, IdRef cullMask, IdRef sBTOffset, IdRef sBTStride, IdRef missIndex, IdRef rayOrigin, IdRef rayTmin, IdRef rayDirection, IdRef rayTmax, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(accel) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullMask) + buffer.GetWordLength(sBTOffset) + buffer.GetWordLength(sBTStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(rayOrigin) + buffer.GetWordLength(rayTmin) + buffer.GetWordLength(rayDirection) + buffer.GetWordLength(rayTmax) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTraceRayKHR, ..accel.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullMask.AsSpirvSpan(), ..sBTOffset.AsSpirvSpan(), ..sBTStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..rayOrigin.AsSpirvSpan(), ..rayTmin.AsSpirvSpan(), ..rayDirection.AsSpirvSpan(), ..rayTmax.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpExecuteCallableKHR(this SpirvBuffer buffer, IdRef sBTIndex, IdRef callableData)
    {
        var wordLength = 1 + buffer.GetWordLength(sBTIndex) + buffer.GetWordLength(callableData);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExecuteCallableKHR, ..sBTIndex.AsSpirvSpan(), ..callableData.AsSpirvSpan()]);
    }

    public static Instruction InsertOpExecuteCallableKHR(this SpirvBuffer buffer, int position, IdRef sBTIndex, IdRef callableData)
    {
        var wordLength = 1 + buffer.GetWordLength(sBTIndex) + buffer.GetWordLength(callableData);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpExecuteCallableKHR, ..sBTIndex.AsSpirvSpan(), ..callableData.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertUToAccelerationStructureKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef accel)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(accel);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertUToAccelerationStructureKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..accel.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConvertUToAccelerationStructureKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef accel)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(accel);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConvertUToAccelerationStructureKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..accel.AsSpirvSpan()]);
    }

    public static Instruction AddOpIgnoreIntersectionKHR(this SpirvBuffer buffer)
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpIgnoreIntersectionKHR]);
    }

    public static Instruction InsertOpIgnoreIntersectionKHR(this SpirvBuffer buffer, int position)
    {
        return buffer.Insert(position, [1 << 16 | (int)SDSLOp.OpIgnoreIntersectionKHR]);
    }

    public static Instruction AddOpTerminateRayKHR(this SpirvBuffer buffer)
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpTerminateRayKHR]);
    }

    public static Instruction InsertOpTerminateRayKHR(this SpirvBuffer buffer, int position)
    {
        return buffer.Insert(position, [1 << 16 | (int)SDSLOp.OpTerminateRayKHR]);
    }

    public static Instruction AddOpSDot(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, PackedVectorFormat? packedVectorFormat)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSDot(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, PackedVectorFormat? packedVectorFormat)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSDot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpUDot(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, PackedVectorFormat? packedVectorFormat)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUDot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUDot(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, PackedVectorFormat? packedVectorFormat)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUDot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpSUDot(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, PackedVectorFormat? packedVectorFormat)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSUDot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSUDot(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, PackedVectorFormat? packedVectorFormat)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSUDot, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDotAccSat(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, IdRef accumulator, PackedVectorFormat? packedVectorFormat)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(accumulator) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDotAccSat, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..accumulator.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSDotAccSat(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, IdRef accumulator, PackedVectorFormat? packedVectorFormat)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(accumulator) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSDotAccSat, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..accumulator.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpUDotAccSat(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, IdRef accumulator, PackedVectorFormat? packedVectorFormat)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(accumulator) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUDotAccSat, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..accumulator.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUDotAccSat(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, IdRef accumulator, PackedVectorFormat? packedVectorFormat)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(accumulator) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUDotAccSat, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..accumulator.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpSUDotAccSat(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, IdRef accumulator, PackedVectorFormat? packedVectorFormat)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(accumulator) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSUDotAccSat, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..accumulator.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSUDotAccSat(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef vector1, IdRef vector2, IdRef accumulator, PackedVectorFormat? packedVectorFormat)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(vector1) + buffer.GetWordLength(vector2) + buffer.GetWordLength(accumulator) + buffer.GetWordLength(packedVectorFormat);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSUDotAccSat, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..vector1.AsSpirvSpan(), ..vector2.AsSpirvSpan(), ..accumulator.AsSpirvSpan(), ..packedVectorFormat.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeCooperativeMatrixKHR(this SpirvBuffer buffer, IdResult resultId, IdRef componentType, IdScope scope, IdRef rows, IdRef columns, IdRef use)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(componentType) + buffer.GetWordLength(scope) + buffer.GetWordLength(rows) + buffer.GetWordLength(columns) + buffer.GetWordLength(use);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeCooperativeMatrixKHR, ..resultId.AsSpirvSpan(), ..componentType.AsSpirvSpan(), ..scope.AsSpirvSpan(), ..rows.AsSpirvSpan(), ..columns.AsSpirvSpan(), ..use.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeCooperativeMatrixKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdRef componentType, IdScope scope, IdRef rows, IdRef columns, IdRef use)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(componentType) + buffer.GetWordLength(scope) + buffer.GetWordLength(rows) + buffer.GetWordLength(columns) + buffer.GetWordLength(use);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeCooperativeMatrixKHR, ..resultId.AsSpirvSpan(), ..componentType.AsSpirvSpan(), ..scope.AsSpirvSpan(), ..rows.AsSpirvSpan(), ..columns.AsSpirvSpan(), ..use.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixLoadKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdRef memoryLayout, IdRef? stride, MemoryAccessMask? memoryOperand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memoryLayout) + buffer.GetWordLength(stride) + buffer.GetWordLength(memoryOperand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixLoadKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memoryLayout.AsSpirvSpan(), ..stride.AsSpirvSpan(), ..memoryOperand.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCooperativeMatrixLoadKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdRef memoryLayout, IdRef? stride, MemoryAccessMask? memoryOperand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memoryLayout) + buffer.GetWordLength(stride) + buffer.GetWordLength(memoryOperand);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixLoadKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memoryLayout.AsSpirvSpan(), ..stride.AsSpirvSpan(), ..memoryOperand.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixStoreKHR(this SpirvBuffer buffer, IdRef pointer, IdRef objectId, IdRef memoryLayout, IdRef? stride, MemoryAccessMask? memoryOperand)
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(objectId) + buffer.GetWordLength(memoryLayout) + buffer.GetWordLength(stride) + buffer.GetWordLength(memoryOperand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixStoreKHR, ..pointer.AsSpirvSpan(), ..objectId.AsSpirvSpan(), ..memoryLayout.AsSpirvSpan(), ..stride.AsSpirvSpan(), ..memoryOperand.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCooperativeMatrixStoreKHR(this SpirvBuffer buffer, int position, IdRef pointer, IdRef objectId, IdRef memoryLayout, IdRef? stride, MemoryAccessMask? memoryOperand)
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(objectId) + buffer.GetWordLength(memoryLayout) + buffer.GetWordLength(stride) + buffer.GetWordLength(memoryOperand);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixStoreKHR, ..pointer.AsSpirvSpan(), ..objectId.AsSpirvSpan(), ..memoryLayout.AsSpirvSpan(), ..stride.AsSpirvSpan(), ..memoryOperand.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixMulAddKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, IdRef b, IdRef c, CooperativeMatrixOperandsMask? cooperativeMatrixOperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(b) + buffer.GetWordLength(c) + buffer.GetWordLength(cooperativeMatrixOperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixMulAddKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..b.AsSpirvSpan(), ..c.AsSpirvSpan(), ..cooperativeMatrixOperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCooperativeMatrixMulAddKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, IdRef b, IdRef c, CooperativeMatrixOperandsMask? cooperativeMatrixOperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(b) + buffer.GetWordLength(c) + buffer.GetWordLength(cooperativeMatrixOperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixMulAddKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..b.AsSpirvSpan(), ..c.AsSpirvSpan(), ..cooperativeMatrixOperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixLengthKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef type)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(type);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixLengthKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..type.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCooperativeMatrixLengthKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef type)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(type);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixLengthKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..type.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantCompositeReplicateEXT(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantCompositeReplicateEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConstantCompositeReplicateEXT(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConstantCompositeReplicateEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpSpecConstantCompositeReplicateEXT(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSpecConstantCompositeReplicateEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSpecConstantCompositeReplicateEXT(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSpecConstantCompositeReplicateEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpCompositeConstructReplicateEXT(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCompositeConstructReplicateEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCompositeConstructReplicateEXT(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCompositeConstructReplicateEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeRayQueryKHR(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeRayQueryKHR, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeRayQueryKHR(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeRayQueryKHR, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryInitializeKHR(this SpirvBuffer buffer, IdRef rayQuery, IdRef accel, IdRef rayFlags, IdRef cullMask, IdRef rayOrigin, IdRef rayTMin, IdRef rayDirection, IdRef rayTMax)
    {
        var wordLength = 1 + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(accel) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullMask) + buffer.GetWordLength(rayOrigin) + buffer.GetWordLength(rayTMin) + buffer.GetWordLength(rayDirection) + buffer.GetWordLength(rayTMax);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryInitializeKHR, ..rayQuery.AsSpirvSpan(), ..accel.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullMask.AsSpirvSpan(), ..rayOrigin.AsSpirvSpan(), ..rayTMin.AsSpirvSpan(), ..rayDirection.AsSpirvSpan(), ..rayTMax.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryInitializeKHR(this SpirvBuffer buffer, int position, IdRef rayQuery, IdRef accel, IdRef rayFlags, IdRef cullMask, IdRef rayOrigin, IdRef rayTMin, IdRef rayDirection, IdRef rayTMax)
    {
        var wordLength = 1 + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(accel) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullMask) + buffer.GetWordLength(rayOrigin) + buffer.GetWordLength(rayTMin) + buffer.GetWordLength(rayDirection) + buffer.GetWordLength(rayTMax);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryInitializeKHR, ..rayQuery.AsSpirvSpan(), ..accel.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullMask.AsSpirvSpan(), ..rayOrigin.AsSpirvSpan(), ..rayTMin.AsSpirvSpan(), ..rayDirection.AsSpirvSpan(), ..rayTMax.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryTerminateKHR(this SpirvBuffer buffer, IdRef rayQuery)
    {
        var wordLength = 1 + buffer.GetWordLength(rayQuery);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryTerminateKHR, ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryTerminateKHR(this SpirvBuffer buffer, int position, IdRef rayQuery)
    {
        var wordLength = 1 + buffer.GetWordLength(rayQuery);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryTerminateKHR, ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGenerateIntersectionKHR(this SpirvBuffer buffer, IdRef rayQuery, IdRef hitT)
    {
        var wordLength = 1 + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(hitT);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGenerateIntersectionKHR, ..rayQuery.AsSpirvSpan(), ..hitT.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGenerateIntersectionKHR(this SpirvBuffer buffer, int position, IdRef rayQuery, IdRef hitT)
    {
        var wordLength = 1 + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(hitT);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGenerateIntersectionKHR, ..rayQuery.AsSpirvSpan(), ..hitT.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryConfirmIntersectionKHR(this SpirvBuffer buffer, IdRef rayQuery)
    {
        var wordLength = 1 + buffer.GetWordLength(rayQuery);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryConfirmIntersectionKHR, ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryConfirmIntersectionKHR(this SpirvBuffer buffer, int position, IdRef rayQuery)
    {
        var wordLength = 1 + buffer.GetWordLength(rayQuery);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryConfirmIntersectionKHR, ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryProceedKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryProceedKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryProceedKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryProceedKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionTypeKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionTypeKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetIntersectionTypeKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionTypeKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleWeightedQCOM(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef texture, IdRef coordinates, IdRef weights)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(texture) + buffer.GetWordLength(coordinates) + buffer.GetWordLength(weights);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleWeightedQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..texture.AsSpirvSpan(), ..coordinates.AsSpirvSpan(), ..weights.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSampleWeightedQCOM(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef texture, IdRef coordinates, IdRef weights)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(texture) + buffer.GetWordLength(coordinates) + buffer.GetWordLength(weights);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSampleWeightedQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..texture.AsSpirvSpan(), ..coordinates.AsSpirvSpan(), ..weights.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageBoxFilterQCOM(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef texture, IdRef coordinates, IdRef boxSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(texture) + buffer.GetWordLength(coordinates) + buffer.GetWordLength(boxSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageBoxFilterQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..texture.AsSpirvSpan(), ..coordinates.AsSpirvSpan(), ..boxSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageBoxFilterQCOM(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef texture, IdRef coordinates, IdRef boxSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(texture) + buffer.GetWordLength(coordinates) + buffer.GetWordLength(boxSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageBoxFilterQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..texture.AsSpirvSpan(), ..coordinates.AsSpirvSpan(), ..boxSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageBlockMatchSSDQCOM(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef target, IdRef targetCoordinates, IdRef reference, IdRef referenceCoordinates, IdRef blockSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(target) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(reference) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageBlockMatchSSDQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..target.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..reference.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageBlockMatchSSDQCOM(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef target, IdRef targetCoordinates, IdRef reference, IdRef referenceCoordinates, IdRef blockSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(target) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(reference) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageBlockMatchSSDQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..target.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..reference.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageBlockMatchSADQCOM(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef target, IdRef targetCoordinates, IdRef reference, IdRef referenceCoordinates, IdRef blockSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(target) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(reference) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageBlockMatchSADQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..target.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..reference.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageBlockMatchSADQCOM(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef target, IdRef targetCoordinates, IdRef reference, IdRef referenceCoordinates, IdRef blockSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(target) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(reference) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageBlockMatchSADQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..target.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..reference.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageBlockMatchWindowSSDQCOM(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef targetSampledImage, IdRef targetCoordinates, IdRef referenceSampledImage, IdRef referenceCoordinates, IdRef blockSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(targetSampledImage) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(referenceSampledImage) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageBlockMatchWindowSSDQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..targetSampledImage.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..referenceSampledImage.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageBlockMatchWindowSSDQCOM(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef targetSampledImage, IdRef targetCoordinates, IdRef referenceSampledImage, IdRef referenceCoordinates, IdRef blockSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(targetSampledImage) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(referenceSampledImage) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageBlockMatchWindowSSDQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..targetSampledImage.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..referenceSampledImage.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageBlockMatchWindowSADQCOM(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef targetSampledImage, IdRef targetCoordinates, IdRef referenceSampledImage, IdRef referenceCoordinates, IdRef blockSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(targetSampledImage) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(referenceSampledImage) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageBlockMatchWindowSADQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..targetSampledImage.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..referenceSampledImage.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageBlockMatchWindowSADQCOM(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef targetSampledImage, IdRef targetCoordinates, IdRef referenceSampledImage, IdRef referenceCoordinates, IdRef blockSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(targetSampledImage) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(referenceSampledImage) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageBlockMatchWindowSADQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..targetSampledImage.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..referenceSampledImage.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageBlockMatchGatherSSDQCOM(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef targetSampledImage, IdRef targetCoordinates, IdRef referenceSampledImage, IdRef referenceCoordinates, IdRef blockSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(targetSampledImage) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(referenceSampledImage) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageBlockMatchGatherSSDQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..targetSampledImage.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..referenceSampledImage.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageBlockMatchGatherSSDQCOM(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef targetSampledImage, IdRef targetCoordinates, IdRef referenceSampledImage, IdRef referenceCoordinates, IdRef blockSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(targetSampledImage) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(referenceSampledImage) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageBlockMatchGatherSSDQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..targetSampledImage.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..referenceSampledImage.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageBlockMatchGatherSADQCOM(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef targetSampledImage, IdRef targetCoordinates, IdRef referenceSampledImage, IdRef referenceCoordinates, IdRef blockSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(targetSampledImage) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(referenceSampledImage) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageBlockMatchGatherSADQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..targetSampledImage.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..referenceSampledImage.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageBlockMatchGatherSADQCOM(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef targetSampledImage, IdRef targetCoordinates, IdRef referenceSampledImage, IdRef referenceCoordinates, IdRef blockSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(targetSampledImage) + buffer.GetWordLength(targetCoordinates) + buffer.GetWordLength(referenceSampledImage) + buffer.GetWordLength(referenceCoordinates) + buffer.GetWordLength(blockSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageBlockMatchGatherSADQCOM, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..targetSampledImage.AsSpirvSpan(), ..targetCoordinates.AsSpirvSpan(), ..referenceSampledImage.AsSpirvSpan(), ..referenceCoordinates.AsSpirvSpan(), ..blockSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupIAddNonUniformAMD(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupIAddNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupIAddNonUniformAMD(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupIAddNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupFAddNonUniformAMD(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupFAddNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupFAddNonUniformAMD(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupFAddNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupFMinNonUniformAMD(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupFMinNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupFMinNonUniformAMD(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupFMinNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupUMinNonUniformAMD(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupUMinNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupUMinNonUniformAMD(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupUMinNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupSMinNonUniformAMD(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupSMinNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupSMinNonUniformAMD(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupSMinNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupFMaxNonUniformAMD(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupFMaxNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupFMaxNonUniformAMD(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupFMaxNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupUMaxNonUniformAMD(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupUMaxNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupUMaxNonUniformAMD(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupUMaxNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupSMaxNonUniformAMD(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupSMaxNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupSMaxNonUniformAMD(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupSMaxNonUniformAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpFragmentMaskFetchAMD(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFragmentMaskFetchAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFragmentMaskFetchAMD(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFragmentMaskFetchAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan()]);
    }

    public static Instruction AddOpFragmentFetchAMD(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, IdRef fragmentIndex)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(fragmentIndex);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFragmentFetchAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..fragmentIndex.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFragmentFetchAMD(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, IdRef fragmentIndex)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(fragmentIndex);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFragmentFetchAMD, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..fragmentIndex.AsSpirvSpan()]);
    }

    public static Instruction AddOpReadClockKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope scope)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(scope);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReadClockKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..scope.AsSpirvSpan()]);
    }

    public static Instruction InsertOpReadClockKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope scope)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(scope);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpReadClockKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..scope.AsSpirvSpan()]);
    }

    public static Instruction AddOpAllocateNodePayloadsAMDX(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope visibility, IdRef payloadCount, IdRef nodeIndex)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(visibility) + buffer.GetWordLength(payloadCount) + buffer.GetWordLength(nodeIndex);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAllocateNodePayloadsAMDX, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..visibility.AsSpirvSpan(), ..payloadCount.AsSpirvSpan(), ..nodeIndex.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAllocateNodePayloadsAMDX(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope visibility, IdRef payloadCount, IdRef nodeIndex)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(visibility) + buffer.GetWordLength(payloadCount) + buffer.GetWordLength(nodeIndex);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAllocateNodePayloadsAMDX, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..visibility.AsSpirvSpan(), ..payloadCount.AsSpirvSpan(), ..nodeIndex.AsSpirvSpan()]);
    }

    public static Instruction AddOpEnqueueNodePayloadsAMDX(this SpirvBuffer buffer, IdRef payloadArray)
    {
        var wordLength = 1 + buffer.GetWordLength(payloadArray);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpEnqueueNodePayloadsAMDX, ..payloadArray.AsSpirvSpan()]);
    }

    public static Instruction InsertOpEnqueueNodePayloadsAMDX(this SpirvBuffer buffer, int position, IdRef payloadArray)
    {
        var wordLength = 1 + buffer.GetWordLength(payloadArray);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpEnqueueNodePayloadsAMDX, ..payloadArray.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeNodePayloadArrayAMDX(this SpirvBuffer buffer, IdResult resultId, IdRef payloadType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(payloadType);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeNodePayloadArrayAMDX, ..resultId.AsSpirvSpan(), ..payloadType.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeNodePayloadArrayAMDX(this SpirvBuffer buffer, int position, IdResult resultId, IdRef payloadType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(payloadType);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeNodePayloadArrayAMDX, ..resultId.AsSpirvSpan(), ..payloadType.AsSpirvSpan()]);
    }

    public static Instruction AddOpFinishWritingNodePayloadAMDX(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFinishWritingNodePayloadAMDX, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFinishWritingNodePayloadAMDX(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFinishWritingNodePayloadAMDX, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpNodePayloadArrayLengthAMDX(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payloadArray)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payloadArray);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpNodePayloadArrayLengthAMDX, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payloadArray.AsSpirvSpan()]);
    }

    public static Instruction InsertOpNodePayloadArrayLengthAMDX(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payloadArray)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payloadArray);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpNodePayloadArrayLengthAMDX, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payloadArray.AsSpirvSpan()]);
    }

    public static Instruction AddOpIsNodePayloadValidAMDX(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payloadType, IdRef nodeIndex)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payloadType) + buffer.GetWordLength(nodeIndex);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIsNodePayloadValidAMDX, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payloadType.AsSpirvSpan(), ..nodeIndex.AsSpirvSpan()]);
    }

    public static Instruction InsertOpIsNodePayloadValidAMDX(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payloadType, IdRef nodeIndex)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payloadType) + buffer.GetWordLength(nodeIndex);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpIsNodePayloadValidAMDX, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payloadType.AsSpirvSpan(), ..nodeIndex.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantStringAMDX(this SpirvBuffer buffer, IdResult resultId, LiteralString literalString)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(literalString);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantStringAMDX, ..resultId.AsSpirvSpan(), ..literalString.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConstantStringAMDX(this SpirvBuffer buffer, int position, IdResult resultId, LiteralString literalString)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(literalString);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConstantStringAMDX, ..resultId.AsSpirvSpan(), ..literalString.AsSpirvSpan()]);
    }

    public static Instruction AddOpSpecConstantStringAMDX(this SpirvBuffer buffer, IdResult resultId, LiteralString literalString)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(literalString);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSpecConstantStringAMDX, ..resultId.AsSpirvSpan(), ..literalString.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSpecConstantStringAMDX(this SpirvBuffer buffer, int position, IdResult resultId, LiteralString literalString)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(literalString);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSpecConstantStringAMDX, ..resultId.AsSpirvSpan(), ..literalString.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformQuadAllKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformQuadAllKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformQuadAllKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformQuadAllKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformQuadAnyKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformQuadAnyKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformQuadAnyKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef predicate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(predicate);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformQuadAnyKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..predicate.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectRecordHitMotionNV(this SpirvBuffer buffer, IdRef hitObject, IdRef accelerationStructure, IdRef instanceId, IdRef primitiveId, IdRef geometryIndex, IdRef hitKind, IdRef sBTRecordOffset, IdRef sBTRecordStride, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef currentTime, IdRef hitObjectAttributes)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(primitiveId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(hitKind) + buffer.GetWordLength(sBTRecordOffset) + buffer.GetWordLength(sBTRecordStride) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(currentTime) + buffer.GetWordLength(hitObjectAttributes);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectRecordHitMotionNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..primitiveId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..hitKind.AsSpirvSpan(), ..sBTRecordOffset.AsSpirvSpan(), ..sBTRecordStride.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..currentTime.AsSpirvSpan(), ..hitObjectAttributes.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectRecordHitMotionNV(this SpirvBuffer buffer, int position, IdRef hitObject, IdRef accelerationStructure, IdRef instanceId, IdRef primitiveId, IdRef geometryIndex, IdRef hitKind, IdRef sBTRecordOffset, IdRef sBTRecordStride, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef currentTime, IdRef hitObjectAttributes)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(primitiveId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(hitKind) + buffer.GetWordLength(sBTRecordOffset) + buffer.GetWordLength(sBTRecordStride) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(currentTime) + buffer.GetWordLength(hitObjectAttributes);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectRecordHitMotionNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..primitiveId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..hitKind.AsSpirvSpan(), ..sBTRecordOffset.AsSpirvSpan(), ..sBTRecordStride.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..currentTime.AsSpirvSpan(), ..hitObjectAttributes.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectRecordHitWithIndexMotionNV(this SpirvBuffer buffer, IdRef hitObject, IdRef accelerationStructure, IdRef instanceId, IdRef primitiveId, IdRef geometryIndex, IdRef hitKind, IdRef sBTRecordIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef currentTime, IdRef hitObjectAttributes)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(primitiveId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(hitKind) + buffer.GetWordLength(sBTRecordIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(currentTime) + buffer.GetWordLength(hitObjectAttributes);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectRecordHitWithIndexMotionNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..primitiveId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..hitKind.AsSpirvSpan(), ..sBTRecordIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..currentTime.AsSpirvSpan(), ..hitObjectAttributes.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectRecordHitWithIndexMotionNV(this SpirvBuffer buffer, int position, IdRef hitObject, IdRef accelerationStructure, IdRef instanceId, IdRef primitiveId, IdRef geometryIndex, IdRef hitKind, IdRef sBTRecordIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef currentTime, IdRef hitObjectAttributes)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(primitiveId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(hitKind) + buffer.GetWordLength(sBTRecordIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(currentTime) + buffer.GetWordLength(hitObjectAttributes);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectRecordHitWithIndexMotionNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..primitiveId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..hitKind.AsSpirvSpan(), ..sBTRecordIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..currentTime.AsSpirvSpan(), ..hitObjectAttributes.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectRecordMissMotionNV(this SpirvBuffer buffer, IdRef hitObject, IdRef sBTIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef currentTime)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(sBTIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(currentTime);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectRecordMissMotionNV, ..hitObject.AsSpirvSpan(), ..sBTIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..currentTime.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectRecordMissMotionNV(this SpirvBuffer buffer, int position, IdRef hitObject, IdRef sBTIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef currentTime)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(sBTIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(currentTime);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectRecordMissMotionNV, ..hitObject.AsSpirvSpan(), ..sBTIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..currentTime.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetWorldToObjectNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetWorldToObjectNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectGetWorldToObjectNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectGetWorldToObjectNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetObjectToWorldNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetObjectToWorldNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectGetObjectToWorldNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectGetObjectToWorldNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetObjectRayDirectionNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetObjectRayDirectionNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectGetObjectRayDirectionNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectGetObjectRayDirectionNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetObjectRayOriginNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetObjectRayOriginNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectGetObjectRayOriginNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectGetObjectRayOriginNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectTraceRayMotionNV(this SpirvBuffer buffer, IdRef hitObject, IdRef accelerationStructure, IdRef rayFlags, IdRef cullmask, IdRef sBTRecordOffset, IdRef sBTRecordStride, IdRef missIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef time, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullmask) + buffer.GetWordLength(sBTRecordOffset) + buffer.GetWordLength(sBTRecordStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(time) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectTraceRayMotionNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullmask.AsSpirvSpan(), ..sBTRecordOffset.AsSpirvSpan(), ..sBTRecordStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..time.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectTraceRayMotionNV(this SpirvBuffer buffer, int position, IdRef hitObject, IdRef accelerationStructure, IdRef rayFlags, IdRef cullmask, IdRef sBTRecordOffset, IdRef sBTRecordStride, IdRef missIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef time, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullmask) + buffer.GetWordLength(sBTRecordOffset) + buffer.GetWordLength(sBTRecordStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(time) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectTraceRayMotionNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullmask.AsSpirvSpan(), ..sBTRecordOffset.AsSpirvSpan(), ..sBTRecordStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..time.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetShaderRecordBufferHandleNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetShaderRecordBufferHandleNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectGetShaderRecordBufferHandleNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectGetShaderRecordBufferHandleNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetShaderBindingTableRecordIndexNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetShaderBindingTableRecordIndexNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectGetShaderBindingTableRecordIndexNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectGetShaderBindingTableRecordIndexNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectRecordEmptyNV(this SpirvBuffer buffer, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectRecordEmptyNV, ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectRecordEmptyNV(this SpirvBuffer buffer, int position, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectRecordEmptyNV, ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectTraceRayNV(this SpirvBuffer buffer, IdRef hitObject, IdRef accelerationStructure, IdRef rayFlags, IdRef cullmask, IdRef sBTRecordOffset, IdRef sBTRecordStride, IdRef missIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullmask) + buffer.GetWordLength(sBTRecordOffset) + buffer.GetWordLength(sBTRecordStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectTraceRayNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullmask.AsSpirvSpan(), ..sBTRecordOffset.AsSpirvSpan(), ..sBTRecordStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectTraceRayNV(this SpirvBuffer buffer, int position, IdRef hitObject, IdRef accelerationStructure, IdRef rayFlags, IdRef cullmask, IdRef sBTRecordOffset, IdRef sBTRecordStride, IdRef missIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullmask) + buffer.GetWordLength(sBTRecordOffset) + buffer.GetWordLength(sBTRecordStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectTraceRayNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullmask.AsSpirvSpan(), ..sBTRecordOffset.AsSpirvSpan(), ..sBTRecordStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectRecordHitNV(this SpirvBuffer buffer, IdRef hitObject, IdRef accelerationStructure, IdRef instanceId, IdRef primitiveId, IdRef geometryIndex, IdRef hitKind, IdRef sBTRecordOffset, IdRef sBTRecordStride, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef hitObjectAttributes)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(primitiveId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(hitKind) + buffer.GetWordLength(sBTRecordOffset) + buffer.GetWordLength(sBTRecordStride) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(hitObjectAttributes);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectRecordHitNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..primitiveId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..hitKind.AsSpirvSpan(), ..sBTRecordOffset.AsSpirvSpan(), ..sBTRecordStride.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..hitObjectAttributes.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectRecordHitNV(this SpirvBuffer buffer, int position, IdRef hitObject, IdRef accelerationStructure, IdRef instanceId, IdRef primitiveId, IdRef geometryIndex, IdRef hitKind, IdRef sBTRecordOffset, IdRef sBTRecordStride, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef hitObjectAttributes)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(primitiveId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(hitKind) + buffer.GetWordLength(sBTRecordOffset) + buffer.GetWordLength(sBTRecordStride) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(hitObjectAttributes);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectRecordHitNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..primitiveId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..hitKind.AsSpirvSpan(), ..sBTRecordOffset.AsSpirvSpan(), ..sBTRecordStride.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..hitObjectAttributes.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectRecordHitWithIndexNV(this SpirvBuffer buffer, IdRef hitObject, IdRef accelerationStructure, IdRef instanceId, IdRef primitiveId, IdRef geometryIndex, IdRef hitKind, IdRef sBTRecordIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef hitObjectAttributes)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(primitiveId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(hitKind) + buffer.GetWordLength(sBTRecordIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(hitObjectAttributes);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectRecordHitWithIndexNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..primitiveId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..hitKind.AsSpirvSpan(), ..sBTRecordIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..hitObjectAttributes.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectRecordHitWithIndexNV(this SpirvBuffer buffer, int position, IdRef hitObject, IdRef accelerationStructure, IdRef instanceId, IdRef primitiveId, IdRef geometryIndex, IdRef hitKind, IdRef sBTRecordIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax, IdRef hitObjectAttributes)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(accelerationStructure) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(primitiveId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(hitKind) + buffer.GetWordLength(sBTRecordIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax) + buffer.GetWordLength(hitObjectAttributes);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectRecordHitWithIndexNV, ..hitObject.AsSpirvSpan(), ..accelerationStructure.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..primitiveId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..hitKind.AsSpirvSpan(), ..sBTRecordIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan(), ..hitObjectAttributes.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectRecordMissNV(this SpirvBuffer buffer, IdRef hitObject, IdRef sBTIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(sBTIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectRecordMissNV, ..hitObject.AsSpirvSpan(), ..sBTIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectRecordMissNV(this SpirvBuffer buffer, int position, IdRef hitObject, IdRef sBTIndex, IdRef origin, IdRef tMin, IdRef direction, IdRef tMax)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(sBTIndex) + buffer.GetWordLength(origin) + buffer.GetWordLength(tMin) + buffer.GetWordLength(direction) + buffer.GetWordLength(tMax);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectRecordMissNV, ..hitObject.AsSpirvSpan(), ..sBTIndex.AsSpirvSpan(), ..origin.AsSpirvSpan(), ..tMin.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..tMax.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectExecuteShaderNV(this SpirvBuffer buffer, IdRef hitObject, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectExecuteShaderNV, ..hitObject.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectExecuteShaderNV(this SpirvBuffer buffer, int position, IdRef hitObject, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectExecuteShaderNV, ..hitObject.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetCurrentTimeNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetCurrentTimeNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectGetCurrentTimeNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectGetCurrentTimeNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetAttributesNV(this SpirvBuffer buffer, IdRef hitObject, IdRef hitObjectAttribute)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(hitObjectAttribute);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetAttributesNV, ..hitObject.AsSpirvSpan(), ..hitObjectAttribute.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectGetAttributesNV(this SpirvBuffer buffer, int position, IdRef hitObject, IdRef hitObjectAttribute)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(hitObjectAttribute);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectGetAttributesNV, ..hitObject.AsSpirvSpan(), ..hitObjectAttribute.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetHitKindNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetHitKindNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectGetHitKindNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectGetHitKindNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetPrimitiveIndexNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetPrimitiveIndexNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectGetPrimitiveIndexNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectGetPrimitiveIndexNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetGeometryIndexNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetGeometryIndexNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectGetGeometryIndexNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectGetGeometryIndexNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetInstanceIdNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetInstanceIdNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectGetInstanceIdNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectGetInstanceIdNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetInstanceCustomIndexNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetInstanceCustomIndexNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectGetInstanceCustomIndexNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectGetInstanceCustomIndexNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetWorldRayDirectionNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetWorldRayDirectionNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectGetWorldRayDirectionNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectGetWorldRayDirectionNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetWorldRayOriginNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetWorldRayOriginNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectGetWorldRayOriginNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectGetWorldRayOriginNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetRayTMaxNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetRayTMaxNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectGetRayTMaxNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectGetRayTMaxNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectGetRayTMinNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectGetRayTMinNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectGetRayTMinNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectGetRayTMinNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectIsEmptyNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectIsEmptyNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectIsEmptyNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectIsEmptyNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectIsHitNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectIsHitNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectIsHitNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectIsHitNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpHitObjectIsMissNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpHitObjectIsMissNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction InsertOpHitObjectIsMissNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hitObject)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hitObject);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpHitObjectIsMissNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hitObject.AsSpirvSpan()]);
    }

    public static Instruction AddOpReorderThreadWithHitObjectNV(this SpirvBuffer buffer, IdRef hitObject, IdRef? hint, IdRef? bits)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(hint) + buffer.GetWordLength(bits);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReorderThreadWithHitObjectNV, ..hitObject.AsSpirvSpan(), ..hint.AsSpirvSpan(), ..bits.AsSpirvSpan()]);
    }

    public static Instruction InsertOpReorderThreadWithHitObjectNV(this SpirvBuffer buffer, int position, IdRef hitObject, IdRef? hint, IdRef? bits)
    {
        var wordLength = 1 + buffer.GetWordLength(hitObject) + buffer.GetWordLength(hint) + buffer.GetWordLength(bits);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpReorderThreadWithHitObjectNV, ..hitObject.AsSpirvSpan(), ..hint.AsSpirvSpan(), ..bits.AsSpirvSpan()]);
    }

    public static Instruction AddOpReorderThreadWithHintNV(this SpirvBuffer buffer, IdRef hint, IdRef bits)
    {
        var wordLength = 1 + buffer.GetWordLength(hint) + buffer.GetWordLength(bits);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReorderThreadWithHintNV, ..hint.AsSpirvSpan(), ..bits.AsSpirvSpan()]);
    }

    public static Instruction InsertOpReorderThreadWithHintNV(this SpirvBuffer buffer, int position, IdRef hint, IdRef bits)
    {
        var wordLength = 1 + buffer.GetWordLength(hint) + buffer.GetWordLength(bits);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpReorderThreadWithHintNV, ..hint.AsSpirvSpan(), ..bits.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeHitObjectNV(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeHitObjectNV, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeHitObjectNV(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeHitObjectNV, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpImageSampleFootprintNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef granularity, IdRef coarse, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(granularity) + buffer.GetWordLength(coarse) + buffer.GetWordLength(imageoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpImageSampleFootprintNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..granularity.AsSpirvSpan(), ..coarse.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpImageSampleFootprintNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sampledImage, IdRef coordinate, IdRef granularity, IdRef coarse, ImageOperandsMask? imageoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sampledImage) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(granularity) + buffer.GetWordLength(coarse) + buffer.GetWordLength(imageoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpImageSampleFootprintNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sampledImage.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..granularity.AsSpirvSpan(), ..coarse.AsSpirvSpan(), ..imageoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixConvertNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef matrix)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(matrix);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixConvertNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..matrix.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCooperativeMatrixConvertNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef matrix)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(matrix);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixConvertNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..matrix.AsSpirvSpan()]);
    }

    public static Instruction AddOpEmitMeshTasksEXT(this SpirvBuffer buffer, IdRef groupCountX, IdRef groupCountY, IdRef groupCountZ, IdRef? payload)
    {
        var wordLength = 1 + buffer.GetWordLength(groupCountX) + buffer.GetWordLength(groupCountY) + buffer.GetWordLength(groupCountZ) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpEmitMeshTasksEXT, ..groupCountX.AsSpirvSpan(), ..groupCountY.AsSpirvSpan(), ..groupCountZ.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpEmitMeshTasksEXT(this SpirvBuffer buffer, int position, IdRef groupCountX, IdRef groupCountY, IdRef groupCountZ, IdRef? payload)
    {
        var wordLength = 1 + buffer.GetWordLength(groupCountX) + buffer.GetWordLength(groupCountY) + buffer.GetWordLength(groupCountZ) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpEmitMeshTasksEXT, ..groupCountX.AsSpirvSpan(), ..groupCountY.AsSpirvSpan(), ..groupCountZ.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSetMeshOutputsEXT(this SpirvBuffer buffer, IdRef vertexCount, IdRef primitiveCount)
    {
        var wordLength = 1 + buffer.GetWordLength(vertexCount) + buffer.GetWordLength(primitiveCount);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSetMeshOutputsEXT, ..vertexCount.AsSpirvSpan(), ..primitiveCount.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSetMeshOutputsEXT(this SpirvBuffer buffer, int position, IdRef vertexCount, IdRef primitiveCount)
    {
        var wordLength = 1 + buffer.GetWordLength(vertexCount) + buffer.GetWordLength(primitiveCount);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSetMeshOutputsEXT, ..vertexCount.AsSpirvSpan(), ..primitiveCount.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupNonUniformPartitionNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupNonUniformPartitionNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupNonUniformPartitionNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupNonUniformPartitionNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpWritePackedPrimitiveIndices4x8NV(this SpirvBuffer buffer, IdRef indexOffset, IdRef packedIndices)
    {
        var wordLength = 1 + buffer.GetWordLength(indexOffset) + buffer.GetWordLength(packedIndices);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpWritePackedPrimitiveIndices4x8NV, ..indexOffset.AsSpirvSpan(), ..packedIndices.AsSpirvSpan()]);
    }

    public static Instruction InsertOpWritePackedPrimitiveIndices4x8NV(this SpirvBuffer buffer, int position, IdRef indexOffset, IdRef packedIndices)
    {
        var wordLength = 1 + buffer.GetWordLength(indexOffset) + buffer.GetWordLength(packedIndices);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpWritePackedPrimitiveIndices4x8NV, ..indexOffset.AsSpirvSpan(), ..packedIndices.AsSpirvSpan()]);
    }

    public static Instruction AddOpFetchMicroTriangleVertexPositionNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef accel, IdRef instanceId, IdRef geometryIndex, IdRef primitiveIndex, IdRef barycentric)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(accel) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(primitiveIndex) + buffer.GetWordLength(barycentric);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFetchMicroTriangleVertexPositionNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..accel.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..primitiveIndex.AsSpirvSpan(), ..barycentric.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFetchMicroTriangleVertexPositionNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef accel, IdRef instanceId, IdRef geometryIndex, IdRef primitiveIndex, IdRef barycentric)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(accel) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(primitiveIndex) + buffer.GetWordLength(barycentric);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFetchMicroTriangleVertexPositionNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..accel.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..primitiveIndex.AsSpirvSpan(), ..barycentric.AsSpirvSpan()]);
    }

    public static Instruction AddOpFetchMicroTriangleVertexBarycentricNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef accel, IdRef instanceId, IdRef geometryIndex, IdRef primitiveIndex, IdRef barycentric)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(accel) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(primitiveIndex) + buffer.GetWordLength(barycentric);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFetchMicroTriangleVertexBarycentricNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..accel.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..primitiveIndex.AsSpirvSpan(), ..barycentric.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFetchMicroTriangleVertexBarycentricNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef accel, IdRef instanceId, IdRef geometryIndex, IdRef primitiveIndex, IdRef barycentric)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(accel) + buffer.GetWordLength(instanceId) + buffer.GetWordLength(geometryIndex) + buffer.GetWordLength(primitiveIndex) + buffer.GetWordLength(barycentric);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFetchMicroTriangleVertexBarycentricNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..accel.AsSpirvSpan(), ..instanceId.AsSpirvSpan(), ..geometryIndex.AsSpirvSpan(), ..primitiveIndex.AsSpirvSpan(), ..barycentric.AsSpirvSpan()]);
    }

    public static Instruction AddOpReportIntersectionKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef hit, IdRef hitKind)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hit) + buffer.GetWordLength(hitKind);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReportIntersectionKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hit.AsSpirvSpan(), ..hitKind.AsSpirvSpan()]);
    }

    public static Instruction InsertOpReportIntersectionKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef hit, IdRef hitKind)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(hit) + buffer.GetWordLength(hitKind);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpReportIntersectionKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..hit.AsSpirvSpan(), ..hitKind.AsSpirvSpan()]);
    }

    public static Instruction AddOpIgnoreIntersectionNV(this SpirvBuffer buffer)
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpIgnoreIntersectionNV]);
    }

    public static Instruction InsertOpIgnoreIntersectionNV(this SpirvBuffer buffer, int position)
    {
        return buffer.Insert(position, [1 << 16 | (int)SDSLOp.OpIgnoreIntersectionNV]);
    }

    public static Instruction AddOpTerminateRayNV(this SpirvBuffer buffer)
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpTerminateRayNV]);
    }

    public static Instruction InsertOpTerminateRayNV(this SpirvBuffer buffer, int position)
    {
        return buffer.Insert(position, [1 << 16 | (int)SDSLOp.OpTerminateRayNV]);
    }

    public static Instruction AddOpTraceNV(this SpirvBuffer buffer, IdRef accel, IdRef rayFlags, IdRef cullMask, IdRef sBTOffset, IdRef sBTStride, IdRef missIndex, IdRef rayOrigin, IdRef rayTmin, IdRef rayDirection, IdRef rayTmax, IdRef payloadId)
    {
        var wordLength = 1 + buffer.GetWordLength(accel) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullMask) + buffer.GetWordLength(sBTOffset) + buffer.GetWordLength(sBTStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(rayOrigin) + buffer.GetWordLength(rayTmin) + buffer.GetWordLength(rayDirection) + buffer.GetWordLength(rayTmax) + buffer.GetWordLength(payloadId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTraceNV, ..accel.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullMask.AsSpirvSpan(), ..sBTOffset.AsSpirvSpan(), ..sBTStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..rayOrigin.AsSpirvSpan(), ..rayTmin.AsSpirvSpan(), ..rayDirection.AsSpirvSpan(), ..rayTmax.AsSpirvSpan(), ..payloadId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTraceNV(this SpirvBuffer buffer, int position, IdRef accel, IdRef rayFlags, IdRef cullMask, IdRef sBTOffset, IdRef sBTStride, IdRef missIndex, IdRef rayOrigin, IdRef rayTmin, IdRef rayDirection, IdRef rayTmax, IdRef payloadId)
    {
        var wordLength = 1 + buffer.GetWordLength(accel) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullMask) + buffer.GetWordLength(sBTOffset) + buffer.GetWordLength(sBTStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(rayOrigin) + buffer.GetWordLength(rayTmin) + buffer.GetWordLength(rayDirection) + buffer.GetWordLength(rayTmax) + buffer.GetWordLength(payloadId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTraceNV, ..accel.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullMask.AsSpirvSpan(), ..sBTOffset.AsSpirvSpan(), ..sBTStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..rayOrigin.AsSpirvSpan(), ..rayTmin.AsSpirvSpan(), ..rayDirection.AsSpirvSpan(), ..rayTmax.AsSpirvSpan(), ..payloadId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTraceMotionNV(this SpirvBuffer buffer, IdRef accel, IdRef rayFlags, IdRef cullMask, IdRef sBTOffset, IdRef sBTStride, IdRef missIndex, IdRef rayOrigin, IdRef rayTmin, IdRef rayDirection, IdRef rayTmax, IdRef time, IdRef payloadId)
    {
        var wordLength = 1 + buffer.GetWordLength(accel) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullMask) + buffer.GetWordLength(sBTOffset) + buffer.GetWordLength(sBTStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(rayOrigin) + buffer.GetWordLength(rayTmin) + buffer.GetWordLength(rayDirection) + buffer.GetWordLength(rayTmax) + buffer.GetWordLength(time) + buffer.GetWordLength(payloadId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTraceMotionNV, ..accel.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullMask.AsSpirvSpan(), ..sBTOffset.AsSpirvSpan(), ..sBTStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..rayOrigin.AsSpirvSpan(), ..rayTmin.AsSpirvSpan(), ..rayDirection.AsSpirvSpan(), ..rayTmax.AsSpirvSpan(), ..time.AsSpirvSpan(), ..payloadId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTraceMotionNV(this SpirvBuffer buffer, int position, IdRef accel, IdRef rayFlags, IdRef cullMask, IdRef sBTOffset, IdRef sBTStride, IdRef missIndex, IdRef rayOrigin, IdRef rayTmin, IdRef rayDirection, IdRef rayTmax, IdRef time, IdRef payloadId)
    {
        var wordLength = 1 + buffer.GetWordLength(accel) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullMask) + buffer.GetWordLength(sBTOffset) + buffer.GetWordLength(sBTStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(rayOrigin) + buffer.GetWordLength(rayTmin) + buffer.GetWordLength(rayDirection) + buffer.GetWordLength(rayTmax) + buffer.GetWordLength(time) + buffer.GetWordLength(payloadId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTraceMotionNV, ..accel.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullMask.AsSpirvSpan(), ..sBTOffset.AsSpirvSpan(), ..sBTStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..rayOrigin.AsSpirvSpan(), ..rayTmin.AsSpirvSpan(), ..rayDirection.AsSpirvSpan(), ..rayTmax.AsSpirvSpan(), ..time.AsSpirvSpan(), ..payloadId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTraceRayMotionNV(this SpirvBuffer buffer, IdRef accel, IdRef rayFlags, IdRef cullMask, IdRef sBTOffset, IdRef sBTStride, IdRef missIndex, IdRef rayOrigin, IdRef rayTmin, IdRef rayDirection, IdRef rayTmax, IdRef time, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(accel) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullMask) + buffer.GetWordLength(sBTOffset) + buffer.GetWordLength(sBTStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(rayOrigin) + buffer.GetWordLength(rayTmin) + buffer.GetWordLength(rayDirection) + buffer.GetWordLength(rayTmax) + buffer.GetWordLength(time) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTraceRayMotionNV, ..accel.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullMask.AsSpirvSpan(), ..sBTOffset.AsSpirvSpan(), ..sBTStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..rayOrigin.AsSpirvSpan(), ..rayTmin.AsSpirvSpan(), ..rayDirection.AsSpirvSpan(), ..rayTmax.AsSpirvSpan(), ..time.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTraceRayMotionNV(this SpirvBuffer buffer, int position, IdRef accel, IdRef rayFlags, IdRef cullMask, IdRef sBTOffset, IdRef sBTStride, IdRef missIndex, IdRef rayOrigin, IdRef rayTmin, IdRef rayDirection, IdRef rayTmax, IdRef time, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(accel) + buffer.GetWordLength(rayFlags) + buffer.GetWordLength(cullMask) + buffer.GetWordLength(sBTOffset) + buffer.GetWordLength(sBTStride) + buffer.GetWordLength(missIndex) + buffer.GetWordLength(rayOrigin) + buffer.GetWordLength(rayTmin) + buffer.GetWordLength(rayDirection) + buffer.GetWordLength(rayTmax) + buffer.GetWordLength(time) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTraceRayMotionNV, ..accel.AsSpirvSpan(), ..rayFlags.AsSpirvSpan(), ..cullMask.AsSpirvSpan(), ..sBTOffset.AsSpirvSpan(), ..sBTStride.AsSpirvSpan(), ..missIndex.AsSpirvSpan(), ..rayOrigin.AsSpirvSpan(), ..rayTmin.AsSpirvSpan(), ..rayDirection.AsSpirvSpan(), ..rayTmax.AsSpirvSpan(), ..time.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionTriangleVertexPositionsKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionTriangleVertexPositionsKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetIntersectionTriangleVertexPositionsKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionTriangleVertexPositionsKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAccelerationStructureKHR(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAccelerationStructureKHR, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeAccelerationStructureKHR(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeAccelerationStructureKHR, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpExecuteCallableNV(this SpirvBuffer buffer, IdRef sBTIndex, IdRef callableDataId)
    {
        var wordLength = 1 + buffer.GetWordLength(sBTIndex) + buffer.GetWordLength(callableDataId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExecuteCallableNV, ..sBTIndex.AsSpirvSpan(), ..callableDataId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpExecuteCallableNV(this SpirvBuffer buffer, int position, IdRef sBTIndex, IdRef callableDataId)
    {
        var wordLength = 1 + buffer.GetWordLength(sBTIndex) + buffer.GetWordLength(callableDataId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpExecuteCallableNV, ..sBTIndex.AsSpirvSpan(), ..callableDataId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeCooperativeMatrixNV(this SpirvBuffer buffer, IdResult resultId, IdRef componentType, IdScope execution, IdRef rows, IdRef columns)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(componentType) + buffer.GetWordLength(execution) + buffer.GetWordLength(rows) + buffer.GetWordLength(columns);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeCooperativeMatrixNV, ..resultId.AsSpirvSpan(), ..componentType.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..rows.AsSpirvSpan(), ..columns.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeCooperativeMatrixNV(this SpirvBuffer buffer, int position, IdResult resultId, IdRef componentType, IdScope execution, IdRef rows, IdRef columns)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(componentType) + buffer.GetWordLength(execution) + buffer.GetWordLength(rows) + buffer.GetWordLength(columns);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeCooperativeMatrixNV, ..resultId.AsSpirvSpan(), ..componentType.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..rows.AsSpirvSpan(), ..columns.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixLoadNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdRef stride, IdRef columnMajor, MemoryAccessMask? memoryaccess)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(stride) + buffer.GetWordLength(columnMajor) + buffer.GetWordLength(memoryaccess);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixLoadNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..stride.AsSpirvSpan(), ..columnMajor.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCooperativeMatrixLoadNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdRef stride, IdRef columnMajor, MemoryAccessMask? memoryaccess)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(stride) + buffer.GetWordLength(columnMajor) + buffer.GetWordLength(memoryaccess);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixLoadNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..stride.AsSpirvSpan(), ..columnMajor.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixStoreNV(this SpirvBuffer buffer, IdRef pointer, IdRef objectId, IdRef stride, IdRef columnMajor, MemoryAccessMask? memoryaccess)
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(objectId) + buffer.GetWordLength(stride) + buffer.GetWordLength(columnMajor) + buffer.GetWordLength(memoryaccess);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixStoreNV, ..pointer.AsSpirvSpan(), ..objectId.AsSpirvSpan(), ..stride.AsSpirvSpan(), ..columnMajor.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCooperativeMatrixStoreNV(this SpirvBuffer buffer, int position, IdRef pointer, IdRef objectId, IdRef stride, IdRef columnMajor, MemoryAccessMask? memoryaccess)
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(objectId) + buffer.GetWordLength(stride) + buffer.GetWordLength(columnMajor) + buffer.GetWordLength(memoryaccess);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixStoreNV, ..pointer.AsSpirvSpan(), ..objectId.AsSpirvSpan(), ..stride.AsSpirvSpan(), ..columnMajor.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixMulAddNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, IdRef b, IdRef c)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(b) + buffer.GetWordLength(c);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixMulAddNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..b.AsSpirvSpan(), ..c.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCooperativeMatrixMulAddNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, IdRef b, IdRef c)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(b) + buffer.GetWordLength(c);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixMulAddNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..b.AsSpirvSpan(), ..c.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixLengthNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef type)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(type);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixLengthNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..type.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCooperativeMatrixLengthNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef type)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(type);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixLengthNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..type.AsSpirvSpan()]);
    }

    public static Instruction AddOpBeginInvocationInterlockEXT(this SpirvBuffer buffer)
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpBeginInvocationInterlockEXT]);
    }

    public static Instruction InsertOpBeginInvocationInterlockEXT(this SpirvBuffer buffer, int position)
    {
        return buffer.Insert(position, [1 << 16 | (int)SDSLOp.OpBeginInvocationInterlockEXT]);
    }

    public static Instruction AddOpEndInvocationInterlockEXT(this SpirvBuffer buffer)
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpEndInvocationInterlockEXT]);
    }

    public static Instruction InsertOpEndInvocationInterlockEXT(this SpirvBuffer buffer, int position)
    {
        return buffer.Insert(position, [1 << 16 | (int)SDSLOp.OpEndInvocationInterlockEXT]);
    }

    public static Instruction AddOpCooperativeMatrixReduceNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef matrix, CooperativeMatrixReduceMask reduce, IdRef combineFunc)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(matrix) + buffer.GetWordLength(reduce) + buffer.GetWordLength(combineFunc);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixReduceNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..matrix.AsSpirvSpan(), ..reduce.AsSpirvSpan(), ..combineFunc.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCooperativeMatrixReduceNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef matrix, CooperativeMatrixReduceMask reduce, IdRef combineFunc)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(matrix) + buffer.GetWordLength(reduce) + buffer.GetWordLength(combineFunc);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixReduceNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..matrix.AsSpirvSpan(), ..reduce.AsSpirvSpan(), ..combineFunc.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixLoadTensorNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdRef objectId, IdRef tensorLayout, MemoryAccessMask memoryOperand, TensorAddressingOperandsMask tensorAddressingOperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(objectId) + buffer.GetWordLength(tensorLayout) + buffer.GetWordLength(memoryOperand) + buffer.GetWordLength(tensorAddressingOperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixLoadTensorNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..objectId.AsSpirvSpan(), ..tensorLayout.AsSpirvSpan(), ..memoryOperand.AsSpirvSpan(), ..tensorAddressingOperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCooperativeMatrixLoadTensorNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdRef objectId, IdRef tensorLayout, MemoryAccessMask memoryOperand, TensorAddressingOperandsMask tensorAddressingOperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(objectId) + buffer.GetWordLength(tensorLayout) + buffer.GetWordLength(memoryOperand) + buffer.GetWordLength(tensorAddressingOperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixLoadTensorNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..objectId.AsSpirvSpan(), ..tensorLayout.AsSpirvSpan(), ..memoryOperand.AsSpirvSpan(), ..tensorAddressingOperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixStoreTensorNV(this SpirvBuffer buffer, IdRef pointer, IdRef objectId, IdRef tensorLayout, MemoryAccessMask memoryOperand, TensorAddressingOperandsMask tensorAddressingOperands)
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(objectId) + buffer.GetWordLength(tensorLayout) + buffer.GetWordLength(memoryOperand) + buffer.GetWordLength(tensorAddressingOperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixStoreTensorNV, ..pointer.AsSpirvSpan(), ..objectId.AsSpirvSpan(), ..tensorLayout.AsSpirvSpan(), ..memoryOperand.AsSpirvSpan(), ..tensorAddressingOperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCooperativeMatrixStoreTensorNV(this SpirvBuffer buffer, int position, IdRef pointer, IdRef objectId, IdRef tensorLayout, MemoryAccessMask memoryOperand, TensorAddressingOperandsMask tensorAddressingOperands)
    {
        var wordLength = 1 + buffer.GetWordLength(pointer) + buffer.GetWordLength(objectId) + buffer.GetWordLength(tensorLayout) + buffer.GetWordLength(memoryOperand) + buffer.GetWordLength(tensorAddressingOperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixStoreTensorNV, ..pointer.AsSpirvSpan(), ..objectId.AsSpirvSpan(), ..tensorLayout.AsSpirvSpan(), ..memoryOperand.AsSpirvSpan(), ..tensorAddressingOperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixPerElementOpNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef matrix, IdRef func, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(matrix) + buffer.GetWordLength(func) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixPerElementOpNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..matrix.AsSpirvSpan(), ..func.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCooperativeMatrixPerElementOpNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef matrix, IdRef func, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(matrix) + buffer.GetWordLength(func) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixPerElementOpNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..matrix.AsSpirvSpan(), ..func.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeTensorLayoutNV(this SpirvBuffer buffer, IdResult resultId, IdRef dim, IdRef clampMode)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(dim) + buffer.GetWordLength(clampMode);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeTensorLayoutNV, ..resultId.AsSpirvSpan(), ..dim.AsSpirvSpan(), ..clampMode.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeTensorLayoutNV(this SpirvBuffer buffer, int position, IdResult resultId, IdRef dim, IdRef clampMode)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(dim) + buffer.GetWordLength(clampMode);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeTensorLayoutNV, ..resultId.AsSpirvSpan(), ..dim.AsSpirvSpan(), ..clampMode.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeTensorViewNV(this SpirvBuffer buffer, IdResult resultId, IdRef dim, IdRef hasDimensions, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(dim) + buffer.GetWordLength(hasDimensions) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeTensorViewNV, ..resultId.AsSpirvSpan(), ..dim.AsSpirvSpan(), ..hasDimensions.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeTensorViewNV(this SpirvBuffer buffer, int position, IdResult resultId, IdRef dim, IdRef hasDimensions, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(dim) + buffer.GetWordLength(hasDimensions) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeTensorViewNV, ..resultId.AsSpirvSpan(), ..dim.AsSpirvSpan(), ..hasDimensions.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpCreateTensorLayoutNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCreateTensorLayoutNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCreateTensorLayoutNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCreateTensorLayoutNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTensorLayoutSetDimensionNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef tensorLayout, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(tensorLayout) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTensorLayoutSetDimensionNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..tensorLayout.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTensorLayoutSetDimensionNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef tensorLayout, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(tensorLayout) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTensorLayoutSetDimensionNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..tensorLayout.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpTensorLayoutSetStrideNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef tensorLayout, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(tensorLayout) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTensorLayoutSetStrideNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..tensorLayout.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTensorLayoutSetStrideNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef tensorLayout, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(tensorLayout) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTensorLayoutSetStrideNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..tensorLayout.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpTensorLayoutSliceNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef tensorLayout, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(tensorLayout) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTensorLayoutSliceNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..tensorLayout.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTensorLayoutSliceNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef tensorLayout, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(tensorLayout) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTensorLayoutSliceNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..tensorLayout.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpTensorLayoutSetClampValueNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef tensorLayout, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(tensorLayout) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTensorLayoutSetClampValueNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..tensorLayout.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTensorLayoutSetClampValueNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef tensorLayout, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(tensorLayout) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTensorLayoutSetClampValueNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..tensorLayout.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpCreateTensorViewNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCreateTensorViewNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCreateTensorViewNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCreateTensorViewNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTensorViewSetDimensionNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef tensorView, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(tensorView) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTensorViewSetDimensionNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..tensorView.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTensorViewSetDimensionNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef tensorView, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(tensorView) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTensorViewSetDimensionNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..tensorView.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpTensorViewSetStrideNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef tensorView, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(tensorView) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTensorViewSetStrideNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..tensorView.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTensorViewSetStrideNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef tensorView, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(tensorView) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTensorViewSetStrideNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..tensorView.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpDemoteToHelperInvocation(this SpirvBuffer buffer)
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpDemoteToHelperInvocation]);
    }

    public static Instruction InsertOpDemoteToHelperInvocation(this SpirvBuffer buffer, int position)
    {
        return buffer.Insert(position, [1 << 16 | (int)SDSLOp.OpDemoteToHelperInvocation]);
    }

    public static Instruction AddOpIsHelperInvocationEXT(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIsHelperInvocationEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpIsHelperInvocationEXT(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpIsHelperInvocationEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTensorViewSetClipNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef tensorView, IdRef clipRowOffset, IdRef clipRowSpan, IdRef clipColOffset, IdRef clipColSpan)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(tensorView) + buffer.GetWordLength(clipRowOffset) + buffer.GetWordLength(clipRowSpan) + buffer.GetWordLength(clipColOffset) + buffer.GetWordLength(clipColSpan);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTensorViewSetClipNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..tensorView.AsSpirvSpan(), ..clipRowOffset.AsSpirvSpan(), ..clipRowSpan.AsSpirvSpan(), ..clipColOffset.AsSpirvSpan(), ..clipColSpan.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTensorViewSetClipNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef tensorView, IdRef clipRowOffset, IdRef clipRowSpan, IdRef clipColOffset, IdRef clipColSpan)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(tensorView) + buffer.GetWordLength(clipRowOffset) + buffer.GetWordLength(clipRowSpan) + buffer.GetWordLength(clipColOffset) + buffer.GetWordLength(clipColSpan);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTensorViewSetClipNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..tensorView.AsSpirvSpan(), ..clipRowOffset.AsSpirvSpan(), ..clipRowSpan.AsSpirvSpan(), ..clipColOffset.AsSpirvSpan(), ..clipColSpan.AsSpirvSpan()]);
    }

    public static Instruction AddOpTensorLayoutSetBlockSizeNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef tensorLayout, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(tensorLayout) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTensorLayoutSetBlockSizeNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..tensorLayout.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTensorLayoutSetBlockSizeNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef tensorLayout, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(tensorLayout) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTensorLayoutSetBlockSizeNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..tensorLayout.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpCooperativeMatrixTransposeNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef matrix)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(matrix);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixTransposeNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..matrix.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCooperativeMatrixTransposeNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef matrix)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(matrix);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCooperativeMatrixTransposeNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..matrix.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertUToImageNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertUToImageNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConvertUToImageNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConvertUToImageNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertUToSamplerNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertUToSamplerNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConvertUToSamplerNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConvertUToSamplerNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertImageToUNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertImageToUNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConvertImageToUNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConvertImageToUNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertSamplerToUNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertSamplerToUNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConvertSamplerToUNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConvertSamplerToUNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertUToSampledImageNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertUToSampledImageNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConvertUToSampledImageNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConvertUToSampledImageNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertSampledImageToUNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertSampledImageToUNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConvertSampledImageToUNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConvertSampledImageToUNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpSamplerImageAddressingModeNV(this SpirvBuffer buffer, LiteralInteger bitWidth)
    {
        var wordLength = 1 + buffer.GetWordLength(bitWidth);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSamplerImageAddressingModeNV, ..bitWidth.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSamplerImageAddressingModeNV(this SpirvBuffer buffer, int position, LiteralInteger bitWidth)
    {
        var wordLength = 1 + buffer.GetWordLength(bitWidth);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSamplerImageAddressingModeNV, ..bitWidth.AsSpirvSpan()]);
    }

    public static Instruction AddOpRawAccessChainNV(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef bytestride, IdRef elementindex, IdRef byteoffset, RawAccessChainOperandsMask? rawaccesschainoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(bytestride) + buffer.GetWordLength(elementindex) + buffer.GetWordLength(byteoffset) + buffer.GetWordLength(rawaccesschainoperands);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRawAccessChainNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..bytestride.AsSpirvSpan(), ..elementindex.AsSpirvSpan(), ..byteoffset.AsSpirvSpan(), ..rawaccesschainoperands.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRawAccessChainNV(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef baseId, IdRef bytestride, IdRef elementindex, IdRef byteoffset, RawAccessChainOperandsMask? rawaccesschainoperands)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(baseId) + buffer.GetWordLength(bytestride) + buffer.GetWordLength(elementindex) + buffer.GetWordLength(byteoffset) + buffer.GetWordLength(rawaccesschainoperands);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRawAccessChainNV, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..baseId.AsSpirvSpan(), ..bytestride.AsSpirvSpan(), ..elementindex.AsSpirvSpan(), ..byteoffset.AsSpirvSpan(), ..rawaccesschainoperands.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupShuffleINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef data, IdRef invocationId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(data) + buffer.GetWordLength(invocationId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupShuffleINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..data.AsSpirvSpan(), ..invocationId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupShuffleINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef data, IdRef invocationId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(data) + buffer.GetWordLength(invocationId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupShuffleINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..data.AsSpirvSpan(), ..invocationId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupShuffleDownINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef current, IdRef next, IdRef delta)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(current) + buffer.GetWordLength(next) + buffer.GetWordLength(delta);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupShuffleDownINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..current.AsSpirvSpan(), ..next.AsSpirvSpan(), ..delta.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupShuffleDownINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef current, IdRef next, IdRef delta)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(current) + buffer.GetWordLength(next) + buffer.GetWordLength(delta);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupShuffleDownINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..current.AsSpirvSpan(), ..next.AsSpirvSpan(), ..delta.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupShuffleUpINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef previous, IdRef current, IdRef delta)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(previous) + buffer.GetWordLength(current) + buffer.GetWordLength(delta);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupShuffleUpINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..previous.AsSpirvSpan(), ..current.AsSpirvSpan(), ..delta.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupShuffleUpINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef previous, IdRef current, IdRef delta)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(previous) + buffer.GetWordLength(current) + buffer.GetWordLength(delta);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupShuffleUpINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..previous.AsSpirvSpan(), ..current.AsSpirvSpan(), ..delta.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupShuffleXorINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef data, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(data) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupShuffleXorINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..data.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupShuffleXorINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef data, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(data) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupShuffleXorINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..data.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupBlockReadINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef ptr)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(ptr);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupBlockReadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..ptr.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupBlockReadINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef ptr)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(ptr);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupBlockReadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..ptr.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupBlockWriteINTEL(this SpirvBuffer buffer, IdRef ptr, IdRef data)
    {
        var wordLength = 1 + buffer.GetWordLength(ptr) + buffer.GetWordLength(data);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupBlockWriteINTEL, ..ptr.AsSpirvSpan(), ..data.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupBlockWriteINTEL(this SpirvBuffer buffer, int position, IdRef ptr, IdRef data)
    {
        var wordLength = 1 + buffer.GetWordLength(ptr) + buffer.GetWordLength(data);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupBlockWriteINTEL, ..ptr.AsSpirvSpan(), ..data.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupImageBlockReadINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupImageBlockReadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupImageBlockReadINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupImageBlockReadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupImageBlockWriteINTEL(this SpirvBuffer buffer, IdRef image, IdRef coordinate, IdRef data)
    {
        var wordLength = 1 + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(data);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupImageBlockWriteINTEL, ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..data.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupImageBlockWriteINTEL(this SpirvBuffer buffer, int position, IdRef image, IdRef coordinate, IdRef data)
    {
        var wordLength = 1 + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(data);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupImageBlockWriteINTEL, ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..data.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupImageMediaBlockReadINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, IdRef width, IdRef height)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(width) + buffer.GetWordLength(height);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupImageMediaBlockReadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..width.AsSpirvSpan(), ..height.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupImageMediaBlockReadINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef image, IdRef coordinate, IdRef width, IdRef height)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(width) + buffer.GetWordLength(height);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupImageMediaBlockReadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..width.AsSpirvSpan(), ..height.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupImageMediaBlockWriteINTEL(this SpirvBuffer buffer, IdRef image, IdRef coordinate, IdRef width, IdRef height, IdRef data)
    {
        var wordLength = 1 + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(width) + buffer.GetWordLength(height) + buffer.GetWordLength(data);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupImageMediaBlockWriteINTEL, ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..width.AsSpirvSpan(), ..height.AsSpirvSpan(), ..data.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupImageMediaBlockWriteINTEL(this SpirvBuffer buffer, int position, IdRef image, IdRef coordinate, IdRef width, IdRef height, IdRef data)
    {
        var wordLength = 1 + buffer.GetWordLength(image) + buffer.GetWordLength(coordinate) + buffer.GetWordLength(width) + buffer.GetWordLength(height) + buffer.GetWordLength(data);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupImageMediaBlockWriteINTEL, ..image.AsSpirvSpan(), ..coordinate.AsSpirvSpan(), ..width.AsSpirvSpan(), ..height.AsSpirvSpan(), ..data.AsSpirvSpan()]);
    }

    public static Instruction AddOpUCountLeadingZerosINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUCountLeadingZerosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUCountLeadingZerosINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUCountLeadingZerosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpUCountTrailingZerosINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUCountTrailingZerosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUCountTrailingZerosINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUCountTrailingZerosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand.AsSpirvSpan()]);
    }

    public static Instruction AddOpAbsISubINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAbsISubINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAbsISubINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAbsISubINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpAbsUSubINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAbsUSubINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAbsUSubINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAbsUSubINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpIAddSatINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIAddSatINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpIAddSatINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpIAddSatINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUAddSatINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUAddSatINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUAddSatINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUAddSatINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpIAverageINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIAverageINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpIAverageINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpIAverageINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUAverageINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUAverageINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUAverageINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUAverageINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpIAverageRoundedINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIAverageRoundedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpIAverageRoundedINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpIAverageRoundedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUAverageRoundedINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUAverageRoundedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUAverageRoundedINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUAverageRoundedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpISubSatINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpISubSatINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpISubSatINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpISubSatINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUSubSatINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUSubSatINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUSubSatINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUSubSatINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpIMul32x16INTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpIMul32x16INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpIMul32x16INTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpIMul32x16INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpUMul32x16INTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpUMul32x16INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpUMul32x16INTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef operand1, IdRef operand2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(operand1) + buffer.GetWordLength(operand2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpUMul32x16INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..operand1.AsSpirvSpan(), ..operand2.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantFunctionPointerINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef function)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(function);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantFunctionPointerINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..function.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConstantFunctionPointerINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef function)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(function);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConstantFunctionPointerINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..function.AsSpirvSpan()]);
    }

    public static Instruction AddOpFunctionPointerCallINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFunctionPointerCallINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFunctionPointerCallINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFunctionPointerCallINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpAsmTargetINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, LiteralString asmtarget)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(asmtarget);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAsmTargetINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..asmtarget.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAsmTargetINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, LiteralString asmtarget)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(asmtarget);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAsmTargetINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..asmtarget.AsSpirvSpan()]);
    }

    public static Instruction AddOpAsmINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef asmtype, IdRef target, LiteralString asminstructions, LiteralString constraints)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(asmtype) + buffer.GetWordLength(target) + buffer.GetWordLength(asminstructions) + buffer.GetWordLength(constraints);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAsmINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..asmtype.AsSpirvSpan(), ..target.AsSpirvSpan(), ..asminstructions.AsSpirvSpan(), ..constraints.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAsmINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef asmtype, IdRef target, LiteralString asminstructions, LiteralString constraints)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(asmtype) + buffer.GetWordLength(target) + buffer.GetWordLength(asminstructions) + buffer.GetWordLength(constraints);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAsmINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..asmtype.AsSpirvSpan(), ..target.AsSpirvSpan(), ..asminstructions.AsSpirvSpan(), ..constraints.AsSpirvSpan()]);
    }

    public static Instruction AddOpAsmCallINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef asm, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(asm) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAsmCallINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..asm.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAsmCallINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef asm, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(asm) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAsmCallINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..asm.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicFMinEXT(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicFMinEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicFMinEXT(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicFMinEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicFMaxEXT(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicFMaxEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicFMaxEXT(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicFMaxEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpAssumeTrueKHR(this SpirvBuffer buffer, IdRef condition)
    {
        var wordLength = 1 + buffer.GetWordLength(condition);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAssumeTrueKHR, ..condition.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAssumeTrueKHR(this SpirvBuffer buffer, int position, IdRef condition)
    {
        var wordLength = 1 + buffer.GetWordLength(condition);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAssumeTrueKHR, ..condition.AsSpirvSpan()]);
    }

    public static Instruction AddOpExpectKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef value, IdRef expectedValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value) + buffer.GetWordLength(expectedValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpExpectKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan(), ..expectedValue.AsSpirvSpan()]);
    }

    public static Instruction InsertOpExpectKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef value, IdRef expectedValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(value) + buffer.GetWordLength(expectedValue);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpExpectKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..value.AsSpirvSpan(), ..expectedValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpDecorateString(this SpirvBuffer buffer, IdRef target, Decoration decoration, int? additional1 = null, int? additional2 = null, string? additionalString = null)
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(decoration) + buffer.GetWordLength(additional1) + buffer.GetWordLength(additional2) + buffer.GetWordLength(additionalString);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpDecorate, target, ..decoration.AsSpirvSpan(), ..additional1.AsSpirvSpan(), ..additional2.AsSpirvSpan(), ..additionalString.AsSpirvSpan()]);
    }

    public static Instruction InsertOpDecorateString(this SpirvBuffer buffer, int position, IdRef target, Decoration decoration, int? additional1 = null, int? additional2 = null, string? additionalString = null)
    {
        var wordLength = 1 + buffer.GetWordLength(target) + buffer.GetWordLength(decoration) + buffer.GetWordLength(additional1) + buffer.GetWordLength(additional2) + buffer.GetWordLength(additionalString);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpDecorate, target, ..decoration.AsSpirvSpan(), ..additional1.AsSpirvSpan(), ..additional2.AsSpirvSpan(), ..additionalString.AsSpirvSpan()]);
    }

    public static Instruction AddOpMemberDecorateString(this SpirvBuffer buffer, IdRef structureType, LiteralInteger member, Decoration decoration, int? additional1 = null, int? additional2 = null, string? additionalString = null)
    {
        var wordLength = 1 + buffer.GetWordLength(structureType) + buffer.GetWordLength(member) + buffer.GetWordLength(decoration) + buffer.GetWordLength(additional1) + buffer.GetWordLength(additional2) + buffer.GetWordLength(additionalString);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMemberDecorate, ..structureType.AsSpirvSpan(), ..member.AsSpirvSpan(), ..decoration.AsSpirvSpan(), ..additional1.AsSpirvSpan(), ..additional2.AsSpirvSpan(), ..additionalString.AsSpirvSpan()]);
    }

    public static Instruction InsertOpMemberDecorateString(this SpirvBuffer buffer, int position, IdRef structureType, LiteralInteger member, Decoration decoration, int? additional1 = null, int? additional2 = null, string? additionalString = null)
    {
        var wordLength = 1 + buffer.GetWordLength(structureType) + buffer.GetWordLength(member) + buffer.GetWordLength(decoration) + buffer.GetWordLength(additional1) + buffer.GetWordLength(additional2) + buffer.GetWordLength(additionalString);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpMemberDecorate, ..structureType.AsSpirvSpan(), ..member.AsSpirvSpan(), ..decoration.AsSpirvSpan(), ..additional1.AsSpirvSpan(), ..additional2.AsSpirvSpan(), ..additionalString.AsSpirvSpan()]);
    }

    public static Instruction AddOpVmeImageINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef imageType, IdRef sampler)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(imageType) + buffer.GetWordLength(sampler);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpVmeImageINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..imageType.AsSpirvSpan(), ..sampler.AsSpirvSpan()]);
    }

    public static Instruction InsertOpVmeImageINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef imageType, IdRef sampler)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(imageType) + buffer.GetWordLength(sampler);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpVmeImageINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..imageType.AsSpirvSpan(), ..sampler.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeVmeImageINTEL(this SpirvBuffer buffer, IdResult resultId, IdRef imageType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(imageType);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeVmeImageINTEL, ..resultId.AsSpirvSpan(), ..imageType.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeVmeImageINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdRef imageType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(imageType);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeVmeImageINTEL, ..resultId.AsSpirvSpan(), ..imageType.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcImePayloadINTEL(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcImePayloadINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeAvcImePayloadINTEL(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeAvcImePayloadINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcRefPayloadINTEL(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcRefPayloadINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeAvcRefPayloadINTEL(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeAvcRefPayloadINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcSicPayloadINTEL(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcSicPayloadINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeAvcSicPayloadINTEL(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeAvcSicPayloadINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcMcePayloadINTEL(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcMcePayloadINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeAvcMcePayloadINTEL(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeAvcMcePayloadINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcMceResultINTEL(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcMceResultINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeAvcMceResultINTEL(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeAvcMceResultINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcImeResultINTEL(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcImeResultINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeAvcImeResultINTEL(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeAvcImeResultINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcImeResultSingleReferenceStreamoutINTEL(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcImeResultSingleReferenceStreamoutINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeAvcImeResultSingleReferenceStreamoutINTEL(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeAvcImeResultSingleReferenceStreamoutINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcImeResultDualReferenceStreamoutINTEL(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcImeResultDualReferenceStreamoutINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeAvcImeResultDualReferenceStreamoutINTEL(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeAvcImeResultDualReferenceStreamoutINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcImeSingleReferenceStreaminINTEL(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcImeSingleReferenceStreaminINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeAvcImeSingleReferenceStreaminINTEL(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeAvcImeSingleReferenceStreaminINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcImeDualReferenceStreaminINTEL(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcImeDualReferenceStreaminINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeAvcImeDualReferenceStreaminINTEL(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeAvcImeDualReferenceStreaminINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcRefResultINTEL(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcRefResultINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeAvcRefResultINTEL(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeAvcRefResultINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeAvcSicResultINTEL(this SpirvBuffer buffer, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeAvcSicResultINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeAvcSicResultINTEL(this SpirvBuffer buffer, int position, IdResult resultId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeAvcSicResultINTEL, ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef referenceBasePenalty, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(referenceBasePenalty) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..referenceBasePenalty.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef referenceBasePenalty, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(referenceBasePenalty) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..referenceBasePenalty.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceSetInterShapePenaltyINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef packedShapePenalty, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedShapePenalty) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetInterShapePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedShapePenalty.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceSetInterShapePenaltyINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef packedShapePenalty, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedShapePenalty) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetInterShapePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedShapePenalty.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceSetInterDirectionPenaltyINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef directionCost, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(directionCost) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetInterDirectionPenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..directionCost.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceSetInterDirectionPenaltyINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef directionCost, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(directionCost) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetInterDirectionPenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..directionCost.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceSetMotionVectorCostFunctionINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef packedCostCenterDelta, IdRef packedCostTable, IdRef costPrecision, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedCostCenterDelta) + buffer.GetWordLength(packedCostTable) + buffer.GetWordLength(costPrecision) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedCostCenterDelta.AsSpirvSpan(), ..packedCostTable.AsSpirvSpan(), ..costPrecision.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceSetMotionVectorCostFunctionINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef packedCostCenterDelta, IdRef packedCostTable, IdRef costPrecision, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedCostCenterDelta) + buffer.GetWordLength(packedCostTable) + buffer.GetWordLength(costPrecision) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedCostCenterDelta.AsSpirvSpan(), ..packedCostTable.AsSpirvSpan(), ..costPrecision.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sliceType, IdRef qp)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sliceType) + buffer.GetWordLength(qp);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sliceType.AsSpirvSpan(), ..qp.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceSetAcOnlyHaarINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetAcOnlyHaarINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceSetAcOnlyHaarINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetAcOnlyHaarINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef sourceFieldPolarity, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sourceFieldPolarity) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sourceFieldPolarity.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef sourceFieldPolarity, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(sourceFieldPolarity) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..sourceFieldPolarity.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef referenceFieldPolarity, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(referenceFieldPolarity) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..referenceFieldPolarity.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef referenceFieldPolarity, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(referenceFieldPolarity) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..referenceFieldPolarity.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef forwardReferenceFieldPolarity, IdRef backwardReferenceFieldPolarity, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(forwardReferenceFieldPolarity) + buffer.GetWordLength(backwardReferenceFieldPolarity) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..forwardReferenceFieldPolarity.AsSpirvSpan(), ..backwardReferenceFieldPolarity.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef forwardReferenceFieldPolarity, IdRef backwardReferenceFieldPolarity, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(forwardReferenceFieldPolarity) + buffer.GetWordLength(backwardReferenceFieldPolarity) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..forwardReferenceFieldPolarity.AsSpirvSpan(), ..backwardReferenceFieldPolarity.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceConvertToImePayloadINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToImePayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceConvertToImePayloadINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToImePayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceConvertToImeResultINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToImeResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceConvertToImeResultINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToImeResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceConvertToRefPayloadINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToRefPayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceConvertToRefPayloadINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToRefPayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceConvertToRefResultINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToRefResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceConvertToRefResultINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToRefResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceConvertToSicPayloadINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToSicPayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceConvertToSicPayloadINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToSicPayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceConvertToSicResultINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToSicResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceConvertToSicResultINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceConvertToSicResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetMotionVectorsINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetMotionVectorsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetMotionVectorsINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetMotionVectorsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetInterDistortionsINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterDistortionsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetInterDistortionsINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterDistortionsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetBestInterDistortionsINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetBestInterDistortionsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetBestInterDistortionsINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetBestInterDistortionsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetInterMajorShapeINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterMajorShapeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetInterMajorShapeINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterMajorShapeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetInterMinorShapeINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterMinorShapeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetInterMinorShapeINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterMinorShapeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetInterDirectionsINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterDirectionsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetInterDirectionsINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterDirectionsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetInterMotionVectorCountINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterMotionVectorCountINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetInterMotionVectorCountINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterMotionVectorCountINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetInterReferenceIdsINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterReferenceIdsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetInterReferenceIdsINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterReferenceIdsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef packedReferenceIds, IdRef packedReferenceParameterFieldPolarities, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedReferenceIds) + buffer.GetWordLength(packedReferenceParameterFieldPolarities) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedReferenceIds.AsSpirvSpan(), ..packedReferenceParameterFieldPolarities.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef packedReferenceIds, IdRef packedReferenceParameterFieldPolarities, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedReferenceIds) + buffer.GetWordLength(packedReferenceParameterFieldPolarities) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedReferenceIds.AsSpirvSpan(), ..packedReferenceParameterFieldPolarities.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeInitializeINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcCoord, IdRef partitionMask, IdRef sADAdjustment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcCoord) + buffer.GetWordLength(partitionMask) + buffer.GetWordLength(sADAdjustment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeInitializeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcCoord.AsSpirvSpan(), ..partitionMask.AsSpirvSpan(), ..sADAdjustment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeInitializeINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcCoord, IdRef partitionMask, IdRef sADAdjustment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcCoord) + buffer.GetWordLength(partitionMask) + buffer.GetWordLength(sADAdjustment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeInitializeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcCoord.AsSpirvSpan(), ..partitionMask.AsSpirvSpan(), ..sADAdjustment.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeSetSingleReferenceINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef refOffset, IdRef searchWindowConfig, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(refOffset) + buffer.GetWordLength(searchWindowConfig) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetSingleReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..refOffset.AsSpirvSpan(), ..searchWindowConfig.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeSetSingleReferenceINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef refOffset, IdRef searchWindowConfig, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(refOffset) + buffer.GetWordLength(searchWindowConfig) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetSingleReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..refOffset.AsSpirvSpan(), ..searchWindowConfig.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeSetDualReferenceINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef fwdRefOffset, IdRef bwdRefOffset, IdRef idSearchWindowConfig, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(fwdRefOffset) + buffer.GetWordLength(bwdRefOffset) + buffer.GetWordLength(idSearchWindowConfig) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetDualReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..fwdRefOffset.AsSpirvSpan(), ..bwdRefOffset.AsSpirvSpan(), ..idSearchWindowConfig.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeSetDualReferenceINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef fwdRefOffset, IdRef bwdRefOffset, IdRef idSearchWindowConfig, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(fwdRefOffset) + buffer.GetWordLength(bwdRefOffset) + buffer.GetWordLength(idSearchWindowConfig) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetDualReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..fwdRefOffset.AsSpirvSpan(), ..bwdRefOffset.AsSpirvSpan(), ..idSearchWindowConfig.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeRefWindowSizeINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef searchWindowConfig, IdRef dualRef)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(searchWindowConfig) + buffer.GetWordLength(dualRef);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeRefWindowSizeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..searchWindowConfig.AsSpirvSpan(), ..dualRef.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeRefWindowSizeINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef searchWindowConfig, IdRef dualRef)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(searchWindowConfig) + buffer.GetWordLength(dualRef);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeRefWindowSizeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..searchWindowConfig.AsSpirvSpan(), ..dualRef.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeAdjustRefOffsetINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef refOffset, IdRef srcCoord, IdRef refWindowSize, IdRef imageSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(refOffset) + buffer.GetWordLength(srcCoord) + buffer.GetWordLength(refWindowSize) + buffer.GetWordLength(imageSize);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeAdjustRefOffsetINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..refOffset.AsSpirvSpan(), ..srcCoord.AsSpirvSpan(), ..refWindowSize.AsSpirvSpan(), ..imageSize.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeAdjustRefOffsetINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef refOffset, IdRef srcCoord, IdRef refWindowSize, IdRef imageSize)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(refOffset) + buffer.GetWordLength(srcCoord) + buffer.GetWordLength(refWindowSize) + buffer.GetWordLength(imageSize);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeAdjustRefOffsetINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..refOffset.AsSpirvSpan(), ..srcCoord.AsSpirvSpan(), ..refWindowSize.AsSpirvSpan(), ..imageSize.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeConvertToMcePayloadINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeConvertToMcePayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeConvertToMcePayloadINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeConvertToMcePayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeSetMaxMotionVectorCountINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef maxMotionVectorCount, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(maxMotionVectorCount) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetMaxMotionVectorCountINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..maxMotionVectorCount.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeSetMaxMotionVectorCountINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef maxMotionVectorCount, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(maxMotionVectorCount) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetMaxMotionVectorCountINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..maxMotionVectorCount.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeSetUnidirectionalMixDisableINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeSetUnidirectionalMixDisableINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef threshold, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(threshold) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..threshold.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef threshold, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(threshold) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..threshold.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeSetWeightedSadINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef packedSadWeights, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedSadWeights) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetWeightedSadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedSadWeights.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeSetWeightedSadINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef packedSadWeights, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedSadWeights) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeSetWeightedSadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedSadWeights.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeEvaluateWithSingleReferenceINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeEvaluateWithSingleReferenceINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeEvaluateWithDualReferenceINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithDualReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeEvaluateWithDualReferenceINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithDualReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload, IdRef streaminComponents)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload) + buffer.GetWordLength(streaminComponents);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..streaminComponents.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload, IdRef streaminComponents)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload) + buffer.GetWordLength(streaminComponents);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..streaminComponents.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload, IdRef streaminComponents)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload) + buffer.GetWordLength(streaminComponents);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..streaminComponents.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload, IdRef streaminComponents)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload) + buffer.GetWordLength(streaminComponents);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..streaminComponents.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload, IdRef streaminComponents)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload) + buffer.GetWordLength(streaminComponents);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..streaminComponents.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload, IdRef streaminComponents)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload) + buffer.GetWordLength(streaminComponents);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..streaminComponents.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload, IdRef streaminComponents)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload) + buffer.GetWordLength(streaminComponents);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..streaminComponents.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload, IdRef streaminComponents)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload) + buffer.GetWordLength(streaminComponents);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..streaminComponents.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeConvertToMceResultINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeConvertToMceResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeConvertToMceResultINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeConvertToMceResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetSingleReferenceStreaminINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetSingleReferenceStreaminINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeGetSingleReferenceStreaminINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetSingleReferenceStreaminINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetDualReferenceStreaminINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetDualReferenceStreaminINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeGetDualReferenceStreaminINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetDualReferenceStreaminINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeStripSingleReferenceStreamoutINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeStripSingleReferenceStreamoutINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeStripDualReferenceStreamoutINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeStripDualReferenceStreamoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeStripDualReferenceStreamoutINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeStripDualReferenceStreamoutINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape, IdRef direction)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape) + buffer.GetWordLength(direction);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan(), ..direction.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape, IdRef direction)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape) + buffer.GetWordLength(direction);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan(), ..direction.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape, IdRef direction)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape) + buffer.GetWordLength(direction);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan(), ..direction.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape, IdRef direction)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape) + buffer.GetWordLength(direction);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan(), ..direction.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape, IdRef direction)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape) + buffer.GetWordLength(direction);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan(), ..direction.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload, IdRef majorShape, IdRef direction)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload) + buffer.GetWordLength(majorShape) + buffer.GetWordLength(direction);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan(), ..majorShape.AsSpirvSpan(), ..direction.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetBorderReachedINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef imageSelect, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(imageSelect) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetBorderReachedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..imageSelect.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeGetBorderReachedINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef imageSelect, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(imageSelect) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetBorderReachedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..imageSelect.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetTruncatedSearchIndicationINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeGetTruncatedSearchIndicationINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcFmeInitializeINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcCoord, IdRef motionVectors, IdRef majorShapes, IdRef minorShapes, IdRef direction, IdRef pixelResolution, IdRef sadAdjustment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcCoord) + buffer.GetWordLength(motionVectors) + buffer.GetWordLength(majorShapes) + buffer.GetWordLength(minorShapes) + buffer.GetWordLength(direction) + buffer.GetWordLength(pixelResolution) + buffer.GetWordLength(sadAdjustment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcFmeInitializeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcCoord.AsSpirvSpan(), ..motionVectors.AsSpirvSpan(), ..majorShapes.AsSpirvSpan(), ..minorShapes.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..pixelResolution.AsSpirvSpan(), ..sadAdjustment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcFmeInitializeINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcCoord, IdRef motionVectors, IdRef majorShapes, IdRef minorShapes, IdRef direction, IdRef pixelResolution, IdRef sadAdjustment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcCoord) + buffer.GetWordLength(motionVectors) + buffer.GetWordLength(majorShapes) + buffer.GetWordLength(minorShapes) + buffer.GetWordLength(direction) + buffer.GetWordLength(pixelResolution) + buffer.GetWordLength(sadAdjustment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcFmeInitializeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcCoord.AsSpirvSpan(), ..motionVectors.AsSpirvSpan(), ..majorShapes.AsSpirvSpan(), ..minorShapes.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..pixelResolution.AsSpirvSpan(), ..sadAdjustment.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcBmeInitializeINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcCoord, IdRef motionVectors, IdRef majorShapes, IdRef minorShapes, IdRef direction, IdRef pixelResolution, IdRef bidirectionalWeight, IdRef sadAdjustment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcCoord) + buffer.GetWordLength(motionVectors) + buffer.GetWordLength(majorShapes) + buffer.GetWordLength(minorShapes) + buffer.GetWordLength(direction) + buffer.GetWordLength(pixelResolution) + buffer.GetWordLength(bidirectionalWeight) + buffer.GetWordLength(sadAdjustment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcBmeInitializeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcCoord.AsSpirvSpan(), ..motionVectors.AsSpirvSpan(), ..majorShapes.AsSpirvSpan(), ..minorShapes.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..pixelResolution.AsSpirvSpan(), ..bidirectionalWeight.AsSpirvSpan(), ..sadAdjustment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcBmeInitializeINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcCoord, IdRef motionVectors, IdRef majorShapes, IdRef minorShapes, IdRef direction, IdRef pixelResolution, IdRef bidirectionalWeight, IdRef sadAdjustment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcCoord) + buffer.GetWordLength(motionVectors) + buffer.GetWordLength(majorShapes) + buffer.GetWordLength(minorShapes) + buffer.GetWordLength(direction) + buffer.GetWordLength(pixelResolution) + buffer.GetWordLength(bidirectionalWeight) + buffer.GetWordLength(sadAdjustment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcBmeInitializeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcCoord.AsSpirvSpan(), ..motionVectors.AsSpirvSpan(), ..majorShapes.AsSpirvSpan(), ..minorShapes.AsSpirvSpan(), ..direction.AsSpirvSpan(), ..pixelResolution.AsSpirvSpan(), ..bidirectionalWeight.AsSpirvSpan(), ..sadAdjustment.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcRefConvertToMcePayloadINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefConvertToMcePayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcRefConvertToMcePayloadINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefConvertToMcePayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcRefSetBidirectionalMixDisableINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefSetBidirectionalMixDisableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcRefSetBidirectionalMixDisableINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefSetBidirectionalMixDisableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcRefSetBilinearFilterEnableINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefSetBilinearFilterEnableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcRefSetBilinearFilterEnableINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefSetBilinearFilterEnableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcRefEvaluateWithSingleReferenceINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcRefEvaluateWithSingleReferenceINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcRefEvaluateWithDualReferenceINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefEvaluateWithDualReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcRefEvaluateWithDualReferenceINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefEvaluateWithDualReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcRefEvaluateWithMultiReferenceINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef packedReferenceIds, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(packedReferenceIds) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..packedReferenceIds.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcRefEvaluateWithMultiReferenceINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef packedReferenceIds, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(packedReferenceIds) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..packedReferenceIds.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef packedReferenceIds, IdRef packedReferenceFieldPolarities, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(packedReferenceIds) + buffer.GetWordLength(packedReferenceFieldPolarities) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..packedReferenceIds.AsSpirvSpan(), ..packedReferenceFieldPolarities.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef packedReferenceIds, IdRef packedReferenceFieldPolarities, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(packedReferenceIds) + buffer.GetWordLength(packedReferenceFieldPolarities) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..packedReferenceIds.AsSpirvSpan(), ..packedReferenceFieldPolarities.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcRefConvertToMceResultINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefConvertToMceResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcRefConvertToMceResultINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcRefConvertToMceResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicInitializeINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcCoord)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcCoord);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicInitializeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcCoord.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicInitializeINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcCoord)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcCoord);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicInitializeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcCoord.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicConfigureSkcINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef skipBlockPartitionType, IdRef skipMotionVectorMask, IdRef motionVectors, IdRef bidirectionalWeight, IdRef sadAdjustment, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(skipBlockPartitionType) + buffer.GetWordLength(skipMotionVectorMask) + buffer.GetWordLength(motionVectors) + buffer.GetWordLength(bidirectionalWeight) + buffer.GetWordLength(sadAdjustment) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicConfigureSkcINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..skipBlockPartitionType.AsSpirvSpan(), ..skipMotionVectorMask.AsSpirvSpan(), ..motionVectors.AsSpirvSpan(), ..bidirectionalWeight.AsSpirvSpan(), ..sadAdjustment.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicConfigureSkcINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef skipBlockPartitionType, IdRef skipMotionVectorMask, IdRef motionVectors, IdRef bidirectionalWeight, IdRef sadAdjustment, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(skipBlockPartitionType) + buffer.GetWordLength(skipMotionVectorMask) + buffer.GetWordLength(motionVectors) + buffer.GetWordLength(bidirectionalWeight) + buffer.GetWordLength(sadAdjustment) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicConfigureSkcINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..skipBlockPartitionType.AsSpirvSpan(), ..skipMotionVectorMask.AsSpirvSpan(), ..motionVectors.AsSpirvSpan(), ..bidirectionalWeight.AsSpirvSpan(), ..sadAdjustment.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicConfigureIpeLumaINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef lumaIntraPartitionMask, IdRef intraNeighbourAvailabilty, IdRef leftEdgeLumaPixels, IdRef upperLeftCornerLumaPixel, IdRef upperEdgeLumaPixels, IdRef upperRightEdgeLumaPixels, IdRef sadAdjustment, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(lumaIntraPartitionMask) + buffer.GetWordLength(intraNeighbourAvailabilty) + buffer.GetWordLength(leftEdgeLumaPixels) + buffer.GetWordLength(upperLeftCornerLumaPixel) + buffer.GetWordLength(upperEdgeLumaPixels) + buffer.GetWordLength(upperRightEdgeLumaPixels) + buffer.GetWordLength(sadAdjustment) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicConfigureIpeLumaINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..lumaIntraPartitionMask.AsSpirvSpan(), ..intraNeighbourAvailabilty.AsSpirvSpan(), ..leftEdgeLumaPixels.AsSpirvSpan(), ..upperLeftCornerLumaPixel.AsSpirvSpan(), ..upperEdgeLumaPixels.AsSpirvSpan(), ..upperRightEdgeLumaPixels.AsSpirvSpan(), ..sadAdjustment.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicConfigureIpeLumaINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef lumaIntraPartitionMask, IdRef intraNeighbourAvailabilty, IdRef leftEdgeLumaPixels, IdRef upperLeftCornerLumaPixel, IdRef upperEdgeLumaPixels, IdRef upperRightEdgeLumaPixels, IdRef sadAdjustment, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(lumaIntraPartitionMask) + buffer.GetWordLength(intraNeighbourAvailabilty) + buffer.GetWordLength(leftEdgeLumaPixels) + buffer.GetWordLength(upperLeftCornerLumaPixel) + buffer.GetWordLength(upperEdgeLumaPixels) + buffer.GetWordLength(upperRightEdgeLumaPixels) + buffer.GetWordLength(sadAdjustment) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicConfigureIpeLumaINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..lumaIntraPartitionMask.AsSpirvSpan(), ..intraNeighbourAvailabilty.AsSpirvSpan(), ..leftEdgeLumaPixels.AsSpirvSpan(), ..upperLeftCornerLumaPixel.AsSpirvSpan(), ..upperEdgeLumaPixels.AsSpirvSpan(), ..upperRightEdgeLumaPixels.AsSpirvSpan(), ..sadAdjustment.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicConfigureIpeLumaChromaINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef lumaIntraPartitionMask, IdRef intraNeighbourAvailabilty, IdRef leftEdgeLumaPixels, IdRef upperLeftCornerLumaPixel, IdRef upperEdgeLumaPixels, IdRef upperRightEdgeLumaPixels, IdRef leftEdgeChromaPixels, IdRef upperLeftCornerChromaPixel, IdRef upperEdgeChromaPixels, IdRef sadAdjustment, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(lumaIntraPartitionMask) + buffer.GetWordLength(intraNeighbourAvailabilty) + buffer.GetWordLength(leftEdgeLumaPixels) + buffer.GetWordLength(upperLeftCornerLumaPixel) + buffer.GetWordLength(upperEdgeLumaPixels) + buffer.GetWordLength(upperRightEdgeLumaPixels) + buffer.GetWordLength(leftEdgeChromaPixels) + buffer.GetWordLength(upperLeftCornerChromaPixel) + buffer.GetWordLength(upperEdgeChromaPixels) + buffer.GetWordLength(sadAdjustment) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicConfigureIpeLumaChromaINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..lumaIntraPartitionMask.AsSpirvSpan(), ..intraNeighbourAvailabilty.AsSpirvSpan(), ..leftEdgeLumaPixels.AsSpirvSpan(), ..upperLeftCornerLumaPixel.AsSpirvSpan(), ..upperEdgeLumaPixels.AsSpirvSpan(), ..upperRightEdgeLumaPixels.AsSpirvSpan(), ..leftEdgeChromaPixels.AsSpirvSpan(), ..upperLeftCornerChromaPixel.AsSpirvSpan(), ..upperEdgeChromaPixels.AsSpirvSpan(), ..sadAdjustment.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicConfigureIpeLumaChromaINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef lumaIntraPartitionMask, IdRef intraNeighbourAvailabilty, IdRef leftEdgeLumaPixels, IdRef upperLeftCornerLumaPixel, IdRef upperEdgeLumaPixels, IdRef upperRightEdgeLumaPixels, IdRef leftEdgeChromaPixels, IdRef upperLeftCornerChromaPixel, IdRef upperEdgeChromaPixels, IdRef sadAdjustment, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(lumaIntraPartitionMask) + buffer.GetWordLength(intraNeighbourAvailabilty) + buffer.GetWordLength(leftEdgeLumaPixels) + buffer.GetWordLength(upperLeftCornerLumaPixel) + buffer.GetWordLength(upperEdgeLumaPixels) + buffer.GetWordLength(upperRightEdgeLumaPixels) + buffer.GetWordLength(leftEdgeChromaPixels) + buffer.GetWordLength(upperLeftCornerChromaPixel) + buffer.GetWordLength(upperEdgeChromaPixels) + buffer.GetWordLength(sadAdjustment) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicConfigureIpeLumaChromaINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..lumaIntraPartitionMask.AsSpirvSpan(), ..intraNeighbourAvailabilty.AsSpirvSpan(), ..leftEdgeLumaPixels.AsSpirvSpan(), ..upperLeftCornerLumaPixel.AsSpirvSpan(), ..upperEdgeLumaPixels.AsSpirvSpan(), ..upperRightEdgeLumaPixels.AsSpirvSpan(), ..leftEdgeChromaPixels.AsSpirvSpan(), ..upperLeftCornerChromaPixel.AsSpirvSpan(), ..upperEdgeChromaPixels.AsSpirvSpan(), ..sadAdjustment.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetMotionVectorMaskINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef skipBlockPartitionType, IdRef direction)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(skipBlockPartitionType) + buffer.GetWordLength(direction);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetMotionVectorMaskINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..skipBlockPartitionType.AsSpirvSpan(), ..direction.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicGetMotionVectorMaskINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef skipBlockPartitionType, IdRef direction)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(skipBlockPartitionType) + buffer.GetWordLength(direction);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetMotionVectorMaskINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..skipBlockPartitionType.AsSpirvSpan(), ..direction.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicConvertToMcePayloadINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicConvertToMcePayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicConvertToMcePayloadINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicConvertToMcePayloadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef packedShapePenalty, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedShapePenalty) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedShapePenalty.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef packedShapePenalty, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedShapePenalty) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedShapePenalty.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef lumaModePenalty, IdRef lumaPackedNeighborModes, IdRef lumaPackedNonDcPenalty, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(lumaModePenalty) + buffer.GetWordLength(lumaPackedNeighborModes) + buffer.GetWordLength(lumaPackedNonDcPenalty) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..lumaModePenalty.AsSpirvSpan(), ..lumaPackedNeighborModes.AsSpirvSpan(), ..lumaPackedNonDcPenalty.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef lumaModePenalty, IdRef lumaPackedNeighborModes, IdRef lumaPackedNonDcPenalty, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(lumaModePenalty) + buffer.GetWordLength(lumaPackedNeighborModes) + buffer.GetWordLength(lumaPackedNonDcPenalty) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..lumaModePenalty.AsSpirvSpan(), ..lumaPackedNeighborModes.AsSpirvSpan(), ..lumaPackedNonDcPenalty.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef chromaModeBasePenalty, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(chromaModeBasePenalty) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..chromaModeBasePenalty.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef chromaModeBasePenalty, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(chromaModeBasePenalty) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..chromaModeBasePenalty.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicSetBilinearFilterEnableINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetBilinearFilterEnableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicSetBilinearFilterEnableINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetBilinearFilterEnableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicSetSkcForwardTransformEnableINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef packedSadCoefficients, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedSadCoefficients) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedSadCoefficients.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicSetSkcForwardTransformEnableINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef packedSadCoefficients, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packedSadCoefficients) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packedSadCoefficients.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef blockBasedSkipType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(blockBasedSkipType) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..blockBasedSkipType.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef blockBasedSkipType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(blockBasedSkipType) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..blockBasedSkipType.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicEvaluateIpeINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicEvaluateIpeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicEvaluateIpeINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicEvaluateIpeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicEvaluateWithSingleReferenceINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicEvaluateWithSingleReferenceINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef refImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(refImage) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..refImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicEvaluateWithDualReferenceINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicEvaluateWithDualReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicEvaluateWithDualReferenceINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef fwdRefImage, IdRef bwdRefImage, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(fwdRefImage) + buffer.GetWordLength(bwdRefImage) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicEvaluateWithDualReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..fwdRefImage.AsSpirvSpan(), ..bwdRefImage.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicEvaluateWithMultiReferenceINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef packedReferenceIds, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(packedReferenceIds) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..packedReferenceIds.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicEvaluateWithMultiReferenceINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef packedReferenceIds, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(packedReferenceIds) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..packedReferenceIds.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef packedReferenceIds, IdRef packedReferenceFieldPolarities, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(packedReferenceIds) + buffer.GetWordLength(packedReferenceFieldPolarities) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..packedReferenceIds.AsSpirvSpan(), ..packedReferenceFieldPolarities.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef srcImage, IdRef packedReferenceIds, IdRef packedReferenceFieldPolarities, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(srcImage) + buffer.GetWordLength(packedReferenceIds) + buffer.GetWordLength(packedReferenceFieldPolarities) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..srcImage.AsSpirvSpan(), ..packedReferenceIds.AsSpirvSpan(), ..packedReferenceFieldPolarities.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicConvertToMceResultINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicConvertToMceResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicConvertToMceResultINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicConvertToMceResultINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetIpeLumaShapeINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetIpeLumaShapeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicGetIpeLumaShapeINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetIpeLumaShapeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetBestIpeLumaDistortionINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicGetBestIpeLumaDistortionINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetBestIpeChromaDistortionINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicGetBestIpeChromaDistortionINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetPackedIpeLumaModesINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetPackedIpeLumaModesINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicGetPackedIpeLumaModesINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetPackedIpeLumaModesINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetIpeChromaModeINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetIpeChromaModeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicGetIpeChromaModeINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetIpeChromaModeINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupAvcSicGetInterRawSadsINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetInterRawSadsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupAvcSicGetInterRawSadsINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef payload)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(payload);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupAvcSicGetInterRawSadsINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..payload.AsSpirvSpan()]);
    }

    public static Instruction AddOpVariableLengthArrayINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef lenght)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(lenght);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpVariableLengthArrayINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..lenght.AsSpirvSpan()]);
    }

    public static Instruction InsertOpVariableLengthArrayINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef lenght)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(lenght);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpVariableLengthArrayINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..lenght.AsSpirvSpan()]);
    }

    public static Instruction AddOpSaveMemoryINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSaveMemoryINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSaveMemoryINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSaveMemoryINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan()]);
    }

    public static Instruction AddOpRestoreMemoryINTEL(this SpirvBuffer buffer, IdRef ptr)
    {
        var wordLength = 1 + buffer.GetWordLength(ptr);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRestoreMemoryINTEL, ..ptr.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRestoreMemoryINTEL(this SpirvBuffer buffer, int position, IdRef ptr)
    {
        var wordLength = 1 + buffer.GetWordLength(ptr);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRestoreMemoryINTEL, ..ptr.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatSinCosPiINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger fromSign, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(fromSign) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSinCosPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..fromSign.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatSinCosPiINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger fromSign, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(fromSign) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSinCosPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..fromSign.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatCastINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCastINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatCastINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCastINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatCastFromIntINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger mout, LiteralInteger fromSign, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(mout) + buffer.GetWordLength(fromSign) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCastFromIntINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..fromSign.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatCastFromIntINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger mout, LiteralInteger fromSign, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(mout) + buffer.GetWordLength(fromSign) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCastFromIntINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..fromSign.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatCastToIntINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCastToIntINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatCastToIntINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCastToIntINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatAddINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatAddINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatAddINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatAddINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatSubINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSubINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatSubINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSubINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatMulINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatMulINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatMulINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatMulINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatDivINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatDivINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatDivINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatDivINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatGTINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatGTINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatGTINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatGTINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatGEINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatGEINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatGEINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatGEINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatLTINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLTINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatLTINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLTINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatLEINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLEINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatLEINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLEINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatEQINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatEQINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatEQINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatEQINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatRecipINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatRecipINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatRecipINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatRecipINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatRSqrtINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatRSqrtINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatRSqrtINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatRSqrtINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatCbrtINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCbrtINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatCbrtINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCbrtINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatHypotINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatHypotINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatHypotINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatHypotINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatSqrtINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSqrtINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatSqrtINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSqrtINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatLogINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLogINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatLogINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLogINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatLog2INTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLog2INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatLog2INTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLog2INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatLog10INTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLog10INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatLog10INTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLog10INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatLog1pINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLog1pINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatLog1pINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatLog1pINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatExpINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatExpINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatExpINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatExpINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatExp2INTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatExp2INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatExp2INTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatExp2INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatExp10INTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatExp10INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatExp10INTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatExp10INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatExpm1INTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatExpm1INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatExpm1INTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatExpm1INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatSinINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSinINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatSinINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSinINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatCosINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatCosINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatSinCosINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSinCosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatSinCosINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSinCosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatSinPiINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSinPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatSinPiINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatSinPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatCosPiINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCosPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatCosPiINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatCosPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatASinINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatASinINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatASinINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatASinINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatASinPiINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatASinPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatASinPiINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatASinPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatACosINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatACosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatACosINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatACosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatACosPiINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatACosPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatACosPiINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatACosPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatATanINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatATanINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatATanINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatATanINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatATanPiINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatATanPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatATanPiINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatATanPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatATan2INTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatATan2INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatATan2INTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatATan2INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatPowINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatPowINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatPowINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatPowINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatPowRINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatPowRINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatPowRINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger m2, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(m2) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatPowRINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..m2.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpArbitraryFloatPowNINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArbitraryFloatPowNINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArbitraryFloatPowNINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef a, LiteralInteger m1, IdRef b, LiteralInteger mout, LiteralInteger enableSubnormals, LiteralInteger roundingMode, LiteralInteger roundingAccuracy)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(a) + buffer.GetWordLength(m1) + buffer.GetWordLength(b) + buffer.GetWordLength(mout) + buffer.GetWordLength(enableSubnormals) + buffer.GetWordLength(roundingMode) + buffer.GetWordLength(roundingAccuracy);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArbitraryFloatPowNINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..a.AsSpirvSpan(), ..m1.AsSpirvSpan(), ..b.AsSpirvSpan(), ..mout.AsSpirvSpan(), ..enableSubnormals.AsSpirvSpan(), ..roundingMode.AsSpirvSpan(), ..roundingAccuracy.AsSpirvSpan()]);
    }

    public static Instruction AddOpLoopControlINTEL(this SpirvBuffer buffer, Span<LiteralInteger> values)
    {
        var wordLength = 1 + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpLoopControlINTEL, ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpLoopControlINTEL(this SpirvBuffer buffer, int position, Span<LiteralInteger> values)
    {
        var wordLength = 1 + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpLoopControlINTEL, ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpAliasDomainDeclINTEL(this SpirvBuffer buffer, IdResult resultId, IdRef? name)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(name);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAliasDomainDeclINTEL, ..resultId.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAliasDomainDeclINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdRef? name)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(name);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAliasDomainDeclINTEL, ..resultId.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction AddOpAliasScopeDeclINTEL(this SpirvBuffer buffer, IdResult resultId, IdRef aliasDomain, IdRef? name)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(aliasDomain) + buffer.GetWordLength(name);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAliasScopeDeclINTEL, ..resultId.AsSpirvSpan(), ..aliasDomain.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAliasScopeDeclINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdRef aliasDomain, IdRef? name)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(aliasDomain) + buffer.GetWordLength(name);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAliasScopeDeclINTEL, ..resultId.AsSpirvSpan(), ..aliasDomain.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction AddOpAliasScopeListDeclINTEL(this SpirvBuffer buffer, IdResult resultId, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAliasScopeListDeclINTEL, ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAliasScopeListDeclINTEL(this SpirvBuffer buffer, int position, IdResult resultId, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAliasScopeListDeclINTEL, ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedSqrtINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedSqrtINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFixedSqrtINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFixedSqrtINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedRecipINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedRecipINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFixedRecipINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFixedRecipINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedRsqrtINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedRsqrtINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFixedRsqrtINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFixedRsqrtINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedSinINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedSinINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFixedSinINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFixedSinINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedCosINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedCosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFixedCosINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFixedCosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedSinCosINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedSinCosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFixedSinCosINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFixedSinCosINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedSinPiINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedSinPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFixedSinPiINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFixedSinPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedCosPiINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedCosPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFixedCosPiINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFixedCosPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedSinCosPiINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedSinCosPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFixedSinCosPiINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFixedSinCosPiINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedLogINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedLogINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFixedLogINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFixedLogINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpFixedExpINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFixedExpINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFixedExpINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef inputType, IdRef input, LiteralInteger s, LiteralInteger i, LiteralInteger rI, LiteralInteger q, LiteralInteger o)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(inputType) + buffer.GetWordLength(input) + buffer.GetWordLength(s) + buffer.GetWordLength(i) + buffer.GetWordLength(rI) + buffer.GetWordLength(q) + buffer.GetWordLength(o);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFixedExpINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..inputType.AsSpirvSpan(), ..input.AsSpirvSpan(), ..s.AsSpirvSpan(), ..i.AsSpirvSpan(), ..rI.AsSpirvSpan(), ..q.AsSpirvSpan(), ..o.AsSpirvSpan()]);
    }

    public static Instruction AddOpPtrCastToCrossWorkgroupINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpPtrCastToCrossWorkgroupINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction InsertOpPtrCastToCrossWorkgroupINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpPtrCastToCrossWorkgroupINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction AddOpCrossWorkgroupCastToPtrINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCrossWorkgroupCastToPtrINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCrossWorkgroupCastToPtrINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCrossWorkgroupCastToPtrINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan()]);
    }

    public static Instruction AddOpReadPipeBlockingINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpReadPipeBlockingINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpReadPipeBlockingINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpReadPipeBlockingINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpWritePipeBlockingINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpWritePipeBlockingINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction InsertOpWritePipeBlockingINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef packetSize, IdRef packetAlignment)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(packetSize) + buffer.GetWordLength(packetAlignment);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpWritePipeBlockingINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..packetSize.AsSpirvSpan(), ..packetAlignment.AsSpirvSpan()]);
    }

    public static Instruction AddOpFPGARegINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef result, IdRef input)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(result) + buffer.GetWordLength(input);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpFPGARegINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..result.AsSpirvSpan(), ..input.AsSpirvSpan()]);
    }

    public static Instruction InsertOpFPGARegINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef result, IdRef input)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(result) + buffer.GetWordLength(input);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpFPGARegINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..result.AsSpirvSpan(), ..input.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetRayTMinKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetRayTMinKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetRayTMinKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetRayTMinKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetRayFlagsKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetRayFlagsKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetRayFlagsKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetRayFlagsKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionTKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionTKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetIntersectionTKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionTKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionInstanceCustomIndexKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionInstanceCustomIndexKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetIntersectionInstanceCustomIndexKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionInstanceCustomIndexKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionInstanceIdKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionInstanceIdKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetIntersectionInstanceIdKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionInstanceIdKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionGeometryIndexKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionGeometryIndexKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetIntersectionGeometryIndexKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionGeometryIndexKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionPrimitiveIndexKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionPrimitiveIndexKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetIntersectionPrimitiveIndexKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionPrimitiveIndexKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionBarycentricsKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionBarycentricsKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetIntersectionBarycentricsKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionBarycentricsKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionFrontFaceKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionFrontFaceKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetIntersectionFrontFaceKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionFrontFaceKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionCandidateAABBOpaqueKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionCandidateAABBOpaqueKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetIntersectionCandidateAABBOpaqueKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionCandidateAABBOpaqueKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionObjectRayDirectionKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionObjectRayDirectionKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetIntersectionObjectRayDirectionKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionObjectRayDirectionKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionObjectRayOriginKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionObjectRayOriginKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetIntersectionObjectRayOriginKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionObjectRayOriginKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetWorldRayDirectionKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetWorldRayDirectionKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetWorldRayDirectionKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetWorldRayDirectionKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetWorldRayOriginKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetWorldRayOriginKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetWorldRayOriginKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetWorldRayOriginKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionObjectToWorldKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionObjectToWorldKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetIntersectionObjectToWorldKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionObjectToWorldKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpRayQueryGetIntersectionWorldToObjectKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionWorldToObjectKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction InsertOpRayQueryGetIntersectionWorldToObjectKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef rayQuery, IdRef intersection)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(rayQuery) + buffer.GetWordLength(intersection);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpRayQueryGetIntersectionWorldToObjectKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..rayQuery.AsSpirvSpan(), ..intersection.AsSpirvSpan()]);
    }

    public static Instruction AddOpAtomicFAddEXT(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpAtomicFAddEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpAtomicFAddEXT(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef pointer, IdScope memory, IdMemorySemantics semantics, IdRef value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(pointer) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics) + buffer.GetWordLength(value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpAtomicFAddEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..pointer.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan(), ..value.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeBufferSurfaceINTEL(this SpirvBuffer buffer, IdResult resultId, AccessQualifier accessQualifier)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(accessQualifier);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeBufferSurfaceINTEL, ..resultId.AsSpirvSpan(), ..accessQualifier.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeBufferSurfaceINTEL(this SpirvBuffer buffer, int position, IdResult resultId, AccessQualifier accessQualifier)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(accessQualifier);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeBufferSurfaceINTEL, ..resultId.AsSpirvSpan(), ..accessQualifier.AsSpirvSpan()]);
    }

    public static Instruction AddOpTypeStructContinuedINTEL(this SpirvBuffer buffer, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpTypeStructContinuedINTEL, ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpTypeStructContinuedINTEL(this SpirvBuffer buffer, int position, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpTypeStructContinuedINTEL, ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpConstantCompositeContinuedINTEL(this SpirvBuffer buffer, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConstantCompositeContinuedINTEL, ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConstantCompositeContinuedINTEL(this SpirvBuffer buffer, int position, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConstantCompositeContinuedINTEL, ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpSpecConstantCompositeContinuedINTEL(this SpirvBuffer buffer, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSpecConstantCompositeContinuedINTEL, ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSpecConstantCompositeContinuedINTEL(this SpirvBuffer buffer, int position, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSpecConstantCompositeContinuedINTEL, ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpCompositeConstructContinuedINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpCompositeConstructContinuedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction InsertOpCompositeConstructContinuedINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, Span<IdRef> values)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(values);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpCompositeConstructContinuedINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..values.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertFToBF16INTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef floatValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(floatValue);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertFToBF16INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..floatValue.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConvertFToBF16INTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef floatValue)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(floatValue);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConvertFToBF16INTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..floatValue.AsSpirvSpan()]);
    }

    public static Instruction AddOpConvertBF16ToFINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef bFloat16Value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(bFloat16Value);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpConvertBF16ToFINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..bFloat16Value.AsSpirvSpan()]);
    }

    public static Instruction InsertOpConvertBF16ToFINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef bFloat16Value)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(bFloat16Value);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpConvertBF16ToFINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..bFloat16Value.AsSpirvSpan()]);
    }

    public static Instruction AddOpControlBarrierArriveINTEL(this SpirvBuffer buffer, IdScope execution, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpControlBarrierArriveINTEL, ..execution.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction InsertOpControlBarrierArriveINTEL(this SpirvBuffer buffer, int position, IdScope execution, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpControlBarrierArriveINTEL, ..execution.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpControlBarrierWaitINTEL(this SpirvBuffer buffer, IdScope execution, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpControlBarrierWaitINTEL, ..execution.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction InsertOpControlBarrierWaitINTEL(this SpirvBuffer buffer, int position, IdScope execution, IdScope memory, IdMemorySemantics semantics)
    {
        var wordLength = 1 + buffer.GetWordLength(execution) + buffer.GetWordLength(memory) + buffer.GetWordLength(semantics);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpControlBarrierWaitINTEL, ..execution.AsSpirvSpan(), ..memory.AsSpirvSpan(), ..semantics.AsSpirvSpan()]);
    }

    public static Instruction AddOpArithmeticFenceEXT(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef target)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(target);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpArithmeticFenceEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..target.AsSpirvSpan()]);
    }

    public static Instruction InsertOpArithmeticFenceEXT(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef target)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(target);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpArithmeticFenceEXT, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..target.AsSpirvSpan()]);
    }

    public static Instruction AddOpSubgroupBlockPrefetchINTEL(this SpirvBuffer buffer, IdRef ptr, IdRef numBytes, MemoryAccessMask? memoryaccess)
    {
        var wordLength = 1 + buffer.GetWordLength(ptr) + buffer.GetWordLength(numBytes) + buffer.GetWordLength(memoryaccess);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSubgroupBlockPrefetchINTEL, ..ptr.AsSpirvSpan(), ..numBytes.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSubgroupBlockPrefetchINTEL(this SpirvBuffer buffer, int position, IdRef ptr, IdRef numBytes, MemoryAccessMask? memoryaccess)
    {
        var wordLength = 1 + buffer.GetWordLength(ptr) + buffer.GetWordLength(numBytes) + buffer.GetWordLength(memoryaccess);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSubgroupBlockPrefetchINTEL, ..ptr.AsSpirvSpan(), ..numBytes.AsSpirvSpan(), ..memoryaccess.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupIMulKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupIMulKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupIMulKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupIMulKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupFMulKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupFMulKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupFMulKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupFMulKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupBitwiseAndKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupBitwiseAndKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupBitwiseAndKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupBitwiseAndKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupBitwiseOrKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupBitwiseOrKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupBitwiseOrKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupBitwiseOrKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupBitwiseXorKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupBitwiseXorKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupBitwiseXorKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupBitwiseXorKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupLogicalAndKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupLogicalAndKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupLogicalAndKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupLogicalAndKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupLogicalOrKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupLogicalOrKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupLogicalOrKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupLogicalOrKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpGroupLogicalXorKHR(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpGroupLogicalXorKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction InsertOpGroupLogicalXorKHR(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdScope execution, GroupOperation operation, IdRef x)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(execution) + buffer.GetWordLength(operation) + buffer.GetWordLength(x);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpGroupLogicalXorKHR, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..execution.AsSpirvSpan(), ..operation.AsSpirvSpan(), ..x.AsSpirvSpan()]);
    }

    public static Instruction AddOpMaskedGatherINTEL(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, IdRef ptrVector, LiteralInteger alignment, IdRef mask, IdRef fillEmpty)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(ptrVector) + buffer.GetWordLength(alignment) + buffer.GetWordLength(mask) + buffer.GetWordLength(fillEmpty);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMaskedGatherINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..ptrVector.AsSpirvSpan(), ..alignment.AsSpirvSpan(), ..mask.AsSpirvSpan(), ..fillEmpty.AsSpirvSpan()]);
    }

    public static Instruction InsertOpMaskedGatherINTEL(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, IdRef ptrVector, LiteralInteger alignment, IdRef mask, IdRef fillEmpty)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(ptrVector) + buffer.GetWordLength(alignment) + buffer.GetWordLength(mask) + buffer.GetWordLength(fillEmpty);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpMaskedGatherINTEL, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..ptrVector.AsSpirvSpan(), ..alignment.AsSpirvSpan(), ..mask.AsSpirvSpan(), ..fillEmpty.AsSpirvSpan()]);
    }

    public static Instruction AddOpMaskedScatterINTEL(this SpirvBuffer buffer, IdRef inputVector, IdRef ptrVector, LiteralInteger alignment, IdRef mask)
    {
        var wordLength = 1 + buffer.GetWordLength(inputVector) + buffer.GetWordLength(ptrVector) + buffer.GetWordLength(alignment) + buffer.GetWordLength(mask);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpMaskedScatterINTEL, ..inputVector.AsSpirvSpan(), ..ptrVector.AsSpirvSpan(), ..alignment.AsSpirvSpan(), ..mask.AsSpirvSpan()]);
    }

    public static Instruction InsertOpMaskedScatterINTEL(this SpirvBuffer buffer, int position, IdRef inputVector, IdRef ptrVector, LiteralInteger alignment, IdRef mask)
    {
        var wordLength = 1 + buffer.GetWordLength(inputVector) + buffer.GetWordLength(ptrVector) + buffer.GetWordLength(alignment) + buffer.GetWordLength(mask);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpMaskedScatterINTEL, ..inputVector.AsSpirvSpan(), ..ptrVector.AsSpirvSpan(), ..alignment.AsSpirvSpan(), ..mask.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLMixinName(this SpirvBuffer buffer, LiteralString mixinName)
    {
        var wordLength = 1 + buffer.GetWordLength(mixinName);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLMixinName, ..mixinName.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSDSLMixinName(this SpirvBuffer buffer, int position, LiteralString mixinName)
    {
        var wordLength = 1 + buffer.GetWordLength(mixinName);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSDSLMixinName, ..mixinName.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLMixinEnd(this SpirvBuffer buffer)
    {
        return buffer.Add([1 << 16 | (int)SDSLOp.OpSDSLMixinEnd]);
    }

    public static Instruction InsertOpSDSLMixinEnd(this SpirvBuffer buffer, int position)
    {
        return buffer.Insert(position, [1 << 16 | (int)SDSLOp.OpSDSLMixinEnd]);
    }

    public static Instruction AddOpSDSLMixinOffset(this SpirvBuffer buffer, LiteralInteger mixinName)
    {
        var wordLength = 1 + buffer.GetWordLength(mixinName);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLMixinOffset, ..mixinName.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSDSLMixinOffset(this SpirvBuffer buffer, int position, LiteralInteger mixinName)
    {
        var wordLength = 1 + buffer.GetWordLength(mixinName);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSDSLMixinOffset, ..mixinName.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLMixinInherit(this SpirvBuffer buffer, LiteralString mixinName)
    {
        var wordLength = 1 + buffer.GetWordLength(mixinName);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLMixinInherit, ..mixinName.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSDSLMixinInherit(this SpirvBuffer buffer, int position, LiteralString mixinName)
    {
        var wordLength = 1 + buffer.GetWordLength(mixinName);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSDSLMixinInherit, ..mixinName.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLCompose(this SpirvBuffer buffer, LiteralString mixin, LiteralString name)
    {
        var wordLength = 1 + buffer.GetWordLength(mixin) + buffer.GetWordLength(name);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLCompose, ..mixin.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSDSLCompose(this SpirvBuffer buffer, int position, LiteralString mixin, LiteralString name)
    {
        var wordLength = 1 + buffer.GetWordLength(mixin) + buffer.GetWordLength(name);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSDSLCompose, ..mixin.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLStage(this SpirvBuffer buffer, IdRef stagedElement)
    {
        var wordLength = 1 + buffer.GetWordLength(stagedElement);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLStage, ..stagedElement.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSDSLStage(this SpirvBuffer buffer, int position, IdRef stagedElement)
    {
        var wordLength = 1 + buffer.GetWordLength(stagedElement);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSDSLStage, ..stagedElement.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLImportFunction(this SpirvBuffer buffer, IdResult resultId, LiteralString functionName, LiteralString mixinName, LiteralInteger id, LiteralInteger typeId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(functionName) + buffer.GetWordLength(mixinName) + buffer.GetWordLength(id) + buffer.GetWordLength(typeId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLImportFunction, ..resultId.AsSpirvSpan(), ..functionName.AsSpirvSpan(), ..mixinName.AsSpirvSpan(), ..id.AsSpirvSpan(), ..typeId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSDSLImportFunction(this SpirvBuffer buffer, int position, IdResult resultId, LiteralString functionName, LiteralString mixinName, LiteralInteger id, LiteralInteger typeId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(functionName) + buffer.GetWordLength(mixinName) + buffer.GetWordLength(id) + buffer.GetWordLength(typeId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSDSLImportFunction, ..resultId.AsSpirvSpan(), ..functionName.AsSpirvSpan(), ..mixinName.AsSpirvSpan(), ..id.AsSpirvSpan(), ..typeId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLImportVariable(this SpirvBuffer buffer, IdResult resultId, LiteralString variableName, LiteralString mixinName, LiteralInteger id)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(variableName) + buffer.GetWordLength(mixinName) + buffer.GetWordLength(id);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLImportVariable, ..resultId.AsSpirvSpan(), ..variableName.AsSpirvSpan(), ..mixinName.AsSpirvSpan(), ..id.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSDSLImportVariable(this SpirvBuffer buffer, int position, IdResult resultId, LiteralString variableName, LiteralString mixinName, LiteralInteger id)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(variableName) + buffer.GetWordLength(mixinName) + buffer.GetWordLength(id);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSDSLImportVariable, ..resultId.AsSpirvSpan(), ..variableName.AsSpirvSpan(), ..mixinName.AsSpirvSpan(), ..id.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLImportIdRef(this SpirvBuffer buffer, IdResult resultId, LiteralString mixinName, LiteralInteger id)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(mixinName) + buffer.GetWordLength(id);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLImportIdRef, ..resultId.AsSpirvSpan(), ..mixinName.AsSpirvSpan(), ..id.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSDSLImportIdRef(this SpirvBuffer buffer, int position, IdResult resultId, LiteralString mixinName, LiteralInteger id)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(mixinName) + buffer.GetWordLength(id);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSDSLImportIdRef, ..resultId.AsSpirvSpan(), ..mixinName.AsSpirvSpan(), ..id.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLMixinVariable(this SpirvBuffer buffer, IdResult resultId, IdRef mixinId, IdRef variableId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(mixinId) + buffer.GetWordLength(variableId);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLMixinVariable, ..resultId.AsSpirvSpan(), ..mixinId.AsSpirvSpan(), ..variableId.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSDSLMixinVariable(this SpirvBuffer buffer, int position, IdResult resultId, IdRef mixinId, IdRef variableId)
    {
        var wordLength = 1 + buffer.GetWordLength(resultId) + buffer.GetWordLength(mixinId) + buffer.GetWordLength(variableId);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSDSLMixinVariable, ..resultId.AsSpirvSpan(), ..mixinId.AsSpirvSpan(), ..variableId.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLVariable(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, StorageClass storageclass, LiteralString name, IdRef? initializer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass) + buffer.GetWordLength(name) + buffer.GetWordLength(initializer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLVariable, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan(), ..name.AsSpirvSpan(), ..initializer.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSDSLVariable(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, StorageClass storageclass, LiteralString name, IdRef? initializer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass) + buffer.GetWordLength(name) + buffer.GetWordLength(initializer);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSDSLVariable, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan(), ..name.AsSpirvSpan(), ..initializer.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLFunctionParameter(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, LiteralString name)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(name);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLFunctionParameter, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSDSLFunctionParameter(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, LiteralString name)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(name);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSDSLFunctionParameter, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..name.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLIOVariable(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, StorageClass storageclass, ExecutionModel executionmodel, LiteralString name, LiteralString semantic, IdRef? initializer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass) + buffer.GetWordLength(executionmodel) + buffer.GetWordLength(name) + buffer.GetWordLength(semantic) + buffer.GetWordLength(initializer);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLIOVariable, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan(), ..executionmodel.AsSpirvSpan(), ..name.AsSpirvSpan(), ..semantic.AsSpirvSpan(), ..initializer.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSDSLIOVariable(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, StorageClass storageclass, ExecutionModel executionmodel, LiteralString name, LiteralString semantic, IdRef? initializer)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(storageclass) + buffer.GetWordLength(executionmodel) + buffer.GetWordLength(name) + buffer.GetWordLength(semantic) + buffer.GetWordLength(initializer);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSDSLIOVariable, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..storageclass.AsSpirvSpan(), ..executionmodel.AsSpirvSpan(), ..name.AsSpirvSpan(), ..semantic.AsSpirvSpan(), ..initializer.AsSpirvSpan()]);
    }

    public static Instruction AddOpSDSLFunction(this SpirvBuffer buffer, IdResult resultId, IdResultType resultType, FunctionControlMask functioncontrol, IdRef functionType, LiteralString functionName)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(functioncontrol) + buffer.GetWordLength(functionType) + buffer.GetWordLength(functionName);
        return buffer.Add([wordLength << 16 | (int)SDSLOp.OpSDSLFunction, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..functioncontrol.AsSpirvSpan(), ..functionType.AsSpirvSpan(), ..functionName.AsSpirvSpan()]);
    }

    public static Instruction InsertOpSDSLFunction(this SpirvBuffer buffer, int position, IdResult resultId, IdResultType resultType, FunctionControlMask functioncontrol, IdRef functionType, LiteralString functionName)
    {
        var wordLength = 1 + buffer.GetWordLength(resultType) + buffer.GetWordLength(resultId) + buffer.GetWordLength(functioncontrol) + buffer.GetWordLength(functionType) + buffer.GetWordLength(functionName);
        return buffer.Insert(position, [wordLength << 16 | (int)SDSLOp.OpSDSLFunction, ..resultType.AsSpirvSpan(), ..resultId.AsSpirvSpan(), ..functioncontrol.AsSpirvSpan(), ..functionType.AsSpirvSpan(), ..functionName.AsSpirvSpan()]);
    }

    public static Instruction AddGLSLRound(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 1, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLRound(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 1, resultId, resultType, refs);
    }

    public static Instruction AddGLSLRoundEven(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 2, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLRoundEven(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 2, resultId, resultType, refs);
    }

    public static Instruction AddGLSLTrunc(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 3, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLTrunc(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 3, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFAbs(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 4, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLFAbs(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 4, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSAbs(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 5, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLSAbs(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 5, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFSign(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 6, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLFSign(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 6, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSSign(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 7, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLSSign(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 7, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFloor(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 8, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLFloor(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 8, resultId, resultType, refs);
    }

    public static Instruction AddGLSLCeil(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 9, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLCeil(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 9, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFract(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 10, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLFract(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 10, resultId, resultType, refs);
    }

    public static Instruction AddGLSLRadians(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef degrees, int set)
    {
        Span<IdRef> refs = [degrees];
        return buffer.AddOpExtInst(set, 11, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLRadians(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef degrees, int set)
    {
        Span<IdRef> refs = [degrees];
        return buffer.InsertOpExtInst(position, set, 11, resultId, resultType, refs);
    }

    public static Instruction AddGLSLDegrees(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef radians, int set)
    {
        Span<IdRef> refs = [radians];
        return buffer.AddOpExtInst(set, 12, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLDegrees(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef radians, int set)
    {
        Span<IdRef> refs = [radians];
        return buffer.InsertOpExtInst(position, set, 12, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSin(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 13, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLSin(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 13, resultId, resultType, refs);
    }

    public static Instruction AddGLSLCos(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 14, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLCos(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 14, resultId, resultType, refs);
    }

    public static Instruction AddGLSLTan(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 15, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLTan(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 15, resultId, resultType, refs);
    }

    public static Instruction AddGLSLAsin(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 16, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLAsin(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 16, resultId, resultType, refs);
    }

    public static Instruction AddGLSLAcos(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 17, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLAcos(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 17, resultId, resultType, refs);
    }

    public static Instruction AddGLSLAtan(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef y_over_x, int set)
    {
        Span<IdRef> refs = [y_over_x];
        return buffer.AddOpExtInst(set, 18, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLAtan(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef y_over_x, int set)
    {
        Span<IdRef> refs = [y_over_x];
        return buffer.InsertOpExtInst(position, set, 18, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSinh(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 19, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLSinh(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 19, resultId, resultType, refs);
    }

    public static Instruction AddGLSLCosh(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 20, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLCosh(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 20, resultId, resultType, refs);
    }

    public static Instruction AddGLSLTanh(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 21, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLTanh(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 21, resultId, resultType, refs);
    }

    public static Instruction AddGLSLAsinh(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 22, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLAsinh(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 22, resultId, resultType, refs);
    }

    public static Instruction AddGLSLAcosh(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 23, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLAcosh(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 23, resultId, resultType, refs);
    }

    public static Instruction AddGLSLAtanh(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 24, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLAtanh(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 24, resultId, resultType, refs);
    }

    public static Instruction AddGLSLAtan2(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef y, IdRef x, int set)
    {
        Span<IdRef> refs = [y, x];
        return buffer.AddOpExtInst(set, 25, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLAtan2(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef y, IdRef x, int set)
    {
        Span<IdRef> refs = [y, x];
        return buffer.InsertOpExtInst(position, set, 25, resultId, resultType, refs);
    }

    public static Instruction AddGLSLPow(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.AddOpExtInst(set, 26, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLPow(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.InsertOpExtInst(position, set, 26, resultId, resultType, refs);
    }

    public static Instruction AddGLSLExp(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 27, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLExp(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 27, resultId, resultType, refs);
    }

    public static Instruction AddGLSLLog(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 28, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLLog(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 28, resultId, resultType, refs);
    }

    public static Instruction AddGLSLExp2(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 29, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLExp2(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 29, resultId, resultType, refs);
    }

    public static Instruction AddGLSLLog2(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 30, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLLog2(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 30, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSqrt(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 31, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLSqrt(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 31, resultId, resultType, refs);
    }

    public static Instruction AddGLSLInverseSqrt(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 32, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLInverseSqrt(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 32, resultId, resultType, refs);
    }

    public static Instruction AddGLSLDeterminant(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 33, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLDeterminant(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 33, resultId, resultType, refs);
    }

    public static Instruction AddGLSLMatrixInverse(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 34, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLMatrixInverse(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 34, resultId, resultType, refs);
    }

    public static Instruction AddGLSLModf(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef i, int set)
    {
        Span<IdRef> refs = [x, i];
        return buffer.AddOpExtInst(set, 35, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLModf(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef i, int set)
    {
        Span<IdRef> refs = [x, i];
        return buffer.InsertOpExtInst(position, set, 35, resultId, resultType, refs);
    }

    public static Instruction AddGLSLModfStruct(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 36, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLModfStruct(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 36, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFMin(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.AddOpExtInst(set, 37, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLFMin(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.InsertOpExtInst(position, set, 37, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUMin(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.AddOpExtInst(set, 38, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLUMin(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.InsertOpExtInst(position, set, 38, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSMin(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.AddOpExtInst(set, 39, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLSMin(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.InsertOpExtInst(position, set, 39, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFMax(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.AddOpExtInst(set, 40, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLFMax(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.InsertOpExtInst(position, set, 40, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUMax(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.AddOpExtInst(set, 41, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLUMax(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.InsertOpExtInst(position, set, 41, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSMax(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.AddOpExtInst(set, 42, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLSMax(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.InsertOpExtInst(position, set, 42, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFClamp(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef minVal, IdRef maxVal, int set)
    {
        Span<IdRef> refs = [x, minVal, maxVal];
        return buffer.AddOpExtInst(set, 43, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLFClamp(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef minVal, IdRef maxVal, int set)
    {
        Span<IdRef> refs = [x, minVal, maxVal];
        return buffer.InsertOpExtInst(position, set, 43, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUClamp(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef minVal, IdRef maxVal, int set)
    {
        Span<IdRef> refs = [x, minVal, maxVal];
        return buffer.AddOpExtInst(set, 44, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLUClamp(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef minVal, IdRef maxVal, int set)
    {
        Span<IdRef> refs = [x, minVal, maxVal];
        return buffer.InsertOpExtInst(position, set, 44, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSClamp(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef minVal, IdRef maxVal, int set)
    {
        Span<IdRef> refs = [x, minVal, maxVal];
        return buffer.AddOpExtInst(set, 45, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLSClamp(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef minVal, IdRef maxVal, int set)
    {
        Span<IdRef> refs = [x, minVal, maxVal];
        return buffer.InsertOpExtInst(position, set, 45, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFMix(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, IdRef a, int set)
    {
        Span<IdRef> refs = [x, y, a];
        return buffer.AddOpExtInst(set, 46, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLFMix(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef y, IdRef a, int set)
    {
        Span<IdRef> refs = [x, y, a];
        return buffer.InsertOpExtInst(position, set, 46, resultId, resultType, refs);
    }

    public static Instruction AddGLSLIMix(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, IdRef a, int set)
    {
        Span<IdRef> refs = [x, y, a];
        return buffer.AddOpExtInst(set, 47, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLIMix(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef y, IdRef a, int set)
    {
        Span<IdRef> refs = [x, y, a];
        return buffer.InsertOpExtInst(position, set, 47, resultId, resultType, refs);
    }

    public static Instruction AddGLSLStep(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef edge, IdRef x, int set)
    {
        Span<IdRef> refs = [edge, x];
        return buffer.AddOpExtInst(set, 48, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLStep(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef edge, IdRef x, int set)
    {
        Span<IdRef> refs = [edge, x];
        return buffer.InsertOpExtInst(position, set, 48, resultId, resultType, refs);
    }

    public static Instruction AddGLSLSmoothStep(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef edge0, IdRef edge1, IdRef x, int set)
    {
        Span<IdRef> refs = [edge0, edge1, x];
        return buffer.AddOpExtInst(set, 49, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLSmoothStep(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef edge0, IdRef edge1, IdRef x, int set)
    {
        Span<IdRef> refs = [edge0, edge1, x];
        return buffer.InsertOpExtInst(position, set, 49, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFma(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef a, IdRef b, IdRef c, int set)
    {
        Span<IdRef> refs = [a, b, c];
        return buffer.AddOpExtInst(set, 50, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLFma(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef a, IdRef b, IdRef c, int set)
    {
        Span<IdRef> refs = [a, b, c];
        return buffer.InsertOpExtInst(position, set, 50, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFrexp(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef exp, int set)
    {
        Span<IdRef> refs = [x, exp];
        return buffer.AddOpExtInst(set, 51, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLFrexp(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef exp, int set)
    {
        Span<IdRef> refs = [x, exp];
        return buffer.InsertOpExtInst(position, set, 51, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFrexpStruct(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 52, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLFrexpStruct(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 52, resultId, resultType, refs);
    }

    public static Instruction AddGLSLLdexp(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef exp, int set)
    {
        Span<IdRef> refs = [x, exp];
        return buffer.AddOpExtInst(set, 53, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLLdexp(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef exp, int set)
    {
        Span<IdRef> refs = [x, exp];
        return buffer.InsertOpExtInst(position, set, 53, resultId, resultType, refs);
    }

    public static Instruction AddGLSLPackSnorm4x8(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = [v];
        return buffer.AddOpExtInst(set, 54, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLPackSnorm4x8(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = [v];
        return buffer.InsertOpExtInst(position, set, 54, resultId, resultType, refs);
    }

    public static Instruction AddGLSLPackUnorm4x8(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = [v];
        return buffer.AddOpExtInst(set, 55, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLPackUnorm4x8(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = [v];
        return buffer.InsertOpExtInst(position, set, 55, resultId, resultType, refs);
    }

    public static Instruction AddGLSLPackSnorm2x16(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = [v];
        return buffer.AddOpExtInst(set, 56, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLPackSnorm2x16(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = [v];
        return buffer.InsertOpExtInst(position, set, 56, resultId, resultType, refs);
    }

    public static Instruction AddGLSLPackUnorm2x16(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = [v];
        return buffer.AddOpExtInst(set, 57, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLPackUnorm2x16(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = [v];
        return buffer.InsertOpExtInst(position, set, 57, resultId, resultType, refs);
    }

    public static Instruction AddGLSLPackHalf2x16(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = [v];
        return buffer.AddOpExtInst(set, 58, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLPackHalf2x16(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = [v];
        return buffer.InsertOpExtInst(position, set, 58, resultId, resultType, refs);
    }

    public static Instruction AddGLSLPackDouble2x32(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = [v];
        return buffer.AddOpExtInst(set, 59, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLPackDouble2x32(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = [v];
        return buffer.InsertOpExtInst(position, set, 59, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUnpackSnorm2x16(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef p, int set)
    {
        Span<IdRef> refs = [p];
        return buffer.AddOpExtInst(set, 60, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLUnpackSnorm2x16(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef p, int set)
    {
        Span<IdRef> refs = [p];
        return buffer.InsertOpExtInst(position, set, 60, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUnpackUnorm2x16(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef p, int set)
    {
        Span<IdRef> refs = [p];
        return buffer.AddOpExtInst(set, 61, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLUnpackUnorm2x16(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef p, int set)
    {
        Span<IdRef> refs = [p];
        return buffer.InsertOpExtInst(position, set, 61, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUnpackHalf2x16(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = [v];
        return buffer.AddOpExtInst(set, 62, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLUnpackHalf2x16(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = [v];
        return buffer.InsertOpExtInst(position, set, 62, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUnpackSnorm4x8(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef p, int set)
    {
        Span<IdRef> refs = [p];
        return buffer.AddOpExtInst(set, 63, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLUnpackSnorm4x8(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef p, int set)
    {
        Span<IdRef> refs = [p];
        return buffer.InsertOpExtInst(position, set, 63, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUnpackUnorm4x8(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef p, int set)
    {
        Span<IdRef> refs = [p];
        return buffer.AddOpExtInst(set, 64, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLUnpackUnorm4x8(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef p, int set)
    {
        Span<IdRef> refs = [p];
        return buffer.InsertOpExtInst(position, set, 64, resultId, resultType, refs);
    }

    public static Instruction AddGLSLUnpackDouble2x32(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = [v];
        return buffer.AddOpExtInst(set, 65, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLUnpackDouble2x32(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef v, int set)
    {
        Span<IdRef> refs = [v];
        return buffer.InsertOpExtInst(position, set, 65, resultId, resultType, refs);
    }

    public static Instruction AddGLSLLength(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 66, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLLength(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 66, resultId, resultType, refs);
    }

    public static Instruction AddGLSLDistance(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef p0, IdRef p1, int set)
    {
        Span<IdRef> refs = [p0, p1];
        return buffer.AddOpExtInst(set, 67, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLDistance(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef p0, IdRef p1, int set)
    {
        Span<IdRef> refs = [p0, p1];
        return buffer.InsertOpExtInst(position, set, 67, resultId, resultType, refs);
    }

    public static Instruction AddGLSLCross(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.AddOpExtInst(set, 68, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLCross(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.InsertOpExtInst(position, set, 68, resultId, resultType, refs);
    }

    public static Instruction AddGLSLNormalize(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.AddOpExtInst(set, 69, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLNormalize(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, int set)
    {
        Span<IdRef> refs = [x];
        return buffer.InsertOpExtInst(position, set, 69, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFaceForward(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef n, IdRef i, IdRef nref, int set)
    {
        Span<IdRef> refs = [n, i, nref];
        return buffer.AddOpExtInst(set, 70, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLFaceForward(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef n, IdRef i, IdRef nref, int set)
    {
        Span<IdRef> refs = [n, i, nref];
        return buffer.InsertOpExtInst(position, set, 70, resultId, resultType, refs);
    }

    public static Instruction AddGLSLReflect(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef i, IdRef n, int set)
    {
        Span<IdRef> refs = [i, n];
        return buffer.AddOpExtInst(set, 71, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLReflect(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef i, IdRef n, int set)
    {
        Span<IdRef> refs = [i, n];
        return buffer.InsertOpExtInst(position, set, 71, resultId, resultType, refs);
    }

    public static Instruction AddGLSLRefract(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef i, IdRef n, IdRef eta, int set)
    {
        Span<IdRef> refs = [i, n, eta];
        return buffer.AddOpExtInst(set, 72, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLRefract(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef i, IdRef n, IdRef eta, int set)
    {
        Span<IdRef> refs = [i, n, eta];
        return buffer.InsertOpExtInst(position, set, 72, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFindILsb(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef value, int set)
    {
        Span<IdRef> refs = [value];
        return buffer.AddOpExtInst(set, 73, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLFindILsb(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef value, int set)
    {
        Span<IdRef> refs = [value];
        return buffer.InsertOpExtInst(position, set, 73, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFindSMsb(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef value, int set)
    {
        Span<IdRef> refs = [value];
        return buffer.AddOpExtInst(set, 74, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLFindSMsb(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef value, int set)
    {
        Span<IdRef> refs = [value];
        return buffer.InsertOpExtInst(position, set, 74, resultId, resultType, refs);
    }

    public static Instruction AddGLSLFindUMsb(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef value, int set)
    {
        Span<IdRef> refs = [value];
        return buffer.AddOpExtInst(set, 75, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLFindUMsb(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef value, int set)
    {
        Span<IdRef> refs = [value];
        return buffer.InsertOpExtInst(position, set, 75, resultId, resultType, refs);
    }

    public static Instruction AddGLSLInterpolateAtCentroid(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef interpolant, int set)
    {
        Span<IdRef> refs = [interpolant];
        return buffer.AddOpExtInst(set, 76, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLInterpolateAtCentroid(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef interpolant, int set)
    {
        Span<IdRef> refs = [interpolant];
        return buffer.InsertOpExtInst(position, set, 76, resultId, resultType, refs);
    }

    public static Instruction AddGLSLInterpolateAtSample(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef interpolant, IdRef sample, int set)
    {
        Span<IdRef> refs = [interpolant, sample];
        return buffer.AddOpExtInst(set, 77, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLInterpolateAtSample(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef interpolant, IdRef sample, int set)
    {
        Span<IdRef> refs = [interpolant, sample];
        return buffer.InsertOpExtInst(position, set, 77, resultId, resultType, refs);
    }

    public static Instruction AddGLSLInterpolateAtOffset(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef interpolant, IdRef offset, int set)
    {
        Span<IdRef> refs = [interpolant, offset];
        return buffer.AddOpExtInst(set, 78, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLInterpolateAtOffset(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef interpolant, IdRef offset, int set)
    {
        Span<IdRef> refs = [interpolant, offset];
        return buffer.InsertOpExtInst(position, set, 78, resultId, resultType, refs);
    }

    public static Instruction AddGLSLNMin(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.AddOpExtInst(set, 79, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLNMin(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.InsertOpExtInst(position, set, 79, resultId, resultType, refs);
    }

    public static Instruction AddGLSLNMax(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.AddOpExtInst(set, 80, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLNMax(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef y, int set)
    {
        Span<IdRef> refs = [x, y];
        return buffer.InsertOpExtInst(position, set, 80, resultId, resultType, refs);
    }

    public static Instruction AddGLSLNClamp(this SpirvBuffer buffer, IdResultType resultType, int resultId, IdRef x, IdRef minVal, IdRef maxVal, int set)
    {
        Span<IdRef> refs = [x, minVal, maxVal];
        return buffer.AddOpExtInst(set, 81, resultId, resultType, refs);
    }

    public static Instruction InsertGLSLNClamp(this SpirvBuffer buffer, int position, IdResultType resultType, int resultId, IdRef x, IdRef minVal, IdRef maxVal, int set)
    {
        Span<IdRef> refs = [x, minVal, maxVal];
        return buffer.InsertOpExtInst(position, set, 81, resultId, resultType, refs);
    }
}