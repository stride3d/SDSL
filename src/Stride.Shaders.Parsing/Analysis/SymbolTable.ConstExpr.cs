using Stride.Shaders.Core;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.Analysis;

public partial class SymbolTable
{
    public bool IsConstantExpression(Expression expression)
    {
        if(expression is TernaryExpression tern)
            return IsConstantExpression(tern.Condition) && IsConstantExpression(tern.Left) && IsConstantExpression(tern.Right);
        else if(expression is BinaryExpression bin)
            return IsConstantExpression(bin.Left) && IsConstantExpression(bin.Right);
        else if(expression is Identifier identifier)
            return TryFind(identifier, SymbolKind.Constant, out _);
        else if(expression is NumberLiteral || expression is BoolLiteral)
            return true;
        else return false;
    }
}