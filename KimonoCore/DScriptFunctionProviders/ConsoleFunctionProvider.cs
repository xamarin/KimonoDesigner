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
using System.Diagnostics;

namespace DScript.FunctionProviders
{
	[ScriptClass("Console")]
	public class ConsoleFunctionProvider
	{
		public static void WriteLine(String text, object userData)
		{
#if WINDOWS_UWP
            Debug.WriteLine(text);
#else
            Console.WriteLine(text);
#endif
        }

        public static String ReadLine(object userData)
		{
#if WINDOWS_UWP
            String retVal = "";
#else
            String retVal = Console.ReadLine();
#endif
            return retVal;
		}

		public static void Write(String text, object userData)
		{
#if WINDOWS_UWP
            Debug.Write(text);
#else
            Console.Write(text);
#endif
        }

		public static Int32 ReadChar(object userData)
		{
#if WINDOWS_UWP
            Int32 retVal = 0;
#else
            Int32 retVal = Console.Read();
#endif

            return retVal;
		}
	}
}
