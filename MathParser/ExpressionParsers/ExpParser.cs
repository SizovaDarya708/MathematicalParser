using ScienceLibrary.MathParser.Expressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScienceLibrary.MathParser.ExpressionParsers
{
    public class ExpParser : FunctionParser<Exp>
    {
        public ExpParser(MathParser mathParser) : base(nameof(Exp), 1, mathParser)
        {
        }
    }
}
