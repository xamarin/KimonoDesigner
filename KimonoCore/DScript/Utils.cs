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

namespace DScript
{
	internal static class Utils
	{
		public static bool IsWhitespace(this char ch)
		{
			return (ch == ' ') || (ch == '\t') || (ch == '\n') || (ch == '\r');
		}

		public static bool IsNumeric(this char ch)
		{
			return (ch >= '0') && (ch <= '9');
		}

		public static bool IsNumber(this String str)
		{
			Int32 c = str.Length;
			for (Int32 i = 0; i < c; i++)
			{
				if (!IsNumeric(str[i])) return false;
			}
			return true;
		}

		public static bool IsHexadecimal(this char ch)
		{
			return ((ch >= '0') && (ch <= '9')) || ((ch >= 'a') && (ch <= 'f')) || ((ch >= 'A') && (ch <= 'F'));
		}

		public static bool IsAlpha(this char ch)
		{
			return ((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')) || ch == '_';
		}

		public static bool IsIDString(this String str)
		{
			Int32 c = str.Length;
			for (Int32 i = 0; i < c; i++)
			{
				if (IsNumeric(str[i]) || !IsAlpha(str[i])) return false;
			}
			return true;
		}

		public static String GetJSString(this String str)
		{
			String oStr = str;
			
			for (int x = 0; x < oStr.Length; x++)
			{
				String replaceWith = "";
				bool replace = true;
				switch (oStr[x])
				{
					case '\\':
						replaceWith = "\\\\";
						break;
					case '\n':
						replaceWith = "\\n";
						break;
					case '\r':
						replaceWith = "\\r";
						break;
					case '\a':
						replaceWith = "\\a";
						break;
					case '"':
						replaceWith = "\\\"";
						break;
					default:
					{
						Int32 nCh = ((Int32) oStr[x]) & 0xFF;
						if (nCh < 32 || nCh > 127)
						{
							replaceWith = String.Format("\\x{0:x2}", nCh);
						}
						else
						{
							replace = false;
						}
					}
						break;
				}

				if (replace)
				{
					oStr = oStr.Substring(0, x) + replaceWith + oStr.Substring(x + 1);
					x += replaceWith.Length - 1;
				}
			}

			return String.Format("\"{0}\"", oStr);
		}
	}
}
