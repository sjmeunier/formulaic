using System;
using System.Collections.Generic;
using System.Text;

namespace Formulaic.Maths
{
    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D()
        {
        }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static double Abs(Point3D p1)
        {
            return Math.Sqrt((p1.X * p1.X) + (p1.Y * p1.Y) + (p1.Z * p1.Z));
        }

        public static Point3D Add(Point3D p1, Point3D p2)
        {
            double dX, dY, dZ;
            dX = p1.X + p2.X;
            dY = p1.Y + p2.Y;
            dZ = p1.Z + p2.Z;
            return new Point3D(dX, dY, dZ);
        }

        public static Point3D Subtract(Point3D p1, Point3D p2)
        {
            double dX, dY, dZ;
            dX = p1.X - p2.X;
            dY = p1.Y - p2.Y;
            dZ = p1.Z - p2.Z;
            return new Point3D(dX, dY, dZ);
        }

        public static Point3D Normalise(Point3D p1)
        {
            double abs = Point3D.Abs(p1);
            Point3D newPoint = new Point3D()
            {
                X = p1.X / abs,
                Y = p1.Y / abs,
                Z = p1.Z / abs
            };
            return newPoint;
        }

        public static double DotProduct(Point3D p1, Point3D p2)
        {
            double dotProduct = p1.X * p2.X + p1.Y * p2.Y +  p1.Z * p2.Z;
            if (dotProduct > 1)
            {
                dotProduct = 1;
            }
            if (dotProduct < 0)
            {
                dotProduct = 0;
            }
            return dotProduct;
        }

        public static Point3D CrossProduct(Point3D p1, Point3D p2)
        {
            Point3D newPoint = new Point3D()
            {
                X = p1.Y * p2.Z - p1.Z * p2.Y,
                Y = p1.Z * p2.X - p1.X * p2.Z,
                Z = p1.X * p2.Y - p1.Y * p2.X
            };
            return newPoint;
        }

        public static Point3D Scale(Point3D p, double scale)
        {
            return new Point3D(p.X * scale, p.Y * scale, p.Z * scale);
        }

        public static double GetAngleBetween(Point3D p1, Point3D p2)
        {
            return Trigonometry.Acos(DotProduct(p1, p2));
        }
    }
}
