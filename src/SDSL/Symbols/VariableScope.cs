using System;
using System.Collections.Generic;
using SDSL.Parsing.AST.Shader.Symbols;

namespace SDSL.Symbols;



public class VariableScope
{
    SymbolTable Table;
    Stack<SortedList<string, VariableSymbol>> Scopes;

    public VariableScope(SymbolTable table)
    {
        Table = table;
        Scopes = new();
    }

    public void Push(VariableSymbol variable)
    {
        if (!IsDeclared(variable.Name))
            Scopes.Peek().Add(variable.Name, variable);
        else
            throw new Exception($"Variable {variable.Name} already declared");
    }
    public void Remove(VariableSymbol variable) => Scopes.Peek().Remove(variable.Name);
    public void PushScope() => Scopes.Push(new());
    public void PopScope() => Scopes.Pop();

    public bool IsDeclared(string name)
    {
        foreach (var scope in Scopes)
            if (scope.ContainsKey(name)) return true;
        return false;
    }

    public VariableSymbol? GetVariable(string name)
    {
        foreach (var scope in Scopes)
        {
            if (scope.TryGetValue(name, out var variable))
                return variable;
        }
        return null;
    }

    public bool TryGetVariable(string name, out VariableSymbol variable)
    {
        variable = VariableSymbol.None;
        foreach (var scope in Scopes)
        {
            if (scope.TryGetValue(name, out variable))
                return true;
        }
        return false;
    }


}