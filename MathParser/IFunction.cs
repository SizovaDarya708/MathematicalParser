using System;
using System.Collections.Generic;
using System.Text;

namespace ScienceLibrary.MathParser
{
    public interface IFunction: IExpression
    {
        ICollection<IExpression> Arguments { get; init; }
    }
}
