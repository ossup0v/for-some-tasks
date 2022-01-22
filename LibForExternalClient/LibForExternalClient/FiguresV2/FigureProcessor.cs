public sealed class FigureProcessor
{
    private Dictionary<int, FigureBase> _figures = new Dictionary<int, FigureBase>();

    public FigureProcessor()
    {
        InitFigures();
    }

    public double GetAreaOfFigure(params double[] sides)
    {
        return _figures[sides.Length].SetSides(sides).GetArea();
    }

    private void InitFigures()
    {
        var allFigures = typeof(FigureBase).GetAllSubclass();

        foreach (var figure in allFigures)
        {
            var figureInstance = (FigureBase)Activator.CreateInstance(figure);

            _figures.Add(figureInstance.SidesCount, figureInstance);
        }
    }
}
