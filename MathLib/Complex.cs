using System;

namespace MathLib
{

    public class Complex
    {
        public double Real;
        public double Imaginary;

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator ^(Complex arg1, int arg2)
        {
            int i = 0;
            Complex x = new Complex(0.0, 0.0);

            if (arg2 == 0)
            {
                return x;
            }
            else
            {
                x = arg1;
                for (i = 1; i < arg2; i++)
                {
                    x = x * arg1;
                }
                return x;
            }
        }


        public static Complex operator +(Complex arg1, Complex arg2)
        {
            return (new Complex(arg1.Real + arg2.Real, arg1.Imaginary + arg2.Imaginary));
        }

        public static Complex operator -(Complex arg1)
        {
            return (new Complex(-arg1.Real, -arg1.Imaginary));
        }

        public static Complex operator -(Complex arg1, Complex arg2)
        {
            return (new Complex(arg1.Real - arg2.Real, arg1.Imaginary - arg2.Imaginary));
        }

        public static Complex operator *(Complex arg1, Complex arg2)
        {
            return (new Complex(arg1.Real * arg2.Real - arg1.Imaginary * arg2.Imaginary, arg1.Real * arg2.Imaginary + arg2.Real * arg1.Imaginary));
        }

        public static Complex operator /(Complex arg1, Complex arg2)
        {
            double c1, c2, d;
            d = arg2.Real * arg2.Real + arg2.Imaginary * arg2.Imaginary;
            if (d == 0)
            {
                return (new Complex(0, 0));
            }
            c1 = arg1.Real * arg2.Real + arg1.Imaginary * arg2.Imaginary;
            c2 = arg1.Imaginary * arg2.Real - arg1.Real * arg2.Imaginary;
            return (new Complex(c1 / d, c2 / d));
        }

        public double Abs()
        {
            return (Math.Sqrt(Real * Real + Imaginary * Imaginary));
        }

        //Arg of complex number in degrees
        public double Arg()
        {
            double ret = 0;
            if (Real != 0)
                ret = (180 / Math.PI) * Math.Atan(Imaginary / Real);
            return (ret);
           
        }

        

        public override string ToString()
        {
            return (String.Format("Complex: ({0}, {1})", Real, Imaginary));
        }

        public string ToComplexString(int iRounding)
        {
            string ComplexNumber = Convert.ToString(Math.Round(Real, iRounding)) + "+" + Convert.ToString(Math.Round(Imaginary, iRounding)) + "i";
            return ComplexNumber;
        }
    }
}
