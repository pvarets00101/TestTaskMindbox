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
        public void CheckSquarenessTriangle_ThrowExeption()
        {
            var triange = new Triangle(3, 4, 8);

            Assert.Throws<ArgumentException>(() => triange.CheckSquarenessTriangle());
        }
        [Fact]
        public void GetArea_Test()
        {
            var triange = new Triangle(3, 4, 5);

            var area = triange.GetArea();

            Assert.Equal(6, area);
        }
        [Fact]
        public void GetAreaWithTheWrongSides_ThrowExeption()
        {
            var triange = new Triangle(3, 9, 5);

            Assert.Throws<ArgumentException>(() => triange.GetArea());
        }

        [Fact]
        public void CheckSideLengtByZero_ReturnTrue()
        {
            var triange = new Triangle(3, 5, 5);

            var isNotHaveZeroSideLengt = triange.CheckSideLengtByZero();

            Assert.True(isNotHaveZeroSideLengt);
        }

        [Fact]
        public void CheckSideLengtByZero_ReturnFalse()
        {
            var triange = new Triangle(3, 5, 0);

            var isNotHaveZeroSideLengt = triange.CheckSideLengtByZero();

            Assert.False(isNotHaveZeroSideLengt);
        }


        [Fact]
        public void CheckSideCondition_ReturnTrue()
        {
            var triange = new Triangle(3, 5, 5);

            var isRatioSidesAcceptable = triange.CheckSideCondition();

            Assert.True(isRatioSidesAcceptable);

        }
        [Fact]
        public void CheckSideCondition_ReturnFalse()
        {
            var triange = new Triangle(3, 5, 9);

            var isRatioSidesAcceptable = triange.CheckSideCondition();

            Assert.False(isRatioSidesAcceptable);

        }
    }
}