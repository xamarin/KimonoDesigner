using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Defines a shadow effect that can be attached to the fill or the frame of a
	/// <c>KimonoShape</c>.
	/// </summary>
	public class KimonoShadow : IKimonoCodeGeneration
	{
		#region Private Variables
		/// <summary>
		/// The horizontal offset.
		/// </summary>
		public Single _horizontalOffset = 0;

		/// <summary>
		/// The vertical offset.
		/// </summary>
		public Single _verticalOffset = 0;

		/// <summary>
		/// The horizontal blur amount.
		/// </summary>
		private Single _horizontalBlurAmount = 0;

		/// <summary>
		/// The vertical blur amount.
		/// </summary>
		private Single _verticalBlurAmount = 0;

		/// <summary>
		/// The color of the shadow.
		/// </summary>
		private SKColor _color = KimonoColor.Gray;

		/// <summary>
		/// A linked <c>KimonoColor</c> to use as the shadow color.
		/// </summary>
		private KimonoColor _linkedColor = null;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; } = "Shadow";

		/// <summary>
		/// Gets or sets the horizontal offset.
		/// </summary>
		/// <value>The horizontal offset.</value>
		public Single HorizontalOffset
		{
			get { return _horizontalOffset; }
			set
			{
				_horizontalOffset = value;
				RaiseShadowModified();
			}
		}

		/// <summary>
		/// Gets or sets the vertical offset.
		/// </summary>
		/// <value>The vertical offset.</value>
		public Single VerticalOffset
		{
			get { return _verticalOffset; }
			set
			{
				_verticalOffset = value;
				RaiseShadowModified();
			}
		}

		/// <summary>
		/// Gets or sets the horizontal blur amount.
		/// </summary>
		/// <value>The horizontal blur amount.</value>
		public Single HorizontalBlurAmount
		{
			get { return _horizontalBlurAmount; }
			set
			{
				_horizontalBlurAmount = value;
				RaiseShadowModified();
			}
		}

		/// <summary>
		/// Gets or sets the vertical blur amount.
		/// </summary>
		/// <value>The vertical blur amount.</value>
		public Single VerticalBlurAmount
		{
			get { return _verticalBlurAmount; }
			set
			{
				_verticalBlurAmount = value;
				RaiseShadowModified();
			}
		}

		/// <summary>
		/// Gets or sets the color of the shadow.
		/// </summary>
		/// <value>The color.</value>
		public SKColor Color
		{
			get { return _color; }
			set
			{
				_color = value;
				RaiseShadowModified();
			}
		}

		/// <summary>
		/// Gets or sets the color of the linked.
		/// </summary>
		/// <value>The color of the linked.</value>
		public KimonoColor LinkedColor
		{
			get { return _linkedColor; }
			set
			{
				// Unwire previous value
				if (_linkedColor != null)
				{
					_linkedColor.ColorChanged -= HandleLinkedColorChanged;
				}

				// Save new value
				_linkedColor = value;
				RaiseShadowModified();

				// Wireup new value
				if (_linkedColor != null)
				{
					_linkedColor.ColorChanged += HandleLinkedColorChanged;
				}
 
			}
		}

		/// <summary>
		/// Gets the color of the shadow.
		/// </summary>
		/// <remarks>Returns either the custom color attached to this shadow or a linked color
		/// if it is being used.</remarks>
		/// <value>The color of the shadow as a <c>SKColor</c>.</value>
		public SKColor ShadowColor
		{
			get
			{
				// Is this provided by a linked color?
				if (LinkedColor == null)
				{
					// No, use custom color
					return Color;
				}
				else
				{
					// Yes, use that color instead.
					return LinkedColor.Color;
				}
			}
		}

		/// <summary>
		/// Gets the shadoe filter represented by this shadow effect.
		/// </summary>
		/// <value>The <c>SKImageFilter</c> for the blur filter.</value>
		public SKImageFilter ShadowFilter
		{
			get { return SKImageFilter.CreateDropShadow(HorizontalOffset, 
			                                            VerticalOffset,
			                                            HorizontalBlurAmount,
			                                            VerticalBlurAmount,
			                                            ShadowColor,
			                                            SKDropShadowImageFilterShadowMode.DrawShadowAndForeground,
			                                            null,
			                                            null); }
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShadow"/> class.
		/// </summary>
		public KimonoShadow()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShadow"/> class.
		/// </summary>
		/// <param name="horizontalOffset">Horizontal offset.</param>
		/// <param name="horizontalBlurAmount">Horizontal blur amount.</param>
		/// <param name="verticalOffset">Vertical offset.</param>
		/// <param name="verticalBlurAmount">Vertical blur amount.</param>
		public KimonoShadow(Single horizontalOffset, Single horizontalBlurAmount, Single verticalOffset, Single verticalBlurAmount)
		{
			// Initialize
			HorizontalOffset = horizontalOffset;
			HorizontalBlurAmount = horizontalBlurAmount;
			VerticalOffset = verticalOffset;
			VerticalBlurAmount = verticalBlurAmount;
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Handles the linked color changed.
		/// </summary>
		private void HandleLinkedColorChanged()
		{
			// Update shadow
			RaiseShadowModified();
		}
		#endregion

		#region Conversion Routines
		/// <summary>
		/// Converts the shapes path to C# Skia based code.
		/// </summary>
		/// <returns>The path as code.</returns>
		public virtual string ToSkiaSharpPath()
		{
			return "";
		}


		/// <summary>
		/// Converts this shape to C# code.
		/// </summary>
		/// <returns>The shape as C# code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public virtual string ToCSharp(CodeOutputLibrary outputLibrary)
		{
			return "";
		}

		/// <summary>
		/// Converts this shadow to C# code using the Skia library.
		/// </summary>
		/// <returns>The shadow as code.</returns>
		public virtual string ToSkiaSharp()
		{
			var sourceCode = "";
			var colorName = "";

			// Using linked color?
			if (LinkedColor == null)
			{
				// Save color name
				colorName = $"{Name}ShadowColor";

				// No, generate a one off color
				sourceCode += $"// Shadow color for {Name}\n" +
					$"var {colorName} = {KimonoCodeGenerator.ColorToCode(CodeOutputLibrary.SkiaSharp, Color)};\n\n";
			}
			else
			{
				// Save linked color
				colorName = KimonoCodeGenerator.AddSupportingColor(LinkedColor);
			}

			// Assemble code
			sourceCode += $"// Build shadow for {Name}\n" +
				$"var {Name}Shadow = SKImageFilter.CreateDropShadow({HorizontalOffset}f, {VerticalOffset}f, {HorizontalBlurAmount}f, {VerticalBlurAmount}f, {colorName}, SKDropShadowImageFilterShadowMode.DrawShadowAndForeground, null, null);\n";

			// Return resulting code
			return sourceCode;
		}

		/// <summary>
		/// Converts this shadow to C# code using the KimonoCore library.
		/// </summary>
		/// <returns>The shadow as code.</returns>
		public virtual string ToKimonoCore()
		{
			var sourceCode = "";

			// Assemble code
			sourceCode += $"// Build shadow for {Name}\n" +
				$"var {Name}Shadow = new KimonoShadow({HorizontalOffset}f, {VerticalOffset}f, {HorizontalBlurAmount}f, {VerticalBlurAmount}f);\n";

			// Using linked color?
			if (LinkedColor == null)
			{
				// No, generate a one off color
				sourceCode += $"{Name}Shadow.Color = {KimonoCodeGenerator.ColorToCode(CodeOutputLibrary.SkiaSharp, Color)};\n";
			}
			else
			{
				// Use linked color
				sourceCode += $"{Name}Shadow.LinkedColor = {KimonoCodeGenerator.AddSupportingColor(LinkedColor)};\n";
			}

			// Return resulting code
			return sourceCode;
		}

		/// <summary>
		/// Converts this object to source code for the given OS, Language and Library.
		/// </summary>
		/// <returns>The object represented as source code in a `string`.</returns>
		/// <param name="outputOS">The `CodeOutputOS`.</param>
		/// <param name="outputLanguage">The `CodeOutputLanguage`.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary`.</param>
		public string ToCode(CodeOutputOS outputOS, CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Take action based on the library
			switch (outputLibrary)
			{
				case CodeOutputLibrary.SkiaSharp:
					sourceCode += ToSkiaSharp();
					break;
				case CodeOutputLibrary.KimonoCore:
					sourceCode += ToKimonoCore();
					break;
			}

			// Include any supporting colors
			sourceCode = KimonoCodeGenerator.CodeForSupportingColors(outputLanguage, outputLibrary) + sourceCode;

			// Return resulting code
			return sourceCode;
		}
		#endregion

		#region Cloning
		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>The clone.</returns>
		public KimonoShadow Clone()
		{
			// Create copy
			var shadowCopy = new KimonoShadow(this.HorizontalOffset, this.HorizontalBlurAmount, this.VerticalOffset, this.VerticalBlurAmount)
			{
				Color = this.Color,
				LinkedColor = this.LinkedColor
			};

			// Return clone
			return shadowCopy;
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when the shadow is modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate ShadowModified;

		/// <summary>
		/// Raises the shadow modified event.
		/// </summary>
		internal void RaiseShadowModified()
		{
			// Inform caller
			if (ShadowModified != null) ShadowModified();
		}
		#endregion
	}
}
