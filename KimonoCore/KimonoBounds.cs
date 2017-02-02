using System;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Defines the outter bounding box for a <c>KimonoShape</c> and contains the routines required
	/// to draw the bounds and the control handles as the user edits and moves the shape.
	/// </summary>
	public class KimonoBounds
	{
		#region Private Variables
		/// <summary>
		/// The base <c>SkRect</c> that holds the internal bounds of the shape.
		/// </summary>
		internal SKRect Rect = new SKRect();

		/// <summary>
		/// Holds the previous center used in scaling operations.
		/// </summary>
		internal SKPoint PreviousCenter = new SKPoint();

		/// <summary>
		/// Holds the previous rect used in scaling operations.
		/// </summary>
		internal SKRect PreviousRect = new SKRect();
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets the current edit state of the <c>KimonoShape</c>.
		/// </summary>
		/// <value>The state as a <c>KimonoShapeState</c>.</value>
		public KimonoShapeState State { get; internal set; } = KimonoShapeState.Unselected;

		/// <summary>
		/// Gets or sets the unique identifier.
		/// </summary>
		/// <value>The unique identifier.</value>
		public string UniqueID { get; set; } = Guid.NewGuid().ToString();

		/// <summary>
		/// Gets or sets the top.
		/// </summary>
		/// <value>The top coord location.</value>
		public float Top
		{
			get { return Rect.Top; }
			set
			{
				SavePreviousBounds();
				Rect.Top = value;
				BoundsChanged();
			}
		}

		/// <summary>
		/// Gets or sets the left.
		/// </summary>
		/// <value>The left coord location.</value>
		public float Left
		{
			get { return Rect.Left; }
			set
			{
				SavePreviousBounds();
				Rect.Left = value;
				BoundsChanged();
			}
		}

		/// <summary>
		/// Gets or sets the bottom.
		/// </summary>
		/// <value>The bottom coord location.</value>
		public float Bottom
		{
			get { return Rect.Bottom; }
			set
			{
				SavePreviousBounds();
				Rect.Bottom = value;
				BoundsChanged();
			}
		}

		/// <summary>
		/// Gets or sets the right.
		/// </summary>
		/// <value>The right coord location.</value>
		public float Right
		{
			get { return Rect.Right; }
			set
			{
				SavePreviousBounds();
				Rect.Right = value;
				BoundsChanged();
			}
		}

		/// <summary>
		/// Gets or sets the width.
		/// </summary>
		/// <value>The width of the shape's bounding box.</value>
		public float Width
		{
			get { return Math.Abs(Right - Left); }
			set
			{
				SavePreviousBounds();
				if (Right > Left)
				{
					Right = Left + value;
				}
				else
				{
					Left = Right + value;
				}
			}
		}

		/// <summary>
		/// Gets or sets the height.
		/// </summary>
		/// <value>The height of the shape's bounding box.</value>
		public float Height
		{
			get { return Math.Abs(Bottom - Top); }
			set
			{
				SavePreviousBounds();
				if (Bottom > Top)
				{
					Bottom = Top + value;
				}
				else
				{
					Top = Bottom + value;
				}
			}
		}

		/// <summary>
		/// Gets the horizontal center.
		/// </summary>
		/// <value>The horizontal center.</value>
		public float HorizontalCenter
		{
			get
			{
				return Left + ((Right - Left) / 2);
			}
		}

		/// <summary>
		/// Gets the vertical center.
		/// </summary>
		/// <value>The vertical center.</value>
		public float VerticalCenter
		{
			get
			{
				return Top + ((Bottom - Top) / 2);
			}
		}

		/// <summary>
		/// Gets the center.
		/// </summary>
		/// <value>The center.</value>
		public SKPoint Center
		{
			get { return new SKPoint(HorizontalCenter, VerticalCenter); }
		}

		/// <summary>
		/// Gets or sets the rotation degrees.
		/// </summary>
		/// <value>The rotation degrees.</value>
		public int RotationDegrees { get; set; } = 0;

		/// <summary>
		/// Gets or sets the top left handle.
		/// </summary>
		/// <value>The top left handle.</value>
		public KimonoHandle TopLeftHandle { get; set; }

		/// <summary>
		/// Gets or sets the top handle.
		/// </summary>
		/// <value>The top handle.</value>
		public KimonoHandle TopHandle { get; set; }

		/// <summary>
		/// Gets or sets the top right handle.
		/// </summary>
		/// <value>The top right handle.</value>
		public KimonoHandle TopRightHandle { get; set; }

		/// <summary>
		/// Gets or sets the right handle.
		/// </summary>
		/// <value>The right handle.</value>
		public KimonoHandle RightHandle { get; set; }

		/// <summary>
		/// Gets or sets the bottom right handle.
		/// </summary>
		/// <value>The bottom right handle.</value>
		public KimonoHandle BottomRightHandle { get; set; }

		/// <summary>
		/// Gets or sets the bottom handle.
		/// </summary>
		/// <value>The bottom handle.</value>
		public KimonoHandle BottomHandle { get; set; }

		/// <summary>
		/// Gets or sets the bottom left handle.
		/// </summary>
		/// <value>The bottom left handle.</value>
		public KimonoHandle BottomLeftHandle { get; set; }

		/// <summary>
		/// Gets or sets the left handle.
		/// </summary>
		/// <value>The left handle.</value>
		public KimonoHandle LeftHandle { get; set; }

		/// <summary>
		/// Gets or sets the hit offset.
		/// </summary>
		/// <value>The hit offset.</value>
		public SKPoint HitOffset { get; set; } = new SKPoint();

		/// <summary>
		/// Gets or sets the hit handle.
		/// </summary>
		/// <value>The hit handle.</value>
		public KimonoHandle HitHandle { get; set; } = null;
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoBounds"/> class.
		/// </summary>
		public KimonoBounds()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoBounds"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		public KimonoBounds(float left, float top, float right, float bottom)
		{
			// Initialize
			Rect = new SKRect(left, top, right, bottom);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoBounds"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		/// <param name="state">State.</param>
		public KimonoBounds(float left, float top, float right, float bottom, KimonoShapeState state)
		{
			// Initialize
			Rect = new SKRect(left, top, right, bottom);

			// Is the bounds selected?
			if (state == KimonoShapeState.Selected)
			{
				Select();
			}

			// Save state
			State = state;
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Saves the previous bounds.
		/// </summary>
		internal void SavePreviousBounds()
		{
			// Save previous bounds
			PreviousCenter = Center;
			PreviousRect = new SKRect(Rect.Left, Rect.Top, Rect.Right, Rect.Bottom);
		}

		/// <summary>
		/// Checks to see if the given value is between the two given points.
		/// </summary>
		/// <returns>The <see cref="T:System.Boolean"/>.</returns>
		/// <param name="x">The x coordinate.</param>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		internal bool ValueBetween(float x, float a, float b)
		{
			if (a > b)
			{
				return (x >= b && x <= a);
			}
			else
			{
				return (x >= a && x <= b);
			}
		}

		/// <summary>
		/// Adds the control handles to the bounds
		/// </summary>
		internal void AddHandles(KimonoShapeState state)
		{
			// Create the four corner drag handles
			TopLeftHandle = new KimonoHandle(Left - KimonoHandle.DrawOffset, Top - KimonoHandle.DrawOffset, state);
			TopRightHandle = new KimonoHandle(Right - KimonoHandle.DrawOffset, Top - KimonoHandle.DrawOffset, state);
			BottomRightHandle = new KimonoHandle(Right - KimonoHandle.DrawOffset, Bottom - KimonoHandle.DrawOffset, state);
			BottomLeftHandle = new KimonoHandle(Left - KimonoHandle.DrawOffset, Bottom - KimonoHandle.DrawOffset, state);

			// Wire-up events
			TopLeftHandle.Moved += (point) =>
			{
				SavePreviousBounds();
				Rect.Left = point.X;
				Rect.Top = point.Y;
				BoundsChanged();
			};
			TopRightHandle.Moved += (point) =>
			{
				SavePreviousBounds();
				Rect.Right = point.X;
				Rect.Top = point.Y;
				BoundsChanged();
			};
			BottomRightHandle.Moved += (point) =>
			{
				SavePreviousBounds();
				Rect.Right = point.X;
				Rect.Bottom = point.Y;
				BoundsChanged();
			};
			BottomLeftHandle.Moved += (point) =>
			{
				SavePreviousBounds();
				Rect.Left = point.X;
				Rect.Bottom = point.Y;
				BoundsChanged();
			};

			// Create the top and bottom drag handles if the bounds
			// is wide enough
			if (Width >= 50)
			{
				// Add handles
				TopHandle = new KimonoHandle(HorizontalCenter - KimonoHandle.DrawOffset, Top - KimonoHandle.DrawOffset, KimonoHandleConstraint.Vertical, state);
				BottomHandle = new KimonoHandle(HorizontalCenter - KimonoHandle.DrawOffset, Bottom - KimonoHandle.DrawOffset, KimonoHandleConstraint.Vertical, state);

				// Wire-up events
				TopHandle.Moved += (point) =>
				{
					Top = point.Y;
				};
				BottomHandle.Moved += (point) =>
				{
					Bottom = point.Y;
				};
			}

			// Create the left and right drag handles if the bounds
			// is tall enough
			if (Height >= 50)
			{
				// Add handle
				LeftHandle = new KimonoHandle(Left - KimonoHandle.DrawOffset, VerticalCenter - KimonoHandle.DrawOffset, KimonoHandleConstraint.Horizontal, state);
				RightHandle = new KimonoHandle(Right - KimonoHandle.DrawOffset, VerticalCenter - KimonoHandle.DrawOffset, KimonoHandleConstraint.Horizontal, state);

				// Wire-up events
				LeftHandle.Moved += (point) =>
				{
					Left = point.X;
				};
				RightHandle.Moved += (point) =>
				{
					Right = point.X;
				};
			}
		}

		/// <summary>
		/// Removes the control handles from the bounds.
		/// </summary>
		internal void RemoveHandles()
		{
			// Remove all handles
			HitHandle = null;
			TopLeftHandle = null;
			TopHandle = null;
			TopRightHandle = null;
			RightHandle = null;
			BottomRightHandle = null;
			BottomHandle = null;
			BottomLeftHandle = null;
			LeftHandle = null;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Updates the location of the edit handles when the bounds has been relocated or
		/// resized.
		/// </summary>
		public virtual void BoundsChanged()
		{
			// Anything to process?
			if (TopLeftHandle == null) return;

			// Adjust the four courner drag handles
			TopLeftHandle.MoveTo(Left - KimonoHandle.DrawOffset, Top - KimonoHandle.DrawOffset);
			TopRightHandle.MoveTo(Right - KimonoHandle.DrawOffset, Top - KimonoHandle.DrawOffset);
			BottomRightHandle.MoveTo(Right - KimonoHandle.DrawOffset, Bottom - KimonoHandle.DrawOffset);
			BottomLeftHandle.MoveTo(Left - KimonoHandle.DrawOffset, Bottom - KimonoHandle.DrawOffset);

			// Set handle state
			var newHandleState = (State == KimonoShapeState.Selected) ? KimonoShapeState.Unselected : State;

			// Adjust top and bottom drag handles based on width
			if (Width < 50)
			{
				// Too small so remove handles
				TopHandle = null;
				BottomHandle = null;
			}
			else
			{
				// Move or create handles as needed
				if (TopHandle == null)
				{
					TopHandle = new KimonoHandle(HorizontalCenter - KimonoHandle.DrawOffset, Top - KimonoHandle.DrawOffset, KimonoHandleConstraint.Vertical, newHandleState);
					TopHandle.Moved += (point) =>
					{
						Top = point.Y;
					};
				}
				else
				{
					TopHandle.MoveTo(HorizontalCenter - KimonoHandle.DrawOffset, Top - KimonoHandle.DrawOffset);
				}

				if (BottomHandle == null)
				{
					BottomHandle = new KimonoHandle(HorizontalCenter - KimonoHandle.DrawOffset, Bottom - KimonoHandle.DrawOffset, KimonoHandleConstraint.Vertical, newHandleState);
					BottomHandle.Moved += (point) =>
					{
						Bottom = point.Y;
					};
				}
				else
				{
					BottomHandle.MoveTo(HorizontalCenter - KimonoHandle.DrawOffset, Bottom - KimonoHandle.DrawOffset);
				}
			}

			// Adjust left and right drag handles based on the height
			if (Height < 50)
			{
				// Too small so remove handles
				LeftHandle = null;
				RightHandle = null;
			}
			else
			{
				// Move or create handles as needed
				if (LeftHandle == null)
				{
					LeftHandle = new KimonoHandle(Left - KimonoHandle.DrawOffset, VerticalCenter - KimonoHandle.DrawOffset, KimonoHandleConstraint.Horizontal, newHandleState);
					LeftHandle.Moved += (point) =>
					{
						Left = point.X;
					};
				}
				else
				{
					LeftHandle.MoveTo(Left - KimonoHandle.DrawOffset, VerticalCenter - KimonoHandle.DrawOffset);
				}

				if (RightHandle == null)
				{
					RightHandle = new KimonoHandle(Right - KimonoHandle.DrawOffset, VerticalCenter - KimonoHandle.DrawOffset, KimonoHandleConstraint.Horizontal, newHandleState);
					RightHandle.Moved += (point) =>
					{
						Right = point.X;
					};
				}
				else
				{
					RightHandle.MoveTo(Right - KimonoHandle.DrawOffset, VerticalCenter - KimonoHandle.DrawOffset);
				}
			}
		}

		/// <summary>
		/// Draws the bounding box and its edit handles into the given canvas
		/// </summary>
		/// <param name="canvas">Canvas.</param>
		public virtual void Draw(SKCanvas canvas)
		{
			// Anything to process?
			if (State != KimonoShapeState.Selected &&
				State != KimonoShapeState.Constructing &&
				State != KimonoShapeState.Grouping) return;

			// Define the paint style
			var paint = new SKPaint()
			{
				Style = SKPaintStyle.Stroke,
				StrokeWidth = 1
			};

			// Set stroke based on the state
			switch (State)
			{
				case KimonoShapeState.Grouping:
					paint.Color = KimonoColor.Ice;
					break;
				case KimonoShapeState.Selected:
					paint.Color = KimonoColor.Tungsten;
					break;
				case KimonoShapeState.Constructing:
					paint.Color = KimonoColor.Aqua;
					break;
			}

			// Draw bounding frame
			canvas.DrawRect(Rect, paint);

			// Draw the four corner handles
			TopLeftHandle?.Draw(canvas);
			TopRightHandle?.Draw(canvas);
			BottomRightHandle?.Draw(canvas);
			BottomLeftHandle?.Draw(canvas);

			// Draw optional handles
			TopHandle?.Draw(canvas);
			RightHandle?.Draw(canvas);
			BottomHandle?.Draw(canvas);
			LeftHandle?.Draw(canvas);
		}

		/// <summary>
		/// Puts the <c>KimonoShape</c> into the edit mode and creates the edit
		/// handles as required.
		/// </summary>
		public void Select()
		{
			// Already selected?
			if (State == KimonoShapeState.Selected) return;

			// Add handles
			AddHandles(KimonoShapeState.Unselected);

			// Mark selected
			State = KimonoShapeState.Selected;

		}

		/// <summary>
		/// Places the bounds under construction.
		/// </summary>
		/// <param name="needsHandles">If set to <c>true</c> needs handles.</param>
		public void PlaceUnderConstruction(bool needsHandles)
		{
			// Requires constrol handles?
			if (needsHandles)
			{
				AddHandles(KimonoShapeState.Constructing);
			}
			else
			{
				RemoveHandles();
			}

			// Mark selected
			State = KimonoShapeState.Constructing;

		}

		/// <summary>
		/// Starts the bounds grouping.
		/// </summary>
		public void StartGrouping()
		{
			// Nuke any handles
			RemoveHandles();

			// Mark selected
			State = KimonoShapeState.Grouping;

		}

		/// <summary>
		/// Unselects the <c>KimonoShape</c> as the current edit target and removes
		/// any edit handles.
		/// </summary>
		public void Unselect()
		{
			// Remove all handles
			RemoveHandles();

			// Mark unselected
			State = KimonoShapeState.Unselected;
		}

		/// <summary>
		/// Changes the bounds to match the given values.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		public virtual void ChangeBounds(float left, float top, float right, float bottom)
		{
			// Update the bounds
			SavePreviousBounds();
			Rect.Left = left;
			Rect.Top = top;
			Rect.Right = right;
			Rect.Bottom = bottom;
			BoundsChanged();
		}

		/// <summary>
		/// Adjusts the size of the bounds.
		/// </summary>
		/// <param name="point">The new size as a <c>SKPoint</c>.</param>
		public virtual void GrowBounds(SKPoint point)
		{
			// Update the size of the bounds
			SavePreviousBounds();
			Rect.Right = point.X;
			Rect.Bottom = point.Y;
			BoundsChanged();
		}

		/// <summary>
		/// Moves the bounds to the given point.
		/// </summary>
		/// <param name="point">The new top, left location as a <c>SKPoint</c>.</param>
		public virtual void MoveBounds(SKPoint point)
		{
			// Calculate offsets
			var width = Rect.Right - Rect.Left;
			var heigh = Rect.Bottom - Rect.Top;

			// Update bounds
			SavePreviousBounds();
			Rect.Left = point.X;
			Rect.Top = point.Y;
			Rect.Right = point.X + width;
			Rect.Bottom = point.Y + heigh;
			BoundsChanged();
		}

		/// <summary>
		/// Drags the bounds.
		/// </summary>
		/// <param name="point">Point.</param>
		public virtual void DragBounds(SKPoint point)
		{
			// Dragging a handle?
			if (HitHandle == null)
			{
				// No, get current width and height
				SavePreviousBounds();
				var width = Width;
				var height = Height;

				// Move bounds accounting for offset
				if (Rect.Left > Rect.Right)
				{
					Rect.Right = point.X - HitOffset.X;
					Rect.Left = Rect.Right + width;
				}
				else
				{
					Rect.Left = point.X - HitOffset.X;
					Rect.Right = Rect.Left + width;
				}
				if (Rect.Top > Rect.Bottom)
				{
					Rect.Bottom = point.Y - HitOffset.Y;
					Rect.Top = Rect.Bottom + height;
				}
				else
				{
					Rect.Top = point.Y - HitOffset.Y;
					Rect.Bottom = Rect.Top + height;
				}
				BoundsChanged();
			}
			else
			{
				// Yes, drag the handle instead
				HitHandle.DragHandle(point);
			}
		}

		/// <summary>
		/// Test to see if the given point is inside of the current bounds
		/// </summary>
		/// <returns><c>true</c>, if in bounds, <c>false</c> otherwise.</returns>
		/// <param name="point">Point.</param>
		public virtual bool PointInBound(SKPoint point)
		{
			// Clear hit handle and test point
			HitHandle = null;
			var inBounds = (ValueBetween(point.X, Left, Right) && ValueBetween(point.Y, Top, Bottom));

			// Test all handles to see if they have been hit
			if (TopLeftHandle != null && TopLeftHandle.PointInBound(point))
			{
				HitHandle = TopLeftHandle;
				inBounds = true;
			}
			else if (TopHandle != null && TopHandle.PointInBound(point))
			{
				HitHandle = TopHandle;
				inBounds = true;
			}
			else if (TopRightHandle != null && TopRightHandle.PointInBound(point))
			{
				HitHandle = TopRightHandle;
				inBounds = true;
			}
			else if (RightHandle != null && RightHandle.PointInBound(point))
			{
				HitHandle = RightHandle;
				inBounds = true;
			}
			else if (BottomRightHandle != null && BottomRightHandle.PointInBound(point))
			{
				HitHandle = BottomRightHandle;
				inBounds = true;
			}
			else if (BottomHandle != null && BottomHandle.PointInBound(point))
			{
				HitHandle = BottomHandle;
				inBounds = true;
			}
			else if (BottomLeftHandle != null && BottomLeftHandle.PointInBound(point))
			{
				HitHandle = BottomLeftHandle;
				inBounds = true;
			}
			else if (LeftHandle != null && LeftHandle.PointInBound(point))
			{
				HitHandle = LeftHandle;
				inBounds = true;
			}
			else if (inBounds)
			{
				// See if we are in bounds
				HitOffset = new SKPoint((Left > Right) ? point.X - Right : point.X - Left, (Top > Bottom) ? point.Y - Bottom : point.Y - Top);
			}

			return inBounds;
		}
		#endregion

		#region Cloning
		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>The clone.</returns>
		public virtual KimonoBounds Clone()
		{
			// Make duplicate
			var newBounds = new KimonoBounds(this.Left, this.Top, this.Right, this.Bottom, this.State)
			{
				UniqueID = this.UniqueID,
				RotationDegrees = this.RotationDegrees
			};

			// Return duplicate
			return newBounds;
		}
		#endregion
	}
}
