using FluentAssertions;
using Formulaic.Finance;
using Xunit;

namespace FormulaicTests
{
    public class SimpleInterestTests
    {
        private readonly int doublePrecision = 8;

        [Theory]
        [InlineData(100.0, 8.0, 5.0, 140.0)]
        public void CalculateFinalValueTest(double principalValue, double interest, double years, double expected)
        {
            var result = SimpleInterest.CalculateFinalValue(principalValue, interest, years);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(140.0, 8.0, 5.0, 100.0)]
        public void CalculatePrincipalValueTest(double finalValue, double interest, double years, double expected)
        {
            var result = SimpleInterest.CalculatePrincipalValue(finalValue, interest, years);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(100.0, 140.0, 5.0, 8.0)]
        public void CalculateInterestTest(double principalValue, double finalValue, double years, double expected)
        {
            var result = SimpleInterest.CalculateInterest(principalValue, finalValue, years);

            result.Should().BeApproximately(expected, doublePrecision);
        }


        [Theory]
        [InlineData(100.0, 140.0, 8.0, 5.0)]
        public void CalculateYearsTest(double principalValue, double finalValue, double interest, double expected)
        {
            var result = SimpleInterest.CalculateYears(principalValue, finalValue, interest);

            result.Should().BeApproximately(expected, doublePrecision);
        }
    }
}
