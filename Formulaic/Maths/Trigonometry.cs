using System;

namespace Formulaic.Maths
{
    public static class Trigonometry
    {
        public static double DegToRad(double deg) 
        {
            return deg / 180.0 * Math.PI;
        }
        
        public static double RadToDeg(double rad)
        {
            return rad * 180.0 / Math.PI;
        }

        public static double Cos(double deg)
        {
            return Math.Cos(DegToRad(deg));
        }

        public static double Sin(double deg)
        {
            return Math.Sin(DegToRad(deg));
        }

        public static double Tan(double deg)
        {
            return Math.Tan(DegToRad(deg));
        }

        public static double Cosec(double deg)
        {
            return (1.0 / Math.Sin(DegToRad(deg)));
        }    
    
        public static double Sec(double deg)
        {
            return (1.0 / Math.Cos(DegToRad(deg)));
        }

        public static double Cot(double deg)
        {
            return (1.0 / Math.Tan(DegToRad(deg)));
        }

        public static double Acos(double val)
        {
            return RadToDeg(Math.Acos(val));
        }

        public static double Asin(double val)
        {
            return RadToDeg(Math.Asin(val));
        }

        public static double Atan(double val)
        {
            return RadToDeg(Math.Atan(val));
        }

        public static double Cosh(double deg)
        {
            return Math.Cosh(DegToRad(deg));
        }

        public static double Sinh(double deg)
        {
            return Math.Sinh(DegToRad(deg));
        }

        public static double Tanh(double deg)
        {
            return Math.Tanh(DegToRad(deg));
        }

        public static double Cosech(double deg)
        {
            return (1.0 / Math.Sinh(DegToRad(deg)));
        }    
    
        public static double Sech(double deg)
        {
            return (1.0 / Math.Cosh(DegToRad(deg)));
        }

        public static double Coth(double deg)
        {
            return (1.0 / Math.Tanh(DegToRad(deg)));
        }
    
        public static double PutIn360Deg(double deg)
        {
            while (deg >= 360)
            {
                deg -= 360;
            }
            while (deg < 0)
            {
                deg += 360;
            }
            return deg;
        }

        public static double TanQuadrant(double x, double y, double tanValue)
        {
            if ((y >= 0) && (x >= 0))
            {
                while (tanValue >= 90)
                {
                    tanValue -= 90;
                }
                while (tanValue < 0)
                {
                    tanValue += 90;
                }
            }
            else if ((y < 0) && (x >= 0))
            {
                while (tanValue >= 360)
                {
                    tanValue -= 90;
                }
                while (tanValue < 270)
                {
                    tanValue += 90;
                }
            }
            else if ((y >= 0) && (x < 0))
            {
                while (tanValue >= 180)
                {
                    tanValue -= 90;
                }
                while (tanValue < 90)
                {
                    tanValue += 90;
                }
            }
            else if ((y < 0) && (x < 0))
            {
                while (tanValue >= 270)
                {
                    tanValue -= 90;
                }
                while (tanValue < 180)
                {
                    tanValue += 90;
                }
            }
            return tanValue;
        }

    }
}
