using ScienceLibrary.MathParser.Expressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScienceLibrary.MathParser.ExpressionParsers
{
    public class LogParser : FunctionParser<Log>
    {
        public LogParser(MathParser mathParser) : base(nameof(Log), 2, mathParser)
        {
        }
    }
}
