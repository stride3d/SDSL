﻿using Eto.Parse;
using SDSL.Analysis;
using SDSL.Parsing.AST.Shader.Symbols;
using SDSL.Symbols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDSL.Parsing.AST.Shader;


public class UnaryExpression : Expression
{
    public override SymbolType? InferredType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

public class ChainAccessor : UnaryExpression, IStreamCheck, IVariableCheck
{
    public ShaderToken Value { get; set; }
    public List<ShaderToken> Field { get; set; }
    public override SymbolType? InferredType { get => inferredType; set => inferredType = value; }

    public ChainAccessor(Match m, SymbolTable s)
    {
        Match = m;
        Value = GetToken(m.Matches["Identifier"], s);
        Field = m.Matches.GetRange(1, m.Matches.Count - 1).Select(x => GetToken(x, s)).ToList();
    }

    public IEnumerable<string> GetUsedStream()
    {
        if (Value is VariableNameLiteral vn && vn.Name == "streams")
            return new List<string> { ((VariableNameLiteral)Field.First()).Name };
        return Enumerable.Empty<string>();
    }
    public IEnumerable<string> GetAssignedStream()
    {
        return Enumerable.Empty<string>();
    }
    public bool CheckStream(SymbolTable symbols)
    {
        return GetUsedStream().Any();
    }
    public void CheckVariables(SymbolTable s)
    {
        if (Value is IVariableCheck n) n.CheckVariables(s);
    }
    public override void TypeCheck(SymbolTable symbols, in SymbolType? expected)
    {
        throw new NotImplementedException("TODO");
        // if (Value is VariableNameLiteral vn && symbols.TryGet(vn.Name, out var type))
        // {
        //     SymbolType current = type;

        //     foreach (var a in Field)
        //     {
        //         var tmp = current;
        //         if (a is VariableNameLiteral vna)
        //         {
        //             if(!current.TryAccessType(vna.Name, out current))
        //             {
        //                 // symbols.AddError(Match, $"Accessor `{vna.Name}` does not exist for type `{tmp}`");
        //             }
        //         }
        //     }
        //     inferredType = current;
        // }
    }
}

public class ArrayAccessor : UnaryExpression, IVariableCheck
{
    public ShaderToken Value { get; set; }
    public IEnumerable<ShaderToken> Accessors { get; set; }

    public ArrayAccessor(Match m, SymbolTable s)
    {
        Match = m;
        Value = GetToken(m.Matches[0], s);
        throw new NotImplementedException();
        // Accessors = m.Matches.GetRange(1,m.Matches.Count-1).Select(GetToken);
    }
    public void CheckVariables(SymbolTable s)
    {
        if (Value is IVariableCheck n) n.CheckVariables(s);
    }
}


public class PostfixIncrement : UnaryExpression, IVariableCheck
{
    public string Operator { get; set; }
    public ShaderToken Value { get; set; }
    public PostfixIncrement(Match m, SymbolTable s)
    {
        Match = m;
        Value = GetToken(m.Matches[0], s);
        Operator = m.Matches[1].StringValue;
    }

    public override string ToString()
    {
        return $"{{ PostfixIncrement :  [\"{Value}\", \"{Operator}\"] }}";
    }
    public void CheckVariables(SymbolTable s)
    {
        if (Value is VariableNameLiteral n) n.CheckVariables(s);
    }
}

public class PrefixIncrement : UnaryExpression
{
    public string Operator { get; set; }
    public ShaderToken Value { get; set; }
    public PrefixIncrement(Match m, SymbolTable s)
    {
        Match = m;
        Operator = m.Matches[0].StringValue;
        Value = GetToken(m.Matches[1], s);
    }
}

public class CastExpression : UnaryExpression
{
    public TypeNameLiteral Target { get; set; }
    public ShaderToken From { get; set; }
    public CastExpression(Match m, SymbolTable s)
    {
        Target = new TypeNameLiteral(m.Matches[0], s);
        From = GetToken(m.Matches[1], s);
    }
}