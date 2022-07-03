using NUnit.Framework;
using MindBoxFigures.Figures;
using System;

namespace MindBoxFigures.Tests
{
    
    public class MindBoxFiguresTest
    {
        /// <summary>
        /// Площадь круга
        /// </summary>
        [Test]
        public void GetSquareCircle_3()
        {
            var circle = new Circle(3);
            Assert.AreEqual(28.274333882308138, circle.Square);
        }

        /// <summary>
        /// Площадь треугольника
        /// </summary>
        [Test]
        public void GetSquareTriangle_5_4_7()
        {
            var triangle = new Triangle(5,4,7);
            Assert.AreEqual(9.797958971132712, triangle.Square);
        }

        /// <summary>
        /// Отрицательное значение радиуса круга
        /// </summary>
        [Test]
        public void BadCircleRadiusValue()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }

        /// <summary>
        /// Отрицательные и нулевые значения сторон треугольника
        /// </summary>
        [Test]
        public void BadTriangleSidesValues()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-5, 10, 4));
            Assert.Throws<ArgumentException>(() => new Triangle(10, -5, 4));
            Assert.Throws<ArgumentException>(() => new Triangle(10, 4, -5));
            Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 0));
            Assert.Throws<ArgumentException>(() => new Triangle(-5, -5, -5));
            Assert.Throws<ArgumentException>(() => new Triangle(5, 0, 0));
        }

        /// <summary>
        /// Если прямоугольный треугольник
        /// </summary>
        [Test]
        public void RightAngledTriangleTrue()
        {
            var triangle = new Triangle(3,4,5);
            Assert.AreEqual(triangle.IsRightAngled, true);
        }

        /// <summary>
        /// Если треугольник не прямоугольный
        /// </summary>
        [Test]
        public void RightAngledTriangleFalse()
        {
            var triangle = new Triangle(2, 3, 4);
            Assert.AreEqual(triangle.IsRightAngled, false);
        }
    }
}
