using FigureLib.Contracts;

namespace FigureLib.Shapes
{
    public class Сircle : IShape
    {
        public double R { get; private set; }
        public Сircle(double r) => R = r;
        public double GetArea()
        {
            if (R != 0) return Math.Round(Math.PI * R * R,2);
            else throw new ArgumentNullException("Radius can't be 0");
        }
    }
}
