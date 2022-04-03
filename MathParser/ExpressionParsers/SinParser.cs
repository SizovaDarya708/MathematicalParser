using ScienceLibrary.MathParser.Expressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScienceLibrary.MathParser.ExpressionParsers
{
    /// <summary>
    /// Тригонометрическая функция угла,
    /// в прямоугольном треугольнике равная отношению катета противолежащего угла к гипотенузе.
    /// </summary>
    public class SinParser : FunctionParser<Sin>
    {
        public SinParser(MathParser mathParser) : base(nameof(Sin), 1, mathParser)
        {
        }
    }
}
