using Stride.Shaders.Parsing;
using Stride.Shaders.Parsing.SDSL.AST;
using Stride.Shaders.Spirv.Building;

namespace Stride.Shaders.Compilers.SDSL;

public static class ASTExtensions
{
    public static void Lower(this ShaderFile file, SpirvContext ctx, Builder builder)
    {
        
        // foreach(var ns in file.Namespaces)
        // {
        //     foreach(var sc in ns.Declarations.OfType<ShaderClass>())
        //     {

        //     }
        // }
        // foreach(var sc in file.RootDeclarations.OfType<ShaderClass>())
        // {

        // }
        throw new NotImplementedException();
    }
    public static void Lower(this ShaderClass file, SpirvContext ctx, Builder builder)
    {
        
        
        throw new NotImplementedException();
    }
}