using System;
using System.Collections.Generic;
using System.Text;

namespace Formulaic.Geodesy
{
    public class DMS
    {
        public int Degrees { get; set; }
        public int Minutes { get; set; }
        public double Seconds { get; set; }

        public DMS(double degrees)
        {
            Set(degrees);
        }

        public void Set(double decimalDegrees)
        {
            int degrees = (int)Math.Floor(Math.Abs(decimalDegrees));

            double tmp = (Math.Abs(decimalDegrees) - degrees) * 60.0;
            int minutes = (int)Math.Floor(tmp);

            tmp = (tmp - minutes) * 60.0;

            double seconds = tmp;
            while (seconds >= 60)
            {
                seconds -= 60;
                minutes += 1;
            }
            while (minutes >= 60)
            {
                minutes -= 60;
                degrees += 1;
            }

            if (decimalDegrees < 0)
            {
                degrees += -1;
            }

            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
        }

        public string ToString(int precision = 2)
        {
            return $"{Degrees}° {Minutes}' {Math.Round(Seconds, precision)}\"";
        }

        public string ToLatLongString(bool isLatitude, int precision = 2)
        {
            string direction;
            if (isLatitude)
            {
                if (Degrees < 0)
                {
                    direction = "S";
                }
                else
                {
                    direction = "N";
                }
            }
            else
            {
                if (Degrees < 0)
                {
                    direction = "W";
                }
                else
                {
                    direction = "E";
                }
            }

            return $"{Math.Abs(Degrees)}° {Minutes}' {Math.Round(Seconds, precision)}\"{direction}";


        }

    }
}
