using System;
using System.Collections.Generic;

namespace Formulaic.Electronics
{
    public class Resistance
    {
        public static double TotalResistanceWithParallelResistors(List<double> resistors)
        {
            double totalResistance = 0.0;

            foreach(var resistor in resistors)
            {
                totalResistance += (1.0 / resistor);
            }

            totalResistance = 1.0 / totalResistance;
            return totalResistance;
        }

        public static double TotalResistanceWithSeriesResistors(List<double> resistors)
        {
            double totalResistance = 0.0;

            foreach (var resistor in resistors)
            {
                totalResistance += resistor;
            }

            return totalResistance;
        }

        public static double ClosestStandardResistor(double resistance, double tolerance)
        {
            double[] values = new double[5];

            values[5] = tolerance;
            values[3] = 1.19927E-2 * Math.Floor(1.0 + (1.5 * tolerance) + (0.004 * Math.Pow(tolerance, 2)));
            values[2] = Math.Floor(Math.Log10(resistance) / Math.Log10(10.0) - Math.Floor(2.2 - 3 * values[3]));
            double standardResistor = resistance / Math.Pow(10.0, values[2]);

            for (int i = 0; i < 2; i++)
            {
                values[i] = Math.Floor(Math.Exp(values[3] * (Math.Floor(Math.Log10(standardResistor) / values[3]) + i)) + 0.5);
                values[4] = (1.88E-5 * Math.Pow(values[i], 3.0)) - (0.00335 * Math.Pow(values[i], 2)) + (0.164 * values[i]) - 1.284;
                values[i] = values[i] + Math.Floor(values[4] * Math.Floor(3.0 * values[3] + 0.8));
            }
            standardResistor = Math.Pow(10.0, values[2]) * values[(int)(standardResistor / Math.Sqrt(values[0] + values[1]))];
            standardResistor = Math.Floor(standardResistor + 0.5);

            return standardResistor;
        }

    }
}
