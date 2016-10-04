using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLib;

namespace MathLibTests
{
    [TestClass]
    public class Finance_Tests
    {
        [TestMethod]
        public void SimpleInterestFinalValue()
        {
            var result = Finance.SimpleInterestFinalValue(100, 8, 5);
            Assert.AreEqual(140, Math.Round(result, 8));
        }

        [TestMethod]
        public void SimpleInterestPrincipalValue()
        {
            var result = Finance.SimpleInterestPrincipalValue(140, 8, 5);
            Assert.AreEqual(100, Math.Round(result, 8));
        }

        [TestMethod]
        public void SimpleInterestInterest()
        {
            var result = Finance.SimpleInterestInterest(100, 140, 5);
            Assert.AreEqual(8, Math.Round(result, 8));
        }

        [TestMethod]
        public void SimpleInterestYears()
        {
            var result = Finance.SimpleInterestYears(100, 140, 8);
            Assert.AreEqual(5, Math.Round(result, 8));
        }

        [TestMethod]
        public void CompoundInterestFinalValue()
        {
            var result = Finance.CompoundInterestFinalValue(100, 8, 5);
            Assert.AreEqual(146.93280768, Math.Round(result, 8));
        }

        [TestMethod]
        public void CompoundInterestPrincipalValue()
        {
            var result = Finance.CompoundInterestPrincipalValue(146.93280768, 8, 5);
            Assert.AreEqual(100, Math.Round(result, 8));
        }

        [TestMethod]
        public void CompoundInterestInterest()
        {
            var result = Finance.CompoundInterestInterest(100, 146.93280768, 5);
            Assert.AreEqual(8, Math.Round(result, 8));
        }

        [TestMethod]
        public void CompoundInterestYears()
        {
            var result = Finance.CompoundInterestYears(100, 146.93280768, 8);
            Assert.AreEqual(5, Math.Round(result, 8));
        }

        [TestMethod]
        public void SimpleDepreciationFinalValue()
        {
            var result = Finance.SimpleDepreciationFinalValue(100, 8, 5);
            Assert.AreEqual(60, Math.Round(result, 8));
        }

        [TestMethod]
        public void SimpleDepreciationPrincipalValue()
        {
            var result = Finance.SimpleDepreciationPrincipalValue(60, 8, 5);
            Assert.AreEqual(100, Math.Round(result, 8));
        }

        [TestMethod]
        public void SimpleDepreciationDepreciation()
        {
            var result = Finance.SimpleDepreciationDepreciation(100, 60, 5);
            Assert.AreEqual(8, Math.Round(result, 8));
        }

        [TestMethod]
        public void SimpleDepreciationYears()
        {
            var result = Finance.SimpleDepreciationYears(100, 60, 8);
            Assert.AreEqual(5, Math.Round(result, 8));
        }


        [TestMethod]
        public void CompoundDepreciationFinalValue()
        {
            var result = Finance.CompoundDepreciationFinalValue(100, 8, 5);
            Assert.AreEqual(65.90815232, Math.Round(result, 8));
        }

        [TestMethod]
        public void CompoundDepreciationPrincipalValue()
        {
            var result = Finance.CompoundDepreciationPrincipalValue(65.90815232, 8, 5);
            Assert.AreEqual(100, Math.Round(result, 8));
        }

        [TestMethod]
        public void CompoundDepreciationDepreciation()
        {
            var result = Finance.CompoundDepreciationDepreciation(100, 65.90815232, 5);
            Assert.AreEqual(8, Math.Round(result, 8));
        }

        [TestMethod]
        public void CompoundDepreciationYears()
        {
            var result = Finance.CompoundDepreciationYears(100, 65.90815232, 8);
            Assert.AreEqual(5, Math.Round(result, 8));
        }

    }
}
