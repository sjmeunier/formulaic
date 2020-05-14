using System;

namespace Formulaic.Maths
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public PolarCoordinates GetPolarCoords()
        {
            PolarCoordinates polarCoordinates = new PolarCoordinates()
            {
                r = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(X, 2)),
                Theta = Trigonometry.TanQuadrant(X, Y, Trigonometry.Atan(Y / X))
            };
            return polarCoordinates;
        }

        public void SetPolarCoords(PolarCoordinates polarCoordinates)
        {
            X = polarCoordinates.r * Trigonometry.Cos(polarCoordinates.Theta);
            Y = polarCoordinates.r * Trigonometry.Sin(polarCoordinates.Theta);
        }

        public void Translate(double newXOrigin, double newYOrigin)
        {
            X -= newXOrigin;
            Y -= newYOrigin;
        }
    }
}
