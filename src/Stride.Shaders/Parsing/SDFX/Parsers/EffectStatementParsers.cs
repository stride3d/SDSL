using Stride.Shaders.Core;
using Stride.Shaders.Parsing.SDFX.AST;
using Stride.Shaders.Parsing.SDSL;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDFX.Parsers;


public record struct EffectStatementParsers : IParser<EffectStatement>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out EffectStatement parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (EffectBlock(ref scanner, result, out var block))
        {
            parsed = block;
            return true;
        }
        else if (UsingParams(ref scanner, result, out var p1) && scanner.FollowedBy(';', withSpaces: true, advance: true))
        {
            parsed = p1;
            return true;
        }
        else if (MixinCompose(ref scanner, result, out var p2))
        {
            parsed = p2;
            return true;
        }
        else if (MixinComposeAdd(ref scanner, result, out var mca) && scanner.FollowedBy(';', withSpaces: true, advance: true))
        {
            parsed = mca;
            return true;
        }
        else if (MixinChild(ref scanner, result, out var mc) && scanner.FollowedBy(';', withSpaces: true, advance: true))
        {
            parsed = mc;
            return true;
        }
        else if (MixinClone(ref scanner, result, out var mcl) && scanner.FollowedBy(';', withSpaces: true, advance: true))
        {
            parsed = mcl;
            return true;
        }
        else if (MixinConst(ref scanner, result, out var mconst) && scanner.FollowedBy(';', withSpaces: true, advance: true))
        {
            parsed = mconst;
            return true;
        }
        else if (MixinUse(ref scanner, result, out var p3) && scanner.FollowedBy(';', withSpaces: true, advance: true))
        {
            parsed = p3;
            return true;
        }
        else if (EffectControlsParser.Control(ref scanner, result, out var control))
        {
            parsed = control;
            return true;
        }
        else if (Flow(ref scanner, result, out var flow))
        {
            parsed = flow;
            return true;
        }
        else if (ShaderSourceDeclaration(ref scanner, result, out var ssd))
        {
            parsed = ssd;
            return true;
        }
        else if (StatementParsers.Expression(ref scanner, result, out var exp))
        {
            parsed = new EffectExpressionStatement(exp, scanner[position..scanner.Position]);
            return true;
        }
        else if (
            scanner.FollowedBy("dicard", withSpaces: true, advance: true)
            && scanner.FollowedBy(';', withSpaces: true, advance: true)
        )
        {
            parsed = new EffectDiscardStatement(scanner[position..scanner.Position]);
            return true;
        }
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }

    public static bool Statement(ref Scanner scanner, ParseResult result, out EffectStatement parsed, in ParseError? orError = null)
        => new EffectStatementParsers().Match(ref scanner, result, out parsed, orError);
    public static bool UsingParams(ref Scanner scanner, ParseResult result, out UsingParams parsed, in ParseError? orError = null)
        => new UsingParamsParser().Match(ref scanner, result, out parsed, orError);
    public static bool MixinCompose(ref Scanner scanner, ParseResult result, out MixinCompose parsed, in ParseError? orError = null)
        => new MixinComposeParser().Match(ref scanner, result, out parsed, orError);
    public static bool MixinComposeAdd(ref Scanner scanner, ParseResult result, out MixinComposeAdd parsed, in ParseError? orError = null)
        => new MixinComposeAddParser().Match(ref scanner, result, out parsed, orError);
    public static bool MixinUse(ref Scanner scanner, ParseResult result, out MixinUse parsed, in ParseError? orError = null)
        => new MixinUseParser().Match(ref scanner, result, out parsed, orError);
    public static bool MixinChild(ref Scanner scanner, ParseResult result, out MixinChild parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            SDSL.Parsers.SequenceOf(ref scanner, ["mixin", "child"], advance: true)
            && SDSL.Parsers.FollowedByDel(ref scanner, result, ShaderClassParsers.Mixin, out Mixin mixin, withSpaces: true, advance: true)
            && scanner.FollowedBy(';', withSpaces: true)
        )
        {
            parsed = new(mixin, scanner[position..scanner.Position]);
            return true;
        }
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
    public static bool MixinClone(ref Scanner scanner, ParseResult result, out MixinClone parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            SDSL.Parsers.SequenceOf(ref scanner, ["mixin", "clone"], advance: true)
            && SDSL.Parsers.FollowedByDel(ref scanner, result, ShaderClassParsers.Mixin, out Mixin mixin, withSpaces: true, advance: true)
            && scanner.FollowedBy(';', withSpaces: true)
        )
        {
            parsed = new(mixin, scanner[position..scanner.Position]);
            return true;
        }
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
    public static bool MixinConst(ref Scanner scanner, ParseResult result, out MixinConst parsed, in ParseError? orError = null)
        => new MixinConstParser().Match(ref scanner, result, out parsed, orError);
    public static bool Flow(ref Scanner scanner, ParseResult result, out EffectFlow parsed, in ParseError? orError = null)
        => new FlowParsers().Match(ref scanner, result, out parsed, orError);

    public static bool EffectBlock(ref Scanner scanner, ParseResult result, out EffectStatement parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;

        if (scanner.Match('{', advance: true))
        {
            List<EffectStatement> statements = [];
            while (SDSL.Parsers.FollowedByDel(ref scanner, result, Statement, out EffectStatement statement, withSpaces: true, advance: true))
            {
                statements.Add(statement);
            }
            if (!scanner.FollowedBy('}', withSpaces: true, advance: true))
                return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0001, scanner[scanner.Position], scanner.Memory));
            parsed = new EffectBlock(scanner[position..scanner.Position]) { Statements = statements };
            return true;
        }
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position);
    }
    public static bool ShaderSourceDeclaration(ref Scanner scanner, ParseResult result, out ShaderSourceDeclaration parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            scanner.MatchAnyOf(["ShaderSourceCollection ", "ShaderSource ", "var "], out _)
            && SDSL.Parsers.TypeNameIdentifierArraySizeValue(ref scanner, result, out var typename, out var name,out var value)
            && scanner.FollowedBy(';', withSpaces: true, advance: true)
        )
        {
            parsed = new(name, scanner[position..scanner.Position], value);
            return true;
        }
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position);
    }

}


public record struct UsingParamsParser : IParser<UsingParams>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out UsingParams parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (SDSL.Parsers.SequenceOf(ref scanner, ["using", "params"], advance: true))
        {
            if (LiteralsParser.Identifier(ref scanner, result, out var identifier))
            {
                parsed = new(identifier, scanner[position..scanner.Position]);
                return true;
            }

        }
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}

public record struct MixinConstParser : IParser<MixinConst>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out MixinConst parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            SDSL.Parsers.SequenceOf(ref scanner, ["mixin", "macro"], advance: true)
            || SDSL.Parsers.SequenceOf(ref scanner, ["mixin", "const"], advance: true)
        )
        {
            scanner.MatchWhiteSpace(advance: true);
            var tmp = scanner.Position;
            scanner.MatchUntil(';');
            if (scanner.Match(';'))
            {
                parsed = new(scanner.Memory[tmp..scanner.Position].ToString().Trim(), scanner[position..scanner.Position]);
                return true;
            }
            else return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0001, scanner[position], scanner.Memory));
        }
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}

public record struct MixinComposeParser : IParser<MixinCompose>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out MixinCompose parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            SDSL.Parsers.SequenceOf(ref scanner, ["mixin", "compose"], advance: true)
            && LiteralsParser.Identifier(ref scanner, result, out var name)
            && scanner.MatchWhiteSpace(advance: true)
            && scanner.MatchAnyOf(["=", "+="], out var op, advance: true)
        )
        {
            if(
                scanner.FollowedBy('(', withSpaces: true, advance: true)
                && scanner.MatchWhiteSpace(advance: true)
                && ComposeValue(ref scanner, result, out var composeValue)
                && scanner.FollowedBy(')', withSpaces: true, advance: true)
                && scanner.FollowedBy(';', withSpaces: true, advance: true)
            )
            {
                parsed = new MixinCompose(name, op.ToAssignOperator(), composeValue, scanner[position..scanner.Position]);
                return true;
            }
            else if(
                scanner.MatchWhiteSpace(advance: true)
                && ComposeValue(ref scanner, result, out var composeValue2)
                && scanner.FollowedBy(';', withSpaces: true, advance: true)
            )
            {
                parsed = new MixinCompose(name, op.ToAssignOperator(), composeValue2, scanner[position..scanner.Position]);
                return true;
            }
            
        }
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }

    public static bool ComposeValue(ref Scanner scanner, ParseResult result, out ComposeValue value, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if(
            ShaderClassParsers.Mixin(ref scanner, result, out var mixin) 
            && (
                scanner.FollowedBy(';', withSpaces: true)
                || scanner.FollowedBy(')', withSpaces: true)
            )
        )
        {
            value = new ComposeMixinValue(mixin, scanner[position..scanner.Position]);
            return true;
        }
        else 
        {
            scanner.Backtrack(position);
            if(scanner.IdentifierFirstChar(advance: true))
            {
                while(
                    scanner.MatchLetterOrDigit(advance: true)
                    || scanner.Match('_', advance: true)
                    || scanner.Match('.', advance: true)
                );
                if(
                    scanner.FollowedBy(')', withSpaces: true)
                    || scanner.FollowedBy(';', withSpaces: true)
                )
                {
                    value = new ComposePathValue(scanner.Memory[position..scanner.Position].ToString(), scanner[position..scanner.Position]);
                    return true;
                }
            }
        }
        return SDSL.Parsers.Exit(ref scanner, result, out value, position);
    }
}

public record struct MixinComposeAddParser : IParser<MixinComposeAdd>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out MixinComposeAdd parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            SDSL.Parsers.SequenceOf(ref scanner, ["mixin", "compose"], advance: true)
            && LiteralsParser.Identifier(ref scanner, result, out var name)
            && scanner.MatchWhiteSpace(advance: true)
            && scanner.Match("+=", advance: true)
            && scanner.MatchWhiteSpace(advance: true)

        )
        {
            var start = scanner.Position;
            SDSL.Parsers.Until(ref scanner, ';');
            parsed = new MixinComposeAdd(name, new(scanner.Memory[start..scanner.Position].ToString().Trim(), scanner[start..scanner.Position]), scanner[position..scanner.Position]);
            return true;
        }
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}

public record struct MixinUseParser : IParser<MixinUse>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out MixinUse parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (
            scanner.Match("mixin", advance: true)
            && scanner.MatchWhiteSpace(minimum: 1, advance: true)
        )
        {
            var betweenParenthesis = scanner.FollowedBy('(', withSpaces: true, advance: true);
            if (SDSL.Parsers.Repeat(ref scanner, result, ShaderClassParsers.Mixin, out List<Mixin> mixins, 1, withSpaces: true, separator: ","))
            {
                var checkParen = betweenParenthesis == scanner.FollowedBy(')', withSpaces: true, advance: true);
                var finished = scanner.FollowedBy(';', withSpaces: true);
                if (finished && checkParen)
                {
                    parsed = new(mixins, scanner[position..scanner.Position]);
                    return finished;
                }
                else return SDSL.Parsers.Exit(ref scanner, result, out parsed, position);
            }
            return SDSL.Parsers.Exit(ref scanner, result, out parsed, position);
        }
        return SDSL.Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}