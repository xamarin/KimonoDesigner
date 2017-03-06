using System;
using System.Linq;

namespace AppKit.TextKit.Formatter
{
	public class FSharpDescriptor : LanguageDescriptor
	{
		public override string LanguageIdentifier { get; } = "F#";

		public override char[] LanguageSeparators { get; set; } = new char[] { '=', '+', '-', '*', '/', '%', '&', '<', '>', ';', ':', '^', '!', '~', '?', ',', '"', '\'', '(', ')', '[', ']', '{', '}' };

		public FSharpDescriptor()
		{
		}

		//TODO: Complete this
		public override void Define()
		{
			// Call base class
			base.Define();

			//Source https://docs.microsoft.com/en-us/dotnet/articles/fsharp/language-reference/keyword-reference
			var keywordsAndDescriptions = new[]
			{
				"abstract", "Indicates a method that either has no implementation in the type in which it is declared or that is virtual and has a default implementation.",
				"and", "Used in mutually recursive bindings, in property declarations, and with multiple constraints on generic parameters.",
				"as", "Used to give the current class object an object name. Also used to give a name to a whole pattern within a pattern match.",
				"assert", "Used to verify code during debugging."
			};

			var	keywordTuples = keywordsAndDescriptions.Zip(keywordsAndDescriptions.Skip(1), (first, second) => new Tuple<string,string>(first, second));
			foreach (var tuple in keywordTuples)
			{
				Keywords.Add(tuple.Item1, new KeywordDescriptor(KeywordType.ValueType, ValueTypeColor, tuple.Item2));
			}
			                     
		}

		/// <summary>
		/// Formats the passed in string of text for previewing.
		/// </summary>
		/// <returns>The string formatted for preview.</returns>
		/// <param name="text">Text.</param>
		public override string FormatForPreview(string text)
		{
			return "<pre><code>" + text + "</code></pre>";
		}
	}
}
