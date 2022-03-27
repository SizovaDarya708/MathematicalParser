﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScienceLibrary.MathParser.Expressions
{
    public record Log : IFunction
    {
        public string Name => nameof(Log);

        public IExpression Base => Arguments.FirstOrDefault();
        public IExpression Argument => Arguments.LastOrDefault();
        public ICollection<IExpression> Arguments { get; init; }
        public IEnumerable<Variable> Variables { get; init; }

        public double ComputeValue(ICollection<Parameter> variables)
        {
            var @base = Base.ComputeValue(variables);

            var argument = Argument.ComputeValue(variables);

            var result = Math.Log(argument, @base);

            return result;
        }
    }
}
