namespace Formulaic.Finance
{

    public static class SimpleDepreciation
    {
        //Calculate final value using simple depreciation
        public static double CalculateFinalValue(double principalValue, double interest, double years)
        {
            return principalValue * (1 - ((interest / 100.0) * years));
        }

        //Calculate principal value using simple depreciation
        public static double CalculatePrincipalValue(double finalValue, double interest, double years)
        {
            return finalValue / (1 - ((interest / 100.0) * years));
        }

        //Calculate depreciation using simple depreciation
        public static double CalculateDepreciation(double principalValue, double finalValue, double years)
        {
            return (((finalValue / principalValue) - 1) * (-1) / years) * 100.0;
        }

        //Calculate year timeframe using simple depreciation
        public static double CalculateYears(double principalValue, double finalValue, double interest)
        {
            return (((finalValue / principalValue) - 1) * (-1) / (interest / 100.0));
        }
    }
}
