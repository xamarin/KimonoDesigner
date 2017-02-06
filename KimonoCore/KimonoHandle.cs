using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Defines an edit handle that the user manipulates to edit the bounds of a
	/// <c>KimonoShape</c> or the control points of a Bezier object.
	/// </summary>
	public class KimonoHandle
	{
		#region Static Properties
		/// <summary>
		/// The width of the drag handle.
		/// </summary>
		public static float DrawWidth = 8;

		/// <summary>
		/// The draw offset of the drag handle.
		/// </summary>
		public static float DrawOffset = 4;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the index.
		/// </summary>
		/// <value>The index.</value>
		public int Index { get; set; } = 0;

		/// <summary>
		/// Gets or sets the type of the handle.
		/// </summary>
		/// <value>The type of the handle as a <c>KimonoHandleType</c>.</value>
		public KimonoHandleType HandleType { get; set; } = KimonoHandleType.ControlPoint;

		/// <summary>
		/// Gets or sets the unique identifier.
		/// </summary>
		/// <value>The unique identifier.</value>
		public string UniqueID { get; set; } = Guid.NewGuid().ToString();

		/// <summary>
		/// Gets the edit state of the <c>KimonoHandle</c>.
		/// </summary>
		/// <value>The state as a <c>KimonoShapeState</c>.</value>
		public KimonoShapeState State { get; set; } = KimonoShapeState.Unselected;

		/// <summary>
		/// Gets or sets the x value.
		/// </summary>
		/// <value>The x coord of the handle's top-left location.</value>
		public float X { get; set; }

		/// <summary>
		/// Gets or sets the y value.
		/// </summary>
		/// <value>The y coord of the handle's top-left location.</value>
		public float Y { get; set; }

		/// <summary>
		/// Gets the rect.
		/// </summary>
		/// <value>The rect.</value>
		public SKRect Rect
		{
			get
			{
				return new SKRect(X, Y, X + DrawWidth, Y + DrawWidth);
			}
		}

		/// <summary>
		/// Gets or sets the edit constraint.
		/// </summary>
		/// <value>The edit constraint as a <c>KimonoHandleConstraint</c>.</value>
		public KimonoHandleConstraint Constraint { get; set; } = KimonoHandleConstraint.None;

		/// <summary>
		/// Gets or sets the hit offset.
		/// </summary>
		/// <value>The hit offset.</value>
		public SKPoint HitOffset { get; set; } = new SKPoint();

		/// <summary>
		/// Gets or sets the color that this handle represents in a gradient. If the
		/// <c>LinkedColor</c> property is <c>null</c>, this color will be used.
		/// </summary>
		/// <value>The <c>SKColor</c>.</value>
		public SKColor Color { get; set; } = KimonoColor.Black;

		/// <summary>
		/// Gets or sets the color that this handle represents in a gradient. If the
		/// <c>LinkedColor</c> property is <c>null</c>, the <c>Color</c> property will 
		/// be used instead.
		/// </summary>
		/// <value>The color of the linked.</value>
		public KimonoColor LinkedColor { get; set; } = null;

		/// <summary>
		/// Gets the color that this handle represents.
		/// </summary>
		/// <value>The color as a <c>SKColor</c>.</value>
		public SKColor RepresentedColor
		{
			get
			{
				// Using a linked color?
				if (LinkedColor == null)
				{
					return Color;
				}
				else
				{
					return LinkedColor.Color;
				}
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoHandle"/> class.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		public KimonoHandle(float x, float y)
		{
			// Initialize
			X = x;
			Y = y;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoHandle"/> class.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="state">State.</param>
		public KimonoHandle(float x, float y, KimonoShapeState state)
		{
			// Initialize
			X = x;
			Y = y;
			State = state;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoHandle"/> class.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="constraint">Constraint.</param>
		public KimonoHandle(float x, float y, KimonoHandleConstraint constraint)
		{
			// Initialize
			X = x;
			Y = y;
			Constraint = constraint;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoHandle"/> class.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="constraint">Constraint.</param>
		/// <param name="state">State.</param>
		public KimonoHandle(float x, float y, KimonoHandleConstraint constraint, KimonoShapeState state)
		{
			// Initialize
			X = x;
			Y = y;
			Constraint = constraint;
			State = state;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Draws the hanled into the given Skia canvas.
		/// </summary>
		/// <returns>The draw.</returns>
		/// <param name="canvas">The <c>SKCanvas</c> to draw the hanled into.</param>
		public void Draw(SKCanvas canvas)
		{
			// Define bounds
			var rect = new SKRect(X, Y, X + DrawWidth, Y + DrawWidth);

			// Define paint style
			var paint = new SKPaint()
			{
				Style = SKPaintStyle.Fill
			};

			// Set fill based on the state
			switch (State)
			{
				case KimonoShapeState.Unselected:
					paint.Color = KimonoColor.White;
					break;
				case KimonoShapeState.Selected:
					paint.Color = KimonoColor.Silver;
					break;
				case KimonoShapeState.Constructing:
					paint.Color = KimonoColor.Ice;
					break;
			}

			// Draw inside of handle
			if (HandleType == KimonoHandleType.BezierControlPoint)
			{
				canvas.DrawOval(rect, paint);
			}
			else
			{
				canvas.DrawRect(rect, paint);
			}

			// Draw handle frame
			paint.Style = SKPaintStyle.Stroke;
			paint.StrokeWidth = 1;

			// Set fill based on the state
			switch (State)
			{
				case KimonoShapeState.Unselected:
					paint.Color = KimonoColor.Tungsten;
					break;
				case KimonoShapeState.Selected:
					paint.Color = KimonoColor.Tungsten;
					break;
				case KimonoShapeState.Constructing:
					paint.Color = KimonoColor.Aqua;
					break;
			}

			// Draw frame of handle
			if (HandleType == KimonoHandleType.BezierControlPoint)
			{
				canvas.DrawOval(rect, paint);
			}
			else
			{
				canvas.DrawRect(rect, paint);
			}
		}

		/// <summary>
		/// Moves the handle to the given coordinates.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		public void MoveTo(float x, float y)
		{
			// Save new location
			X = x;
			Y = y;
		}

		/// <summary>
		/// Test to see if the given point is inside of the current bounds
		/// </summary>
		/// <returns><c>true</c>, if in bounds, <c>false</c> otherwise.</returns>
		/// <param name="point">Point.</param>
		public bool PointInBound(SKPoint point)
		{
			var rect = Rect;
			var inBounds = (point.X >= rect.Left && point.X <= rect.Right && point.Y >= rect.Top && point.Y <= rect.Bottom);

			// In bounds?
			if (inBounds)
			{
				// Yes, save hit offset
				HitOffset = new SKPoint(point.X - rect.Left, point.Y - rect.Top);
			}

			return inBounds;
		}

		/// <summary>
		/// Drags the handle.
		/// </summary>
		/// <param name="point">Point.</param>
		public void DragHandle(SKPoint point)
		{
			// Move bounds accounting for offset and constraints
			switch (Constraint)
			{
				case KimonoHandleConstraint.None:
					X = point.X - HitOffset.X;
					Y = point.Y - HitOffset.Y;
					break;
				case KimonoHandleConstraint.Horizontal:
					X = point.X - HitOffset.X;
					break;
				case KimonoHandleConstraint.Vertical:
					Y = point.Y - HitOffset.Y;
					break;
			}

			// Inform caller of change
			RaiseMoved(new SKPoint(X + DrawOffset, Y + DrawOffset));
		}
		#endregion

		#region Cloning
		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>The clone.</returns>
		public KimonoHandle Clone()
		{
			// Duplicate handle
			var newHandle = new KimonoHandle(this.X, this.Y)
			{
				Index = this.Index,
				HandleType = this.HandleType,
				UniqueID = this.UniqueID,
				State = this.State,
				Constraint = this.Constraint,
				Color = this.Color,
				LinkedColor = this.LinkedColor
			};

			// Return new handle
			return newHandle;
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when moved.
		/// </summary>
		public event Kimono.SkiaPointEventDelegate Moved;

		/// <summary>
		/// Raises the moved event.
		/// </summary>
		/// <param name="point">Point.</param>
		internal void RaiseMoved(SKPoint point)
		{
			if (Moved != null) Moved(point);
		}
		#endregion
	}
}
