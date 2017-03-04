using System;
using System.Collections.Generic;
using System.Linq;
using SkiaSharp;

namespace KimonoCore 
{
public static class GeneratorUtils
{
      /// <summary>
      /// Outputs the string representations of the IEnumerable elements on individual lines
      /// </summary>
      /// <returns>A string with each element's string representation on its own line.</returns>
      /// <param name="self">The IEnumerable</param>
      /// <typeparam name="T">The type parameter of the IEnumerable.</typeparam>
      public static string ToLines<T> (this IEnumerable<T> self)
      {
         return self.BuildString(Environment.NewLine);
      }

      public static string BuildString<T> (this IEnumerable<T> self, string separator = ", ")
      {
         return self.Aggregate ("", (accum, current) => accum + separator + current);
      }

      // Helper for BuildFunctionCall. For some reason, couldn't do this in a local func
      private static IEnumerable<String> EnumerateArgs(IEnumerator<String> en)
      {
         while (en.MoveNext())
         {
               yield return en.Current;
         }
      }

      /// <summary>
      /// Treats the Head of the IEnumerable as the function name and the Tail as args
      /// </summary>
      public static string BuildFunctionCall(this IEnumerable<string> self)
      {
         var enumerator = self.GetEnumerator();
         enumerator.MoveNext();
         var functionName = enumerator.Current;
         //TODO: Hoist args out of tuple form? (Idiomatic but unnecessary?)
         var args = EnumerateArgs(enumerator).BuildString();
         return functionName + "(" + args + ")";
      }
}
}