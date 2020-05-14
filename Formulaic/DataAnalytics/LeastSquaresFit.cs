using Formulaic.Maths;
using System;
using System.Collections.Generic;

namespace Formulaic.DataAnalytics
{
    public static class LeastSquaresFit
    {

        //Find the least squares fit of a list of points, fitting to the equation y = mx + b
        public static void Linear(List<Point> points, ref double m, ref double b)
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
        public static void LogOrdinate(List<Point> points, ref double m, ref double b)
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
        public static void LogAbscissa(List<Point> points, ref double m, ref double b)
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
        public static void LogFull(List<Point> points, ref double m, ref double b)
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
    }
}
