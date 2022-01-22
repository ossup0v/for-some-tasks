public class Program
{
    public static void Main(string[] args)
    {
        var figureProcessor = new FigureProcessor();

        Console.WriteLine("pentagon is " + figureProcessor.GetAreaOfFigure(5, 3, 4, 5, 5));
        Console.WriteLine("triangle is " + figureProcessor.GetAreaOfFigure(3, 4, 5));
        Console.WriteLine("rectangle is " + figureProcessor.GetAreaOfFigure(2, 2));
        Console.WriteLine("circle is " + figureProcessor.GetAreaOfFigure(1));
        Console.ReadLine();
    }
}