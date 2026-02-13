namespace Stride.Shaders.Parsing.SDSL;
using System.Collections.Frozen;
using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Building;
using Stride.Shaders.Parsing.Analysis;

public interface IIntrinsicCompiler
{
    SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams);
}

public abstract class IntrinsicsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileD3DCOLORtoUBYTE4(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetRenderTargetSampleCount(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetRenderTargetSamplePosition(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s) => throw new NotImplementedException();
    public virtual SpirvValue CompileAbort(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileAbs(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileAcos(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileAll(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileAllMemoryBarrier(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileAllMemoryBarrierWithGroupSync(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileAny(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileAsdouble(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x, SpirvValue y) => throw new NotImplementedException();
    public virtual SpirvValue CompileAsfloat(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileAsfloat16(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileAsint16(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileAsin(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileAsint(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileAsuint(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue? d = null, SpirvValue? x = null, SpirvValue? y = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileAsuint16(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileAtan(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileAtan2(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x, SpirvValue y) => throw new NotImplementedException();
    public virtual SpirvValue CompileCeil(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileClamp(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x, SpirvValue min, SpirvValue max) => throw new NotImplementedException();
    public virtual SpirvValue CompileClip(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileCos(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileCosh(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileCountbits(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileCross(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue a, SpirvValue b) => throw new NotImplementedException();
    public virtual SpirvValue CompileDdx(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileDdx_coarse(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileDdx_fine(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileDdy(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileDdy_coarse(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileDdy_fine(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileDegrees(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileDeterminant(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileDeviceMemoryBarrier(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileDeviceMemoryBarrierWithGroupSync(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileDistance(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue a, SpirvValue b) => throw new NotImplementedException();
    public virtual SpirvValue CompileDot(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue a, SpirvValue b) => throw new NotImplementedException();
    public virtual SpirvValue CompileDst(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue a, SpirvValue b) => throw new NotImplementedException();
    public virtual SpirvValue CompileEvaluateAttributeAtSample(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value, SpirvValue index) => throw new NotImplementedException();
    public virtual SpirvValue CompileEvaluateAttributeCentroid(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileEvaluateAttributeSnapped(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value, SpirvValue offset) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetAttributeAtVertex(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value, SpirvValue VertexID) => throw new NotImplementedException();
    public virtual SpirvValue CompileExp(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileExp2(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileF16tof32(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileF32tof16(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileFaceforward(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue N, SpirvValue I, SpirvValue Ng) => throw new NotImplementedException();
    public virtual SpirvValue CompileFirstbithigh(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileFirstbitlow(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileFloor(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileFma(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue a, SpirvValue b, SpirvValue c) => throw new NotImplementedException();
    public virtual SpirvValue CompileFmod(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue a, SpirvValue b) => throw new NotImplementedException();
    public virtual SpirvValue CompileFrac(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileFrexp(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x, SpirvValue exp) => throw new NotImplementedException();
    public virtual SpirvValue CompileFwidth(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileGroupMemoryBarrier(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileGroupMemoryBarrierWithGroupSync(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedAdd(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue result, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedMin(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue result, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedMax(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue result, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedAnd(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue result, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedOr(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue result, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedXor(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue result, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedCompareStore(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue result, SpirvValue compare, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedExchange(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue result, SpirvValue value, SpirvValue original) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedCompareExchange(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue result, SpirvValue compare, SpirvValue value, SpirvValue original) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedCompareStoreFloatBitwise(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue result, SpirvValue compare, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedCompareExchangeFloatBitwise(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue result, SpirvValue compare, SpirvValue value, SpirvValue original) => throw new NotImplementedException();
    public virtual SpirvValue CompileIsfinite(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileIsinf(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileIsnan(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileIsnormal(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileLdexp(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x, SpirvValue exp) => throw new NotImplementedException();
    public virtual SpirvValue CompileLength(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileLerp(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue a, SpirvValue b, SpirvValue s) => throw new NotImplementedException();
    public virtual SpirvValue CompileLit(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue l, SpirvValue h, SpirvValue m) => throw new NotImplementedException();
    public virtual SpirvValue CompileLog(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileLog10(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileLog2(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileMad(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue a, SpirvValue b, SpirvValue c) => throw new NotImplementedException();
    public virtual SpirvValue CompileMax(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue a, SpirvValue b) => throw new NotImplementedException();
    public virtual SpirvValue CompileMin(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue a, SpirvValue b) => throw new NotImplementedException();
    public virtual SpirvValue CompileModf(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x, SpirvValue ip) => throw new NotImplementedException();
    public virtual SpirvValue CompileMsad4(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue reference, SpirvValue source, SpirvValue accum) => throw new NotImplementedException();
    public virtual SpirvValue CompileMul(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue a, SpirvValue b) => throw new NotImplementedException();
    public virtual SpirvValue CompileNormalize(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompilePow(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x, SpirvValue y) => throw new NotImplementedException();
    public virtual SpirvValue CompileProcess2DQuadTessFactorsAvg(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue RawEdgeFactors, SpirvValue InsideScale, SpirvValue RoundedEdgeFactors, SpirvValue RoundedInsideFactors, SpirvValue UnroundedInsideFactors) => throw new NotImplementedException();
    public virtual SpirvValue CompileProcess2DQuadTessFactorsMax(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue RawEdgeFactors, SpirvValue InsideScale, SpirvValue RoundedEdgeFactors, SpirvValue RoundedInsideFactors, SpirvValue UnroundedInsideFactors) => throw new NotImplementedException();
    public virtual SpirvValue CompileProcess2DQuadTessFactorsMin(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue RawEdgeFactors, SpirvValue InsideScale, SpirvValue RoundedEdgeFactors, SpirvValue RoundedInsideFactors, SpirvValue UnroundedInsideFactors) => throw new NotImplementedException();
    public virtual SpirvValue CompileProcessIsolineTessFactors(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue RawDetailFactor, SpirvValue RawDensityFactor, SpirvValue RoundedDetailFactorr, SpirvValue RoundedDensityFactor) => throw new NotImplementedException();
    public virtual SpirvValue CompileProcessQuadTessFactorsAvg(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue RawEdgeFactors, SpirvValue InsideScale, SpirvValue RoundedEdgeFactors, SpirvValue RoundedInsideFactors, SpirvValue UnroundedInsideFactors) => throw new NotImplementedException();
    public virtual SpirvValue CompileProcessQuadTessFactorsMax(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue RawEdgeFactors, SpirvValue InsideScale, SpirvValue RoundedEdgeFactors, SpirvValue RoundedInsideFactors, SpirvValue UnroundedInsideFactors) => throw new NotImplementedException();
    public virtual SpirvValue CompileProcessQuadTessFactorsMin(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue RawEdgeFactors, SpirvValue InsideScale, SpirvValue RoundedEdgeFactors, SpirvValue RoundedInsideFactors, SpirvValue UnroundedInsideFactors) => throw new NotImplementedException();
    public virtual SpirvValue CompileProcessTriTessFactorsAvg(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue RawEdgeFactors, SpirvValue InsideScale, SpirvValue RoundedEdgeFactors, SpirvValue RoundedInsideFactor, SpirvValue UnroundedInsideFactor) => throw new NotImplementedException();
    public virtual SpirvValue CompileProcessTriTessFactorsMax(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue RawEdgeFactors, SpirvValue InsideScale, SpirvValue RoundedEdgeFactors, SpirvValue RoundedInsideFactor, SpirvValue UnroundedInsideFactor) => throw new NotImplementedException();
    public virtual SpirvValue CompileProcessTriTessFactorsMin(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue RawEdgeFactors, SpirvValue InsideScale, SpirvValue RoundedEdgeFactors, SpirvValue RoundedInsideFactor, SpirvValue UnroundedInsideFactor) => throw new NotImplementedException();
    public virtual SpirvValue CompileRadians(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileRcp(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileReflect(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue i, SpirvValue n) => throw new NotImplementedException();
    public virtual SpirvValue CompileRefract(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue i, SpirvValue n, SpirvValue ri) => throw new NotImplementedException();
    public virtual SpirvValue CompileReversebits(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileRound(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileRsqrt(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileSaturate(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileSign(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileSin(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileSincos(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x, SpirvValue s, SpirvValue c) => throw new NotImplementedException();
    public virtual SpirvValue CompileSinh(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileSmoothstep(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue a, SpirvValue b, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileSource_mark(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileSqrt(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileStep(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue a, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileTan(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileTanh(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileTex1D(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x, SpirvValue? ddx = null, SpirvValue? ddy = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileTex1Dbias(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileTex1Dgrad(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x, SpirvValue ddx, SpirvValue ddy) => throw new NotImplementedException();
    public virtual SpirvValue CompileTex1Dlod(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileTex1Dproj(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileTex2D(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x, SpirvValue? ddx = null, SpirvValue? ddy = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileTex2Dbias(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileTex2Dgrad(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x, SpirvValue ddx, SpirvValue ddy) => throw new NotImplementedException();
    public virtual SpirvValue CompileTex2Dlod(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileTex2Dproj(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileTex3D(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x, SpirvValue? ddx = null, SpirvValue? ddy = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileTex3Dbias(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileTex3Dgrad(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x, SpirvValue ddx, SpirvValue ddy) => throw new NotImplementedException();
    public virtual SpirvValue CompileTex3Dlod(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileTex3Dproj(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileTexCUBE(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x, SpirvValue? ddx = null, SpirvValue? ddy = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileTexCUBEbias(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileTexCUBEgrad(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x, SpirvValue ddx, SpirvValue ddy) => throw new NotImplementedException();
    public virtual SpirvValue CompileTexCUBElod(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileTexCUBEproj(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue s, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileTranspose(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileTrunc(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileCheckAccessFullyMapped(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue status) => throw new NotImplementedException();
    public virtual SpirvValue CompileAddUint64(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue a, SpirvValue b) => throw new NotImplementedException();
    public virtual SpirvValue CompileNonUniformResourceIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue index) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveIsFirstLane(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveGetLaneIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveGetLaneCount(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveActiveAnyTrue(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue cond) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveActiveAllTrue(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue cond) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveActiveAllEqual(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveActiveBallot(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue cond) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveReadLaneAt(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value, SpirvValue lane) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveReadLaneFirst(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveActiveCountBits(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveActiveSum(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveActiveProduct(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveActiveBitAnd(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveActiveBitOr(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveActiveBitXor(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveActiveMin(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveActiveMax(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileWavePrefixCountBits(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileWavePrefixSum(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileWavePrefixProduct(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveMatch(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveMultiPrefixBitAnd(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value, SpirvValue mask) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveMultiPrefixBitOr(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value, SpirvValue mask) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveMultiPrefixBitXor(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value, SpirvValue mask) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveMultiPrefixCountBits(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value, SpirvValue mask) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveMultiPrefixProduct(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value, SpirvValue mask) => throw new NotImplementedException();
    public virtual SpirvValue CompileWaveMultiPrefixSum(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value, SpirvValue mask) => throw new NotImplementedException();
    public virtual SpirvValue CompileQuadReadLaneAt(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value, SpirvValue quadLane) => throw new NotImplementedException();
    public virtual SpirvValue CompileQuadReadAcrossX(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileQuadReadAcrossY(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileQuadReadAcrossDiagonal(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileQuadAny(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue cond) => throw new NotImplementedException();
    public virtual SpirvValue CompileQuadAll(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue cond) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetGroupWaveIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetGroupWaveCount(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileTraceRay(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue AccelerationStructure, SpirvValue RayFlags, SpirvValue InstanceInclusionMask, SpirvValue RayContributionToHitGroupIndex, SpirvValue MultiplierForGeometryContributionToHitGroupIndex, SpirvValue MissShaderIndex, SpirvValue Ray, SpirvValue Payload) => throw new NotImplementedException();
    public virtual SpirvValue CompileReportHit(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue THit, SpirvValue HitKind, SpirvValue Attributes) => throw new NotImplementedException();
    public virtual SpirvValue CompileCallShader(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue ShaderIndex, SpirvValue Parameter) => throw new NotImplementedException();
    public virtual SpirvValue CompileIgnoreHit(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileAcceptHitAndEndSearch(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileDispatchRaysIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileDispatchRaysDimensions(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileWorldRayOrigin(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileWorldRayDirection(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileObjectRayOrigin(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileObjectRayDirection(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileRayTMin(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileRayTCurrent(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompilePrimitiveIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileInstanceID(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileInstanceIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileGeometryIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileHitKind(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileRayFlags(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileObjectToWorld(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileWorldToObject(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileObjectToWorld3x4(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileWorldToObject3x4(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileObjectToWorld4x3(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public virtual SpirvValue CompileWorldToObject4x3(SpirvContext context, SpirvBuilder builder, FunctionType functionType) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group D3DCOLORtoUBYTE4
            (_, "D3DCOLORtoUBYTE4", 1) => CompileD3DCOLORtoUBYTE4(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group GetRenderTargetSampleCount
            (_, "GetRenderTargetSampleCount", 0) => CompileGetRenderTargetSampleCount(context, builder, functionType),
            // group GetRenderTargetSamplePosition
            (_, "GetRenderTargetSamplePosition", 1) => CompileGetRenderTargetSamplePosition(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group abort
            (_, "abort", 0) => CompileAbort(context, builder, functionType),
            // group abs
            (_, "abs", 1) => CompileAbs(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group acos
            (_, "acos", 1) => CompileAcos(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group all
            (_, "all", 1) => CompileAll(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group AllMemoryBarrier
            (_, "AllMemoryBarrier", 0) => CompileAllMemoryBarrier(context, builder, functionType),
            // group AllMemoryBarrierWithGroupSync
            (_, "AllMemoryBarrierWithGroupSync", 0) => CompileAllMemoryBarrierWithGroupSync(context, builder, functionType),
            // group any
            (_, "any", 1) => CompileAny(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group asdouble
            (_, "asdouble", 2) => CompileAsdouble(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group asfloat
            (_, "asfloat", 1) => CompileAsfloat(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group asfloat16
            (_, "asfloat16", 1) => CompileAsfloat16(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group asint16
            (_, "asint16", 1) => CompileAsint16(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group asin
            (_, "asin", 1) => CompileAsin(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group asint
            (_, "asint", 1) => CompileAsint(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group asuint
            (_, "asuint", 3) => CompileAsuint(context, builder, functionType, d: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), x: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), y: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            (_, "asuint", 1) => CompileAsuint(context, builder, functionType, x: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group asuint16
            (_, "asuint16", 1) => CompileAsuint16(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group atan
            (_, "atan", 1) => CompileAtan(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group atan2
            (_, "atan2", 2) => CompileAtan2(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group ceil
            (_, "ceil", 1) => CompileCeil(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group clamp
            (_, "clamp", 3) => CompileClamp(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group clip
            (_, "clip", 1) => CompileClip(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group cos
            (_, "cos", 1) => CompileCos(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group cosh
            (_, "cosh", 1) => CompileCosh(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group countbits
            (_, "countbits", 1) => CompileCountbits(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group cross
            (_, "cross", 2) => CompileCross(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group ddx
            (_, "ddx", 1) => CompileDdx(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group ddx_coarse
            (_, "ddx_coarse", 1) => CompileDdx_coarse(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group ddx_fine
            (_, "ddx_fine", 1) => CompileDdx_fine(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group ddy
            (_, "ddy", 1) => CompileDdy(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group ddy_coarse
            (_, "ddy_coarse", 1) => CompileDdy_coarse(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group ddy_fine
            (_, "ddy_fine", 1) => CompileDdy_fine(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group degrees
            (_, "degrees", 1) => CompileDegrees(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group determinant
            (_, "determinant", 1) => CompileDeterminant(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group DeviceMemoryBarrier
            (_, "DeviceMemoryBarrier", 0) => CompileDeviceMemoryBarrier(context, builder, functionType),
            // group DeviceMemoryBarrierWithGroupSync
            (_, "DeviceMemoryBarrierWithGroupSync", 0) => CompileDeviceMemoryBarrierWithGroupSync(context, builder, functionType),
            // group distance
            (_, "distance", 2) => CompileDistance(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group dot
            (_, "dot", 2) => CompileDot(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group dst
            (_, "dst", 2) => CompileDst(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group EvaluateAttributeAtSample
            (_, "EvaluateAttributeAtSample", 2) => CompileEvaluateAttributeAtSample(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group EvaluateAttributeCentroid
            (_, "EvaluateAttributeCentroid", 1) => CompileEvaluateAttributeCentroid(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group EvaluateAttributeSnapped
            (_, "EvaluateAttributeSnapped", 2) => CompileEvaluateAttributeSnapped(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group GetAttributeAtVertex
            (_, "GetAttributeAtVertex", 2) => CompileGetAttributeAtVertex(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group exp
            (_, "exp", 1) => CompileExp(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group exp2
            (_, "exp2", 1) => CompileExp2(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group f16tof32
            (_, "f16tof32", 1) => CompileF16tof32(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group f32tof16
            (_, "f32tof16", 1) => CompileF32tof16(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group faceforward
            (_, "faceforward", 3) => CompileFaceforward(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group firstbithigh
            (_, "firstbithigh", 1) => CompileFirstbithigh(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group firstbitlow
            (_, "firstbitlow", 1) => CompileFirstbitlow(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group floor
            (_, "floor", 1) => CompileFloor(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group fma
            (_, "fma", 3) => CompileFma(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group fmod
            (_, "fmod", 2) => CompileFmod(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group frac
            (_, "frac", 1) => CompileFrac(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group frexp
            (_, "frexp", 2) => CompileFrexp(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group fwidth
            (_, "fwidth", 1) => CompileFwidth(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group GroupMemoryBarrier
            (_, "GroupMemoryBarrier", 0) => CompileGroupMemoryBarrier(context, builder, functionType),
            // group GroupMemoryBarrierWithGroupSync
            (_, "GroupMemoryBarrierWithGroupSync", 0) => CompileGroupMemoryBarrierWithGroupSync(context, builder, functionType),
            // group InterlockedAdd
            (_, "InterlockedAdd", 2) => CompileInterlockedAdd(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedAdd", 3) => CompileInterlockedAdd(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedMin
            (_, "InterlockedMin", 2) => CompileInterlockedMin(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedMin", 3) => CompileInterlockedMin(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedMax
            (_, "InterlockedMax", 2) => CompileInterlockedMax(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedMax", 3) => CompileInterlockedMax(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedAnd
            (_, "InterlockedAnd", 2) => CompileInterlockedAnd(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedAnd", 3) => CompileInterlockedAnd(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedOr
            (_, "InterlockedOr", 2) => CompileInterlockedOr(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedOr", 3) => CompileInterlockedOr(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedXor
            (_, "InterlockedXor", 2) => CompileInterlockedXor(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedXor", 3) => CompileInterlockedXor(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedCompareStore
            (_, "InterlockedCompareStore", 3) => CompileInterlockedCompareStore(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedExchange
            (_, "InterlockedExchange", 3) => CompileInterlockedExchange(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedCompareExchange
            (_, "InterlockedCompareExchange", 4) => CompileInterlockedCompareExchange(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group InterlockedCompareStoreFloatBitwise
            (_, "InterlockedCompareStoreFloatBitwise", 3) => CompileInterlockedCompareStoreFloatBitwise(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedCompareExchangeFloatBitwise
            (_, "InterlockedCompareExchangeFloatBitwise", 4) => CompileInterlockedCompareExchangeFloatBitwise(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group isfinite
            (_, "isfinite", 1) => CompileIsfinite(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group isinf
            (_, "isinf", 1) => CompileIsinf(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group isnan
            (_, "isnan", 1) => CompileIsnan(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group isnormal
            (_, "isnormal", 1) => CompileIsnormal(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group ldexp
            (_, "ldexp", 2) => CompileLdexp(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group length
            (_, "length", 1) => CompileLength(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group lerp
            (_, "lerp", 3) => CompileLerp(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group lit
            (_, "lit", 3) => CompileLit(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group log
            (_, "log", 1) => CompileLog(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group log10
            (_, "log10", 1) => CompileLog10(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group log2
            (_, "log2", 1) => CompileLog2(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group mad
            (_, "mad", 3) => CompileMad(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group max
            (_, "max", 2) => CompileMax(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group min
            (_, "min", 2) => CompileMin(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group modf
            (_, "modf", 2) => CompileModf(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group msad4
            (_, "msad4", 3) => CompileMsad4(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group mul
            (_, "mul", 2) => CompileMul(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group normalize
            (_, "normalize", 1) => CompileNormalize(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group pow
            (_, "pow", 2) => CompilePow(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group Process2DQuadTessFactorsAvg
            (_, "Process2DQuadTessFactorsAvg", 5) => CompileProcess2DQuadTessFactorsAvg(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            // group Process2DQuadTessFactorsMax
            (_, "Process2DQuadTessFactorsMax", 5) => CompileProcess2DQuadTessFactorsMax(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            // group Process2DQuadTessFactorsMin
            (_, "Process2DQuadTessFactorsMin", 5) => CompileProcess2DQuadTessFactorsMin(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            // group ProcessIsolineTessFactors
            (_, "ProcessIsolineTessFactors", 4) => CompileProcessIsolineTessFactors(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group ProcessQuadTessFactorsAvg
            (_, "ProcessQuadTessFactorsAvg", 5) => CompileProcessQuadTessFactorsAvg(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            // group ProcessQuadTessFactorsMax
            (_, "ProcessQuadTessFactorsMax", 5) => CompileProcessQuadTessFactorsMax(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            // group ProcessQuadTessFactorsMin
            (_, "ProcessQuadTessFactorsMin", 5) => CompileProcessQuadTessFactorsMin(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            // group ProcessTriTessFactorsAvg
            (_, "ProcessTriTessFactorsAvg", 5) => CompileProcessTriTessFactorsAvg(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            // group ProcessTriTessFactorsMax
            (_, "ProcessTriTessFactorsMax", 5) => CompileProcessTriTessFactorsMax(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            // group ProcessTriTessFactorsMin
            (_, "ProcessTriTessFactorsMin", 5) => CompileProcessTriTessFactorsMin(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            // group radians
            (_, "radians", 1) => CompileRadians(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group rcp
            (_, "rcp", 1) => CompileRcp(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group reflect
            (_, "reflect", 2) => CompileReflect(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group refract
            (_, "refract", 3) => CompileRefract(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group reversebits
            (_, "reversebits", 1) => CompileReversebits(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group round
            (_, "round", 1) => CompileRound(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group rsqrt
            (_, "rsqrt", 1) => CompileRsqrt(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group saturate
            (_, "saturate", 1) => CompileSaturate(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group sign
            (_, "sign", 1) => CompileSign(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group sin
            (_, "sin", 1) => CompileSin(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group sincos
            (_, "sincos", 3) => CompileSincos(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group sinh
            (_, "sinh", 1) => CompileSinh(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group smoothstep
            (_, "smoothstep", 3) => CompileSmoothstep(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group source_mark
            (_, "source_mark", 0) => CompileSource_mark(context, builder, functionType),
            // group sqrt
            (_, "sqrt", 1) => CompileSqrt(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group step
            (_, "step", 2) => CompileStep(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group tan
            (_, "tan", 1) => CompileTan(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group tanh
            (_, "tanh", 1) => CompileTanh(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group tex1D
            (_, "tex1D", 2) => CompileTex1D(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "tex1D", 4) => CompileTex1D(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), ddx: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), ddy: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group tex1Dbias
            (_, "tex1Dbias", 2) => CompileTex1Dbias(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group tex1Dgrad
            (_, "tex1Dgrad", 4) => CompileTex1Dgrad(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group tex1Dlod
            (_, "tex1Dlod", 2) => CompileTex1Dlod(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group tex1Dproj
            (_, "tex1Dproj", 2) => CompileTex1Dproj(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group tex2D
            (_, "tex2D", 2) => CompileTex2D(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "tex2D", 4) => CompileTex2D(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), ddx: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), ddy: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group tex2Dbias
            (_, "tex2Dbias", 2) => CompileTex2Dbias(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group tex2Dgrad
            (_, "tex2Dgrad", 4) => CompileTex2Dgrad(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group tex2Dlod
            (_, "tex2Dlod", 2) => CompileTex2Dlod(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group tex2Dproj
            (_, "tex2Dproj", 2) => CompileTex2Dproj(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group tex3D
            (_, "tex3D", 2) => CompileTex3D(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "tex3D", 4) => CompileTex3D(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), ddx: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), ddy: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group tex3Dbias
            (_, "tex3Dbias", 2) => CompileTex3Dbias(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group tex3Dgrad
            (_, "tex3Dgrad", 4) => CompileTex3Dgrad(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group tex3Dlod
            (_, "tex3Dlod", 2) => CompileTex3Dlod(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group tex3Dproj
            (_, "tex3Dproj", 2) => CompileTex3Dproj(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group texCUBE
            (_, "texCUBE", 2) => CompileTexCUBE(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "texCUBE", 4) => CompileTexCUBE(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), ddx: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), ddy: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group texCUBEbias
            (_, "texCUBEbias", 2) => CompileTexCUBEbias(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group texCUBEgrad
            (_, "texCUBEgrad", 4) => CompileTexCUBEgrad(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group texCUBElod
            (_, "texCUBElod", 2) => CompileTexCUBElod(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group texCUBEproj
            (_, "texCUBEproj", 2) => CompileTexCUBEproj(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group transpose
            (_, "transpose", 1) => CompileTranspose(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group trunc
            (_, "trunc", 1) => CompileTrunc(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group CheckAccessFullyMapped
            (_, "CheckAccessFullyMapped", 1) => CompileCheckAccessFullyMapped(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group AddUint64
            (_, "AddUint64", 2) => CompileAddUint64(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group NonUniformResourceIndex
            (_, "NonUniformResourceIndex", 1) => CompileNonUniformResourceIndex(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WaveIsFirstLane
            (_, "WaveIsFirstLane", 0) => CompileWaveIsFirstLane(context, builder, functionType),
            // group WaveGetLaneIndex
            (_, "WaveGetLaneIndex", 0) => CompileWaveGetLaneIndex(context, builder, functionType),
            // group WaveGetLaneCount
            (_, "WaveGetLaneCount", 0) => CompileWaveGetLaneCount(context, builder, functionType),
            // group WaveActiveAnyTrue
            (_, "WaveActiveAnyTrue", 1) => CompileWaveActiveAnyTrue(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WaveActiveAllTrue
            (_, "WaveActiveAllTrue", 1) => CompileWaveActiveAllTrue(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WaveActiveAllEqual
            (_, "WaveActiveAllEqual", 1) => CompileWaveActiveAllEqual(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WaveActiveBallot
            (_, "WaveActiveBallot", 1) => CompileWaveActiveBallot(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WaveReadLaneAt
            (_, "WaveReadLaneAt", 2) => CompileWaveReadLaneAt(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group WaveReadLaneFirst
            (_, "WaveReadLaneFirst", 1) => CompileWaveReadLaneFirst(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WaveActiveCountBits
            (_, "WaveActiveCountBits", 1) => CompileWaveActiveCountBits(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WaveActiveSum
            (_, "WaveActiveSum", 1) => CompileWaveActiveSum(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WaveActiveProduct
            (_, "WaveActiveProduct", 1) => CompileWaveActiveProduct(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WaveActiveBitAnd
            (_, "WaveActiveBitAnd", 1) => CompileWaveActiveBitAnd(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WaveActiveBitOr
            (_, "WaveActiveBitOr", 1) => CompileWaveActiveBitOr(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WaveActiveBitXor
            (_, "WaveActiveBitXor", 1) => CompileWaveActiveBitXor(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WaveActiveMin
            (_, "WaveActiveMin", 1) => CompileWaveActiveMin(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WaveActiveMax
            (_, "WaveActiveMax", 1) => CompileWaveActiveMax(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WavePrefixCountBits
            (_, "WavePrefixCountBits", 1) => CompileWavePrefixCountBits(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WavePrefixSum
            (_, "WavePrefixSum", 1) => CompileWavePrefixSum(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WavePrefixProduct
            (_, "WavePrefixProduct", 1) => CompileWavePrefixProduct(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WaveMatch
            (_, "WaveMatch", 1) => CompileWaveMatch(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group WaveMultiPrefixBitAnd
            (_, "WaveMultiPrefixBitAnd", 2) => CompileWaveMultiPrefixBitAnd(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group WaveMultiPrefixBitOr
            (_, "WaveMultiPrefixBitOr", 2) => CompileWaveMultiPrefixBitOr(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group WaveMultiPrefixBitXor
            (_, "WaveMultiPrefixBitXor", 2) => CompileWaveMultiPrefixBitXor(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group WaveMultiPrefixCountBits
            (_, "WaveMultiPrefixCountBits", 2) => CompileWaveMultiPrefixCountBits(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group WaveMultiPrefixProduct
            (_, "WaveMultiPrefixProduct", 2) => CompileWaveMultiPrefixProduct(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group WaveMultiPrefixSum
            (_, "WaveMultiPrefixSum", 2) => CompileWaveMultiPrefixSum(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group QuadReadLaneAt
            (_, "QuadReadLaneAt", 2) => CompileQuadReadLaneAt(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group QuadReadAcrossX
            (_, "QuadReadAcrossX", 1) => CompileQuadReadAcrossX(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group QuadReadAcrossY
            (_, "QuadReadAcrossY", 1) => CompileQuadReadAcrossY(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group QuadReadAcrossDiagonal
            (_, "QuadReadAcrossDiagonal", 1) => CompileQuadReadAcrossDiagonal(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group QuadAny
            (_, "QuadAny", 1) => CompileQuadAny(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group QuadAll
            (_, "QuadAll", 1) => CompileQuadAll(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group GetGroupWaveIndex
            (_, "GetGroupWaveIndex", 0) => CompileGetGroupWaveIndex(context, builder, functionType),
            // group GetGroupWaveCount
            (_, "GetGroupWaveCount", 0) => CompileGetGroupWaveCount(context, builder, functionType),
            // group TraceRay
            (_, "TraceRay", 8) => CompileTraceRay(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type)), new SpirvValue(compiledParams[7], context.GetOrRegister(functionType.ParameterTypes[7].Type))),
            // group ReportHit
            (_, "ReportHit", 3) => CompileReportHit(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group CallShader
            (_, "CallShader", 2) => CompileCallShader(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group IgnoreHit
            (_, "IgnoreHit", 0) => CompileIgnoreHit(context, builder, functionType),
            // group AcceptHitAndEndSearch
            (_, "AcceptHitAndEndSearch", 0) => CompileAcceptHitAndEndSearch(context, builder, functionType),
            // group DispatchRaysIndex
            (_, "DispatchRaysIndex", 0) => CompileDispatchRaysIndex(context, builder, functionType),
            // group DispatchRaysDimensions
            (_, "DispatchRaysDimensions", 0) => CompileDispatchRaysDimensions(context, builder, functionType),
            // group WorldRayOrigin
            (_, "WorldRayOrigin", 0) => CompileWorldRayOrigin(context, builder, functionType),
            // group WorldRayDirection
            (_, "WorldRayDirection", 0) => CompileWorldRayDirection(context, builder, functionType),
            // group ObjectRayOrigin
            (_, "ObjectRayOrigin", 0) => CompileObjectRayOrigin(context, builder, functionType),
            // group ObjectRayDirection
            (_, "ObjectRayDirection", 0) => CompileObjectRayDirection(context, builder, functionType),
            // group RayTMin
            (_, "RayTMin", 0) => CompileRayTMin(context, builder, functionType),
            // group RayTCurrent
            (_, "RayTCurrent", 0) => CompileRayTCurrent(context, builder, functionType),
            // group PrimitiveIndex
            (_, "PrimitiveIndex", 0) => CompilePrimitiveIndex(context, builder, functionType),
            // group InstanceID
            (_, "InstanceID", 0) => CompileInstanceID(context, builder, functionType),
            // group InstanceIndex
            (_, "InstanceIndex", 0) => CompileInstanceIndex(context, builder, functionType),
            // group GeometryIndex
            (_, "GeometryIndex", 0) => CompileGeometryIndex(context, builder, functionType),
            // group HitKind
            (_, "HitKind", 0) => CompileHitKind(context, builder, functionType),
            // group RayFlags
            (_, "RayFlags", 0) => CompileRayFlags(context, builder, functionType),
            // group ObjectToWorld
            (_, "ObjectToWorld", 0) => CompileObjectToWorld(context, builder, functionType),
            // group WorldToObject
            (_, "WorldToObject", 0) => CompileWorldToObject(context, builder, functionType),
            // group ObjectToWorld3x4
            (_, "ObjectToWorld3x4", 0) => CompileObjectToWorld3x4(context, builder, functionType),
            // group WorldToObject3x4
            (_, "WorldToObject3x4", 0) => CompileWorldToObject3x4(context, builder, functionType),
            // group ObjectToWorld4x3
            (_, "ObjectToWorld4x3", 0) => CompileObjectToWorld4x3(context, builder, functionType),
            // group WorldToObject4x3
            (_, "WorldToObject4x3", 0) => CompileWorldToObject4x3(context, builder, functionType),
        };
    }
}

public abstract class VkIntrinsicsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileReadClock(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue scope) => throw new NotImplementedException();
    public virtual SpirvValue CompileRawBufferLoad(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue addr, SpirvValue? alignment = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileRawBufferStore(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue addr, SpirvValue value, SpirvValue? alignment = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileStatic_pointer_cast(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue ptr) => throw new NotImplementedException();
    public virtual SpirvValue CompileReinterpret_pointer_cast(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue ptr) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group ReadClock
            (_, "ReadClock", 1) => CompileReadClock(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group RawBufferLoad
            (_, "RawBufferLoad", 1) => CompileRawBufferLoad(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            (_, "RawBufferLoad", 2) => CompileRawBufferLoad(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), alignment: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group RawBufferStore
            (_, "RawBufferStore", 2) => CompileRawBufferStore(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "RawBufferStore", 3) => CompileRawBufferStore(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), alignment: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group static_pointer_cast
            (_, "static_pointer_cast", 1) => CompileStatic_pointer_cast(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group reinterpret_pointer_cast
            (_, "reinterpret_pointer_cast", 1) => CompileReinterpret_pointer_cast(context, builder, functionType, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
        };
    }
}

public abstract class BufferPointerMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileGetBufferContents(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue bufferPointer) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group GetBufferContents
            (_, "GetBufferContents", 0) => CompileGetBufferContents(context, builder, functionType, thisValue.Value),
        };
    }
}

public abstract class StreamMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileAppend(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue stream, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileRestartStrip(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue stream) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group Append
            (_, "Append", 1) => CompileAppend(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group RestartStrip
            (_, "RestartStrip", 0) => CompileRestartStrip(context, builder, functionType, thisValue.Value),
        };
    }
}

public abstract class TextureMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileCalculateLevelOfDetail(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileCalculateLevelOfDetailUnclamped(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetDimensions(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue? x = null, SpirvValue? width = null, SpirvValue? levels = null, SpirvValue? elements = null, SpirvValue? height = null, SpirvValue? samples = null, SpirvValue? depth = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileLoad(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue x, SpirvValue? o = null, SpirvValue? status = null, SpirvValue? s = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileSample(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue? o = null, SpirvValue? clamp = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileSampleBias(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue bias, SpirvValue? o = null, SpirvValue? clamp = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileSampleCmp(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue compareValue, SpirvValue? o = null, SpirvValue? clamp = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileSampleCmpBias(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue compareValue, SpirvValue bias, SpirvValue? o = null, SpirvValue? clamp = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileSampleCmpGrad(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue compareValue, SpirvValue ddx, SpirvValue ddy, SpirvValue? o = null, SpirvValue? clamp = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileSampleCmpLevel(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue? compareValue = null, SpirvValue? lod = null, SpirvValue? o = null, SpirvValue? status = null, SpirvValue? c = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileSampleCmpLevelZero(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue compareValue, SpirvValue? o = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileSampleGrad(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue ddx, SpirvValue ddy, SpirvValue? o = null, SpirvValue? clamp = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileSampleLevel(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue lod, SpirvValue? o = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileGather(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue? o = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileGatherAlpha(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue? o = null, SpirvValue? o1 = null, SpirvValue? o2 = null, SpirvValue? o3 = null, SpirvValue? o4 = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileGatherBlue(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue? o = null, SpirvValue? o1 = null, SpirvValue? o2 = null, SpirvValue? o3 = null, SpirvValue? o4 = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileGatherCmp(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue compareValue, SpirvValue? o = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileGatherCmpAlpha(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue compareValue, SpirvValue? o = null, SpirvValue? o1 = null, SpirvValue? o2 = null, SpirvValue? o3 = null, SpirvValue? o4 = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileGatherCmpBlue(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue compareValue, SpirvValue? o = null, SpirvValue? o1 = null, SpirvValue? o2 = null, SpirvValue? o3 = null, SpirvValue? o4 = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileGatherCmpGreen(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue compareValue, SpirvValue? o = null, SpirvValue? o1 = null, SpirvValue? o2 = null, SpirvValue? o3 = null, SpirvValue? o4 = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileGatherCmpRed(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue compareValue, SpirvValue? o = null, SpirvValue? o1 = null, SpirvValue? o2 = null, SpirvValue? o3 = null, SpirvValue? o4 = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileGatherGreen(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue? o = null, SpirvValue? o1 = null, SpirvValue? o2 = null, SpirvValue? o3 = null, SpirvValue? o4 = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileGatherRed(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue? o = null, SpirvValue? o1 = null, SpirvValue? o2 = null, SpirvValue? o3 = null, SpirvValue? o4 = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileGatherRaw(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s, SpirvValue x, SpirvValue? o = null, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetSamplePosition(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue texture, SpirvValue s) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group CalculateLevelOfDetail
            (_, "CalculateLevelOfDetail", 2) => CompileCalculateLevelOfDetail(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group CalculateLevelOfDetailUnclamped
            (_, "CalculateLevelOfDetailUnclamped", 2) => CompileCalculateLevelOfDetailUnclamped(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group GetDimensions
            ("Texture1DMethods", "GetDimensions", 3) => CompileGetDimensions(context, builder, functionType, thisValue.Value, x: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), width: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), levels: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DMSMethods", "GetDimensions", 3) => CompileGetDimensions(context, builder, functionType, thisValue.Value, width: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), height: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), samples: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("RWTexture2DMSMethods", "GetDimensions", 3) => CompileGetDimensions(context, builder, functionType, thisValue.Value, width: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), height: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), samples: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DArrayMethods", "GetDimensions", 3) => CompileGetDimensions(context, builder, functionType, thisValue.Value, width: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), height: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), elements: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("TextureCUBEArrayMethods", "GetDimensions", 3) => CompileGetDimensions(context, builder, functionType, thisValue.Value, width: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), height: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), elements: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("RWTexture2DArrayMethods", "GetDimensions", 3) => CompileGetDimensions(context, builder, functionType, thisValue.Value, width: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), height: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), elements: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture3DMethods", "GetDimensions", 3) => CompileGetDimensions(context, builder, functionType, thisValue.Value, width: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), height: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), depth: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("RWTexture3DMethods", "GetDimensions", 3) => CompileGetDimensions(context, builder, functionType, thisValue.Value, width: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), height: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), depth: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            (_, "GetDimensions", 1) => CompileGetDimensions(context, builder, functionType, thisValue.Value, width: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            ("Texture1DArrayMethods", "GetDimensions", 4) => CompileGetDimensions(context, builder, functionType, thisValue.Value, x: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), width: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), elements: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), levels: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DMethods", "GetDimensions", 4) => CompileGetDimensions(context, builder, functionType, thisValue.Value, x: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), width: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), height: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), levels: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEMethods", "GetDimensions", 4) => CompileGetDimensions(context, builder, functionType, thisValue.Value, x: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), width: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), height: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), levels: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DArrayMSMethods", "GetDimensions", 4) => CompileGetDimensions(context, builder, functionType, thisValue.Value, width: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), height: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), elements: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), samples: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("RWTexture2DMSArrayMethods", "GetDimensions", 4) => CompileGetDimensions(context, builder, functionType, thisValue.Value, width: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), height: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), elements: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), samples: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture1DArrayMethods", "GetDimensions", 2) => CompileGetDimensions(context, builder, functionType, thisValue.Value, width: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), elements: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("RWTexture1DArrayMethods", "GetDimensions", 2) => CompileGetDimensions(context, builder, functionType, thisValue.Value, width: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), elements: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("Texture2DMethods", "GetDimensions", 2) => CompileGetDimensions(context, builder, functionType, thisValue.Value, width: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), height: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("TextureCUBEMethods", "GetDimensions", 2) => CompileGetDimensions(context, builder, functionType, thisValue.Value, width: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), height: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("RWTexture2DMethods", "GetDimensions", 2) => CompileGetDimensions(context, builder, functionType, thisValue.Value, width: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), height: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("Texture2DArrayMethods", "GetDimensions", 5) => CompileGetDimensions(context, builder, functionType, thisValue.Value, x: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), width: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), height: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), elements: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), levels: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("TextureCUBEArrayMethods", "GetDimensions", 5) => CompileGetDimensions(context, builder, functionType, thisValue.Value, x: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), width: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), height: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), elements: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), levels: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture3DMethods", "GetDimensions", 5) => CompileGetDimensions(context, builder, functionType, thisValue.Value, x: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), width: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), height: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), depth: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), levels: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            // group Load
            (_, "Load", 1) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            ("Texture1DMethods", "Load", 2) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), o: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("Texture1DArrayMethods", "Load", 2) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), o: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("Texture2DMethods", "Load", 2) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), o: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("Texture2DArrayMethods", "Load", 2) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), o: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("Texture3DMethods", "Load", 2) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), o: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("Texture2DMSMethods", "Load", 2) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), s: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("Texture2DArrayMSMethods", "Load", 2) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), s: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("RWTexture2DMSMethods", "Load", 2) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), s: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("RWTexture2DMSArrayMethods", "Load", 2) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), s: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("RWTexture1DMethods", "Load", 2) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), status: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("RWTexture1DArrayMethods", "Load", 2) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), status: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("RWTexture2DMethods", "Load", 2) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), status: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("RWTexture2DArrayMethods", "Load", 2) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), status: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("RWTexture3DMethods", "Load", 2) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), status: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("Texture1DMethods", "Load", 3) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), o: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), status: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture1DArrayMethods", "Load", 3) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), o: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), status: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DMethods", "Load", 3) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), o: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), status: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DArrayMethods", "Load", 3) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), o: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), status: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture3DMethods", "Load", 3) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), o: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), status: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DMSMethods", "Load", 3) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), s: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DArrayMSMethods", "Load", 3) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), s: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("RWTexture2DMSMethods", "Load", 3) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), s: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), status: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("RWTexture2DMSArrayMethods", "Load", 3) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), s: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), status: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            (_, "Load", 4) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), s: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group Sample
            (_, "Sample", 2) => CompileSample(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("Texture1DMethods", "Sample", 3) => CompileSample(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture1DArrayMethods", "Sample", 3) => CompileSample(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DMethods", "Sample", 3) => CompileSample(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DArrayMethods", "Sample", 3) => CompileSample(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture3DMethods", "Sample", 3) => CompileSample(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("TextureCUBEMethods", "Sample", 3) => CompileSample(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), clamp: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("TextureCUBEArrayMethods", "Sample", 3) => CompileSample(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), clamp: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture1DMethods", "Sample", 4) => CompileSample(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), clamp: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture1DArrayMethods", "Sample", 4) => CompileSample(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), clamp: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DMethods", "Sample", 4) => CompileSample(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), clamp: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DArrayMethods", "Sample", 4) => CompileSample(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), clamp: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture3DMethods", "Sample", 4) => CompileSample(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), clamp: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEMethods", "Sample", 4) => CompileSample(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), clamp: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEArrayMethods", "Sample", 4) => CompileSample(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), clamp: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            (_, "Sample", 5) => CompileSample(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), clamp: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), status: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            // group SampleBias
            (_, "SampleBias", 3) => CompileSampleBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture1DMethods", "SampleBias", 4) => CompileSampleBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture1DArrayMethods", "SampleBias", 4) => CompileSampleBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DMethods", "SampleBias", 4) => CompileSampleBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DArrayMethods", "SampleBias", 4) => CompileSampleBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture3DMethods", "SampleBias", 4) => CompileSampleBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEMethods", "SampleBias", 4) => CompileSampleBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), clamp: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEArrayMethods", "SampleBias", 4) => CompileSampleBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), clamp: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture1DMethods", "SampleBias", 5) => CompileSampleBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture1DArrayMethods", "SampleBias", 5) => CompileSampleBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture2DMethods", "SampleBias", 5) => CompileSampleBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture2DArrayMethods", "SampleBias", 5) => CompileSampleBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture3DMethods", "SampleBias", 5) => CompileSampleBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("TextureCUBEMethods", "SampleBias", 5) => CompileSampleBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), clamp: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), status: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("TextureCUBEArrayMethods", "SampleBias", 5) => CompileSampleBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), clamp: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), status: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            (_, "SampleBias", 6) => CompileSampleBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), status: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            // group SampleCmp
            (_, "SampleCmp", 3) => CompileSampleCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture1DMethods", "SampleCmp", 4) => CompileSampleCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture1DArrayMethods", "SampleCmp", 4) => CompileSampleCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DMethods", "SampleCmp", 4) => CompileSampleCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DArrayMethods", "SampleCmp", 4) => CompileSampleCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEMethods", "SampleCmp", 4) => CompileSampleCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), clamp: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEArrayMethods", "SampleCmp", 4) => CompileSampleCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), clamp: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture1DMethods", "SampleCmp", 5) => CompileSampleCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture1DArrayMethods", "SampleCmp", 5) => CompileSampleCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture2DMethods", "SampleCmp", 5) => CompileSampleCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture2DArrayMethods", "SampleCmp", 5) => CompileSampleCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("TextureCUBEMethods", "SampleCmp", 5) => CompileSampleCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), clamp: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), status: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("TextureCUBEArrayMethods", "SampleCmp", 5) => CompileSampleCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), clamp: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), status: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            (_, "SampleCmp", 6) => CompileSampleCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), status: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            // group SampleCmpBias
            (_, "SampleCmpBias", 4) => CompileSampleCmpBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture1DMethods", "SampleCmpBias", 5) => CompileSampleCmpBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture1DArrayMethods", "SampleCmpBias", 5) => CompileSampleCmpBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture2DMethods", "SampleCmpBias", 5) => CompileSampleCmpBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture2DArrayMethods", "SampleCmpBias", 5) => CompileSampleCmpBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("TextureCUBEMethods", "SampleCmpBias", 5) => CompileSampleCmpBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("TextureCUBEArrayMethods", "SampleCmpBias", 5) => CompileSampleCmpBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture1DMethods", "SampleCmpBias", 6) => CompileSampleCmpBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), clamp: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            ("Texture1DArrayMethods", "SampleCmpBias", 6) => CompileSampleCmpBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), clamp: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            ("Texture2DMethods", "SampleCmpBias", 6) => CompileSampleCmpBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), clamp: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            ("Texture2DArrayMethods", "SampleCmpBias", 6) => CompileSampleCmpBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), clamp: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            ("TextureCUBEMethods", "SampleCmpBias", 6) => CompileSampleCmpBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), status: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            ("TextureCUBEArrayMethods", "SampleCmpBias", 6) => CompileSampleCmpBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), status: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            (_, "SampleCmpBias", 7) => CompileSampleCmpBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), clamp: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), status: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type))),
            // group SampleCmpGrad
            (_, "SampleCmpGrad", 5) => CompileSampleCmpGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture1DMethods", "SampleCmpGrad", 6) => CompileSampleCmpGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            ("Texture1DArrayMethods", "SampleCmpGrad", 6) => CompileSampleCmpGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            ("Texture2DMethods", "SampleCmpGrad", 6) => CompileSampleCmpGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            ("Texture2DArrayMethods", "SampleCmpGrad", 6) => CompileSampleCmpGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            ("TextureCUBEMethods", "SampleCmpGrad", 6) => CompileSampleCmpGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), clamp: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            ("TextureCUBEArrayMethods", "SampleCmpGrad", 6) => CompileSampleCmpGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), clamp: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            ("Texture1DMethods", "SampleCmpGrad", 7) => CompileSampleCmpGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), clamp: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type))),
            ("Texture1DArrayMethods", "SampleCmpGrad", 7) => CompileSampleCmpGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), clamp: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type))),
            ("Texture2DMethods", "SampleCmpGrad", 7) => CompileSampleCmpGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), clamp: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type))),
            ("Texture2DArrayMethods", "SampleCmpGrad", 7) => CompileSampleCmpGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), clamp: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type))),
            ("TextureCUBEMethods", "SampleCmpGrad", 7) => CompileSampleCmpGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), clamp: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), status: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type))),
            ("TextureCUBEArrayMethods", "SampleCmpGrad", 7) => CompileSampleCmpGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), clamp: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), status: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type))),
            (_, "SampleCmpGrad", 8) => CompileSampleCmpGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), clamp: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type)), status: new SpirvValue(compiledParams[7], context.GetOrRegister(functionType.ParameterTypes[7].Type))),
            // group SampleCmpLevel
            ("Texture1DMethods", "SampleCmpLevel", 4) => CompileSampleCmpLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), compareValue: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), lod: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture1DArrayMethods", "SampleCmpLevel", 4) => CompileSampleCmpLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), compareValue: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), lod: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DMethods", "SampleCmpLevel", 4) => CompileSampleCmpLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), compareValue: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), lod: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DArrayMethods", "SampleCmpLevel", 4) => CompileSampleCmpLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), compareValue: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), lod: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEMethods", "SampleCmpLevel", 4) => CompileSampleCmpLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), c: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), lod: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEArrayMethods", "SampleCmpLevel", 4) => CompileSampleCmpLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), c: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), lod: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture1DMethods", "SampleCmpLevel", 5) => CompileSampleCmpLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), compareValue: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), lod: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture1DArrayMethods", "SampleCmpLevel", 5) => CompileSampleCmpLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), compareValue: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), lod: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture2DMethods", "SampleCmpLevel", 5) => CompileSampleCmpLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), compareValue: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), lod: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture2DArrayMethods", "SampleCmpLevel", 5) => CompileSampleCmpLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), compareValue: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), lod: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("TextureCUBEMethods", "SampleCmpLevel", 5) => CompileSampleCmpLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), compareValue: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), lod: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), status: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("TextureCUBEArrayMethods", "SampleCmpLevel", 5) => CompileSampleCmpLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), compareValue: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), lod: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), status: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            (_, "SampleCmpLevel", 6) => CompileSampleCmpLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), compareValue: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), lod: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), status: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            // group SampleCmpLevelZero
            (_, "SampleCmpLevelZero", 3) => CompileSampleCmpLevelZero(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture1DMethods", "SampleCmpLevelZero", 4) => CompileSampleCmpLevelZero(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture1DArrayMethods", "SampleCmpLevelZero", 4) => CompileSampleCmpLevelZero(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DMethods", "SampleCmpLevelZero", 4) => CompileSampleCmpLevelZero(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DArrayMethods", "SampleCmpLevelZero", 4) => CompileSampleCmpLevelZero(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEMethods", "SampleCmpLevelZero", 4) => CompileSampleCmpLevelZero(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEArrayMethods", "SampleCmpLevelZero", 4) => CompileSampleCmpLevelZero(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            (_, "SampleCmpLevelZero", 5) => CompileSampleCmpLevelZero(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), status: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            // group SampleGrad
            (_, "SampleGrad", 4) => CompileSampleGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture1DMethods", "SampleGrad", 5) => CompileSampleGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture1DArrayMethods", "SampleGrad", 5) => CompileSampleGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture2DMethods", "SampleGrad", 5) => CompileSampleGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture2DArrayMethods", "SampleGrad", 5) => CompileSampleGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture3DMethods", "SampleGrad", 5) => CompileSampleGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("TextureCUBEMethods", "SampleGrad", 5) => CompileSampleGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("TextureCUBEArrayMethods", "SampleGrad", 5) => CompileSampleGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            ("Texture1DMethods", "SampleGrad", 6) => CompileSampleGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), clamp: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            ("Texture1DArrayMethods", "SampleGrad", 6) => CompileSampleGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), clamp: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            ("Texture2DMethods", "SampleGrad", 6) => CompileSampleGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), clamp: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            ("Texture2DArrayMethods", "SampleGrad", 6) => CompileSampleGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), clamp: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            ("Texture3DMethods", "SampleGrad", 6) => CompileSampleGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), clamp: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            ("TextureCUBEMethods", "SampleGrad", 6) => CompileSampleGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), status: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            ("TextureCUBEArrayMethods", "SampleGrad", 6) => CompileSampleGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), status: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            (_, "SampleGrad", 7) => CompileSampleGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), clamp: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), status: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type))),
            // group SampleLevel
            (_, "SampleLevel", 3) => CompileSampleLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture1DMethods", "SampleLevel", 4) => CompileSampleLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture1DArrayMethods", "SampleLevel", 4) => CompileSampleLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DMethods", "SampleLevel", 4) => CompileSampleLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DArrayMethods", "SampleLevel", 4) => CompileSampleLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture3DMethods", "SampleLevel", 4) => CompileSampleLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEMethods", "SampleLevel", 4) => CompileSampleLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEArrayMethods", "SampleLevel", 4) => CompileSampleLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            (_, "SampleLevel", 5) => CompileSampleLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), status: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            // group Gather
            (_, "Gather", 2) => CompileGather(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("Texture2DMethods", "Gather", 3) => CompileGather(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DArrayMethods", "Gather", 3) => CompileGather(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("TextureCUBEMethods", "Gather", 3) => CompileGather(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), status: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("TextureCUBEArrayMethods", "Gather", 3) => CompileGather(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), status: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            (_, "Gather", 4) => CompileGather(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group GatherAlpha
            (_, "GatherAlpha", 2) => CompileGatherAlpha(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("Texture2DMethods", "GatherAlpha", 3) => CompileGatherAlpha(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DArrayMethods", "GatherAlpha", 3) => CompileGatherAlpha(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("TextureCUBEMethods", "GatherAlpha", 3) => CompileGatherAlpha(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), status: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("TextureCUBEArrayMethods", "GatherAlpha", 3) => CompileGatherAlpha(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), status: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            (_, "GatherAlpha", 6) => CompileGatherAlpha(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o1: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o2: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o3: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o4: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            (_, "GatherAlpha", 4) => CompileGatherAlpha(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            (_, "GatherAlpha", 7) => CompileGatherAlpha(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o1: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o2: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o3: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o4: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), status: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type))),
            // group GatherBlue
            (_, "GatherBlue", 2) => CompileGatherBlue(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("Texture2DMethods", "GatherBlue", 3) => CompileGatherBlue(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DArrayMethods", "GatherBlue", 3) => CompileGatherBlue(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("TextureCUBEMethods", "GatherBlue", 3) => CompileGatherBlue(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), status: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("TextureCUBEArrayMethods", "GatherBlue", 3) => CompileGatherBlue(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), status: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            (_, "GatherBlue", 6) => CompileGatherBlue(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o1: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o2: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o3: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o4: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            (_, "GatherBlue", 4) => CompileGatherBlue(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            (_, "GatherBlue", 7) => CompileGatherBlue(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o1: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o2: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o3: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o4: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), status: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type))),
            // group GatherCmp
            (_, "GatherCmp", 3) => CompileGatherCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DMethods", "GatherCmp", 4) => CompileGatherCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DArrayMethods", "GatherCmp", 4) => CompileGatherCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEMethods", "GatherCmp", 4) => CompileGatherCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEArrayMethods", "GatherCmp", 4) => CompileGatherCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            (_, "GatherCmp", 5) => CompileGatherCmp(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), status: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            // group GatherCmpAlpha
            (_, "GatherCmpAlpha", 3) => CompileGatherCmpAlpha(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DMethods", "GatherCmpAlpha", 4) => CompileGatherCmpAlpha(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DArrayMethods", "GatherCmpAlpha", 4) => CompileGatherCmpAlpha(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEMethods", "GatherCmpAlpha", 4) => CompileGatherCmpAlpha(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEArrayMethods", "GatherCmpAlpha", 4) => CompileGatherCmpAlpha(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            (_, "GatherCmpAlpha", 7) => CompileGatherCmpAlpha(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o1: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o2: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o3: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), o4: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type))),
            (_, "GatherCmpAlpha", 5) => CompileGatherCmpAlpha(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), status: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            (_, "GatherCmpAlpha", 8) => CompileGatherCmpAlpha(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o1: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o2: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o3: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), o4: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type)), status: new SpirvValue(compiledParams[7], context.GetOrRegister(functionType.ParameterTypes[7].Type))),
            // group GatherCmpBlue
            (_, "GatherCmpBlue", 3) => CompileGatherCmpBlue(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DMethods", "GatherCmpBlue", 4) => CompileGatherCmpBlue(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DArrayMethods", "GatherCmpBlue", 4) => CompileGatherCmpBlue(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEMethods", "GatherCmpBlue", 4) => CompileGatherCmpBlue(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEArrayMethods", "GatherCmpBlue", 4) => CompileGatherCmpBlue(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            (_, "GatherCmpBlue", 7) => CompileGatherCmpBlue(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o1: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o2: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o3: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), o4: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type))),
            (_, "GatherCmpBlue", 5) => CompileGatherCmpBlue(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), status: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            (_, "GatherCmpBlue", 8) => CompileGatherCmpBlue(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o1: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o2: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o3: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), o4: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type)), status: new SpirvValue(compiledParams[7], context.GetOrRegister(functionType.ParameterTypes[7].Type))),
            // group GatherCmpGreen
            (_, "GatherCmpGreen", 3) => CompileGatherCmpGreen(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DMethods", "GatherCmpGreen", 4) => CompileGatherCmpGreen(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DArrayMethods", "GatherCmpGreen", 4) => CompileGatherCmpGreen(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEMethods", "GatherCmpGreen", 4) => CompileGatherCmpGreen(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEArrayMethods", "GatherCmpGreen", 4) => CompileGatherCmpGreen(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            (_, "GatherCmpGreen", 7) => CompileGatherCmpGreen(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o1: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o2: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o3: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), o4: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type))),
            (_, "GatherCmpGreen", 5) => CompileGatherCmpGreen(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), status: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            (_, "GatherCmpGreen", 8) => CompileGatherCmpGreen(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o1: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o2: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o3: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), o4: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type)), status: new SpirvValue(compiledParams[7], context.GetOrRegister(functionType.ParameterTypes[7].Type))),
            // group GatherCmpRed
            (_, "GatherCmpRed", 3) => CompileGatherCmpRed(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DMethods", "GatherCmpRed", 4) => CompileGatherCmpRed(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("Texture2DArrayMethods", "GatherCmpRed", 4) => CompileGatherCmpRed(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEMethods", "GatherCmpRed", 4) => CompileGatherCmpRed(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            ("TextureCUBEArrayMethods", "GatherCmpRed", 4) => CompileGatherCmpRed(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            (_, "GatherCmpRed", 7) => CompileGatherCmpRed(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o1: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o2: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o3: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), o4: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type))),
            (_, "GatherCmpRed", 5) => CompileGatherCmpRed(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), status: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            (_, "GatherCmpRed", 8) => CompileGatherCmpRed(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o1: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o2: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o3: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), o4: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type)), status: new SpirvValue(compiledParams[7], context.GetOrRegister(functionType.ParameterTypes[7].Type))),
            // group GatherGreen
            (_, "GatherGreen", 2) => CompileGatherGreen(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("Texture2DMethods", "GatherGreen", 3) => CompileGatherGreen(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DArrayMethods", "GatherGreen", 3) => CompileGatherGreen(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("TextureCUBEMethods", "GatherGreen", 3) => CompileGatherGreen(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), status: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("TextureCUBEArrayMethods", "GatherGreen", 3) => CompileGatherGreen(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), status: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            (_, "GatherGreen", 6) => CompileGatherGreen(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o1: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o2: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o3: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o4: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            (_, "GatherGreen", 4) => CompileGatherGreen(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            (_, "GatherGreen", 7) => CompileGatherGreen(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o1: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o2: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o3: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o4: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), status: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type))),
            // group GatherRed
            (_, "GatherRed", 2) => CompileGatherRed(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            ("Texture2DMethods", "GatherRed", 3) => CompileGatherRed(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("Texture2DArrayMethods", "GatherRed", 3) => CompileGatherRed(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("TextureCUBEMethods", "GatherRed", 3) => CompileGatherRed(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), status: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            ("TextureCUBEArrayMethods", "GatherRed", 3) => CompileGatherRed(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), status: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            (_, "GatherRed", 6) => CompileGatherRed(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o1: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o2: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o3: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o4: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            (_, "GatherRed", 4) => CompileGatherRed(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            (_, "GatherRed", 7) => CompileGatherRed(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o1: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), o2: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), o3: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), o4: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), status: new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type))),
            // group GatherRaw
            (_, "GatherRaw", 2) => CompileGatherRaw(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "GatherRaw", 3) => CompileGatherRaw(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            (_, "GatherRaw", 4) => CompileGatherRaw(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), o: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), status: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group GetSamplePosition
            (_, "GetSamplePosition", 1) => CompileGetSamplePosition(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
        };
    }
}

public abstract class BufferMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileGetDimensions(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue buffer, SpirvValue width) => throw new NotImplementedException();
    public virtual SpirvValue CompileLoad(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue buffer, SpirvValue x, SpirvValue? status = null) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group GetDimensions
            (_, "GetDimensions", 1) => CompileGetDimensions(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group Load
            (_, "Load", 1) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            (_, "Load", 2) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), status: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
        };
    }
}

public abstract class ByteAddressBufferMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileGetDimensions(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue width) => throw new NotImplementedException();
    public virtual SpirvValue CompileLoad(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileLoad2(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileLoad3(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileLoad4(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileStore(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileStore2(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileStore3(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileStore4(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedAdd64(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedMin64(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedMax64(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedAnd64(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedOr64(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedXor64(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedCompareStore64(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue compare, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedExchange64(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value, SpirvValue original) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedCompareExchange64(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue compare, SpirvValue value, SpirvValue original) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedExchangeFloat(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffest, SpirvValue value, SpirvValue original) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedCompareStoreFloatBitwise(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffest, SpirvValue compare, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedCompareExchangeFloatBitwise(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffest, SpirvValue compare, SpirvValue value, SpirvValue original) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedAdd(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedMin(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedMax(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedAnd(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedOr(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedXor(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value, SpirvValue? original = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedCompareStore(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue compare, SpirvValue value) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedExchange(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue value, SpirvValue original) => throw new NotImplementedException();
    public virtual SpirvValue CompileInterlockedCompareExchange(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue byteAddressBuffer, SpirvValue byteOffset, SpirvValue compare, SpirvValue value, SpirvValue original) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group GetDimensions
            (_, "GetDimensions", 1) => CompileGetDimensions(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group Load
            (_, "Load", 1) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            (_, "Load", 2) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), status: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group Load2
            (_, "Load2", 1) => CompileLoad2(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            (_, "Load2", 2) => CompileLoad2(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), status: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group Load3
            (_, "Load3", 1) => CompileLoad3(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            (_, "Load3", 2) => CompileLoad3(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), status: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group Load4
            (_, "Load4", 1) => CompileLoad4(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            (_, "Load4", 2) => CompileLoad4(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), status: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group Store
            (_, "Store", 2) => CompileStore(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group Store2
            (_, "Store2", 2) => CompileStore2(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group Store3
            (_, "Store3", 2) => CompileStore3(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group Store4
            (_, "Store4", 2) => CompileStore4(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group InterlockedAdd64
            (_, "InterlockedAdd64", 2) => CompileInterlockedAdd64(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedAdd64", 3) => CompileInterlockedAdd64(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedMin64
            (_, "InterlockedMin64", 2) => CompileInterlockedMin64(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedMin64", 3) => CompileInterlockedMin64(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedMax64
            (_, "InterlockedMax64", 2) => CompileInterlockedMax64(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedMax64", 3) => CompileInterlockedMax64(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedAnd64
            (_, "InterlockedAnd64", 2) => CompileInterlockedAnd64(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedAnd64", 3) => CompileInterlockedAnd64(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedOr64
            (_, "InterlockedOr64", 2) => CompileInterlockedOr64(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedOr64", 3) => CompileInterlockedOr64(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedXor64
            (_, "InterlockedXor64", 2) => CompileInterlockedXor64(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedXor64", 3) => CompileInterlockedXor64(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedCompareStore64
            (_, "InterlockedCompareStore64", 3) => CompileInterlockedCompareStore64(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedExchange64
            (_, "InterlockedExchange64", 3) => CompileInterlockedExchange64(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedCompareExchange64
            (_, "InterlockedCompareExchange64", 4) => CompileInterlockedCompareExchange64(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group InterlockedExchangeFloat
            (_, "InterlockedExchangeFloat", 3) => CompileInterlockedExchangeFloat(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedCompareStoreFloatBitwise
            (_, "InterlockedCompareStoreFloatBitwise", 3) => CompileInterlockedCompareStoreFloatBitwise(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedCompareExchangeFloatBitwise
            (_, "InterlockedCompareExchangeFloatBitwise", 4) => CompileInterlockedCompareExchangeFloatBitwise(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group InterlockedAdd
            (_, "InterlockedAdd", 2) => CompileInterlockedAdd(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedAdd", 3) => CompileInterlockedAdd(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedMin
            (_, "InterlockedMin", 2) => CompileInterlockedMin(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedMin", 3) => CompileInterlockedMin(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedMax
            (_, "InterlockedMax", 2) => CompileInterlockedMax(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedMax", 3) => CompileInterlockedMax(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedAnd
            (_, "InterlockedAnd", 2) => CompileInterlockedAnd(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedAnd", 3) => CompileInterlockedAnd(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedOr
            (_, "InterlockedOr", 2) => CompileInterlockedOr(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedOr", 3) => CompileInterlockedOr(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedXor
            (_, "InterlockedXor", 2) => CompileInterlockedXor(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "InterlockedXor", 3) => CompileInterlockedXor(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), original: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedCompareStore
            (_, "InterlockedCompareStore", 3) => CompileInterlockedCompareStore(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedExchange
            (_, "InterlockedExchange", 3) => CompileInterlockedExchange(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group InterlockedCompareExchange
            (_, "InterlockedCompareExchange", 4) => CompileInterlockedCompareExchange(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
        };
    }
}

public abstract class StructuredBufferMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileGetDimensions(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue structuredBuffer, SpirvValue count, SpirvValue stride) => throw new NotImplementedException();
    public virtual SpirvValue CompileLoad(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue structuredBuffer, SpirvValue x, SpirvValue? status = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileIncrementCounter(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue structuredBuffer) => throw new NotImplementedException();
    public virtual SpirvValue CompileDecrementCounter(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue structuredBuffer) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group GetDimensions
            (_, "GetDimensions", 2) => CompileGetDimensions(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group Load
            (_, "Load", 1) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            (_, "Load", 2) => CompileLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), status: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group IncrementCounter
            (_, "IncrementCounter", 0) => CompileIncrementCounter(context, builder, functionType, thisValue.Value),
            // group DecrementCounter
            (_, "DecrementCounter", 0) => CompileDecrementCounter(context, builder, functionType, thisValue.Value),
        };
    }
}

public abstract class AppendStructuredBufferMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileGetDimensions(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue appendStructuredBuffer, SpirvValue count, SpirvValue stride) => throw new NotImplementedException();
    public virtual SpirvValue CompileAppend(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue appendStructuredBuffer, SpirvValue value) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group GetDimensions
            (_, "GetDimensions", 2) => CompileGetDimensions(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group Append
            (_, "Append", 1) => CompileAppend(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
        };
    }
}

public abstract class ConsumeStructuredBufferMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileGetDimensions(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue consumeStructuredBuffer, SpirvValue count, SpirvValue stride) => throw new NotImplementedException();
    public virtual SpirvValue CompileConsume(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue consumeStructuredBuffer) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group GetDimensions
            (_, "GetDimensions", 2) => CompileGetDimensions(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group Consume
            (_, "Consume", 0) => CompileConsume(context, builder, functionType, thisValue.Value),
        };
    }
}

public abstract class FeedbackTexture2DMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileWriteSamplerFeedback(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue feedbackTexture2D, SpirvValue t, SpirvValue s, SpirvValue x, SpirvValue? clamp = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileWriteSamplerFeedbackBias(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue feedbackTexture2D, SpirvValue t, SpirvValue s, SpirvValue x, SpirvValue bias, SpirvValue? clamp = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileWriteSamplerFeedbackGrad(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue feedbackTexture2D, SpirvValue t, SpirvValue s, SpirvValue x, SpirvValue ddx, SpirvValue ddy, SpirvValue? clamp = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileWriteSamplerFeedbackLevel(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue feedbackTexture2D, SpirvValue t, SpirvValue s, SpirvValue x, SpirvValue lod) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group WriteSamplerFeedback
            (_, "WriteSamplerFeedback", 3) => CompileWriteSamplerFeedback(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            (_, "WriteSamplerFeedback", 4) => CompileWriteSamplerFeedback(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), clamp: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group WriteSamplerFeedbackBias
            (_, "WriteSamplerFeedbackBias", 4) => CompileWriteSamplerFeedbackBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            (_, "WriteSamplerFeedbackBias", 5) => CompileWriteSamplerFeedbackBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            // group WriteSamplerFeedbackGrad
            (_, "WriteSamplerFeedbackGrad", 5) => CompileWriteSamplerFeedbackGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            (_, "WriteSamplerFeedbackGrad", 6) => CompileWriteSamplerFeedbackGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), clamp: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            // group WriteSamplerFeedbackLevel
            (_, "WriteSamplerFeedbackLevel", 4) => CompileWriteSamplerFeedbackLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
        };
    }
}

public abstract class FeedbackTexture2DArrayMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileWriteSamplerFeedback(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue feedbackTexture2DArray, SpirvValue t, SpirvValue s, SpirvValue x, SpirvValue? clamp = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileWriteSamplerFeedbackBias(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue feedbackTexture2DArray, SpirvValue t, SpirvValue s, SpirvValue x, SpirvValue bias, SpirvValue? clamp = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileWriteSamplerFeedbackGrad(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue feedbackTexture2DArray, SpirvValue t, SpirvValue s, SpirvValue x, SpirvValue ddx, SpirvValue ddy, SpirvValue? clamp = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileWriteSamplerFeedbackLevel(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue feedbackTexture2DArray, SpirvValue t, SpirvValue s, SpirvValue x, SpirvValue lod) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group WriteSamplerFeedback
            (_, "WriteSamplerFeedback", 3) => CompileWriteSamplerFeedback(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            (_, "WriteSamplerFeedback", 4) => CompileWriteSamplerFeedback(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), clamp: new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group WriteSamplerFeedbackBias
            (_, "WriteSamplerFeedbackBias", 4) => CompileWriteSamplerFeedbackBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            (_, "WriteSamplerFeedbackBias", 5) => CompileWriteSamplerFeedbackBias(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), clamp: new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            // group WriteSamplerFeedbackGrad
            (_, "WriteSamplerFeedbackGrad", 5) => CompileWriteSamplerFeedbackGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type))),
            (_, "WriteSamplerFeedbackGrad", 6) => CompileWriteSamplerFeedbackGrad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), clamp: new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type))),
            // group WriteSamplerFeedbackLevel
            (_, "WriteSamplerFeedbackLevel", 4) => CompileWriteSamplerFeedbackLevel(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
        };
    }
}

public abstract class RayQueryMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileTraceRayInline(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery, SpirvValue AccelerationStructure, SpirvValue RayFlags, SpirvValue InstanceInclusionMask, SpirvValue Ray) => throw new NotImplementedException();
    public virtual SpirvValue CompileProceed(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileAbort(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommitNonOpaqueTriangleHit(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommitProceduralPrimitiveHit(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery, SpirvValue t) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommittedStatus(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidateType(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidateObjectToWorld3x4(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidateObjectToWorld4x3(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidateWorldToObject3x4(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidateWorldToObject4x3(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommittedObjectToWorld3x4(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommittedObjectToWorld4x3(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommittedWorldToObject3x4(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommittedWorldToObject4x3(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidateProceduralPrimitiveNonOpaque(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidateTriangleFrontFace(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommittedTriangleFrontFace(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidateTriangleBarycentrics(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommittedTriangleBarycentrics(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileRayFlags(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileWorldRayOrigin(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileWorldRayDirection(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileRayTMin(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidateTriangleRayT(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommittedRayT(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidateInstanceIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidateInstanceID(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidateGeometryIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidatePrimitiveIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidateObjectRayOrigin(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidateObjectRayDirection(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommittedInstanceIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommittedInstanceID(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommittedGeometryIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommittedPrimitiveIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommittedObjectRayOrigin(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommittedObjectRayDirection(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidateInstanceContributionToHitGroupIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommittedInstanceContributionToHitGroupIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidateClusterID(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommittedClusterID(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCandidateTriangleObjectPositions(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public virtual SpirvValue CompileCommittedTriangleObjectPositions(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue rayQuery) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group TraceRayInline
            (_, "TraceRayInline", 4) => CompileTraceRayInline(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type))),
            // group Proceed
            (_, "Proceed", 0) => CompileProceed(context, builder, functionType, thisValue.Value),
            // group Abort
            (_, "Abort", 0) => CompileAbort(context, builder, functionType, thisValue.Value),
            // group CommitNonOpaqueTriangleHit
            (_, "CommitNonOpaqueTriangleHit", 0) => CompileCommitNonOpaqueTriangleHit(context, builder, functionType, thisValue.Value),
            // group CommitProceduralPrimitiveHit
            (_, "CommitProceduralPrimitiveHit", 1) => CompileCommitProceduralPrimitiveHit(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group CommittedStatus
            (_, "CommittedStatus", 0) => CompileCommittedStatus(context, builder, functionType, thisValue.Value),
            // group CandidateType
            (_, "CandidateType", 0) => CompileCandidateType(context, builder, functionType, thisValue.Value),
            // group CandidateObjectToWorld3x4
            (_, "CandidateObjectToWorld3x4", 0) => CompileCandidateObjectToWorld3x4(context, builder, functionType, thisValue.Value),
            // group CandidateObjectToWorld4x3
            (_, "CandidateObjectToWorld4x3", 0) => CompileCandidateObjectToWorld4x3(context, builder, functionType, thisValue.Value),
            // group CandidateWorldToObject3x4
            (_, "CandidateWorldToObject3x4", 0) => CompileCandidateWorldToObject3x4(context, builder, functionType, thisValue.Value),
            // group CandidateWorldToObject4x3
            (_, "CandidateWorldToObject4x3", 0) => CompileCandidateWorldToObject4x3(context, builder, functionType, thisValue.Value),
            // group CommittedObjectToWorld3x4
            (_, "CommittedObjectToWorld3x4", 0) => CompileCommittedObjectToWorld3x4(context, builder, functionType, thisValue.Value),
            // group CommittedObjectToWorld4x3
            (_, "CommittedObjectToWorld4x3", 0) => CompileCommittedObjectToWorld4x3(context, builder, functionType, thisValue.Value),
            // group CommittedWorldToObject3x4
            (_, "CommittedWorldToObject3x4", 0) => CompileCommittedWorldToObject3x4(context, builder, functionType, thisValue.Value),
            // group CommittedWorldToObject4x3
            (_, "CommittedWorldToObject4x3", 0) => CompileCommittedWorldToObject4x3(context, builder, functionType, thisValue.Value),
            // group CandidateProceduralPrimitiveNonOpaque
            (_, "CandidateProceduralPrimitiveNonOpaque", 0) => CompileCandidateProceduralPrimitiveNonOpaque(context, builder, functionType, thisValue.Value),
            // group CandidateTriangleFrontFace
            (_, "CandidateTriangleFrontFace", 0) => CompileCandidateTriangleFrontFace(context, builder, functionType, thisValue.Value),
            // group CommittedTriangleFrontFace
            (_, "CommittedTriangleFrontFace", 0) => CompileCommittedTriangleFrontFace(context, builder, functionType, thisValue.Value),
            // group CandidateTriangleBarycentrics
            (_, "CandidateTriangleBarycentrics", 0) => CompileCandidateTriangleBarycentrics(context, builder, functionType, thisValue.Value),
            // group CommittedTriangleBarycentrics
            (_, "CommittedTriangleBarycentrics", 0) => CompileCommittedTriangleBarycentrics(context, builder, functionType, thisValue.Value),
            // group RayFlags
            (_, "RayFlags", 0) => CompileRayFlags(context, builder, functionType, thisValue.Value),
            // group WorldRayOrigin
            (_, "WorldRayOrigin", 0) => CompileWorldRayOrigin(context, builder, functionType, thisValue.Value),
            // group WorldRayDirection
            (_, "WorldRayDirection", 0) => CompileWorldRayDirection(context, builder, functionType, thisValue.Value),
            // group RayTMin
            (_, "RayTMin", 0) => CompileRayTMin(context, builder, functionType, thisValue.Value),
            // group CandidateTriangleRayT
            (_, "CandidateTriangleRayT", 0) => CompileCandidateTriangleRayT(context, builder, functionType, thisValue.Value),
            // group CommittedRayT
            (_, "CommittedRayT", 0) => CompileCommittedRayT(context, builder, functionType, thisValue.Value),
            // group CandidateInstanceIndex
            (_, "CandidateInstanceIndex", 0) => CompileCandidateInstanceIndex(context, builder, functionType, thisValue.Value),
            // group CandidateInstanceID
            (_, "CandidateInstanceID", 0) => CompileCandidateInstanceID(context, builder, functionType, thisValue.Value),
            // group CandidateGeometryIndex
            (_, "CandidateGeometryIndex", 0) => CompileCandidateGeometryIndex(context, builder, functionType, thisValue.Value),
            // group CandidatePrimitiveIndex
            (_, "CandidatePrimitiveIndex", 0) => CompileCandidatePrimitiveIndex(context, builder, functionType, thisValue.Value),
            // group CandidateObjectRayOrigin
            (_, "CandidateObjectRayOrigin", 0) => CompileCandidateObjectRayOrigin(context, builder, functionType, thisValue.Value),
            // group CandidateObjectRayDirection
            (_, "CandidateObjectRayDirection", 0) => CompileCandidateObjectRayDirection(context, builder, functionType, thisValue.Value),
            // group CommittedInstanceIndex
            (_, "CommittedInstanceIndex", 0) => CompileCommittedInstanceIndex(context, builder, functionType, thisValue.Value),
            // group CommittedInstanceID
            (_, "CommittedInstanceID", 0) => CompileCommittedInstanceID(context, builder, functionType, thisValue.Value),
            // group CommittedGeometryIndex
            (_, "CommittedGeometryIndex", 0) => CompileCommittedGeometryIndex(context, builder, functionType, thisValue.Value),
            // group CommittedPrimitiveIndex
            (_, "CommittedPrimitiveIndex", 0) => CompileCommittedPrimitiveIndex(context, builder, functionType, thisValue.Value),
            // group CommittedObjectRayOrigin
            (_, "CommittedObjectRayOrigin", 0) => CompileCommittedObjectRayOrigin(context, builder, functionType, thisValue.Value),
            // group CommittedObjectRayDirection
            (_, "CommittedObjectRayDirection", 0) => CompileCommittedObjectRayDirection(context, builder, functionType, thisValue.Value),
            // group CandidateInstanceContributionToHitGroupIndex
            (_, "CandidateInstanceContributionToHitGroupIndex", 0) => CompileCandidateInstanceContributionToHitGroupIndex(context, builder, functionType, thisValue.Value),
            // group CommittedInstanceContributionToHitGroupIndex
            (_, "CommittedInstanceContributionToHitGroupIndex", 0) => CompileCommittedInstanceContributionToHitGroupIndex(context, builder, functionType, thisValue.Value),
            // group CandidateClusterID
            (_, "CandidateClusterID", 0) => CompileCandidateClusterID(context, builder, functionType, thisValue.Value),
            // group CommittedClusterID
            (_, "CommittedClusterID", 0) => CompileCommittedClusterID(context, builder, functionType, thisValue.Value),
            // group CandidateTriangleObjectPositions
            (_, "CandidateTriangleObjectPositions", 0) => CompileCandidateTriangleObjectPositions(context, builder, functionType, thisValue.Value),
            // group CommittedTriangleObjectPositions
            (_, "CommittedTriangleObjectPositions", 0) => CompileCommittedTriangleObjectPositions(context, builder, functionType, thisValue.Value),
        };
    }
}

public abstract class DxHitObjectMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileMakeNop(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileMakeMiss(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject, SpirvValue RayFlags, SpirvValue MissShaderIndex, SpirvValue Ray) => throw new NotImplementedException();
    public virtual SpirvValue CompileFromRayQuery(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject, SpirvValue rq, SpirvValue? HitKind = null, SpirvValue? Attributes = null) => throw new NotImplementedException();
    public virtual SpirvValue CompileTraceRay(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject, SpirvValue AccelerationStructure, SpirvValue RayFlags, SpirvValue InstanceInclusionMask, SpirvValue RayContributionToHitGroupIndex, SpirvValue MultiplierForGeometryContributionToHitGroupIndex, SpirvValue MissShaderIndex, SpirvValue Ray, SpirvValue Payload) => throw new NotImplementedException();
    public virtual SpirvValue CompileInvoke(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject, SpirvValue ho, SpirvValue Payload) => throw new NotImplementedException();
    public virtual SpirvValue CompileIsMiss(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileIsHit(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileIsNop(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetRayFlags(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetRayTMin(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetRayTCurrent(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetWorldRayOrigin(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetWorldRayDirection(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetObjectRayOrigin(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetObjectRayDirection(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetObjectToWorld3x4(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetObjectToWorld4x3(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetWorldToObject3x4(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetWorldToObject4x3(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetGeometryIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetInstanceIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetInstanceID(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetPrimitiveIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetHitKind(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetShaderTableIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetAttributes(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject, SpirvValue Attributes) => throw new NotImplementedException();
    public virtual SpirvValue CompileSetShaderTableIndex(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject, SpirvValue RecordIndex) => throw new NotImplementedException();
    public virtual SpirvValue CompileLoadLocalRootTableConstant(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject, SpirvValue RootConstantOffsetInBytes) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetClusterID(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public virtual SpirvValue CompileTriangleObjectPositions(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dxHitObject) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group MakeNop
            (_, "MakeNop", 0) => CompileMakeNop(context, builder, functionType, thisValue.Value),
            // group MakeMiss
            (_, "MakeMiss", 3) => CompileMakeMiss(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group FromRayQuery
            (_, "FromRayQuery", 1) => CompileFromRayQuery(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            (_, "FromRayQuery", 3) => CompileFromRayQuery(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), HitKind: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), Attributes: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
            // group TraceRay
            (_, "TraceRay", 8) => CompileTraceRay(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type)), new SpirvValue(compiledParams[3], context.GetOrRegister(functionType.ParameterTypes[3].Type)), new SpirvValue(compiledParams[4], context.GetOrRegister(functionType.ParameterTypes[4].Type)), new SpirvValue(compiledParams[5], context.GetOrRegister(functionType.ParameterTypes[5].Type)), new SpirvValue(compiledParams[6], context.GetOrRegister(functionType.ParameterTypes[6].Type)), new SpirvValue(compiledParams[7], context.GetOrRegister(functionType.ParameterTypes[7].Type))),
            // group Invoke
            (_, "Invoke", 2) => CompileInvoke(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            // group IsMiss
            (_, "IsMiss", 0) => CompileIsMiss(context, builder, functionType, thisValue.Value),
            // group IsHit
            (_, "IsHit", 0) => CompileIsHit(context, builder, functionType, thisValue.Value),
            // group IsNop
            (_, "IsNop", 0) => CompileIsNop(context, builder, functionType, thisValue.Value),
            // group GetRayFlags
            (_, "GetRayFlags", 0) => CompileGetRayFlags(context, builder, functionType, thisValue.Value),
            // group GetRayTMin
            (_, "GetRayTMin", 0) => CompileGetRayTMin(context, builder, functionType, thisValue.Value),
            // group GetRayTCurrent
            (_, "GetRayTCurrent", 0) => CompileGetRayTCurrent(context, builder, functionType, thisValue.Value),
            // group GetWorldRayOrigin
            (_, "GetWorldRayOrigin", 0) => CompileGetWorldRayOrigin(context, builder, functionType, thisValue.Value),
            // group GetWorldRayDirection
            (_, "GetWorldRayDirection", 0) => CompileGetWorldRayDirection(context, builder, functionType, thisValue.Value),
            // group GetObjectRayOrigin
            (_, "GetObjectRayOrigin", 0) => CompileGetObjectRayOrigin(context, builder, functionType, thisValue.Value),
            // group GetObjectRayDirection
            (_, "GetObjectRayDirection", 0) => CompileGetObjectRayDirection(context, builder, functionType, thisValue.Value),
            // group GetObjectToWorld3x4
            (_, "GetObjectToWorld3x4", 0) => CompileGetObjectToWorld3x4(context, builder, functionType, thisValue.Value),
            // group GetObjectToWorld4x3
            (_, "GetObjectToWorld4x3", 0) => CompileGetObjectToWorld4x3(context, builder, functionType, thisValue.Value),
            // group GetWorldToObject3x4
            (_, "GetWorldToObject3x4", 0) => CompileGetWorldToObject3x4(context, builder, functionType, thisValue.Value),
            // group GetWorldToObject4x3
            (_, "GetWorldToObject4x3", 0) => CompileGetWorldToObject4x3(context, builder, functionType, thisValue.Value),
            // group GetGeometryIndex
            (_, "GetGeometryIndex", 0) => CompileGetGeometryIndex(context, builder, functionType, thisValue.Value),
            // group GetInstanceIndex
            (_, "GetInstanceIndex", 0) => CompileGetInstanceIndex(context, builder, functionType, thisValue.Value),
            // group GetInstanceID
            (_, "GetInstanceID", 0) => CompileGetInstanceID(context, builder, functionType, thisValue.Value),
            // group GetPrimitiveIndex
            (_, "GetPrimitiveIndex", 0) => CompileGetPrimitiveIndex(context, builder, functionType, thisValue.Value),
            // group GetHitKind
            (_, "GetHitKind", 0) => CompileGetHitKind(context, builder, functionType, thisValue.Value),
            // group GetShaderTableIndex
            (_, "GetShaderTableIndex", 0) => CompileGetShaderTableIndex(context, builder, functionType, thisValue.Value),
            // group GetAttributes
            (_, "GetAttributes", 1) => CompileGetAttributes(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group SetShaderTableIndex
            (_, "SetShaderTableIndex", 1) => CompileSetShaderTableIndex(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group LoadLocalRootTableConstant
            (_, "LoadLocalRootTableConstant", 1) => CompileLoadLocalRootTableConstant(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group GetClusterID
            (_, "GetClusterID", 0) => CompileGetClusterID(context, builder, functionType, thisValue.Value),
            // group TriangleObjectPositions
            (_, "TriangleObjectPositions", 0) => CompileTriangleObjectPositions(context, builder, functionType, thisValue.Value),
        };
    }
}

public abstract class DxIntrinsicsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileMaybeReorderThread(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue? HitObject = null, SpirvValue? CoherenceHint = null, SpirvValue? NumCoherenceHintBitsFromLSB = null) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group MaybeReorderThread
            (_, "MaybeReorderThread", 1) => CompileMaybeReorderThread(context, builder, functionType, HitObject: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            (_, "MaybeReorderThread", 2) => CompileMaybeReorderThread(context, builder, functionType, CoherenceHint: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), NumCoherenceHintBitsFromLSB: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type))),
            (_, "MaybeReorderThread", 3) => CompileMaybeReorderThread(context, builder, functionType, HitObject: new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type)), CoherenceHint: new SpirvValue(compiledParams[1], context.GetOrRegister(functionType.ParameterTypes[1].Type)), NumCoherenceHintBitsFromLSB: new SpirvValue(compiledParams[2], context.GetOrRegister(functionType.ParameterTypes[2].Type))),
        };
    }
}

public abstract class EmptyNodeInputMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileCount(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue emptyNodeInput) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group Count
            (_, "Count", 0) => CompileCount(context, builder, functionType, thisValue.Value),
        };
    }
}

public abstract class DispatchNodeInputRecordMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileFinishedCrossGroupSharing(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue dispatchNodeInputRecord) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group FinishedCrossGroupSharing
            (_, "FinishedCrossGroupSharing", 0) => CompileFinishedCrossGroupSharing(context, builder, functionType, thisValue.Value),
        };
    }
}

public abstract class GroupNodeInputRecordsMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileCount(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue groupNodeInputRecords) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group Count
            (_, "Count", 0) => CompileCount(context, builder, functionType, thisValue.Value),
        };
    }
}

public abstract class NodeOutputMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileGetThreadNodeOutputRecords(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue nodeOutput, SpirvValue numRecords) => throw new NotImplementedException();
    public virtual SpirvValue CompileGetGroupNodeOutputRecords(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue nodeOutput, SpirvValue numRecords) => throw new NotImplementedException();
    public virtual SpirvValue CompileIsValid(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue nodeOutput) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group GetThreadNodeOutputRecords
            (_, "GetThreadNodeOutputRecords", 1) => CompileGetThreadNodeOutputRecords(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group GetGroupNodeOutputRecords
            (_, "GetGroupNodeOutputRecords", 1) => CompileGetGroupNodeOutputRecords(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group IsValid
            (_, "IsValid", 0) => CompileIsValid(context, builder, functionType, thisValue.Value),
        };
    }
}

public abstract class EmptyNodeOutputMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileGroupIncrementOutputCount(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue emptyNodeOutput, SpirvValue count) => throw new NotImplementedException();
    public virtual SpirvValue CompileThreadIncrementOutputCount(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue emptyNodeOutput, SpirvValue count) => throw new NotImplementedException();
    public virtual SpirvValue CompileIsValid(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue emptyNodeOutput) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group GroupIncrementOutputCount
            (_, "GroupIncrementOutputCount", 1) => CompileGroupIncrementOutputCount(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group ThreadIncrementOutputCount
            (_, "ThreadIncrementOutputCount", 1) => CompileThreadIncrementOutputCount(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
            // group IsValid
            (_, "IsValid", 0) => CompileIsValid(context, builder, functionType, thisValue.Value),
        };
    }
}

public abstract class GroupOrThreadNodeOutputRecordsMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileOutputComplete(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue groupOrThreadNodeOutputRecords) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group OutputComplete
            (_, "OutputComplete", 0) => CompileOutputComplete(context, builder, functionType, thisValue.Value),
        };
    }
}

public abstract class VkSubpassInputMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileSubpassLoad(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue vkSubpassInput) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group SubpassLoad
            (_, "SubpassLoad", 0) => CompileSubpassLoad(context, builder, functionType, thisValue.Value),
        };
    }
}

public abstract class VkSubpassInputMSMethodsDeclarations : IIntrinsicCompiler
{
    public virtual SpirvValue CompileSubpassLoad(SpirvContext context, SpirvBuilder builder, FunctionType functionType, SpirvValue vkSubpassInputMS, SpirvValue sample) => throw new NotImplementedException();
    public SpirvValue CompileIntrinsic(SymbolTable table, CompilerUnit compiler, string? @namespace, string name, FunctionType functionType, SpirvValue? thisValue, Span<int> compiledParams)
    {
        var(builder, context) = compiler;
        return (@namespace, name, compiledParams.Length) switch
        {
            // group SubpassLoad
            (_, "SubpassLoad", 1) => CompileSubpassLoad(context, builder, functionType, thisValue.Value, new SpirvValue(compiledParams[0], context.GetOrRegister(functionType.ParameterTypes[0].Type))),
        };
    }
}