using FigureLib.Shapes;

namespace TestTaskMindbox.Test
{
    public class TriangleTest
    {
        [Fact]
        public void CheckSquarenessTriangle_ReturnTrue()
        {
            var triange = new Triangle(3,4,5);

            bool isSquareness = triange.CheckSquarenessTriangle();

            Assert.True(isSquareness);
        }
        [Fact]
        public void CheckSquarenessTriangle_False()
        {
            var triange = new Triangle(3, 5, 5);

            bool isSquareness = triange.CheckSquarenessTriangle();

            Assert.False(isSquareness);
        }

        [Fact]
        public void CheckSquarenessTriangle_ThrowExeption()
        {
            var triange = new Triangle(3, 4, 8);

            Assert.Throws<ArgumentException>(() => triange.CheckSquarenessTriangle());
        }
        [Fact]
        public void GetArea_Value()
        {
            var triange = new Triangle(3, 4, 5);

            var area = triange.GetArea();

            Assert.Equal(6, area);
        }
        [Fact]
        public void GetAreaWithTheWrongSides_ThrowExeption()
        {
            var triange = new Triangle(3, -4, 5);

            Assert.Throws<ArgumentException>(() => triange.GetArea());
        }

        [Fact]
        public void CheckSideLengtMoreThanZero_True()
        {
            var triange = new Triangle(3, 5, 5);

            var isNotHaveZeroSideLengt = triange.CheckSideLengtMoreThanZero();

            Assert.True(isNotHaveZeroSideLengt);
        }
        [Fact]
        public void CheckSideLengtMoreThanZero_False()
        {
            var triange = new Triangle(-3, 5, 5);

            var isNotHaveZeroSideLengt = triange.CheckSideLengtMoreThanZero();

            Assert.False(isNotHaveZeroSideLengt);
        }

        [Fact]
        public void CheckSideLengtNotEqualZero_False()
        {
            var triange = new Triangle(3, 5, 0);

            var isNotHaveZeroSideLengt = triange.CheckSideLengtMoreThanZero();

            Assert.False(isNotHaveZeroSideLengt);
        }


        [Fact]
        public void CheckSideCondition_True()
        {
            var triange = new Triangle(3, 5, 5);

            var isRatioSidesAcceptable = triange.CheckSideCondition();

            Assert.True(isRatioSidesAcceptable);

        }
        [Fact]
        public void CheckSideCondition_False()
        {
            var triange = new Triangle(3, 5, 9);

            var isRatioSidesAcceptable = triange.CheckSideCondition();

            Assert.False(isRatioSidesAcceptable);

        }
    }
}