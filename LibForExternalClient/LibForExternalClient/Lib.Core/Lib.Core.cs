using Lib.API;
using System;

namespace Lib.Core
{
    public class LibCore : LibAPI
    {
        public double MathArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double MathArea(double sideA, double sideB, double sideC)
        {
            if (!IsTriangle(sideA, sideB, sideC))
                throw new Exception($"Unvalid sides: {sideA}-{sideB}-{sideC}");

            var hp = MathHalfPerimeter(sideA, sideB, sideC);
            return Math.Pow(hp * (hp - sideA) * (hp - sideB) * (hp - sideC), 0.5);
        }

        public bool IsRightTriangle(double sideA, double sideB, double sideC)
        {
            if (!IsTriangle(sideA, sideB, sideC))
                throw new Exception($"Unvalid sides: {sideA}-{sideB}-{sideC}");
            
            double biggerSide = 0;
            double secondSide = 0;
            double thridSide = 0;
            
            if (sideA > sideB && sideA > sideC)
            {
                biggerSide = sideA;
                secondSide = sideB;
                thridSide = sideC;
            }
            else if (sideB > sideA && sideB > sideC)
            {

                biggerSide = sideC;
                secondSide = sideB;
                thridSide = sideA;
            } 
            else
            {
                biggerSide = sideB;
                secondSide = sideC;
                thridSide = sideA;
            }

            return Math.Pow(biggerSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thridSide, 2);
        }

        private double MathHalfPerimeter(double sideA, double sideB, double sideC)
        {
            var perimeter = sideA + sideB + sideC;
            return perimeter/2;
        }

        private bool IsTriangle(double sideA, double sideB, double sideC)
        {
            return (sideA + sideB >= sideC) && (sideB + sideC >= sideA) && (sideC + sideA >= sideB);
        }
    }
}
