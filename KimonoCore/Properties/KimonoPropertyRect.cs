using System;
using SkiaSharp;
using TextBase;

namespace KimonoCore
{
	/// <summary>
	/// Defines a `KimonoProperty` that represents a `SKRect`.
	/// </summary>
	[Table("RectProperty")]
	public class KimonoPropertyRect : KimonoProperty
	{
		#region Public Variables
		/// <summary>
		/// The base value of this rectangle.
		/// </summary>
		public SKRect Value = new SKRect();
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the left.
		/// </summary>
		/// <value>The left.</value>
		public float Left
		{
			get { return Value.Left; }
			set { Value.Left = value; }
		}

		/// <summary>
		/// Gets or sets the top.
		/// </summary>
		/// <value>The top.</value>
		public float Top
		{
			get { return Value.Top; }
			set { Value.Top = value; }
		}

		/// <summary>
		/// Gets or sets the right.
		/// </summary>
		/// <value>The right.</value>
		public float Right
		{
			get { return Value.Right; }
			set { Value.Right = value; }
		}

		/// <summary>
		/// Gets or sets the bottom.
		/// </summary>
		/// <value>The bottom.</value>
		public float Bottom
		{
			get { return Value.Bottom; }
			set { Value.Bottom = value; }
		}

		/// <summary>
		/// Gets or sets the width.
		/// </summary>
		/// <value>The width.</value>
		[Ignore]
		public float Width
		{
			get { return Value.Width; }
			set { Value.Right = Value.Left + value; }
		}

		/// <summary>
		/// Gets or sets the height.
		/// </summary>
		/// <value>The height.</value>
		[Ignore]
		public float Height
		{
			get { return Value.Height; }
			set { Value.Bottom = Value.Top + value; }
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoPropertyRect"/> class.
		/// </summary>
		public KimonoPropertyRect()
		{
			// Initialize
			Name = "Rect Property";
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
					if (ObiScriptEngine.EvaluationResult.Value is SKRect)
					{
						// Yes, save it
						Value = (SKRect)ObiScriptEngine.EvaluationResult.Value;
					}
					else
					{
						// Report this as an error
						ObiScriptEngine.EvaluationResult.Successful = false;
						ObiScriptEngine.EvaluationResult.ErrorMessage = "Error: Script did not return a rectangular value. " +
							"Call `Return.Rect(left,top,width,height);` to return the required value.";
					}
				}
			}

			// Return the result of executing the script
			return ObiScriptEngine.EvaluationResult;
		}
		#endregion

		#region Conversion Routines
		/// <summary>
		/// Converts this `KimonoProperty` to a `SKRect`.
		/// </summary>
		/// <returns>The `SKRect` value.</returns>
		public override SKRect ToRect()
		{
			return Value;
		}

		/// <summary>
		/// Converts to KimonoCore based source code
		/// </summary>
		/// <returns>The property as a KimonoCore object.</returns>
		public override string ToKimonoCore()
		{
			var sourceCode = "new KimonoPropertyRect() {\n" +
				$"\tName = \"{Name}\",\n" +
				$"\tGetsValueFromScript = {GetsValueFromScript.ToString().ToLower()},\n" +
				$"\tObiScript = \"{ScriptToString()}\",\n" +
				$"\tValue = new SKRect({Value.Left}f, {Value.Top}f, {Value.Right}f, {Value.Bottom}f)\n" +
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
					sourceCode += $"public static SKRect {ElementName} " +
						"{get; set;}" +
						$" = new SKRect({Value.Left}f, {Value.Top}f, {Value.Right}f, {Value.Bottom}f);\n";
					break;
				case CodeOutputLibrary.KimonoCore:
					sourceCode += $"public static KimonoPropertyRect {ElementName} " +
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
					sourceCode += $" = new SKRect({Value.Left}f, {Value.Top}f, {Value.Right}f, {Value.Bottom}f);\n";
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
			var sourceCode = $"KimonoPropertyRect {ElementName}";

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
			var newProperty = new KimonoPropertyRect()
			{
				UniqueID = this.UniqueID,
				Name = this.Name,
				Usage = this.Usage,
				IsObiScriptValue = this.IsObiScriptValue,
				ObiScript = this.ObiScript,
				Value = new SKRect(this.Value.Left, this.Value.Top, this.Value.Right, this.Value.Bottom)
			};

			// Return clone
			return newProperty;
		}
		#endregion
	}
}
