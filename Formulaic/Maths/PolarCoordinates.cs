namespace Formulaic.Maths
{
    public class PolarCoordinates
    {
        public double r { get; set; }
        public double Theta { get; set; }

        public PolarCoordinates()
        {

        }

        public PolarCoordinates(double r, double theta)
        {
            this.r = r;
            Theta = theta;
        }
    }
}
