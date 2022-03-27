using System;
using System.Collections.Generic;
using System.Text;

namespace ScienceLibrary.MathParser
{
    public interface IConst : IMathParserEntity
    {
        double Value { get;}
    }
}
