﻿using Eto.Parse;
using Stride.Shader.Parsing.AST.Shader;
using Stride.Shader.Parsing.Grammars.Expression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride.Shader.Parsing.AST.Directives;


public class DirectiveToken
{
	public Match Match { get; set; }
	public static DirectiveToken GetToken(Match match)
	{
		var tmp = match;
		while (tmp.Matches.Count == 1)
			tmp = tmp.Matches.First();

		return tmp.Name switch
		{
			"Ternary" => new ConditionalExpression(tmp),
			"LogicalOrExpression" => LogicalOrExpression.Create(tmp),
			"LogicalAndExpression" => LogicalAndExpression.Create(tmp),
			"EqualsExpression" => EqualsExpression.Create(tmp),
			"TestExpression" => TestExpression.Create(tmp),
			"OrExpression" => OrExpression.Create(tmp),
			"XorExpression" => XorExpression.Create(tmp),
			"AndExpression" => AndExpression.Create(tmp),
			"ShiftExpression" => ShiftExpression.Create(tmp),
			"SumExpression" => SumExpression.Create(tmp),
			"MulExpression" => MulExpression.Create(tmp),
			"CastExpression" => new CastExpression(tmp),
			"PrefixIncrement" => throw new NotImplementedException("prefix implement not implemented"),
			"IntegerValue" or "FloatValue" => new NumberLiteral(tmp),
			"VariableTerm" => new VariableNameLiteral(tmp),
			"ValueTypes" or "TypeName" => new TypeNameLiteral(tmp),
			"Boolean" => new BoolLiteral(tmp),
			_ => throw new NotImplementedException()
		};
	}
}