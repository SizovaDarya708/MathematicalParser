using ScienceLibrary.MathParser.Expressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScienceLibrary.MathParser.ExpressionParsers
{
    /// <summary>
    /// Функция EXP - это одна из математических и тригонометрических функций. 
    /// Она возвращает значение константы e, возведенной в заданную степень. 
    /// </summary>
    public class ExpParser : FunctionParser<Exp>
    {
        public ExpParser(MathParser mathParser) : base(nameof(Exp), 1, mathParser)
        {
        }
    }
}
