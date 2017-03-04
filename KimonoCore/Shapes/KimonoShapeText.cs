using System;
using SkiaSharp;
using TextBase;

namespace KimonoCore
{
	/// <summary>
	/// Draws a block of text into the Design Surface within the specifid bounds of this shape.
	/// </summary>
	[Table("Text")]
	public class KimonoShapeText : KimonoShape, IKimonoCodeGeneration, IKimonoPropertyConsumer
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the text.
		/// </summary>
		/// <value>The text.</value>
		public string Text { get; set; } = "Type Something";

		/// <summary>
		/// Gets the font metrics.
		/// </summary>
		/// <value>The font metrics.</value>
		[Ignore]
		public SKFontMetrics FontMetrics
		{
			get { return Style.Fill.FontMetrics; }
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoShapeText"/> is linear text.
		/// </summary>
		/// <value><c>true</c> if is linear text; otherwise, <c>false</c>.</value>
		public bool IsLinearText
		{
			get { return Style.Fill.IsLinearText; }
			set
			{
				Style.Fill.IsLinearText = value;
				Style.Frame.IsLinearText = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoShapeText"/> is vertical text.
		/// </summary>
		/// <value><c>true</c> if is vertical text; otherwise, <c>false</c>.</value>
		public bool IsVerticalText
		{
			get { return Style.Fill.IsVerticalText; }
			set
			{
				Style.Fill.IsVerticalText = value;
				Style.Frame.IsVerticalText = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoShapeText"/> strike thru text.
		/// </summary>
		/// <value><c>true</c> if strike thru text; otherwise, <c>false</c>.</value>
		public bool StrikeThruText
		{
			get { return Style.Fill.StrikeThruText; }
			set
			{
				Style.Fill.StrikeThruText = value;
				Style.Frame.StrikeThruText = value;
			}
		}

		/// <summary>
		/// Gets or sets the text align.
		/// </summary>
		/// <value>The text align.</value>
		public SKTextAlign TextAlign
		{
			get { return Style.Fill.TextAlign; }
			set
			{
				Style.Fill.TextAlign = value;
				Style.Frame.TextAlign = value;
			}
		}

		/// <summary>
		/// Gets or sets the text encoding.
		/// </summary>
		/// <value>The text encoding.</value>
		public SKTextEncoding TextEncoding
		{
			get { return Style.Fill.TextEncoding; }
			set
			{
				Style.Fill.TextEncoding = value;
				Style.Frame.TextEncoding = value;
			}
		}

		/// <summary>
		/// Gets or sets the text scale x.
		/// </summary>
		/// <value>The text scale x.</value>
		public float TextScaleX
		{
			get { return Style.Fill.TextScaleX; }
			set
			{
				Style.Fill.TextScaleX = value;
				Style.Frame.TextScaleX = value;
			}
		}

		/// <summary>
		/// Gets or sets the size of the text.
		/// </summary>
		/// <value>The size of the text.</value>
		public float TextSize
		{
			get { return Style.Fill.TextSize; }
			set
			{
				Style.Fill.TextSize = value;
				Style.Frame.TextSize = value;
			}
		}

		/// <summary>
		/// Gets or sets the text skew x.
		/// </summary>
		/// <value>The text skew x.</value>
		public float TextSkewX
		{
			get { return Style.Fill.TextSkewX; }
			set
			{
				Style.Fill.TextSkewX = value;
				Style.Frame.TextSkewX = value;
			}
		}

		/// <summary>
		/// Gets or sets the typeface.
		/// </summary>
		/// <value>The typeface.</value>
		[Ignore]
		public SKTypeface Typeface
		{
			get { return Style.Fill.Typeface; }
			set
			{
				Style.Fill.Typeface = value;
				Style.Frame.Typeface = value;
			}
		}

		/// <summary>
		/// Gets or sets the name of the font family.
		/// </summary>
		/// <value>The name of the font family.</value>
		public string FontFamilyName
		{
			get { return (Style.Fill.Typeface == null) ? "System" : Style.Fill.Typeface.FamilyName; }
			set
			{
				Typeface = SKTypeface.FromFamilyName(value, TypefaceStyle);
			}
		}

		/// <summary>
		/// Gets or sets the typeface style.
		/// </summary>
		/// <value>The typeface style.</value>
		public SKTypefaceStyle TypefaceStyle
		{
			get { return (Style.Fill.Typeface == null) ? SKTypefaceStyle.Normal : Style.Fill.Typeface.Style; }
			set
			{
				Typeface = SKTypeface.FromFamilyName(FontFamilyName, value);
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoShapeText"/> underline text.
		/// </summary>
		/// <value><c>true</c> if underline text; otherwise, <c>false</c>.</value>
		public bool UnderlineText
		{
			get { return Style.Fill.UnderlineText; }
			set
			{
				Style.Fill.UnderlineText = value;
				Style.Frame.UnderlineText = value;
			}
		}

		/// <summary>
		/// Gets the possible connection points that a `KimonoProperty` can be connected to this
		/// `KimonoShape`.
		/// </summary>
		/// <value>The array of `KimonoPropertyConnectionPoint`.</value>
		[Ignore]
		public override KimonoPropertyConnectionPoint[] ConnectionPoints
		{
			get
			{
				// Return available connection points
				return new KimonoPropertyConnectionPoint[] {
					KimonoPropertyConnectionPoint.Rect,
					KimonoPropertyConnectionPoint.Top,
					KimonoPropertyConnectionPoint.Left,
					KimonoPropertyConnectionPoint.Bottom,
					KimonoPropertyConnectionPoint.Right,
					KimonoPropertyConnectionPoint.Width,
					KimonoPropertyConnectionPoint.Height,
					KimonoPropertyConnectionPoint.RotationDegrees,
					KimonoPropertyConnectionPoint.Style,
					KimonoPropertyConnectionPoint.Visible,
					KimonoPropertyConnectionPoint.Text
				};
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeText"/> class.
		/// </summary>
		public KimonoShapeText()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeText"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		public KimonoShapeText(float left, float top, float right, float bottom) : base(left, top, right, bottom)
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeText"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		/// <param name="state">State.</param>
		public KimonoShapeText(float left, float top, float right, float bottom, KimonoShapeState state) : base(left, top, right, bottom, state)
		{
			Initialize();
		}

		/// <summary>
		/// Initialize this instance.
		/// </summary>
		private void Initialize()
		{
			// Set the default properties
			Name = "Text";
			Style.StyleType = KimonoStyleType.CustomText;
			Style.HasFrame = false;
			Style.Fill.Color = KimonoColor.Black;
		}
		#endregion

		#region Override Methods
		/// <summary>
		/// Updates a `KimonoPropertyConnectionPoint` on this `KimonoShape` with the results
		/// of a Obi Script run on an attached `KimonoProperty`.
		/// </summary>
		/// <param name="connection">Connection.</param>
		public override void UpdatePropertyConnectionPoint(KimonoPropertyConnection connection)
		{

			// Take action based on the connection point
			switch (connection.ConnectionPoint)
			{
				case KimonoPropertyConnectionPoint.Text:
					Text = connection.ConnectedProperty.ToString();
					break;
				default:
					base.UpdatePropertyConnectionPoint(connection);
					break;
			}
		}

		/// <summary>
		/// Converts the current shape to a path.
		/// </summary>
		/// <returns>The shape as a <c>SKPath</c>.</returns>
		public override SKPath ToPath()
		{
			// Update any attached properties
			EvaluateConnectedProperties();

			// Construct new path
			var path = new SKPath();

			// TODO: Convert text block to a set of paths

			// Return path
			return path;
		}

		/// <summary>
		/// Draws the text block into the given Skia Canvas.
		/// </summary>
		/// <remarks>TODO: This routine currently breaks line on characters and it needs
		/// to be adjust to break on word boundaries.</remarks>
		/// <param name="canvas">The <c>SKCanvas</c> to draw into.</param>
		public override void Draw(SKCanvas canvas)
		{
			// Update any attached properties
			EvaluateConnectedProperties();

			// Rotated?
			if (RotationDegrees > 0)
			{
				// Save current state and apply rotation
				canvas.Save();
				canvas.RotateDegrees(RotationDegrees, HorizontalCenter, VerticalCenter);
			}

			// Apply gradients
			ConformGradientToShape(Style.FillGradient, Style.Fill);
			ConformGradientToShape(Style.FrameGradient, Style.Frame);

			// Draw shape
			if (Visible)
			{
				// Vertical text?
				if (IsVerticalText)
				{
					var x = Left + FontMetrics.AverageCharacterWidth;
					var y = Top + FontMetrics.XMax;
					var line = "";

					// Adjust x based on text alignment
					switch (TextAlign)
					{
						case SKTextAlign.Left:
							y = Top + FontMetrics.XMax;
							break;
						case SKTextAlign.Center:
							y = VerticalCenter;
							break;
						case SKTextAlign.Right:
							y = Bottom;
							break;
					}

					// Draw text inside of the bounds
					for (int n = 0; n < Text.Length && y < Bottom; ++n)
					{
						// Get current character
						var c = Text[n];

						// At end of line?
						if ((line.Length) * FontMetrics.XMax > Height)
						{
							// Print current line
							if (Style.HasFill) canvas.DrawText(line, x, y, Style.Fill);
							if (Style.HasFrame) canvas.DrawText(line, x, y, Style.Frame);

							// Advance line
							line = "" + c;
							x += FontMetrics.MaxCharacterWidth;
						}
						else
						{
							// Accumulate characters on line
							line += c;
						}
					}

					// Any text remaining to be printed?
					if (line != "")
					{
						// Print last line
						if (Style.HasFill) canvas.DrawText(line, x, y, Style.Fill);
						if (Style.HasFrame) canvas.DrawText(line, x, y, Style.Frame);
					}
				}
				else
				{
					var x = Left;
					var y = Top + FontMetrics.XMax;
					var line = "";

					// Adjust x based on text alignment
					switch (TextAlign)
					{
						case SKTextAlign.Left:
							x = Left;
							break;
						case SKTextAlign.Center:
							x = HorizontalCenter;
							break;
						case SKTextAlign.Right:
							x = Right;
							break;
					}

					// Draw text inside of the bounds
					for (int n = 0; n < Text.Length && y < Bottom; ++n)
					{
						// Get current character
						var c = Text[n];

						// At end of line?
						if (Style.Fill.MeasureText(line + c) > Width)
						{
							// Print current line
							if (Style.HasFill) canvas.DrawText(line, x, y, Style.Fill);
							if (Style.HasFrame) canvas.DrawText(line, x, y, Style.Frame);

							// Advance line
							line = "" + c;
							y += FontMetrics.XMax;
						}
						else
						{
							// Accumulate characters on line
							line += c;
						}
					}

					// Any text remaining to be printed?
					if (line != "")
					{
						// Print last line
						if (Style.HasFill) canvas.DrawText(line, x, y, Style.Fill);
						if (Style.HasFrame) canvas.DrawText(line, x, y, Style.Frame);
					}
				}
			}

			// Call base to draw bounds if required
			base.Draw(canvas);

			// Rotated?
			if (RotationDegrees > 0)
			{
				// Restore previous state
				canvas.Restore();
			}
		}

		/// <summary>
		/// Grows the bounds of the text block.
		/// </summary>
		/// <remarks>TODO: Changing the bounds of a text box should optionally
		/// scale the size of the text within.</remarks>
		/// <param name="point">The <c>SKPoint</c> to adjust the bounds by.</param>
		public override void GrowBounds(SKPoint point)
		{
			// Update the size of the bounds
			if (point.X > Rect.Left)
			{
				Rect.Right = point.X;
			}
			if (point.Y > Rect.Top)
			{
				Rect.Bottom = point.Y;
			}
			BoundsChanged();
		}

		/// <summary>
		/// Drags the bounds of the text block.
		/// </summary>
		/// <param name="point">The <c>SKPoint</c> with the new location of the bounds.</param>
		public override void DragBounds(SKPoint point)
		{
			// Allow parent to move and size bounds
			base.DragBounds(point);

			// Ensure that the bounds stay positive
			if (Rect.Left > Rect.Right)
			{
				Rect.Right = Rect.Left + 1;
				BoundsChanged();
			}

			if (Rect.Top > Rect.Bottom)
			{
				Rect.Bottom = Rect.Top + 1;
				BoundsChanged();
			}
		}
		#endregion

		#region Conversion Routines
		/// <summary>
		/// Converts the shapes path to C# Skia based code.
		/// </summary>
		/// <returns>The path as code.</returns>
		public override string ToSkiaSharpPath()
		{
			var sourceCode = "";

			// Assemble path name
			if (ElementName == "") KimonoCodeGenerator.MakeElementName(Name);
			var pathName = $"{ElementName}Path";

			// Update any attached properties
			EvaluateConnectedProperties();

			// Define path with Skia
			sourceCode += $"// Define {Name} shape path\n" +
				$"var {pathName} = new SKPath();\n";

			// Define path
			// TODO: Create text code paths

			// Return code
			return sourceCode;
		}

		/// <summary>
		/// Converts the shape to C# code using the Skia library.
		/// </summary>
		/// <remarks>TODO: This routine currently breaks line on characters and it needs
		/// to be adjust to break on word boundaries.</remarks>
		/// <returns>The shape as code.</returns>
		public override string ToSkiaSharp()
		{
			var sourceCode = "";

			// Update any attached properties
			EvaluateConnectedProperties();

			// Draw with Skia
			sourceCode += $"// Draw {Name} shape\n";

			// Rotated?
			if (RotationDegrees > 0)
			{
				// Save current state and apply rotation
				sourceCode += $"canvas.Save();\n" +
					$"canvas.RotateDegrees({RotationDegrees}f, {HorizontalCenter}f, {VerticalCenter}f);\n";
			}

			// Conform gradients first
			sourceCode += ConformedFillGradientCode(CodeOutputLibrary.SkiaSharp) +
				ConformedFrameGradientCode(CodeOutputLibrary.SkiaSharp);
			
			// Draw shape
			if (Visible)
			{
				// Vertical text?
				if (IsVerticalText)
				{
					var x = Left + FontMetrics.AverageCharacterWidth;
					var y = Top + FontMetrics.XMax;
					var line = "";

					// Adjust x based on text alignment
					switch (TextAlign)
					{
						case SKTextAlign.Left:
							y = Top + FontMetrics.XMax;
							break;
						case SKTextAlign.Center:
							y = VerticalCenter;
							break;
						case SKTextAlign.Right:
							y = Bottom;
							break;
					}

					// Draw text inside of the bounds
					for (int n = 0; n < Text.Length && y < Bottom; ++n)
					{
						// Get current character
						var c = Text[n];

						// At end of line?
						if ((line.Length) * FontMetrics.XMax > Height)
						{
							// Print current line
							if (Style.HasFill) sourceCode += $"canvas.DrawText(\"{line}\", {x}f, {y}f, {StyleFillPaintForCode(CodeOutputLibrary.SkiaSharp)});\n";
							if (Style.HasFrame) sourceCode += $"canvas.DrawText(\"{line}\", {x}f, {y}f, {StyleFramePaintForCode(CodeOutputLibrary.SkiaSharp)});\n";

							// Advance line
							line = "" + c;
							x += FontMetrics.MaxCharacterWidth;
						}
						else
						{
							// Accumulate characters on line
							line += c;
						}
					}

					// Any text remaining to be printed?
					if (line != "")
					{
						// Print last line
						if (Style.HasFill) sourceCode += $"canvas.DrawText(\"{line}\", {x}f, {y}f, {StyleFillPaintForCode(CodeOutputLibrary.SkiaSharp)});\n";
						if (Style.HasFrame) sourceCode += $"canvas.DrawText(\"{line}\", {x}f, {y}f, {StyleFramePaintForCode(CodeOutputLibrary.SkiaSharp)});\n";
					}
				}
				else
				{
					var x = Left;
					var y = Top + FontMetrics.XMax;
					var line = "";

					// Adjust x based on text alignment
					switch (TextAlign)
					{
						case SKTextAlign.Left:
							x = Left;
							break;
						case SKTextAlign.Center:
							x = HorizontalCenter;
							break;
						case SKTextAlign.Right:
							x = Right;
							break;
					}

					// Draw text inside of the bounds
					for (int n = 0; n < Text.Length && y < Bottom; ++n)
					{
						// Get current character
						var c = Text[n];

						// At end of line?
						if (Style.Fill.MeasureText(line + c) > Width)
						{
							// Print current line
							if (Style.HasFill) sourceCode += $"canvas.DrawText(\"{line}\", {x}f, {y}f, {StyleFillPaintForCode(CodeOutputLibrary.SkiaSharp)});\n";
							if (Style.HasFrame) sourceCode += $"canvas.DrawText(\"{line}\", {x}f, {y}f, {StyleFramePaintForCode(CodeOutputLibrary.SkiaSharp)});\n";

							// Advance line
							line = "" + c;
							y += FontMetrics.XMax;
						}
						else
						{
							// Accumulate characters on line
							line += c;
						}
					}

					// Any text remaining to be printed?
					if (line != "")
					{
						// Print last line
						if (Style.HasFill) sourceCode += $"canvas.DrawText(\"{line}\", {x}f, {y}f, {StyleFillPaintForCode(CodeOutputLibrary.SkiaSharp)});\n";
						if (Style.HasFrame) sourceCode += $"canvas.DrawText(\"{line}\", {x}f, {y}f, {StyleFramePaintForCode(CodeOutputLibrary.SkiaSharp)});\n";
					}
				}
			}

			// Rotated?
			if (RotationDegrees > 0)
			{
				// Restore previous state
				sourceCode += $"canvas.Restore();\n";
			}

			// Return code
			return sourceCode;
		}

		/// <summary>
		/// Converts this shape C# using the KimonoCore library.
		/// </summary>
		/// <returns>The kimono core.</returns>
		public override string ToKimonoCore()
		{
			var sourceCode = "";

			// Build with KimonoCore
			sourceCode += $"// Draw {Name} shape\n" +
				$"var {ElementName} = new KimonoShapeText({Left}f, {Top}f, {Right}f, {Bottom}f)" + "{" +
				$"\n\tRotationDegrees = {RotationDegrees}," +
				$"\n\tVisible = {Visible.ToString().ToLower()}," +
				$"\n\tStyle = {Style.ElementName}," +
				$"\n\tText = \"{Text}\"" +
				"};\n";

			// Add any connections
			var connections = ConnectionsToKimonoCore();
			if (connections != null)
			{
				sourceCode += $"\n{connections}\n";
			}

			// Draw shape
			sourceCode += $"{ElementName}.Draw(canvas);\n";

			// Return code
			return sourceCode;
		}

		/// <summary>
		/// Converts this shape to C# code.
		/// </summary>
		/// <returns>The shape as C# code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public override string ToCSharp(CodeOutputLibrary outputLibrary)
		{
			var sourceCode = base.ToCode(CodeOutputOS.CrossPlatform, CodeOutputLanguage.CSharp, outputLibrary);

			// Define element name
			ElementName = KimonoCodeGenerator.MakeElementName(Name);

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
		public override string ToCode(CodeOutputOS outputOS, CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";
			var preCode = "";

			// Take action based on the language
			switch (outputLanguage)
			{
				case CodeOutputLanguage.CSharp:
					sourceCode += ToCSharp(outputLibrary);
					break;
				case CodeOutputLanguage.ObiScript:
					sourceCode += "// Shapes are not supported in ObiScript\n";
					break;
			}

			// Assemble precode items in reverse order to ensure dependencies are registered first
			preCode = KimonoCodeGenerator.CodeForSupportStyles(outputLanguage, outputLibrary);
			preCode = KimonoCodeGenerator.CodeForSupportGradients(outputLanguage, outputLibrary) + preCode;
			preCode = KimonoCodeGenerator.CodeForSupportingColors(outputLanguage, outputLibrary) + preCode;

			// Include any supporting elements
			sourceCode = preCode + sourceCode;

			// Return code
			return sourceCode;
		}

        /// <summary>
        /// Generates F# representation of <c>this</c>
        /// </summary>
        /// <returns>The F# code.</returns>
        /// <param name="outputLibrary">Output library.</param>
        public override string ToFSharp (CodeOutputLibrary outputLibrary) => FSharpCodeGenerator.ToCode (this, outputLibrary);

        /// <summary>
        /// Forwards to extension method
        /// </summary>
        /// <returns>The Skia representation of <c>this</c>.</returns>
        public override string ToFSharpSkia () => this.ToFSharpSkiaImpl ();

        /// <summary>
        /// Forwards to extension method
        /// </summary>
        /// <returns>The KimonoCore representation of <c>this</c>.</returns>
        public override string ToFSharpKimonoCore () => this.ToFSharpKimonoCoreImpl ();

		#endregion

		#region Cloning
		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>The clone <c>KimonoShapeText</c>.</returns>
		public override KimonoBounds Clone()
		{
			// Duplicate shape
			var newShape = new KimonoShapeText(this.Left, this.Top, this.Right, this.Bottom, this.State)
			{
				UniqueID = this.UniqueID,
				Name = this.Name,
				Style = CloneAttachedStyle(),
				Visible = this.Visible,
				Text = this.Text,
				LayerDepth = this.LayerDepth
			};

			// Clone control points
			foreach (KimonoHandle handle in ControlPoints)
			{
				// Duplicate handle and add to collection
				newShape.ControlPoints.Add(handle.Clone());
			}

			// Clone any property connections
			foreach (KimonoPropertyConnection connection in PropertyConnections)
			{
				// Add duplicate connection
				newShape.PropertyConnections.Add(connection.Clone());
			}

			// Return new shape
			return newShape;
		}
		#endregion
	}
}
