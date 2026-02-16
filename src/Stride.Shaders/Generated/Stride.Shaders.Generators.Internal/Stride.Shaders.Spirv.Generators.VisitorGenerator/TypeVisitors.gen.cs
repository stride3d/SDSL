using Stride.Shaders.Core;

namespace Stride.Shaders.Core
{
    public partial class TypeVisitor
    {
        public virtual void VisitUndefinedType(Stride.Shaders.Core.UndefinedType undefinedType)
        {
            DefaultVisit(undefinedType);
        }

        public virtual void VisitPointerType(Stride.Shaders.Core.PointerType pointerType)
        {
            DefaultVisit(pointerType);
        }

        public virtual void VisitScalarType(Stride.Shaders.Core.ScalarType scalarType)
        {
            DefaultVisit(scalarType);
        }

        public virtual void VisitVectorType(Stride.Shaders.Core.VectorType vectorType)
        {
            DefaultVisit(vectorType);
        }

        public virtual void VisitMatrixType(Stride.Shaders.Core.MatrixType matrixType)
        {
            DefaultVisit(matrixType);
        }

        public virtual void VisitArrayType(Stride.Shaders.Core.ArrayType arrayType)
        {
            DefaultVisit(arrayType);
        }

        public virtual void VisitStructuredTypeMember(Stride.Shaders.Core.StructuredTypeMember structuredTypeMember)
        {
            DefaultVisit(structuredTypeMember);
        }

        public virtual void VisitStructuredType(Stride.Shaders.Core.StructuredType structuredType)
        {
            DefaultVisit(structuredType);
        }

        public virtual void VisitStructType(Stride.Shaders.Core.StructType structType)
        {
            DefaultVisit(structType);
        }

        public virtual void VisitStructuredBufferType(Stride.Shaders.Core.StructuredBufferType structuredBufferType)
        {
            DefaultVisit(structuredBufferType);
        }

        public virtual void VisitBufferType(Stride.Shaders.Core.BufferType bufferType)
        {
            DefaultVisit(bufferType);
        }

        public virtual void VisitSamplerType(Stride.Shaders.Core.SamplerType samplerType)
        {
            DefaultVisit(samplerType);
        }

        public virtual void VisitSampledImage(Stride.Shaders.Core.SampledImage sampledImage)
        {
            DefaultVisit(sampledImage);
        }

        public virtual void VisitTexture1DType(Stride.Shaders.Core.Texture1DType texture1DType)
        {
            DefaultVisit(texture1DType);
        }

        public virtual void VisitTexture2DType(Stride.Shaders.Core.Texture2DType texture2DType)
        {
            DefaultVisit(texture2DType);
        }

        public virtual void VisitTexture3DType(Stride.Shaders.Core.Texture3DType texture3DType)
        {
            DefaultVisit(texture3DType);
        }

        public virtual void VisitTextureCubeType(Stride.Shaders.Core.TextureCubeType textureCubeType)
        {
            DefaultVisit(textureCubeType);
        }

        public virtual void VisitFunctionGroupType(Stride.Shaders.Core.FunctionGroupType functionGroupType)
        {
            DefaultVisit(functionGroupType);
        }

        public virtual void VisitFunctionParameter(Stride.Shaders.Core.FunctionParameter functionParameter)
        {
            DefaultVisit(functionParameter);
        }

        public virtual void VisitFunctionType(Stride.Shaders.Core.FunctionType functionType)
        {
            DefaultVisit(functionType);
        }

        public virtual void VisitStreamsSymbol(Stride.Shaders.Core.StreamsSymbol streamsSymbol)
        {
            DefaultVisit(streamsSymbol);
        }

        public virtual void VisitConstantBufferSymbol(Stride.Shaders.Core.ConstantBufferSymbol constantBufferSymbol)
        {
            DefaultVisit(constantBufferSymbol);
        }

        public virtual void VisitParamsSymbol(Stride.Shaders.Core.ParamsSymbol paramsSymbol)
        {
            DefaultVisit(paramsSymbol);
        }

        public virtual void VisitEffectSymbol(Stride.Shaders.Core.EffectSymbol effectSymbol)
        {
            DefaultVisit(effectSymbol);
        }

        public virtual void VisitShaderSymbol(Stride.Shaders.Core.ShaderSymbol shaderSymbol)
        {
            DefaultVisit(shaderSymbol);
        }

        public virtual void VisitLoadedShaderSymbol(Stride.Shaders.Core.LoadedShaderSymbol loadedShaderSymbol)
        {
            DefaultVisit(loadedShaderSymbol);
        }

        public virtual void VisitGenericParameterType(Stride.Shaders.Core.GenericParameterType genericParameterType)
        {
            DefaultVisit(genericParameterType);
        }

        public virtual void VisitStreamsType(Stride.Shaders.Core.StreamsType streamsType)
        {
            DefaultVisit(streamsType);
        }

        public virtual void VisitGeometryStreamType(Stride.Shaders.Core.GeometryStreamType geometryStreamType)
        {
            DefaultVisit(geometryStreamType);
        }

        public virtual void VisitPatchType(Stride.Shaders.Core.PatchType patchType)
        {
            DefaultVisit(patchType);
        }

        public virtual void VisitShaderMixinType(Stride.Shaders.Core.ShaderMixinType shaderMixinType)
        {
            DefaultVisit(shaderMixinType);
        }

        public virtual void VisitExternalType(Stride.Shaders.Core.ExternalType externalType)
        {
            DefaultVisit(externalType);
        }
    }

    public partial class TypeWalker
    {
        public override void VisitUndefinedType(Stride.Shaders.Core.UndefinedType undefinedType)
        {
            base.VisitUndefinedType(undefinedType);
        }

        public override void VisitPointerType(Stride.Shaders.Core.PointerType pointerType)
        {
            VisitType(pointerType.BaseType);
            base.VisitPointerType(pointerType);
        }

        public override void VisitScalarType(Stride.Shaders.Core.ScalarType scalarType)
        {
            base.VisitScalarType(scalarType);
        }

        public override void VisitVectorType(Stride.Shaders.Core.VectorType vectorType)
        {
            VisitType(vectorType.BaseType);
            base.VisitVectorType(vectorType);
        }

        public override void VisitMatrixType(Stride.Shaders.Core.MatrixType matrixType)
        {
            VisitType(matrixType.BaseType);
            base.VisitMatrixType(matrixType);
        }

        public override void VisitArrayType(Stride.Shaders.Core.ArrayType arrayType)
        {
            VisitType(arrayType.BaseType);
            base.VisitArrayType(arrayType);
        }

        public override void VisitStructuredTypeMember(Stride.Shaders.Core.StructuredTypeMember structuredTypeMember)
        {
            VisitType(structuredTypeMember.Type);
            base.VisitStructuredTypeMember(structuredTypeMember);
        }

        public override void VisitStructuredType(Stride.Shaders.Core.StructuredType structuredType)
        {
            VisitItemList(structuredType.Members);
            base.VisitStructuredType(structuredType);
        }

        public override void VisitStructType(Stride.Shaders.Core.StructType structType)
        {
            VisitItemList(structType.Members);
            base.VisitStructType(structType);
        }

        public override void VisitStructuredBufferType(Stride.Shaders.Core.StructuredBufferType structuredBufferType)
        {
            VisitItemList(structuredBufferType.Members);
            VisitType(structuredBufferType.BaseType);
            base.VisitStructuredBufferType(structuredBufferType);
        }

        public override void VisitBufferType(Stride.Shaders.Core.BufferType bufferType)
        {
            VisitType(bufferType.BaseType);
            base.VisitBufferType(bufferType);
        }

        public override void VisitSamplerType(Stride.Shaders.Core.SamplerType samplerType)
        {
            base.VisitSamplerType(samplerType);
        }

        public override void VisitSampledImage(Stride.Shaders.Core.SampledImage sampledImage)
        {
            VisitType(sampledImage.ImageType);
            base.VisitSampledImage(sampledImage);
        }

        public override void VisitTexture1DType(Stride.Shaders.Core.Texture1DType texture1DType)
        {
            VisitType(texture1DType.ReturnType);
            base.VisitTexture1DType(texture1DType);
        }

        public override void VisitTexture2DType(Stride.Shaders.Core.Texture2DType texture2DType)
        {
            VisitType(texture2DType.ReturnType);
            base.VisitTexture2DType(texture2DType);
        }

        public override void VisitTexture3DType(Stride.Shaders.Core.Texture3DType texture3DType)
        {
            VisitType(texture3DType.ReturnType);
            base.VisitTexture3DType(texture3DType);
        }

        public override void VisitTextureCubeType(Stride.Shaders.Core.TextureCubeType textureCubeType)
        {
            VisitType(textureCubeType.ReturnType);
            base.VisitTextureCubeType(textureCubeType);
        }

        public override void VisitFunctionGroupType(Stride.Shaders.Core.FunctionGroupType functionGroupType)
        {
            base.VisitFunctionGroupType(functionGroupType);
        }

        public override void VisitFunctionParameter(Stride.Shaders.Core.FunctionParameter functionParameter)
        {
            VisitType(functionParameter.Type);
            base.VisitFunctionParameter(functionParameter);
        }

        public override void VisitFunctionType(Stride.Shaders.Core.FunctionType functionType)
        {
            VisitType(functionType.ReturnType);
            VisitItemList(functionType.ParameterTypes);
            base.VisitFunctionType(functionType);
        }

        public override void VisitStreamsSymbol(Stride.Shaders.Core.StreamsSymbol streamsSymbol)
        {
            base.VisitStreamsSymbol(streamsSymbol);
        }

        public override void VisitConstantBufferSymbol(Stride.Shaders.Core.ConstantBufferSymbol constantBufferSymbol)
        {
            VisitItemList(constantBufferSymbol.Members);
            base.VisitConstantBufferSymbol(constantBufferSymbol);
        }

        public override void VisitParamsSymbol(Stride.Shaders.Core.ParamsSymbol paramsSymbol)
        {
            base.VisitParamsSymbol(paramsSymbol);
        }

        public override void VisitEffectSymbol(Stride.Shaders.Core.EffectSymbol effectSymbol)
        {
            base.VisitEffectSymbol(effectSymbol);
        }

        public override void VisitShaderSymbol(Stride.Shaders.Core.ShaderSymbol shaderSymbol)
        {
            base.VisitShaderSymbol(shaderSymbol);
        }

        public override void VisitLoadedShaderSymbol(Stride.Shaders.Core.LoadedShaderSymbol loadedShaderSymbol)
        {
            VisitTypeList(loadedShaderSymbol.InheritedShaders);
            base.VisitLoadedShaderSymbol(loadedShaderSymbol);
        }

        public override void VisitGenericParameterType(Stride.Shaders.Core.GenericParameterType genericParameterType)
        {
            base.VisitGenericParameterType(genericParameterType);
        }

        public override void VisitStreamsType(Stride.Shaders.Core.StreamsType streamsType)
        {
            base.VisitStreamsType(streamsType);
        }

        public override void VisitGeometryStreamType(Stride.Shaders.Core.GeometryStreamType geometryStreamType)
        {
            VisitType(geometryStreamType.BaseType);
            base.VisitGeometryStreamType(geometryStreamType);
        }

        public override void VisitPatchType(Stride.Shaders.Core.PatchType patchType)
        {
            VisitType(patchType.BaseType);
            base.VisitPatchType(patchType);
        }

        public override void VisitShaderMixinType(Stride.Shaders.Core.ShaderMixinType shaderMixinType)
        {
            base.VisitShaderMixinType(shaderMixinType);
        }

        public override void VisitExternalType(Stride.Shaders.Core.ExternalType externalType)
        {
            base.VisitExternalType(externalType);
        }
    }

    public partial class TypeVisitor<TResult>
    {
        public virtual TResult VisitUndefinedType(Stride.Shaders.Core.UndefinedType undefinedType)
        {
            return DefaultVisit(undefinedType);
        }

        public virtual TResult VisitPointerType(Stride.Shaders.Core.PointerType pointerType)
        {
            return DefaultVisit(pointerType);
        }

        public virtual TResult VisitScalarType(Stride.Shaders.Core.ScalarType scalarType)
        {
            return DefaultVisit(scalarType);
        }

        public virtual TResult VisitVectorType(Stride.Shaders.Core.VectorType vectorType)
        {
            return DefaultVisit(vectorType);
        }

        public virtual TResult VisitMatrixType(Stride.Shaders.Core.MatrixType matrixType)
        {
            return DefaultVisit(matrixType);
        }

        public virtual TResult VisitArrayType(Stride.Shaders.Core.ArrayType arrayType)
        {
            return DefaultVisit(arrayType);
        }

        public virtual bool VisitStructuredTypeMember(ref Stride.Shaders.Core.StructuredTypeMember structuredTypeMember)
        {
            return DefaultVisit(ref structuredTypeMember);
        }

        public virtual TResult VisitStructuredType(Stride.Shaders.Core.StructuredType structuredType)
        {
            return DefaultVisit(structuredType);
        }

        public virtual TResult VisitStructType(Stride.Shaders.Core.StructType structType)
        {
            return DefaultVisit(structType);
        }

        public virtual TResult VisitStructuredBufferType(Stride.Shaders.Core.StructuredBufferType structuredBufferType)
        {
            return DefaultVisit(structuredBufferType);
        }

        public virtual TResult VisitBufferType(Stride.Shaders.Core.BufferType bufferType)
        {
            return DefaultVisit(bufferType);
        }

        public virtual TResult VisitSamplerType(Stride.Shaders.Core.SamplerType samplerType)
        {
            return DefaultVisit(samplerType);
        }

        public virtual TResult VisitSampledImage(Stride.Shaders.Core.SampledImage sampledImage)
        {
            return DefaultVisit(sampledImage);
        }

        public virtual TResult VisitTexture1DType(Stride.Shaders.Core.Texture1DType texture1DType)
        {
            return DefaultVisit(texture1DType);
        }

        public virtual TResult VisitTexture2DType(Stride.Shaders.Core.Texture2DType texture2DType)
        {
            return DefaultVisit(texture2DType);
        }

        public virtual TResult VisitTexture3DType(Stride.Shaders.Core.Texture3DType texture3DType)
        {
            return DefaultVisit(texture3DType);
        }

        public virtual TResult VisitTextureCubeType(Stride.Shaders.Core.TextureCubeType textureCubeType)
        {
            return DefaultVisit(textureCubeType);
        }

        public virtual TResult VisitFunctionGroupType(Stride.Shaders.Core.FunctionGroupType functionGroupType)
        {
            return DefaultVisit(functionGroupType);
        }

        public virtual bool VisitFunctionParameter(ref Stride.Shaders.Core.FunctionParameter functionParameter)
        {
            return DefaultVisit(ref functionParameter);
        }

        public virtual TResult VisitFunctionType(Stride.Shaders.Core.FunctionType functionType)
        {
            return DefaultVisit(functionType);
        }

        public virtual TResult VisitStreamsSymbol(Stride.Shaders.Core.StreamsSymbol streamsSymbol)
        {
            return DefaultVisit(streamsSymbol);
        }

        public virtual TResult VisitConstantBufferSymbol(Stride.Shaders.Core.ConstantBufferSymbol constantBufferSymbol)
        {
            return DefaultVisit(constantBufferSymbol);
        }

        public virtual TResult VisitParamsSymbol(Stride.Shaders.Core.ParamsSymbol paramsSymbol)
        {
            return DefaultVisit(paramsSymbol);
        }

        public virtual TResult VisitEffectSymbol(Stride.Shaders.Core.EffectSymbol effectSymbol)
        {
            return DefaultVisit(effectSymbol);
        }

        public virtual TResult VisitShaderSymbol(Stride.Shaders.Core.ShaderSymbol shaderSymbol)
        {
            return DefaultVisit(shaderSymbol);
        }

        public virtual TResult VisitLoadedShaderSymbol(Stride.Shaders.Core.LoadedShaderSymbol loadedShaderSymbol)
        {
            return DefaultVisit(loadedShaderSymbol);
        }

        public virtual TResult VisitGenericParameterType(Stride.Shaders.Core.GenericParameterType genericParameterType)
        {
            return DefaultVisit(genericParameterType);
        }

        public virtual TResult VisitStreamsType(Stride.Shaders.Core.StreamsType streamsType)
        {
            return DefaultVisit(streamsType);
        }

        public virtual TResult VisitGeometryStreamType(Stride.Shaders.Core.GeometryStreamType geometryStreamType)
        {
            return DefaultVisit(geometryStreamType);
        }

        public virtual TResult VisitPatchType(Stride.Shaders.Core.PatchType patchType)
        {
            return DefaultVisit(patchType);
        }

        public virtual TResult VisitShaderMixinType(Stride.Shaders.Core.ShaderMixinType shaderMixinType)
        {
            return DefaultVisit(shaderMixinType);
        }

        public virtual TResult VisitExternalType(Stride.Shaders.Core.ExternalType externalType)
        {
            return DefaultVisit(externalType);
        }
    }

    public partial class TypeRewriter
    {
        public override SymbolType VisitUndefinedType(Stride.Shaders.Core.UndefinedType undefinedType)
        {
            return (SymbolType)base.VisitUndefinedType(undefinedType);
        }

        public override SymbolType VisitPointerType(Stride.Shaders.Core.PointerType pointerType)
        {
            var baseTypeTemp = (Stride.Shaders.Core.SymbolType)VisitType(pointerType.BaseType);
            if (!ReferenceEquals(baseTypeTemp, pointerType.BaseType))
                pointerType = pointerType with
                {
                    BaseType = baseTypeTemp
                };
            return (SymbolType)base.VisitPointerType(pointerType);
        }

        public override SymbolType VisitScalarType(Stride.Shaders.Core.ScalarType scalarType)
        {
            return (SymbolType)base.VisitScalarType(scalarType);
        }

        public override SymbolType VisitVectorType(Stride.Shaders.Core.VectorType vectorType)
        {
            var baseTypeTemp = (Stride.Shaders.Core.ScalarType)VisitType(vectorType.BaseType);
            if (!ReferenceEquals(baseTypeTemp, vectorType.BaseType))
                vectorType = vectorType with
                {
                    BaseType = baseTypeTemp
                };
            return (SymbolType)base.VisitVectorType(vectorType);
        }

        public override SymbolType VisitMatrixType(Stride.Shaders.Core.MatrixType matrixType)
        {
            var baseTypeTemp = (Stride.Shaders.Core.ScalarType)VisitType(matrixType.BaseType);
            if (!ReferenceEquals(baseTypeTemp, matrixType.BaseType))
                matrixType = matrixType with
                {
                    BaseType = baseTypeTemp
                };
            return (SymbolType)base.VisitMatrixType(matrixType);
        }

        public override SymbolType VisitArrayType(Stride.Shaders.Core.ArrayType arrayType)
        {
            var baseTypeTemp = (Stride.Shaders.Core.SymbolType)VisitType(arrayType.BaseType);
            if (!ReferenceEquals(baseTypeTemp, arrayType.BaseType))
                arrayType = arrayType with
                {
                    BaseType = baseTypeTemp
                };
            return (SymbolType)base.VisitArrayType(arrayType);
        }

        public override bool VisitStructuredTypeMember(ref Stride.Shaders.Core.StructuredTypeMember structuredTypeMember)
        {
            var typeTemp = (Stride.Shaders.Core.SymbolType)VisitType(structuredTypeMember.Type);
            if (!ReferenceEquals(typeTemp, structuredTypeMember.Type))
                structuredTypeMember = structuredTypeMember with
                {
                    Type = typeTemp
                };
            return base.VisitStructuredTypeMember(ref structuredTypeMember);
        }

        public override SymbolType VisitStructuredType(Stride.Shaders.Core.StructuredType structuredType)
        {
            var membersTemp = (System.Collections.Generic.List<Stride.Shaders.Core.StructuredTypeMember>)VisitItemList(structuredType.Members);
            if (!ReferenceEquals(membersTemp, structuredType.Members))
                structuredType = structuredType with
                {
                    Members = membersTemp
                };
            return (SymbolType)base.VisitStructuredType(structuredType);
        }

        public override SymbolType VisitStructType(Stride.Shaders.Core.StructType structType)
        {
            var membersTemp = (System.Collections.Generic.List<Stride.Shaders.Core.StructuredTypeMember>)VisitItemList(structType.Members);
            if (!ReferenceEquals(membersTemp, structType.Members))
                structType = structType with
                {
                    Members = membersTemp
                };
            return (SymbolType)base.VisitStructType(structType);
        }

        public override SymbolType VisitStructuredBufferType(Stride.Shaders.Core.StructuredBufferType structuredBufferType)
        {
            var membersTemp = (System.Collections.Generic.List<Stride.Shaders.Core.StructuredTypeMember>)VisitItemList(structuredBufferType.Members);
            if (!ReferenceEquals(membersTemp, structuredBufferType.Members))
                structuredBufferType = structuredBufferType with
                {
                    Members = membersTemp
                };
            var baseTypeTemp = (Stride.Shaders.Core.SymbolType)VisitType(structuredBufferType.BaseType);
            if (!ReferenceEquals(baseTypeTemp, structuredBufferType.BaseType))
                structuredBufferType = structuredBufferType with
                {
                    BaseType = baseTypeTemp
                };
            return (SymbolType)base.VisitStructuredBufferType(structuredBufferType);
        }

        public override SymbolType VisitBufferType(Stride.Shaders.Core.BufferType bufferType)
        {
            var baseTypeTemp = (Stride.Shaders.Core.ScalarType)VisitType(bufferType.BaseType);
            if (!ReferenceEquals(baseTypeTemp, bufferType.BaseType))
                bufferType = bufferType with
                {
                    BaseType = baseTypeTemp
                };
            return (SymbolType)base.VisitBufferType(bufferType);
        }

        public override SymbolType VisitSamplerType(Stride.Shaders.Core.SamplerType samplerType)
        {
            return (SymbolType)base.VisitSamplerType(samplerType);
        }

        public override SymbolType VisitSampledImage(Stride.Shaders.Core.SampledImage sampledImage)
        {
            var imageTypeTemp = (Stride.Shaders.Core.TextureType)VisitType(sampledImage.ImageType);
            if (!ReferenceEquals(imageTypeTemp, sampledImage.ImageType))
                sampledImage = sampledImage with
                {
                    ImageType = imageTypeTemp
                };
            return (SymbolType)base.VisitSampledImage(sampledImage);
        }

        public override SymbolType VisitTexture1DType(Stride.Shaders.Core.Texture1DType texture1DType)
        {
            var returnTypeTemp = (Stride.Shaders.Core.ScalarType)VisitType(texture1DType.ReturnType);
            if (!ReferenceEquals(returnTypeTemp, texture1DType.ReturnType))
                texture1DType = texture1DType with
                {
                    ReturnType = returnTypeTemp
                };
            return (SymbolType)base.VisitTexture1DType(texture1DType);
        }

        public override SymbolType VisitTexture2DType(Stride.Shaders.Core.Texture2DType texture2DType)
        {
            var returnTypeTemp = (Stride.Shaders.Core.ScalarType)VisitType(texture2DType.ReturnType);
            if (!ReferenceEquals(returnTypeTemp, texture2DType.ReturnType))
                texture2DType = texture2DType with
                {
                    ReturnType = returnTypeTemp
                };
            return (SymbolType)base.VisitTexture2DType(texture2DType);
        }

        public override SymbolType VisitTexture3DType(Stride.Shaders.Core.Texture3DType texture3DType)
        {
            var returnTypeTemp = (Stride.Shaders.Core.ScalarType)VisitType(texture3DType.ReturnType);
            if (!ReferenceEquals(returnTypeTemp, texture3DType.ReturnType))
                texture3DType = texture3DType with
                {
                    ReturnType = returnTypeTemp
                };
            return (SymbolType)base.VisitTexture3DType(texture3DType);
        }

        public override SymbolType VisitTextureCubeType(Stride.Shaders.Core.TextureCubeType textureCubeType)
        {
            var returnTypeTemp = (Stride.Shaders.Core.ScalarType)VisitType(textureCubeType.ReturnType);
            if (!ReferenceEquals(returnTypeTemp, textureCubeType.ReturnType))
                textureCubeType = textureCubeType with
                {
                    ReturnType = returnTypeTemp
                };
            return (SymbolType)base.VisitTextureCubeType(textureCubeType);
        }

        public override SymbolType VisitFunctionGroupType(Stride.Shaders.Core.FunctionGroupType functionGroupType)
        {
            return (SymbolType)base.VisitFunctionGroupType(functionGroupType);
        }

        public override bool VisitFunctionParameter(ref Stride.Shaders.Core.FunctionParameter functionParameter)
        {
            var typeTemp = (Stride.Shaders.Core.SymbolType)VisitType(functionParameter.Type);
            if (!ReferenceEquals(typeTemp, functionParameter.Type))
                functionParameter = functionParameter with
                {
                    Type = typeTemp
                };
            return base.VisitFunctionParameter(ref functionParameter);
        }

        public override SymbolType VisitFunctionType(Stride.Shaders.Core.FunctionType functionType)
        {
            var returnTypeTemp = (Stride.Shaders.Core.SymbolType)VisitType(functionType.ReturnType);
            if (!ReferenceEquals(returnTypeTemp, functionType.ReturnType))
                functionType = functionType with
                {
                    ReturnType = returnTypeTemp
                };
            var parameterTypesTemp = (System.Collections.Generic.List<Stride.Shaders.Core.FunctionParameter>)VisitItemList(functionType.ParameterTypes);
            if (!ReferenceEquals(parameterTypesTemp, functionType.ParameterTypes))
                functionType = functionType with
                {
                    ParameterTypes = parameterTypesTemp
                };
            return (SymbolType)base.VisitFunctionType(functionType);
        }

        public override SymbolType VisitStreamsSymbol(Stride.Shaders.Core.StreamsSymbol streamsSymbol)
        {
            return (SymbolType)base.VisitStreamsSymbol(streamsSymbol);
        }

        public override SymbolType VisitConstantBufferSymbol(Stride.Shaders.Core.ConstantBufferSymbol constantBufferSymbol)
        {
            var membersTemp = (System.Collections.Generic.List<Stride.Shaders.Core.StructuredTypeMember>)VisitItemList(constantBufferSymbol.Members);
            if (!ReferenceEquals(membersTemp, constantBufferSymbol.Members))
                constantBufferSymbol = constantBufferSymbol with
                {
                    Members = membersTemp
                };
            return (SymbolType)base.VisitConstantBufferSymbol(constantBufferSymbol);
        }

        public override SymbolType VisitParamsSymbol(Stride.Shaders.Core.ParamsSymbol paramsSymbol)
        {
            return (SymbolType)base.VisitParamsSymbol(paramsSymbol);
        }

        public override SymbolType VisitEffectSymbol(Stride.Shaders.Core.EffectSymbol effectSymbol)
        {
            return (SymbolType)base.VisitEffectSymbol(effectSymbol);
        }

        public override SymbolType VisitShaderSymbol(Stride.Shaders.Core.ShaderSymbol shaderSymbol)
        {
            return (SymbolType)base.VisitShaderSymbol(shaderSymbol);
        }

        public override SymbolType VisitLoadedShaderSymbol(Stride.Shaders.Core.LoadedShaderSymbol loadedShaderSymbol)
        {
            var inheritedShadersTemp = (System.Collections.Generic.List<Stride.Shaders.Core.LoadedShaderSymbol>)VisitTypeList(loadedShaderSymbol.InheritedShaders);
            if (!ReferenceEquals(inheritedShadersTemp, loadedShaderSymbol.InheritedShaders))
                loadedShaderSymbol = loadedShaderSymbol with
                {
                    InheritedShaders = inheritedShadersTemp
                };
            return (SymbolType)base.VisitLoadedShaderSymbol(loadedShaderSymbol);
        }

        public override SymbolType VisitGenericParameterType(Stride.Shaders.Core.GenericParameterType genericParameterType)
        {
            return (SymbolType)base.VisitGenericParameterType(genericParameterType);
        }

        public override SymbolType VisitStreamsType(Stride.Shaders.Core.StreamsType streamsType)
        {
            return (SymbolType)base.VisitStreamsType(streamsType);
        }

        public override SymbolType VisitGeometryStreamType(Stride.Shaders.Core.GeometryStreamType geometryStreamType)
        {
            var baseTypeTemp = (Stride.Shaders.Core.SymbolType)VisitType(geometryStreamType.BaseType);
            if (!ReferenceEquals(baseTypeTemp, geometryStreamType.BaseType))
                geometryStreamType = geometryStreamType with
                {
                    BaseType = baseTypeTemp
                };
            return (SymbolType)base.VisitGeometryStreamType(geometryStreamType);
        }

        public override SymbolType VisitPatchType(Stride.Shaders.Core.PatchType patchType)
        {
            var baseTypeTemp = (Stride.Shaders.Core.SymbolType)VisitType(patchType.BaseType);
            if (!ReferenceEquals(baseTypeTemp, patchType.BaseType))
                patchType = patchType with
                {
                    BaseType = baseTypeTemp
                };
            return (SymbolType)base.VisitPatchType(patchType);
        }

        public override SymbolType VisitShaderMixinType(Stride.Shaders.Core.ShaderMixinType shaderMixinType)
        {
            return (SymbolType)base.VisitShaderMixinType(shaderMixinType);
        }

        public override SymbolType VisitExternalType(Stride.Shaders.Core.ExternalType externalType)
        {
            return (SymbolType)base.VisitExternalType(externalType);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record UndefinedType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitUndefinedType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitUndefinedType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record PointerType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitPointerType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitPointerType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record ScalarType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitScalarType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitScalarType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record VectorType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitVectorType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitVectorType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record MatrixType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitMatrixType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitMatrixType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record ArrayType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitArrayType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitArrayType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record struct StructuredTypeMember
    {
        public void Accept(TypeVisitor visitor)
        {
            visitor.VisitStructuredTypeMember(this);
        }

        public bool Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitStructuredTypeMember(ref this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record StructuredType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitStructuredType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitStructuredType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record StructType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitStructType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitStructType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record StructuredBufferType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitStructuredBufferType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitStructuredBufferType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record BufferType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitBufferType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitBufferType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record SamplerType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitSamplerType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitSamplerType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record SampledImage
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitSampledImage(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitSampledImage(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record Texture1DType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitTexture1DType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitTexture1DType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record Texture2DType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitTexture2DType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitTexture2DType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record Texture3DType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitTexture3DType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitTexture3DType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record TextureCubeType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitTextureCubeType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitTextureCubeType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record FunctionGroupType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitFunctionGroupType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitFunctionGroupType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record struct FunctionParameter
    {
        public void Accept(TypeVisitor visitor)
        {
            visitor.VisitFunctionParameter(this);
        }

        public bool Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitFunctionParameter(ref this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record FunctionType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitFunctionType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitFunctionType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record StreamsSymbol
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitStreamsSymbol(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitStreamsSymbol(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record ConstantBufferSymbol
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitConstantBufferSymbol(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitConstantBufferSymbol(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record ParamsSymbol
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitParamsSymbol(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitParamsSymbol(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record EffectSymbol
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitEffectSymbol(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitEffectSymbol(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record ShaderSymbol
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitShaderSymbol(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitShaderSymbol(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record LoadedShaderSymbol
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitLoadedShaderSymbol(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitLoadedShaderSymbol(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record GenericParameterType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitGenericParameterType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitGenericParameterType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record StreamsType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitStreamsType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitStreamsType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record GeometryStreamType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitGeometryStreamType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitGeometryStreamType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record PatchType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitPatchType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitPatchType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record ShaderMixinType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitShaderMixinType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitShaderMixinType(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record ExternalType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.VisitExternalType(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.VisitExternalType(this);
        }
    }
}