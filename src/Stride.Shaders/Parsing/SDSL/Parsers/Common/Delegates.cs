namespace Stride.Shaders.Parsing.SDSL;


public delegate bool ParserDelegate(ref Scanner scanner, ParseResult result);
public delegate bool ParserDelegate<TResult>(ref Scanner scanner, ParseResult result, out TResult parsed, in ParseError? orError = null);
public delegate bool ParserListDelegate<TResult>(ref Scanner scanner, ParseResult result, out List<TResult> parsed, in ParseError? orError = null);
public delegate bool ParserOptionalDelegate<TResult>(ref Scanner scanner, ParseResult result, out TResult? parsed, in ParseError? orError = null);
