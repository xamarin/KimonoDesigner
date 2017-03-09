using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeGenFSharp
{
	public static class GeneratorUtils
	{
		/// <summary>
		/// Outputs the string representations of the IEnumerable elements on individual lines
		/// </summary>
		/// <returns>A string with each element's string representation on its own line.</returns>
		/// <param name="self">The IEnumerable</param>
		/// <typeparam name="T">The type parameter of the IEnumerable.</typeparam>
		public static string ToLines<T>(this IEnumerable<T> self)
		{
			return self.BuildString(Environment.NewLine);
		}

		/// <summary>
		/// Concatenates ToString() results, with a separator that defaults to ", "
		/// </summary>
		/// <returns>A concatenated string.</returns>
		/// <param name="self"><c>this</c> object sequence</param>
		/// <param name="separator">The string to place between strings.</param>
		/// <typeparam name="T">The type of the objects in the sequence. ToString() implicitly called.</typeparam>
		public static string BuildString<T>(this IEnumerable<T> self, string separator = ", ")
		{
			return self.Aggregate("", (accum, current) => accum + separator + current);
		}

		// Helper for BuildFunctionCall. For some reason, couldn't do this in a local func
		private static IEnumerable<String> EnumerateArgs(IEnumerator<String> en)
		{
			while (en.MoveNext())
			{
				yield return en.Current;
			}
		}

		public static IEnumerable<T> AppendAll<T>(this T self, IEnumerable<T> tail)
		{
			yield return self;
			foreach (var t in tail) yield return t;
		}

		public static IEnumerable<T> Append<T>(this IEnumerable<T> self, IEnumerable<T> tail)
		{
			return self.Concat(tail);
		}

		public static IEnumerable<T> Append<T>(this IEnumerable<T> self, T tail)
		{
			foreach(var s in self) yield return s;
			yield return tail;
		}

		public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> self) => self.SelectMany( s => s);

		public static IEnumerable<string> BuildConditionalCompilation(string predicateExpr, IEnumerable<string> snippets)
		{
			yield return "#if " + predicateExpr;
			foreach (var s in snippets) yield return s;
			yield return "#endif";
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