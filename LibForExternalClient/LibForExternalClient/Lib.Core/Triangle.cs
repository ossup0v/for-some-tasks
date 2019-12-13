using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Core
{
    public class Triangle : IFigure
    {
        public Triangle()
        { }

        public void SetSides(int[] sides)
        { A = sides[0]; B = sides[1]; C = sides[2]; }

        public double A { get; set; }

        public double B { get; set; }

        public double C { get; set; }

        public bool IsRightTriangle
        {
            get
            {
                if (!IsValid)
                {
                    throw new Exception($"Unvalid sides: {A}-{B}-{C}");
                }

                var biggerSide = 0.0D;
                var side2 = 0.0D;
                var side3 = 0.0D;

                if (A >= B && A >= C)
                {
                    biggerSide = A;
                    side2 = B;
                    side3 = C;
                }
                else if (B >= A && B >= C)
                {
                    biggerSide = B;
                    side2 = A;
                    side3 = C;
                }
                else if (C >= B && C >= A)
                {
                    biggerSide = C;
                    side2 = B;
                    side3 = A;
                }

                return Math.Pow(biggerSide, 2) == Math.Pow(side2, 2) + Math.Pow(side3, 2);
            }

            private set
            {

            }
        }

        public double Area()
        {
            if (!IsValid)
                throw new Exception($"Unvalid sides: {A}-{B}-{C}");

            var hp = MathHalfPerimeter(A, B, C);
            return Math.Pow(hp * (hp - A) * (hp - B) * (hp - C), 0.5);
        }

        private double MathHalfPerimeter(double sideA, double sideB, double sideC)
        {
            var perimeter = sideA + sideB + sideC;
            return perimeter / 2;
        }

        private bool IsValid => A < (B + C) && B < (A + C) && C < (A + B);
    }
}
