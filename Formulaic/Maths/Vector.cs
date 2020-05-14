using System;

namespace Formulaic.Maths
{
    public class Vector
    {
        public double[] Components { get; set; }
        public int Dimension { get; set; }

        public Vector(double[] Values)
        {
            Components = Values;
            Dimension = Components.GetLength(0);
        }

        public Vector(int dimension)
        {
            Components = new double[dimension];
            Dimension = dimension;
            Zero();
        }


        public void Zero()
        {
            for(int i = 0; i < Dimension; i++)
            {
                Components[i] = 0;
            }
        }

        public double Abs()
        {
            double abs = 0;

            for (int i = 0; i < Dimension; i++)
            {
                abs += Components[i] * Components[i];
            }
            return Math.Sqrt(abs);
        }

        public double Dot(Vector vector)
        {
            if (vector.Dimension != Dimension)
            {
                return 0;
            }

            double dotProduct = 0;
            for (int i = 0; i < Dimension; i++)
            {
                dotProduct += Components[i] * vector.Components[i];
            }
            return dotProduct;
        }

        public Vector Scale(double factor)
        {
            double[] values = new double[Dimension];

            for (int i = 0; i < Dimension; i++)
            {
                values[i] = Components[i] * factor;
            }
            return new Vector(values);
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < Dimension; i++)
            {
                if (i != 0)
                {
                    str += ", ";
                }
                str += Components[i];
            }
            return $"({str})";
        }


        public static Vector operator +(Vector left, Vector right)
        {
            if (left.Dimension != right.Dimension)
            {
                return left;
            }
            double[] values = new double[left.Dimension];

            for (int i = 0; i < left.Dimension; i++)
            {
                values[i] = left.Components[i] + right.Components[i];
            }
            return (new Vector(values));
        }

        public static Vector operator -(Vector left, Vector right)
        {
            if (left.Dimension != right.Dimension)
            {
                return left;
            }
            double[] values = new double[left.Dimension];

            for (int i = 0; i < left.Dimension; i++)
            {
                values[i] = left.Components[i] - right.Components[i];
            }
            return (new Vector(values));
        }

    }
}
