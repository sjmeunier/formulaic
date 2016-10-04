using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLib;
using System.Collections.Generic;

namespace MathLibTests
{
    [TestClass]
    public class Matrix_Tests
    {
        [TestMethod]
        public void Matrix_SetIdentity()
        {
            double[,] expected = new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

            var matrix = new Matrix(3, 3);
            matrix.SetIdentity();

            CollectionAssert.AreEquivalent(expected, matrix.Values);
        }

        [TestMethod]
        public void Matrix_Zero()
        {
            double[,] expected = new double[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            double[,] values = new double[3, 3] { { 1, 0, 0 }, { 3, 0, 1 }, { 0, 2, 0 } };

            var matrix = new Matrix(values);
            matrix.Zero();

            CollectionAssert.AreEquivalent(expected, matrix.Values);
        }

        [TestMethod]
        public void Matrix_Set()
        {
            double[,] expected = new double[3, 3] { { 1, 0, 0 }, { 3, 0, 1 }, { 0, 2, 0 } };
            double[,] values = new double[3, 3] { { 1, 0, 0 }, { 3, 0, 1 }, { 0, 2, 0 } };

            var matrix = new Matrix(values);

            CollectionAssert.AreEquivalent(expected, matrix.Values);
        }

        [TestMethod]
        public void Matrix_Transpose()
        {
            double[,] expected = new double[3, 3] { { 1, 3, 0 }, { 0, 0, 2 }, { 1, 0, 0 } };
            double[,] values = new double[3, 3] { { 1, 0, 0 }, { 3, 0, 1 }, { 0, 2, 0 } };

            var matrix = new Matrix(values);
            matrix.Transpose();

            CollectionAssert.AreEquivalent(expected, matrix.Values);
        }

        [TestMethod]
        public void Matrix_Scale()
        {
            double[,] expected = new double[3, 3] { { 2, 0, 0 }, { 6, 0, 2 }, { 0, 4, 0 } };
            double[,] values = new double[3, 3] { { 1, 0, 0 }, { 3, 0, 1 }, { 0, 2, 0 } };

            var matrix = new Matrix(values);
            matrix = matrix.Scale(2);

            CollectionAssert.AreEquivalent(expected, matrix.Values);
        }

        [TestMethod]
        public void Matrix_Determinant()
        {
            double[,] values = new double[3, 3] { { 1, 0, 0 }, { 3, 0, 1 }, { 0, 2, 0 } };

            var matrix = new Matrix(values);
            var result = matrix.Determinant();

            Assert.AreEqual(-2, Math.Round(result, 8));
        }

        [TestMethod]
        public void Matrix_Trace()
        {
            double[,] values = new double[3, 3] { { 1, 0, 0 }, { 3, 0, 1 }, { 0, 2, 5 } };

            var matrix = new Matrix(values);
            var result = matrix.Trace();

            Assert.AreEqual(6, Math.Round(result, 8));
        }
    }
}
