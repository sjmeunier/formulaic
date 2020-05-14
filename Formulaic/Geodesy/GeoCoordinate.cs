namespace Formulaic.Geodesy
{
    public class GeoCoordinate
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public GeoCoordinate()
        {

        }

        public GeoCoordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
