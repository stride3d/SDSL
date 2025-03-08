using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Core.Buffers;

namespace Stride.Shaders.Spirv.Building;

// Should contain internal data not seen by the client but helpful for the generation like type symbols and other 
// SPIR-V parameters
public class SpirvContext(Module module)
{
    public int Bound { get; private set; }
    public Module Module { get; } = module;
    public SortedList<SymbolType, int> Types { get; } = [];
    public SpirvBuffer Buffer { get; set; } = new();
}