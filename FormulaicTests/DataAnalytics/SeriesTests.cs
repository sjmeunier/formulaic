using FluentAssertions;
using Formulaic.Maths;
using System;
using System.Collections.Generic;
using Xunit;

namespace FormulaicTests
{
    public class SeriesTests
    {
        private readonly int doublePrecision = 8;

        [Fact]
        public void GeometricMeanTest()
        {
            List<double> values = new List<double>() { 1, 5, 4, 8, 6, 4, 9 };
            var expected = 4.45007854;
            var result = Math.Round(Series.GeometricMean(values), doublePrecision);
            result.Should().Be(expected);
        }

        [Fact]
        public void ArithmeticMeanMeanTest()
        {
            List<double> values = new List<double>() { 1, 5, 4, 8, 6, 4, 9 };
            var expected = 5.28571429;
            var result = Math.Round(Series.ArithmeticMean(values), doublePrecision);
            result.Should().Be(expected);
        }

        [Fact]
        public void SumTest()
        {
            List<double> values = new List<double>() { 1, 5, 4, 8, 6, 4, 9 };
            var expected = 37;
            var result = Math.Round(Series.Sum(values), doublePrecision);
            result.Should().Be(expected);
        }

        [Fact]
        public void MedianTest()
        {
            List<double> values = new List<double>() { 1, 5, 4, 8, 6, 4, 9 };
            var expected = 5;
            var result = Math.Round(Series.Median(values), doublePrecision);
            result.Should().Be(expected);
        }

        [Fact]
        public void StandardDeviationTest()
        {
            List<double> values = new List<double>() { 1, 5, 4, 8, 6, 4, 9 };
            var expected = 2.4907994;
            var result = Math.Round(Series.StandardDeviation(values), doublePrecision);
            result.Should().Be(expected);
        }

        [Fact]
        public void VarianceTest()
        {
            List<double> values = new List<double>() { 1, 5, 4, 8, 6, 4, 9 };
            var expected = 6.20408163;
            var result = Math.Round(Series.Variance(values), doublePrecision);
            result.Should().Be(expected);
        }

        [Fact]
        public void MaxTest()
        {
            List<double> values = new List<double>() { 1, 5, 4, 8, 6, 4, 9 };
            var expected = 9;
            var result = Math.Round(Series.Max(values), doublePrecision);
            result.Should().Be(expected);
        }

        [Fact]
        public void MinTest()
        {
            List<double> values = new List<double>() { 1, 5, 4, 8, 6, 4, 9 };
            var expected = 1;
            var result = Math.Round(Series.Min(values), doublePrecision);
            result.Should().Be(expected);
        }
    }
}
