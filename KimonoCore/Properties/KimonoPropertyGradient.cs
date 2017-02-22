using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Defines a `KimonoProperty` that represents a `KimonoGradient` value.
	/// </summary>
	public class KimonoPropertyGradient : KimonoProperty
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The `KimonoGradient` value.</value>
		public KimonoGradient Value { get; set; } = null;

		/// <summary>
		/// Gets a value indicating whether this <see cref="T:KimonoCore.KimonoProperty"/> gets value from script.
		/// </summary>
		/// <value><c>true</c> if gets value from script; otherwise, <c>false</c>.</value>
		public override bool GetsValueFromScript
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		/// Gets a value indicating whether this <see cref="T:KimonoCore.KimonoPropertyColor"/> is obi script value.
		/// </summary>
		/// <value><c>true</c> if is obi script value; otherwise, <c>false</c>.</value>
		public override bool IsObiScriptValue
		{
			get
			{
				return true;
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoPropertyText"/> class.
		/// </summary>
		public KimonoPropertyGradient()
		{
			// Initialize
			Name = "Gradient Property";
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
					if (ObiScriptEngine.EvaluationResult.Value == null) {
						// Remove gradient
						Value = null;
					} 
					else if (ObiScriptEngine.EvaluationResult.Value is KimonoGradient)
					{
						// Yes, save it
						Value = ObiScriptEngine.EvaluationResult.Value as KimonoGradient;
					}
					else
					{
						// Report this as an error
						ObiScriptEngine.EvaluationResult.Successful = false;
						ObiScriptEngine.EvaluationResult.ErrorMessage = "Error: Script did not return a named gradient. " +
							"Call `Return.Gradient(\"name\");` to return the required value or `Return.NoGradient();` to " +
							"remove the current gradient.";
					}
				}
			}

			// Return the result of executing the script
			return ObiScriptEngine.EvaluationResult;
		}
		#endregion

		#region Conversion Routines
		/// <summary>
		/// Converts this `KimonoProperty` to a `KimonoGradient`.
		/// </summary>
		/// <returns>The gradient.</returns>
		public override KimonoGradient ToGradient()
		{
			return Value;
		}

		/// <summary>
		/// Converts to KimonoCore based source code
		/// </summary>
		/// <returns>The property as a KimonoCore object.</returns>
		public override string ToKimonoCore()
		{
			var sourceCode = "new KimonoPropertyGradient() {\n" +
				$"\tName = \"{Name}\",\n" +
				$"\tGetsValueFromScript = {GetsValueFromScript.ToString().ToLower()},\n" +
				$"\tObiScript = \"{ScriptToString()}\",\n" +
				$"\tValue = {Value.ElementName}\n" +
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
					sourceCode += $"public static SKShader {ElementName} " +
						"{get; set;}" +
						$" = {Value.ElementName};\n";
					break;
				case CodeOutputLibrary.KimonoCore:
					sourceCode += $"public static KimonoPropertyGradient {ElementName} " +
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
					sourceCode += $" = {Value.ElementName};\n";
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
			var sourceCode = $"KimonoPropertyGradient {ElementName}";

			// Return results
			return sourceCode;
		}

		/// <summary>
		/// Converts this object to source code for the given OS, Language and Library.
		/// </summary>
		/// <returns>The object represented as source code in a `string`.</returns>
		/// <param name="outputOS">The `CodeOutputOS`.</param>
		/// <param name="outputLanguage">The `CodeOutputLanguage`.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary`.</param>
		public override string ToCode(CodeOutputOS outputOS, CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Accumulate color
			if (Value != null)
			{
				// Yes, add as a supporting gradient
				KimonoCodeGenerator.AddSupportingGradient(Value);
			}

			// Take action based on the output language
			switch (outputLanguage)
			{
				case CodeOutputLanguage.CSharp:
					sourceCode = ToCSharp(outputLibrary);
					break;
			}

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
			var newProperty = new KimonoPropertyGradient()
			{
				UniqueID = this.UniqueID,
				Name = this.Name,
				Usage = this.Usage,
				IsObiScriptValue = this.IsObiScriptValue,
				GetsValueFromScript = this.GetsValueFromScript,
				ObiScript = this.ObiScript,
				Value = (this.Value == null) ? null : this.Value.Clone()
			};

			// Return clone
			return newProperty;
		}
		#endregion
	}
}
