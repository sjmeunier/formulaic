using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLib;
using System.Collections.Generic;

namespace MathLibTests
{
    [TestClass]
    public class DataAnalysis_Tests
    {
        [TestMethod]
        public void GeometricMean()
        {
            List<double> values = new List<double>() { 1, 5, 4, 8, 6, 4, 9 };
            
            var result = DataAnalysis.GeometricMean(values);
            Assert.AreEqual(4.45007854, Math.Round(result, 8));
        }

        [TestMethod]
        public void ArithmeticMean()
        {
            List<double> values = new List<double>() { 1, 5, 4, 8, 6, 4, 9 };

            var result = DataAnalysis.ArithmeticMean(values);
            Assert.AreEqual(5.28571429, Math.Round(result, 8));
        }

        [TestMethod]
        public void Sum()
        {
            List<double> values = new List<double>() { 1, 5, 4, 8, 6, 4, 9 };

            var result = DataAnalysis.Sum(values);
            Assert.AreEqual(37, Math.Round(result, 8));
        }

        [TestMethod]
        public void Median()
        {
            List<double> values = new List<double>() { 1, 5, 4, 8, 6, 4, 9 };

            var result = DataAnalysis.Median(values);
            Assert.AreEqual(5, Math.Round(result, 8));
        }


        [TestMethod]
        public void StandardDeviation()
        {
            List<double> values = new List<double>() { 1, 5, 4, 8, 6, 4, 9 };

            var result = DataAnalysis.StandardDeviation(values);
            Assert.AreEqual(2.4907994, Math.Round(result, 8));
        }


        [TestMethod]
        public void Variance()
        {
            List<double> values = new List<double>() { 1, 5, 4, 8, 6, 4, 9 };

            var result = DataAnalysis.Variance(values);
            Assert.AreEqual(6.20408163, Math.Round(result, 8));
        }


        [TestMethod]
        public void Max()
        {
            List<double> values = new List<double>() { 1, 5, 4, 8, 6, 4, 9 };

            var result = DataAnalysis.Max(values);
            Assert.AreEqual(9, Math.Round(result, 8));
        }


        [TestMethod]
        public void Min()
        {
            List<double> values = new List<double>() { 1, 5, 4, 8, 6, 4, 9 };

            var result = DataAnalysis.Min(values);
            Assert.AreEqual(1, Math.Round(result, 8));
        }

        [TestMethod]
        public void RandomGenerator()
        {
            List<double> values = new List<double>() { 1, 5, 4, 8, 6, 4, 9 };

            var result = DataAnalysis.GenerateRandomNormalDistribution(100, 50, 20, 1000);
            result.Sort();
            Assert.AreEqual(1, 1);
        }
    }
}
