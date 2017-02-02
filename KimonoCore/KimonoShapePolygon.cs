using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Draws a multi-sided polygon into the Design Surface.
	/// </summary>
	public class KimonoShapePolygon : KimonoShape
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the number of sides.
		/// </summary>
		/// <value>The number of sides.</value>
		public int NumberOfSides { get; set; } = 5;
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
		/// Draws the polygon into the given Skia Canvas.
		/// </summary>
		/// <param name="canvas">The <c>SKCanvas</c> to draw into.</param>
		public override void Draw(SKCanvas canvas)
		{
			// Define star points
			var points = MakeSidePoints(-Math.PI / 2, NumberOfSides, Rect);

			// Define path
			var path = new SKPath();
			path.MoveTo(points[0]);
			for (int n = 1; n < points.Length; n++)
			{
				path.LineTo(points[n]);
			}
			path.LineTo(points[0]);

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

			// Return new shape
			return newShape;
		}
		#endregion
	}
}
