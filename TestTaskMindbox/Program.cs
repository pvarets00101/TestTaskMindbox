using FigureLib;
using FigureLib.Shapes;

var context = new ContextShapes(new Triangle(0, 3, 3));
context.GetResult();

context.SetContextShape(new Circle(4));
context.GetResult();

Console.WriteLine($"The squareness of the triangle is { new Triangle(6, 8, 10).CheckSquarenessTriangle()}");
Console.WriteLine($"The squareness of the triangle is { new Triangle(6, 8, 10).CheckSquarenessTriangle()}");
