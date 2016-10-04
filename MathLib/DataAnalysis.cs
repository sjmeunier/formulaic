using System;
using System.Collections.Generic;

namespace MathLib
{

	public class DataAnalysis
	{

        //Find the geometric mean of a list of values
		public static double GeometricMean(List<double> values)
		{
			double geometricMean, product;

			product = 1.0;
			foreach(double value in values)
			{
				product *= value;
			}

            geometricMean =  Math.Pow(product, (1.0 / (double)values.Count));
			return geometricMean;
		}

        //Find the arithmetic mean of a list of values
		public static double ArithmeticMean(List<double> values)
		{
			double mean, sum;

			sum = 0.0;
            foreach (double value in values)
            {
                sum += value;
            }

            mean =  sum / (double)values.Count;
			return mean;
		}

        //Calculates the sum of the items in a list
		public static double Sum(List<double> values)
		{
			double sum;

			sum = 0.0;
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
			double standardDeviation, mean, deviationMean;
			List<double> deviation = new List<double>();
			
			mean = ArithmeticMean(values);

			foreach(double value in values)
			{
				deviation.Add(Math.Pow((value - mean), 2));
			}

			deviationMean = ArithmeticMean(deviation);
			standardDeviation = Math.Sqrt(deviationMean);

			return standardDeviation;
		}

        //Find the standard deviation of a list of items
        public static double Variance(List<double> values)
		{
			double standardDeviation, variance;

            standardDeviation = StandardDeviation(values);
			variance = Math.Pow(standardDeviation, 2);

			return variance;
		}

        //Find the maximum in a list of values
		public static double Max(List<double> values)
		{
			double max;
			max = -1.0E300;

            foreach (double value in values)
            {
                max = Math.Max(value, max);
			}

			return max;
		}

        //Find the minimum in a list of values
        public static double Min(List<double> values)
		{
			double min;
			min = 1.0E300;

            foreach (double value in values)
            {
                min = Math.Min(value, min);
			}

			return min;
		}

        //Find the least squares fit of a list of points, fitting to the equation y = mx + b
		public static void LeastSquaresFitLinear(List<Point> points, ref double m, ref double b)
		{
			double x1, y1, xy, x2, j;

			x1 = y1 = xy = x2 = 0.0;

			foreach(Point point in points)
			{
				x1 += point.X;
				y1 += point.Y;
				xy += point.X * point.Y;
				x2 += point.X * point.X;
			}

			j = (points.Count * x2) - (x1 * x1);
			if (j != 0.0)
			{
				m = ((points.Count * xy) - (x1 * y1)) / j;
				b = ((y1 * x2) - (x1 * xy)) / j;
			}
			else
			{
				m = 0;
				b = 0;
			}
		}

        //Find the least squares fit of a list of points, fitting to the equation y = b(10^m)^x
        public static void LeastSquaresFitLogOrdinate(List<Point> points, ref double m, ref double b)
		{
            double x1, y1, xy, x2, j, ly;

            x1 = y1 = xy = x2 = 0.0;

            foreach (Point point in points)
            {
                ly = Math.Log10(point.Y);
                x1 += point.X;
                y1 += ly;
                xy += point.X * ly;
                x2 += point.X * point.X;
            }

            j = (points.Count * x2) - (x1 * x1);
            if (j != 0.0)
            {
                m = ((points.Count * xy) - (x1 * y1)) / j;
                b = ((y1 * x2) - (x1 * xy)) / j;
            }
            else
            {
                m = 0;
                b = 0;
            }
		}

        //Find the least squares fit of a list of points, fitting to the equation y = m*log(x)/log(10) + b
        public static void LeastSquaresFitLogAbscissa(List<Point> points, ref double m, ref double b)
		{
            double x1, y1, xy, x2, j, lx;

            x1 = y1 = xy = x2 = 0.0;

            foreach (Point point in points)
            {
                lx = Math.Log10(point.X);
                x1 += lx;
                y1 += point.Y;
                xy += point.Y * lx;
                x2 += point.X * point.X;
            }

            j = (points.Count * x2) - (x1 * x1);
            if (j != 0.0)
            {
                m = ((points.Count * xy) - (x1 * y1)) / j;
                b = ((y1 * x2) - (x1 * xy)) / j;
            }
            else
            {
                m = 0;
                b = 0;
            }
		}

        //Find the least squares fit of a list of points, fitting to the equation y = b*x^m
        public static void LeastSquaresFitLogFull(List<Point> points, ref double m, ref double b)
        {
            double x1, y1, xy, x2, j, lx, ly;

            x1 = y1 = xy = x2 = 0.0;

            foreach (Point point in points)
            {
                lx = Math.Log10(point.X);
                ly = Math.Log10(point.Y);
                x1 += lx;
                y1 += ly;
                xy += ly * lx;
                x2 += lx * lx;
            }

            j = (points.Count * x2) - (x1 * x1);
            if (j != 0.0)
            {
                m = ((points.Count * xy) - (x1 * y1)) / j;
                b = ((y1 * x2) - (x1 * xy)) / j;
            }
            else
            {
                m = 0;
                b = 0;
            }
		}

        //Interpolate y value from equation y = mx + b
		public double InterpolateLinearY(double m, double b, double x)
		{
			return (m * x) + b;
		}

        //Interpolate x value from equation y = mx + b
        public double InterpolateLinearX(double m, double b, double y)
		{
			return (y - b) / m;
		}

        //Interpolate y value from equation y = b(10^m)^x
        public double InterpolateLogOrdinateY(double m, double b, double x)
		{
			return b * Math.Pow(Math.Pow(10, m), x);
		}

        //Interpolate x value from equation y = b(10^m)^x
        public double InterpolateLogOrdinateX(double m, double b, double y)
		{

            //TODO
            return 0;
			
		}

        //Interpolate y value from equation y = m*log(x)/log(10) + b
        public double InterpolateLogAbscissaY(double m, double b, double x)
		{
			return (m * Math.Log10(x)) + b;
		}
 
        //Interpolate x value from equation y = m*log(x)/log(10) + b
        public double InterpolateLogAbscissaX(double m, double b, double y)
		{
			return Math.Pow(10, ((y - b) / m));
		}

        //Interpolate y value from equation y = b*x^m
        public double InterpolateLogFullY(double m, double b, double x)
		{
			return (b * Math.Pow(x, m));
		}

        //Interpolate x value from equation y = b*x^m
        public double InterpolateLogFullX(double m, double b, double y)
		{
            //TODO
            return 0;
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
