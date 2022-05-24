﻿using Eto.Parse;
using Stride.Shader.Parsing.AST.Directives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Stride.Shader.Parsing.AST.Directives.OperatorTokenExtensions;

namespace Stride.Shader.Parsing.AST.Shader;

public class Operation : ShaderToken
{
    public OperatorToken Op { get; set; }
    public ShaderToken Left { get; set; }
    public ShaderToken Right { get; set; }
}

public class PrefixIncrement : ShaderToken
{
    public string Operator { get; set; }
    public string Name { get; set; }
    public PrefixIncrement(Match m)
    {
        Match = m;
        Operator = m.Matches[0].StringValue;
        Name = m.Matches[1].StringValue;
    }
}

public class CastExpression : ShaderToken
{
    public TypeNameLiteral Target { get; set; }
    public ShaderToken From { get; set; }
    public CastExpression(Match m)
    {
        Target = new TypeNameLiteral(m.Matches[0]);
        From = GetToken(m.Matches[1]);
    }
}

public class MulExpression : Operation
{
    public static MulExpression Create(Match m)
    {
        var first = new MulExpression
        {
            Match = m,
            Op = m.Matches[1].StringValue.AsOperatorToken(),
            Left = GetToken(m.Matches[0]),
            Right = GetToken(m.Matches[2])
        };

        MulExpression tmp = first;
        for (int i = 3; i < m.Matches.Count - 2; i += 2)
        {
            tmp = new MulExpression
            {
                Match = m,
                Op = m.Matches[i].StringValue.AsOperatorToken(),
                Left = tmp,
                Right = GetToken(m.Matches[i + 1])
            };
        }
        return tmp;
    }
}

public class SumExpression : Operation
{
    public static SumExpression Create(Match m)
    {
        var first = new SumExpression
        {
            Match = m,
            Op = m.Matches[1].StringValue.AsOperatorToken(),
            Left = GetToken(m.Matches[0]),
            Right = GetToken(m.Matches[2])
        };

        SumExpression tmp = first;
        for (int i = 3; i < m.Matches.Count - 2; i += 2)
        {
            tmp = new SumExpression
            {
                Match = m,
                Op = m.Matches[i].StringValue.AsOperatorToken(),
                Left = tmp,
                Right = GetToken(m.Matches[i + 1])
            };
        }
        return tmp;
    }
}

public class ShiftExpression : Operation
{
    public static ShiftExpression Create(Match m)
    {
        var first = new ShiftExpression
        {
            Match = m,
            Op = m.Matches[1].StringValue.AsOperatorToken(),
            Left = GetToken(m.Matches[0]),
            Right = GetToken(m.Matches[2])
        };

        ShiftExpression tmp = first;
        for (int i = 3; i < m.Matches.Count - 2; i += 2)
        {
            tmp = new ShiftExpression
            {
                Match = m,
                Op = m.Matches[i].StringValue.AsOperatorToken(),
                Left = tmp,
                Right = GetToken(m.Matches[i + 1])
            };
        }
        return tmp;
    }
}

public class AndExpression : Operation
{
    public static AndExpression Create(Match m)
    {
        var first = new AndExpression
        {
            Match = m,
            Op = m.Matches[1].StringValue.AsOperatorToken(),
            Left = GetToken(m.Matches[0]),
            Right = GetToken(m.Matches[2])
        };

        AndExpression tmp = first;
        for (int i = 3; i < m.Matches.Count - 2; i += 2)
        {
            tmp = new AndExpression
            {
                Match = m,
                Op = m.Matches[i].StringValue.AsOperatorToken(),
                Left = tmp,
                Right = GetToken(m.Matches[i + 1])
            };
        }
        return tmp;
    }
}
public class XorExpression : Operation
{
    public static XorExpression Create(Match m)
    {
        var first = new XorExpression
        {
            Match = m,
            Op = m.Matches[1].StringValue.AsOperatorToken(),
            Left = GetToken(m.Matches[0]),
            Right = GetToken(m.Matches[2])
        };

        XorExpression tmp = first;
        for (int i = 3; i < m.Matches.Count - 2; i += 2)
        {
            tmp = new XorExpression
            {
                Match = m,
                Op = m.Matches[i].StringValue.AsOperatorToken(),
                Left = tmp,
                Right = GetToken(m.Matches[i + 1])
            };
        }
        return tmp;
    }
}
public class OrExpression : Operation
{
    public static OrExpression Create(Match m)
    {
        var first = new OrExpression
        {
            Match = m,
            Op = m.Matches[1].StringValue.AsOperatorToken(),
            Left = GetToken(m.Matches[0]),
            Right = GetToken(m.Matches[2])
        };

        OrExpression tmp = first;
        for (int i = 3; i < m.Matches.Count - 2; i += 2)
        {
            tmp = new OrExpression
            {
                Match = m,
                Op = m.Matches[i].StringValue.AsOperatorToken(),
                Left = tmp,
                Right = GetToken(m.Matches[i + 1])
            };
        }
        return tmp;
    }
}

public class TestExpression : Operation
{
    public static TestExpression Create(Match m)
    {
        var first = new TestExpression
        {
            Match = m,
            Op = m.Matches[1].StringValue.AsOperatorToken(),
            Left = GetToken(m.Matches[0]),
            Right = GetToken(m.Matches[2])
        };

        TestExpression tmp = first;
        for (int i = 3; i < m.Matches.Count - 2; i += 2)
        {
            tmp = new TestExpression
            {
                Match = m,
                Op = m.Matches[i].StringValue.AsOperatorToken(),
                Left = tmp,
                Right = GetToken(m.Matches[i + 1])
            };
        }
        return tmp;
    }
}

public class EqualsExpression : Operation
{
    public static EqualsExpression Create(Match m)
    {
        var first = new EqualsExpression
        {
            Match = m,
            Op = m.Matches[1].StringValue.AsOperatorToken(),
            Left = GetToken(m.Matches[0]),
            Right = GetToken(m.Matches[2])
        };

        EqualsExpression tmp = first;
        for (int i = 3; i < m.Matches.Count - 2; i += 2)
        {
            tmp = new EqualsExpression
            {
                Match = m,
                Op = m.Matches[i].StringValue.AsOperatorToken(),
                Left = tmp,
                Right = GetToken(m.Matches[i + 1])
            };
        }
        return tmp;
    }
}

public class LogicalAndExpression : Operation
{
    public static LogicalAndExpression Create(Match m)
    {
        var first = new LogicalAndExpression
        {
            Match = m,
            Op = m.Matches[1].StringValue.AsOperatorToken(),
            Left = GetToken(m.Matches[0]),
            Right = GetToken(m.Matches[2])
        };

        LogicalAndExpression tmp = first;
        for (int i = 3; i < m.Matches.Count - 2; i += 2)
        {
            tmp = new LogicalAndExpression
            {
                Match = m,
                Op = m.Matches[i].StringValue.AsOperatorToken(),
                Left = tmp,
                Right = GetToken(m.Matches[i + 1])
            };
        }
        return tmp;
    }

}
public class LogicalOrExpression : Operation
{
    public static LogicalOrExpression Create(Match m)
    {
        var first = new LogicalOrExpression
        {
            Match = m,
            Op = m.Matches[1].StringValue.AsOperatorToken(),
            Left = GetToken(m.Matches[0]),
            Right = GetToken(m.Matches[2])
        };

        LogicalOrExpression tmp = first;
        for (int i = 3; i < m.Matches.Count - 2; i += 2)
        {
            tmp = new LogicalOrExpression
            {
                Match = m,
                Op = m.Matches[i].StringValue.AsOperatorToken(),
                Left = tmp,
                Right = GetToken(m.Matches[i + 1])
            };
        }
        return tmp;
    }
}

public class ConditionalExpression : ShaderToken
{
    public ShaderToken Condition { get; set; }
    public ShaderToken TrueOutput { get; set; }
    public ShaderToken FalseOutput { get; set; }


    public ConditionalExpression(Match m)
    {
        Condition = GetToken(m.Matches[0]);
        TrueOutput = GetToken(m.Matches[1]);
        FalseOutput = GetToken(m.Matches[2]);
    }
}