using System;

namespace MathLib
{

	public class Finance
	{

        //Calculate final value using simple interest
		public static double SimpleInterestFinalValue(double principalValue, double interest, double years)
		{
			return principalValue * (1 + ((interest / 100.0) * years));
		}

        //Calculate principal value using simple interest
        public static double SimpleInterestPrincipalValue(double finalValue, double interest, double years)
		{
			return finalValue / (1 + ((interest / 100.0) * years));
		}

        //Calculate interest using simple interest
        public static double SimpleInterestInterest(double principalValue, double finalValue, double years)
		{
			return (((finalValue / principalValue) - 1) / years) * 100.0;
		}

        //Calculate year timeframe using simple interest
        public static double SimpleInterestYears(double principalValue, double finalValue, double interest)
		{
			return (((finalValue / principalValue) - 1) / (interest / 100.0));
		}

        //Calculate final value using compound interest
        public static double CompoundInterestFinalValue(double principalValue, double interest, double years)
		{
			return principalValue * Math.Pow((1 + (interest / 100.0)), years);
		}

        //Calculate principal value using compound interest
        public static double CompoundInterestPrincipalValue(double finalValue, double interest, double years)
		{
			return finalValue / Math.Pow((1 + (interest / 100.0)), years);
		}

        //Calculate interest using compound interest
        public static double CompoundInterestInterest(double principalValue, double finalValue, double years)
		{
			return (MathExt.Root((finalValue / principalValue), years) - 1) * 100.0;
		}

        //Calculate year timeframe using compound interest
        public static double CompoundInterestYears(double principalValue, double finalValue, double interest)
		{
			return Math.Log10(finalValue / principalValue) / Math.Log10(1 + (interest / 100.0));
		}

        //Calculate final value using simple depreciation
        public static double SimpleDepreciationFinalValue(double principalValue, double interest, double years)
		{
			return principalValue * (1 - ((interest / 100.0) * years));
		}

        //Calculate principal value using simple depreciation
        public static double SimpleDepreciationPrincipalValue(double finalValue, double interest, double years)
		{
			return finalValue / (1 - ((interest / 100.0) * years));
		}

        //Calculate depreciation using simple depreciation
        public static double SimpleDepreciationDepreciation(double principalValue, double finalValue, double years)
		{
			return (((finalValue / principalValue) - 1) * (-1) / years) * 100.0;
		}

        //Calculate year timeframe using simple depreciation
        public static double SimpleDepreciationYears(double principalValue, double finalValue, double interest)
		{
			return (((finalValue / principalValue) - 1) * (-1) / (interest / 100.0));
		}

        //Calculate final value using compound depreciation
        public static double CompoundDepreciationFinalValue(double principalValue, double interest, double years)
		{
			return principalValue * Math.Pow((1 - (interest / 100.0)), years);
		}

        //Calculate principal value using compound depreciation
        public static double CompoundDepreciationPrincipalValue(double finalValue, double interest, double years)
		{
			return finalValue / Math.Pow((1 - (interest / 100.0)), years);
		}

        //Calculate depreciation using compound depreciation
        public static double CompoundDepreciationDepreciation(double principalValue, double finalValue, double years)
		{
			return (MathExt.Root((finalValue / principalValue), years) - 1) * (-1) * 100.0;
		}

        //Calculate year timeframe using compound depreciation
        public static double CompoundDepreciationYears(double principalValue, double finalValue, double interest)
		{
			return Math.Log10(finalValue / principalValue) / Math.Log10(1 - (interest / 100.0));
		}
	}
}
