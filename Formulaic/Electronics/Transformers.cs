using System;

namespace Formulaic.Electronics
{
    public static class Transformers
    {
        //Gives turn ratio as {return val} to 1
        public static double TransformerRatio(double primaryImp, double secondaryImp)
        {

            double ratio = Math.Sqrt(primaryImp / secondaryImp);
            ratio = Math.Floor((10.0 * ratio) + 0.5) / 10.0;

            return ratio;
        }
    }
}
