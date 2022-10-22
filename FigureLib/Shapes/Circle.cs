using FigureLib.Contracts;

namespace FigureLib.Shapes
{
    public class Circle : IShape
    {
        public double R { get; private set; }
        public Circle(double r) => R = r;
        public double GetArea()
        {
            if (R > 0) return Math.Round(Math.PI * R * R,2);
            else throw new ArgumentException("Radius can't be 0 or less than 0");
        }

    }
}
