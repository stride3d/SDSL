using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;


public record struct DirectiveUnaryParsers
{
    internal static bool Not(ref Scanner scanner, ParseResult result, out Expression cast, in ParseError? orError = null)
        
        => new DirectiveNotExpressionParser().Match(ref scanner, result, out cast, in orError);
    internal static bool Signed(ref Scanner scanner, ParseResult result, out Expression cast, in ParseError? orError = null)
        
        => new DirectiveSignExpressionParser().Match(ref scanner, result, out cast, in orError);
    internal static bool PrefixIncrement(ref Scanner scanner, ParseResult result, out Expression cast, in ParseError? orError = null)
        
        => new DirectivePrefixIncrementParser().Match(ref scanner, result, out cast, in orError);
    internal static bool Cast(ref Scanner scanner, ParseResult result, out Expression cast, in ParseError? orError = null)
        
        => new DirectiveCastExpressionParser().Match(ref scanner, result, out cast, in orError);
    public static bool Prefix(ref Scanner scanner, ParseResult result, out Expression prefix, in ParseError? orError = null)
        
        => new DirectivePrefixParser().Match(ref scanner, result, out prefix, in orError);
    public static bool Primary(ref Scanner scanner, ParseResult result, out Expression postfix, in ParseError? orError = null)
        
       => new DirectivePrimaryParsers().Match(ref scanner, result, out postfix, in orError);
}
