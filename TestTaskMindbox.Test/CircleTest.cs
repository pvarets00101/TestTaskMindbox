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
        [Fact]
        public void GetArea_WithRadiusValueByZero_ReturFalse()
        {
            var circle = new Circle(0);

            var isNotHaveZeroRadiusValue= circle.CheckRadiusValue();

            Assert.False(isNotHaveZeroRadiusValue);
        }
        [Fact]
        public void GetArea_WithRadiusValueLessThanZero_ReturFalse()
        {
            var circle = new Circle(-3);

            var isNotHaveZeroRadiusValue = circle.CheckRadiusValue();

            Assert.False(isNotHaveZeroRadiusValue);
        }
    }
}