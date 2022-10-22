using FigureLib.Shapes;

namespace TestTaskMindbox.Test
{
    public class CircleTest
    {
        [Theory]
        [InlineData(-3)]
        [InlineData(0)]
        public void GetArea_WithRadiusValueByZero_ReturExeption(double r)
        {
            var circle = new Circle(r);

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