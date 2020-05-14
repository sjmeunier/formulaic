using FluentAssertions;
using Formulaic.Finance;
using Xunit;

namespace FormulaicTests
{
    public class CompoundDepreciationTests
    {
        private readonly int doublePrecision = 8;

        [Theory]
        [InlineData(100.0, 8.0, 5.0, 65.90815232)]
        public void CalculateFinalValueTest(double principalValue, double depreciation, double years, double expected)
        {
            var result = CompoundDepreciation.CalculateFinalValue(principalValue, depreciation, years);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(65.90815232, 8.0, 5.0, 100.0)]
        public void CalculatePrincipalValueTest(double finalValue, double depreciation, double years, double expected)
        {
            var result = CompoundDepreciation.CalculatePrincipalValue(finalValue, depreciation, years);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(100.0, 65.90815232, 5.0, 8.0)]
        public void CalculateDepreciationTest(double principalValue, double finalValue, double years, double expected)
        {
            var result = CompoundDepreciation.CalculateDepreciation(principalValue, finalValue, years);

            result.Should().BeApproximately(expected, doublePrecision);
        }


        [Theory]
        [InlineData(100.0, 65.90815232, 8.0, 5.0)]
        public void CalculateYearsTest(double principalValue, double finalValue, double Depreciation, double expected)
        {
            var result = CompoundDepreciation.CalculateYears(principalValue, finalValue, Depreciation);

            result.Should().BeApproximately(expected, doublePrecision);
        }
    }
}
