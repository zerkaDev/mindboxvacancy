using Figures;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void SquareCompileTest()
        {
            IFigure circle = new Circle(4);
            var circleSquare = circle.GetSquare();

            circle = new Triangle(1, 3, 4);
            var thigonSquare = circle.GetSquare();

            Assert.NotZero(circleSquare);
            Assert.NotZero(thigonSquare);

            Assert.IsTrue(circleSquare > 0);
            Assert.IsTrue(thigonSquare > 0);

            Assert.That(circleSquare, Is.Not.EqualTo(thigonSquare));
        }
        [Test]
        public void TriangleIsRectangular()
        {
            Triangle triangleRec = new Triangle(3, 4, 5);
            Triangle triangleNotRec = new Triangle(4, 4, 5);

            Assert.IsTrue(triangleRec.IsRectangular);
            Assert.IsFalse(triangleNotRec.IsRectangular);
        }
        [Test]
        public void TriangleThrowsExceptionOnCount()
        {
            Assert.Throws<Exception>(() => new Triangle(1, 2, 3, 4, 5));
            Assert.DoesNotThrow(() => new Triangle(1, 2, 3));
            Assert.Throws<Exception>(() => new Triangle(5));
        }
        [Test]
        public void TriangleThrowsExceptionOnLessZero()
        {
            Assert.Throws<Exception>(() => new Triangle(1, 2, -3));
            Assert.Throws<Exception>(() => new Triangle(1, -2, 3));
            Assert.Throws<Exception>(() => new Triangle(-1, 2, 3));
        }
        [Test]
        public void CircleThrowsExceptionOnLessZero()
        {
            Assert.Throws<Exception>(() => new Circle(-3));
        }
    }
}