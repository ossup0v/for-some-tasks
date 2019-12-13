using System;
using Lib.API;
using Lib.Core;
using NUnit.Framework;

namespace Lib.Test
{ 
    public class Tests
    {
        //        Напишите библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу 
        //        и треугольника по трем сторонам.Дополнительно к работоспособности оценим:
        //
        //        Юнит-тесты
        //        Легкость добавления других фигур
        //        Вычисление площади фигуры без знания типа фигуры
        //        Проверку на то, является ли треугольник прямоугольным

        [Test]
        [Category("Tests for lib..")]
        public void TemporaryTest()
        {
            var math = new LibCore();

            Assert.AreEqual(math.Area(new int[] { 5 }) , 5 * 5 * Math.PI);
            Assert.AreEqual(math.Area(new int[] { 5, 4, 3 }), 6);

            var triangle = new Triangle() { A = 5, B = 4, C = 3 };
            Assert.IsTrue(triangle.IsRightTriangle);

            triangle = new Triangle() { A = 5, B = 4, C = 2};
            Assert.IsFalse(triangle.IsRightTriangle);
        }
    }
}
