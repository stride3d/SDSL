using Stride.Shaders.Parsing.SDSL.AST;

namespace Stride.Shaders.Parsing.SDSL;


public record struct BufferParsers : IParser<ShaderBuffer>
{
    public static bool Buffer(ref Scanner scanner, ParseResult result, out ShaderBuffer parsed, in ParseError? orError = null)
        => new BufferParsers().Match(ref scanner, result, out parsed, orError);

    public readonly bool Match(ref Scanner scanner, ParseResult result, out ShaderBuffer parsed, in ParseError? orError = null)
    {
        return Parsers.Alternatives(
            ref scanner, result, out parsed, in orError,
            CBuffer,
            TBuffer,
            RGroup
        );
    }

    public static bool TBuffer(ref Scanner scanner, ParseResult result, out ShaderBuffer parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (scanner.Match("tbuffer", advance: true) && scanner.MatchWhiteSpace(minimum: 1, advance: true))
        {
            if (
                BufferName(ref scanner, result, out var identifiers, new(SDSLErrorMessages.SDSL0017, scanner[scanner.Position], scanner.Memory))
                && scanner.MatchWhiteSpace(advance: true)
            )
            {
                if (scanner.Match('{'))
                {
                    List<ShaderMember> members = [];
                    scanner.MatchWhiteSpace(advance: true);
                    do
                    {
                        if (Member(ref scanner, result, out var member) && scanner.MatchWhiteSpace(advance: true))
                            members.Add(member);
                    }
                    while (!(scanner.MatchLetter() || scanner.Match('_')));
                    if (scanner.Match('}', advance: true))
                    {
                        parsed = new TBuffer(identifiers, scanner[position..scanner.Position])
                        {
                            Members = members
                        };
                        return true;
                    }
                }
                else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
            }
        }
        return Parsers.Exit(ref scanner, result, out parsed, position, orError); ;
    }

    public static bool CBuffer(ref Scanner scanner, ParseResult result, out ShaderBuffer parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (scanner.Match("cbuffer", advance: true) && scanner.MatchWhiteSpace(minimum: 1, advance: true))
        {
            if (
                BufferName(ref scanner, result, out var identifiers, new(SDSLErrorMessages.SDSL0017, scanner[scanner.Position], scanner.Memory))
                && scanner.MatchWhiteSpace(advance: true)
            )
            {
                if (scanner.Match('{', advance: true))
                {
                    List<ShaderMember> members = [];
                    scanner.MatchWhiteSpace(advance: true);
                    while (!scanner.IsEof && !scanner.Match('}', advance: true))
                    {
                        if (
                            Member(ref scanner, result, out var member)
                            && scanner.MatchWhiteSpace(advance: true)
                        )
                            members.Add(member);
                        else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0001, scanner[scanner.Position], scanner.Memory));
                    }
                    if (scanner.IsEof)
                        return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0043, scanner[scanner.Position], scanner.Memory));
                    parsed = new CBuffer(identifiers, scanner[position..scanner.Position])
                    {
                        Members = members
                    };
                    return true;

                }
                else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
            }
        }
        return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }

    public static bool RGroup(ref Scanner scanner, ParseResult result, out ShaderBuffer parsed, in ParseError? orError = null)
    {
        var position = scanner.Position;
        if (scanner.Match("rgroup", advance: true) && scanner.MatchWhiteSpace(minimum: 1, advance: true))
        {
            if (
                BufferName(ref scanner, result, out var identifiers)
                && scanner.MatchWhiteSpace(advance: true)
            )
            {
                if (scanner.Match('{', advance: true))
                {
                    List<ShaderMember> members = [];
                    scanner.MatchWhiteSpace(advance: true);
                    while (!scanner.IsEof && !scanner.Match('}', advance: true))
                    {
                        if (
                            Member(ref scanner, result, out var member)
                            && scanner.MatchWhiteSpace(advance: true)
                        )
                            members.Add(member);
                        else return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0001, scanner[scanner.Position], scanner.Memory));
                    }
                    if (scanner.IsEof)
                        return Parsers.Exit(ref scanner, result, out parsed, position, new(SDSLErrorMessages.SDSL0043, scanner[scanner.Position], scanner.Memory));
                    parsed = new RGroup(identifiers, scanner[position..scanner.Position])
                    {
                        Members = members
                    };
                    return true;

                }
                else return Parsers.Exit(ref scanner, result, out parsed, position, orError);
            }
        }
        return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }

    public static bool Member(ref Scanner scanner, ParseResult result, out ShaderMember parsed, in ParseError? orError = null)
    {
        scanner.MatchWhiteSpace(advance: true);
        var position = scanner.Position;
        var isStage = false;
        StreamKind streamKind = StreamKind.None;
        bool hasAttributes = ShaderAttributeListParser.AttributeList(ref scanner, result, out var attributes, orError);
        var tmp = scanner.Position;
        if (scanner.Match("stage", advance: true) && scanner.MatchWhiteSpace(minimum: 1, advance: true))
        {
            isStage = true;
            tmp = scanner.Position;
        }
        else
            scanner.Backtrack(tmp);
        if (
            Parsers.TypeNameIdentifierArraySizeValue(ref scanner, result, out var typeName, out var identifier, out var value, advance: true)
            && scanner.FollowedBy(";", withSpaces: true, advance: true)
        )
        {
            parsed = new ShaderMember(typeName, identifier, value, scanner[position..scanner.Position], isStage, streamKind);
            if (hasAttributes)
                parsed.Attributes = attributes.Attributes;
            return true;
        }
        return Parsers.Exit(ref scanner, result, out parsed, position, orError);
    }

    public static bool BufferName(ref Scanner scanner, ParseResult result, out Identifier parsed, in ParseError? orError = null)
    {
        parsed = null!;
        if(Parsers.Repeat(ref scanner, result, LiteralsParser.Identifier, out List<Identifier> identifiers, 1, true, ".", orError))
        {
            parsed = new Identifier(string.Join(".", identifiers.Select(i => i.Name)), scanner[identifiers[0].Info.Range.Start..identifiers[^1].Info.Range.End]);
            return true;
        }
        else return false;
    }
}