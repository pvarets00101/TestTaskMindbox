using FigureLib.Shapes;

namespace TestTaskMindbox.Test
{
    public class TriangleTest
    {
        [Fact]
        public void CheckSquarenessTriangleSideLenghtByCorrectValue_ReturnTrue()
        {
            var triange = new Triangle(3,4,5);

            bool isSquareness = triange.CheckSquarenessTriangle();

            Assert.True(isSquareness);
        }
        [Fact]
        public void CheckSquarenessTriangleSideLenghtByCorrectValue_False()
        {
            var triange = new Triangle(3, 5, 5);

            bool isSquareness = triange.CheckSquarenessTriangle();

            Assert.False(isSquareness);
        }

        [Theory]
        [InlineData(3, 4, 8)]
        [InlineData(3, -4, 5)]
        [InlineData(3, 4, 0)]
        public void CheckSquarenessTriangleSideLenghtByIncorrectValue_ThrowExeption(double a, double b, double c)
        {
            var triange = new Triangle(a,b,c);

            Assert.Throws<ArgumentException>(() => triange.CheckSquarenessTriangle());
        }

        [Fact]
        public void GetAreaWithSideLenghtByCorrectValue_Value()
        {
            var triange = new Triangle(3, 4, 5);

            var area = triange.GetArea();

            Assert.Equal(6, area);
        }

        [Theory]
        [InlineData(3, 4, 8)]
        [InlineData(3, -4, 5)]
        [InlineData(0, 4, 5)]
        public void GetAreaSideLenghtByIncorrectValue_ThrowExeption(double a, double b, double c)
        {
            var triange = new Triangle(a, b, c);

            Assert.Throws<ArgumentException>(() => triange.GetArea());
        }
    }
}