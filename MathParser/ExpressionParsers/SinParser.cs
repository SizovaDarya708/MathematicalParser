using ScienceLibrary.MathParser.Expressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScienceLibrary.MathParser.ExpressionParsers
{
    public class SinParser : FunctionParser<Sin>
    {
        public SinParser(MathParser mathParser) : base(nameof(Sin), 1, mathParser)
        {
        }
    }
}
