using Stride.Shaders.Parsing.SDFX.AST;
using Stride.Shaders.Parsing.SDSL;

namespace Stride.Shaders.Parsing.SDFX.Parsers;

// public record struct EffectFileParser : IParser<EffectFile>
// {
//     public readonly bool Match(ref Scanner scanner, ParseResult result, out EffectFile parsed, in ParseError? orError = null) 
//         
//     {
//         var position = scanner.Position;

//         scanner.MatchWhiteSpace(advance: true);
//         throw new NotImplementedException();
//     }
// }


// public record struct EffectNamespaceParser : IParser<ShaderNamespace>
// {
//     public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderNamespace parsed, in ParseError? orError = null) 
//     {
//         var position = scanner.Position;

//         if(Terminals.Literal("namespace", advance: true) && scanner.MatchWhiteSpace(minimum: 1, advance: true))
//         {
//             do
//             {
                
//             }
//             while (!scanner.IsEof && !Terminals.Char(';') && Terminals.Char('.', advance: true));
//         }
//         return CommonParsers.Exit(ref scanner, result, out parsed, position, orError);

//     }
// }