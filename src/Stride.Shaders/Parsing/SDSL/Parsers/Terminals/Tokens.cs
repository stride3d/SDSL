namespace Stride.Shaders.Parsing.SDSL;


public interface IToken
{
    public bool Match(ref Scanner scanner, bool advance = false);
}