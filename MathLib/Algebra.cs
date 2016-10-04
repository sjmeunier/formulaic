using System;

namespace MathLib
{
	/// <summary>
	/// Summary description for Algebra.
	/// </summary>
	public class Algebra
	{

        //Solve the quadratic equation specified by ax^2 + bx + x. The roots can be real, repeating or imaginary
        public static void SolveQuadratic(double a, double b, double c, ref double x1Real, ref double x1Im, ref double x2Real, ref double x2Im, ref Enums.RootType rootType)
		{
			double z = 0;

			z = Math.Pow(b, 2) - (4 * a * c);
			
			if (Math.Round(z, 2) < 0)
			{
				x1Real = -1 * b / (2.0 * a);
				x2Real = x1Real;

				x1Im = Math.Sqrt(Math.Abs(z)) / (2.0 * a);
				x2Im = -1 * x1Im;

				rootType = Enums.RootType.Complex;
			}
			else if(Math.Round(z, 2) == 0)
			{
				x1Real = -1 * b / (2.0 * a);
				x2Real = x1Real;

				x1Im = 0.0;
				x2Im = 0.0;

                rootType = Enums.RootType.Repeating;
			}
			else
			{
				x1Real = ((-1 * b) + Math.Sqrt(z)) / (2.0 * a);
				x2Real = ((-1 * b) - Math.Sqrt(z)) / (2.0 * a);

				x1Im = 0.0;
				x2Im = 0.0;

                rootType = Enums.RootType.Real;
			}
		}
	}
}
