using Stride.Shaders.Core;
using Stride.Shaders.Experiments;
using Stride.Shaders.Parsing;
using Stride.Shaders.Parsing.SDSL;
using Stride.Shaders.Parsing.SDSL.AST;


// Examples.SpvOpt();
// Examples.TranslateHLSL();
// var matched = Grammar.Match<StatementParsers, Statement>("int uSeed = (int) (fSeed);");
// foreach(var e in matched.Errors)
//     Console.WriteLine(e);
// Console.WriteLine(matched.AST);
Console.WriteLine(
    new FunctionTypeSymbol([ScalarSymbol.From("float"), ScalarSymbol.From("int")])
    ==
    new FunctionTypeSymbol([ScalarSymbol.From("float"), ScalarSymbol.From("double")])
);
Examples.ParseSDSL();
var x = 0;
// Examples.TryAllFiles();