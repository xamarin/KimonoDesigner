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
		public static List<KimonoColor> SupportingColors = new List<KimonoColor>();

		/// <summary>
		/// A list of supporting gradients that are required for the object being converted
		/// to source code.
		/// </summary>
		public static List<KimonoGradient> SupportingGradients = new List<KimonoGradient>();

		/// <summary>
		/// A list of supporting styles that are required for the object being converted to
		/// source code.
		/// </summary>
		public static List<KimonoStyle> SupportingStyles = new List<KimonoStyle>();

		/// <summary>
		/// A collection of all of the object and varaible names currently used in code generation.
		/// </summary>
		public static List<string> UsedNames = new List<string>();

		/// <summary>
		/// List of all the supporting Global scoped properties used in code generation.
		/// </summary>
		public static List<KimonoProperty> GlobalProperties = new List<KimonoProperty>();

		/// <summary>
		/// List of all the supporting Local scoped properties used in code generation.
		/// </summary>
		public static List<KimonoProperty> LocalProperties = new List<KimonoProperty>();

		/// <summary>
		/// List of all the supporting Parameter scoped properties used in code generation.
		/// </summary>
		public static List<KimonoProperty> ParameterProperties = new List<KimonoProperty>();
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
			GlobalProperties.Clear();
			LocalProperties.Clear();
			ParameterProperties.Clear();
			UsedNames.Clear();
		}

		/// <summary>
		/// Checks to see if a name has already been used in generating source code.
		/// </summary>
		/// <returns><c>true</c>, if the name has already been used, <c>false</c> otherwise.</returns>
		/// <param name="name">The element name to test for.</param>
		public static bool NameUsed(string name)
		{
			// Scan all names
			foreach (string nameOnFile in UsedNames)
			{
				// Already used?
				if (nameOnFile == name) return true;
			}

			// Not used
			return false;
		}

		/// <summary>
		/// For Sketchs or Portfolios being output using the KimonoCore library,
		/// accumulate all of the supporting elements into a master Portfolio
		/// so that scripting will still work in the emitted object.
		/// </summary>
		/// <returns>The code to accumulate portfolio elements.</returns>
		/// <param name="portfolio">The name of the portfolio to accumulate into.</param>
		public static string CodeToAccumulatePortfolioElements(string portfolio)
		{
			var sourceCode = "// Accumulate Kimono objects into the portfolio\n";

			// Accumulate colors
			foreach (KimonoColor color in SupportingColors)
			{
				// Accumulate
				sourceCode += $"{portfolio}Colors.Add({color.ElementName});\n";
			}

			// Accumulate gradients
			foreach (KimonoGradient gradient in SupportingGradients)
			{
				// Accumulate
				sourceCode += $"{portfolio}Gradients.Add({gradient.ElementName});\n";
			}

			// Accumulate styles
			foreach (KimonoStyle style in SupportingStyles)
			{
				// Accumulate
				sourceCode += $"{portfolio}Styles.Add({style.ElementName});\n";
			}

			// Accumulate global properties
			foreach (KimonoProperty property in GlobalProperties)
			{
				// Accumulate
				sourceCode += $"{portfolio}Properties.Add({property.ElementName});\n";
			}

			// Accumulate local properties
			foreach (KimonoProperty property in LocalProperties)
			{
				// Accumulate
				sourceCode += $"{portfolio}Properties.Add({property.ElementName});\n";
			}

			// Accumulate parameter properties
			foreach (KimonoProperty property in ParameterProperties)
			{
				// Accumulate
				sourceCode += $"{portfolio}Properties.Add({property.ElementName});\n";
			}

			// Return results
			return sourceCode;
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
			// Is there a supporting color?
			if (color.BaseColor != null)
			{
				// Yes, add it to the supporting colors first
				AddSupportingColor(color.BaseColor);
			}

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
				sourceCode = AddCarriageIfNeeded(sourceCode);
				sourceCode += $"// Create new {supportColor.Name}\n";
				sourceCode += $"var {supportColor.ElementName} = {supportColor.ToCSharp(outputLibrary)};\n";
			}

			// Return generated source
			return sourceCode;
		}

		/// <summary>
		/// Returns the source code for all of the supporting colors used in generating
		/// a higher level Kimono object as a public computed propert.
		/// </summary>
		/// <returns>The source code for the supporting `KimonoColors`.</returns>
		/// <param name="outputLanguage">The `CodeOutputLanguage` for the generated code.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` of the generated code.</param>
		public static string PropertyForSupportingColors(CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";
			var classType = (outputLibrary == CodeOutputLibrary.SkiaSharp) ? "SKColor" : "KimonoColor";

			// Process all colors
			foreach (KimonoColor supportColor in SupportingColors)
			{
				// Accumulate color code
				sourceCode = AddCarriageIfNeeded(sourceCode);
				sourceCode += $"// Global color {supportColor.Name}\n";
				sourceCode += $"public static {classType} {supportColor.ElementName} " +
					"{get; set;} " +
					$"= {supportColor.ToCSharp(outputLibrary)};\n";
			}

			// Return generated source
			return sourceCode;
		}

		/// <summary>
		/// Returns the source code for all of the sketches used in generating
		/// a higher level Kimono object as a public computed propert.
		/// </summary>
		/// <returns>The source code for the supporting `KimonoColors`.</returns>
		/// <param name="outputLanguage">The `CodeOutputLanguage` for the generated code.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` of the generated code.</param>
		public static string PropertyForSketches(CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Process sketches
			foreach (KimonoSketch sketch in ObiScriptPortfolio.Portfolio.Sketches)
			{
				// Accumulate color code
				sourceCode = AddCarriageIfNeeded(sourceCode);
				sourceCode += $"// Global sketch {sketch.Name}\n";
				sourceCode += $"public static KimonoSketch {sketch.ElementName} " +
					"{get; set;}\n";
			}

			// Return generated source
			return sourceCode;
		}

		/// <summary>
		/// Returns the source code for all of the supporting colors used in generating
		/// a higher level Kimono object.
		/// </summary>
		/// <returns>The source code for the supporting `KimonoColors`.</returns>
		/// <param name="outputLanguage">The `CodeOutputLanguage` for the generated code.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` of the generated code.</param>
		public static string InitializerForSupportColors(CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Only valid for KimonoCode generation
			if (outputLibrary != CodeOutputLibrary.KimonoCore) return "";

			// Process all colors
			foreach (KimonoColor supportColor in SupportingColors)
			{
				// Accumulate gradient
				sourceCode = AddCarriageIfNeeded(sourceCode);
				sourceCode += supportColor.ConnectionsToKimonoCore();
			}

			// Return generated source
			return sourceCode;
		}

		/// <summary>
		/// Adds the supporting property to the correct list based on its usage.
		/// </summary>
		/// <returns>The element name of the newly added supporting property.</returns>
		/// <param name="property">The `KimonoProperty` to add.</param>
		public static string AddSupportingProperty(KimonoProperty property)
		{
			var elementName = "";

			// Does this property have a script?
			if (property.ObiScript != "")
			{
				// Is this property's script using any sub colors?
				foreach (KimonoColor color in ObiScriptPortfolio.Portfolio.Colors)
				{
					// Test for script
					if (property.ObiScript.Contains(color.Name))
					{
						// Yes, add as supporting
						AddSupportingColor(color);
					}
				}

				// Is this property's script using any sub gradients?
				foreach (KimonoGradient gradient in ObiScriptPortfolio.Portfolio.Gradients)
				{
					// Test for script
					if (property.ObiScript.Contains(gradient.Name))
					{
						// Yes, add as supporting
						AddSupportingGradient(gradient);
					}
				}

				// Is this property's script using any sub styles?
				foreach (KimonoStyle style in ObiScriptPortfolio.Portfolio.Styles)
				{
					// Test for script
					if (property.ObiScript.Contains(style.Name))
					{
						// Yes, add as supporting
						AddSupportingStyle(style);
					}
				}

				// Is this property's script using any sub properties?
				foreach (KimonoProperty scanProperty in ObiScriptPortfolio.Portfolio.Properties)
				{
					// Test for script
					if (property.ObiScript.Contains(scanProperty.Name))
					{
						// Yes, add this as a supporting property
						AddSupportingProperty(scanProperty);
					}
				}
			}

			// Take action based on the property's scope
			switch (property.Usage)
			{
				case KimonoPropertyUsage.GlobalVariable:
					elementName = AddSupportingGlobalProperty(property);
					break;
				case KimonoPropertyUsage.LocalVariable:
					elementName = AddSupportingLocalProperty(property);
					break;
				case KimonoPropertyUsage.Parameter:
					elementName = AddSupportingParameterProperty(property);
					break;
			}

			// Return the new element name
			return elementName;
		}

		/// <summary>
		/// Adds a new global scoped supporting property.
		/// </summary>
		/// <returns>The element name of the newly added supporting property.</returns>
		/// <param name="property">The `KimonoProperty` to add.</param>
		public static string AddSupportingGlobalProperty(KimonoProperty property)
		{
			// Scan all properties
			foreach (KimonoProperty supportProperty in GlobalProperties)
			{
				// Already in collection?
				if (supportProperty == property) return supportProperty.ElementName;
			}

			// Generate element name and add to collection
			property.ElementName = MakeElementName(property.Name);
			GlobalProperties.Add(property);

			// Return the new element name
			return property.ElementName;
		}

		/// <summary>
		/// Adds a new local scoped supporting property.
		/// </summary>
		/// <returns>The element name of the newly added supporting property.</returns>
		/// <param name="property">The `KimonoProperty` to add.</param>
		public static string AddSupportingLocalProperty(KimonoProperty property)
		{
			// Scan all properties
			foreach (KimonoProperty supportProperty in LocalProperties)
			{
				// Already in collection?
				if (supportProperty == property) return supportProperty.ElementName;
			}

			// Generate element name and add to collection
			property.ElementName = MakeElementName(property.Name);
			LocalProperties.Add(property);

			// Return the new element name
			return property.ElementName;
		}

		/// <summary>
		/// Adds a new parameter scoped supporting property.
		/// </summary>
		/// <returns>The element name of the newly added supporting property.</returns>
		/// <param name="property">The `KimonoProperty` to add.</param>
		public static string AddSupportingParameterProperty(KimonoProperty property)
		{
			// Scan all properties
			foreach (KimonoProperty supportProperty in ParameterProperties)
			{
				// Already in collection?
				if (supportProperty == property) return supportProperty.ElementName;
			}

			// Generate element name and add to collection
			property.ElementName = MakeElementName(property.Name);
			ParameterProperties.Add(property);

			// Return the new element name
			return property.ElementName;
		}

		/// <summary>
		/// Returns the source code for all of the supporting properties used in generating
		/// a higher level Kimono object.
		/// </summary>
		/// <returns>The source code for the supporting `KimonoProperty`.</returns>
		/// <param name="outputLanguage">The `CodeOutputLanguage` for the generated code.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` of the generated code.</param>
		public static string CodeForSupportGlobalProperties(CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Process all properties
			foreach (KimonoProperty supportProperty in GlobalProperties)
			{
				// Accumulate property
				sourceCode = AddCarriageIfNeeded(sourceCode);
				sourceCode += supportProperty.ToCode(CodeOutputOS.CrossPlatform, outputLanguage, outputLibrary);
			}

			// Return generated source
			return sourceCode;
		}

		/// <summary>
		/// Returns the source code for all of the supporting properties used in generating
		/// a higher level Kimono object.
		/// </summary>
		/// <returns>The source code for the supporting `KimonoProperty`.</returns>
		/// <param name="outputLanguage">The `CodeOutputLanguage` for the generated code.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` of the generated code.</param>
		public static string CodeForSupportLocalProperties(CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Process all properties
			foreach (KimonoProperty supportProperty in LocalProperties)
			{
				// Accumulate property
				sourceCode = AddCarriageIfNeeded(sourceCode);
				sourceCode += supportProperty.ToCode(CodeOutputOS.CrossPlatform, outputLanguage, outputLibrary);
			}

			// Return generated source
			return sourceCode;
		}

		/// <summary>
		/// Returns the source code for all of the supporting properties used in generating
		/// a higher level Kimono object.
		/// </summary>
		/// <returns>The source code for the supporting `KimonoProperty`.</returns>
		/// <param name="outputLanguage">The `CodeOutputLanguage` for the generated code.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` of the generated code.</param>
		public static string CodeForSupportParameterProperties(CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Process all properties
			foreach (KimonoProperty supportProperty in ParameterProperties)
			{
				// Accumulate property
				if (sourceCode != "") sourceCode += ", ";
				sourceCode += supportProperty.ToCode(CodeOutputOS.CrossPlatform, outputLanguage, outputLibrary);
			}

			// Return generated source
			return sourceCode;
		}

		/// <summary>
		/// Returns the initializers for all of the supporting properties used in generating
		/// a higher level Kimono object.
		/// </summary>
		/// <returns>The source code for the supporting `KimonoProperty`.</returns>
		/// <param name="outputLanguage">The `CodeOutputLanguage` for the generated code.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` of the generated code.</param>
		public static string CodeForInitializeParameterProperties(CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Process all properties
			foreach (KimonoProperty supportProperty in ParameterProperties)
			{
				// Accumulate property
				if (sourceCode != "") sourceCode += ", ";
				sourceCode += supportProperty.ElementName;
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
				sourceCode = AddCarriageIfNeeded(sourceCode);
				sourceCode += supportingGradient.ToCSharp(outputLibrary);
			}

			// Return generated source
			return sourceCode;
		}

		/// <summary>
		/// Returns the source code for all of the supporting colors used in generating
		/// a higher level Kimono object as a public computed propert.
		/// </summary>
		/// <returns>The source code for the supporting `KimonoColors`.</returns>
		/// <param name="outputLanguage">The `CodeOutputLanguage` for the generated code.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` of the generated code.</param>
		public static string PrivateVariablesForSupportingGradients(CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Process all colors
			foreach (KimonoGradient supportingGradient in SupportingGradients)
			{
				// Accumulate color code
				sourceCode = AddCarriageIfNeeded(sourceCode);
				sourceCode += $"// Private gradient {supportingGradient.Name} vairables\n";
				sourceCode += $"private SKColor[] {supportingGradient.ElementName}Colors;\n" +
					$"private float[] {supportingGradient.ElementName}Weights;\n";
			}

			// Return generated source
			return sourceCode;
		}

		/// <summary>
		/// Returns the source code for all of the supporting colors used in generating
		/// a higher level Kimono object as a public computed propert.
		/// </summary>
		/// <returns>The source code for the supporting `KimonoColors`.</returns>
		/// <param name="outputLanguage">The `CodeOutputLanguage` for the generated code.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` of the generated code.</param>
		public static string PropertyForSupportingGradients(CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";
			var classType = (outputLibrary == CodeOutputLibrary.SkiaSharp) ? "SKShader" : "KimonoGradient";

			// Process all colors
			foreach (KimonoGradient supportingGradient in SupportingGradients)
			{
				// Accumulate color code
				sourceCode = AddCarriageIfNeeded(sourceCode);
				sourceCode += $"// Global gradient {supportingGradient.Name}\n";
				sourceCode += $"public static {classType} {supportingGradient.ElementName} " +
					"{get; set;}\n";
			}

			// Return generated source
			return sourceCode;
		}

		/// <summary>
		/// Returns the source code for all of the supporting gradients used in generating
		/// a higher level Kimono object.
		/// </summary>
		/// <returns>The source code for the supporting `KimonoGradients`.</returns>
		/// <param name="outputLanguage">The `CodeOutputLanguage` for the generated code.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` of the generated code.</param>
		public static string InitializerForSupportGradients(CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Process all gradients
			foreach (KimonoGradient supportingGradient in SupportingGradients)
			{
				// Accumulate gradient
				sourceCode = AddCarriageIfNeeded(sourceCode);
				sourceCode += supportingGradient.ToCSharpInitializer(outputLibrary);
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
				sourceCode = AddCarriageIfNeeded(sourceCode);
				sourceCode += supportingStyle.ToCSharp(outputLibrary);
			}

			// Return generated source
			return sourceCode;
		}

		/// <summary>
		/// Returns the source code for all of the supporting colors used in generating
		/// a higher level Kimono object as a public computed propert.
		/// </summary>
		/// <returns>The source code for the supporting `KimonoColors`.</returns>
		/// <param name="outputLanguage">The `CodeOutputLanguage` for the generated code.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` of the generated code.</param>
		public static string PropertyForSupportingStyles(CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Process all colors
			foreach (KimonoStyle supportingStyle in SupportingStyles)
			{
				// Accumulate color code
				sourceCode = AddCarriageIfNeeded(sourceCode);
				sourceCode += $"// Global style {supportingStyle.Name}\n";

				// Take action based on library
				switch (outputLibrary)
				{
					case CodeOutputLibrary.SkiaSharp:
						if (supportingStyle.HasFill)
						{
							sourceCode += $"public static SKPaint {supportingStyle.ElementName}FillPaint " +
								"{get; set;}\n";
						}

						if (supportingStyle.HasFill)
						{
							sourceCode += $"public static SKPaint {supportingStyle.ElementName}FramePaint " +
								"{get; set;}\n";
						}
						break;
					case CodeOutputLibrary.KimonoCore:
						sourceCode += $"public static KimonoStyle {supportingStyle.ElementName} " +
							"{get; set;}\n";
						break;
				}
			}

			// Return generated source
			return sourceCode;
		}

		/// <summary>
		/// Returns the source code for all of the supporting styles used in generating
		/// a higher level Kimono object.
		/// </summary>
		/// <returns>The source code for the supporting `KimonoGradients`.</returns>
		/// <param name="outputLanguage">The `CodeOutputLanguage` for the generated code.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` of the generated code.</param>
		public static string InitializerForSupportStyles(CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Process all gradients
			foreach (KimonoStyle supportingStyle in SupportingStyles)
			{
				// Accumulate gradient
				sourceCode = AddCarriageIfNeeded(sourceCode);
				sourceCode += supportingStyle.ToCSharpInitializer(outputLibrary);
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
						elementName += $"Skia{c}";
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

				// Clear state
				isFirstLetter = false;
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

			// Has this name already been used?
			while (NameUsed(elementName))
			{
				// Increment the name
				elementName = Kimono.IncrementName(elementName).Replace(" ","");
			}

			// Save name in the collection of used names
			UsedNames.Add(elementName);

			// Return resulting name
			return elementName;
		}

		/// <summary>
		/// Adds a carriage return to the source code if it is required to "pretty print"
		/// the source in a human readable format.
		/// </summary>
		/// <returns>The source with a carriage return if needed.</returns>
		/// <param name="sourceCode">The source code to test for a carriage return requirement.</param>
		public static string AddCarriageIfNeeded(string sourceCode)
		{
			// Is a carriage return required?
			if (sourceCode == "")
			{
				// No, return string as is
				return sourceCode;
			}
			else
			{
				// Yes, insert a blank line between items in the source code.
				return $"{sourceCode}\n";
			}
		}

		/// <summary>
		/// Increases the indent level of the given section of source code by the given
		/// number of levels
		/// </summary>
		/// <returns>The indent level.</returns>
		/// <param name="sourceCode">Source code.</param>
		/// <param name="levels">Levels.</param>
		public static string IncreaseIndentLevel(string sourceCode, int levels)
		{
			// Add the required number of levels
			for (int n = 0; n < levels; ++n)
			{
				sourceCode = IncreaseIndentLevel(sourceCode);
			}
			
			// Return adjusted source
			return sourceCode;
		}

		/// <summary>
		/// Increases the indent level of the given section of source code.
		/// </summary>
		/// <returns>The source code indented by one tab.</returns>
		/// <param name="sourceCode">The source code to indent.</param>
		public static string IncreaseIndentLevel(string sourceCode)
		{
			return "\t" + sourceCode.Replace("\n", "\n\t");
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
