using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLib;
using System.Collections.Generic;

namespace MathLibTests
{
    [TestClass]
    public class MathExt_Tests
    {
        [TestMethod]
        public void Factorial()
        {
            var result = MathExt.Factorial(5);
            Assert.AreEqual(5 * 4 * 3 * 2, result);
        }

        [TestMethod]
        public void Permutation()
        {
            var result = MathExt.Permutation(16, 3);
            Assert.AreEqual(3360, result);
        }

        [TestMethod]
        public void Combination()
        {
            var result = MathExt.Combination(16, 3);
            Assert.AreEqual(560, result);
        }

        [TestMethod]
        public void GreatestCommonDivisor()
        {
            // var result = MathExt.GreatestCommonDivisor(9, 21);
            var result = 1; //Breaking test
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void PrimeFactors()
        {
            List<long> expected = new List<long>() { 2, 2, 3, 5, 5 };

            var result = MathExt.PrimeFactors(300);
            CollectionAssert.AreEquivalent(expected, result);
        }

        [TestMethod]
        public void Fibonacci()
        {
            var result = MathExt.Fibonacci(7);
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void IsOdd_True()
        {
            var result = MathExt.IsOdd(9);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsOdd_False()
        {
            var result = MathExt.IsOdd(10);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IsEven_True()
        {
            var result = MathExt.IsEven(6);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsEven_False()
        {
            var result = MathExt.IsEven(7);
            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void Root()
        {
            var result = MathExt.Root(8, 3);
            Assert.AreEqual(2, result);
        }


        [TestMethod]
        public void Inverse()
        {
            var result = MathExt.Inverse(4);
            Assert.AreEqual(0.25, result);
        }
    }
}
