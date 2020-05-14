using System;

namespace Formulaic.Maths
{
    public static class Algebra
    {

        //Solve the quadratic equation specified by ax^2 + bx + x. The roots can be real, repeating or imaginary
        public static QuadraticResult SolveQuadratic(double a, double b, double c)
        {
            QuadraticResult result = new QuadraticResult();

            double z =  Math.Pow(b, 2) - (4 * a * c);

            if (Math.Round(z, 2) < 0)
            {
                result.SecondRoot.Real = result.FirstRoot.Real = -1 * b / (2.0 * a);

                result.FirstRoot.Imaginary = Math.Sqrt(Math.Abs(z)) / (2.0 * a);
                result.SecondRoot.Imaginary = result.FirstRoot.Imaginary * -1;

                result.RootType = QuadraticRootType.Complex;
            }
            else if (Math.Round(z, 2) == 0)
            {
                result.FirstRoot.Real = -1 * b / (2.0 * a);
                result.SecondRoot.Real = result.FirstRoot.Real;

                result.FirstRoot.Imaginary = result.SecondRoot.Imaginary = 0.0;

                result.RootType = QuadraticRootType.Repeating;
            }
            else
            {
                result.FirstRoot.Real = ((-1 * b) + Math.Sqrt(z)) / (2.0 * a);
                result.SecondRoot.Real = ((-1 * b) - Math.Sqrt(z)) / (2.0 * a);

                result.FirstRoot.Imaginary = result.SecondRoot.Imaginary = 0.0;

                result.RootType = QuadraticRootType.Real;
            }

            return result;
        }
    }
}
