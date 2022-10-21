using FigureLib.Contracts;

namespace FigureLib
{
    public class ContextShapes
    {
        private IShape _shape;

        public ContextShapes(IShape shape) => _shape = shape;
        public void SetContextShape(IShape shape) => _shape = shape;

        public void GetResult()
        {
            Console.WriteLine($"Area of the {_shape.GetType().Name} is {_shape.GetArea()}");
        }
    }
}
