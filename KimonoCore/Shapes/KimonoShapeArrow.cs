using System;
using SkiaSharp;
using TextBase;

namespace KimonoCore
{
	/// <summary>
	/// Draws either an outlined or single line arrow with heads on one or both ends.
	/// </summary>
	[Table("Arrow")]
	public class KimonoShapeArrow : KimonoShape, IKimonoCodeGeneration, IKimonoPropertyConsumer
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoShapeArrow"/> has start head.
		/// </summary>
		/// <value><c>true</c> if has start head; otherwise, <c>false</c>.</value>
		public bool HasStartHead { get; set; } = false;

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoShapeArrow"/> has end head.
		/// </summary>
		/// <value><c>true</c> if has end head; otherwise, <c>false</c>.</value>
		public bool HasEndHead { get; set; } = true;

		/// <summary>
		/// Gets or sets the head inner ratio.
		/// </summary>
		/// <value>The head inner ratio.</value>
		public float HeadInnerRatio { get; set; } = 15;

		/// <summary>
		/// Gets or sets the head outer ratio.
		/// </summary>
		/// <value>The head outer ratio.</value>
		public float HeadOuterRatio { get; set; } = 15;

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoShapeArrow"/> is streamlined.
		/// </summary>
		/// <remarks>A Streamlined Arrow, is drawn as a single line.</remarks>
		/// <value><c>true</c> if is streamlined; otherwise, <c>false</c>.</value>
		public bool IsStreamlined { get; set; } = false;

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
					KimonoPropertyConnectionPoint.HasStartHead,
					KimonoPropertyConnectionPoint.HasEndHead,
					KimonoPropertyConnectionPoint.HeadInnerRatio,
					KimonoPropertyConnectionPoint.HeadOuterRatio,
					KimonoPropertyConnectionPoint.IsStreamlined
				};
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeArrow"/> class.
		/// </summary>
		public KimonoShapeArrow()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeArrow"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		public KimonoShapeArrow(float left, float top, float right, float bottom) : base(left, top, right, bottom)
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeArrow"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		/// <param name="state">State.</param>
		public KimonoShapeArrow(float left, float top, float right, float bottom, KimonoShapeState state) : base(left, top, right, bottom, state)
		{
			Initialize();
		}

		/// <summary>
		/// Initialize this instance.
		/// </summary>
		private void Initialize()
		{
			// Set the default properties
			Name = "Arrow";
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
				case KimonoPropertyConnectionPoint.HasStartHead:
					HasStartHead = connection.ConnectedProperty.ToBool();
					break;
				case KimonoPropertyConnectionPoint.HasEndHead:
					HasEndHead = connection.ConnectedProperty.ToBool();
					break;
				case KimonoPropertyConnectionPoint.HeadInnerRatio:
					HeadInnerRatio = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.HeadOuterRatio:
					HeadOuterRatio = connection.ConnectedProperty.ToFloat();
					break;
				case KimonoPropertyConnectionPoint.IsStreamlined:
					IsStreamlined = connection.ConnectedProperty.ToBool();
					break;
				default:
					base.UpdatePropertyConnectionPoint(connection);
					break;
			}
		}

		/// <summary>
		/// Converts the arrow to a path.
		/// </summary>
		/// <returns>The the arrow as a <c>SKPath</c>.</returns>
		public override SKPath ToPath()
		{
			// Update any attached properties
			EvaluateConnectedProperties();

			// Define path
			var path = new SKPath();
			var innerSize = Width * (HeadInnerRatio * .01f);
			var outerSize = Width * (HeadOuterRatio * .01f);
			var bodyThickness = Height / 4;

			// Is this a streamlined arrow?
			if (IsStreamlined)
			{
				// Yes, start streamlined arrow
				path.MoveTo(new SKPoint(Left, VerticalCenter));

				// Has starting head?
				if (HasStartHead)
				{
					// Draw head
					path.LineTo(new SKPoint(Left + outerSize, Top));
					path.LineTo(new SKPoint(Left + innerSize, VerticalCenter));
					path.LineTo(new SKPoint(Left + outerSize, Bottom));
					path.LineTo(new SKPoint(Left, VerticalCenter));
					path.MoveTo(new SKPoint(Left + innerSize, VerticalCenter));
				}

				// Has ending head?
				if (HasEndHead)
				{
					// Draw body
					path.LineTo(new SKPoint(Right - innerSize, VerticalCenter));
					path.MoveTo(new SKPoint(Right, VerticalCenter));

					// Draw head
					path.LineTo(new SKPoint(Right - outerSize, Top));
					path.LineTo(new SKPoint(Right - innerSize, VerticalCenter));
					path.LineTo(new SKPoint(Right - outerSize, Bottom));
					path.LineTo(new SKPoint(Right, VerticalCenter));
				}
				else
				{
					// Draw body
					path.LineTo(new SKPoint(Right, VerticalCenter));
				}

			}
			else
			{
				// No, start thick arrow
				if (HasStartHead)
				{
					// Draw head
					path.MoveTo(new SKPoint(Left + innerSize, VerticalCenter + bodyThickness));
					path.LineTo(new SKPoint(Left + outerSize, Bottom));
					path.LineTo(new SKPoint(Left, VerticalCenter));
					path.LineTo(new SKPoint(Left + outerSize, Top));
					path.LineTo(new SKPoint(Left + innerSize, VerticalCenter - bodyThickness));
				}
				else
				{
					// Draw flat end
					path.MoveTo(new SKPoint(Left, VerticalCenter + bodyThickness));
					path.LineTo(new SKPoint(Left, VerticalCenter - bodyThickness));
				}

				// Has ending head?
				if (HasEndHead)
				{
					// Draw Head
					path.LineTo(new SKPoint(Right - innerSize, VerticalCenter - bodyThickness));
					path.LineTo(new SKPoint(Right - outerSize, Top));
					path.LineTo(new SKPoint(Right, VerticalCenter));
					path.LineTo(new SKPoint(Right - outerSize, Bottom));
					path.LineTo(new SKPoint(Right - innerSize, VerticalCenter + bodyThickness));
				}
				else
				{
					// Draw flat end
					path.LineTo(new SKPoint(Right, VerticalCenter - bodyThickness));
					path.LineTo(new SKPoint(Right, VerticalCenter + bodyThickness));
				}

				// Terminate
				if (HasStartHead)
				{
					// Close head
					path.LineTo(new SKPoint(Left + innerSize, VerticalCenter + bodyThickness));
				}
				else
				{
					// Close flat end
					path.LineTo(new SKPoint(Left, VerticalCenter + bodyThickness));
				}
			}

			// Return new path
			return path;
		}

		/// <summary>
		/// Draws the arrow into the specified Skia canvas.
		/// </summary>
		/// <param name="canvas">The <c>SKCanvas</c> to draw into.</param>
		public override void Draw(SKCanvas canvas)
		{
			// Define path
			var path = ToPath();

			// Rotated?
			if (RotationDegrees > 0)
			{
				// Save current state and apply rotation
				canvas.Save();
				canvas.RotateDegrees(RotationDegrees, HorizontalCenter, VerticalCenter);
			}

			// Draw shape
			if (Visible)
			{
				if (Style.HasFill)
				{
					ConformGradientToShape(Style.FillGradient, Style.Fill);
					canvas.DrawPath(path, Style.Fill);
				}
				if (Style.HasFrame)
				{
					ConformGradientToShape(Style.FrameGradient, Style.Frame);
					canvas.DrawPath(path, Style.Frame);
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
		/// Grows the bounds of the arrow.
		/// </summary>
		/// <param name="point">The <c>SKPoint</c> containing the bounds adjustment.</param>
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
		/// Drags the bounds of the arrow to a new location.
		/// </summary>
		/// <param name="point">The <c>SKPoint</c> specifying the new location of the bounds.</param>
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

			// Define path with Skia
			sourceCode += $"// Define {Name} shape path\n"+
				$"var {pathName} = new SKPath();\n";

			// Calculate sizes
			var innerSize = Width * (HeadInnerRatio * .01f);
			var outerSize = Width * (HeadOuterRatio * .01f);
			var bodyThickness = Height / 4;

			// Is this a streamlined arrow?
			if (IsStreamlined)
			{
				// Yes, start streamlined arrow
				sourceCode += $"{pathName}.MoveTo(new SKPoint({Left}f, {VerticalCenter}f));\n";

				// Has starting head?
				if (HasStartHead)
				{
					// Draw head
					sourceCode += $"{pathName}.LineTo(new SKPoint({Left + outerSize}f, {Top}f));\n" +
						$"{pathName}.LineTo(new SKPoint({Left + innerSize}f, {VerticalCenter}f));\n" +
						$"{pathName}.LineTo(new SKPoint({Left + outerSize}f, {Bottom}f));\n" +
						$"{pathName}.LineTo(new SKPoint({Left}f, {VerticalCenter}f));\n" +
						$"{pathName}.MoveTo(new SKPoint({Left + innerSize}f, {VerticalCenter}f));\n";
				}

				// Has ending head?
				if (HasEndHead)
				{
					// Draw body
					sourceCode += $"{pathName}.LineTo(new SKPoint({Right - innerSize}f, {VerticalCenter}f));\n" +
						$"{pathName}.MoveTo(new SKPoint({Right}f, {VerticalCenter}f));\n";

					// Draw head
					sourceCode += $"{pathName}.LineTo(new SKPoint({Right - outerSize}f, {Top}f));\n" +
						$"{pathName}.LineTo(new SKPoint({Right - innerSize}f, {VerticalCenter}f));\n" +
						$"{pathName}.LineTo(new SKPoint({Right - outerSize}f, {Bottom}f));\n" +
						$"{pathName}.LineTo(new SKPoint({Right}f, {VerticalCenter}f));\n";
				}
				else
				{
					// Draw body
					sourceCode += $"{pathName}.LineTo(new SKPoint({Right}f, {VerticalCenter}f));\n";
				}

			}
			else
			{
				// No, start thick arrow
				if (HasStartHead)
				{
					// Draw head
					sourceCode += $"{pathName}.MoveTo(new SKPoint({Left + innerSize}f, {VerticalCenter + bodyThickness}f));\n" +
						$"{pathName}.LineTo(new SKPoint({Left + outerSize}f, {Bottom}f));\n" +
						$"{pathName}.LineTo(new SKPoint({Left}f, {VerticalCenter}f));\n" +
						$"{pathName}.LineTo(new SKPoint({Left + outerSize}f, {Top}f));\n" +
						$"{pathName}.LineTo(new SKPoint({Left + innerSize}f, {VerticalCenter - bodyThickness}f));\n";
				}
				else
				{
					// Draw flat end
					sourceCode += $"{pathName}.MoveTo(new SKPoint({Left}f, {VerticalCenter + bodyThickness}f));\n" +
						$"{pathName}.LineTo(new SKPoint({Left}f, {VerticalCenter - bodyThickness}f));\n";
				}

				// Has ending head?
				if (HasEndHead)
				{
					// Draw Head
					sourceCode += $"{pathName}.LineTo(new SKPoint({Right - innerSize}f, {VerticalCenter - bodyThickness}f));\n" +
						$"{pathName}.LineTo(new SKPoint({Right - outerSize}f, {Top}f));\n" +
						$"{pathName}.LineTo(new SKPoint({Right}f, {VerticalCenter}f));\n" +
						$"{pathName}.LineTo(new SKPoint({Right - outerSize}f, {Bottom}f));\n" +
						$"{pathName}.LineTo(new SKPoint({Right - innerSize}f, {VerticalCenter + bodyThickness}f));\n";
				}
				else
				{
					// Draw flat end
					sourceCode += $"{pathName}.LineTo(new SKPoint({Right}f, {VerticalCenter - bodyThickness}f));\n" +
						$"{pathName}.LineTo(new SKPoint({Right}f, {VerticalCenter + bodyThickness}f));\n";
				}

				// Terminate
				if (HasStartHead)
				{
					// Close head
					sourceCode += $"{pathName}.LineTo(new SKPoint({Left + innerSize}f, {VerticalCenter + bodyThickness}f));\n";
				}
				else
				{
					// Close flat end
					sourceCode += $"{pathName}.LineTo(new SKPoint({Left}f, {VerticalCenter + bodyThickness}f));\n";
				}
			}

			// Return code
			return sourceCode;
		}

		/// <summary>
		/// Converts the shape to C# code using the Skia library.
		/// </summary>
		/// <returns>The shape as code.</returns>
		public override string ToSkiaSharp()
		{
			var sourceCode = "";
			var pathName = $"{ElementName}Path";

			// Update any attached properties
			EvaluateConnectedProperties();

			// Visible?
			if (Visible)
			{
				// Yes, include shape path
				sourceCode += ToSkiaSharpPath()+"\n";
			}

			// Draw with Skia
			sourceCode += $"// Draw {Name} shape\n";

			// Rotated?
			if (RotationDegrees > 0)
			{
				// Save current state and apply rotation
				sourceCode += $"canvas.Save();\n" +
					$"canvas.RotateDegrees({RotationDegrees}f, {HorizontalCenter}f, {VerticalCenter}f);\n";
			}

			// Draw shape
			if (Visible)
			{
				if (Style.HasFill)
				{
					sourceCode += ConformedFillGradientCode(CodeOutputLibrary.SkiaSharp) +
						$"canvas.DrawPath({pathName}, {StyleFillPaintForCode(CodeOutputLibrary.SkiaSharp)});\n";
				}
				if (Style.HasFrame)
				{
					sourceCode += ConformedFrameGradientCode(CodeOutputLibrary.SkiaSharp) +
						$"canvas.DrawPath({pathName}, {StyleFramePaintForCode(CodeOutputLibrary.SkiaSharp)});\n";
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

			// Build with Skia
			sourceCode += $"// Draw {Name} shape\n" +
				$"var {ElementName} = new KimonoShapeArrow({Left}f, {Top}f, {Right}f, {Bottom}f)" + "{" +
				$"\n\tRotationDegrees = {RotationDegrees}," +
				$"\n\tVisible = {Visible.ToString().ToLower()}," +
				$"\n\tStyle = {Style.ElementName}," +
				$"\n\tHasStartHead = {HasStartHead.ToString().ToLower()}," +
				$"\n\tHasEndHead = {HasEndHead.ToString().ToLower()}," +
				$"\n\tHeadInnerRatio = {HeadInnerRatio}," +
				$"\n\tHeadOuterRatio = {HeadOuterRatio}," +
				$"\n\tIsStreamlined = {IsStreamlined.ToString().ToLower()}" +
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
		#endregion

		#region Cloning
		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>The clone of the <c>KimonoArrow</c>.</returns>
		public override KimonoBounds Clone()
		{
			// Duplicate shape
			var newShape = new KimonoShapeArrow(this.Left, this.Top, this.Right, this.Bottom, this.State)
			{
				UniqueID = this.UniqueID,
				Name = this.Name,
				Style = CloneAttachedStyle(),
				Visible = this.Visible,
				HasStartHead = this.HasStartHead,
				HasEndHead = this.HasEndHead,
				HeadInnerRatio = this.HeadInnerRatio,
				HeadOuterRatio = this.HeadOuterRatio,
				IsStreamlined = this.IsStreamlined,
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
