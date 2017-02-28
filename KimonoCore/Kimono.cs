using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Holds a set of shared utilities that are used across the Kimono classes.
	/// </summary>
	public static class Kimono
	{
		#region Static Methods
		/// <summary>
		/// Test to see if the given character is a number character.
		/// </summary>
		/// <returns><c>true</c>, if is character is a number, <c>false</c> otherwise.</returns>
		/// <param name="c">C.</param>
		public static bool CharIsNumber(char c)
		{
			var numbers = "0123456789";
			return numbers.Contains(c.ToString());
		}

		/// <summary>
		/// Test to see if the given character is a letter character.
		/// </summary>
		/// <returns><c>true</c>, if is character is a letter, <c>false</c> otherwise.</returns>
		/// <param name="c">C.</param>
		public static bool CharIsLetter(char c)
		{
			var numbers = "abcdefghijklmnopqrstuvwxyz";
			return numbers.Contains(c.ToString().ToLower());
		}

		/// <summary>
		/// Test to see if the given character is valid in an element name.
		/// </summary>
		/// <returns><c>true</c>, if is character is a valid symbol, <c>false</c> otherwise.</returns>
		/// <param name="c">C.</param>
		public static bool CharIsLegalNameSymbol(char c)
		{
			var symbol = " ._-";
			return symbol.Contains(c.ToString().ToLower());
		}

		/// <summary>
		/// Makes a valid element name from the given name.
		/// </summary>
		/// <returns>The valid item name.</returns>
		/// <param name="itemType">The type of item that a name is being built for.</param>
		/// <param name="name">The current item name.</param>
		public static string MakeValidItemName(string itemType, string name)
		{
			var validatedName = "";

			// Process incoming name
			for (int n = 0; n < name.Length; ++n)
			{
				// Get character
				var c = name[n];

				// Is valid character?
				if (CharIsNumber(c) || CharIsLetter(c) || CharIsLegalNameSymbol(c))
				{
					// Yes, accumulate
					validatedName += c;
				}
			}

			// Non-empty
			validatedName = validatedName.Trim();
			if (validatedName == "") validatedName = itemType;

			// Return valid name
			return validatedName;
		}

		/// <summary>
		/// Increments the name by appending a number to the end or incrementing an existing
		/// number count.
		/// </summary>
		/// <returns>The name.</returns>
		/// <param name="name">Name.</param>
		public static string IncrementName(string name)
		{
			var numeric = "";
			var posn = 0;

			// Anything to process?
			if (name == "") return "1";

			// Start scanning for numeric bit
			for(int n = name.Length - 1; n >= 0; --n)
			{
				var c = name[n];

				// Is this a number?
				if (CharIsNumber(c))
				{
					// Yes, assemble number
					numeric = c + numeric;
				}
				else
				{
					// Not a number, save position hope out of loop
					posn = n + 1;
					break;
				}
			}

			// Any numeric bit found?
			if (numeric == "")
			{
				// No, add one
				return $"{name} 1";
			}
			else
			{
				// Yes, attempt to increment number
				var start = name.Substring(0, posn);
				var value = 0;
				if (int.TryParse(numeric, out value))
				{
					return $"{start}{++value}";
				}
				else
				{
					return $"{name}1";
				}
			}
		}

		/// <summary>
		/// Clones the given <c>SKPoint</c>.
		/// </summary>
		/// <returns>A clone of the given point.</returns>
		/// <param name="point">The <c>SKPoint</c> to clone.</param>
		public static SKPoint CloneSKPoint(SKPoint point)
		{
			return new SKPoint(point.X, point.Y);
		}

		/// <summary>
		/// Converts the given hex color string into a <c>SKColor</c>.
		/// </summary>
		/// <returns>The color, or white on error.</returns>
		/// <param name="hex">The hex representation of the color.</param>
		public static SKColor HexToColor(string hex)
		{
			int offset;

			// Valid length?
			if (hex.Length < 8 || hex.Length > 9)
			{
				// No, just return white
				return KimonoColor.White;
			}

			try
			{
				// Has leading #?, skip
				if (hex[0] == '#')
				{
					offset = 1;
				}
				else
				{
					offset = 0;
				}

				// Break hex into sections
				int Red = int.Parse(hex.Substring(offset, 2), System.Globalization.NumberStyles.HexNumber);
				int Green = int.Parse(hex.Substring(offset + 2, 2), System.Globalization.NumberStyles.HexNumber);
				int Blue = int.Parse(hex.Substring(offset + 4, 2), System.Globalization.NumberStyles.HexNumber);
				int Alpha = int.Parse(hex.Substring(offset + 6, 2), System.Globalization.NumberStyles.HexNumber);

				// Return assembled color
				return new SKColor((byte)Red, (byte)Green, (byte)Blue, (byte)Alpha);
			}
			catch
			{
				// Return white on error
				return KimonoColor.White;
			}
		}

		/// <summary>
		/// Converts a <c>SKColor</c> into a hex value.
		/// </summary>
		/// <returns>The hex representation of the color.</returns>
		/// <param name="color">The SKColor to convert.</param>
		/// <param name="LeadingHash">If set to <c>true</c>, adds a leading hash.</param>
		public static string ColorToHex(SKColor color, bool LeadingHash)
		{
			// Return results
			return string.Format("{0}{1:X2}{2:X2}{3:X2}{4:X2}", (LeadingHash) ? "#" : "", color.Red, color.Green, color.Blue, color.Alpha);
		}
		#endregion

		#region Delegates
		/// <summary>
		/// Portfolio event delegate.
		/// </summary>
		public delegate void PortfolioEventDelegate();

		/// <summary>
		/// Sketch event delegate.
		/// </summary>
		public delegate void SketchEventDelegate(KimonoSketch sketch);

		/// <summary>
		/// Style event delegate.
		/// </summary>
		public delegate void StyleEventDelegate(KimonoStyle style);

		/// <summary>
		/// Shape event delegate.
		/// </summary>
		public delegate void ShapeEventDelegate(KimonoShape selected);

		/// <summary>
		/// Tool event delegate.
		/// </summary>
		public delegate void ToolEventDelegate(KimonoTool tool);

		/// <summary>
		/// Skia point event delegate.
		/// </summary>
		public delegate void SkiaPointEventDelegate(SKPoint point);

		/// <summary>
		/// Group event delegate.
		/// </summary>
		public delegate void GroupEventDelegate(KimonoShapeGroup group);

		/// <summary>
		/// Color event delegate.
		/// </summary>
		public delegate void ColorEventDelegate(KimonoColor color);

		/// <summary>
		/// Skia color event delegate.
		/// </summary>
		public delegate void SkiaColorEventDelegate(SKColor color);

		/// <summary>
		/// Gradient event delegate.
		/// </summary>
		public delegate void GradientEventDelegate(KimonoGradient gradient);

		/// <summary>
		/// Handle event delegate.
		/// </summary>
		public delegate void HandleEventDelegate(KimonoHandle handle);

		/// <summary>
		/// Property event delegate.
		/// </summary>
		public delegate void PropertyEventDelegate(KimonoProperty property);
		#endregion
	}
}
