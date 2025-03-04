using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Core;
using Stride.Shaders.Spirv.Core.Buffers;

namespace Stride.Shaders.Spirv.Building;


public class SpirvFunction
{
    SymbolType FunctionType { get; set; }
    public List<BasicBlock> BasicBlocks { get; set; }
}


public class BasicBlock
{
    public string Name { get; set; }
    public SpirvFunction Parent { get; set; }
    public SpirvBuffer Instructions { get; set; } = new();
}

