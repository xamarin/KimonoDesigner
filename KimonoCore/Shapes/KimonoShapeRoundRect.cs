using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Draws a rounded rectangle into the Design Surface.
	/// </summary>
	public class KimonoShapeRoundRect : KimonoShape
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the corner radius.
		/// </summary>
		/// <value>The corner radius.</value>
		public float CornerRadius { get; set; } = 32;

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
					KimonoPropertyConnectionPoint.CornerRadius
				};
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeRoundRect"/> class.
		/// </summary>
		public KimonoShapeRoundRect()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeRoundRect"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		public KimonoShapeRoundRect(float left, float top, float right, float bottom) : base(left, top, right, bottom)
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeRoundRect"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		/// <param name="cornerRadius">Corner radius.</param>
		public KimonoShapeRoundRect(float left, float top, float right, float bottom, float cornerRadius) : base(left, top, right, bottom)
		{
			Initialize();
			CornerRadius = cornerRadius;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeRoundRect"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		/// <param name="state">State.</param>
		public KimonoShapeRoundRect(float left, float top, float right, float bottom, KimonoShapeState state) : base(left, top, right, bottom, state)
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeRoundRect"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		/// <param name="cornerRadius">Corner radius.</param>
		/// <param name="state">State.</param>
		public KimonoShapeRoundRect(float left, float top, float right, float bottom, float cornerRadius, KimonoShapeState state) : base(left, top, right, bottom, state)
		{
			Initialize();
			CornerRadius = cornerRadius;
		}

		/// <summary>
		/// Initialize this instance.
		/// </summary>
		private void Initialize()
		{
			// Set the default properties
			Name = "Round Rectangle";
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
				case KimonoPropertyConnectionPoint.CornerRadius:
					CornerRadius = connection.ConnectedProperty.ToFloat();
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

			// Add round rect to path
			path.AddRoundedRect(Rect, CornerRadius, CornerRadius, SKPathDirection.Clockwise);

			// Return path
			return path;
		}

		/// <summary>
		/// Draws the round rectangle into the given Skia Canvas.
		/// </summary>
		/// <param name="canvas">The <c>SKCanvas</c> to draw into.</param>
		public override void Draw(SKCanvas canvas)
		{
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
				// Update any attached properties
				EvaluateConnectedProperties();

				if (Style.HasFill)
				{
					ConformGradientToShape(Style.FillGradient, Style.Fill);
					canvas.DrawRoundRect(Rect, CornerRadius, CornerRadius, Style.Fill);
				}
				if (Style.HasFrame)
				{
					ConformGradientToShape(Style.FrameGradient, Style.Frame);
					canvas.DrawRoundRect(Rect, CornerRadius, CornerRadius, Style.Frame);
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
		/// <returns>The clone <c>KimonoShapeRoundRect</c>.</returns>
		public override KimonoBounds Clone()
		{
			// Duplicate shape
			var newShape = new KimonoShapeRoundRect(this.Left, this.Top, this.Right, this.Bottom, this.State)
			{
				UniqueID = this.UniqueID,
				Name = this.Name,
				Style = CloneAttachedStyle(),
				Visible = this.Visible,
				CornerRadius = this.CornerRadius,
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
