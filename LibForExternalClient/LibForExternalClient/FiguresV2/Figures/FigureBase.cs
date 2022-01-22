public abstract class FigureBase
{
    protected double[]? _sides;
 
    public abstract int SidesCount { get; }

    public FigureBase SetSides(double[] sides)
    {
        _sides = sides;
        return this;
    }

    public abstract double GetArea();
}
