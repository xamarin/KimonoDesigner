using System;
using System.Collections.Generic;
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

		/// <summary>
		/// A list of supporting colors that are required for the object being converted
		/// to source code.
		/// </summary>
		public static List<KimonoColor> SupportingColors;

		/// <summary>
		/// A list of supporting gradients that are required for the object being converted
		/// to source code.
		/// </summary>
		public static List<KimonoGradient> SupportingGradients;

		/// <summary>
		/// A list of supporting styles that are required for the object being converted to
		/// source code.
		/// </summary>
		public static List<KimonoStyle> SupportingStyles;
		#endregion

		#region Static Constructors
		static KimonoCodeGenerator()
		{
			// Allocate storage for lists
			SupportingColors = new List<KimonoColor>();
			SupportingGradients = new List<KimonoGradient>();
			SupportingStyles = new List<KimonoStyle>();
		}
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
			SupportingColors.Clear();
			SupportingGradients.Clear();
			SupportingStyles.Clear();
		}

		/// <summary>
		/// Adds the given color to the collection of named colors that are used
		/// in the generation of other Kimono Objects. If a color is already in
		/// the collection, its `ElementName` is returned.
		/// </summary>
		/// <returns>The `ElementName` for the supporting color.</returns>
		/// <param name="color">The `KimonoColor` to add to the collection.</param>
		public static string AddSupportingColor(KimonoColor color)
		{
			// Scan all colors
			foreach (KimonoColor supportColor in SupportingColors)
			{
				// Already in collection?
				if (supportColor == color) return supportColor.ElementName;
			}

			// Generate element name and add to collection
			color.ElementName = MakeElementName(color.Name);
			SupportingColors.Add(color);

			// Return the new element name
			return color.ElementName;
		}

		/// <summary>
		/// Returns the source code for all of the supporting colors used in generating
		/// a higher level Kimono object.
		/// </summary>
		/// <returns>The source code for the supporting `KimonoColors`.</returns>
		/// <param name="outputLanguage">The `CodeOutputLanguage` for the generated code.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` of the generated code.</param>
		public static string CodeForSupportingColors(CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Process all colors
			foreach (KimonoColor supportColor in SupportingColors)
			{
				// Accumulate color code
				sourceCode += $"// Create new {supportColor.Name}\n";
				sourceCode += $"var {supportColor.ElementName} = {ColorToCode(outputLibrary, supportColor.Color)};\n\n";
			}

			// Return generated source
			return sourceCode;
		}

		/// <summary>
		/// Adds the given gradient to the collection of named gradients that are used
		/// in the generation of other Kimono Objects. If a gradient is already in
		/// the collection, its `ElementName` is returned.
		/// </summary>
		/// <returns>The `ElementName` for the supporting gradient.</returns>
		/// <param name="gradient">The `KimonoGradient` to add.</param>
		public static string AddSupportingGradient(KimonoGradient gradient)
		{
			// Scan all gradients
			foreach (KimonoGradient supportingGradient in SupportingGradients)
			{
				// Already in the collection?
				if (supportingGradient == gradient) return supportingGradient.ElementName;
			}

			// Generate element name and add to collection
			gradient.ElementName = MakeElementName(gradient.Name);
			SupportingGradients.Add(gradient);

			// Return the new element name
			return gradient.ElementName;
		}

		/// <summary>
		/// Returns the source code for all of the supporting gradients used in generating
		/// a higher level Kimono object.
		/// </summary>
		/// <returns>The source code for the supporting `KimonoGradients`.</returns>
		/// <param name="outputLanguage">The `CodeOutputLanguage` for the generated code.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` of the generated code.</param>
		public static string CodeForSupportGradients(CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Process all gradients
			foreach (KimonoGradient supportingGradient in SupportingGradients)
			{
				// Accumulate gradient
				sourceCode += supportingGradient.ToCSharp(outputLibrary) + "\n";
			}

			// Return generated source
			return sourceCode;
		}

		/// <summary>
		/// Adds the given style to the collection of named styles that are used
		/// in the generation of other Kimono Objects. If a style is already in
		/// the collection, its `ElementName` is returned.
		/// </summary>
		/// <returns>The `ElementName` for the supporting style.</returns>
		/// <param name="style">The `KimonoStyle` to add.</param>
		public static string AddSupportingStyle(KimonoStyle style)
		{
			// Scan all styles
			foreach (KimonoStyle supportingStyle in SupportingStyles)
			{
				// Already in the collection?
				if (supportingStyle == style) return supportingStyle.ElementName;
			}

			// Generate element name and add to collection
			style.ElementName = MakeElementName(style.Name);
			SupportingStyles.Add(style);

			// Return the new element name
			return style.ElementName;
		}

		/// <summary>
		/// Returns the source code for all of the supporting styles used in generating
		/// a higher level Kimono object.
		/// </summary>
		/// <returns>The source code for the supporting `KimonoGradients`.</returns>
		/// <param name="outputLanguage">The `CodeOutputLanguage` for the generated code.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` of the generated code.</param>
		public static string CodeForSupportStyles(CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Process all gradients
			foreach (KimonoStyle supportingStyle in SupportingStyles)
			{
				// Accumulate gradient
				sourceCode += supportingStyle.ToCSharp(outputLibrary) + "\n";
			}

			// Return generated source
			return sourceCode;
		}

		/// <summary>
		/// Makes a valid source code name for the name of a given Kimono Object.
		/// </summary>
		/// <returns>The element name valid for use in source code.</returns>
		/// <param name="name">The source Kimono Object name.</param>
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
					sourceCode = $"new SKPoint({point.X}f, {point.Y}f)";
					break;
				case CodeOutputLibrary.KimonoCore:
					sourceCode = $"new KimonoHandle({point.X}f, {point.Y}f)";
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
					sourceCode = $"new SKPoint({point.X}f, {point.Y}f)";
					break;
				case CodeOutputLibrary.KimonoCore:
					sourceCode = $"new KimonoHandle({point.X}f, {point.Y}f)";
					break;
			}

			// Return results
			return sourceCode;
		}
		#endregion
	}
}
