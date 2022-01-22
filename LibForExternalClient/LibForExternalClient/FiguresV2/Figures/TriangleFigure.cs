public sealed class TriangleFigure : FigureBase
{
    public override int SidesCount => 3;

    private double _a => _sides[0];
    private double _b => _sides[1];
    private double _c => _sides[2];

    public override double GetArea()
    {
        if (!IsExists())
            return double.NaN;

        return (_a + _b + _c) / 2;
    }

    private bool IsExists()
    {
        return _a + _b > _c
            && _a + _c > _b
            && _b + _c > _a;
    }
}
