using System;

namespace Formulaic.Maths
{
    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber()
        {
            Real = 0;
            Imaginary = 0;
        }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public double Abs()
        {
            return Math.Sqrt(Real * Real + Imaginary * Imaginary);
        }

        //Arg of complex number in degrees
        public double Arg()
        {
            double result = 0;
            if (Real != 0)
                result = (180 / Math.PI) * Math.Atan(Imaginary / Real);
            return (result);

        }


        public override string ToString()
        {
            return $"Complex: ({Real}, {Imaginary})";
        }

        public string ToComplexString(int precision)
        {
            string ComplexNumber = $"{Math.Round(Real, precision)}{((Imaginary >= 0) ? "+" : "")}{Math.Round(Imaginary, precision)}i";
            return ComplexNumber;
        }

        #region Complex number operators

        public static ComplexNumber operator +(ComplexNumber arg1, ComplexNumber arg2)
        {
            return (new ComplexNumber(arg1.Real + arg2.Real, arg1.Imaginary + arg2.Imaginary));
        }

        public static ComplexNumber operator -(ComplexNumber arg1)
        {
            return (new ComplexNumber(-arg1.Real, -arg1.Imaginary));
        }

        public static ComplexNumber operator -(ComplexNumber arg1, ComplexNumber arg2)
        {
            return (new ComplexNumber(arg1.Real - arg2.Real, arg1.Imaginary - arg2.Imaginary));
        }

        public static ComplexNumber operator *(ComplexNumber arg1, ComplexNumber arg2)
        {
            return (new ComplexNumber(arg1.Real * arg2.Real - arg1.Imaginary * arg2.Imaginary, arg1.Real * arg2.Imaginary + arg2.Real * arg1.Imaginary));
        }

        public static ComplexNumber operator /(ComplexNumber arg1, ComplexNumber arg2)
        {
            double c1, c2, d;
            d = arg2.Real * arg2.Real + arg2.Imaginary * arg2.Imaginary;
            if (d == 0)
            {
                return (new ComplexNumber(0, 0));
            }
            c1 = arg1.Real * arg2.Real + arg1.Imaginary * arg2.Imaginary;
            c2 = arg1.Imaginary * arg2.Real - arg1.Real * arg2.Imaginary;
            return (new ComplexNumber(c1 / d, c2 / d));
        }

        public static ComplexNumber operator ^(ComplexNumber arg1, int arg2)
        {
            ComplexNumber x = new ComplexNumber(0.0, 0.0);

            if (arg2 == 0)
            {
                return x;
            }
            else
            {
                x = arg1;
                for (int i = 1; i < arg2; i++)
                {
                    x *= arg1;
                }
                return x;
            }
        }

        #endregion
    }
}
