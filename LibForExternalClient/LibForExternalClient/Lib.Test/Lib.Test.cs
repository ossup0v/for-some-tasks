using System;
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
            Assert.IsTrue(math.IsRightTriangle(5, 4, 3));
            Assert.IsFalse(math.IsRightTriangle(5, 4, 2));

            Assert.AreEqual(math.MathArea(5, 4, 3), 6);
            Assert.AreEqual(math.MathArea(5), 5 * 5 * Math.PI);
        }
    }
}
