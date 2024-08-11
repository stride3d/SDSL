namespace Stride.Parsing;

public abstract class Node(TextLocation info)
{
    public TextLocation Info { get; } = info;
}