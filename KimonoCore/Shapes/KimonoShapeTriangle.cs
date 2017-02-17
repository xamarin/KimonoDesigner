using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Draws a triangle into the Design Surface.
	/// </summary>
	public class KimonoShapeTriangle : KimonoShape, IKimonoCodeGeneration, IKimonoPropertyConsumer
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeTriangle"/> class.
		/// </summary>
		public KimonoShapeTriangle()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeTriangle"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		public KimonoShapeTriangle(float left, float top, float right, float bottom) : base(left, top, right, bottom)
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeTriangle"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		/// <param name="state">State.</param>
		public KimonoShapeTriangle(float left, float top, float right, float bottom, KimonoShapeState state) : base(left, top, right, bottom, state)
		{
			Initialize();
		}

		/// <summary>
		/// Initialize this instance.
		/// </summary>
		private void Initialize()
		{
			// Set the default properties
			Name = "Triangle";
		}
		#endregion

		#region Override Methods
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

			// Define path
			path.MoveTo(new SKPoint(HorizontalCenter, Top));
			path.LineTo(new SKPoint(Right, Bottom));
			path.LineTo(new SKPoint(Left, Bottom));
			path.LineTo(new SKPoint(HorizontalCenter, Top));

			// Return path
			return path;
		}

		/// <summary>
		/// Draws the triangle into the given Skia Canvas.
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
			sourceCode += $"{pathName}.MoveTo(new SKPoint({HorizontalCenter}f, {Top}f));\n" +
				$"{pathName}.LineTo(new SKPoint({Right}f, {Bottom}f));\n" +
				$"{pathName}.LineTo(new SKPoint({Left}f, {Bottom}f));\n" +
				$"{pathName}.LineTo(new SKPoint({HorizontalCenter}f, {Top}f));\n";

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

			// Visible?
			if (Visible)
			{
				// Yes, include shape path
				sourceCode += ToSkiaSharpPath() + "\n";
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

			// Draw with KimonoCore
			sourceCode += $"// Draw {Name} shape\n" +
				$"var {ElementName} = new KimonoShapeTriangle({Left}f, {Top}f, {Right}f, {Bottom}f)" + "{" +
				$"\n\tRotationDegrees = {RotationDegrees}," +
				$"\n\tVisible = {Visible.ToString().ToLower()}," +
				$"\n\tStyle = {Style.ElementName}" +
				"};\n" +
				$"{ElementName}.Draw(canvas);\n";

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
		/// <returns>The clone <c>KimonoShapeTriangle</c>.</returns>
		public override KimonoBounds Clone()
		{
			// Duplicate shape
			var newShape = new KimonoShapeTriangle(this.Left, this.Top, this.Right, this.Bottom, this.State)
			{
				UniqueID = this.UniqueID,
				Name = this.Name,
				Style = CloneAttachedStyle(),
				Visible = this.Visible,
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
