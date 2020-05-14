using FluentAssertions;
using Formulaic.Finance;
using Xunit;

namespace FormulaicTests
{
    public class SimpleDepreciationTests
    {
        private readonly int doublePrecision = 8;

        [Theory]
        [InlineData(100.0, 8.0, 5.0, 60.0)]
        public void CalculateFinalValueTest(double principalValue, double depreciation, double years, double expected)
        {
            var result = SimpleDepreciation.CalculateFinalValue(principalValue, depreciation, years);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(60.0, 8.0, 5.0, 100.0)]
        public void SimpleDepreciationPrincipalValueTest(double finalValue, double depreciation, double years, double expected)
        {
            var result = SimpleDepreciation.CalculatePrincipalValue(finalValue, depreciation, years);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(100.0, 60.0, 5.0, 8.0)]
        public void SimpleDepreciationDepreciationTest(double principalValue, double finalValue, double years, double expected)
        {
            var result = SimpleDepreciation.CalculateDepreciation(principalValue, finalValue, years);

            result.Should().BeApproximately(expected, doublePrecision);
        }


        [Theory]
        [InlineData(100.0, 60.0, 8.0, 5.0)]
        public void SimpleDepreciationYearsTest(double principalValue, double finalValue, double depreciation, double expected)
        {
            var result = SimpleDepreciation.CalculateYears(principalValue, finalValue, depreciation);

            result.Should().BeApproximately(expected, doublePrecision);
        }
    }
}
