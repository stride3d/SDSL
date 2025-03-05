using Stride.Shaders.Spirv.Core.Buffers;

namespace Stride.Shaders.Spirv.Building;




// High level API to create SPIR-V
public class Builder(Module module)
{
    public Module Module { get; } = module;
}

// Should contain internal data not seen by the client
public class Context()
{
    
    SpirvBuffer buffer = new();
}
// Should contain the SPIR-V code and a sort of symbol table to list components in it
public class Module()
{
    public SpirvBuffer Variables { get; set; } = new();
    public SortedList<string, SpirvBuffer> Functions { get; } = [];
}