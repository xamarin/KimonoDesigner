/*
Copyright (c) 2014 Darren Horrocks

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;

namespace DScript.FunctionProviders
{
	[ScriptClass("Math", PropertiesAsObjects = true)]
	public class MathFunctionProvider
	{
		public static double Pi
		{
			get { return Math.PI; }
		}

		public static double E()
		{
			return Math.E;
		}

		public static double Abs(double v, object userdata)
		{
			return Math.Abs(v);
		}

		public static double Round(double val, int digits, object userdata)
		{
			return Math.Round(val, digits);
		}

		public static double Ceil(double val, object userdata)
		{
			return Math.Ceiling(val);
		}

		public static double Floor(double val, object userdata)
		{
			return Math.Floor(val);
		}

		public static double Min(double a, double b, object userdata)
		{
			return Math.Min(a, b);
		}

		public static double Max(double a, double b, object userdata)
		{
			return Math.Max(a, b);
		}

		public static double Range(double a, double b, double x, object userdata)
		{
			return (x < a ? a : (x > b ? b : a));
		}

		public static double Sign(double val, object userdata)
		{
			return Math.Sign(val);
		}

		public static double Sin(double val, object userdata)
		{
			return Math.Sin(val);
		}

		public static double Cos(double val, object userdata)
		{
			return Math.Cos(val);
		}

		public static double Tan(double val, object userdata)
		{
			return Math.Tan(val);
		}

		public static double Sinh(double val, object userdata)
		{
			return Math.Sinh(val);
		}

		public static double Cosh(double val, object userdata)
		{
			return Math.Cosh(val);
		}

		public static double Tanh(double val, object userdata)
		{
			return Math.Tanh(val);
		}

		public static double ASin(double val, object userdata)
		{
			return Math.Asin(val);
		}

		public static double ACos(double val, object userdata)
		{
			return Math.Acos(val);
		}

		public static double ATan(double val, object userdata)
		{
			return Math.Atan(val);
		}

		public static double ASinh(double val, object userdata)
		{
			double returnVal;

			if (val > 0)
			{
				returnVal = Math.Log(val + Math.Sqrt(val * val + 1));
			}
			else
			{
				returnVal = -Math.Log(-val + Math.Sqrt(val * val + 1));
			}

			return returnVal;
		}

		public static double ACosh(double val, object userdata)
		{
			double returnVal;

			if (val > 0)
			{
				returnVal = Math.Log(val + Math.Sqrt(val * val - 1));
			}
			else
			{
				returnVal = -Math.Log(-val + Math.Sqrt(val * val - 1));
			}

			return returnVal;
		}

		public static double ATan2(double a, double b, object userdata)
		{
			return Math.Atan2(a, b);
		}

		public static double Pow(double a, double b, object userdata)
		{
			return Math.Pow(a, b);
		}

		public static double Sqrt(double val, object userdata)
		{
			return Math.Sqrt(val);
		}

		public static double Log(double val, object userdata)
		{
			return Math.Log(val);
		}

		public static double Log10(double val, object userdata)
		{
			return Math.Log10(val);
		}

		public static double Exp(double val, object userdata)
		{
			return Math.Exp(val);
		}
	}
}
