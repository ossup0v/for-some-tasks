using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.API
{
    public abstract class Figure
    {
        public Figure()
        {
            Type = FigureType.Unexpected;
        }

        public FigureType Type { get; protected set; }
    }

    public class Triangle : Figure
    {
        public double Perimeter { get;  set; }

        public double Area { get;  set; }

        public bool IsRightTriangle { get;  set; }

        public double SideA { get; private set; }

        public double SideB { get; private set; }

        public double SideC { get; private set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            base.Type = FigureType.Triangle;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
    }

    public class Circle : Figure
    {
        public double Area { get;  set; }

        public double Radius { get; private set; }

        public Circle(double radius)
        {
            base.Type = FigureType.Circle;
            Radius = radius;
        }
    }

    public enum FigureType
    {
        Unexpected,
        Triangle,
        Circle
    }
}
