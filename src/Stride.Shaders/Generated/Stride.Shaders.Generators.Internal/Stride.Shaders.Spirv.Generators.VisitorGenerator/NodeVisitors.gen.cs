using Stride.Shaders.Core;

namespace Stride.Shaders.Core
{
    public partial class NodeVisitor
    {
        public virtual void VisitNoNode(Stride.Shaders.Parsing.NoNode noNode)
        {
            DefaultVisit(noNode);
        }

        public virtual void VisitShaderFile(Stride.Shaders.Parsing.ShaderFile shaderFile)
        {
            DefaultVisit(shaderFile);
        }

        public virtual void VisitUsingShaderNamespace(Stride.Shaders.Parsing.UsingShaderNamespace usingShaderNamespace)
        {
            DefaultVisit(usingShaderNamespace);
        }

        public virtual void VisitShaderNamespace(Stride.Shaders.Parsing.ShaderNamespace shaderNamespace)
        {
            DefaultVisit(shaderNamespace);
        }

        public virtual void VisitPreProcessableCode(Stride.Shaders.Parsing.SDSL.AST.PreProcessableCode preProcessableCode)
        {
            DefaultVisit(preProcessableCode);
        }

        public virtual void VisitDirectiveCode(Stride.Shaders.Parsing.SDSL.AST.DirectiveCode directiveCode)
        {
            DefaultVisit(directiveCode);
        }

        public virtual void VisitObjectDefineDirective(Stride.Shaders.Parsing.SDSL.AST.ObjectDefineDirective objectDefineDirective)
        {
            DefaultVisit(objectDefineDirective);
        }

        public virtual void VisitFunctionDefineDirective(Stride.Shaders.Parsing.SDSL.AST.FunctionDefineDirective functionDefineDirective)
        {
            DefaultVisit(functionDefineDirective);
        }

        public virtual void VisitIfDirective(Stride.Shaders.Parsing.SDSL.AST.IfDirective ifDirective)
        {
            DefaultVisit(ifDirective);
        }

        public virtual void VisitIfDefDirective(Stride.Shaders.Parsing.SDSL.AST.IfDefDirective ifDefDirective)
        {
            DefaultVisit(ifDefDirective);
        }

        public virtual void VisitIfNDefDirective(Stride.Shaders.Parsing.SDSL.AST.IfNDefDirective ifNDefDirective)
        {
            DefaultVisit(ifNDefDirective);
        }

        public virtual void VisitElifDirective(Stride.Shaders.Parsing.SDSL.AST.ElifDirective elifDirective)
        {
            DefaultVisit(elifDirective);
        }

        public virtual void VisitElseDirective(Stride.Shaders.Parsing.SDSL.AST.ElseDirective elseDirective)
        {
            DefaultVisit(elseDirective);
        }

        public virtual void VisitEndIfDirective(Stride.Shaders.Parsing.SDSL.AST.EndIfDirective endIfDirective)
        {
            DefaultVisit(endIfDirective);
        }

        public virtual void VisitConditionalDirectives(Stride.Shaders.Parsing.SDSL.AST.ConditionalDirectives conditionalDirectives)
        {
            DefaultVisit(conditionalDirectives);
        }

        public virtual void VisitEmptyExpression(Stride.Shaders.Parsing.SDSL.AST.EmptyExpression emptyExpression)
        {
            DefaultVisit(emptyExpression);
        }

        public virtual void VisitParenthesisExpression(Stride.Shaders.Parsing.SDSL.AST.ParenthesisExpression parenthesisExpression)
        {
            DefaultVisit(parenthesisExpression);
        }

        public virtual void VisitMethodCall(Stride.Shaders.Parsing.SDSL.AST.MethodCall methodCall)
        {
            DefaultVisit(methodCall);
        }

        public virtual void VisitPrefixExpression(Stride.Shaders.Parsing.SDSL.AST.PrefixExpression prefixExpression)
        {
            DefaultVisit(prefixExpression);
        }

        public virtual void VisitCastExpression(Stride.Shaders.Parsing.SDSL.AST.CastExpression castExpression)
        {
            DefaultVisit(castExpression);
        }

        public virtual void VisitIndexerExpression(Stride.Shaders.Parsing.SDSL.AST.IndexerExpression indexerExpression)
        {
            DefaultVisit(indexerExpression);
        }

        public virtual void VisitPostfixIncrement(Stride.Shaders.Parsing.SDSL.AST.PostfixIncrement postfixIncrement)
        {
            DefaultVisit(postfixIncrement);
        }

        public virtual void VisitAccessorChainExpression(Stride.Shaders.Parsing.SDSL.AST.AccessorChainExpression accessorChainExpression)
        {
            DefaultVisit(accessorChainExpression);
        }

        public virtual void VisitBinaryExpression(Stride.Shaders.Parsing.SDSL.AST.BinaryExpression binaryExpression)
        {
            DefaultVisit(binaryExpression);
        }

        public virtual void VisitTernaryExpression(Stride.Shaders.Parsing.SDSL.AST.TernaryExpression ternaryExpression)
        {
            DefaultVisit(ternaryExpression);
        }

        public virtual void VisitStringLiteral(Stride.Shaders.Parsing.SDSL.AST.StringLiteral stringLiteral)
        {
            DefaultVisit(stringLiteral);
        }

        public virtual void VisitIntegerLiteral(Stride.Shaders.Parsing.SDSL.AST.IntegerLiteral integerLiteral)
        {
            DefaultVisit(integerLiteral);
        }

        public virtual void VisitFloatLiteral(Stride.Shaders.Parsing.SDSL.AST.FloatLiteral floatLiteral)
        {
            DefaultVisit(floatLiteral);
        }

        public virtual void VisitHexLiteral(Stride.Shaders.Parsing.SDSL.AST.HexLiteral hexLiteral)
        {
            DefaultVisit(hexLiteral);
        }

        public virtual void VisitBoolLiteral(Stride.Shaders.Parsing.SDSL.AST.BoolLiteral boolLiteral)
        {
            DefaultVisit(boolLiteral);
        }

        public virtual void VisitExpressionLiteral(Stride.Shaders.Parsing.SDSL.AST.ExpressionLiteral expressionLiteral)
        {
            DefaultVisit(expressionLiteral);
        }

        public virtual void VisitVectorLiteral(Stride.Shaders.Parsing.SDSL.AST.VectorLiteral vectorLiteral)
        {
            DefaultVisit(vectorLiteral);
        }

        public virtual void VisitMatrixLiteral(Stride.Shaders.Parsing.SDSL.AST.MatrixLiteral matrixLiteral)
        {
            DefaultVisit(matrixLiteral);
        }

        public virtual void VisitArrayLiteral(Stride.Shaders.Parsing.SDSL.AST.ArrayLiteral arrayLiteral)
        {
            DefaultVisit(arrayLiteral);
        }

        public virtual void VisitIdentifier(Stride.Shaders.Parsing.SDSL.AST.Identifier identifier)
        {
            DefaultVisit(identifier);
        }

        public virtual void VisitGenericIdentifier(Stride.Shaders.Parsing.SDSL.AST.GenericIdentifier genericIdentifier)
        {
            DefaultVisit(genericIdentifier);
        }

        public virtual void VisitTypeName(Stride.Shaders.Parsing.SDSL.AST.TypeName typeName)
        {
            DefaultVisit(typeName);
        }

        public virtual void VisitShaderClass(Stride.Shaders.Parsing.SDSL.AST.ShaderClass shaderClass)
        {
            DefaultVisit(shaderClass);
        }

        public virtual void VisitShaderGenerics(Stride.Shaders.Parsing.SDSL.AST.ShaderGenerics shaderGenerics)
        {
            DefaultVisit(shaderGenerics);
        }

        public virtual void VisitShaderAttributeList(Stride.Shaders.Parsing.SDSL.AST.ShaderAttributeList shaderAttributeList)
        {
            DefaultVisit(shaderAttributeList);
        }

        public virtual void VisitAnyShaderAttribute(Stride.Shaders.Parsing.SDSL.AST.AnyShaderAttribute anyShaderAttribute)
        {
            DefaultVisit(anyShaderAttribute);
        }

        public virtual void VisitResourceBind(Stride.Shaders.Parsing.SDSL.AST.ResourceBind resourceBind)
        {
            DefaultVisit(resourceBind);
        }

        public virtual void VisitColorType(Stride.Shaders.Parsing.SDSL.AST.ColorType colorType)
        {
            DefaultVisit(colorType);
        }

        public virtual void VisitTypeDef(Stride.Shaders.Parsing.SDSL.AST.TypeDef typeDef)
        {
            DefaultVisit(typeDef);
        }

        public virtual void VisitShaderStructMember(Stride.Shaders.Parsing.SDSL.AST.ShaderStructMember shaderStructMember)
        {
            DefaultVisit(shaderStructMember);
        }

        public virtual void VisitShaderStruct(Stride.Shaders.Parsing.SDSL.AST.ShaderStruct shaderStruct)
        {
            DefaultVisit(shaderStruct);
        }

        public virtual void VisitCBuffer(Stride.Shaders.Parsing.SDSL.AST.CBuffer cBuffer)
        {
            DefaultVisit(cBuffer);
        }

        public virtual void VisitRGroup(Stride.Shaders.Parsing.SDSL.AST.RGroup rGroup)
        {
            DefaultVisit(rGroup);
        }

        public virtual void VisitTBuffer(Stride.Shaders.Parsing.SDSL.AST.TBuffer tBuffer)
        {
            DefaultVisit(tBuffer);
        }

        public virtual void VisitSamplerStateParameter(Stride.Shaders.Parsing.SDSL.AST.SamplerStateParameter samplerStateParameter)
        {
            DefaultVisit(samplerStateParameter);
        }

        public virtual void VisitShaderSamplerState(Stride.Shaders.Parsing.SDSL.AST.ShaderSamplerState shaderSamplerState)
        {
            DefaultVisit(shaderSamplerState);
        }

        public virtual void VisitShaderSamplerComparisonState(Stride.Shaders.Parsing.SDSL.AST.ShaderSamplerComparisonState shaderSamplerComparisonState)
        {
            DefaultVisit(shaderSamplerComparisonState);
        }

        public virtual void VisitShaderCompose(Stride.Shaders.Parsing.SDSL.AST.ShaderCompose shaderCompose)
        {
            DefaultVisit(shaderCompose);
        }

        public virtual void VisitShaderMember(Stride.Shaders.Parsing.SDSL.AST.ShaderMember shaderMember)
        {
            DefaultVisit(shaderMember);
        }

        public virtual void VisitMethodParameter(Stride.Shaders.Parsing.SDSL.AST.MethodParameter methodParameter)
        {
            DefaultVisit(methodParameter);
        }

        public virtual void VisitShaderMethod(Stride.Shaders.Parsing.SDSL.AST.ShaderMethod shaderMethod)
        {
            DefaultVisit(shaderMethod);
        }

        public virtual void VisitShaderParameterDeclarations(Stride.Shaders.Parsing.SDSL.AST.ShaderParameterDeclarations shaderParameterDeclarations)
        {
            DefaultVisit(shaderParameterDeclarations);
        }

        public virtual void VisitShaderExpressionList(Stride.Shaders.Parsing.SDSL.AST.ShaderExpressionList shaderExpressionList)
        {
            DefaultVisit(shaderExpressionList);
        }

        public virtual void VisitValueTypeGenerics(Stride.Shaders.Parsing.SDSL.AST.ValueTypeGenerics valueTypeGenerics)
        {
            DefaultVisit(valueTypeGenerics);
        }

        public virtual void VisitConditionalFlow(Stride.Shaders.Parsing.SDSL.AST.ConditionalFlow conditionalFlow)
        {
            DefaultVisit(conditionalFlow);
        }

        public virtual void VisitIf(Stride.Shaders.Parsing.SDSL.AST.If @if)
        {
            DefaultVisit(@if);
        }

        public virtual void VisitElseIf(Stride.Shaders.Parsing.SDSL.AST.ElseIf elseIf)
        {
            DefaultVisit(elseIf);
        }

        public virtual void VisitElse(Stride.Shaders.Parsing.SDSL.AST.Else @else)
        {
            DefaultVisit(@else);
        }

        public virtual void VisitEmptyStatement(Stride.Shaders.Parsing.SDSL.AST.EmptyStatement emptyStatement)
        {
            DefaultVisit(emptyStatement);
        }

        public virtual void VisitExpressionStatement(Stride.Shaders.Parsing.SDSL.AST.ExpressionStatement expressionStatement)
        {
            DefaultVisit(expressionStatement);
        }

        public virtual void VisitReturn(Stride.Shaders.Parsing.SDSL.AST.Return @return)
        {
            DefaultVisit(@return);
        }

        public virtual void VisitVariableAssign(Stride.Shaders.Parsing.SDSL.AST.VariableAssign variableAssign)
        {
            DefaultVisit(variableAssign);
        }

        public virtual void VisitDeclaredVariableAssign(Stride.Shaders.Parsing.SDSL.AST.DeclaredVariableAssign declaredVariableAssign)
        {
            DefaultVisit(declaredVariableAssign);
        }

        public virtual void VisitDeclare(Stride.Shaders.Parsing.SDSL.AST.Declare declare)
        {
            DefaultVisit(declare);
        }

        public virtual void VisitAssign(Stride.Shaders.Parsing.SDSL.AST.Assign assign)
        {
            DefaultVisit(assign);
        }

        public virtual void VisitBlockStatement(Stride.Shaders.Parsing.SDSL.AST.BlockStatement blockStatement)
        {
            DefaultVisit(blockStatement);
        }

        public virtual void VisitBreak(Stride.Shaders.Parsing.SDSL.AST.Break @break)
        {
            DefaultVisit(@break);
        }

        public virtual void VisitDiscard(Stride.Shaders.Parsing.SDSL.AST.Discard discard)
        {
            DefaultVisit(discard);
        }

        public virtual void VisitContinue(Stride.Shaders.Parsing.SDSL.AST.Continue @continue)
        {
            DefaultVisit(@continue);
        }

        public virtual void VisitForEach(Stride.Shaders.Parsing.SDSL.AST.ForEach forEach)
        {
            DefaultVisit(forEach);
        }

        public virtual void VisitWhile(Stride.Shaders.Parsing.SDSL.AST.While @while)
        {
            DefaultVisit(@while);
        }

        public virtual void VisitFor(Stride.Shaders.Parsing.SDSL.AST.For @for)
        {
            DefaultVisit(@for);
        }

        public virtual void VisitShaderEffect(Stride.Shaders.Parsing.SDFX.AST.ShaderEffect shaderEffect)
        {
            DefaultVisit(shaderEffect);
        }

        public virtual void VisitShaderSourceDeclaration(Stride.Shaders.Parsing.SDFX.AST.ShaderSourceDeclaration shaderSourceDeclaration)
        {
            DefaultVisit(shaderSourceDeclaration);
        }

        public virtual void VisitUsingParams(Stride.Shaders.Parsing.SDFX.AST.UsingParams usingParams)
        {
            DefaultVisit(usingParams);
        }

        public virtual void VisitEffectDiscardStatement(Stride.Shaders.Parsing.SDFX.AST.EffectDiscardStatement effectDiscardStatement)
        {
            DefaultVisit(effectDiscardStatement);
        }

        public virtual void VisitMixin(Stride.Shaders.Parsing.SDFX.AST.Mixin mixin)
        {
            DefaultVisit(mixin);
        }

        public virtual void VisitEffectFlow(Stride.Shaders.Parsing.SDFX.AST.EffectFlow effectFlow)
        {
            DefaultVisit(effectFlow);
        }

        public virtual void VisitEffectForEach(Stride.Shaders.Parsing.SDFX.AST.EffectForEach effectForEach)
        {
            DefaultVisit(effectForEach);
        }

        public virtual void VisitEffectParameters(Stride.Shaders.Parsing.SDFX.AST.EffectParameters effectParameters)
        {
            DefaultVisit(effectParameters);
        }

        public virtual void VisitEffectParameter(Stride.Shaders.Parsing.SDFX.AST.EffectParameter effectParameter)
        {
            DefaultVisit(effectParameter);
        }
    }

    public partial class NodeWalker
    {
        public override void VisitNoNode(Stride.Shaders.Parsing.NoNode noNode)
        {
            base.VisitNoNode(noNode);
        }

        public override void VisitShaderFile(Stride.Shaders.Parsing.ShaderFile shaderFile)
        {
            VisitNodeList(shaderFile.RootDeclarations);
            VisitNodeList(shaderFile.Namespaces);
            base.VisitShaderFile(shaderFile);
        }

        public override void VisitUsingShaderNamespace(Stride.Shaders.Parsing.UsingShaderNamespace usingShaderNamespace)
        {
            VisitNodeList(usingShaderNamespace.NamespacePath);
            base.VisitUsingShaderNamespace(usingShaderNamespace);
        }

        public override void VisitShaderNamespace(Stride.Shaders.Parsing.ShaderNamespace shaderNamespace)
        {
            VisitNodeList(shaderNamespace.NamespacePath);
            if (shaderNamespace.Namespace != null)
                VisitNode(shaderNamespace.Namespace);
            VisitNodeList(shaderNamespace.Declarations);
            base.VisitShaderNamespace(shaderNamespace);
        }

        public override void VisitPreProcessableCode(Stride.Shaders.Parsing.SDSL.AST.PreProcessableCode preProcessableCode)
        {
            VisitNodeList(preProcessableCode.Snippets);
            base.VisitPreProcessableCode(preProcessableCode);
        }

        public override void VisitDirectiveCode(Stride.Shaders.Parsing.SDSL.AST.DirectiveCode directiveCode)
        {
            base.VisitDirectiveCode(directiveCode);
        }

        public override void VisitObjectDefineDirective(Stride.Shaders.Parsing.SDSL.AST.ObjectDefineDirective objectDefineDirective)
        {
            VisitNode(objectDefineDirective.Identifier);
            if (objectDefineDirective.Expression != null)
                VisitNode(objectDefineDirective.Expression);
            base.VisitObjectDefineDirective(objectDefineDirective);
        }

        public override void VisitFunctionDefineDirective(Stride.Shaders.Parsing.SDSL.AST.FunctionDefineDirective functionDefineDirective)
        {
            VisitNode(functionDefineDirective.FunctionName);
            VisitNodeList(functionDefineDirective.Parameters);
            base.VisitFunctionDefineDirective(functionDefineDirective);
        }

        public override void VisitIfDirective(Stride.Shaders.Parsing.SDSL.AST.IfDirective ifDirective)
        {
            if (ifDirective.Expression != null)
                VisitNode(ifDirective.Expression);
            if (ifDirective.Code != null)
                VisitNode(ifDirective.Code);
            base.VisitIfDirective(ifDirective);
        }

        public override void VisitIfDefDirective(Stride.Shaders.Parsing.SDSL.AST.IfDefDirective ifDefDirective)
        {
            if (ifDefDirective.Expression != null)
                VisitNode(ifDefDirective.Expression);
            if (ifDefDirective.Code != null)
                VisitNode(ifDefDirective.Code);
            base.VisitIfDefDirective(ifDefDirective);
        }

        public override void VisitIfNDefDirective(Stride.Shaders.Parsing.SDSL.AST.IfNDefDirective ifNDefDirective)
        {
            if (ifNDefDirective.Expression != null)
                VisitNode(ifNDefDirective.Expression);
            if (ifNDefDirective.Code != null)
                VisitNode(ifNDefDirective.Code);
            base.VisitIfNDefDirective(ifNDefDirective);
        }

        public override void VisitElifDirective(Stride.Shaders.Parsing.SDSL.AST.ElifDirective elifDirective)
        {
            if (elifDirective.Expression != null)
                VisitNode(elifDirective.Expression);
            if (elifDirective.Code != null)
                VisitNode(elifDirective.Code);
            base.VisitElifDirective(elifDirective);
        }

        public override void VisitElseDirective(Stride.Shaders.Parsing.SDSL.AST.ElseDirective elseDirective)
        {
            if (elseDirective.Expression != null)
                VisitNode(elseDirective.Expression);
            if (elseDirective.Code != null)
                VisitNode(elseDirective.Code);
            base.VisitElseDirective(elseDirective);
        }

        public override void VisitEndIfDirective(Stride.Shaders.Parsing.SDSL.AST.EndIfDirective endIfDirective)
        {
            if (endIfDirective.Expression != null)
                VisitNode(endIfDirective.Expression);
            if (endIfDirective.Code != null)
                VisitNode(endIfDirective.Code);
            base.VisitEndIfDirective(endIfDirective);
        }

        public override void VisitConditionalDirectives(Stride.Shaders.Parsing.SDSL.AST.ConditionalDirectives conditionalDirectives)
        {
            VisitNode(conditionalDirectives.If);
            VisitNodeList(conditionalDirectives.Elifs);
            if (conditionalDirectives.Else != null)
                VisitNode(conditionalDirectives.Else);
            base.VisitConditionalDirectives(conditionalDirectives);
        }

        public override void VisitEmptyExpression(Stride.Shaders.Parsing.SDSL.AST.EmptyExpression emptyExpression)
        {
            base.VisitEmptyExpression(emptyExpression);
        }

        public override void VisitParenthesisExpression(Stride.Shaders.Parsing.SDSL.AST.ParenthesisExpression parenthesisExpression)
        {
            VisitNode(parenthesisExpression.Expression);
            base.VisitParenthesisExpression(parenthesisExpression);
        }

        public override void VisitMethodCall(Stride.Shaders.Parsing.SDSL.AST.MethodCall methodCall)
        {
            VisitNode(methodCall.Name);
            VisitNode(methodCall.Arguments);
            base.VisitMethodCall(methodCall);
        }

        public override void VisitPrefixExpression(Stride.Shaders.Parsing.SDSL.AST.PrefixExpression prefixExpression)
        {
            VisitNode(prefixExpression.Expression);
            base.VisitPrefixExpression(prefixExpression);
        }

        public override void VisitCastExpression(Stride.Shaders.Parsing.SDSL.AST.CastExpression castExpression)
        {
            VisitNode(castExpression.Expression);
            VisitNode(castExpression.TypeName);
            base.VisitCastExpression(castExpression);
        }

        public override void VisitIndexerExpression(Stride.Shaders.Parsing.SDSL.AST.IndexerExpression indexerExpression)
        {
            VisitNode(indexerExpression.Index);
            base.VisitIndexerExpression(indexerExpression);
        }

        public override void VisitPostfixIncrement(Stride.Shaders.Parsing.SDSL.AST.PostfixIncrement postfixIncrement)
        {
            base.VisitPostfixIncrement(postfixIncrement);
        }

        public override void VisitAccessorChainExpression(Stride.Shaders.Parsing.SDSL.AST.AccessorChainExpression accessorChainExpression)
        {
            VisitNode(accessorChainExpression.Source);
            VisitNodeList(accessorChainExpression.Accessors);
            base.VisitAccessorChainExpression(accessorChainExpression);
        }

        public override void VisitBinaryExpression(Stride.Shaders.Parsing.SDSL.AST.BinaryExpression binaryExpression)
        {
            VisitNode(binaryExpression.Left);
            VisitNode(binaryExpression.Right);
            base.VisitBinaryExpression(binaryExpression);
        }

        public override void VisitTernaryExpression(Stride.Shaders.Parsing.SDSL.AST.TernaryExpression ternaryExpression)
        {
            VisitNode(ternaryExpression.Condition);
            VisitNode(ternaryExpression.Left);
            VisitNode(ternaryExpression.Right);
            base.VisitTernaryExpression(ternaryExpression);
        }

        public override void VisitStringLiteral(Stride.Shaders.Parsing.SDSL.AST.StringLiteral stringLiteral)
        {
            base.VisitStringLiteral(stringLiteral);
        }

        public override void VisitIntegerLiteral(Stride.Shaders.Parsing.SDSL.AST.IntegerLiteral integerLiteral)
        {
            base.VisitIntegerLiteral(integerLiteral);
        }

        public override void VisitFloatLiteral(Stride.Shaders.Parsing.SDSL.AST.FloatLiteral floatLiteral)
        {
            base.VisitFloatLiteral(floatLiteral);
        }

        public override void VisitHexLiteral(Stride.Shaders.Parsing.SDSL.AST.HexLiteral hexLiteral)
        {
            base.VisitHexLiteral(hexLiteral);
        }

        public override void VisitBoolLiteral(Stride.Shaders.Parsing.SDSL.AST.BoolLiteral boolLiteral)
        {
            base.VisitBoolLiteral(boolLiteral);
        }

        public override void VisitExpressionLiteral(Stride.Shaders.Parsing.SDSL.AST.ExpressionLiteral expressionLiteral)
        {
            VisitNode(expressionLiteral.Value);
            VisitNode(expressionLiteral.TypeName);
            base.VisitExpressionLiteral(expressionLiteral);
        }

        public override void VisitVectorLiteral(Stride.Shaders.Parsing.SDSL.AST.VectorLiteral vectorLiteral)
        {
            VisitNodeList(vectorLiteral.Values);
            VisitNode(vectorLiteral.TypeName);
            base.VisitVectorLiteral(vectorLiteral);
        }

        public override void VisitMatrixLiteral(Stride.Shaders.Parsing.SDSL.AST.MatrixLiteral matrixLiteral)
        {
            VisitNodeList(matrixLiteral.Values);
            VisitNode(matrixLiteral.TypeName);
            base.VisitMatrixLiteral(matrixLiteral);
        }

        public override void VisitArrayLiteral(Stride.Shaders.Parsing.SDSL.AST.ArrayLiteral arrayLiteral)
        {
            VisitNodeList(arrayLiteral.Values);
            base.VisitArrayLiteral(arrayLiteral);
        }

        public override void VisitIdentifier(Stride.Shaders.Parsing.SDSL.AST.Identifier identifier)
        {
            base.VisitIdentifier(identifier);
        }

        public override void VisitGenericIdentifier(Stride.Shaders.Parsing.SDSL.AST.GenericIdentifier genericIdentifier)
        {
            base.VisitGenericIdentifier(genericIdentifier);
        }

        public override void VisitTypeName(Stride.Shaders.Parsing.SDSL.AST.TypeName typeName)
        {
            if (typeName.ArraySize != null)
                VisitNodeList(typeName.ArraySize);
            VisitNodeList(typeName.Generics);
            base.VisitTypeName(typeName);
        }

        public override void VisitShaderClass(Stride.Shaders.Parsing.SDSL.AST.ShaderClass shaderClass)
        {
            VisitNode(shaderClass.Name);
            VisitNodeList(shaderClass.Elements);
            if (shaderClass.Generics != null)
                VisitNode(shaderClass.Generics);
            VisitNodeList(shaderClass.Mixins);
            base.VisitShaderClass(shaderClass);
        }

        public override void VisitShaderGenerics(Stride.Shaders.Parsing.SDSL.AST.ShaderGenerics shaderGenerics)
        {
            VisitNode(shaderGenerics.Name);
            VisitNode(shaderGenerics.TypeName);
            base.VisitShaderGenerics(shaderGenerics);
        }

        public override void VisitShaderAttributeList(Stride.Shaders.Parsing.SDSL.AST.ShaderAttributeList shaderAttributeList)
        {
            base.VisitShaderAttributeList(shaderAttributeList);
        }

        public override void VisitAnyShaderAttribute(Stride.Shaders.Parsing.SDSL.AST.AnyShaderAttribute anyShaderAttribute)
        {
            VisitNode(anyShaderAttribute.Name);
            base.VisitAnyShaderAttribute(anyShaderAttribute);
        }

        public override void VisitResourceBind(Stride.Shaders.Parsing.SDSL.AST.ResourceBind resourceBind)
        {
            base.VisitResourceBind(resourceBind);
        }

        public override void VisitColorType(Stride.Shaders.Parsing.SDSL.AST.ColorType colorType)
        {
            base.VisitColorType(colorType);
        }

        public override void VisitTypeDef(Stride.Shaders.Parsing.SDSL.AST.TypeDef typeDef)
        {
            VisitNode(typeDef.Name);
            VisitNode(typeDef.TypeName);
            base.VisitTypeDef(typeDef);
        }

        public override void VisitShaderStructMember(Stride.Shaders.Parsing.SDSL.AST.ShaderStructMember shaderStructMember)
        {
            VisitNode(shaderStructMember.TypeName);
            VisitNode(shaderStructMember.Name);
            VisitNodeList(shaderStructMember.Attributes);
            base.VisitShaderStructMember(shaderStructMember);
        }

        public override void VisitShaderStruct(Stride.Shaders.Parsing.SDSL.AST.ShaderStruct shaderStruct)
        {
            VisitNode(shaderStruct.TypeName);
            VisitNodeList(shaderStruct.Members);
            base.VisitShaderStruct(shaderStruct);
        }

        public override void VisitCBuffer(Stride.Shaders.Parsing.SDSL.AST.CBuffer cBuffer)
        {
            VisitNodeList(cBuffer.Members);
            base.VisitCBuffer(cBuffer);
        }

        public override void VisitRGroup(Stride.Shaders.Parsing.SDSL.AST.RGroup rGroup)
        {
            VisitNodeList(rGroup.Members);
            base.VisitRGroup(rGroup);
        }

        public override void VisitTBuffer(Stride.Shaders.Parsing.SDSL.AST.TBuffer tBuffer)
        {
            VisitNodeList(tBuffer.Members);
            base.VisitTBuffer(tBuffer);
        }

        public override void VisitSamplerStateParameter(Stride.Shaders.Parsing.SDSL.AST.SamplerStateParameter samplerStateParameter)
        {
            VisitNode(samplerStateParameter.Name);
            VisitNode(samplerStateParameter.Value);
            base.VisitSamplerStateParameter(samplerStateParameter);
        }

        public override void VisitShaderSamplerState(Stride.Shaders.Parsing.SDSL.AST.ShaderSamplerState shaderSamplerState)
        {
            if (shaderSamplerState.Attributes != null)
                VisitNodeList(shaderSamplerState.Attributes);
            VisitNode(shaderSamplerState.Name);
            VisitNodeList(shaderSamplerState.Parameters);
            base.VisitShaderSamplerState(shaderSamplerState);
        }

        public override void VisitShaderSamplerComparisonState(Stride.Shaders.Parsing.SDSL.AST.ShaderSamplerComparisonState shaderSamplerComparisonState)
        {
            if (shaderSamplerComparisonState.Attributes != null)
                VisitNodeList(shaderSamplerComparisonState.Attributes);
            VisitNode(shaderSamplerComparisonState.Name);
            VisitNodeList(shaderSamplerComparisonState.Parameters);
            base.VisitShaderSamplerComparisonState(shaderSamplerComparisonState);
        }

        public override void VisitShaderCompose(Stride.Shaders.Parsing.SDSL.AST.ShaderCompose shaderCompose)
        {
            if (shaderCompose.Attributes != null)
                VisitNodeList(shaderCompose.Attributes);
            VisitNode(shaderCompose.Name);
            VisitNode(shaderCompose.Shader);
            base.VisitShaderCompose(shaderCompose);
        }

        public override void VisitShaderMember(Stride.Shaders.Parsing.SDSL.AST.ShaderMember shaderMember)
        {
            if (shaderMember.Attributes != null)
                VisitNodeList(shaderMember.Attributes);
            VisitNode(shaderMember.Name);
            VisitNode(shaderMember.TypeName);
            if (shaderMember.Semantic != null)
                VisitNode(shaderMember.Semantic);
            if (shaderMember.Value != null)
                VisitNode(shaderMember.Value);
            base.VisitShaderMember(shaderMember);
        }

        public override void VisitMethodParameter(Stride.Shaders.Parsing.SDSL.AST.MethodParameter methodParameter)
        {
            VisitNode(methodParameter.TypeName);
            VisitNode(methodParameter.Name);
            if (methodParameter.Semantic != null)
                VisitNode(methodParameter.Semantic);
            if (methodParameter.DefaultValue != null)
                VisitNode(methodParameter.DefaultValue);
            base.VisitMethodParameter(methodParameter);
        }

        public override void VisitShaderMethod(Stride.Shaders.Parsing.SDSL.AST.ShaderMethod shaderMethod)
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
            base.VisitShaderMethod(shaderMethod);
        }

        public override void VisitShaderParameterDeclarations(Stride.Shaders.Parsing.SDSL.AST.ShaderParameterDeclarations shaderParameterDeclarations)
        {
            base.VisitShaderParameterDeclarations(shaderParameterDeclarations);
        }

        public override void VisitShaderExpressionList(Stride.Shaders.Parsing.SDSL.AST.ShaderExpressionList shaderExpressionList)
        {
            VisitNodeList(shaderExpressionList.Values);
            base.VisitShaderExpressionList(shaderExpressionList);
        }

        public override void VisitValueTypeGenerics(Stride.Shaders.Parsing.SDSL.AST.ValueTypeGenerics valueTypeGenerics)
        {
            VisitNode(valueTypeGenerics.Value);
            base.VisitValueTypeGenerics(valueTypeGenerics);
        }

        public override void VisitConditionalFlow(Stride.Shaders.Parsing.SDSL.AST.ConditionalFlow conditionalFlow)
        {
            VisitNode(conditionalFlow.If);
            VisitNodeList(conditionalFlow.ElseIfs);
            if (conditionalFlow.Else != null)
                VisitNode(conditionalFlow.Else);
            if (conditionalFlow.Attributes != null)
                VisitNode(conditionalFlow.Attributes);
            base.VisitConditionalFlow(conditionalFlow);
        }

        public override void VisitIf(Stride.Shaders.Parsing.SDSL.AST.If @if)
        {
            VisitNode(@if.Condition);
            VisitNode(@if.Body);
            base.VisitIf(@if);
        }

        public override void VisitElseIf(Stride.Shaders.Parsing.SDSL.AST.ElseIf elseIf)
        {
            VisitNode(elseIf.Condition);
            VisitNode(elseIf.Body);
            base.VisitElseIf(elseIf);
        }

        public override void VisitElse(Stride.Shaders.Parsing.SDSL.AST.Else @else)
        {
            VisitNode(@else.Body);
            base.VisitElse(@else);
        }

        public override void VisitEmptyStatement(Stride.Shaders.Parsing.SDSL.AST.EmptyStatement emptyStatement)
        {
            base.VisitEmptyStatement(emptyStatement);
        }

        public override void VisitExpressionStatement(Stride.Shaders.Parsing.SDSL.AST.ExpressionStatement expressionStatement)
        {
            VisitNode(expressionStatement.Expression);
            base.VisitExpressionStatement(expressionStatement);
        }

        public override void VisitReturn(Stride.Shaders.Parsing.SDSL.AST.Return @return)
        {
            if (@return.Value != null)
                VisitNode(@return.Value);
            base.VisitReturn(@return);
        }

        public override void VisitVariableAssign(Stride.Shaders.Parsing.SDSL.AST.VariableAssign variableAssign)
        {
            VisitNode(variableAssign.Variable);
            if (variableAssign.Value != null)
                VisitNode(variableAssign.Value);
            base.VisitVariableAssign(variableAssign);
        }

        public override void VisitDeclaredVariableAssign(Stride.Shaders.Parsing.SDSL.AST.DeclaredVariableAssign declaredVariableAssign)
        {
            VisitNode(declaredVariableAssign.Variable);
            if (declaredVariableAssign.Value != null)
                VisitNode(declaredVariableAssign.Value);
            VisitNode(declaredVariableAssign.TypeName);
            if (declaredVariableAssign.ArraySizes != null)
                VisitNodeList(declaredVariableAssign.ArraySizes);
            base.VisitDeclaredVariableAssign(declaredVariableAssign);
        }

        public override void VisitDeclare(Stride.Shaders.Parsing.SDSL.AST.Declare declare)
        {
            VisitNode(declare.TypeName);
            VisitNodeList(declare.Variables);
            base.VisitDeclare(declare);
        }

        public override void VisitAssign(Stride.Shaders.Parsing.SDSL.AST.Assign assign)
        {
            VisitNodeList(assign.Variables);
            base.VisitAssign(assign);
        }

        public override void VisitBlockStatement(Stride.Shaders.Parsing.SDSL.AST.BlockStatement blockStatement)
        {
            VisitNodeList(blockStatement.Statements);
            base.VisitBlockStatement(blockStatement);
        }

        public override void VisitBreak(Stride.Shaders.Parsing.SDSL.AST.Break @break)
        {
            base.VisitBreak(@break);
        }

        public override void VisitDiscard(Stride.Shaders.Parsing.SDSL.AST.Discard discard)
        {
            base.VisitDiscard(discard);
        }

        public override void VisitContinue(Stride.Shaders.Parsing.SDSL.AST.Continue @continue)
        {
            base.VisitContinue(@continue);
        }

        public override void VisitForEach(Stride.Shaders.Parsing.SDSL.AST.ForEach forEach)
        {
            VisitNode(forEach.TypeName);
            VisitNode(forEach.Variable);
            VisitNode(forEach.Collection);
            VisitNode(forEach.Body);
            base.VisitForEach(forEach);
        }

        public override void VisitWhile(Stride.Shaders.Parsing.SDSL.AST.While @while)
        {
            VisitNode(@while.Condition);
            VisitNode(@while.Body);
            base.VisitWhile(@while);
        }

        public override void VisitFor(Stride.Shaders.Parsing.SDSL.AST.For @for)
        {
            VisitNode(@for.Initializer);
            VisitNode(@for.Condition);
            VisitNodeList(@for.Update);
            VisitNode(@for.Body);
            if (@for.Attribute != null)
                VisitNode(@for.Attribute);
            base.VisitFor(@for);
        }

        public override void VisitShaderEffect(Stride.Shaders.Parsing.SDFX.AST.ShaderEffect shaderEffect)
        {
            VisitNode(shaderEffect.Name);
            VisitNode(shaderEffect.Block);
            base.VisitShaderEffect(shaderEffect);
        }

        public override void VisitShaderSourceDeclaration(Stride.Shaders.Parsing.SDFX.AST.ShaderSourceDeclaration shaderSourceDeclaration)
        {
            VisitNode(shaderSourceDeclaration.Name);
            if (shaderSourceDeclaration.Value != null)
                VisitNode(shaderSourceDeclaration.Value);
            base.VisitShaderSourceDeclaration(shaderSourceDeclaration);
        }

        public override void VisitUsingParams(Stride.Shaders.Parsing.SDFX.AST.UsingParams usingParams)
        {
            VisitNode(usingParams.ParamsName);
            base.VisitUsingParams(usingParams);
        }

        public override void VisitEffectDiscardStatement(Stride.Shaders.Parsing.SDFX.AST.EffectDiscardStatement effectDiscardStatement)
        {
            base.VisitEffectDiscardStatement(effectDiscardStatement);
        }

        public override void VisitMixin(Stride.Shaders.Parsing.SDFX.AST.Mixin mixin)
        {
            base.VisitMixin(mixin);
        }

        public override void VisitEffectFlow(Stride.Shaders.Parsing.SDFX.AST.EffectFlow effectFlow)
        {
            base.VisitEffectFlow(effectFlow);
        }

        public override void VisitEffectForEach(Stride.Shaders.Parsing.SDFX.AST.EffectForEach effectForEach)
        {
            VisitNode(effectForEach.Typename);
            VisitNode(effectForEach.Variable);
            VisitNode(effectForEach.Collection);
            VisitNode(effectForEach.Body);
            base.VisitEffectForEach(effectForEach);
        }

        public override void VisitEffectParameters(Stride.Shaders.Parsing.SDFX.AST.EffectParameters effectParameters)
        {
            VisitNode(effectParameters.Name);
            VisitNodeList(effectParameters.Parameters);
            base.VisitEffectParameters(effectParameters);
        }

        public override void VisitEffectParameter(Stride.Shaders.Parsing.SDFX.AST.EffectParameter effectParameter)
        {
            VisitNode(effectParameter.Type);
            VisitNode(effectParameter.Identifier);
            if (effectParameter.DefaultValue != null)
                VisitNode(effectParameter.DefaultValue);
            base.VisitEffectParameter(effectParameter);
        }
    }
}

namespace Stride.Shaders.Parsing
{
    public partial class NoNode
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitNoNode(this);
        }
    }
}

namespace Stride.Shaders.Parsing
{
    public partial class ShaderFile
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitShaderFile(this);
        }
    }
}

namespace Stride.Shaders.Parsing
{
    public partial class UsingShaderNamespace
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitUsingShaderNamespace(this);
        }
    }
}

namespace Stride.Shaders.Parsing
{
    public partial class ShaderNamespace
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitShaderNamespace(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class PreProcessableCode
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitPreProcessableCode(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class DirectiveCode
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitDirectiveCode(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ObjectDefineDirective
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitObjectDefineDirective(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class FunctionDefineDirective
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitFunctionDefineDirective(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class IfDirective
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitIfDirective(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class IfDefDirective
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitIfDefDirective(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class IfNDefDirective
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitIfNDefDirective(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ElifDirective
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitElifDirective(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ElseDirective
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitElseDirective(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class EndIfDirective
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitEndIfDirective(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ConditionalDirectives
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitConditionalDirectives(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class EmptyExpression
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitEmptyExpression(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ParenthesisExpression
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitParenthesisExpression(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class MethodCall
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitMethodCall(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class PrefixExpression
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitPrefixExpression(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class CastExpression
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitCastExpression(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class IndexerExpression
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitIndexerExpression(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class PostfixIncrement
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitPostfixIncrement(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class AccessorChainExpression
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitAccessorChainExpression(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class BinaryExpression
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitBinaryExpression(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class TernaryExpression
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitTernaryExpression(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class StringLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitStringLiteral(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class IntegerLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitIntegerLiteral(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class FloatLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitFloatLiteral(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class HexLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitHexLiteral(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class BoolLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitBoolLiteral(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ExpressionLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitExpressionLiteral(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class VectorLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitVectorLiteral(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class MatrixLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitMatrixLiteral(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ArrayLiteral
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitArrayLiteral(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class Identifier
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitIdentifier(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class GenericIdentifier
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitGenericIdentifier(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class TypeName
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitTypeName(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderClass
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitShaderClass(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderGenerics
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitShaderGenerics(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderAttributeList
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitShaderAttributeList(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class AnyShaderAttribute
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitAnyShaderAttribute(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ResourceBind
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitResourceBind(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ColorType
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitColorType(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class TypeDef
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitTypeDef(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderStructMember
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitShaderStructMember(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderStruct
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitShaderStruct(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class CBuffer
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitCBuffer(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class RGroup
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitRGroup(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class TBuffer
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitTBuffer(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class SamplerStateParameter
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitSamplerStateParameter(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderSamplerState
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitShaderSamplerState(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderSamplerComparisonState
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitShaderSamplerComparisonState(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderCompose
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitShaderCompose(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderMember
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitShaderMember(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class MethodParameter
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitMethodParameter(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderMethod
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitShaderMethod(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderParameterDeclarations
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitShaderParameterDeclarations(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ShaderExpressionList
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitShaderExpressionList(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ValueTypeGenerics
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitValueTypeGenerics(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ConditionalFlow
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitConditionalFlow(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class If
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitIf(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ElseIf
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitElseIf(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class Else
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitElse(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class EmptyStatement
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitEmptyStatement(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ExpressionStatement
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitExpressionStatement(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class Return
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitReturn(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class VariableAssign
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitVariableAssign(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class DeclaredVariableAssign
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitDeclaredVariableAssign(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class Declare
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitDeclare(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class Assign
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitAssign(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class BlockStatement
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitBlockStatement(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class Break
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitBreak(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class Discard
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitDiscard(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class Continue
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitContinue(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class ForEach
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitForEach(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class While
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitWhile(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDSL.AST
{
    public partial class For
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitFor(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class ShaderEffect
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitShaderEffect(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class ShaderSourceDeclaration
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitShaderSourceDeclaration(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class UsingParams
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitUsingParams(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class EffectDiscardStatement
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitEffectDiscardStatement(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class Mixin
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitMixin(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class EffectFlow
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitEffectFlow(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class EffectForEach
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitEffectForEach(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class EffectParameters
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitEffectParameters(this);
        }
    }
}

namespace Stride.Shaders.Parsing.SDFX.AST
{
    public partial class EffectParameter
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitEffectParameter(this);
        }
    }
}