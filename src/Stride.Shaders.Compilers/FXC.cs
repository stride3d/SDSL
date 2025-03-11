using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Direct3D.Compilers;

namespace Stride.Shaders.Compilers;




public record struct FXCompiler() : ICompiler
{
    static D3DCompiler d3d = D3DCompiler.GetApi();
    
    public bool Compile(string code, out Memory<byte> compiled)
    {
        throw new NotImplementedException();
    }
}