using ScienceLibrary.MathParser.Expressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScienceLibrary.MathParser.ExpressionParsers
{
    /// <summary>
    /// Показатель степени, в к-рую надо возвести число, называемое основанием,
    /// чтобы получить данное число.
    /// </summary>
    public class LogParser : FunctionParser<Log>
    {
        public LogParser(MathParser mathParser) : base(nameof(Log), 2, mathParser)
        {
        }
    }
}
