using System;
using System.Collections.Generic;

namespace Formulaic.DataAnalytics
{

    public static class Interpolation
    {

        //Interpolate y value from equation y = mx + b
        public static double InterpolateLinearY(double m, double b, double x)
        {
            return (m * x) + b;
        }

        //Interpolate x value from equation y = mx + b
        public static double InterpolateLinearX(double m, double b, double y)
        {
            return (y - b) / m;
        }

        //Interpolate y value from equation y = b(10^m)^x
        public static double InterpolateLogOrdinateY(double m, double b, double x)
        {
            return b * Math.Pow(Math.Pow(10, m), x);
        }

        //Interpolate x value from equation y = b(10^m)^x
        public static double InterpolateLogOrdinateX(double m, double b, double y)
        {

            //TODO
            throw new NotImplementedException();
        }

        //Interpolate y value from equation y = m*log(x)/log(10) + b
        public static double InterpolateLogAbscissaY(double m, double b, double x)
        {
            return (m * Math.Log10(x)) + b;
        }
 
        //Interpolate x value from equation y = m*log(x)/log(10) + b
        public static double InterpolateLogAbscissaX(double m, double b, double y)
        {
            return Math.Pow(10, ((y - b) / m));
        }

        //Interpolate y value from equation y = b*x^m
        public static double InterpolateLogFullY(double m, double b, double x)
        {
            return (b * Math.Pow(x, m));
        }

        //Interpolate x value from equation y = b*x^m
        public static double InterpolateLogFullX(double m, double b, double y)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
