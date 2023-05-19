using AreaCalculator;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CheckAreaCircle()
        {
            double radius = 5, area = Math.PI * 25;
            Figure circle = new Circle(5);
            var s = circle.CalculateArea();
            Assert.AreEqual(area, s);
        }

        [TestMethod]
        public void CheckAreaTriangle()
        {
            double ab = 5, bc = 4, ca = 3, area = 6;
            Figure circle = new Triangle(ab, bc, ca);
            var s = circle.CalculateArea();
            Assert.AreEqual(area, s);
        }

        [TestMethod]
        public void CheckRightTriangle()
        {
            double ab = 5, bc = 4, ca = 3;
            var triangle = new Triangle(ab, bc, ca);
            var isRight = triangle.CheckRightTriangle();
            Assert.IsTrue(isRight);
        }

        [TestMethod]
        public void CheckNotRightTriangle()
        {
            double ab = 10, bc = 5, ca = 6;
            var triangle = new Triangle(ab, bc, ca);
            var isRight = triangle.CheckRightTriangle();
            Assert.IsFalse(isRight);
        }

    }
}