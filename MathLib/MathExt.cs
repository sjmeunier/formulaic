using System;
using System.Collections.Generic;

namespace MathLib
{
    public static class MathExt
    {
        // Calculate the factorial of a number
        public static long Factorial(int val)
        {
            long factorial = 1;
            for (int i = 2; i <= val; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        //Calculate of the number of permuations of n and r
        public static int Permutation(int n, int r)
        {
            int Perm = 0;
            Perm = (int)(MathExt.Factorial(n) / MathExt.Factorial(n - r));
            return Perm;
        }

        //Calculate of the number of combinations of n and r
        public static int Combination(int n, int r)
        {
            int Comb = 0;
            Comb = (int)(MathExt.Factorial(n) / (MathExt.Factorial(r) * MathExt.Factorial(n - r)));
            return Comb;
        }

        //Calculate of the greatest common divisor of two numbers
        public static int GreatestCommonDivisor(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            if ((a == 1) || (b == 1))
            {
                return 1;
            }
            if ((a % 2 == 0) && (b % 2 == 0))
            {
                return 2 * GreatestCommonDivisor(a / 2, b / 2);
            }
            else if ((a % 2 == 0) && (b % 2 != 0))
            {
                return GreatestCommonDivisor(a / 2, b);
            }
            else if ((a % 2 != 0) && (b % 2 == 0))
            {
                return GreatestCommonDivisor(a, b / 2);
            }
            else
            {
                return GreatestCommonDivisor(Math.Abs(a - b) / 2, b);
            }

        }

        //Calculate a list of all the prime factors of a number
        public static List<long> PrimeFactors(long val)
        {
            List<long> factors = new List<long>();

            while (val % 2 == 0)
            {
                factors.Add(2);
                val = val / 2;
            }

            long divisor = 3;
            while (divisor <= val)
            {
                if (val % divisor == 0)
                {
                    factors.Add(divisor);
                    val = val / divisor;
                }
                else
                {
                    divisor += 2;
                }
            }
           
            return factors;
        }

        //Calculate of the sum of the fibonacci sequence up to the specified number
        public static long Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        //Check if number is odd
        public static bool IsOdd(int val)
        {
            return (val % 2 == 1);
        }

        //Check if number is even
        public static bool IsEven(int val)
        {
            return (val % 2 == 0);
        }

        //Calculate the nth root of a number
        public static double Root(double val, double root)
        {
            return Math.Pow(val, (1.0 / root));
        }

        //Calculate the inverse of a number
        public static double Inverse(double val)
        {
            return 1.0 / val;
        }

    }
}
