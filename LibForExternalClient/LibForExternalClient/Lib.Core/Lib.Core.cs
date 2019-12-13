using Lib.API;
using System;
using System.Collections.Generic;

namespace Lib.Core
{
    public class LibCore : LibAPI
    {
        private Dictionary<int, IFigure> _map = new Dictionary<int, IFigure>()
        { [1] = new Circle() ,
          [3] = new Triangle() };

        public double Area(int[] sides)
        {
            if (_map.TryGetValue(sides.Length, out var figure))
            {
                figure.SetSides(sides);
                return figure.Area();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
