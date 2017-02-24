using System;
using SkiaSharp;
using DScript;
using TextBase;

namespace KimonoCore
{
	/// <summary>
	/// Defines a `KimonoProperty` that represents a `string` value.
	/// </summary>
	[Table("TextProperty")]
	public class KimonoPropertyText : KimonoProperty
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
		public string Value { get; set; } = "";
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoPropertyText"/> class.
		/// </summary>
		public KimonoPropertyText()
		{
			// Initialize
			Name = "Text Property";
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Evaluate this instance by executing any attached Obi Script to get the new
		/// value for the `KimonoProperty`.
		/// </summary>
		/// <returns>The result of the Obi Script execution as a `ObiScriptResult`.</returns>
		public override ObiScriptResult Evaluate()
		{
			// Is there a script attached?
			if (GetsValueFromScript)
			{
				// Execute the script to get the new value
				ObiScriptEngine.Runtime.Execute(ObiScript);

				// Was the script successful?
				if (ObiScriptEngine.EvaluationResult.Successful)
				{
					// Was the right type returned?
					if (ObiScriptEngine.EvaluationResult.Value is string)
					{
						// Yes, save it
						Value = ObiScriptEngine.EvaluationResult.Value as string;
					}
					else
					{
						// Report this as an error
						ObiScriptEngine.EvaluationResult.Successful = false;
						ObiScriptEngine.EvaluationResult.ErrorMessage = "Error: Script did not return a string value. " +
							"Call `Return.Text(\"value\");` to return the required value.";
					}
				}
			}

			// Return the result of executing the script
			return ObiScriptEngine.EvaluationResult;
		}
		#endregion

		#region Conversion Routines
		/// <summary>
		/// Converts this `KimonoProperty` to a `string`.
		/// </summary>
		/// <returns>The `string` value.</returns>
		public override string ToString()
		{
			return Value;
		}

		/// <summary>
		/// Converts the text value to a scriptable string.
		/// </summary>
		/// <returns>The to string.</returns>
		public virtual string TextToString()
		{
			// Make required adjustments
			var sourceCode = Value.Replace("\"", @"\" + "\"");
			sourceCode = sourceCode.Replace("\t", @"\t");
			sourceCode = sourceCode.Replace("\n", @"\n");

			// Return results
			return sourceCode;
		}

		/// <summary>
		/// Converts to KimonoCore based source code
		/// </summary>
		/// <returns>The property as a KimonoCore object.</returns>
		public override string ToKimonoCore()
		{
			var sourceCode = "new KimonoPropertyText() {\n" +
				$"\tName = \"{Name}\",\n" +
				$"\tGetsValueFromScript = {GetsValueFromScript.ToString().ToLower()},\n" +
				$"\tObiScript = \"{ScriptToString()}\",\n" +
				$"\tValue = \"{TextToString()}\"\n" +
				"};\n";

			// Return results
			return sourceCode;
		}

		/// <summary>
		/// Converts this property to Global scoped C# code.
		/// </summary>
		/// <returns>The property as C# code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public override string ToCSharpGlobal(CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Make base
			sourceCode += $"// Global property {Name}\n";

			// Take action based on usage
			switch (outputLibrary)
			{
				case CodeOutputLibrary.SkiaSharp:
					sourceCode += $"public static string {ElementName} " +
						"{get; set;}" +
						$" = \"{TextToString()}\";\n";
					break;
				case CodeOutputLibrary.KimonoCore:
					sourceCode += $"public static KimonoPropertyText {ElementName} " +
						"{get; set;}" +
						$" = {ToKimonoCore()}\n";
					break;

			}

			// Return results
			return sourceCode;
		}

		/// <summary>
		/// Converts this property to Local scoped C# code.
		/// </summary>
		/// <returns>The property as C# code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public override string ToCSharpLocal(CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Make base
			sourceCode += $"// Local property {Name}\n" +
				$"var {ElementName}";

			// Take action based on usage
			switch (outputLibrary)
			{
				case CodeOutputLibrary.SkiaSharp:
					sourceCode += $" = \"{TextToString()}\";\n";
					break;
				case CodeOutputLibrary.KimonoCore:
					sourceCode += $" = {ToKimonoCore()}\n";
					break;

			}

			// Return results
			return sourceCode;
		}

		/// <summary>
		/// Converts this property to Parameter scoped C# code.
		/// </summary>
		/// <returns>The property as C# code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public override string ToCSharpParameter(CodeOutputLibrary outputLibrary)
		{
			var sourceCode = $"KimonoPropertyText {ElementName}";

			// Return results
			return sourceCode;
		}
		#endregion

		#region Cloning
		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>The clone.</returns>
		public override KimonoProperty Clone()
		{
			// Make copy
			var newProperty = new KimonoPropertyText()
			{
				UniqueID = this.UniqueID,
				Name = this.Name,
				Usage = this.Usage,
				IsObiScriptValue = this.IsObiScriptValue,
				GetsValueFromScript = this.GetsValueFromScript,
				ObiScript = this.ObiScript,
				Value = this.Value
			};

			// Return clone
			return newProperty;
		}
		#endregion
	}
}
