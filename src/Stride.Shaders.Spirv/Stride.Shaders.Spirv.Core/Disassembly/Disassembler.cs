using Stride.Shaders.Spirv.Core.Buffers;
using Stride.Shaders.Spirv.Core.Parsing;
using System.Runtime.InteropServices;
using static Spv.Specification;

namespace Stride.Shaders.Spirv.Core;


public static class Disassembler
{

    public static string Disassemble(Span<int> span)
    {
        using var wbuff = new SpirvBuffer(span);
        return Disassemble(wbuff);
    }

    public static string Disassemble(Memory<int> memory)
    {
        using var wbuff = new SpirvBuffer(memory);
        return Disassemble(wbuff);
    }


    public static string Disassemble(SpirvBuffer buff, bool useNames = false)
    {
        var dis = new SpirvDis<SpirvBuffer>(buff, useNames);
        return dis.ToString();
    }

    
}
