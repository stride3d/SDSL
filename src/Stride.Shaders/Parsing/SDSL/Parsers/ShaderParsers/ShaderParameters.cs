using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;


public record struct ParameterParsers : IParser<ParameterListNode>
{
    public bool Match(ref Scanner scanner, ParseResult result, out ParameterListNode parsed, in ParseError? orError = null)
    {
        throw new NotImplementedException();
    }
    public static bool Declarations(ref Scanner scanner, ParseResult result, out ShaderParameterDeclarations parsed, in ParseError? orError = null)
        => new ParameterDeclarationsParser().Match(ref scanner, result, out parsed, in orError);
    public static bool Values(ref Scanner scanner, ParseResult result, out ShaderExpressionList parsed, in ParseError? orError = null)
        => new ParameterListParser().Match(ref scanner, result, out parsed, in orError);

    public static bool GenericsList(ref Scanner scanner, ParseResult result, out ShaderExpressionList parsed, in ParseError? orError = null)
        => new GenericsListParser().Match(ref scanner, result, out parsed, in orError);
    public static bool GenericsValue(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
        => new GenericsValueParser().Match(ref scanner, result, out parsed, in orError);
}


public record struct ParameterDeclarationsParser : IParser<ShaderParameterDeclarations>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderParameterDeclarations parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        List<ShaderParameter> parameters = [];

        do
        {
            if (
                Parsers.FollowedBy(ref scanner, result, LiteralsParser.TypeName, out TypeName typename, withSpaces: true, advance: true)
                && scanner.MatchWhiteSpace(minimum: 1, advance: true)
                && LiteralsParser.Identifier(ref scanner, result, out var name)
                && scanner.MatchWhiteSpace(advance: true)
            )
            {
                parameters.Add(new(typename, name));
            }
            else return Parsers.Exit(ref scanner, result, out parsed, position);
        }
        while (!scanner.IsEof && scanner.Match(',', advance: true));
        parsed = new(scanner[position..scanner.Position]) { Parameters = parameters };
        return true;
    }
}
public record struct ParameterListParser : IParser<ShaderExpressionList>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderExpressionList parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        List<Expression> values = [];
        do
        {
            scanner.MatchWhiteSpace(advance: true);
            if (ExpressionParser.Expression(ref scanner, result, out var expr))
                values.Add(expr);
            else if (LiteralsParser.StringLiteral(ref scanner, result, out var str))
                values.Add(str);
            else 
                break;
            // else return CommonParsers.Exit(ref scanner, result, out parsed, position, new(SDSLParsingMessages.SDSL0001, scanner[scanner.Position], scanner.Memory));
        }
        while (!scanner.IsEof && scanner.FollowedBy(',', advance: true));

        parsed = new(scanner[position..scanner.Position])
        {
            Values = values
        };
        return true;
    }
}

public record struct GenericsListParser : IParser<ShaderExpressionList>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderExpressionList parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (ParameterParsers.GenericsValue(ref scanner, result, out var parameter))
        {
            parsed = new(scanner[position..scanner.Position]);
            parsed.Values.Add(parameter);
            scanner.MatchWhiteSpace(advance: true);
            while (scanner.Match(',', advance: true))
            {
                scanner.MatchWhiteSpace(advance: true);
                if (ParameterParsers.GenericsValue(ref scanner, result, out var other, new("Expecting at least one generics value", scanner[scanner.Position], scanner.Memory)))
                {
                    parsed.Values.Add(other);
                    scanner.MatchWhiteSpace(advance: true);
                }
            }
            return true;
        }
        return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }
}

public record struct GenericsValueParser : IParser<Expression>
{
    public readonly bool Match(ref Scanner scanner, ParseResult result, out Expression parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (LiteralsParser.Number(ref scanner, result, out var number))
        {
            parsed = number;
            return true;
        }
        else if (LiteralsParser.Boolean(ref scanner, result, out var boolean))
        {
            parsed = boolean;
            return true;
        }
        else if (LiteralsParser.Vector(ref scanner, result, out var vector))
        {
            parsed = vector;
            return true;
        }
        else if (LiteralsParser.StringLiteral(ref scanner, result, out var stringLiteral))
        {
            parsed = stringLiteral;
            return true;
        }
        else if (PostfixParser.Postfix(ref scanner, result, out var accessor))
        {
            if (accessor is AccessorChainExpression ae && ae.Source is Identifier)
            {
                parsed = accessor;
                return true;
            }
            scanner.Backtrack(position);
        }
        if (LiteralsParser.Identifier(ref scanner, result, out var identifier))
        {
            // previous parser might have matched somehow and advanced the scanner

            parsed = identifier;
            return true;
        }
        return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }

}