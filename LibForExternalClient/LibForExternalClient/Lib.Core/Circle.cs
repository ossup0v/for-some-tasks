using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Core
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public void SetSides(int[] sides)
        { Radius = sides[0]; }

        public Circle()
        { }
    }
}
