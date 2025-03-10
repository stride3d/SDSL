using Stride.Shaders.Core;
using Stride.Shaders.Spirv.Core;
using Stride.Shaders.Spirv.Core.Buffers;
using static Spv.Specification;

namespace Stride.Shaders.Spirv.Building;


public partial class Builder
{
    public Value OpIAdd(SpirvContext context, Value a, Value b, string? name = null)
    {
        var instruction = Buffer.InsertOpIAdd(Position, context.Bound++, a.TypeId, a.Id, b.Id);
        Position += instruction.WordCount;
        if (instruction.ResultId is int r)
        {
            if (name is not null)
                context.AddName(instruction, name);
            return new(instruction, r, name);            
        }
        else throw new NotImplementedException("Instruction should have result id");
    }
    public Value OpFAdd(SpirvContext context, Value a, Value b, string? name = null)
    {
        var instruction = Buffer.InsertOpFAdd(Position, context.Bound++, a.TypeId, a.Id, b.Id);
        Position += instruction.WordCount;
        if (instruction.ResultId is int r)
        {
            if (name is not null)
                context.AddName(instruction, name);
            return new(instruction, r, name);            
        }
        else throw new NotImplementedException("Instruction should have result id");
    }

    public Value OpISub(SpirvContext context, Value a, Value b, string? name = null)
    {
        var instruction = Buffer.InsertOpISub(Position, context.Bound++, a.TypeId, a.Id, b.Id);
        Position += instruction.WordCount;
        if (instruction.ResultId is int r)
        {
            if (name is not null)
                context.AddName(instruction, name);
            return new(instruction, r, name);            
        }
        else throw new NotImplementedException("Instruction should have result id");
    }
    public Value OpFSub(SpirvContext context, Value a, Value b, string? name = null)
    {
        var instruction = Buffer.InsertOpFSub(Position, context.Bound++, a.TypeId, a.Id, b.Id);
        Position += instruction.WordCount;
        if (instruction.ResultId is int r)
        {
            if (name is not null)
                context.AddName(instruction, name);
            return new(instruction, r, name);            
        }
        else throw new NotImplementedException("Instruction should have result id");
    }

    public Value OpIMul(SpirvContext context, Value a, Value b, string? name = null)
    {
        var instruction = Buffer.InsertOpIMul(Position, context.Bound++, a.TypeId, a.Id, b.Id);
        Position += instruction.WordCount;
        if (instruction.ResultId is int r)
        {
            if (name is not null)
                context.AddName(instruction, name);
            return new(instruction, r, name);            
        }
        else throw new NotImplementedException("Instruction should have result id");
    }

    public Value OpFMul(SpirvContext context, Value a, Value b, string? name = null)
    {
        var instruction = Buffer.InsertOpFMul(Position, context.Bound++, a.TypeId, a.Id, b.Id);
        Position += instruction.WordCount;
        if (instruction.ResultId is int r)
        {
            if (name is not null)
                context.AddName(instruction, name);
            return new(instruction, r, name);            
        }
        else throw new NotImplementedException("Instruction should have result id");
    }



    public Value OpFDiv(SpirvContext context, Value a, Value b, string? name = null)
    {
        var instruction = Buffer.InsertOpFDiv(Position, context.Bound++, a.TypeId, a.Id, b.Id);
        Position += instruction.WordCount;
        if (instruction.ResultId is int r)
        {
            if (name is not null)
                context.AddName(instruction, name);
            return new(instruction, r, name);            
        }
        else throw new NotImplementedException("Instruction should have result id");
    }
    


    public void Return(in Value? value = null)
    {
        Position += value switch 
        {
            Value v => Buffer.InsertOpReturnValue(Position, v.Id).WordCount,
            _ => Buffer.InsertOpReturn(Position).WordCount
        };
        CleanBlock();
    }

    public void CleanBlock()
    {
        if((Buffer.Span[Position] & 0xFFFF) == (int)SDSLOp.OpUnreachable)
        {
            var size = Buffer.Span[Position] >> 16;
            Buffer.Remove(Position);
            Position -= size;
        }
    }
}