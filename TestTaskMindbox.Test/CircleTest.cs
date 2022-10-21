using FigureLib.Shapes;

namespace TestTaskMindbox.Test
{
    public class CircleTest
    {
        [Fact]
        public void GetArea_WithRadiusValueByZero_ReturExeption()
        {
            var circle = new Circle(0);

            Assert.Throws<ArgumentException>(() => circle.GetArea());
        }
        [Fact]
        public void GetArea_ReturValue()
        {
            var circle = new Circle(2);

            var area = circle.GetArea();

            Assert.Equal(12.57, area);
        }
    }
}