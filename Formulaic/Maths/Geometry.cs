using System;

namespace Formulaic.Maths
{
    public static class Geometry
    {

        public static double AreaCircle(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double AreaSquare(double side)
        {
            return side * side;
        }

        public static double AreaRectangle(double height, double width)
        {
            return height * width;
        }

        public static double AreaCircleSegment(double radius, double deg)
        {
            return radius * radius * Trigonometry.DegToRad(deg) / 2.0;
        }

        public static double AreaTriangle(double side1, double side2, double innerAngleDeg)
        {
            return 0.5 * side1 * side2 * Trigonometry.Sin(innerAngleDeg);
        }

        public static double VolumeCube(double side)
        {
            return side * side * side;
        }

        public static double VolumeCylinder(double radius, double height)
        {
            return Math.PI * radius * radius * height;
        }

        public static double VolumeSphere(double radius)
        {
            return Math.PI * radius * radius * radius * 4.0 / 3.0;
        }

        public static double VolumeRectBlock(double width, double height, double depth)
        {
            return width * height * depth;
        }

        public static double VolumeCone(double radius, double height)
        {
            return Math.PI * radius * radius * height / 3.0;
        }

        public static double PerimeterSquare(double side)
        {
            return 4.0 * side;
        }

        public static double PerimeterRectangle(double width, double height)
        {
            return (2.0 * width) + (2.0 * height);
        }

        public static double CircumferenceCircle(double radius)
        {
            return radius * 2.0 * Math.PI;
        }

        public static double SurfaceAreaCube(double side)
        {
            return 6.0 * side * side;
        }

        public static double SurfaceAreaSphere(double radius)
        {
            return Math.PI * radius * radius * radius * 4.0;
        }

        public static double SurfaceAreaRectBlock(double width, double height, double depth)
        {
            return (2.0 * width * height) + (2.0 * width * depth) + (2.0 * height * depth);
        }
    }
}
