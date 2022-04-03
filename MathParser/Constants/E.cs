using System;
using System.Collections.Generic;
using System.Text;

namespace ScienceLibrary.MathParser.Constants
{
    /// <summary>
    /// основание натурального логарифма, математическая константа, иррациональное и трансцендентное число.
    /// Приблизительно равно 2,71828.
    /// Называют числом Эйлера или числом Непера. Обозначается строчной латинской буквой «e».
    /// </summary>
    public class E: IConst
    {
        public string Name => "e";

        public double Value => Math.E;
    }
}
