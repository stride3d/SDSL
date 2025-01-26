using System.Runtime.CompilerServices;
using System.Text;
using Stride.Shaders.Core;

namespace Stride.Shaders.Parsing.SDSL.AST;

public abstract class Statement(TextLocation info) : ValueNode(info);

public class EmptyStatement(TextLocation info) : Statement(info)
{
    public override SymbolType? Type { get => Scalar.From("void"); set { } }
    public override string ToString() => ";";
}

public class ExpressionStatement(Expression expression, TextLocation info) : Statement(info)
{
    public override SymbolType? Type { get => Expression.Type; set { } }
    public Expression Expression { get; set; } = expression;
    public override string ToString()
    {
        return $"{Expression};";
    }
}

public class Return(TextLocation info, Expression? expression = null) : Statement(info)
{
    public override SymbolType? Type { get => Value?.Type ?? Scalar.From("void"); set { } }
    public Expression? Value { get; set; } = expression;

    public override string ToString()
    {
        return $"return {Value};";
    }
}

public abstract class Declaration(TypeName typename, TextLocation info) : Statement(info)
{
    public TypeName TypeName { get; set; } = typename;
}

public class VariableAssign(Expression variable, bool isConst, TextLocation info, AssignOperator? op = null, Expression? value = null) : Node(info)
{
    public Expression Variable { get; set; } = variable;
    public AssignOperator? Operator { get; set; } = op;
    public Expression? Value { get; set; } = value;
    public bool IsConst { get; set; } = isConst;

    public override string ToString()
        => Value switch
        {
            null => Variable.ToString() ?? "",
            Expression v => $"{Variable} {Operator?.ToAssignSymbol()} {v}"
        };
}
public class DeclaredVariableAssign(Identifier variable, bool isConst, TextLocation info, AssignOperator? op = null, Expression? value = null) : Node(info)
{
    public Identifier Variable { get; set; } = variable;
    public AssignOperator? Operator { get; set; } = op;
    public Expression? Value { get; set; } = value;
    public bool IsConst { get; set; } = isConst;
    public TypeName TypeName { get; set; } = new("void", info, false);
    public List<Expression>? ArraySizes
    {
        get => TypeName.ArraySize;
        set => TypeName.ArraySize = value;
    }

    internal void ReplaceTypeName(TypeName typeName)
    {
        TypeName.Type = typeName.Type;
        TypeName.Info = typeName.Info;
    }

    public override string ToString()
        => Value switch
        {
            null => Variable.ToString() ?? "",
            Expression v => $"{Variable} {Operator?.ToAssignSymbol()} {v}"
        };
}

public class Declare(TypeName typename, TextLocation info) : Declaration(typename, info)
{
    public List<DeclaredVariableAssign> Variables { get; set; } = [];

    public override string ToString()
    {
        return $"{TypeName} {string.Join(", ", Variables.Select(v => v.ToString()))}";
    }
}

public class Assign(TextLocation info) : Statement(info)
{
    public List<VariableAssign> Variables { get; set; } = [];
    public override string ToString()
    {
        return string.Join(", ", Variables.Select(x => x.ToString())) + ";";
    }
}



public class BlockStatement(TextLocation info) : Statement(info)
{
    public List<Statement> Statements { get; set; } = [];

    public override string ToString()
    {
        var builder = new StringBuilder().Append("Block : \n");
        foreach (var e in Statements)
            builder.AppendLine(e.ToString());
        return builder.AppendLine("End").ToString();
    }
}
