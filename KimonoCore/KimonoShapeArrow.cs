using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Draws either an outlined or single line arrow with heads on one or both ends.
	/// </summary>
	public class KimonoShapeArrow : KimonoShape
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
		/// Draws the arrow into the specified Skia canvas.
		/// </summary>
		/// <param name="canvas">The <c>SKCanvas</c> to draw into.</param>
		public override void Draw(SKCanvas canvas)
		{
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

			// Return new shape
			return newShape;
		}
		#endregion
	}
}
