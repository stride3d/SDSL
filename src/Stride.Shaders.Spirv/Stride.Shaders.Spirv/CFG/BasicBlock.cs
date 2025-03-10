using Stride.Shaders.Spirv.Core.Buffers;

namespace Stride.Shaders.Spirv;

public abstract class BasicBlock
{
    public string Name { get; set; }
    public WordBuffer Instructions { get; set; } = new();
}


public class ConditionBlock : BasicBlock
{
    public BasicBlock TrueBlock { get; set; }
    public BasicBlock FalseBlock { get; set; }
}

public class LoopBlock : BasicBlock
{
    public BasicBlock Body { get; set; }
    public BasicBlock Continue { get; set; }
    public BasicBlock Break { get; set; }
}