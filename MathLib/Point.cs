using System;

namespace MathLib
{
	/// <summary>
	/// Class encapsulating a cartestian coodinates of a point
	/// </summary>
	public class Point
	{
        private double _x;
        private double _y;
		

		public Point(double x, double y)
		{
			_x = x;
			_y = y;
		}

		public Point()
		{
			_x = 0;
			_y = 0;
		}

		public void SetXY(double x, double y)
		{
            _x = x;
            _y = y;
        }


		public double X
		{
			get
			{
				return _x;
			}
			set
			{
				_x = value;
			}
		}

		public double Y
		{
			get
			{
				return _y;
			}
			set
			{
				_y = value;
			}
		}
        

		public void GetPolarCoords(ref double r, ref double theta)
		{
			r = Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_x, 2));
			theta = Math.Atan(_y / _x);
			theta = Trig.RadToDeg(theta);
			theta = Trig.TanQuadrant(_x, _y, theta);
		}

		public void SetPolarCoords(double r, double theta)
		{
			_x = r * Trig.Cos(theta);
			_y = r * Trig.Sin(theta);
		}

		public void Translate(double newXOrigin, double newYOrigin)
		{
			_x -= newXOrigin;
			_y -= newYOrigin;
		}
	}
}
