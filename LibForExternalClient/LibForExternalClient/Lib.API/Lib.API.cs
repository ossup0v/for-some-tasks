namespace Lib.API
{
    public interface LibAPI
    {
        /// <summary>
        /// Math area of a circle
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>area of a circle</returns>
        double MathArea(double radius);

        /// <summary>
        /// Math area of triagle
        /// </summary>
        /// <param name="sideA">The first side</param>
        /// <param name="sideB">The second side</param>
        /// <param name="sideC">The third side</param>
        /// <returns>area of a triangle</returns>
        double MathArea(double sideA, double sideB, double sideC);

        /// <summary>
        /// Squareness check
        /// </summary>
        /// <param name="sideA">The first side</param>
        /// <param name="sideB">The second side</param>
        /// <param name="sideC">The third side</param>
        /// <returns>Is the triangle rectangular</returns>
        bool IsRightTriangle(double sideA, double sideB, double sideC);
    }
}
