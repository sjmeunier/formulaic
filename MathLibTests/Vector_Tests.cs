using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLib;
using System.Collections.Generic;

namespace MathLibTests
{
    [TestClass]
    public class Vector_Tests
    {
        [TestMethod]
        public void Vector_Set()
        {
            double[] expected = new double[3] { 1, 2, -4 };
            double[] values = new double[3] { 1, 2, -4 };

            var vector = new Vector(values);

            CollectionAssert.AreEquivalent(expected, vector.Components);
        }

        [TestMethod]
        public void Vector_Zero()
        {
            double[] expected = new double[3] { 0, 0, 0 };
            double[] values = new double[3] { 1, 2, -4 };

            var vector = new Vector(values);
            vector.Zero();

            CollectionAssert.AreEquivalent(expected, vector.Components);
        }

        [TestMethod]
        public void Vector_Abs()
        {
            double[] values = new double[3] { 1, 2, -4 };

            var vector = new Vector(values);
            var result = vector.Abs();

            Assert.AreEqual(Math.Sqrt(21), result);
        }

        [TestMethod]
        public void Vector_DotProduct()
        {
            double[] expected = new double[3] { 3, 2, -3 };
            double[] values1 = new double[3] { 1, 2, -4 };
            double[] values2 = new double[3] { 2, 0, 1 };

            var vector1 = new Vector(values1);
            var vector2 = new Vector(values2);

            var result = vector1.Dot(vector2);

            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Vector_Scale()
        {
            double[] expected = new double[3] { 2, 4, -8 };
            double[] values = new double[3] { 1, 2, -4 };

            var vector = new Vector(values);
            vector = vector.Scale(2);

            CollectionAssert.AreEquivalent(expected, vector.Components);
        }

        [TestMethod]
        public void Vector_Add()
        {
            double[] expected = new double[3] { 3, 2, -3 };
            double[] values1 = new double[3] { 1, 2, -4 };
            double[] values2 = new double[3] { 2, 0, 1 };

            var vector1 = new Vector(values1);
            var vector2 = new Vector(values2);
            var vector3 = vector1 + vector2;

            CollectionAssert.AreEquivalent(expected, vector3.Components);
        }

        [TestMethod]
        public void Vector_Subtract()
        {
            double[] expected = new double[3] { -1, 2, -5 };
            double[] values1 = new double[3] { 1, 2, -4 };
            double[] values2 = new double[3] { 2, 0, 1 };

            var vector1 = new Vector(values1);
            var vector2 = new Vector(values2);
            var vector3 = vector1 - vector2;

            CollectionAssert.AreEquivalent(expected, vector3.Components);
        }
    }
}
