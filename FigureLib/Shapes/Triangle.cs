using FigureLib.Contracts;

namespace FigureLib.Shapes
{
    public class Triangle : IShape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c) => (A, B, C) = (a, b, c);

        public double GetArea()
        {
            if (CheckSideCondition())
            {
                double perimetr = (A + B + C) / 2;
                return Math.Round(Math.Sqrt(perimetr * (perimetr - A) * (perimetr - B) * (perimetr - C)),2);
            }
            else
                throw new ArgumentException("The values of the sides does not correspond to reality!");
        }
        public bool CheckSquarenessTriangle()
        {
            if (CheckSideCondition())
                return Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2)
                || Math.Pow(A, 2) + Math.Pow(C, 2) == Math.Pow(B, 2)
                || Math.Pow(C, 2) + Math.Pow(B, 2) == Math.Pow(A, 2);

            throw new ArgumentException("The values of the sides does not correspond to reality!");
        }

        private bool CheckSideCondition()
        {
           return CheckSideLengtMoreThanZero() && !(A + B <= C || A + C <= B || B + C <= A);
        }

        private bool CheckSideLengtMoreThanZero()
        {
            return A > 0 && B > 0 && C > 0;
        }    
    }
}
