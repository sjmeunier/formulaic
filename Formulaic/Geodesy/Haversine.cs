using Formulaic.Maths;
using System;

namespace Formulaic.Geodesy
{
    public static class Haversine
    {
        private static readonly double EarthRadius = 6371; //km

        public static double DistanceBetweenCoordinates(GeoCoordinate coordinate1, GeoCoordinate coordinate2)
        {
            double deltaLatitude = coordinate2.Latitude - coordinate1.Latitude;
            double deltaLong = coordinate2.Longitude - coordinate1.Longitude;

            double a = Trigonometry.Sin(deltaLatitude / 2.0) * Trigonometry.Sin(deltaLatitude / 2.0) + Trigonometry.Cos(coordinate1.Latitude) * Trigonometry.Cos(coordinate2.Latitude) * Trigonometry.Sin(deltaLong / 2.0) * Trigonometry.Sin(deltaLong / 2.0);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double distance = EarthRadius * c;

            return distance;
        }
    }
}
