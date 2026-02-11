using Stride.Shaders.Parsing.SDFX.AST;
using Stride.Shaders.Parsing.SDFX.Parsers;
using Stride.Shaders.Parsing.SDSL;

namespace Stride.Shaders.Parsing.SDFX;



public record struct EffectControlsParser : IParser<EffectControl>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out EffectControl parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (If(ref scanner, result, out var ifstatement, orError) && scanner.MatchWhiteSpace(advance: true))
        {
            parsed = new(ifstatement, scanner[..]);
            while(ElseIf(ref scanner, result, out var elseif, orError) && scanner.MatchWhiteSpace(advance: true))
                parsed.ElseIfs.Add(elseif);
            if (Else(ref scanner, result, out var elseStatement, orError))
                parsed.Else = elseStatement;
            parsed.Info = scanner[position..scanner.Position];
            return true;
        }
        else if(scanner.Match("else "))
            return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, new("Else block should be preceeded by If statement", scanner[scanner.Position], scanner.Memory));
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }

    public static bool Control(ref Scanner scanner, ParseResult result, out EffectControl parsed, ParseError? orError = null)
        => new EffectControlsParser().Match(ref scanner, result, out parsed, orError);

    public static bool If(ref Scanner scanner, ParseResult result, out If parsed, ParseError? orError = null)
        => new IfStatementParser().Match(ref scanner, result, out parsed, orError);
    public static bool ElseIf(ref Scanner scanner, ParseResult result, out ElseIf parsed, ParseError? orError = null)
        => new ElseIfStatementParser().Match(ref scanner, result, out parsed, orError);
    public static bool Else(ref Scanner scanner, ParseResult result, out Else parsed, ParseError? orError = null)
        => new ElseStatementParser().Match(ref scanner, result, out parsed, orError);
}



public record struct IfStatementParser : IParser<If>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out If parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            scanner.Match("if", advance: true)
            && scanner.FollowedBy('(', withSpaces: true, advance: true)
            && scanner.MatchWhiteSpace(advance: true)
            && ExpressionParser.Expression(ref scanner, result, out var condition, new(SDSLErrorMessages.SDSL0015, scanner[scanner.Position], scanner.Memory))
            && scanner.MatchWhiteSpace(advance: true)
        )
        {
            if (scanner.Match(')', advance: true) && scanner.MatchWhiteSpace(advance: true))
            {
                if (EffectStatementParsers.Statement(ref scanner, result, out var statement, new(SDSLErrorMessages.SDSL0010, scanner[scanner.Position], scanner.Memory)))
                {
                    parsed = new(condition, statement, scanner[position..scanner.Position]);
                    return true;
                }
            }
            else return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0018, scanner[scanner.Position], scanner.Memory));
        }
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}

public record struct ElseIfStatementParser : IParser<ElseIf>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ElseIf parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            scanner.Match("else", advance: true)
            && scanner.MatchWhiteSpace(minimum: 1, advance: true)
            && scanner.Match("if", advance: true)
            && scanner.MatchWhiteSpace(advance: true)
            && scanner.Match('(', advance: true)
            && scanner.MatchWhiteSpace(advance: true)
            && ExpressionParser.Expression(ref scanner, result, out var condition, new(SDSLErrorMessages.SDSL0015, scanner[scanner.Position], scanner.Memory))
            && scanner.MatchWhiteSpace(advance: true)
        )
        {
            if (scanner.Match(')', advance: true) && scanner.MatchWhiteSpace(advance: true))
            {
                if (EffectStatementParsers.Statement(ref scanner, result, out var statement, new(SDSLErrorMessages.SDSL0010, scanner[scanner.Position], scanner.Memory)))
                {
                    parsed = new(condition, statement, scanner[position..scanner.Position]);
                    return true;
                }
            }
            else return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0018, scanner[scanner.Position], scanner.Memory));
        }
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}

public record struct ElseStatementParser : IParser<Else>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Else parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            scanner.Match("else", advance: true)
            && scanner.MatchWhiteSpace(advance: true)
            && EffectStatementParsers.Statement(ref scanner, result, out var statement, new(SDSLErrorMessages.SDSL0010, scanner[scanner.Position], scanner.Memory))
        )
        {
            parsed = new(statement, scanner[position..scanner.Position]);
            return true;
        }
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}

