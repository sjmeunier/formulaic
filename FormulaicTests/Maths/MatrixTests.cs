using FluentAssertions;
using Formulaic.Maths;
using System;
using Xunit;

namespace FormulaicTests
{
    public class MatrixTests
    {
        private readonly int doublePrecision = 8;

        [Fact]
        public void SetIdentityTest()
        {
            double[,] expected = new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

            var matrix = new Matrix(3, 3);
            matrix.SetIdentity();

            matrix.Values.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ZeroTest()
        {
            double[,] expected = new double[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            double[,] values = new double[3, 3] { { 1, 0, 0 }, { 3, 0, 1 }, { 0, 2, 0 } };

            var matrix = new Matrix(values);
            matrix.Zero();

            matrix.Values.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void SetTest()
        {
            double[,] expected = new double[3, 3] { { 1, 0, 0 }, { 3, 0, 1 }, { 0, 2, 0 } };
            double[,] values = new double[3, 3] { { 1, 0, 0 }, { 3, 0, 1 }, { 0, 2, 0 } };

            var matrix = new Matrix(values);

            matrix.Values.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void TransposeTest()
        {
            double[,] expected = new double[3, 3] { { 1, 3, 0 }, { 0, 0, 2 }, { 1, 0, 0 } };
            double[,] values = new double[3, 3] { { 1, 0, 1 }, { 3, 0, 0 }, { 0, 2, 0 } };

            var matrix = new Matrix(values);
            var result = matrix.Transpose();

            result.Values.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ScaleTest()
        {
            double[,] expected = new double[3, 3] { { 2, 0, 0 }, { 6, 0, 2 }, { 0, 4, 0 } };
            double[,] values = new double[3, 3] { { 1, 0, 0 }, { 3, 0, 1 }, { 0, 2, 0 } };

            var matrix = new Matrix(values);
            var result = matrix.Scale(2);

            result.Values.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void DeterminantTest()
        {
            double[,] values = new double[3, 3] { { 1, 0, 0 }, { 3, 0, 1 }, { 0, 2, 0 } };

            var matrix = new Matrix(values);
            var result = Math.Round(matrix.Determinant(), doublePrecision);

            result.Should().Be(-2);
        }

        [Fact]
        public void TraceTest()
        {
            double[,] values = new double[3, 3] { { 1, 0, 0 }, { 3, 0, 1 }, { 0, 2, 5 } };

            var matrix = new Matrix(values);
            var result = Math.Round(matrix.Trace(), doublePrecision);

            result.Should().Be(6);
        }
    }
}
