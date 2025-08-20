using AngleSharp.Common;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using System.Text;
using System.Text.Json;

namespace Stride.Shaders.Spirv.Generators;


public record struct SpirvInstructionData
{
    public string Name { get; }
    public string OpCode { get; }
    public string Category { get; }
    public string Description { get; }
    public EquatableList<string> Operands { get; }
    public EquatableList<string> Returns { get; }

    public SpirvInstructionData(string name, string opcode, string category, string description, List<string> operands, List<string> returns)
    {
        Name = name;
        OpCode = opcode;
        Category = category;
        Description = description;
        Operands = new(operands);
        Returns = new(returns);
    }
}


public partial class SPVGenerator : IIncrementalGenerator
{
    public void GenerateStructs(IncrementalGeneratorInitializationContext context)
    {
        IncrementalValueProvider<SpirvGrammar> instructionsData =
            context.AdditionalTextsProvider
            .Where(file => Path.GetFileName(file.Path) == "spirv.core.grammar.json")
            .Select((file, _) => file.GetText()?.ToString())
            .Where(text => text is not null)
            .Select((text, _) =>
                {
                    var result = JsonSerializer.Deserialize<SpirvGrammar>(text!, options);
                    if (result is SpirvGrammar grammar)
                    {
                        var list = new List<OperandData>(24);
                        var dict = grammar.OperandKinds.ToDictionary(x => x.Kind, x => x.Category);
                        if (grammar.Instructions.AsList() is List<InstructionData> instructions)
                        {
                            for (int i = 0; i < instructions.Count; i++)
                            {
                                list.Clear();
                                if (instructions[i].Operands is EquatableList<OperandData> operands)
                                {
                                    foreach (var op in operands)
                                        list.Add(op with { Class = dict[op.Kind] });
                                    instructions[i] = instructions[i] with { Operands = list };
                                }
                            }
                        }
                    }
                    return result;
                })
            .Collect()
            .Select((grammarArray, _) => grammarArray[0] ?? throw new Exception("Grammar is null ?"));


        context.RegisterImplementationSourceOutput(instructionsData,
            static (spc, source) => Execute(source, spc));

    }

    public static void Execute(SpirvGrammar grammar, SourceProductionContext spc)
    {
        StringBuilder builder = new();
        builder
        .AppendLine("using static Spv.Specification;")
        .AppendLine()
        .AppendLine("namespace Stride.Shaders.Spirv.Core;")
        .AppendLine()
        .AppendLine();
        if (grammar.Instructions.AsList() is List<InstructionData> instructions)
        {
            foreach (var instruction in instructions)
            {
                if (instruction.OpName.StartsWith("OpCopyMemory"))
                    continue;
                builder.AppendLine($"public ref struct {instruction.OpName} : IWrapperInstruction")
                .AppendLine("{")
                .AppendLine("public RefInstruction Inner { get; set; }")
                .AppendLine("public int WordCount => Inner.WordCount;");
                if (instruction.Operands.AsList() is List<OperandData> operands && operands.Count > 0)
                {
                    foreach (var operand in operands)
                    {
                        string fieldName;
                        string operandName = ConvertOperandName(operand.Name ?? ConvertKindToName(operand.Kind), operand.Quantifier);
                        if (operand.Name is null or "")
                            fieldName = ConvertKindToName(operand.Kind, false);
                        else
                        {
                            var nameBuilder = new StringBuilder();
                            bool first = true;
                            foreach (var c in operand.Name)
                            {
                                if (char.IsLetterOrDigit(c) || c == '_')
                                {
                                    nameBuilder.Append(first ? char.ToUpperInvariant(c) : c);
                                    first &= false;
                                }

                            }
                            fieldName = nameBuilder.ToString();
                        }
                        if (operand.Kind == "LiteralContextDependentNumber")
                            continue;
                        else if (operand.Kind == "LiteralInteger" || operand.Kind == "LiteralExtInstInteger" || operand.Kind == "LiteralSpecConstantOpInteger")
                            builder.AppendLine($"public LiteralInteger {fieldName} => Inner.GetOperand<LiteralInteger>(\"{operandName}\") ?? default;");
                        else if (operand.Class == "BitEnum")
                            builder.AppendLine($"public {operand.Kind}Mask {fieldName} => Inner.GetEnumOperand<{operand.Kind}Mask>(\"{operandName}\");");
                        else if (operand.Class == "ValueEnum")
                            builder.AppendLine($"public {operand.Kind} {fieldName} => Inner.GetEnumOperand<{operand.Kind}>(\"{operandName}\");");
                        else
                            builder.AppendLine($"public {operand.Kind} {fieldName} => Inner.GetOperand<{operand.Kind}>(\"{operandName}\") ?? default;");
                    }
                }


                builder
                .AppendLine()
                .AppendLine($"public {instruction.OpName}(RefInstruction instruction) => Inner = instruction;")
                .AppendLine($"public {instruction.OpName}(Span<int> buffer) => Inner = RefInstruction.ParseRef(buffer);")
                .AppendLine($"public static implicit operator IdRef({instruction.OpName} instruction) => new(instruction.Inner.ResultId ?? throw new Exception(\"Instruction has no result id\"));")
                .AppendLine($"public static implicit operator IdResultType({instruction.OpName} instruction) => new(instruction.Inner.ResultId ?? throw new Exception(\"Instruction has no result id\"));")
                .AppendLine($"public static implicit operator {instruction.OpName}(Span<int> buffer) => new {instruction.OpName}(buffer);")
                .AppendLine($"public static implicit operator {instruction.OpName}(Instruction instruction) => new {instruction.OpName}(instruction.AsRef());")
                .AppendLine($"public static implicit operator {instruction.OpName}(RefInstruction instruction) => new {instruction.OpName}(instruction);");
                builder.AppendLine("}");

            }
        }
        spc.AddSource(
            $"Instructions.g.cs",
            SourceText.From(
                SyntaxFactory
                .ParseCompilationUnit(builder.ToString())
                .NormalizeWhitespace()
                .ToFullString(),
                Encoding.UTF8
            )
        );
    }
}