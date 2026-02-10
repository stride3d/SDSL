namespace Stride.Shaders.Parsing.SDSL;


public delegate bool ParserDelegate<TScanner>(ref TScanner scanner, ParseResult result);
public delegate bool ParserDelegate<TScanner, TResult>(ref TScanner scanner, ParseResult result, out TResult parsed, in ParseError? orError = null);
public delegate bool ParserListDelegate<TScanner, TResult>(ref TScanner scanner, ParseResult result, out List<TResult> parsed, in ParseError? orError = null);
public delegate bool ParserOptionalDelegate<TScanner, TResult>(ref TScanner scanner, ParseResult result, out TResult? parsed, in ParseError? orError = null);
