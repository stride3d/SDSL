﻿using Eto.Parse;
using SDSL.Analysis;
using SDSL.Parsing.AST.Shader;
using SDSL.Parsing.AST.Shader.Symbols;
using SDSL.Symbols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDSL.Parsing.AST.Shader;


public abstract class Statement : ShaderTokenTyped
{
    public override SymbolType? InferredType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void TypeCheck(SymbolTable symbols, in SymbolType? expected)
    {
        throw new NotImplementedException();
    }
}

public class EmptyStatement : Statement
{
    public override SymbolType? InferredType => SymbolType.Void;
    public override void TypeCheck(SymbolTable symbols, in SymbolType? expected) { }
}

public abstract class Declaration : Statement
{
    public override SymbolType? InferredType => SymbolType.Void;
    public SymbolType? TypeName { get; set; }
    public string VariableName { get; set; }

}

public class DeclareAssign : Declaration, IStaticCheck, IStreamCheck
{
    public AssignOpToken AssignOp { get; set; }
    public ShaderTokenTyped Value { get; set; }


    public DeclareAssign() { }
    public DeclareAssign(Match m, SymbolTable s)
    {
        Match = m;
        AssignOp = m["AssignOp"].StringValue.ToAssignOp();
        TypeName = s.ParseType(m["ValueTypes"].StringValue);
        VariableName = m["Variable"].StringValue;
        Value = (ShaderTokenTyped)GetToken(m["Value"], s);
    }

    public bool CheckStatic(SymbolTable s)
    {
        return Value is IStaticCheck sc &&
            sc.CheckStatic(s);
    }

    public bool CheckStream(SymbolTable s)
    {
        return Value is IStreamCheck sc &&
            sc.CheckStream(s);
    }
    public IEnumerable<string> GetUsedStream()
    {
        if (Value is IStreamCheck val)
            return val.GetUsedStream();
        return Enumerable.Empty<string>();
    }
    public IEnumerable<string> GetAssignedStream()
    {
        return Enumerable.Empty<string>();
    }
    public override void TypeCheck(SymbolTable symbols, in SymbolType? _)
    {
        Value.TypeCheck(symbols, TypeName);
    }
}

public class SimpleDeclare : Declaration
{
    public SimpleDeclare() { }
    public SimpleDeclare(Match m, SymbolTable s)
    {
        Match = m;
        VariableName = m["Variable"].StringValue;
        TypeName = s.ParseType(m["ValueTypes"].StringValue);

    }
    public override void TypeCheck(SymbolTable symbols, in SymbolType? expected) { }
}

public class AssignChain : Statement, IStreamCheck, IStaticCheck, IVariableCheck
{
    public override SymbolType? InferredType => SymbolType.Void;

    public AssignOpToken AssignOp { get; set; }
    public bool StreamValue => AccessNames.Any() && AccessNames.First() == "streams";
    public List<string> AccessNames { get; set; }
    public ShaderTokenTyped Value { get; set; }
    public AssignChain(Match m, SymbolTable s)
    {
        Match = m;
        AssignOp = m["AssignOp"].StringValue.ToAssignOp();
        AccessNames = m.Matches.Where(x => x.Name == "Identifier").Select(x => x.StringValue).ToList();
        Value = (ShaderTokenTyped)GetToken(m["PrimaryExpression"], s);
    }

    public bool CheckStream(SymbolTable s)
    {
        return StreamValue || Value is IStreamCheck isc && isc.CheckStream(s);
    }

    public IEnumerable<string> GetAssignedStream()
    {
        if (StreamValue)
            return new List<string>() { AccessNames.ElementAt(1) };
        else
            return Enumerable.Empty<string>();
    }
    public IEnumerable<string> GetUsedStream()
    {
        if (Value is IStreamCheck v)
            return v.GetUsedStream();
        else
            return Enumerable.Empty<string>();
    }

    public bool CheckStatic(SymbolTable s)
    {
        return Value is IStaticCheck isc && isc.CheckStatic(s);
    }

    public void CheckVariables(SymbolTable s)
    {
        if (Value is IVariableCheck v) v.CheckVariables(s);
    }
    public override void TypeCheck(SymbolTable symbols, in SymbolType? expected)
    {
        throw new NotImplementedException("TODO");
    }
}

public class ReturnStatement : Statement, IStreamCheck, IStaticCheck
{
    public override SymbolType? InferredType => ReturnValue?.InferredType ?? SymbolType.Void;

    public ShaderTokenTyped? ReturnValue { get; set; }
    public ReturnStatement(Match m, SymbolTable s)
    {
        Match = m;
        if (m.HasMatches)
        {
            ReturnValue = (ShaderTokenTyped)GetToken(m["PrimaryExpression"], s);
        }
    }

    public bool CheckStream(SymbolTable s)
    {
        return ReturnValue is IStreamCheck sc && sc.CheckStream(s);
    }

    public IEnumerable<string> GetUsedStream()
    {
        if (ReturnValue is IStreamCheck isc)
            return isc.GetUsedStream();
        return Enumerable.Empty<string>();
    }
    public IEnumerable<string> GetAssignedStream()
    {
        return Enumerable.Empty<string>();
    }

    public bool CheckStatic(SymbolTable s)
    {
        return ReturnValue is IStaticCheck sc && sc.CheckStatic(s);
    }

    public override void TypeCheck(SymbolTable symbols, in SymbolType? expected)
    {
        ReturnValue?.TypeCheck(symbols, expected);
        if(ReturnValue?.InferredType != expected)
            throw new Exception($"Type not matching, expected return type {expected?.ToString() ?? "void"}, and returned {ReturnValue?.InferredType}");

    }
}

public class BlockStatement : Statement, IStreamCheck, IStaticCheck
{
    public IEnumerable<Statement> Statements { get; set; }
    public BlockStatement(Match m, SymbolTable s)
    {
        Match = m;
        throw new NotImplementedException();
        // Statements = m.Matches.Select(GetToken).Cast<Statement>().ToList();
    }

    public bool CheckStream(SymbolTable s)
    {
        return Statements.Any(x => x is IStreamCheck isc && isc.CheckStream(s));
    }
    public IEnumerable<string> GetUsedStream()
    {
        return Statements.OfType<IStreamCheck>().SelectMany(x => x.GetUsedStream());
    }
    public IEnumerable<string> GetAssignedStream()
    {
        return Statements.OfType<IStreamCheck>().SelectMany(x => x.GetAssignedStream());
    }

    public bool CheckStatic(SymbolTable s)
    {
        return Statements.Any(x => x is IStaticCheck isc && isc.CheckStatic(s));
    }
}
