using ScienceLibrary.MathParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceLibrary.MathParser.Expressions
{
    public record Cos : IFunction
    {
        public string Name => nameof(Cos);
        public IExpression Argument => Arguments.FirstOrDefault();
        public ICollection<IExpression> Arguments { get; init; }
        public IEnumerable<Variable> Variables { get; init; }

        public double ComputeValue(ICollection<Parameter> variables)
        {
            return Math.Cos(Argument.ComputeValue(variables));
        }
    }
}
