using System;
using System.Collections.Generic;

namespace Formulaic.Maths
{

    public class Series
    {

        //Find the geometric mean of a list of values
        public static double GeometricMean(List<double> values)
        {
            double product = 1.0;
            foreach(double value in values)
            {
                product *= value;
            }

            double geometricMean =  Math.Pow(product, (1.0 / (double)values.Count));
            return geometricMean;
        }

        //Find the arithmetic mean of a list of values
        public static double ArithmeticMean(List<double> values)
        {
            double sum = 0.0;
            foreach (double value in values)
            {
                sum += value;
            }

            double mean =  sum / (double)values.Count;
            return mean;
        }

        //Calculates the sum of the items in a list
        public static double Sum(List<double> values)
        {
            double sum = 0.0;
            foreach (double value in values)
            {
                sum  += value;
            }

            return sum;
        }

        //Finds the median of a list of values
        public static double Median(List<double> values)
        {
            int mid;
            double median;

            values.Sort();

            if (MathExt.IsEven(values.Count))
            {
                mid = (values.Count / 2) - 1;
                median = (values[mid] + values[mid + 1]) / 2.0;
            }
            else
            {
                mid = (values.Count / 2);
                median = values[mid];
            }

            return median;
        }

        //Find the standard deviation of a list of items
        public static double StandardDeviation(List<double> values)
        {
            List<double> deviation = new List<double>();

            double mean = ArithmeticMean(values);

            foreach(double value in values)
            {
                deviation.Add(Math.Pow((value - mean), 2));
            }

            double deviationMean = ArithmeticMean(deviation);
            double standardDeviation = Math.Sqrt(deviationMean);

            return standardDeviation;
        }

        //Find the standard deviation of a list of items
        public static double Variance(List<double> values)
        {
            double standardDeviation = StandardDeviation(values);
            double variance = Math.Pow(standardDeviation, 2);

            return variance;
        }

        //Find the maximum in a list of values
        public static double Max(List<double> values)
        {
            double max = double.MinValue;

            foreach (double value in values)
            {
                max = Math.Max(value, max);
            }

            return max;
        }

        //Find the minimum in a list of values
        public static double Min(List<double> values)
        {
            double min = double.MaxValue;

            foreach (double value in values)
            {
                min = Math.Min(value, min);
            }

            return min;
        }

        public static List<double> GenerateRandomNormalDistribution(int samples, double mean, double standardDeviation, int accuracy)
        {
            List<double> values = new List<double>();
            Random random = new Random();

            for(int i = 0; i < samples; i++)
            {
                double num = 0;
                for(int j = 0; j < accuracy; j++)
                    num += random.NextDouble();
                values.Add(standardDeviation * Math.Sqrt(12.0 / accuracy) * (num - (accuracy / 2.0)) + mean);
            }

            return values;
        }
    }
}
