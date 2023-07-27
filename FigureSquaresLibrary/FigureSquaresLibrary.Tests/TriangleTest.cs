using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureSquaresLibrary.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [ExpectedException(typeof(ShapeException), "Исключение не брошено!")]
        [TestMethod]
        public void Triangle_IsCorrectSides_0_Exception()
        {
            //arrange
            double aSide = 0;
            double bSide = 3;
            double cSide = 4;
            //act
            Triangle triangle = new Triangle(aSide, bSide, cSide);
        }

        [ExpectedException(typeof(ShapeException), "Исключение не брошено!")]
        [TestMethod]
        public void Triangle_IsCorrectSides_WrongSide_Exception()
        {
            //arrange
            double aSide = 13;
            double bSide = 3;
            double cSide = 4;
            //act
            Triangle triangle = new Triangle(aSide, bSide, cSide);
        }

        [TestMethod]
        public void GetArea_5_6_9_return_14_14()
        {
            //arrange
            double aSide = 5;
            double bSide = 6;
            double cSide = 9;

            double expected = 14.14;
            //act
            Triangle triangle = new Triangle(aSide, bSide, cSide);
            double result = triangle.GetArea();
            //assert
            Assert.AreEqual(expected, result, 0.01);
        }

        [TestMethod]
        public void IsRightTriangle_5_4_3_ReturnTrue()
        {
            //Arrange
            double aSide = 5;
            double bSide = 4;
            double cSide = 3;

            //Act
            Triangle triangle = new Triangle(aSide, bSide, cSide);
            bool result = triangle.IsRightTriangle();
            //Assert
            Assert.IsTrue(result);
        }
    }
}
