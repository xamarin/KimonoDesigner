using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Draws a multi-sided star shape into the Design Surface.
	/// </summary>
	public class KimonoShapeStar : KimonoShape, IKimonoCodeGeneration
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the number of points.
		/// </summary>
		/// <value>The number of points.</value>
		public int NumberOfPoints { get; set; } = 5;

		/// <summary>
		/// Gets or sets the skip points.
		/// </summary>
		/// <value>The skip points.</value>
		public int SkipPoints { get; set; } = 2;

		/// <summary>
		/// Gets or sets the depth offset for the individual points.
		/// </summary>
		/// <value>The depth offset.</value>
		public int DepthOffset { get; set; } = 0;

		/// <summary>
		/// Gets the possible connection points that a `KimonoProperty` can be connected to this
		/// `KimonoShape`.
		/// </summary>
		/// <value>The array of `KimonoPropertyConnectionPoint`.</value>
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
					KimonoPropertyConnectionPoint.NumberOfPoints,
					KimonoPropertyConnectionPoint.SkipPoints,
					KimonoPropertyConnectionPoint.DepthOffset
				};
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeStar"/> class.
		/// </summary>
		public KimonoShapeStar()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeStar"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		public KimonoShapeStar(float left, float top, float right, float bottom) : base(left, top, right, bottom)
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeStar"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		/// <param name="state">State.</param>
		public KimonoShapeStar(float left, float top, float right, float bottom, KimonoShapeState state) : base(left, top, right, bottom, state)
		{
			Initialize();
		}

		/// <summary>
		/// Initialize this instance.
		/// </summary>
		private void Initialize()
		{
			// Set the default properties
			Name = "Star";
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
		private SKPoint[] MakeStarPoints(double startTheta, int numPoints, int skip, SKRect rect, float depth)
		{
			double theta, dtheta;
			SKPoint[] result;
			float cx = rect.Width / 2f;
			float cy = rect.Height / 2f;

			// If this is a polygon, don't bother with concave points.
			if (skip == 1)
			{
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

			// Find the radius for the concave vertices.
			double concave_radius = CalculateConcaveRadius(numPoints, skip) - depth;

			// Make the points.
			result = new SKPoint[2 * numPoints];
			theta = startTheta;
			dtheta = Math.PI / numPoints; for (int i = 0; i < numPoints; i++)
			{
				result[2 * i] = new SKPoint(
					(float)(rect.Left + cx + cx * Math.Cos(theta)),
					(float)(rect.Top + cy + cy * Math.Sin(theta)));
				theta += dtheta;
				result[2 * i + 1] = new SKPoint(
					(float)(rect.Left + cx + cx * Math.Cos(theta) * concave_radius),
					(float)(rect.Top + cy + cy * Math.Sin(theta) * concave_radius));
				theta += dtheta;
			}
			return result;
		}

		/// <summary>
		/// Calculates the concave radius.
		/// </summary>
		/// <returns>The concave radius.</returns>
		/// <remarks>This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/
		/// by Rod Stephens.</remarks>
		/// <param name="numPoints">Number points.</param>
		/// <param name="skip">Skip.</param>
		private double CalculateConcaveRadius(int numPoints, int skip)
		{
			// For really small numbers of points.
			if (numPoints < 5) return 0.33f;

			// Calculate angles to key points.
			double dtheta = 2 * Math.PI / numPoints;
			double theta00 = -Math.PI / 2;
			double theta01 = theta00 + dtheta * skip;
			double theta10 = theta00 + dtheta;
			double theta11 = theta10 - dtheta * skip;

			// Find the key points.
			var pt00 = new SKPoint(
				(float)Math.Cos(theta00),
				(float)Math.Sin(theta00));
			var pt01 = new SKPoint(
				(float)Math.Cos(theta01),
				(float)Math.Sin(theta01));
			var pt10 = new SKPoint(
				(float)Math.Cos(theta10),
				(float)Math.Sin(theta10));
			var pt11 = new SKPoint(
				(float)Math.Cos(theta11),
				(float)Math.Sin(theta11));

			// See where the segments connecting the points intersect.
			bool lines_intersect, segments_intersect;
			SKPoint intersection, close_p1, close_p2;
			FindIntersection(pt00, pt01, pt10, pt11,
				out lines_intersect, out segments_intersect,
				out intersection, out close_p1, out close_p2);

			// Calculate the distance between the
			// point of intersection and the center.
			return Math.Sqrt(
				intersection.X * intersection.X +
				intersection.Y * intersection.Y);
		}

		/// <summary>
		/// Finds the intersection.
		/// </summary>
		/// <remarks>This code adapted from http://csharphelper.com/blog/2014/08/determine-where-two-lines-intersect-in-c/
		/// by Rod Stephens.</remarks>
		/// <param name="p1">P1.</param>
		/// <param name="p2">P2.</param>
		/// <param name="p3">P3.</param>
		/// <param name="p4">P4.</param>
		/// <param name="lines_intersect">If set to <c>true</c> lines intersect.</param>
		/// <param name="segments_intersect">If set to <c>true</c> segments intersect.</param>
		/// <param name="intersection">Intersection.</param>
		/// <param name="close_p1">Close p1.</param>
		/// <param name="close_p2">Close p2.</param>
		private void FindIntersection(
	SKPoint p1, SKPoint p2, SKPoint p3, SKPoint p4,
	out bool lines_intersect, out bool segments_intersect,
	out SKPoint intersection,
	out SKPoint close_p1, out SKPoint close_p2)
		{
			// Get the segments' parameters.
			float dx12 = p2.X - p1.X;
			float dy12 = p2.Y - p1.Y;
			float dx34 = p4.X - p3.X;
			float dy34 = p4.Y - p3.Y;

			// Solve for t1 and t2
			float denominator = (dy12 * dx34 - dx12 * dy34);

			float t1 =
				((p1.X - p3.X) * dy34 + (p3.Y - p1.Y) * dx34)
					/ denominator;
			if (float.IsInfinity(t1))
			{
				// The lines are parallel (or close enough to it).
				lines_intersect = false;
				segments_intersect = false;
				intersection = new SKPoint(float.NaN, float.NaN);
				close_p1 = new SKPoint(float.NaN, float.NaN);
				close_p2 = new SKPoint(float.NaN, float.NaN);
				return;
			}
			lines_intersect = true;

			float t2 =
				((p3.X - p1.X) * dy12 + (p1.Y - p3.Y) * dx12)
					/ -denominator;

			// Find the point of intersection.
			intersection = new SKPoint(p1.X + dx12 * t1, p1.Y + dy12 * t1);

			// The segments intersect if t1 and t2 are between 0 and 1.
			segments_intersect =
				((t1 >= 0) && (t1 <= 1) &&
				 (t2 >= 0) && (t2 <= 1));

			// Find the closest points on the segments.
			if (t1 < 0)
			{
				t1 = 0;
			}
			else if (t1 > 1)
			{
				t1 = 1;
			}

			if (t2 < 0)
			{
				t2 = 0;
			}
			else if (t2 > 1)
			{
				t2 = 1;
			}

			close_p1 = new SKPoint(p1.X + dx12 * t1, p1.Y + dy12 * t1);
			close_p2 = new SKPoint(p3.X + dx34 * t2, p3.Y + dy34 * t2);
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
				case KimonoPropertyConnectionPoint.NumberOfPoints:
					NumberOfPoints = connection.ConnectedProperty.ToInt();
					break;
				case KimonoPropertyConnectionPoint.SkipPoints:
					SkipPoints = connection.ConnectedProperty.ToInt();
					break;
				case KimonoPropertyConnectionPoint.DepthOffset:
					DepthOffset = connection.ConnectedProperty.ToInt();
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
			var points = MakeStarPoints(-Math.PI / 2, NumberOfPoints, SkipPoints, Rect, DepthOffset * .01f);

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
		/// Draws the star into the given Skia Canvas.
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
		/// Converts the star into a vector.
		/// </summary>
		/// <returns>The <c>KimonoShapeVector</c> version of the star.</returns>
		public override KimonoShapeVector ToVector()
		{
			var vector = new KimonoShapeVector();

			// Define star points
			var points = MakeStarPoints(-Math.PI / 2, NumberOfPoints, SkipPoints, Rect, DepthOffset * .01f);

			// Add points to vector
			foreach (SKPoint point in points)
			{
				vector.AddPoint(point);
			}

			// Return new vector
			return vector;
		}
		#endregion

		#region Conversion Routines
		/// <summary>
		/// Converts this object to source code for the given OS, Language and Library.
		/// </summary>
		/// <returns>The object represented as source code in a `string`.</returns>
		/// <param name="outputOS">The `CodeOutputOS`.</param>
		/// <param name="outputLanguage">The `CodeOutputLanguage`.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary`.</param>
		public override string ToCode(CodeOutputOS outputOS, CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			return "";
		}
		#endregion

		#region Cloning
		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>The clone <c>KimonoShapeStar</c>.</returns>
		public override KimonoBounds Clone()
		{
			// Duplicate shape
			var newShape = new KimonoShapeStar(this.Left, this.Top, this.Right, this.Bottom, this.State)
			{
				UniqueID = this.UniqueID,
				Name = this.Name,
				Style = CloneAttachedStyle(),
				Visible = this.Visible,
				NumberOfPoints = this.NumberOfPoints,
				SkipPoints = this.SkipPoints,
				DepthOffset = this.DepthOffset,
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
