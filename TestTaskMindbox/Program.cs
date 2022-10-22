using FigureLib;
using FigureLib.Shapes;

var context = new ContextShapes(new Triangle(4, 7, 9));
context.GetResult();

context.SetContextShape(new Circle(4));
context.GetResult();

Console.WriteLine($"The squareness of the triangle is { new Triangle(6, 8, 10).CheckSquarenessTriangle()}");
