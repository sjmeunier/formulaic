using FluentAssertions;
using Formulaic.Geodesy;
using System;
using Xunit;

namespace FormulaicTests
{
    public class GeodesyTests
    {
        private readonly int doublePrecision = 8;

        [Theory]
        [InlineData(10.0, 5.0, 15.0, 10.0, 776.86015754)]
        [InlineData(0.0, 1.0, 0.0, 2.0, 111.19492664)]
        [InlineData(50.0, 1.0, 50.0, 2.0, 71.47418874)]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0)]
        public void AddTest(double latitude1, double longitude1, double latitude2, double longitude2, double expected)
        {
            var coordinate1 = new GeoCoordinate(latitude1, longitude1);
            var coordinate2 = new GeoCoordinate(latitude2, longitude2);

            var result = Math.Round(Haversine.DistanceBetweenCoordinates(coordinate1, coordinate2), doublePrecision);

            result.Should().Be(Math.Round(expected, doublePrecision));
        }
    }
}
