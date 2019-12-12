using System;
using Lib.API;
using Lib.Core;
using NUnit.Framework;

namespace Lib.Test
{
    public class Tests
    {
        [Test]
        [Category("Tests for lib..")]
        public void TemporaryTest()
        {
            var math = new LibCore();

            var circule = new Circle(5d);
            math.Mathing(circule);
            Assert.AreEqual(circule.Area, 5 * 5 * Math.PI);

            var triangle = new Triangle(5, 4, 3);
            math.Mathing(triangle);
            Assert.AreEqual(triangle.Area, 6);
            Assert.IsTrue(triangle.IsRightTriangle);

            triangle = new Triangle(5, 4, 2);
            math.Mathing(triangle);
            Assert.IsFalse(triangle.IsRightTriangle);
        }
    }
}
