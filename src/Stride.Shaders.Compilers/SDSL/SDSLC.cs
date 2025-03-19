using Stride.Shaders.Parsing;
using Stride.Shaders.Parsing.Analysis;
using Stride.Shaders.Parsing.SDSL.AST;
using Stride.Shaders.Spirv.Building;
using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Tools;
using Stride.Shaders.Spirv.Core.Buffers;

namespace Stride.Shaders.Compilers.SDSL;

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
            context.Buffer.Sort();
            var dis = new SpirvDis<SpirvBuffer>(context.Buffer, true);
            dis.Disassemble(true);
        }
        throw new NotImplementedException();
    }
}






public static class GenerateExtension
{
    public static void Compile(this ShaderClass sclass, Builder builder, SpirvContext context)
    {
        throw new NotImplementedException();
        // foreach(var v in sclass.Elements.OfType<ShaderMember>())
        // {
        //     if(v.StreamKind is StreamKind.Stream or StreamKind.PatchStream)
        //     {
        //         context.AddGlobalVariable(context.SymbolProvider.RootSymbols[new(v.Name, SymbolKind.Variable, Storage.Stream)]);
        //     }
        // }
    }
}