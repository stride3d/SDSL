using SDSL.Parsing.AST.Shader;
using SoftTouch.Spirv.Core.Buffers;

namespace SDSL.Analysis;


public record struct CFEdge(Expression Condition, CFNode Destination);

public class CFNode()
{
    public List<Statement> Code = [];
    public List<CFEdge> Outputs = [];
}
public sealed class ControlFlowGraph
{
    public Dictionary<ShaderMethod, ControlFlowGraph> Graphs = [];

    public ControlFlowGraph(ShaderProgram program)
    {
        
    }
}