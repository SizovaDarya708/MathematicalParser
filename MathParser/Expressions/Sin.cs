﻿using ScienceLibrary.MathParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceLibrary.MathParser.Expressions
{
    public record Sin : IFunction
    {
        public string Name => nameof(Sin);
        public IExpression Argument => Arguments.FirstOrDefault();
        public ICollection<IExpression> Arguments { get; init; }
        public IEnumerable<Variable> Variables { get; init; }

        public double ComputeValue(ICollection<Parameter> variables)
        {
            var argumentValue = Argument.ComputeValue(variables);
            var result = Math.Sin(argumentValue);
            return result;
        }
    }
}
