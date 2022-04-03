using ScienceLibrary.MathParser.Expressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScienceLibrary.MathParser.ExpressionParsers
{
    /// <summary>
    ///  Тригонометрическая функция угла,
    /// в прямоугольном треугольнике равная прилежащего катета к противолежащему
    /// </summary>
    public class CtgParser : FunctionParser<Ctg>
    {
        public CtgParser(MathParser mathParser) : base(nameof(Ctg), 1, mathParser)
        {
        }
    }
}
