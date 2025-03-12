namespace Stride.Shaders.Compilers.SDSL;

using Stride.Shaders.Parsing;
using Stride.Shaders.Parsing.Analysis;
using Stride.Shaders.Parsing.SDSL.AST;
using Stride.Shaders.Spirv.Building;

public record struct SDSLC() : ICompiler
{
    public readonly bool Compile(string code, out Memory<byte> compiled)
    {
        var parsed = SDSLParser.Parse(code);
        if(parsed.AST is ShaderFile sf)
        {
            SymbolTable table = new();
            var shader = sf.Namespaces.First().Declarations.OfType<ShaderClass>().First();
            shader.ProcessSymbol(table);

            if(table.Errors.Count > 0)
                throw new Exception("Some parse errors");
            var module = new Module();
            var builder = new Builder();
            var context = new SpirvContext(module);
            shader.Compile(builder, context);
        }
        throw new NotImplementedException();
    }
}






public static class GenerateExtension
{
    public static void Compile(this ShaderClass sclass, Builder builder, SpirvContext context)
    {
        foreach(var e in sclass.Elements.OfType<ShaderMember>())
        {
            Console.WriteLine(e);
        }
    }
}