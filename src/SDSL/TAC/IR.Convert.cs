using System.Collections;
using System.Numerics;
using System.Runtime.InteropServices;
using CommunityToolkit.HighPerformance.Buffers;
using SDSL.Parsing.AST.Shader;
using SDSL.Parsing.AST.Shader.Symbols;

namespace SDSL.TAC;

public sealed partial class IR
{
    public static IR Convert(ShaderMethod method)
    {
        var ir = new IR();
        if(method is MainMethod m)
        {
            // TODO: Depending the main method generate variables
        }
        foreach (var statement in method.Statements)
            if (statement is SimpleDeclare sd)
                ir.Convert(sd);
            else if (statement is DeclareAssign da)
                ir.Convert(da);
        return ir;
                
    }
    void Convert(SimpleDeclare sd)
    {
        Add(new(Operator.Declare, Result: new(sd.VariableName, Kind.Variable, sd.TypeName)));
    }
    void Convert(DeclareAssign da)
    {
        var vId = Convert(da.Value as Expression ?? throw new NotImplementedException());
        Add(new(Operator.Declare, vId, Result: new(da.VariableName, Kind.Variable, da.TypeName)));
    }
}