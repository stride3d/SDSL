using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Core.Buffers;

namespace Stride.Shaders.Spirv.Building;

// Should contain internal data not seen by the client but helpful for the generation
public class SpirvContext(Module module)
{
    public int Bound { get; private set; }
    public Module Module { get; } = module;
    public SortedList<SymbolType, int> Types { get; } = [];
}
// Should contain the SPIR-V code and a sort of symbol table to list components in it
public class Module()
{
    public SortedList<string, SpirvFunction> Functions { get; init; } = [];
}


public class Builder
{
    public SpirvBuffer Buffer { get; init; } = new();
    public int Position { get; private set; }
}
