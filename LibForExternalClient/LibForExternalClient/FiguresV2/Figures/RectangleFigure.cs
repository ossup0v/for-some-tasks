public sealed class RectangleFigure : FigureBase
{
    public override int SidesCount => 2;

    private double _a => _sides[0];
    private double _b => _sides[1];

    public override double GetArea()
    {
        return (_a + _b) * 2;
    }
}
