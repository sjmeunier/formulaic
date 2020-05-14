using FluentAssertions;
using Formulaic.Maths;
using System.Collections.Generic;
using Xunit;

namespace FormulaicTests
{
    public class MathExtTests
    {
        [Theory]
        [InlineData(5, 5 * 4 * 3 * 2)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        public void FactorialTest(int val, long expected)
        {
            var result = MathExt.Factorial(val);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(16, 3, 3360)]
        [InlineData(1, 1, 1)]
        public void PermutationTest(int n, int r, int expected)
        {
            var result = MathExt.Permutation(n, r);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(16, 3, 560)]
        [InlineData(1, 1, 1)]
        public void CombinationTest(int n, int r, int expected)
        {
            var result = MathExt.Combination(n, r);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(9, 21, 3)]
        [InlineData(1, 1, 1)]
        public void GreatestCommonDivisorTest(int a, int b, int expected)
        {
            var result = MathExt.GreatestCommonDivisor(a, b);

            result.Should().Be(expected);
        }

        [Fact]
        public void PrimeFactorsTest()
        {
            var expected = new List<long>() { 2, 2, 5, 5, 5 };
            var result = MathExt.PrimeFactors(500);

            result.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(7, 13)]
        [InlineData(1, 1)]
        public void FibonacciTest(int n, int expected)
        {
            var result = MathExt.Fibonacci(n);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(7, true)]
        [InlineData(2, false)]
        public void IsOddTest(int n, bool expected)
        {
            var result = MathExt.IsOdd(n);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(7, false)]
        [InlineData(2, true)]
        public void IsEvenTest(int n, bool expected)
        {
            var result = MathExt.IsEven(n);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(8.0, 3.0, 2.0)]
        [InlineData(1.0, 1.0, 1.0)]
        public void RootTest(double val, double root, double expected)
        {
            var result = MathExt.Root(val, root);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(4.0, 0.25)]
        [InlineData(1.0, 1.0)]
        public void InverseTest(double val, double expected)
        {
            var result = MathExt.Inverse(val);

            result.Should().Be(expected);
        }
    }
}
