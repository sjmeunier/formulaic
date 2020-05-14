using System;

namespace Formulaic.Maths
{
    public static class Transforms3D
    {
        public static Point Map3DTo2DCartesian(Point3D p3d)
        {
            double scale = (0.707 - p3d.Z) / 0.707;
            Point p2d = new Point()
            {
                X = p3d.X + (0.707 * p3d.Z * scale),
                Y = p3d.Y + (0.707 * p3d.Z * scale)
            };

            return p2d;
        }


        public static Point Map3DTo2D(double depth, Point3D p3d)
        {
            double perspectiveScale = (depth - p3d.Z) / depth;
            Point p2d = new Point()
            {
                X = p3d.X * perspectiveScale,
                Y = p3d.Y * perspectiveScale
            };

            return p2d;
        }

        public static Point3D Map3dPerspective(double screenZ, Point3D p3d)
        {
            Point3D newPoint = new Point3D()
            {
                X = p3d.X * screenZ / p3d.Z,
                Y = p3d.Y * screenZ / p3d.Z,
                Z = p3d.Z
            };

            return newPoint;
        }
        public static Point3D[] Map3dPerspectiveArray(double screenZ, Point3D[] p3d)
        {
            Point3D[] p = new Point3D[p3d.GetLength(0)];

            for (int i = 0; i < p3d.GetLength(0); i++)
            {
                p[i] = Map3dPerspective(screenZ, p3d[i]);
            }
            return p;
        }
        public static Point[] Map3dTo2dArray(double screenZ, Point3D[] p3d)
        {
            Point[] p2d = new Point[p3d.GetLength(0)];
          
            for (int i = 0; i < p3d.GetLength(0); i++)
            {
                p2d[i] = Map3DTo2D(screenZ, p3d[i]);
            }
            return p2d;
        }

        public static void RotatePoint(ref double p1, ref double p2, ref double p3, double angle)
        {
            double new2 = (p2 * Math.Cos(angle)) - (p3 * Math.Sin(angle));
            double new3 = (p2 * Math.Sin(angle)) + (p3 * Math.Cos(angle));
            p2 = new2;
            p3 = new3;
        }


    }
}
