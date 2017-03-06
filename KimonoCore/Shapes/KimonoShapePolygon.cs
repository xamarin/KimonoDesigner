using System;
using SkiaSharp;
using TextBase;

namespace KimonoCore
{
	/// <summary>
	/// Draws a multi-sided polygon into the Design Surface.
	/// </summary>
	[Table("Polygon")]
	public class KimonoShapePolygon : KimonoShape, IKimonoCodeGeneration, IKimonoPropertyConsumer
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the number of sides.
		/// </summary>
		/// <value>The number of sides.</value>
		public int NumberOfSides { get; set; } = 5;

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
					KimonoPropertyConnectionPoint.NumberOfSides
				};
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapePolygon"/> class.
		/// </summary>
		public KimonoShapePolygon()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapePolygon"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		public KimonoShapePolygon(float left, float top, float right, float bottom) : base(left, top, right, bottom)
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapePolygon"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		/// <param name="state">State.</param>
		public KimonoShapePolygon(float left, float top, float right, float bottom, KimonoShapeState state) : base(left, top, right, bottom, state)
		{
			Initialize();
		}

		/// <summary>
		/// Initialize this instance.
		/// </summary>
		private void Initialize()
		{
			// Set the default properties
			Name = "Polygon";
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Makes the star points.
		/// </summary>
		/// <returns>The star points.</returns>
		/// <remarks>This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/
		/// by Rod Stephens.</remarks>
		/// <param name="startTheta">Start theta.</param>
		/// <param name="numPoints">Number points.</param>
		/// <param name="skip">Skip.</param>
		/// <param name="rect">Rect.</param>
		private SKPoint[] MakeSidePoints(double startTheta, int numPoints, SKRect rect)
		{
			double theta, dtheta;
			SKPoint[] result;
			float cx = rect.Width / 2f;
			float cy = rect.Height / 2f;

			// Make Polygon points
			result = new SKPoint[numPoints];
			theta = startTheta;
			dtheta = 2 * Math.PI / numPoints;
			for (int i = 0; i < numPoints; i++)
			{
				result[i] = new SKPoint(
					(float)(rect.Left + cx + cx * Math.Cos(theta)),
					(float)(rect.Top + cy + cy * Math.Sin(theta)));
				theta += dtheta;
			}
			return result;
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
			var amount = 0;

			// Take action based on the connection point
			switch (connection.ConnectionPoint)
			{
				case KimonoPropertyConnectionPoint.NumberOfSides:
					amount = connection.ConnectedProperty.ToInt();
					if (amount > 2 && amount < 20) NumberOfSides = amount;
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

			// Define star points
			var points = MakeSidePoints(-Math.PI / 2, NumberOfSides, Rect);

			// Define path
			path.MoveTo(points[0]);
			for (int n = 1; n < points.Length; n++)
			{
				path.LineTo(points[n]);
			}
			path.LineTo(points[0]);

			// Return path
			return path;
		}

		/// <summary>
		/// Draws the polygon into the given Skia Canvas.
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

			// Assemble path name
			if (ElementName == "") KimonoCodeGenerator.MakeElementName(Name);
			var pathName = $"{ElementName}Path";

			// Define star points
			var points = MakeSidePoints(-Math.PI / 2, NumberOfSides, Rect);

			// Define path with Skia
			sourceCode += $"// Define {Name} shape path\n" +
				$"var {pathName} = new SKPath();\n";
			
			// Define path
			sourceCode += $"{pathName}.MoveTo(new SKPoint({points[0].X}f, {points[0].Y}f));\n";
			for (int n = 1; n < points.Length; n++)
			{
				sourceCode += $"{pathName}.LineTo(new SKPoint({points[n].X}f, {points[n].Y}f));\n";
			}
			sourceCode += $"{pathName}.LineTo(new SKPoint({points[0].X}f, {points[0].Y}f));\n";

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
				$"var {ElementName} = new KimonoShapePolygon({Left}f, {Top}f, {Right}f, {Bottom}f)" + "{" +
				$"\n\tRotationDegrees = {RotationDegrees}," +
				$"\n\tVisible = {Visible.ToString().ToLower()}," +
				$"\n\tStyle = {Style.ElementName}," +
				$"\n\tNumberOfSides = {NumberOfSides}" +
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
        /// Visitor pattern: returns results of double-dispatch to code generator
        /// </summary>
        /// <returns>The code from the code generator visitor.</returns>
        /// <param name="visitor">A code generator.</param>
        /// <remarks>Note that implementation is always just `=>visitor.CodeGen(this)`</remarks>
        public string ToCode (IVisitorCodeGen visitor) => visitor.CodeGen(this);


		#endregion

		#region Cloning
		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>The clone <c>KimonoPloygon</c>.</returns>
		public override KimonoBounds Clone()
		{
			// Duplicate shape
			var newShape = new KimonoShapePolygon(this.Left, this.Top, this.Right, this.Bottom, this.State)
			{
				UniqueID = this.UniqueID,
				Name = this.Name,
				Style = CloneAttachedStyle(),
				Visible = this.Visible,
				NumberOfSides = this.NumberOfSides,
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
