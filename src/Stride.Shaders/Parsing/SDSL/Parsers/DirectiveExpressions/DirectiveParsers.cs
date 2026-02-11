using Microsoft.VisualBasic;
using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;

public record struct PreprocessorParser : IParser<PreProcessableCode>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out PreProcessableCode parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        var p = new PreProcessableCode(new());
        while (!scanner.IsEof && DirectiveStatementParsers.Statement(ref scanner, result, out var statement))
            p.Snippets.Add(statement);
        p.Info = scanner[position..scanner.Position];
        parsed = p;
        return true;
    }

    public static bool PreCode(ref Scanner scanner, ParseResult result, out PreProcessableCode parsed, in ParseError? orError = null)
        
        => new PreprocessorParser().Match(ref scanner, result, out parsed, orError);
}

public record struct DirectiveStatementParsers : IParser<DirectiveStatement>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out DirectiveStatement parsed, in ParseError? orError = null)
        
    {
        parsed = null!;
        if (Conditional(ref scanner, result, out var conditional))
        {
            parsed = conditional;
            return true;
        }
        else if(Define(ref scanner, result, out var obj))
        {
            parsed = obj;
            return true;
        }
        else if (DefineFunc(ref scanner, result, out var func))
        {
            parsed = func;
            return true;
        }
        else if (Code(ref scanner, result, out var code))
        {
            parsed = code;
            return true;
        }
        else return false;
    }

    public static bool AnyIf(ref Scanner scanner, ParseResult result, out IfDirective parsed, in ParseError? orError = null)
        
    {
        if (If(ref scanner, result, out var ifDirective))
        {
            parsed = ifDirective;
            return true;
        }
        else if (IfDef(ref scanner, result, out var ifdefDirective))
        {
            parsed = ifdefDirective;
            return true;
        }
        else if (IfNDef(ref scanner, result, out var ifndefDirective))
        {
            parsed = ifndefDirective;
            return true;
        }
        parsed = null!;
        return false;
    }
    public static bool Define(ref Scanner scanner, ParseResult result, out ObjectDefineDirective parsed, in ParseError? orError = null)
        
        => new ObjectDefineDirectiveParser().Match(ref scanner, result, out parsed, orError);
    public static bool DefineFunc(ref Scanner scanner, ParseResult result, out FunctionDefineDirective parsed, in ParseError? orError = null)
        
        => new FunctionDefineDirectiveParser().Match(ref scanner, result, out parsed, orError);
    public static bool If(ref Scanner scanner, ParseResult result, out IfDirective parsed, in ParseError? orError = null)
        
        => new ConditionalIfDirectivesParser().Match(ref scanner, result, out parsed, orError);
    public static bool IfDef(ref Scanner scanner, ParseResult result, out IfDefDirective parsed, in ParseError? orError = null)
        
        => new ConditionalIfDefDirectivesParser().Match(ref scanner, result, out parsed, orError);
    public static bool IfNDef(ref Scanner scanner, ParseResult result, out IfNDefDirective parsed, in ParseError? orError = null)
        
        => new ConditionalIfNDefDirectivesParser().Match(ref scanner, result, out parsed, orError);
    public static bool Elif(ref Scanner scanner, ParseResult result, out IfDirective parsed, in ParseError? orError = null)
        
        => new ConditionalElifDirectivesParser().Match(ref scanner, result, out parsed, orError);
    public static bool Endif(ref Scanner scanner, ParseResult result, in ParseError? orError = null)
        
        => new EndifDirectiveParser().Match(ref scanner, result, out _, orError);
    public static bool Code(ref Scanner scanner, ParseResult result, out DirectiveCode parsed, in ParseError? orError = null)
        
        => new DirectiveCodeParser().Match(ref scanner, result, out parsed, orError);
    public static bool Else(ref Scanner scanner, ParseResult result, out ElseDirective parsed, in ParseError? orError = null)
        
        => new ConditionalElseDirectivesParser().Match(ref scanner, result, out parsed, orError);
    public static bool Conditional(ref Scanner scanner, ParseResult result, out ConditionalDirectives parsed, in ParseError? orError = null)
        
        => new ConditionalDirectivesParser().Match(ref scanner, result, out parsed, orError);
    public static bool Statement(ref Scanner scanner, ParseResult result, out DirectiveStatement parsed, in ParseError? orError = null)
        
        => new DirectiveStatementParsers().Match(ref scanner, result, out parsed, orError);
}

public struct ConditionalDirectivesParser : IParser<ConditionalDirectives>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ConditionalDirectives parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;

        if (DirectiveStatementParsers.AnyIf(ref scanner, result, out var ifDirective, orError))
        {
            if (PreprocessorParser.PreCode(ref scanner, result, out var c))
                ifDirective.Code = c;

            var elifDirectives = new List<ElifDirective>();
            while (DirectiveStatementParsers.Elif(ref scanner, result, out var elifDirective, orError))
            {
                elifDirectives.Add((ElifDirective)elifDirective);
                if (PreprocessorParser.PreCode(ref scanner, result, out c))
                    elifDirective.Code = c;
            }

            if (DirectiveStatementParsers.Else(ref scanner, result, out var elseDirective, orError))
                if (PreprocessorParser.PreCode(ref scanner, result, out c))
                    elseDirective.Code = c;

            if (DirectiveStatementParsers.Endif(ref scanner, result, orError))
            {
                parsed = new ConditionalDirectives(ifDirective, scanner[position..scanner.Position])
                {
                    Elifs = elifDirectives,
                    Else = elseDirective
                };
                return true;
            }
            else
            {
                parsed = null!;
                return false;
            }
        }
        else
        {
            scanner.Backtrack(position);
            parsed = null!;
            return false;
        }
    }
}

public record struct DirectiveCodeParser : IParser<DirectiveCode>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out DirectiveCode parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        var beginningOfLine = scanner.Position;
        int lineCount = 0;
        while (
            !(
                scanner.MatchWhiteSpace(advance: true)
                && (
                    scanner.Match("#if")
                    || scanner.Match("#define")
                    || scanner.Match("#endif")
                    || scanner.Match("#elif")
                )
            )
            && !scanner.IsEof
        )
        {
            Parsers.Until(ref scanner, '\n', advance: true);
            beginningOfLine = scanner.Position;
            lineCount += 1;
        }
        if (lineCount > 0)
        {
            scanner.Backtrack(beginningOfLine);
            parsed = new DirectiveCode(scanner[position..scanner.Position]);
            return true;
        }
        else
        {
            scanner.Backtrack(position);
            parsed = null!;
            return false;
        }
    }
}

public record struct ConditionalIfDefDirectivesParser : IParser<IfDefDirective>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out IfDefDirective parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        scanner.MatchWhiteSpace(advance: true);
        if (
            scanner.Match("#ifdef", advance: true)
            && scanner.MatchWhiteSpace(1, true)
            && LiteralsParser.Identifier(ref scanner, result, out var id, new(SDSLErrorMessages.SDSL0017, scanner[scanner.Position], scanner.Memory))
            && scanner.MatchUntil("\n", advance: true)
        )
        {
            var cond = new IfDefDirective(id, scanner[position..scanner.Position]);
            parsed = cond;
            return true;
        }
        else
        {
            scanner.Backtrack(position);
            parsed = null!;
            return false;
        }
    }
}
public record struct ConditionalIfNDefDirectivesParser : IParser<IfNDefDirective>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out IfNDefDirective parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        scanner.MatchWhiteSpace(advance: true);
        if (
            scanner.Match("#ifndef", advance: true)
            && scanner.MatchWhiteSpace(1, true)
            && LiteralsParser.Identifier(ref scanner, result, out var id)
            && scanner.MatchUntil("\n", advance: true)
        )
        {
            var cond = new IfNDefDirective(id, scanner[position..scanner.Position]);
            parsed = cond;
            return true;
        }
        else
        {
            scanner.Backtrack(position);
            parsed = null!;
            return false;
        }
    }
}

public record struct ConditionalIfDirectivesParser : IParser<IfDirective>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out IfDirective parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        scanner.MatchWhiteSpace(advance: true);
        if (
            scanner.Match("#if", advance: true)
            && scanner.MatchWhiteSpace(1, true)
            && DirectiveExpressionParser.Expression(ref scanner, result, out var expression)
            && scanner.MatchUntil("\n", advance: true)
        )
        {
            var cond = new IfDirective(expression, scanner[position..scanner.Position]);
            parsed = cond;
            return true;
        }
        else
        {
            scanner.Backtrack(position);
            parsed = null!;
            return false;
        }
    }
}


public record struct ConditionalElifDirectivesParser : IParser<IfDirective>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out IfDirective parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        scanner.MatchWhiteSpace(advance: true);
        if (
            scanner.Match("#elif", advance: true)
            && scanner.MatchWhiteSpace(1, true)
            && DirectiveExpressionParser.Expression(ref scanner, result, out var expression)
            && scanner.MatchUntil("\n", advance: true)
        )
        {
            var cond = new ElifDirective(expression, scanner[position..scanner.Position]);
            parsed = cond;
            return true;
        }
        else
        {
            scanner.Backtrack(position);
            parsed = null!;
            return false;
        }
    }
}
public record struct ConditionalElseDirectivesParser : IParser<ElseDirective>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ElseDirective parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        scanner.MatchWhiteSpace(advance: true);
        if (
            scanner.Match("#else", advance: true)
            && scanner.MatchUntil("\n", advance: true)
        )
        {
            var cond = new ElseDirective(scanner[position..scanner.Position]);
            parsed = cond;
            return true;
        }
        else
        {
            scanner.Backtrack(position);
            parsed = null!;
            return false;
        }
    }
}

public record struct EndifDirectiveParser : IParser<NoNode>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out NoNode parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        scanner.MatchWhiteSpace(advance: true);

        if (
            scanner.Match("#endif", advance: true)
            && scanner.MatchUntil("\n", advance: true)
        )
        {
            parsed = null!;
            return true;
        }
        else
        {
            scanner.Backtrack(position);
            parsed = null!;
            return false;
        }
    }
}


public record struct ObjectDefineDirectiveParser : IParser<ObjectDefineDirective>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ObjectDefineDirective parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        scanner.MatchWhiteSpace(advance: true);

        if (
            scanner.Match("#define", advance: true)
            && scanner.MatchWhiteSpace(1, true)
            && LiteralsParser.Identifier(ref scanner, result, out var identifier)
        )
        {
            if (
                DirectiveExpressionParser.Expression(ref scanner, result, out var expression)
                && scanner.MatchUntil("\n", advance: true)
            )
            {
                parsed = new(identifier, expression, scanner[position..scanner.Position]);
                return true;
            }
            else if(scanner.MatchUntil("\n", advance: true))
            {
                parsed = new(identifier, null, scanner[position..scanner.Position]);
                return true;
            }
            else
            {
                scanner.Backtrack(position);
                parsed = null!;
                return false;
            }
        }
        else
        {
            scanner.Backtrack(position);
            parsed = null!;
            return false;
        }
    }
}


public record struct FunctionDefineDirectiveParser : IParser<FunctionDefineDirective>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out FunctionDefineDirective parsed, in ParseError? orError = null)
        
    {
        var position = scanner.Position;
        scanner.MatchWhiteSpace(advance: true);

        if (
            scanner.Match("#define", advance: true)
            && scanner.MatchWhiteSpace(1, true)
            && LiteralsParser.Identifier(ref scanner, result, out var identifier)
            && scanner.MatchWhiteSpace(advance: true)
            && scanner.Match('(', advance: true)
        )
        {
            scanner.MatchWhiteSpace(advance: true);
            var func = new FunctionDefineDirective(identifier, "", new());
            
            if (
                LiteralsParser.Identifier(ref scanner, result, out var param) 
                && scanner.MatchWhiteSpace(advance: true)
            )
                func.Parameters.Add(param);
            while(
                scanner.Match(',', advance: true)
                && scanner.MatchWhiteSpace(advance: true)
                && LiteralsParser.Identifier(ref scanner, result, out param)
                && scanner.MatchWhiteSpace(advance: true)

            )
                func.Parameters.Add(param);
            if(!scanner.Match(')', advance: true))
            {
                result.Errors.Add(new(SDSLErrorMessages.SDSL0018, scanner[scanner.Position], scanner.Memory));
                scanner.Backtrack(position);
                parsed = null!;
                return false;
            }
            else
            {
                var startPattern = scanner.Position;
                while(!(scanner.IsEof || scanner.Match('\n') || scanner.Match("\r\n")))
                    scanner.Advance(1);
                func.Pattern = scanner.Memory[startPattern..scanner.Position].TrimEnd().TrimStart().ToString();
                if(!scanner.Match('\n', advance: true))
                    scanner.Match("\r\n", advance: true);
                parsed = func;
                return true;
            }
        }
        else
        {
            scanner.Backtrack(position);
            parsed = null!;
            return false;
        }
    }
}