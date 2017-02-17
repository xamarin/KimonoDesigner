using System;
using SkiaSharp;
using DScript;

namespace KimonoCore
{
	/// <summary>
	/// The ObiScript Portfolio provides a communication link between the current `KimonoPortfolio`
	/// and any ObiScripts attached to a `KimonoProperty` allow a script to access and modify element
	/// of the portfolio and any of the objects it contains. ObiScript is powered by a modified
	/// version of the Dscript Script Langauge (by Darren Horrocks).
	/// </summary>
	/// <remarks>For more information, please see: https://github.com/bizzehdee/DScript</remarks>
	[ScriptClass("Portfolio")]
	public static class ObiScriptPortfolio
	{
		#region Gloval Variables
		/// <summary>
		/// The `KimonoPortfolio` that ObiScripts are currently being executed against.
		/// </summary>
		public static KimonoPortfolio Portfolio = null;
		#endregion

		#region Private Methods
		/// <summary>
		/// Finds the property with the given name.
		/// </summary>
		/// <returns>The `KimonoProperty` if found, else `null`.</returns>
		/// <param name="name">The name of the property to find.</param>
		internal static KimonoProperty FindProperty(string name)
		{
			// Scan all properties
			foreach (KimonoProperty property in Portfolio.Properties)
			{
				// Found?
				if (property.Name == name) return property;
			}

			// Not found 
			return null;
		}

		/// <summary>
		/// Finds the color with the given name.
		/// </summary>
		/// <returns>The `KimonoColor` if found, else `null`.</returns>
		/// <param name="name">The name of the color to find.</param>
		internal static KimonoColor FindColor(string name)
		{
			// Scan all colors
			foreach (KimonoColor color in Portfolio.Colors)
			{
				// Found?
				if (color.Name == name) return color;
			}

			// Not found
			return null;
		}

		/// <summary>
		/// Finds the gradient with the given name.
		/// </summary>
		/// <returns>The `KimonoGradient` if found, else `null`.</returns>
		/// <param name="name">The name of the gradient to find.</param>
		internal static KimonoGradient FindGradient(string name)
		{
			// Scan all gradients
			foreach (KimonoGradient gradient in Portfolio.Gradients)
			{
				// Found?
				if (gradient.Name == name) return gradient;
			}

			// Not found
			return null;
		}

		/// <summary>
		/// Finds the style with the given name.
		/// </summary>
		/// <returns>The `KimonoStyle` if found, else `null`.</returns>
		/// <param name="name">The name of the style to find.</param>
		internal static KimonoStyle FindStyle(string name)
		{
			// Scan all styles
			foreach (KimonoStyle style in Portfolio.Styles)
			{
				// Found?
				if (style.Name == name) return style;
			}

			// Not found
			return null;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Gets the value of a boolean property defined in the portfolio.
		/// </summary>
		/// <returns>The value of the `KimonoPropertyBoolean` if found, else `false`.</returns>
		/// <param name="name">The name of the property to get the value for.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static bool GetBoolean(string name, object userData)
		{
			// Get requested property
			var property = FindProperty(name);

			// Is it the correct type?
			if (property is KimonoPropertyBoolean)
			{
				// Execute any scripts on the property
				property.Evaluate();

				// Yes, return value
				var prop = property as KimonoPropertyBoolean;
				return prop.Value;
			}
			else
			{
				// No
				return false;
			}
		}

		/// <summary>
		/// Sets the value of the given boolean property.
		/// </summary>
		/// <param name="name">The name of the property to set.</param>
		/// <param name="value">The new value.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static void SetBoolean(string name, bool value, object userData)
		{
			// Get requested property
			var property = FindProperty(name);

			// Is it the correct type?
			if (property is KimonoPropertyBoolean)
			{
				// Yes, return value
				var prop = property as KimonoPropertyBoolean;
				prop.Value = value;
			}
		}

		/// <summary>
		/// Gets the value of a number property defined in the portfolio.
		/// </summary>
		/// <returns>The value of the `KimonoPropertyNumber` if found, else `0`.</returns>
		/// <param name="name">The name of the value to get the property for.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static double GetNumber(string name, object userData)
		{
			// Get requested property
			var property = FindProperty(name);

			// Is it the correct type?
			if (property is KimonoPropertyNumber)
			{
				// Execute any scripts on the property
				property.Evaluate();

				// Yes, return value
				var prop = property as KimonoPropertyNumber;
				return prop.Value;
			}
			else
			{
				// No
				return 0;
			}
		}

		/// <summary>
		/// Sets the value of the given number property.
		/// </summary>
		/// <param name="name">The name of the property to set.</param>
		/// <param name="value">The new value.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static void SetNumber(string name, double value, object userData)
		{
			// Get requested property
			var property = FindProperty(name);

			// Is it the correct type?
			if (property is KimonoPropertyNumber)
			{
				// Yes, return value
				var prop = property as KimonoPropertyNumber;
				prop.Value = (float)value;
			}
		}

		/// <summary>
		/// Gets the value of a text property defined in the portfolio.
		/// </summary>
		/// <returns>The value of the `KimonoPropertyText` if found, else "".</returns>
		/// <param name="name">The name of the value to get the property for.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static string GetText(string name, object userData)
		{
			// Get requested property
			var property = FindProperty(name);

			// Is it the correct type?
			if (property is KimonoPropertyText)
			{
				// Execute any scripts on the property
				property.Evaluate();

				// Yes, return value
				var prop = property as KimonoPropertyText;
				return prop.Value;
			}
			else
			{
				// No
				return "";
			}
		}

		/// <summary>
		/// Sets the value of the given text property.
		/// </summary>
		/// <param name="name">The name of the property to set.</param>
		/// <param name="value">The new value.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static void SetText(string name, string value, object userData)
		{
			// Get requested property
			var property = FindProperty(name);

			// Is it the correct type?
			if (property is KimonoPropertyText)
			{
				// Yes, return value
				var prop = property as KimonoPropertyText;
				prop.Value = value;
			}
		}

		/// <summary>
		/// Sets the value of the given rect property.
		/// </summary>
		/// <param name="name">The name of the property to set.</param>
		/// <param name="left">The X coordinate of the rect.</param>
		/// <param name="top">The Y coordinate of the rect.</param>
		/// <param name="width">The width of the rect.</param>
		/// <param name="height">The height of the rect.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static void SetRect(string name, double left, double top, double width, double height, object userData)
		{
			// Get requested property
			var property = FindProperty(name);

			// Is it the correct type?
			if (property is KimonoPropertyRect)
			{
				// Yes, return value
				var prop = property as KimonoPropertyRect;
				prop.Value = new SKRect((float)left, (float)top, (float)left + (float)width, (float)top + (float)height);
			}
		}

		/// <summary>
		/// Sets the value of the given color property.
		/// </summary>
		/// <param name="name">The name of the color property to set.</param>
		/// <param name="red">The red value for the color.</param>
		/// <param name="green">The green value for the color.</param>
		/// <param name="blue">The blue value for the color.</param>
		/// <param name="alpha">The transparancy value for the color.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static void SetColor(string name, int red, int green, int blue, int alpha, object userData)
		{
			// Get requested property
			var property = FindProperty(name);

			// Is it the correct type?
			if (property is KimonoPropertyColor)
			{
				// Yes, return value
				var prop = property as KimonoPropertyColor;
				prop.Value.Color = new SKColor((byte)red, (byte)green, (byte)blue, (byte)alpha);
			}
		}

		/// <summary>
		/// Sets the value of the given named color saved in the portfolio.
		/// </summary>
		/// <param name="name">The name of the color to set.</param>
		/// <param name="red">The red value for the color.</param>
		/// <param name="green">The green value for the color.</param>
		/// <param name="blue">The blue value for the color.</param>
		/// <param name="alpha">The transparancy value for the color.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static void SetNamedColor(string name, int red, int green, int blue, int alpha, object userData)
		{
			// Get requested color
			var color = FindColor(name);

			// Found?
			if (color != null)
			{
				// Yes, set new color value
				color.Color = new SKColor((byte)red, (byte)green, (byte)blue, (byte)alpha);
			}
		}

		/// <summary>
		/// Check to see if the portfolio contains the given named color.
		/// </summary>
		/// <returns><c>true</c>, if color was found, <c>false</c> otherwise.</returns>
		/// <param name="name">The name of the color to find.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static bool HasColor(string name, object userData)
		{
			return (FindColor(name) != null);
		}

		/// <summary>
		/// Check to see if the portfolio contains the given named gradient.
		/// </summary>
		/// <returns><c>true</c>, if gradient was found, <c>false</c> otherwise.</returns>
		/// <param name="name">The name of the gradient to find.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static bool HasGradient(string name, object userData)
		{
			return (FindGradient(name) != null);
		}

		/// <summary>
		/// Check to see if the portfolio contains the given named style.
		/// </summary>
		/// <returns><c>true</c>, if style was found, <c>false</c> otherwise.</returns>
		/// <param name="name">The name of the style to find.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static bool HasStyle(string name, object userData)
		{
			return (FindStyle(name) != null);
		}

		/// <summary>
		/// Check to see if the portfolio contains the given property.
		/// </summary>
		/// <returns><c>true</c>, if property was found, <c>false</c> otherwise.</returns>
		/// <param name="name">The name of the property to find.</param>
		/// <param name="userData">The `ScriptEngine` executing the script.</param>
		public static bool HasProperty(string name, object userData)
		{
			return (FindProperty(name) != null);
		}
		#endregion
	}
}
