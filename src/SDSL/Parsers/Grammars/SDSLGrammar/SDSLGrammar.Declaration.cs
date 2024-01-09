using Eto.Parse;
using Eto.Parse.Parsers;
using static Eto.Parse.Terminals;
using static SDSL.Parsing.Grammars.CommonParsers;

namespace SDSL.Parsing.Grammars.SDSL;
public partial class SDSLGrammar : Grammar
{
    public SequenceParser ShaderCompositionDeclaration = new() { Name = "ShaderCompositionDeclaration" };
    public SequenceParser ShaderValueDeclaration = new() { Name = "ShaderValueDeclaration" };
    public SequenceParser ConstantBufferValueDeclaration = new(){Name = "ConstantBufferValueDeclaration"};
    public SequenceParser StructDefinition = new(){Name = "StructDefinition"};

    public SDSLGrammar UsingDeclarators()
    {
        var ws  = WhiteSpace.Repeat(0);
        Inner = ShaderValueDeclaration & Semi;
        // Inner = Identifier.Then(LeftBracket).Then(PrimaryExpression).Then(RightBracket).Then(";");
        return this;
    }
    public void CreateDeclarators()
    {
        var ws = WhiteSpace.Repeat(0);
        var ws1 = WhiteSpace.Repeat(1);


        ShaderCompositionDeclaration.Add(
            Compose,
            Identifier,
            Identifier,
            Literal("[]").Optional().WithName("Array"),
            Semi
        );
        ShaderCompositionDeclaration.SeparatedBy(ws);


        var declare = new SequenceParser();
        declare.Add(
            ValueTypes,
            ws1,
            Identifier.Named("Name"),
            ws,
            Semi
        );

        var packoffset = new SequenceParser();
        packoffset.Add(
            Packoffset,
            LeftParen,
            Identifier,
            (Dot & Identifier).Repeat(0),
            RightParen
        );
        packoffset.Separator = ws;

        var register = new SequenceParser();
        register.Add(
            Register,
            LeftParen,
            Identifier.Repeat(0).SeparatedBy(ws & Comma & ws),
            RightParen
        );
        register.Separator = ws;

        var supplement = new SequenceParser();
        supplement.Add(
            Colon,
            ws,
            packoffset.Named("PackOffset")
            | register
            | Identifier.Named("Semantic")
        );

        var staging =
            Stage.NotFollowedBy(ws1 & CommonParsers.Stream).Named("Stage")
            | Stage.Named("Stage") & ws1 & CommonParsers.Stream.Named("Stream")
            | CommonParsers.Stream.Named("Stream");

        var valueDeclaration = new SequenceParser();
        valueDeclaration.Add(
            ~(staging & ws1),
            ~(StorageFlag & ws1),
            ValueTypes,
            ws1,
            Identifier
        );

        var assignOrSupplement = new AlternativeParser(
            supplement,
            (AssignOperators & PrimaryExpression).SeparatedBy(ws).NotFollowedBy(ws & supplement),
            (AssignOperators & PrimaryExpression & supplement).SeparatedBy(ws)
        );

        ShaderValueDeclaration.Add(
            valueDeclaration,
            ~assignOrSupplement,
            Semi
        );
        ShaderValueDeclaration.Separator = ws;

        ConstantBufferValueDeclaration.Add(
            valueDeclaration,
            assignOrSupplement.Optional(),
            Semi
        );

        ConstantBufferValueDeclaration.Separator = ws;

        StructDefinition.Add(
            Struct & ws1 & Identifier.Named("StructName"),
            LeftBrace,
            declare.Named("Declaration").Repeat(0).SeparatedBy(ws).Named("Fields"),
            RightBrace,
            Semi
        );
        StructDefinition.Separator = ws;
    }
}