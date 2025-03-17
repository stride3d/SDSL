using Stride.Shaders.Core;
using Stride.Shaders.Parsing.Analysis;

namespace Stride.Shaders.Parsing.SDSL.AST;


public abstract class Control(TextLocation info) : Flow(info);


public class ConditionalFlow(If first, TextLocation info) : Flow(info)
{
    public If If { get; set; } = first;
    public List<ElseIf> ElseIfs { get; set; } = [];
    public Else? Else { get; set; }
    public ShaderAttributeList? Attributes { get; set; }

    public override void ProcessSymbol(SymbolTable table, EntryPoint? entrypoint, StreamIO? io)
    {
        If.ProcessSymbol(table, entrypoint, io);
        foreach (var ei in ElseIfs)
            ei.ProcessSymbol(table, entrypoint, io);
        Else?.ProcessSymbol(table, entrypoint, io);

    }

    public override string ToString()
    {
        return $"{If}{string.Join("\n", ElseIfs.Select(x => x.ToString()))}{Else}";
    }
}
public class If(Expression condition, Statement body, TextLocation info) : Flow(info)
{
    public Expression Condition { get; set; } = condition;
    public Statement Body { get; set; } = body;

    public override void ProcessSymbol(SymbolTable table, EntryPoint? entrypoint, StreamIO? io)
    {
        Condition.ProcessSymbol(table, entrypoint, io);
        Body.ProcessSymbol(table, entrypoint, io);
        if(Condition.Type != ScalarSymbol.From("bool"))
            table.Errors.Add(new(Condition.Info, "not a boolean"));
    }

    public override string ToString()
    {
        return $"if({Condition})\n{Body}";
    }
}

public class ElseIf(Expression condition, Statement body, TextLocation info) : If(condition, body, info)
{
    public override void ProcessSymbol(SymbolTable table, EntryPoint? entrypoint, StreamIO? io)
    {
        Condition.ProcessSymbol(table, entrypoint, io);
        Body.ProcessSymbol(table, entrypoint, io);
        if(Condition.Type != ScalarSymbol.From("bool"))
            table.Errors.Add(new(Condition.Info, "not a boolean"));
    }
    public override string ToString()
    {
        return $"else if({Condition}){Body}";
    }
}

public class Else(Statement body, TextLocation info) : Flow(info)
{
    public Statement Body { get; set; } = body;

    public override void ProcessSymbol(SymbolTable table, EntryPoint? entrypoint, StreamIO? io)
    {
        Body.ProcessSymbol(table, entrypoint, io);
    }
    public override string ToString()
    {
        return $"else {Body}";
    }
}