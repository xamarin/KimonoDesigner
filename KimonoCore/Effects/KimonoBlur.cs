using System;
using SkiaSharp;
using TextBase;

namespace KimonoCore
{
	/// <summary>
	/// Defines a blur effect that can be attached to the fill or the frame of a
	/// <c>KimonoShape</c>.
	/// </summary>
	[Table("Blur")]
	public class KimonoBlur : IKimonoCodeGeneration
	{
		#region Private Variables
		/// <summary>
		/// The horizontal blur amount.
		/// </summary>
		private Single _horizontalBlurAmount = 0;

		/// <summary>
		/// The vertical blur amount.
		/// </summary>
		private Single _verticalBlurAmount = 0;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; } = "Blur";

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
				RaiseBlurModified();
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
				RaiseBlurModified();
			}
		}

		/// <summary>
		/// Gets the blur filter represented by this blur effect.
		/// </summary>
		/// <value>The <c>SKImageFilter</c> for the blur filter.</value>
		[Ignore]
		public SKImageFilter BlurFilter
		{
			get { return SKImageFilter.CreateBlur(HorizontalBlurAmount, VerticalBlurAmount, null, null); }
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoBlur"/> class.
		/// </summary>
		public KimonoBlur()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoBlur"/> class.
		/// </summary>
		/// <param name="horizontalBlurAmount">Horizontal blur amount.</param>
		/// <param name="verticalBlurAmount">Vertical blur amount.</param>
		public KimonoBlur(Single horizontalBlurAmount, Single verticalBlurAmount)
		{
			// Initialize
			HorizontalBlurAmount = horizontalBlurAmount;
			VerticalBlurAmount = verticalBlurAmount;
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
		/// Converts this blur effect to code using the Skia library.
		/// </summary>
		/// <returns>The blur as code.</returns>
		public virtual string ToSkiaSharp()
		{
			var sourceCode = "";

			// Assemble code
			sourceCode += $"// Build {Name} Blur\n" +
				$"var {Name}Blur = SKImageFilter.CreateBlur({HorizontalBlurAmount}f, {VerticalBlurAmount}f, null, null);\n";

			// Return code
			return sourceCode;
		}

		/// <summary>
		/// Converts this blur effect to code using the KimonoCore library.
		/// </summary>
		/// <returns>The blur as code.</returns>
		public virtual string ToKimonoCore()
		{
			var sourceCode = "";

			// Assemble code
			sourceCode += $"// Build {Name} Blur\n" +
				$"var {Name}Blur = new KimonoBlur({HorizontalBlurAmount}f, {VerticalBlurAmount}f);\n";

			// Return code
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

			// Return resulting code
			return sourceCode;
		}
		#endregion

		#region Cloning
		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>The clone.</returns>
		public KimonoBlur Clone()
		{
			// Create copy
			var blurCopy = new KimonoBlur(this.HorizontalBlurAmount, this.VerticalBlurAmount);

			// Return clone
			return blurCopy;
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when the blur is modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate BlurModified;

		/// <summary>
		/// Raises the blur modified event.
		/// </summary>
		internal void RaiseBlurModified()
		{
			// Inform caller
			if (BlurModified != null) BlurModified();
		}
		#endregion
	}
}
