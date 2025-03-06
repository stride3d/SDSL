using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Core;
using Stride.Shaders.Spirv.Core.Buffers;

namespace Stride.Shaders.Spirv.Building;


public struct SpirvFunction(int id, string name, FunctionTypeSymbol type)
{
    public int Id { get; } = id;
    public string Name { get; } = name;
    public FunctionTypeSymbol FunctionType { get; private set; } = type;
    public SortedList<string, BasicBlock> BasicBlocks { get; } = [];

    public readonly BasicBlock CreateBlock(string name)
    {
        var result = new BasicBlock(name, this);
        BasicBlocks.Add(name, result);
        return result;
    }

    public readonly int GetLastPosition()
    {
        throw new NotImplementedException();
    }

}


public struct BasicBlock(string name, SpirvFunction parent)
{
    public string Name { get; set; } = name;
    public SpirvFunction Parent { get; set; } = parent;
    public int Length { get; private set; }
}

