using Stride.Shaders.Core;

namespace Stride.Shaders.Core
{
    public partial class NodeVisitor
    {
        public virtual void Visit(Stride.Shaders.Parsing.NoNode noNode)
        {
            DefaultVisit(noNode);
        }

        public virtual void Visit(Stride.Shaders.Parsing.ShaderFile shaderFile)
        {
            DefaultVisit(shaderFile);
        }

        public virtual void Visit(Stride.Shaders.Parsing.UsingShaderNamespace usingShaderNamespace)
        {
            DefaultVisit(usingShaderNamespace);
        }

        public virtual void Visit(Stride.Shaders.Parsing.ShaderNamespace shaderNamespace)
        {
            DefaultVisit(shaderNamespace);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.PreProcessableCode preProcessableCode)
        {
            DefaultVisit(preProcessableCode);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.DirectiveCode directiveCode)
        {
            DefaultVisit(directiveCode);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ObjectDefineDirective objectDefineDirective)
        {
            DefaultVisit(objectDefineDirective);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.FunctionDefineDirective functionDefineDirective)
        {
            DefaultVisit(functionDefineDirective);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.IfDirective ifDirective)
        {
            DefaultVisit(ifDirective);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.IfDefDirective ifDefDirective)
        {
            DefaultVisit(ifDefDirective);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.IfNDefDirective ifNDefDirective)
        {
            DefaultVisit(ifNDefDirective);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ElifDirective elifDirective)
        {
            DefaultVisit(elifDirective);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ElseDirective elseDirective)
        {
            DefaultVisit(elseDirective);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.EndIfDirective endIfDirective)
        {
            DefaultVisit(endIfDirective);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ConditionalDirectives conditionalDirectives)
        {
            DefaultVisit(conditionalDirectives);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.EmptyExpression emptyExpression)
        {
            DefaultVisit(emptyExpression);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.MethodCall methodCall)
        {
            DefaultVisit(methodCall);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.MixinAccess mixinAccess)
        {
            DefaultVisit(mixinAccess);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.PrefixExpression prefixExpression)
        {
            DefaultVisit(prefixExpression);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.CastExpression castExpression)
        {
            DefaultVisit(castExpression);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.IndexerExpression indexerExpression)
        {
            DefaultVisit(indexerExpression);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.PostfixIncrement postfixIncrement)
        {
            DefaultVisit(postfixIncrement);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.AccessorChainExpression accessorChainExpression)
        {
            DefaultVisit(accessorChainExpression);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.BinaryExpression binaryExpression)
        {
            DefaultVisit(binaryExpression);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.TernaryExpression ternaryExpression)
        {
            DefaultVisit(ternaryExpression);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.StringLiteral stringLiteral)
        {
            DefaultVisit(stringLiteral);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.IntegerLiteral integerLiteral)
        {
            DefaultVisit(integerLiteral);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.FloatLiteral floatLiteral)
        {
            DefaultVisit(floatLiteral);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.HexLiteral hexLiteral)
        {
            DefaultVisit(hexLiteral);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.BoolLiteral boolLiteral)
        {
            DefaultVisit(boolLiteral);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ExpressionLiteral expressionLiteral)
        {
            DefaultVisit(expressionLiteral);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.VectorLiteral vectorLiteral)
        {
            DefaultVisit(vectorLiteral);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.MatrixLiteral matrixLiteral)
        {
            DefaultVisit(matrixLiteral);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ArrayLiteral arrayLiteral)
        {
            DefaultVisit(arrayLiteral);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.Identifier identifier)
        {
            DefaultVisit(identifier);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.TypeName typeName)
        {
            DefaultVisit(typeName);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderClass shaderClass)
        {
            DefaultVisit(shaderClass);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderGenerics shaderGenerics)
        {
            DefaultVisit(shaderGenerics);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.Mixin mixin)
        {
            DefaultVisit(mixin);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderMixinExpression shaderMixinExpression)
        {
            DefaultVisit(shaderMixinExpression);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderMixinIdentifier shaderMixinIdentifier)
        {
            DefaultVisit(shaderMixinIdentifier);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderAttributeList shaderAttributeList)
        {
            DefaultVisit(shaderAttributeList);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.AnyShaderAttribute anyShaderAttribute)
        {
            DefaultVisit(anyShaderAttribute);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ResourceBind resourceBind)
        {
            DefaultVisit(resourceBind);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ColorType colorType)
        {
            DefaultVisit(colorType);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderVariable shaderVariable)
        {
            DefaultVisit(shaderVariable);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.TypeDef typeDef)
        {
            DefaultVisit(typeDef);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderStructMember shaderStructMember)
        {
            DefaultVisit(shaderStructMember);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderStruct shaderStruct)
        {
            DefaultVisit(shaderStruct);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.CBuffer cBuffer)
        {
            DefaultVisit(cBuffer);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.RGroup rGroup)
        {
            DefaultVisit(rGroup);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.TBuffer tBuffer)
        {
            DefaultVisit(tBuffer);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.SamplerStateParameter samplerStateParameter)
        {
            DefaultVisit(samplerStateParameter);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderSamplerState shaderSamplerState)
        {
            DefaultVisit(shaderSamplerState);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderSamplerComparisonState shaderSamplerComparisonState)
        {
            DefaultVisit(shaderSamplerComparisonState);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderCompose shaderCompose)
        {
            DefaultVisit(shaderCompose);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderMember shaderMember)
        {
            DefaultVisit(shaderMember);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.MethodParameter methodParameter)
        {
            DefaultVisit(methodParameter);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderMethod shaderMethod)
        {
            DefaultVisit(shaderMethod);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderParameterDeclarations shaderParameterDeclarations)
        {
            DefaultVisit(shaderParameterDeclarations);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderExpressionList shaderExpressionList)
        {
            DefaultVisit(shaderExpressionList);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ValueTypeGenerics valueTypeGenerics)
        {
            DefaultVisit(valueTypeGenerics);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ConditionalFlow conditionalFlow)
        {
            DefaultVisit(conditionalFlow);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.If @if)
        {
            DefaultVisit(@if);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ElseIf elseIf)
        {
            DefaultVisit(elseIf);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.Else @else)
        {
            DefaultVisit(@else);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.EmptyStatement emptyStatement)
        {
            DefaultVisit(emptyStatement);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ExpressionStatement expressionStatement)
        {
            DefaultVisit(expressionStatement);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.Return @return)
        {
            DefaultVisit(@return);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.VariableAssign variableAssign)
        {
            DefaultVisit(variableAssign);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.DeclaredVariableAssign declaredVariableAssign)
        {
            DefaultVisit(declaredVariableAssign);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.Declare declare)
        {
            DefaultVisit(declare);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.Assign assign)
        {
            DefaultVisit(assign);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.BlockStatement blockStatement)
        {
            DefaultVisit(blockStatement);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.Break @break)
        {
            DefaultVisit(@break);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.Discard discard)
        {
            DefaultVisit(discard);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.Continue @continue)
        {
            DefaultVisit(@continue);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.ForEach forEach)
        {
            DefaultVisit(forEach);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.While @while)
        {
            DefaultVisit(@while);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDSL.AST.For @for)
        {
            DefaultVisit(@for);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDFX.AST.ShaderEffect shaderEffect)
        {
            DefaultVisit(shaderEffect);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDFX.AST.ShaderSourceDeclaration shaderSourceDeclaration)
        {
            DefaultVisit(shaderSourceDeclaration);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDFX.AST.MixinUse mixinUse)
        {
            DefaultVisit(mixinUse);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDFX.AST.MixinChild mixinChild)
        {
            DefaultVisit(mixinChild);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDFX.AST.MixinClone mixinClone)
        {
            DefaultVisit(mixinClone);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDFX.AST.MixinConst mixinConst)
        {
            DefaultVisit(mixinConst);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDFX.AST.ComposePathValue composePathValue)
        {
            DefaultVisit(composePathValue);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDFX.AST.ComposeMixinValue composeMixinValue)
        {
            DefaultVisit(composeMixinValue);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDFX.AST.MixinCompose mixinCompose)
        {
            DefaultVisit(mixinCompose);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDFX.AST.MixinComposeAdd mixinComposeAdd)
        {
            DefaultVisit(mixinComposeAdd);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDFX.AST.ComposeParams composeParams)
        {
            DefaultVisit(composeParams);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDFX.AST.UsingParams usingParams)
        {
            DefaultVisit(usingParams);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDFX.AST.EffectDiscardStatement effectDiscardStatement)
        {
            DefaultVisit(effectDiscardStatement);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDFX.AST.EffectFlow effectFlow)
        {
            DefaultVisit(effectFlow);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDFX.AST.EffectForEach effectForEach)
        {
            DefaultVisit(effectForEach);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDFX.AST.EffectParameters effectParameters)
        {
            DefaultVisit(effectParameters);
        }

        public virtual void Visit(Stride.Shaders.Parsing.SDFX.AST.EffectParameter effectParameter)
        {
            DefaultVisit(effectParameter);
        }
    }

    public partial class NodeWalker
    {
        public override void Visit(Stride.Shaders.Parsing.NoNode noNode)
        {
            base.Visit(noNode);
        }

        public override void Visit(Stride.Shaders.Parsing.ShaderFile shaderFile)
        {
            VisitNodeList(shaderFile.RootDeclarations);
            VisitNodeList(shaderFile.Namespaces);
            base.Visit(shaderFile);
        }

        public override void Visit(Stride.Shaders.Parsing.UsingShaderNamespace usingShaderNamespace)
        {
            VisitNodeList(usingShaderNamespace.NamespacePath);
            base.Visit(usingShaderNamespace);
        }

        public override void Visit(Stride.Shaders.Parsing.ShaderNamespace shaderNamespace)
        {
            VisitNodeList(shaderNamespace.NamespacePath);
            if (shaderNamespace.Namespace != null)
                VisitNode(shaderNamespace.Namespace);
            VisitNodeList(shaderNamespace.Declarations);
            base.Visit(shaderNamespace);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.PreProcessableCode preProcessableCode)
        {
            VisitNodeList(preProcessableCode.Snippets);
            base.Visit(preProcessableCode);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.DirectiveCode directiveCode)
        {
            base.Visit(directiveCode);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ObjectDefineDirective objectDefineDirective)
        {
            VisitNode(objectDefineDirective.Identifier);
            if (objectDefineDirective.Expression != null)
                VisitNode(objectDefineDirective.Expression);
            base.Visit(objectDefineDirective);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.FunctionDefineDirective functionDefineDirective)
        {
            VisitNode(functionDefineDirective.FunctionName);
            VisitNodeList(functionDefineDirective.Parameters);
            base.Visit(functionDefineDirective);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.IfDirective ifDirective)
        {
            if (ifDirective.Expression != null)
                VisitNode(ifDirective.Expression);
            if (ifDirective.Code != null)
                VisitNode(ifDirective.Code);
            base.Visit(ifDirective);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.IfDefDirective ifDefDirective)
        {
            if (ifDefDirective.Expression != null)
                VisitNode(ifDefDirective.Expression);
            if (ifDefDirective.Code != null)
                VisitNode(ifDefDirective.Code);
            base.Visit(ifDefDirective);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.IfNDefDirective ifNDefDirective)
        {
            if (ifNDefDirective.Expression != null)
                VisitNode(ifNDefDirective.Expression);
            if (ifNDefDirective.Code != null)
                VisitNode(ifNDefDirective.Code);
            base.Visit(ifNDefDirective);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ElifDirective elifDirective)
        {
            if (elifDirective.Expression != null)
                VisitNode(elifDirective.Expression);
            if (elifDirective.Code != null)
                VisitNode(elifDirective.Code);
            base.Visit(elifDirective);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ElseDirective elseDirective)
        {
            if (elseDirective.Expression != null)
                VisitNode(elseDirective.Expression);
            if (elseDirective.Code != null)
                VisitNode(elseDirective.Code);
            base.Visit(elseDirective);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.EndIfDirective endIfDirective)
        {
            if (endIfDirective.Expression != null)
                VisitNode(endIfDirective.Expression);
            if (endIfDirective.Code != null)
                VisitNode(endIfDirective.Code);
            base.Visit(endIfDirective);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ConditionalDirectives conditionalDirectives)
        {
            VisitNode(conditionalDirectives.If);
            VisitNodeList(conditionalDirectives.Elifs);
            if (conditionalDirectives.Else != null)
                VisitNode(conditionalDirectives.Else);
            base.Visit(conditionalDirectives);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.EmptyExpression emptyExpression)
        {
            base.Visit(emptyExpression);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.MethodCall methodCall)
        {
            VisitNode(methodCall.Name);
            VisitNode(methodCall.Arguments);
            base.Visit(methodCall);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.MixinAccess mixinAccess)
        {
            VisitNode(mixinAccess.Mixin);
            base.Visit(mixinAccess);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.PrefixExpression prefixExpression)
        {
            VisitNode(prefixExpression.Expression);
            base.Visit(prefixExpression);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.CastExpression castExpression)
        {
            VisitNode(castExpression.Expression);
            VisitNode(castExpression.TypeName);
            base.Visit(castExpression);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.IndexerExpression indexerExpression)
        {
            VisitNode(indexerExpression.Index);
            base.Visit(indexerExpression);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.PostfixIncrement postfixIncrement)
        {
            base.Visit(postfixIncrement);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.AccessorChainExpression accessorChainExpression)
        {
            VisitNode(accessorChainExpression.Source);
            VisitNodeList(accessorChainExpression.Accessors);
            base.Visit(accessorChainExpression);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.BinaryExpression binaryExpression)
        {
            VisitNode(binaryExpression.Left);
            VisitNode(binaryExpression.Right);
            base.Visit(binaryExpression);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.TernaryExpression ternaryExpression)
        {
            VisitNode(ternaryExpression.Condition);
            VisitNode(ternaryExpression.Left);
            VisitNode(ternaryExpression.Right);
            base.Visit(ternaryExpression);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.StringLiteral stringLiteral)
        {
            base.Visit(stringLiteral);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.IntegerLiteral integerLiteral)
        {
            base.Visit(integerLiteral);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.FloatLiteral floatLiteral)
        {
            base.Visit(floatLiteral);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.HexLiteral hexLiteral)
        {
            base.Visit(hexLiteral);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.BoolLiteral boolLiteral)
        {
            base.Visit(boolLiteral);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ExpressionLiteral expressionLiteral)
        {
            VisitNode(expressionLiteral.Value);
            VisitNode(expressionLiteral.TypeName);
            base.Visit(expressionLiteral);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.VectorLiteral vectorLiteral)
        {
            VisitNodeList(vectorLiteral.Values);
            VisitNode(vectorLiteral.TypeName);
            base.Visit(vectorLiteral);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.MatrixLiteral matrixLiteral)
        {
            VisitNodeList(matrixLiteral.Values);
            VisitNode(matrixLiteral.TypeName);
            base.Visit(matrixLiteral);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ArrayLiteral arrayLiteral)
        {
            VisitNodeList(arrayLiteral.Values);
            base.Visit(arrayLiteral);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.Identifier identifier)
        {
            base.Visit(identifier);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.TypeName typeName)
        {
            if (typeName.ArraySize != null)
                VisitNodeList(typeName.ArraySize);
            VisitNodeList(typeName.Generics);
            base.Visit(typeName);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderClass shaderClass)
        {
            VisitNode(shaderClass.Name);
            VisitNodeList(shaderClass.Elements);
            if (shaderClass.Generics != null)
                VisitNode(shaderClass.Generics);
            VisitNodeList(shaderClass.Mixins);
            base.Visit(shaderClass);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderGenerics shaderGenerics)
        {
            VisitNode(shaderGenerics.Name);
            VisitNode(shaderGenerics.TypeName);
            base.Visit(shaderGenerics);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.Mixin mixin)
        {
            VisitNodeList(mixin.Path);
            VisitNode(mixin.Name);
            if (mixin.Generics != null)
                VisitNode(mixin.Generics);
            base.Visit(mixin);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderMixinExpression shaderMixinExpression)
        {
            VisitNode(shaderMixinExpression.Value);
            base.Visit(shaderMixinExpression);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderMixinIdentifier shaderMixinIdentifier)
        {
            VisitNode(shaderMixinIdentifier.Value);
            base.Visit(shaderMixinIdentifier);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderAttributeList shaderAttributeList)
        {
            base.Visit(shaderAttributeList);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.AnyShaderAttribute anyShaderAttribute)
        {
            VisitNode(anyShaderAttribute.Name);
            base.Visit(anyShaderAttribute);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ResourceBind resourceBind)
        {
            base.Visit(resourceBind);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ColorType colorType)
        {
            base.Visit(colorType);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderVariable shaderVariable)
        {
            VisitNode(shaderVariable.Name);
            VisitNode(shaderVariable.TypeName);
            if (shaderVariable.Value != null)
                VisitNode(shaderVariable.Value);
            base.Visit(shaderVariable);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.TypeDef typeDef)
        {
            VisitNode(typeDef.Name);
            VisitNode(typeDef.TypeName);
            base.Visit(typeDef);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderStructMember shaderStructMember)
        {
            VisitNode(shaderStructMember.TypeName);
            VisitNode(shaderStructMember.Name);
            VisitNodeList(shaderStructMember.Attributes);
            base.Visit(shaderStructMember);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderStruct shaderStruct)
        {
            VisitNode(shaderStruct.TypeName);
            VisitNodeList(shaderStruct.Members);
            base.Visit(shaderStruct);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.CBuffer cBuffer)
        {
            VisitNodeList(cBuffer.Members);
            base.Visit(cBuffer);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.RGroup rGroup)
        {
            VisitNodeList(rGroup.Members);
            base.Visit(rGroup);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.TBuffer tBuffer)
        {
            VisitNodeList(tBuffer.Members);
            base.Visit(tBuffer);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.SamplerStateParameter samplerStateParameter)
        {
            VisitNode(samplerStateParameter.Name);
            VisitNode(samplerStateParameter.Value);
            base.Visit(samplerStateParameter);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderSamplerState shaderSamplerState)
        {
            if (shaderSamplerState.Attributes != null)
                VisitNodeList(shaderSamplerState.Attributes);
            VisitNode(shaderSamplerState.Name);
            VisitNodeList(shaderSamplerState.Parameters);
            base.Visit(shaderSamplerState);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderSamplerComparisonState shaderSamplerComparisonState)
        {
            if (shaderSamplerComparisonState.Attributes != null)
                VisitNodeList(shaderSamplerComparisonState.Attributes);
            VisitNode(shaderSamplerComparisonState.Name);
            VisitNodeList(shaderSamplerComparisonState.Parameters);
            base.Visit(shaderSamplerComparisonState);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderCompose shaderCompose)
        {
            if (shaderCompose.Attributes != null)
                VisitNodeList(shaderCompose.Attributes);
            VisitNode(shaderCompose.Name);
            VisitNode(shaderCompose.Mixin);
            base.Visit(shaderCompose);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderMember shaderMember)
        {
            if (shaderMember.Attributes != null)
                VisitNodeList(shaderMember.Attributes);
            VisitNode(shaderMember.Name);
            VisitNode(shaderMember.TypeName);
            if (shaderMember.Semantic != null)
                VisitNode(shaderMember.Semantic);
            if (shaderMember.Value != null)
                VisitNode(shaderMember.Value);
            base.Visit(shaderMember);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.MethodParameter methodParameter)
        {
            VisitNode(methodParameter.TypeName);
            VisitNode(methodParameter.Name);
            if (methodParameter.Semantic != null)
                VisitNode(methodParameter.Semantic);
            if (methodParameter.DefaultValue != null)
                VisitNode(methodParameter.DefaultValue);
            base.Visit(methodParameter);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderMethod shaderMethod)
        {
            if (shaderMethod.Attributes != null)
                VisitNodeList(shaderMethod.Attributes);
            VisitNode(shaderMethod.ReturnTypeName);
            VisitNode(shaderMethod.Name);
            if (shaderMethod.Visibility != null)
                VisitNode(shaderMethod.Visibility);
            if (shaderMethod.Storage != null)
                VisitNode(shaderMethod.Storage);
            VisitNodeList(shaderMethod.Parameters);
            if (shaderMethod.Body != null)
                VisitNode(shaderMethod.Body);
            base.Visit(shaderMethod);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderParameterDeclarations shaderParameterDeclarations)
        {
            base.Visit(shaderParameterDeclarations);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ShaderExpressionList shaderExpressionList)
        {
            VisitNodeList(shaderExpressionList.Values);
            base.Visit(shaderExpressionList);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ValueTypeGenerics valueTypeGenerics)
        {
            VisitNode(valueTypeGenerics.Value);
            base.Visit(valueTypeGenerics);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ConditionalFlow conditionalFlow)
        {
            VisitNode(conditionalFlow.If);
            VisitNodeList(conditionalFlow.ElseIfs);
            if (conditionalFlow.Else != null)
                VisitNode(conditionalFlow.Else);
            if (conditionalFlow.Attributes != null)
                VisitNode(conditionalFlow.Attributes);
            base.Visit(conditionalFlow);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.If @if)
        {
            VisitNode(@if.Condition);
            VisitNode(@if.Body);
            base.Visit(@if);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ElseIf elseIf)
        {
            VisitNode(elseIf.Condition);
            VisitNode(elseIf.Body);
            base.Visit(elseIf);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.Else @else)
        {
            VisitNode(@else.Body);
            base.Visit(@else);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.EmptyStatement emptyStatement)
        {
            base.Visit(emptyStatement);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ExpressionStatement expressionStatement)
        {
            VisitNode(expressionStatement.Expression);
            base.Visit(expressionStatement);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.Return @return)
        {
            if (@return.Value != null)
                VisitNode(@return.Value);
            base.Visit(@return);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.VariableAssign variableAssign)
        {
            VisitNode(variableAssign.Variable);
            if (variableAssign.Value != null)
                VisitNode(variableAssign.Value);
            base.Visit(variableAssign);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.DeclaredVariableAssign declaredVariableAssign)
        {
            VisitNode(declaredVariableAssign.Variable);
            if (declaredVariableAssign.Value != null)
                VisitNode(declaredVariableAssign.Value);
            VisitNode(declaredVariableAssign.TypeName);
            if (declaredVariableAssign.ArraySizes != null)
                VisitNodeList(declaredVariableAssign.ArraySizes);
            base.Visit(declaredVariableAssign);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.Declare declare)
        {
            VisitNode(declare.TypeName);
            VisitNodeList(declare.Variables);
            base.Visit(declare);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.Assign assign)
        {
            VisitNodeList(assign.Variables);
            base.Visit(assign);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.BlockStatement blockStatement)
        {
            VisitNodeList(blockStatement.Statements);
            base.Visit(blockStatement);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.Break @break)
        {
            base.Visit(@break);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.Discard discard)
        {
            base.Visit(discard);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.Continue @continue)
        {
            base.Visit(@continue);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.ForEach forEach)
        {
            VisitNode(forEach.TypeName);
            VisitNode(forEach.Variable);
            VisitNode(forEach.Collection);
            VisitNode(forEach.Body);
            base.Visit(forEach);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.While @while)
        {
            VisitNode(@while.Condition);
            VisitNode(@while.Body);
            base.Visit(@while);
        }

        public override void Visit(Stride.Shaders.Parsing.SDSL.AST.For @for)
        {
            VisitNode(@for.Initializer);
            VisitNode(@for.Condition);
            VisitNodeList(@for.Update);
            VisitNode(@for.Body);
            if (@for.Attribute != null)
                VisitNode(@for.Attribute);
            base.Visit(@for);
        }

        public override void Visit(Stride.Shaders.Parsing.SDFX.AST.ShaderEffect shaderEffect)
        {
            VisitNode(shaderEffect.Name);
            VisitNode(shaderEffect.Block);
            base.Visit(shaderEffect);
        }

        public override void Visit(Stride.Shaders.Parsing.SDFX.AST.ShaderSourceDeclaration shaderSourceDeclaration)
        {
            VisitNode(shaderSourceDeclaration.Name);
            if (shaderSourceDeclaration.Value != null)
                VisitNode(shaderSourceDeclaration.Value);
            base.Visit(shaderSourceDeclaration);
        }

        public override void Visit(Stride.Shaders.Parsing.SDFX.AST.MixinUse mixinUse)
        {
            VisitNodeList(mixinUse.MixinName);
            base.Visit(mixinUse);
        }

        public override void Visit(Stride.Shaders.Parsing.SDFX.AST.MixinChild mixinChild)
        {
            VisitNode(mixinChild.MixinName);
            base.Visit(mixinChild);
        }

        public override void Visit(Stride.Shaders.Parsing.SDFX.AST.MixinClone mixinClone)
        {
            VisitNode(mixinClone.MixinName);
            base.Visit(mixinClone);
        }

        public override void Visit(Stride.Shaders.Parsing.SDFX.AST.MixinConst mixinConst)
        {
            base.Visit(mixinConst);
        }

        public override void Visit(Stride.Shaders.Parsing.SDFX.AST.ComposePathValue composePathValue)
        {
            base.Visit(composePathValue);
        }

        public override void Visit(Stride.Shaders.Parsing.SDFX.AST.ComposeMixinValue composeMixinValue)
        {
            VisitNode(composeMixinValue.Mixin);
            base.Visit(composeMixinValue);
        }

        public override void Visit(Stride.Shaders.Parsing.SDFX.AST.MixinCompose mixinCompose)
        {
            VisitNode(mixinCompose.Identifier);
            VisitNode(mixinCompose.ComposeValue);
            base.Visit(mixinCompose);
        }

        public override void Visit(Stride.Shaders.Parsing.SDFX.AST.MixinComposeAdd mixinComposeAdd)
        {
            VisitNode(mixinComposeAdd.Identifier);
            VisitNode(mixinComposeAdd.Source);
            base.Visit(mixinComposeAdd);
        }

        public override void Visit(Stride.Shaders.Parsing.SDFX.AST.ComposeParams composeParams)
        {
            VisitNode(composeParams.MixinName);
            base.Visit(composeParams);
        }

        public override void Visit(Stride.Shaders.Parsing.SDFX.AST.UsingParams usingParams)
        {
            VisitNode(usingParams.ParamsName);
            base.Visit(usingParams);
        }

        public override void Visit(Stride.Shaders.Parsing.SDFX.AST.EffectDiscardStatement effectDiscardStatement)
        {
            base.Visit(effectDiscardStatement);
        }

        public override void Visit(Stride.Shaders.Parsing.SDFX.AST.EffectFlow effectFlow)
        {
            base.Visit(effectFlow);
        }

        public override void Visit(Stride.Shaders.Parsing.SDFX.AST.EffectForEach effectForEach)
        {
            VisitNode(effectForEach.Typename);
            VisitNode(effectForEach.Variable);
            VisitNode(effectForEach.Collection);
            VisitNode(effectForEach.Body);
            base.Visit(effectForEach);
        }

        public override void Visit(Stride.Shaders.Parsing.SDFX.AST.EffectParameters effectParameters)
        {
            VisitNode(effectParameters.Name);
            VisitNodeList(effectParameters.Parameters);
            base.Visit(effectParameters);
        }

        public override void Visit(Stride.Shaders.Parsing.SDFX.AST.EffectParameter effectParameter)
        {
            VisitNode(effectParameter.Type);
            VisitNode(effectParameter.Identifier);
            if (effectParameter.DefaultValue != null)
                VisitNode(effectParameter.DefaultValue);
            base.Visit(effectParameter);
        }
    }
}

namespace Stride.Shaders.Parsing
{
    public partial class NoNode
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing
{
    public partial class ShaderFile
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing
{
    public partial class UsingShaderNamespace
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing
{
    public partial class ShaderNamespace
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class PreProcessableCode
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class DirectiveCode
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ObjectDefineDirective
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class FunctionDefineDirective
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class IfDirective
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class IfDefDirective
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class IfNDefDirective
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ElifDirective
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ElseDirective
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class EndIfDirective
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ConditionalDirectives
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class EmptyExpression
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class MethodCall
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class MixinAccess
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class PrefixExpression
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class CastExpression
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class IndexerExpression
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class PostfixIncrement
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class AccessorChainExpression
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class BinaryExpression
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class TernaryExpression
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class StringLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class IntegerLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class FloatLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class HexLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class BoolLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ExpressionLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class VectorLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class MatrixLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ArrayLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class Identifier
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class TypeName
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderClass
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderGenerics
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class Mixin
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderMixinExpression
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderMixinIdentifier
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderAttributeList
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class AnyShaderAttribute
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ResourceBind
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ColorType
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderVariable
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class TypeDef
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderStructMember
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderStruct
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class CBuffer
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class RGroup
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class TBuffer
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class SamplerStateParameter
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderSamplerState
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderSamplerComparisonState
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderCompose
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderMember
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class MethodParameter
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderMethod
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderParameterDeclarations
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderExpressionList
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ValueTypeGenerics
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ConditionalFlow
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class If
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ElseIf
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class Else
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class EmptyStatement
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ExpressionStatement
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class Return
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class VariableAssign
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class DeclaredVariableAssign
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class Declare
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class Assign
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class BlockStatement
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class Break
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class Discard
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class Continue
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ForEach
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class While
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class For
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class ShaderEffect
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class ShaderSourceDeclaration
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class MixinUse
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class MixinChild
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class MixinClone
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class MixinConst
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class ComposePathValue
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class ComposeMixinValue
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class MixinCompose
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class MixinComposeAdd
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class ComposeParams
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class UsingParams
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class EffectDiscardStatement
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class EffectFlow
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class EffectForEach
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class EffectParameters
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class EffectParameter
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}