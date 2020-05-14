using FluentAssertions;
using Formulaic.Maths;
using System;
using Xunit;

namespace FormulaicTests
{
    public class VectorTests
    {
        private readonly int doublePrecision = 8;

        [Fact]
        public void ZeroTest()
        {
            double[] expected = new double[3] { 0, 0, 0 };
            double[] values = new double[3] { 1, 2, -4 };

            var vector = new Vector(values);
            vector.Zero();

            vector.Components.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void SetTest()
        {
            double[] expected = new double[3] { 1, 2, -4 };
            double[] values = new double[3] { 1, 2, -4 };

            var vector = new Vector(values);

            vector.Components.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void AbsTest()
        {
            double[] values = new double[3] { 1, 2, -4 };

            var vector = new Vector(values);
            var result = Math.Round(vector.Abs(), doublePrecision);

            result.Should().Be(Math.Round(Math.Sqrt(21), doublePrecision));
        }

        [Fact]
        public void DotProductTest()
        {
            double[] expected = new double[3] { 3, 2, -3 };
            double[] values1 = new double[3] { 1, 2, -4 };
            double[] values2 = new double[3] { 2, 0, 1 };

            var vector1 = new Vector(values1);
            var vector2 = new Vector(values2);

            var result = Math.Round(vector1.Dot(vector2), doublePrecision);

            result.Should().Be(-2);
        }

        [Fact]
        public void ScaleTest()
        {
            double[] expected = new double[3] { 2, 4, -8 };
            double[] values = new double[3] { 1, 2, -4 };

            var vector = new Vector(values);
            vector = vector.Scale(2);

            vector.Components.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void AddTest()
        {
            double[] expected = new double[3] { 3, 2, -3 };
            double[] values1 = new double[3] { 1, 2, -4 };
            double[] values2 = new double[3] { 2, 0, 1 };

            var vector1 = new Vector(values1);
            var vector2 = new Vector(values2);
            var vector3 = vector1 + vector2;

            vector3.Components.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void SubtractTest()
        {
            double[] expected = new double[3] { -1, 2, -5 };
            double[] values1 = new double[3] { 1, 2, -4 };
            double[] values2 = new double[3] { 2, 0, 1 };

            var vector1 = new Vector(values1);
            var vector2 = new Vector(values2);
            var vector3 = vector1 - vector2;

            vector3.Components.Should().BeEquivalentTo(expected);
        }
    }
}
