public sealed class CircleFigure : FigureBase
{
    public override int SidesCount => 1;

    private double _radius => _sides[0];

    public override double GetArea()
    {
        return Math.Pow(_radius, 2) * Math.PI;
    }
}