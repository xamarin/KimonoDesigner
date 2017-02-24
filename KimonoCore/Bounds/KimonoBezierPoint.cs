using System;
using SkiaSharp;
using TextBase;

namespace KimonoCore
{
	/// <summary>
	/// Holds the control and end point for a <c>KimonoShapeBezier</c> that define a quad
	/// section of the Bezier.
	/// </summary>
	[Table("BezierPoint")]
	public class KimonoBezierPoint
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the control point.
		/// </summary>
		/// <value>The control point.</value>
		[Child]
		public SKPoint ControlPoint { get; set; } = new SKPoint();

		/// <summary>
		/// Gets or sets the end point.
		/// </summary>
		/// <value>The end point.</value>
		[Child]
		public SKPoint EndPoint { get; set; } = new SKPoint();
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoBezierPoint"/> class.
		/// </summary>
		public KimonoBezierPoint()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoBezierPoint"/> class.
		/// </summary>
		/// <param name="controlPoint">Control point.</param>
		/// <param name="endPoint">End point.</param>
		public KimonoBezierPoint(SKPoint controlPoint, SKPoint endPoint)
		{
			// Initialize
			ControlPoint = controlPoint;
			EndPoint = endPoint;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoBezierPoint"/> class.
		/// </summary>
		/// <param name="controlX">Control x.</param>
		/// <param name="controlY">Control y.</param>
		/// <param name="endX">End x.</param>
		/// <param name="endY">End y.</param>
		public KimonoBezierPoint(float controlX, float controlY, float endX, float endY)
		{
			// Initialize
			ControlPoint = new SKPoint(controlX, controlY);
			EndPoint = new SKPoint(endX, endY);
		}
		#endregion

		#region Cloning
		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>The clone.</returns>
		public KimonoBezierPoint Clone()
		{
			// Make new copy
			var newPoint = new KimonoBezierPoint(this.ControlPoint.X, this.ControlPoint.Y, this.EndPoint.X, this.EndPoint.Y);

			// Return new copy
			return newPoint;
		}
		#endregion
	}
}
