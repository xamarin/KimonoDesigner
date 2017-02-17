using System;
using SkiaSharp;
using DScript;

namespace KimonoCore
{
	/// <summary>
	/// The ObiScript Engine powers the scripting features of the `KimonoProperty` objects. It uses a modified
	/// version of the DScript engine (by Darren Horrocks) to power the actual excution of a script attached
	/// to a property and returns the results in an `ObiScript` results object. This class provides several
	/// helper script functions that a script can use to communicate values back to the property a script is attached
	/// to.
	/// </summary>
	/// <remarks>For more information, please see: https://github.com/bizzehdee/DScript</remarks>
	[ScriptClass("Return")]
	public static class ObiScriptEngine
	{
		#region Global Variables
		/// <summary>
		/// The modified DScript engine used to execute ObiScript code.
		/// </summary>
		public static ScriptEngine Runtime = new ScriptEngine(true);

		/// <summary>
		/// The results of the last script executed.
		/// </summary>
		public static ObiScriptResult EvaluationResult = new ObiScriptResult();
		#endregion

		#region Methods
		/// <summary>
		/// Raises an error from a ObiScript.
		/// </summary>
		/// <param name="message">The text of the error.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static void RaiseError(string message, object userData)
		{
			// Set error state
			EvaluationResult.Successful = false;
			EvaluationResult.ErrorMessage = message;
			EvaluationResult.Value = null;
		}

		/// <summary>
		/// Clears the last script execution results.
		/// </summary>
		public static void ClearResults()
		{
			// Set error state
			EvaluationResult.Successful = true;
			EvaluationResult.ErrorMessage = "";
			EvaluationResult.Value = null;
		}

		/// <summary>
		/// Returns a text (string) value to the parent property.
		/// </summary>
		/// <returns>The string results of the script.</returns>
		/// <param name="text">The value to send to the script.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static void Text(string text, object userData)
		{
			// Save result
			EvaluationResult.Successful = true;
			EvaluationResult.ErrorMessage = "";
			EvaluationResult.Value = text;
		}

		/// <summary>
		/// Returns a boolean (bool) value to the parent property.
		/// </summary>
		/// <returns>The boolean result from the script.</returns>
		/// <param name="state">The boolean value to send to the property.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static void Boolean(bool state, object userData)
		{
			// Save result
			EvaluationResult.Successful = true;
			EvaluationResult.ErrorMessage = "";
			EvaluationResult.Value = state;
		}

		/// <summary>
		/// Returns a number (float or int) value to the parent property.
		/// </summary>
		/// <returns>The numberic value from the script.</returns>
		/// <param name="number">The number to send to the property.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static void Number(double number, object userData)
		{
			// Save result
			EvaluationResult.Successful = true;
			EvaluationResult.ErrorMessage = "";
			EvaluationResult.Value = number;
		}

		/// <summary>
		/// Returns a named color saved in the portfolio to the parent property.
		/// </summary>
		/// <returns>The named `KimonoColor` if found, or raises an error.</returns>
		/// <param name="name">The name of the color to return.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static void Color(string name, object userData)
		{
			// Find the requested color object
			var color = ObiScriptPortfolio.FindColor(name);

			// Found?
			if (color == null)
			{
				// No, set error state
				EvaluationResult.Successful = false;
				EvaluationResult.ErrorMessage = $"Error: Color '{name}' not defined in portfolio.";
				EvaluationResult.Value = null;
			}
			else
			{
				// Save result
				EvaluationResult.Successful = true;
				EvaluationResult.ErrorMessage = "";
				EvaluationResult.Value = color;
			}
		}

		/// <summary>
		/// Returns a named gradient saved in the portfolio to the parent property.
		/// </summary>
		/// <returns>The named `KimonoGradient` if found, or raises an error.</returns>
		/// <param name="name">The name of the gradient to return.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static void Gradient(string name, object userData)
		{
			// Find the requested gradient object
			var gradient = ObiScriptPortfolio.FindGradient(name);

			// Found?
			if (gradient == null)
			{
				// No, set error state
				EvaluationResult.Successful = false;
				EvaluationResult.ErrorMessage = $"Error: Gradient '{name}' not defined in portfolio.";
				EvaluationResult.Value = null;
			}
			else
			{
				// Save result
				EvaluationResult.Successful = true;
				EvaluationResult.ErrorMessage = "";
				EvaluationResult.Value = gradient;
			}
		}

		/// <summary>
		/// Removes the gradient from the parent property.
		/// </summary>
		/// <returns>`null` to remove the current gradient.</returns>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static void NoGradient(object userData)
		{
			// Save result
			EvaluationResult.Successful = true;
			EvaluationResult.ErrorMessage = "";
			EvaluationResult.Value = null;
		}

		/// <summary>
		/// Returns a named style saved in the portfolio to the parent property.
		/// </summary>
		/// <returns>The name `KimonoStyle` if found, else raises an error.</returns>
		/// <param name="name">The name of the style to return.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static void Style(string name, object userData)
		{
			// Find the requested style object
			var style = ObiScriptPortfolio.FindGradient(name);

			// Found?
			if (style == null)
			{
				// No, set error state
				EvaluationResult.Successful = false;
				EvaluationResult.ErrorMessage = $"Error: Style '{name}' not defined in portfolio.";
				EvaluationResult.Value = null;
			}
			else
			{
				// Save result
				EvaluationResult.Successful = true;
				EvaluationResult.ErrorMessage = "";
				EvaluationResult.Value = style;
			}
		}

		/// <summary>
		/// Removes the style from the parent property.
		/// </summary>
		/// <returns>A new custom `KimonoStyle` to remove the current style.</returns>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static void NoStyle(object userData)
		{
			// Save result
			EvaluationResult.Successful = true;
			EvaluationResult.ErrorMessage = "";
			EvaluationResult.Value = new KimonoStyle()
			{
				StyleType = KimonoStyleType.Custom
			};
		}

		/// <summary>
		/// Returns the value of a named property in the portfolio to the parent property.
		/// </summary>
		/// <returns>The `KimonoProperty`'s value if found, else raises an error.</returns>
		/// <param name="name">Name.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static void Property(string name, object userData)
		{
			var property = ObiScriptPortfolio.FindProperty(name);

			// Found?
			if (property == null)
			{
				// No, set error state
				EvaluationResult.Successful = false;
				EvaluationResult.ErrorMessage = $"Error: Property '{name}' not defined in portfolio.";
				EvaluationResult.Value = null;
			}
			else
			{
				// Save result
				EvaluationResult.Successful = true;
				EvaluationResult.ErrorMessage = "";

				// Execute any scripts on the property
				property.Evaluate();

				// Successful?
				if (EvaluationResult.Successful)
				{
					// Yes, take action based on the property type
					if (property is KimonoPropertyBoolean)
					{
						EvaluationResult.Value = ((KimonoPropertyBoolean)property).Value;
					}
					else if (property is KimonoPropertyColor)
					{
						EvaluationResult.Value = ((KimonoPropertyColor)property).Value;
					}
					else if (property is KimonoPropertyGradient)
					{
						EvaluationResult.Value = ((KimonoPropertyGradient)property).Value;
					}
					else if (property is KimonoPropertyNumber)
					{
						EvaluationResult.Value = ((KimonoPropertyNumber)property).Value;
					}
					else if (property is KimonoPropertyNumber)
					{
						EvaluationResult.Value = ((KimonoPropertyNumber)property).Value;
					}
					else if (property is KimonoPropertyRect)
					{
						EvaluationResult.Value = ((KimonoPropertyRect)property).Value;
					}
					else if (property is KimonoPropertyStyle)
					{
						EvaluationResult.Value = ((KimonoPropertyStyle)property).Value;
					}
					else if (property is KimonoPropertyText)
					{
						EvaluationResult.Value = ((KimonoPropertyText)property).Value;
					}
				}
			}
		}

		/// <summary>
		/// Returns a rectangular value to the parent property.
		/// </summary>
		/// <returns>A `SKRect` with the given values.</returns>
		/// <param name="left">The X coordinate of the rect.</param>
		/// <param name="top">The Y coordinate of the rect.</param>
		/// <param name="width">The width of the rect.</param>
		/// <param name="height">The height of the rect.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static void Rect(double left, double top, double width, double height, object userData)
		{
			// Save result
			EvaluationResult.Successful = true;
			EvaluationResult.ErrorMessage = "";
			EvaluationResult.Value = new SKRect((float)left, (float)top, (float)left + (float)width,(float)top + (float)height);
		}
		#endregion
	}
}
