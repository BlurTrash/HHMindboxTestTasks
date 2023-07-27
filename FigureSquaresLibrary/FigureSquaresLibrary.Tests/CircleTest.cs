using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureSquaresLibrary.Tests
{
    [TestClass]
    public class CircleTest
    {
        [ExpectedException(typeof(ShapeException), "Исключение не брошено!")]
        [TestMethod]
        public void Circle_IsCorrectRadius_0_Exception()
        {
            //arrange
            double x = 0;
            //act
            Circle circle = new Circle(x);      
        }

        [ExpectedException(typeof(ShapeException), "Исключение не брошено!")]
        [TestMethod]
        public void Circle_IsCorrectRadius_NegativeData_Exception()
        {
            //arrange
            double x = -22.3;
            //act
            Circle circle = new Circle(x);
        }

        [TestMethod]
        public void GetArea_4_return_50_26()
        {
            //arrange
            double expected = 50.26; 
            //act
            Circle circle = new Circle(4);
            double result = circle.GetArea();
            //assert
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
