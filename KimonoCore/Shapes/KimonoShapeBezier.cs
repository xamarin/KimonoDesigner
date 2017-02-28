using System;
using System.Collections.Generic;
using SkiaSharp;
using TextBase;

namespace KimonoCore
{
	/// <summary>
	/// A Kimono Bezier is a collection of control and end points that define the quad sections of a
	/// bezier shape to be drawn using SkiaSharp.
	/// </summary>
	[Table("Bezier")]
	public class KimonoShapeBezier : KimonoShape, IKimonoCodeGeneration, IKimonoPropertyConsumer
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the points that define the shape.
		/// </summary>
		/// <value>The points.</value>
		[Children]
		public List<KimonoBezierPoint> Points { get; set; } = new List<KimonoBezierPoint>();

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoShapeVector"/> is closed.
		/// </summary>
		/// <value><c>true</c> if closed; otherwise, <c>false</c>.</value>
		public bool Closed { get; set; } = true;

		/// <summary>
		/// Gets a value indicating whether this <see cref="T:KimonoCore.KimonoShapeVector"/> is editable.
		/// </summary>
		/// <value><c>true</c> if is editable; otherwise, <c>false</c>.</value>
		[Ignore]
		public override bool IsEditable
		{
			get { return true; }
		}

		/// <summary>
		/// Gets the last point in the collection of control points.
		/// </summary>
		/// <value>The last point.</value>
		[Ignore]
		public KimonoBezierPoint LastPoint
		{
			get
			{
				// Anything to return?
				if (Points.Count == 0)
				{
					// No, return null
					return null;
				}
				else
				{
					// Yes, get the last point added
					return Points[Points.Count - 1];
				}
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeBezier"/> class.
		/// </summary>
		public KimonoShapeBezier()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeBezier"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		public KimonoShapeBezier(float left, float top, float right, float bottom) : base(left, top, right, bottom)
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeBezier"/> class.
		/// </summary>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		/// <param name="state">State.</param>
		public KimonoShapeBezier(float left, float top, float right, float bottom, KimonoShapeState state) : base(left, top, right, bottom, state)
		{
			Initialize();
		}

		/// <summary>
		/// Initialize this instance.
		/// </summary>
		private void Initialize()
		{
			// Set the default properties
			Name = "Bezier";
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Recalculates the vector bounds to encompas all of the data points that define the shape.
		/// </summary>
		public void RecalculateVectorBounds()
		{
			// Anything to process?
			if (Points.Count < 1) return;

			// Reset the bounding rect
			Left = Points[0].EndPoint.X;
			Right = Points[0].EndPoint.X;
			Top = Points[0].EndPoint.Y;
			Bottom = Points[0].EndPoint.Y;

			// Process all points to find the bounds
			foreach (KimonoBezierPoint point in Points)
			{
				// Adjust bounds for this point
				if (point.EndPoint.X < Left) Left = point.EndPoint.X;
				if (point.EndPoint.X > Right) Right = point.EndPoint.X;
				if (point.EndPoint.Y < Top) Top = point.EndPoint.Y;
				if (point.EndPoint.Y > Bottom) Bottom = point.EndPoint.Y;

				if (point.ControlPoint.X < Left) Left = point.ControlPoint.X;
				if (point.ControlPoint.X > Right) Right = point.ControlPoint.X;
				if (point.ControlPoint.Y < Top) Top = point.ControlPoint.Y;
				if (point.ControlPoint.Y > Bottom) Bottom = point.ControlPoint.Y;
			}
		}

		/// <summary>
		/// Adds a point to the shape.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		public void AddPoint(float x, float y)
		{
			// Add point and recalculate bounds
			Points.Add(new KimonoBezierPoint(x,y,x,y));
			RecalculateVectorBounds();
		}

		/// <summary>
		/// Adds the point to the shape.
		/// </summary>
		/// <param name="controlX">Control x.</param>
		/// <param name="controlY">Control y.</param>
		/// <param name="endX">End x.</param>
		/// <param name="endY">End y.</param>
		public void AddPoint(float controlX, float controlY, float endX, float endY)
		{
			// Add point and recalculate bounds
			Points.Add(new KimonoBezierPoint(controlX, controlY, endX, endY));
			RecalculateVectorBounds();
		}

		/// <summary>
		/// Adds the given point to the shape.
		/// </summary>
		/// <param name="point">The new <c>SKPoint</c> to add.</param>
		public void AddPoint(SKPoint point)
		{
			// is this the first point added?
			if (Points.Count > 0)
			{
				// No, grab first point
				var firstPoint = Points[0];

				// Is the new point within five pixels of the first point?
				if (point.X > (firstPoint.EndPoint.X - 5) && point.X < (firstPoint.EndPoint.X + 5) &&
					point.Y > (firstPoint.EndPoint.Y - 5) && point.Y < (firstPoint.EndPoint.Y + 5))
				{
					// Yes, close the shape and complete editing
					point.X = firstPoint.EndPoint.X;
					point.Y = firstPoint.EndPoint.Y;
					State = KimonoShapeState.Finalizing;
				}
			}

			// Get defaul control point locations
			var x = point.X;
			var y = point.Y;

			// Was there a last point added?
			if (LastPoint != null)
			{
				// Yes, calculate default quad position
				x = LastPoint.EndPoint.X + ((point.X - LastPoint.EndPoint.X) / 2f);
				y = LastPoint.EndPoint.Y + ((point.Y - LastPoint.EndPoint.Y) / 2f);
			}

			// Add point and recalculate bounds
			var bezierPoint = new KimonoBezierPoint(x, y, point.X, point.Y);
			Points.Add(bezierPoint);
			RecalculateVectorBounds();

			// Are we in the editing mode?
			if (State == KimonoShapeState.Editing || State == KimonoShapeState.Finalizing)
			{
				// Add a new drag handle for the new point
				AddHandlesForPoint(Points.Count - 1, bezierPoint);
			}
		}

		/// <summary>
		/// Duplicates the selected point.
		/// </summary>
		public void DuplicateSelectedPoint()
		{
			// Anything to process?
			if (HitHandle == null) return;

			// Yes, clone the point under the handle
			var point = Points[HitHandle.Index].Clone();
			Points.Insert(HitHandle.Index, point);
			RecalculateVectorBounds();

			// Add a new handle too
			StartEditing();
		}

		/// <summary>
		/// Adds the handles for the given bezier point.
		/// </summary>
		/// <param name="index">The index of the <c>KimonoBezierPoint</c> that handles are
		/// being created for.</param>
		/// <param name="bezierPoint">The <c>KimonoBezierPoint</c> that is getting handles.</param>
		public void AddHandlesForPoint(int index, KimonoBezierPoint bezierPoint)
		{
			
			 // Add new control point handle
			var controlPoint = new KimonoHandle(bezierPoint.ControlPoint.X - KimonoHandle.DrawOffset,
											bezierPoint.ControlPoint.Y - KimonoHandle.DrawOffset)
			{
				Index = index,
				HandleType = KimonoHandleType.BezierControlPoint
			};
			controlPoint.Moved += (pt) =>
				{
					// Move attached point
					Points[controlPoint.Index].ControlPoint = pt;
				};
			ControlPoints.Add(controlPoint);

			// Add new end point handle
			var endPoint = new KimonoHandle(bezierPoint.EndPoint.X - KimonoHandle.DrawOffset,
											bezierPoint.EndPoint.Y - KimonoHandle.DrawOffset)
			{
				Index = index
			};
			endPoint.Moved += (pt) =>
				{
					// Move attached point
					Points[endPoint.Index].EndPoint = pt;
				};
			ControlPoints.Add(endPoint);
		}

		/// <summary>
		/// Moves the last point added to the new position.
		/// </summary>
		/// <param name="point">The <c>SKPoint</c> for the new position.</param>
		public void MoveLastPoint(SKPoint point)
		{
			// Anything to process?
			if (Points.Count < 1) return;

			// Move last point to match new location
			LastPoint.EndPoint = point;
			RecalculateVectorBounds();
		}

		/// <summary>
		/// Removes the given point.
		/// </summary>
		/// <param name="n">The index of the point ot remove.</param>
		public void RemovePoint(int n)
		{
			// Remove point and recalculate bounds
			Points.RemoveAt(n);
			RecalculateVectorBounds();
		}

		/// <summary>
		/// Removes the selected point.
		/// </summary>
		public void RemoveSelectedPoint()
		{
			// Anything to process?
			if (HitHandle == null) return;

			// Remove point
			Points.RemoveAt(HitHandle.Index);
			HitHandle = null;
			RecalculateVectorBounds();

			// Update UI
			StartEditing();
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Applies the move and scale amount to the data point that make up the shape.
		/// </summary>
		private void ApplyMoveAndScale()
		{
			// Calculate origin offest
			var originOffest = new SKSize(PreviousRect.Left - Rect.Left, PreviousRect.Top - Rect.Top);

			// Get new center
			var center = Center;

			// Calculate offsets
			var offest = new SKSize(Rect.Left - PreviousRect.Left, Rect.Top - PreviousRect.Top);

			// Apply offest to all points
			for (int n = 0; n < Points.Count; ++n)
			{
				Points[n].ControlPoint = SKPoint.Add(Points[n].ControlPoint, offest);
				Points[n].EndPoint = SKPoint.Add(Points[n].EndPoint, offest);
			}

			// Calculate Size change
			var offsetX = 0f;
			var shrinkX = true;
			var offsetY = 0f;
			var shrinkY = true;

			if (Rect.Width < PreviousRect.Width)
			{
				offsetX = Rect.Width / PreviousRect.Width;
				shrinkX = true;
			}
			else
			{
				offsetX = PreviousRect.Width / Rect.Width;
				shrinkX = false;
			}

			if (Rect.Height < PreviousRect.Height)
			{
				offsetY = Rect.Height / PreviousRect.Height;
				shrinkY = true;
			}
			else
			{
				offsetY = PreviousRect.Height / Rect.Height;
				shrinkY = false;
			}

			if (!((int)offsetX == 1 && (int)offsetY == 1))
			{
				// Apply offest to all points
				for (int n = 0; n < Points.Count; ++n)
				{
					// Get adjusted x,y
					var cx = Points[n].ControlPoint.X - PreviousCenter.X + originOffest.Width;
					var cy = Points[n].ControlPoint.Y - PreviousCenter.Y + originOffest.Height;
					var ex = Points[n].EndPoint.X - PreviousCenter.X + originOffest.Width;
					var ey = Points[n].EndPoint.Y - PreviousCenter.Y + originOffest.Height;

					// Calculate resized positions
					if (shrinkX)
					{
						cx = (cx * offsetX) + center.X;
						ex = (ex * offsetX) + center.X;
					}
					else
					{
						cx = (cx / offsetX) + center.X;
						ex = (ex / offsetX) + center.X;
					}
					if (shrinkY)
					{
						cy = (cy * offsetY) + center.Y;
						ey = (ey * offsetY) + center.Y;
					}
					else
					{
						cy = (cy / offsetY) + center.Y;
						ey = (ey / offsetY) + center.Y;
					}

					// Apply new points
					Points[n].ControlPoint = new SKPoint(cx, cy);
					Points[n].EndPoint = new SKPoint(ex, ey);
				}
			}
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
			path.MoveTo(Points[0].EndPoint);
			for (int n = 1; n < Points.Count; n++)
			{
				path.QuadTo(Points[n].ControlPoint, Points[n].EndPoint);
			}
			if (Closed) path.QuadTo(Points[0].ControlPoint, Points[0].EndPoint);

			// Return path
			return path;
		}

		/// <summary>
		/// Draws the shape into the given Skia Canvas.
		/// </summary>
		/// <param name="canvas">The <c>SKCanvas</c> to draw into.</param>
		public override void Draw(SKCanvas canvas)
		{
			// Yes, define path
			var path = ToPath();

			// Rotated?
			if (RotationDegrees > 0)
			{
				// Save current state and apply rotation
				canvas.Save();
				canvas.RotateDegrees(RotationDegrees, HorizontalCenter, VerticalCenter);
			}

			// Anything to draw?
			if (Points.Count > 1)
			{
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
			}

			// Are we in the editing mode?
			if (State == KimonoShapeState.Editing)
			{
				// Mix new paint
				// Define paint style
				var paint = new SKPaint()
				{
					Style = SKPaintStyle.Fill,
					Color = KimonoColor.Black
				};

				// Draw control line between the control and end points
				foreach (KimonoBezierPoint point in Points)
				{
					canvas.DrawLine(point.ControlPoint.X, point.ControlPoint.Y, point.EndPoint.X, point.EndPoint.Y, paint);
				}

				// Draw control point handles
				foreach (KimonoHandle handle in ControlPoints)
				{
					handle.Draw(canvas);
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
		/// Tests to see if the given point is inside the bounds of the shape.
		/// </summary>
		/// <returns><c>true</c>, if in bound was pointed, <c>false</c> otherwise.</returns>
		/// <param name="point">The <c>SKPoint</c> to test.</param>
		public override bool PointInBound(SKPoint point)
		{
			// In the editing mode?
			if (State == KimonoShapeState.Editing)
			{
				// Yes, see if any handle has been hit
				if (HitHandle != null) HitHandle.State = KimonoShapeState.Unselected;
				HitHandle = null;
				foreach (KimonoHandle handle in ControlPoints)
				{
					if (handle.PointInBound(point))
					{
						HitHandle = handle;
						HitHandle.State = KimonoShapeState.Selected;
						return true;
					}
				}
			}

			// Default to parent
			return base.PointInBound(point);
		}

		/// <summary>
		/// Drags the bounds of the shape to a new location.
		/// </summary>
		/// <param name="point">The <c>SKPoint</c> to drag the bounds to.</param>
		public override void DragBounds(SKPoint point)
		{
			// In the editing mode?
			if (State == KimonoShapeState.Editing || State == KimonoShapeState.Finalizing)
			{
				// Is a handle available?
				if (HitHandle != null)
				{
					HitHandle.DragHandle(point);
					RecalculateVectorBounds();
				}
				return;
			}

			// Allow parent to move and size bounds
			base.DragBounds(point);
		}

		/// <summary>
		/// Handles the bounds of the shape being changed.
		/// </summary>
		public override void BoundsChanged()
		{
			// Editing shape?
			if (State == KimonoShapeState.Editing || State == KimonoShapeState.Finalizing)
			{
				// Yes, allow parent to adjust bounds
				base.BoundsChanged();
			}
			else
			{
				// No, ensure that the bounds stay positive
				if (Rect.Left > Rect.Right)
				{
					Rect.Right = Rect.Left + 1;
				}

				if (Rect.Top > Rect.Bottom)
				{
					Rect.Bottom = Rect.Top + 1;
				}

				// Allow parent to adjust bounds
				base.BoundsChanged();

				// Apply changes
				ApplyMoveAndScale();
			}
		}

		/// <summary>
		/// Places the shape into the editing mode where the user can adjust the individual data points
		/// that define the shape.
		/// </summary>
		public override void StartEditing()
		{
			base.StartEditing();

			// Add the required control points
			ControlPoints.Clear();
			for (int n = 0; n < Points.Count; ++n)
			{
				AddHandlesForPoint(n, Points[n]);
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
			sourceCode += $"{pathName}.MoveTo(new SKPoint({Points[0].EndPoint.X}f, {Points[0].EndPoint.Y}f));\n";
			for (int n = 1; n < Points.Count; n++)
			{
				sourceCode += $"{pathName}.QuadTo(new SKPoint({Points[n].ControlPoint.X}f, {Points[n].ControlPoint.Y}f), new SKPoint({Points[n].EndPoint.X}f, {Points[n].EndPoint.Y}f));\n";
			}
			if (Closed) sourceCode += $"{pathName}.QuadTo(new SKPoint({Points[0].ControlPoint.X}f, {Points[0].ControlPoint.Y}f), new SKPoint({Points[0].EndPoint.X}f, {Points[0].EndPoint.Y}f));\n";

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

			// Build with Kimono Core
			sourceCode += $"// Build {Name} shape\n" +
				$"var {ElementName} = new KimonoShapeBezier({Left}f, {Top}f, {Right}f, {Bottom}f)" + "{" +
				$"\n\tRotationDegrees = {RotationDegrees}," +
				$"\n\tVisible = {Visible.ToString().ToLower()}," +
				$"\n\tStyle = {Style.ElementName}," +
				$"\n\tClosed = {Closed.ToString().ToLower()}" +
				"};\n\n";

			// Add the points to the shape
			sourceCode += $"// Add points to {Name} shape\n";
			foreach (KimonoBezierPoint point in Points)
			{
				sourceCode += $"{ElementName}.AddPoint({point.ControlPoint.X}f, {point.ControlPoint.Y}f, {point.EndPoint.X}f, {point.EndPoint.Y}f);\n";
			}

			// Add any connections
			var connections = ConnectionsToKimonoCore();
			if (connections != null)
			{
				sourceCode += $"\n{connections}";
			}

			// Draw shape
			sourceCode += $"\n// Draw {Name} shape\n" +
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
		/// <returns>The clone <c>KimonoShapeVector</c>.</returns>
		public override KimonoBounds Clone()
		{
			// Duplicate shape
			var newShape = new KimonoShapeBezier(this.Left, this.Top, this.Right, this.Bottom, this.State)
			{
				UniqueID = this.UniqueID,
				Name = this.Name,
				Style = CloneAttachedStyle(),
				Visible = this.Visible,
				Closed = this.Closed,
				LayerDepth = this.LayerDepth
			};

			// Clone control points
			foreach (KimonoHandle handle in ControlPoints)
			{
				// Duplicate handle and add to collection
				newShape.ControlPoints.Add(handle.Clone());
			}

			// Copy points
			foreach (KimonoBezierPoint point in Points)
			{
				newShape.Points.Add(point.Clone());
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
