using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Core
{
    public interface IFigure
    {
        double Area();

        void SetSides(int[] sides);
    }
}
