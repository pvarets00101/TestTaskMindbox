using FigureLib;
using FigureLib.Shapes;

var context = new ContextShapes(new Triangle( 3, 4, 5));
context.GetResult();

context.SetContextShape(new Сircle(10));
context.GetResult();

Console.WriteLine($"The squareness of the triangle is { new Triangle(6, 20, 10).CheckSquarenessTriangle()}");
