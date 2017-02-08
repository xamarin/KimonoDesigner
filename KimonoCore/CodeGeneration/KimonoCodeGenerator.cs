using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// The Kimono Code Generator has routine to assist in the generation of
	/// output source code.
	/// </summary>
	public static class KimonoCodeGenerator
	{
		#region Global Variables
		/// <summary>
		/// The next element number.
		/// </summary>
		public static int NextElementNumber = 0;

		/// <summary>
		/// Add number to element names when generating.
		/// </summary>
		public static bool AddNumberToElementNames = false;
		#endregion

		#region Public Methods
		/// <summary>
		/// Resets the code generation.
		/// </summary>
		public static void ResetCodeGeneration()
		{
			// Returns the generator to the default state
			NextElementNumber = 0;
			AddNumberToElementNames = false;
		}

		/// <summary>
		/// Makes a valid source code name for the name of a given Kimono Object.
		/// </summary>
		/// <returns>The element name valid for use in source code.</returns>
		/// <param name="name">The source Kimono Object name.</param>
		/// <param name="addNumber">If set to <c>true</c>, adds a unique number to the end of the output code.</param>
		public static string MakeElementName(string name)
		{
			var elementName = "";
			var isFirstLetter = true;

			// Scan all characters of the incomming characters
			foreach (char c in name)
			{
				// Is this a valid character?
				if (Kimono.CharIsNumber(c))
				{
					// Is this the first letter?
					if (isFirstLetter)
					{
						// Yes, not valid at the start of a name
						elementName += $"skia{c}";
					}
					else
					{
						// No, always valid
						elementName += c;
					}
				}
				else if (Kimono.CharIsLetter(c))
				{
					// Always valid, add
					elementName += c;
				}
			}

			// Was a name generated at all?
			if (elementName == "")
			{
				// No, make one
				elementName = $"skiaElement{++NextElementNumber}";
			}
			else if (AddNumberToElementNames)
			{
				// Append number to element name
				elementName = $"{elementName}{++NextElementNumber}";
			}

			// Return resulting name
			return elementName;
		}

		/// <summary>
		/// Converts the given color to code using the given library.
		/// </summary>
		/// <returns>The color as code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to encode to.</param>
		/// <param name="color">The `SKColor` to create code for.</param>
		public static string ColorToCode(CodeOutputLibrary outputLibrary, SKColor color)
		{
			var sourceCode = "";

			// Take action based on the language type
			switch (outputLibrary)
			{
				case CodeOutputLibrary.SkiaSharp:
					sourceCode = $"new SKColor({color.Red}, {color.Green}, {color.Blue}, {color.Alpha})";
					break;
				case CodeOutputLibrary.KimonoCore:
					sourceCode = $"new KimonoColor({color.Red}, {color.Green}, {color.Blue}, {color.Alpha})";
					break;
			}
			
			// Return results
			return sourceCode;
		}

		/// <summary>
		/// Converts the given point to code using the given library.
		/// </summary>
		/// <returns>The point as code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to encode to.</param>
		/// <param name="point">The `SKPoint` to encode.</param>
		public static string PointToCode(CodeOutputLibrary outputLibrary, SKPoint point)
		{
			var sourceCode = "";

			// Take action based on the language type
			switch (outputLibrary)
			{
				case CodeOutputLibrary.SkiaSharp:
					sourceCode = $"new SKPoint({point.X},{point.Y})";
					break;
				case CodeOutputLibrary.KimonoCore:
					sourceCode = $"new KimonoHandle({point.X},{point.Y})";
					break;
			}

			// Return results
			return sourceCode;
		}

		/// <summary>
		/// Converts the given point to code using the given library.
		/// </summary>
		/// <returns>The point as code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to encode to.</param>
		/// <param name="point">The `KimonoHandle` to encode.</param>
		public static string PointToCode(CodeOutputLibrary outputLibrary, KimonoHandle point)
		{
			var sourceCode = "";

			// Take action based on the language type
			switch (outputLibrary)
			{
				case CodeOutputLibrary.SkiaSharp:
					sourceCode = $"new SKPoint({point.X},{point.Y})";
					break;
				case CodeOutputLibrary.KimonoCore:
					sourceCode = $"new KimonoHandle({point.X},{point.Y})";
					break;
			}

			// Return results
			return sourceCode;
		}
		#endregion
	}
}
