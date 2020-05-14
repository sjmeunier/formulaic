using System;

namespace Formulaic.Maths
{
    public class Matrix
    {
        public double[,] Values { get; set; }
        public int Cols { get; set; }
        public int Rows { get; set; }

        public Matrix(int cols, int rows)
        {
            Cols = cols;
            Rows = rows;
            Values = new double[Rows, Cols];
            Zero();
        }

        public Matrix(double[,] values)
        {
            Values = values;
            Cols = Values.GetLength(1);
            Rows = Values.GetLength(0);
        }

        public void Zero()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Values[i, j] = 0;
                }
            }
        }

        public void SetIdentity()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (i == j)
                    {
                        Values[i, j] = 1;
                    }
                    else
                    {
                        Values[i, j] = 0;
                    }
                }
            }
        }

        public Matrix Transpose()
        {
            double[,] values = new double[Cols, Rows];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    values[j, i] = Values[i, j];
                }
            }
            return new Matrix(values);
        }

        public Matrix Scale(double factor)
        {
            double[,] values = new double[Rows, Cols];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    values[i, j] = factor * Values[i, j];
                }
            }
            return new Matrix(values);
        }

        public double Determinant()
        {
            double determinant = 0;
            int colIndex;
            double value;
            int k;

            for (int i = 0; i < Cols; i++)
            {
                k = 0;
                value = 1;
                for (int j = 0; j < Cols; j++)
                {
                    colIndex = (i + j) % 3;
                    value *= Values[colIndex, k];
                    k++;
                }
                determinant += value;
            }
            for (int i = 0; i < Cols; i++)
            {
                k = 0;
                value = 1;
                for (int j = Cols-1; j >= 0; j--)
                {
                    colIndex = (i + j) % 3;
                    value *= Values[colIndex, k];
                    k++;
                }
                determinant -= value;
            }

            return determinant;
        }

        public double Trace()
        {
            if (Rows != Cols)
            {
                return 0;
            }
            double trace = 0;
            for (int i = 0; i < Rows; i++)
            {

               trace += Values[i, i];
            }
            return trace;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    str += $"{Values[i, j].ToString()},";
                }
                str += Environment.NewLine;
            }
            return str;
        }

        public static Matrix operator +(Matrix left, Matrix right)
        {
            if ((left.Cols != right.Cols) || (left.Rows != right.Rows))
            {
                return left;
            }
            double[,] values = new double[left.Rows, left.Cols];

            for (int i = 0; i < left.Rows; i++)
            {
                for (int j = 0; j < left.Cols; j++)
                {
                    values[i,j] = left.Values[i,j] + right.Values[i,j];
                }
            }
            return (new Matrix(values));
        }

        public static Matrix operator +(double left, Matrix right)
        {
            double[,] values = new double[right.Rows, right.Cols];

            for (int i = 0; i < right.Rows; i++)
            {
                for (int j = 0; j < right.Cols; j++)
                {
                    values[i, j] = left + right.Values[i, j];
                }
            }
            return (new Matrix(values));
        }

        public static Matrix operator -(Matrix left, Matrix right)
        {
            if ((left.Cols != right.Cols) || (left.Rows != right.Rows))
            {
                return left;
            }
            double[,] values = new double[left.Cols, left.Rows];

            for (int i = 0; i < left.Rows; i++)
            {
                for (int j = 0; j < left.Cols; j++)
                {
                    values[i, j] = left.Values[i, j] - right.Values[i, j];
                }
            }
            return (new Matrix(values));
        }

        public static Matrix operator *(Matrix left, Matrix right)
        {
            double[,] values = new double[left.Rows, right.Cols];

            for (int h = 0; h < left.Rows; h++)
            {
                for (int i = 0; i < right.Cols; i++)
                {
                    for (int j = 0; j < left.Cols; j++)
                    {
                            values[h, i] += left.Values[h, j] * right.Values[j, i];
                    }
                }
            }
            return (new Matrix(values));
        }

    }
}
