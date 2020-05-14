using FluentAssertions;
using Formulaic.Maths;
using System;
using Xunit;

namespace FormulaicTests
{
    public class ComplexNumberTests
    {
        private readonly int doublePrecision = 8;

        [Theory]
        [InlineData(10.0, 5.0, 15.0, 10.0, 25.0, 15.0)]
        [InlineData(10.0, -5.0, 15.0, 10.0, 25.0, 5.0)]
        [InlineData(10.0, 5.0, -15.0, 10.0, -5.0, 15.0)]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0, 0.0)]
        public void AddTest(double real1, double imaginary1, double real2, double imaginary2, double expectedReal, double expectedImaginary)
        {
            var val1 = new ComplexNumber(real1, imaginary1);
            var val2 = new ComplexNumber(real2, imaginary2);
            var expected = new ComplexNumber(expectedReal, expectedImaginary);

            var result = val1 + val2;

            result.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(10.0, 5.0, 15.0, 10.0, -5.0, -5.0)]
        [InlineData(10.0, -5.0, 15.0, 10.0, -5.0, -15.0)]
        [InlineData(10.0, 5.0, -15.0, 10.0, 25.0, -5.0)]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0, 0.0)]
        public void SubtractTest(double real1, double imaginary1, double real2, double imaginary2, double expectedReal, double expectedImaginary)
        {
            var val1 = new ComplexNumber(real1, imaginary1);
            var val2 = new ComplexNumber(real2, imaginary2);
            var expected = new ComplexNumber(expectedReal, expectedImaginary);

            var result = val1 - val2;

            result.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(10.0, 5.0, -10.0, -5.0)]
        [InlineData(10.0, -5.0, -10.0, 5.0)]
        [InlineData(-15.0, 10.0, 15.0, -10.0)]
        [InlineData(0.0, 0.0, 0.0, 0.0)]
        public void NegateTest(double real1, double imaginary1, double expectedReal, double expectedImaginary)
        {
            var val1 = new ComplexNumber(real1, imaginary1);
            var expected = new ComplexNumber(expectedReal, expectedImaginary);

            var result = -val1;

            result.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(10.0, 5.0, 15.0, 10.0, 100.0, 175.0)]
        [InlineData(10.0, -5.0, 15.0, 10.0, 200.0, 25.0)]
        [InlineData(10.0, 5.0, -15.0, 10.0, -200.0, 25.0)]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0, 0.0)]
        public void MultiplyTest(double real1, double imaginary1, double real2, double imaginary2, double expectedReal, double expectedImaginary)
        {
            var val1 = new ComplexNumber(real1, imaginary1);
            var val2 = new ComplexNumber(real2, imaginary2);
            var expected = new ComplexNumber(expectedReal, expectedImaginary);

            var result = val1 * val2;

            result.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(10.0, 5.0, 15.0, 10.0, 0.6153846153846154, -0.07692307692307693)]
        [InlineData(10.0, -5.0, 15.0, 10.0, 0.3076923076923077, -0.5384615384615384)]
        [InlineData(10.0, 5.0, -15.0, 10.0, -0.3076923076923077, -0.5384615384615384)]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0, 0.0)]
        public void DivideTest(double real1, double imaginary1, double real2, double imaginary2, double expectedReal, double expectedImaginary)
        {
            var val1 = new ComplexNumber(real1, imaginary1);
            var val2 = new ComplexNumber(real2, imaginary2);
            var expected = new ComplexNumber(expectedReal, expectedImaginary);

            var result = val1 / val2;

            result.Should().BeEquivalentTo(expected);
        }


        [Theory]
        [InlineData(10.0, 5.0, 0, 0, 0)]
        [InlineData(10.0, -5.0, 1, 10.0, -5.0)]
        [InlineData(10.0, 5.0, 2, 75.0, 100.0)]
        [InlineData(-10.0, 5.0, 2, 75.0, -100.0)]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0)]
        public void PowerTest(double real1, double imaginary1,int power, double expectedReal, double expectedImaginary)
        {
            var val1 = new ComplexNumber(real1, imaginary1);
            var expected = new ComplexNumber(expectedReal, expectedImaginary);

            var result = val1^power;

            result.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(10.0, 5.0, 11.18033989)]
        [InlineData(10.0, -5.0, 11.18033989)]
        [InlineData(10.4, -5.2, 11.62755348)]
        [InlineData(10.0, 0.0, 10.0)]
        [InlineData(-10.0, 5.0, 11.18033989)]
        [InlineData(47.0, -365.0, 368.01358670570846)]
        [InlineData(0.0, 0.0, 0.0)]
        public void AbsTest(double real1, double imaginary1, double expected)
        {
            var val1 = new ComplexNumber(real1, imaginary1);

            var result = Math.Round(val1.Abs(), doublePrecision);

            result.Should().Be(Math.Round(expected, doublePrecision));
        }

        [Theory]
        [InlineData(10.0, 5.0, 26.56505117707799)]
        [InlineData(10.0, -5.0, -26.56505117707799)]
        [InlineData(10.4, -5.2, -26.56505117707799)]
        [InlineData(10.0, 0.0, 0.0)]
        [InlineData(-10.0, 5.0, -26.56505117707799)]
        [InlineData(47.0, -365.0, -82.66256347)]
        [InlineData(0.0, 0.0, 0.0)]
        public void ArgTest(double real1, double imaginary1, double expected)
        {
            var val1 = new ComplexNumber(real1, imaginary1);

            var result = Math.Round(val1.Arg(), doublePrecision);

            result.Should().Be(Math.Round(expected, doublePrecision));
        }

        [Theory]
        [InlineData(10.0, 5.0, "10+5i")]
        [InlineData(10.0, -5.0, "10-5i")]
        [InlineData(-10.0, 5.0, "-10+5i")]
        [InlineData(47.34, -365.0, "47.34-365i")]
        [InlineData(0.0, 0.0, "0+0i")]
        public void ToComplexString(double real1, double imaginary1, string expected)
        {
            var val1 = new ComplexNumber(real1, imaginary1);

            var result = val1.ToComplexString(2);

            result.Should().Be(expected);
        }
    }
}
