public sealed class PentagonFigure : FigureBase
{
    public override int SidesCount => 5;

    private double _a => _sides[0];
    private double _b => _sides[1];
    private double _c => _sides[2];
    private double _d => _sides[3];
    private double _e => _sides[4];

    public override double GetArea()
    {
        return (_a + _b + _c + _d + _e) / 5;
    }
}