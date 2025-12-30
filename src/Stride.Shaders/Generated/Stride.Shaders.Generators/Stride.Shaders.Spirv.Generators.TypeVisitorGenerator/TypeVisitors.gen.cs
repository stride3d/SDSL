namespace Stride.Shaders.Core
{
    public partial class TypeVisitor<TResult>
    {
        public virtual TResult Visit(Stride.Shaders.Core.UndefinedType undefinedType)
        {
            return DefaultVisit(undefinedType);
        }

        public virtual TResult Visit(Stride.Shaders.Core.PointerType pointerType)
        {
            return DefaultVisit(pointerType);
        }

        public virtual TResult Visit(Stride.Shaders.Core.ScalarType scalarType)
        {
            return DefaultVisit(scalarType);
        }

        public virtual TResult Visit(Stride.Shaders.Core.VectorType vectorType)
        {
            return DefaultVisit(vectorType);
        }

        public virtual TResult Visit(Stride.Shaders.Core.MatrixType matrixType)
        {
            return DefaultVisit(matrixType);
        }

        public virtual TResult Visit(Stride.Shaders.Core.ArrayType arrayType)
        {
            return DefaultVisit(arrayType);
        }

        public virtual bool Visit(ref Stride.Shaders.Core.StructuredTypeMember structuredTypeMember)
        {
            return DefaultVisit(ref structuredTypeMember);
        }

        public virtual TResult Visit(Stride.Shaders.Core.StructuredType structuredType)
        {
            return DefaultVisit(structuredType);
        }

        public virtual TResult Visit(Stride.Shaders.Core.StructType structType)
        {
            return DefaultVisit(structType);
        }

        public virtual TResult Visit(Stride.Shaders.Core.BufferType bufferType)
        {
            return DefaultVisit(bufferType);
        }

        public virtual TResult Visit(Stride.Shaders.Core.SamplerType samplerType)
        {
            return DefaultVisit(samplerType);
        }

        public virtual TResult Visit(Stride.Shaders.Core.SampledImage sampledImage)
        {
            return DefaultVisit(sampledImage);
        }

        public virtual TResult Visit(Stride.Shaders.Core.Texture1DType texture1DType)
        {
            return DefaultVisit(texture1DType);
        }

        public virtual TResult Visit(Stride.Shaders.Core.Texture2DType texture2DType)
        {
            return DefaultVisit(texture2DType);
        }

        public virtual TResult Visit(Stride.Shaders.Core.Texture3DType texture3DType)
        {
            return DefaultVisit(texture3DType);
        }

        public virtual TResult Visit(Stride.Shaders.Core.TextureCubeType textureCubeType)
        {
            return DefaultVisit(textureCubeType);
        }

        public virtual TResult Visit(Stride.Shaders.Core.FunctionGroupType functionGroupType)
        {
            return DefaultVisit(functionGroupType);
        }

        public virtual bool Visit(ref Stride.Shaders.Core.FunctionParameter functionParameter)
        {
            return DefaultVisit(ref functionParameter);
        }

        public virtual TResult Visit(Stride.Shaders.Core.FunctionType functionType)
        {
            return DefaultVisit(functionType);
        }

        public virtual TResult Visit(Stride.Shaders.Core.StreamsSymbol streamsSymbol)
        {
            return DefaultVisit(streamsSymbol);
        }

        public virtual TResult Visit(Stride.Shaders.Core.ConstantBufferSymbol constantBufferSymbol)
        {
            return DefaultVisit(constantBufferSymbol);
        }

        public virtual TResult Visit(Stride.Shaders.Core.ParamsSymbol paramsSymbol)
        {
            return DefaultVisit(paramsSymbol);
        }

        public virtual TResult Visit(Stride.Shaders.Core.EffectSymbol effectSymbol)
        {
            return DefaultVisit(effectSymbol);
        }

        public virtual TResult Visit(Stride.Shaders.Core.ShaderSymbol shaderSymbol)
        {
            return DefaultVisit(shaderSymbol);
        }

        public virtual TResult Visit(Stride.Shaders.Core.LoadedShaderSymbol loadedShaderSymbol)
        {
            return DefaultVisit(loadedShaderSymbol);
        }

        public virtual TResult Visit(Stride.Shaders.Core.GenericParameterType genericParameterType)
        {
            return DefaultVisit(genericParameterType);
        }

        public virtual TResult Visit(Stride.Shaders.Core.StreamsType streamsType)
        {
            return DefaultVisit(streamsType);
        }
    }

    public partial class TypeRewriter
    {
        public override SymbolType Visit(Stride.Shaders.Core.UndefinedType undefinedType)
        {
            return (SymbolType)base.Visit(undefinedType);
        }

        public override SymbolType Visit(Stride.Shaders.Core.PointerType pointerType)
        {
            var baseTypeTemp = (Stride.Shaders.Core.SymbolType)VisitType(pointerType.BaseType);
            if (!ReferenceEquals(baseTypeTemp, pointerType.BaseType))
                pointerType = pointerType with
                {
                    BaseType = baseTypeTemp
                };
            return (SymbolType)base.Visit(pointerType);
        }

        public override SymbolType Visit(Stride.Shaders.Core.ScalarType scalarType)
        {
            return (SymbolType)base.Visit(scalarType);
        }

        public override SymbolType Visit(Stride.Shaders.Core.VectorType vectorType)
        {
            var baseTypeTemp = (Stride.Shaders.Core.ScalarType)VisitType(vectorType.BaseType);
            if (!ReferenceEquals(baseTypeTemp, vectorType.BaseType))
                vectorType = vectorType with
                {
                    BaseType = baseTypeTemp
                };
            return (SymbolType)base.Visit(vectorType);
        }

        public override SymbolType Visit(Stride.Shaders.Core.MatrixType matrixType)
        {
            var baseTypeTemp = (Stride.Shaders.Core.ScalarType)VisitType(matrixType.BaseType);
            if (!ReferenceEquals(baseTypeTemp, matrixType.BaseType))
                matrixType = matrixType with
                {
                    BaseType = baseTypeTemp
                };
            return (SymbolType)base.Visit(matrixType);
        }

        public override SymbolType Visit(Stride.Shaders.Core.ArrayType arrayType)
        {
            var baseTypeTemp = (Stride.Shaders.Core.SymbolType)VisitType(arrayType.BaseType);
            if (!ReferenceEquals(baseTypeTemp, arrayType.BaseType))
                arrayType = arrayType with
                {
                    BaseType = baseTypeTemp
                };
            return (SymbolType)base.Visit(arrayType);
        }

        public override bool Visit(ref Stride.Shaders.Core.StructuredTypeMember structuredTypeMember)
        {
            var typeTemp = (Stride.Shaders.Core.SymbolType)VisitType(structuredTypeMember.Type);
            if (!ReferenceEquals(typeTemp, structuredTypeMember.Type))
                structuredTypeMember = structuredTypeMember with
                {
                    Type = typeTemp
                };
            return base.Visit(ref structuredTypeMember);
        }

        public override SymbolType Visit(Stride.Shaders.Core.StructuredType structuredType)
        {
            var membersTemp = (System.Collections.Generic.List<Stride.Shaders.Core.StructuredTypeMember>)VisitNodeList(structuredType.Members);
            if (!ReferenceEquals(membersTemp, structuredType.Members))
                structuredType = structuredType with
                {
                    Members = membersTemp
                };
            return (SymbolType)base.Visit(structuredType);
        }

        public override SymbolType Visit(Stride.Shaders.Core.StructType structType)
        {
            var membersTemp = (System.Collections.Generic.List<Stride.Shaders.Core.StructuredTypeMember>)VisitNodeList(structType.Members);
            if (!ReferenceEquals(membersTemp, structType.Members))
                structType = structType with
                {
                    Members = membersTemp
                };
            return (SymbolType)base.Visit(structType);
        }

        public override SymbolType Visit(Stride.Shaders.Core.BufferType bufferType)
        {
            var baseTypeTemp = (Stride.Shaders.Core.ScalarType)VisitType(bufferType.BaseType);
            if (!ReferenceEquals(baseTypeTemp, bufferType.BaseType))
                bufferType = bufferType with
                {
                    BaseType = baseTypeTemp
                };
            return (SymbolType)base.Visit(bufferType);
        }

        public override SymbolType Visit(Stride.Shaders.Core.SamplerType samplerType)
        {
            return (SymbolType)base.Visit(samplerType);
        }

        public override SymbolType Visit(Stride.Shaders.Core.SampledImage sampledImage)
        {
            var imageTypeTemp = (Stride.Shaders.Core.TextureType)VisitType(sampledImage.ImageType);
            if (!ReferenceEquals(imageTypeTemp, sampledImage.ImageType))
                sampledImage = sampledImage with
                {
                    ImageType = imageTypeTemp
                };
            return (SymbolType)base.Visit(sampledImage);
        }

        public override SymbolType Visit(Stride.Shaders.Core.Texture1DType texture1DType)
        {
            var returnTypeTemp = (Stride.Shaders.Core.ScalarType)VisitType(texture1DType.ReturnType);
            if (!ReferenceEquals(returnTypeTemp, texture1DType.ReturnType))
                texture1DType = texture1DType with
                {
                    ReturnType = returnTypeTemp
                };
            return (SymbolType)base.Visit(texture1DType);
        }

        public override SymbolType Visit(Stride.Shaders.Core.Texture2DType texture2DType)
        {
            var returnTypeTemp = (Stride.Shaders.Core.ScalarType)VisitType(texture2DType.ReturnType);
            if (!ReferenceEquals(returnTypeTemp, texture2DType.ReturnType))
                texture2DType = texture2DType with
                {
                    ReturnType = returnTypeTemp
                };
            return (SymbolType)base.Visit(texture2DType);
        }

        public override SymbolType Visit(Stride.Shaders.Core.Texture3DType texture3DType)
        {
            var returnTypeTemp = (Stride.Shaders.Core.ScalarType)VisitType(texture3DType.ReturnType);
            if (!ReferenceEquals(returnTypeTemp, texture3DType.ReturnType))
                texture3DType = texture3DType with
                {
                    ReturnType = returnTypeTemp
                };
            return (SymbolType)base.Visit(texture3DType);
        }

        public override SymbolType Visit(Stride.Shaders.Core.TextureCubeType textureCubeType)
        {
            var returnTypeTemp = (Stride.Shaders.Core.ScalarType)VisitType(textureCubeType.ReturnType);
            if (!ReferenceEquals(returnTypeTemp, textureCubeType.ReturnType))
                textureCubeType = textureCubeType with
                {
                    ReturnType = returnTypeTemp
                };
            return (SymbolType)base.Visit(textureCubeType);
        }

        public override SymbolType Visit(Stride.Shaders.Core.FunctionGroupType functionGroupType)
        {
            return (SymbolType)base.Visit(functionGroupType);
        }

        public override bool Visit(ref Stride.Shaders.Core.FunctionParameter functionParameter)
        {
            var typeTemp = (Stride.Shaders.Core.SymbolType)VisitType(functionParameter.Type);
            if (!ReferenceEquals(typeTemp, functionParameter.Type))
                functionParameter = functionParameter with
                {
                    Type = typeTemp
                };
            return base.Visit(ref functionParameter);
        }

        public override SymbolType Visit(Stride.Shaders.Core.FunctionType functionType)
        {
            var returnTypeTemp = (Stride.Shaders.Core.SymbolType)VisitType(functionType.ReturnType);
            if (!ReferenceEquals(returnTypeTemp, functionType.ReturnType))
                functionType = functionType with
                {
                    ReturnType = returnTypeTemp
                };
            var parameterTypesTemp = (System.Collections.Generic.List<Stride.Shaders.Core.FunctionParameter>)VisitNodeList(functionType.ParameterTypes);
            if (!ReferenceEquals(parameterTypesTemp, functionType.ParameterTypes))
                functionType = functionType with
                {
                    ParameterTypes = parameterTypesTemp
                };
            return (SymbolType)base.Visit(functionType);
        }

        public override SymbolType Visit(Stride.Shaders.Core.StreamsSymbol streamsSymbol)
        {
            return (SymbolType)base.Visit(streamsSymbol);
        }

        public override SymbolType Visit(Stride.Shaders.Core.ConstantBufferSymbol constantBufferSymbol)
        {
            var membersTemp = (System.Collections.Generic.List<Stride.Shaders.Core.StructuredTypeMember>)VisitNodeList(constantBufferSymbol.Members);
            if (!ReferenceEquals(membersTemp, constantBufferSymbol.Members))
                constantBufferSymbol = constantBufferSymbol with
                {
                    Members = membersTemp
                };
            return (SymbolType)base.Visit(constantBufferSymbol);
        }

        public override SymbolType Visit(Stride.Shaders.Core.ParamsSymbol paramsSymbol)
        {
            return (SymbolType)base.Visit(paramsSymbol);
        }

        public override SymbolType Visit(Stride.Shaders.Core.EffectSymbol effectSymbol)
        {
            return (SymbolType)base.Visit(effectSymbol);
        }

        public override SymbolType Visit(Stride.Shaders.Core.ShaderSymbol shaderSymbol)
        {
            return (SymbolType)base.Visit(shaderSymbol);
        }

        public override SymbolType Visit(Stride.Shaders.Core.LoadedShaderSymbol loadedShaderSymbol)
        {
            var inheritedShadersTemp = (System.Collections.Generic.List<Stride.Shaders.Core.LoadedShaderSymbol>)VisitTypeList(loadedShaderSymbol.InheritedShaders);
            if (!ReferenceEquals(inheritedShadersTemp, loadedShaderSymbol.InheritedShaders))
                loadedShaderSymbol = loadedShaderSymbol with
                {
                    InheritedShaders = inheritedShadersTemp
                };
            return (SymbolType)base.Visit(loadedShaderSymbol);
        }

        public override SymbolType Visit(Stride.Shaders.Core.GenericParameterType genericParameterType)
        {
            return (SymbolType)base.Visit(genericParameterType);
        }

        public override SymbolType Visit(Stride.Shaders.Core.StreamsType streamsType)
        {
            return (SymbolType)base.Visit(streamsType);
        }
    }

    public partial class TypeVisitor
    {
        public virtual void Visit(Stride.Shaders.Core.UndefinedType undefinedType)
        {
            DefaultVisit(undefinedType);
        }

        public virtual void Visit(Stride.Shaders.Core.PointerType pointerType)
        {
            DefaultVisit(pointerType);
        }

        public virtual void Visit(Stride.Shaders.Core.ScalarType scalarType)
        {
            DefaultVisit(scalarType);
        }

        public virtual void Visit(Stride.Shaders.Core.VectorType vectorType)
        {
            DefaultVisit(vectorType);
        }

        public virtual void Visit(Stride.Shaders.Core.MatrixType matrixType)
        {
            DefaultVisit(matrixType);
        }

        public virtual void Visit(Stride.Shaders.Core.ArrayType arrayType)
        {
            DefaultVisit(arrayType);
        }

        public virtual void Visit(Stride.Shaders.Core.StructuredTypeMember structuredTypeMember)
        {
            DefaultVisit(structuredTypeMember);
        }

        public virtual void Visit(Stride.Shaders.Core.StructuredType structuredType)
        {
            DefaultVisit(structuredType);
        }

        public virtual void Visit(Stride.Shaders.Core.StructType structType)
        {
            DefaultVisit(structType);
        }

        public virtual void Visit(Stride.Shaders.Core.BufferType bufferType)
        {
            DefaultVisit(bufferType);
        }

        public virtual void Visit(Stride.Shaders.Core.SamplerType samplerType)
        {
            DefaultVisit(samplerType);
        }

        public virtual void Visit(Stride.Shaders.Core.SampledImage sampledImage)
        {
            DefaultVisit(sampledImage);
        }

        public virtual void Visit(Stride.Shaders.Core.Texture1DType texture1DType)
        {
            DefaultVisit(texture1DType);
        }

        public virtual void Visit(Stride.Shaders.Core.Texture2DType texture2DType)
        {
            DefaultVisit(texture2DType);
        }

        public virtual void Visit(Stride.Shaders.Core.Texture3DType texture3DType)
        {
            DefaultVisit(texture3DType);
        }

        public virtual void Visit(Stride.Shaders.Core.TextureCubeType textureCubeType)
        {
            DefaultVisit(textureCubeType);
        }

        public virtual void Visit(Stride.Shaders.Core.FunctionGroupType functionGroupType)
        {
            DefaultVisit(functionGroupType);
        }

        public virtual void Visit(Stride.Shaders.Core.FunctionParameter functionParameter)
        {
            DefaultVisit(functionParameter);
        }

        public virtual void Visit(Stride.Shaders.Core.FunctionType functionType)
        {
            DefaultVisit(functionType);
        }

        public virtual void Visit(Stride.Shaders.Core.StreamsSymbol streamsSymbol)
        {
            DefaultVisit(streamsSymbol);
        }

        public virtual void Visit(Stride.Shaders.Core.ConstantBufferSymbol constantBufferSymbol)
        {
            DefaultVisit(constantBufferSymbol);
        }

        public virtual void Visit(Stride.Shaders.Core.ParamsSymbol paramsSymbol)
        {
            DefaultVisit(paramsSymbol);
        }

        public virtual void Visit(Stride.Shaders.Core.EffectSymbol effectSymbol)
        {
            DefaultVisit(effectSymbol);
        }

        public virtual void Visit(Stride.Shaders.Core.ShaderSymbol shaderSymbol)
        {
            DefaultVisit(shaderSymbol);
        }

        public virtual void Visit(Stride.Shaders.Core.LoadedShaderSymbol loadedShaderSymbol)
        {
            DefaultVisit(loadedShaderSymbol);
        }

        public virtual void Visit(Stride.Shaders.Core.GenericParameterType genericParameterType)
        {
            DefaultVisit(genericParameterType);
        }

        public virtual void Visit(Stride.Shaders.Core.StreamsType streamsType)
        {
            DefaultVisit(streamsType);
        }
    }

    public partial class TypeWalker
    {
        public override void Visit(Stride.Shaders.Core.UndefinedType undefinedType)
        {
            base.Visit(undefinedType);
        }

        public override void Visit(Stride.Shaders.Core.PointerType pointerType)
        {
            VisitType(pointerType.BaseType);
            base.Visit(pointerType);
        }

        public override void Visit(Stride.Shaders.Core.ScalarType scalarType)
        {
            base.Visit(scalarType);
        }

        public override void Visit(Stride.Shaders.Core.VectorType vectorType)
        {
            VisitType(vectorType.BaseType);
            base.Visit(vectorType);
        }

        public override void Visit(Stride.Shaders.Core.MatrixType matrixType)
        {
            VisitType(matrixType.BaseType);
            base.Visit(matrixType);
        }

        public override void Visit(Stride.Shaders.Core.ArrayType arrayType)
        {
            VisitType(arrayType.BaseType);
            base.Visit(arrayType);
        }

        public override void Visit(Stride.Shaders.Core.StructuredTypeMember structuredTypeMember)
        {
            VisitType(structuredTypeMember.Type);
            base.Visit(structuredTypeMember);
        }

        public override void Visit(Stride.Shaders.Core.StructuredType structuredType)
        {
            VisitNodeList(structuredType.Members);
            base.Visit(structuredType);
        }

        public override void Visit(Stride.Shaders.Core.StructType structType)
        {
            VisitNodeList(structType.Members);
            base.Visit(structType);
        }

        public override void Visit(Stride.Shaders.Core.BufferType bufferType)
        {
            VisitType(bufferType.BaseType);
            base.Visit(bufferType);
        }

        public override void Visit(Stride.Shaders.Core.SamplerType samplerType)
        {
            base.Visit(samplerType);
        }

        public override void Visit(Stride.Shaders.Core.SampledImage sampledImage)
        {
            VisitType(sampledImage.ImageType);
            base.Visit(sampledImage);
        }

        public override void Visit(Stride.Shaders.Core.Texture1DType texture1DType)
        {
            VisitType(texture1DType.ReturnType);
            base.Visit(texture1DType);
        }

        public override void Visit(Stride.Shaders.Core.Texture2DType texture2DType)
        {
            VisitType(texture2DType.ReturnType);
            base.Visit(texture2DType);
        }

        public override void Visit(Stride.Shaders.Core.Texture3DType texture3DType)
        {
            VisitType(texture3DType.ReturnType);
            base.Visit(texture3DType);
        }

        public override void Visit(Stride.Shaders.Core.TextureCubeType textureCubeType)
        {
            VisitType(textureCubeType.ReturnType);
            base.Visit(textureCubeType);
        }

        public override void Visit(Stride.Shaders.Core.FunctionGroupType functionGroupType)
        {
            base.Visit(functionGroupType);
        }

        public override void Visit(Stride.Shaders.Core.FunctionParameter functionParameter)
        {
            VisitType(functionParameter.Type);
            base.Visit(functionParameter);
        }

        public override void Visit(Stride.Shaders.Core.FunctionType functionType)
        {
            VisitType(functionType.ReturnType);
            VisitNodeList(functionType.ParameterTypes);
            base.Visit(functionType);
        }

        public override void Visit(Stride.Shaders.Core.StreamsSymbol streamsSymbol)
        {
            base.Visit(streamsSymbol);
        }

        public override void Visit(Stride.Shaders.Core.ConstantBufferSymbol constantBufferSymbol)
        {
            VisitNodeList(constantBufferSymbol.Members);
            base.Visit(constantBufferSymbol);
        }

        public override void Visit(Stride.Shaders.Core.ParamsSymbol paramsSymbol)
        {
            base.Visit(paramsSymbol);
        }

        public override void Visit(Stride.Shaders.Core.EffectSymbol effectSymbol)
        {
            base.Visit(effectSymbol);
        }

        public override void Visit(Stride.Shaders.Core.ShaderSymbol shaderSymbol)
        {
            base.Visit(shaderSymbol);
        }

        public override void Visit(Stride.Shaders.Core.LoadedShaderSymbol loadedShaderSymbol)
        {
            VisitTypeList(loadedShaderSymbol.InheritedShaders);
            base.Visit(loadedShaderSymbol);
        }

        public override void Visit(Stride.Shaders.Core.GenericParameterType genericParameterType)
        {
            base.Visit(genericParameterType);
        }

        public override void Visit(Stride.Shaders.Core.StreamsType streamsType)
        {
            base.Visit(streamsType);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record UndefinedType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record PointerType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record ScalarType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record VectorType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record MatrixType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record ArrayType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record struct StructuredTypeMember
    {
        public void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public bool Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(ref this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record StructuredType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record StructType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record BufferType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record SamplerType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record SampledImage
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record Texture1DType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record Texture2DType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record Texture3DType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record TextureCubeType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record FunctionGroupType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record struct FunctionParameter
    {
        public void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public bool Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(ref this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record FunctionType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record StreamsSymbol
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record ConstantBufferSymbol
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record ParamsSymbol
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record EffectSymbol
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record ShaderSymbol
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record LoadedShaderSymbol
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record GenericParameterType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Core
{
    public partial record StreamsType
    {
        public override void Accept(TypeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override TResult Accept<TResult>(TypeVisitor<TResult> visitor)
        {
            return visitor.Visit(this);
        }
    }
}