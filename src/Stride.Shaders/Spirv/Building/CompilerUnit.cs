namespace Stride.Shaders.Spirv.Building;


public abstract class CompilerArgument;


public class CompilerUnit
{
    public SpirvModule Module { get; }
    public SpirvContext Context { get; }
    public SpirvBuilder Builder { get; }
    public List<CompilerArgument> Arguments { get; }

    public CompilerUnit()
    {
        Module = new SpirvModule();
        Context = new SpirvContext(Module);
        Builder = new SpirvBuilder();
        Arguments = [];
    }
}