using FigureLib.Contracts;

namespace FigureLib.Shapes
{
    public class Circle : IShape
    {
        public double R { get; private set; }
        public Circle(double r) => R = r;
        public double GetArea()
        {
            if (CheckRadiusValue()) return Math.Round(Math.PI * R * R,2);
            else throw new ArgumentException("Radius can't be 0 or less than 0");
        }
        public bool CheckRadiusValue()
        {
            return R != 0 && R > 0;
        }
    }
}
