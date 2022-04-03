using System;

namespace ScienceLibrary.MathParser.Constants
{
    /// <summary>
    /// это отношение длины окружности к ее диаметру. Обозначается оно буквой греческого алфавита π;
    /// </summary>
    public class PI : IConst
    {
        public string Name => "pi";

        public double Value => Math.PI;
    }
}
