using FluentAssertions;
using Formulaic.Maths;
using System;
using Xunit;

namespace FormulaicTests
{
    public class GeometryTests
    {
        private readonly int doublePrecision = 8;

        [Theory]
        [InlineData(10.0, Math.PI * 100)]
        [InlineData(0.0, 0)]
        [InlineData(5, Math.PI * 25)]
        public void AreaCircleTest(double radius, double expected)
        {
            var result = Geometry.AreaCircle(radius);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(10.0, 100.0)]
        [InlineData(0.0, 0)]
        [InlineData(5, 25.0)]
        public void AreaSquareTest(double side, double expected)
        {
            var result = Geometry.AreaSquare(side);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(10.0, 10.0, 100.0)]
        [InlineData(0.0, 0.0, 0)]
        [InlineData(5, 8.0, 40.0)]
        public void AreaRectangleTest(double height, double width, double expected)
        {
            var result = Geometry.AreaRectangle(height, width);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(10.0, 90.0, Math.PI * 25)]
        [InlineData(0.0, 0.0, 0)]
        [InlineData(5, 360.0, Math.PI * 25)]
        public void AreaCircleSegmentTest(double radius, double deg, double expected)
        {
            var result = Geometry.AreaCircleSegment(radius, deg);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(10.0, 20.0, 45.0, 70.71067811865476)]
        [InlineData(10.0, 20.0, 0.0, 0.0)]
        [InlineData(0.0, 20.0, 45.0, 0.0)]
        [InlineData(15.0, 20.0, 90.0, 150.0)]
        public void AreaTriangleTest(double side1, double side2, double innerAngleDeg, double expected)
        {
            var result = Geometry.AreaTriangle(side1, side2, innerAngleDeg);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(10.0, 1000.0)]
        [InlineData(0.0, 0.0)]
        [InlineData(5, 125.0)]
        public void VolumeCubeTest(double side, double expected)
        {
            var result = Geometry.VolumeCube(side);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(10.0, 20.0, Math.PI * 2000)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(10.0, 0.0, 0.0)]
        [InlineData(0.0, 20.0, 0.0)]
        [InlineData(5.0, 15.0, Math.PI * 375.0)]
        public void VolumeCylinderTest(double radius, double height, double expected)
        {
            var result = Geometry.VolumeCylinder(radius, height);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(10.0, Math.PI * 1333.33333333)]
        [InlineData(0.0, 0.0)]
        [InlineData(5.0, Math.PI * 166.66666666)]
        public void VolumeSphereTest(double radius,double expected)
        {
            var result = Geometry.VolumeSphere(radius);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(10.0, 10.0, 10.0, 1000.0)]
        [InlineData(0.0, 0.0, 0.0, 0.0)]
        [InlineData(10.0, 0.0, 10.0, 0.0)]
        [InlineData(10.0, 10.0, 0.0, 0.0)]
        [InlineData(0.0, 10.0, 10.0, 0.0)]
        [InlineData(5.5, 10.0, 20.0, 1100.0)]
        public void VolumeRectBlockTest(double width, double height, double depth, double expected)
        {
            var result = Geometry.VolumeRectBlock(width, height, depth);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(10.0, 20.0, Math.PI * 2000 / 3.0)]
        [InlineData(0.0, 0.0, 0.0)]
        public void VolumeConeTest(double radius, double height, double expected)
        {
            var result = Geometry.VolumeCone(radius, height);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(10.0, 40.0)]
        [InlineData(0.0, 0.0)]
        [InlineData(5, 20.0)]
        public void PerimeterSquareTest(double side, double expected)
        {
            var result = Geometry.PerimeterSquare(side);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(10.0, 10.0, 40.0)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(0.0, 10.0, 20.0)]
        [InlineData(10.0, 0.0, 20.0)]
        [InlineData(5, 8.0, 26.0)]
        public void PerimeterRectangleTest(double height, double width, double expected)
        {
            var result = Geometry.PerimeterRectangle(height, width);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(10.0, Math.PI * 20.0)]
        [InlineData(0.0, 0.0)]
        [InlineData(5, Math.PI * 10.0)]
        public void CircumferenceCircleTest(double radius, double expected)
        {
            var result = Geometry.CircumferenceCircle(radius);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(10.0, 600.0)]
        [InlineData(0.0, 0.0)]
        [InlineData(5, 150.0)]
        public void SurfaceAreaCubeTest(double side, double expected)
        {
            var result = Geometry.SurfaceAreaCube(side);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(10.0, 20.0, 30.0, 2200.0)]
        [InlineData(0.0, 0.0, 0.0, 0.0)]
        [InlineData(0.0, 10.0, 10.0, 200.0)]
        [InlineData(10.0, 0.0, 10.0, 200.0)]
        [InlineData(10.0, 10.0, 0.0, 200.0)]
        public void SurfaceAreaRectBlockTest(double height, double width, double depth, double expected)
        {
            var result = Geometry.SurfaceAreaRectBlock(height, width, depth);

            result.Should().BeApproximately(expected, doublePrecision);
        }

        [Theory]
        [InlineData(10.0, Math.PI * 4000.0)]
        [InlineData(0.0, 0.0)]
        [InlineData(5.0, Math.PI * 500.0)]
        public void SurfaceAreaSphereTest(double radius, double expected)
        {
            var result = Geometry.SurfaceAreaSphere(radius);

            result.Should().BeApproximately(expected, doublePrecision);
        }
    }
}
