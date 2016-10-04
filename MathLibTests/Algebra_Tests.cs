using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLib;
using System.Collections.Generic;

namespace MathLibTests
{
    [TestClass]
    public class Algebra_Tests
    {
        [TestMethod]
        public void SolveQuadratic_Real()
        {
            double x1Real = 0;
            double x1Im = 0;
            double x2Real = 0;
            double x2Im = 0;
            Enums.RootType rootType = Enums.RootType.None;

            Algebra.SolveQuadratic(1, 0, -1, ref x1Real, ref x1Im, ref x2Real, ref x2Im, ref rootType);

            Assert.AreEqual(Enums.RootType.Real, rootType);
            Assert.AreEqual(1, Math.Round(x1Real, 8));
            Assert.AreEqual(0, Math.Round(x1Im, 8));
            Assert.AreEqual(-1, Math.Round(x2Real, 8));
            Assert.AreEqual(0, Math.Round(x2Im, 8));
        }

        [TestMethod]
        public void SolveQuadratic_Complex()
        {
            double x1Real = 0;
            double x1Im = 0;
            double x2Real = 0;
            double x2Im = 0;
            Enums.RootType rootType = Enums.RootType.None;

            Algebra.SolveQuadratic(1, -10, 34, ref x1Real, ref x1Im, ref x2Real, ref x2Im, ref rootType);

            Assert.AreEqual(Enums.RootType.Complex, rootType);
            Assert.AreEqual(5, Math.Round(x1Real, 8));
            Assert.AreEqual(3, Math.Round(x1Im, 8));
            Assert.AreEqual(5, Math.Round(x2Real, 8));
            Assert.AreEqual(-3, Math.Round(x2Im, 8));
        }
    }
}
