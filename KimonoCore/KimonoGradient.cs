using System;
using System.Collections.Generic;
using System.Linq;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Defines a gradient as a collection of either <c>SKColor</c> or linked <c>KimonoColors</c>
	/// that can be applied to a <c>KimonoStyle</c> and used when drawing a <c>KimonoShape</c>.
	/// </summary>
	public class KimonoGradient
	{
		#region Private Variables
		/// <summary>
		/// The type of the gradient.
		/// </summary>
		private KimonoGradientType _gradientType = KimonoGradientType.LinearGradient;

		/// <summary>
		/// The start point.
		/// </summary>
		private KimonoHandle _startPoint = new KimonoHandle(0, 0)
		{
			HandleType = KimonoHandleType.GradientPosition
		};

		/// <summary>
		/// The end point.
		/// </summary>
		private KimonoHandle _endPoint = new KimonoHandle(176 - KimonoHandle.DrawWidth, 176 - KimonoHandle.DrawWidth)
		{
			HandleType = KimonoHandleType.GradientPosition
		};

		/// <summary>
		/// The radius for radial and conical gradients.
		/// </summary>
		private float _radius = 88;

		/// <summary>
		/// The gradient tile mode.
		/// </summary>
		private SKShaderTileMode _tileMode = SKShaderTileMode.Clamp;

		/// <summary>
		/// The selected handle.
		/// </summary>
		private KimonoHandle _selectedHandle = null;

		/// <summary>
		/// Is the user performing a drag operation.
		/// </summary>
		private bool PerformingDrag = false;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the type of the gradient.
		/// </summary>
		/// <value>The type of the gradient.</value>
		public KimonoGradientType GradientType
		{
			get { return _gradientType; }
			set
			{
				_gradientType = value;
				RaiseGradientModified();
			}
		}

		/// <summary>
		/// Gets or sets the unique identifier.
		/// </summary>
		/// <value>The unique identifier.</value>
		public string UniqueID { get; set; } = Guid.NewGuid().ToString();

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; } = "Gradient";

		/// <summary>
		/// Gets or sets the width of the bar.
		/// </summary>
		/// <value>The width of the bar.</value>
		public float BarWidth { get; set; } = 237;

		/// <summary>
		/// Gets or sets the height of the bar.
		/// </summary>
		/// <value>The height of the bar.</value>
		public float BarHeight { get; set; } = 18;

		/// <summary>
		/// Gets or sets the width of the preview.
		/// </summary>
		/// <value>The width of the preview.</value>
		public float PreviewWidth { get; set; } = 176;

		/// <summary>
		/// Gets or sets the height of the preview.
		/// </summary>
		/// <value>The height of the preview.</value>
		public float PreviewHeight { get; set; } = 176;

		/// <summary>
		/// Gets or sets the start point.
		/// </summary>
		/// <value>The start point.</value>
		public KimonoHandle StartPoint
		{
			get { return _startPoint; }
			set
			{
				_startPoint = value;
				//RaiseGradientModified();
			}

		}

		/// <summary>
		/// Gets or sets the end point.
		/// </summary>
		/// <value>The end point.</value>
		public KimonoHandle EndPoint
		{
			get { return _endPoint; }
			set
			{
				_endPoint = value;
				//RaiseGradientModified();
			}
		}

		/// <summary>
		/// Gets or sets the radius used by radial and conical gradients.
		/// </summary>
		/// <value>The radius.</value>
		public float Radius
		{
			get { return _radius; }
			set
			{
				_radius = value;
				RaiseGradientModified();
			}
		}

		/// <summary>
		/// Gets or sets the tile mode.
		/// </summary>
		/// <value>The tile mode.</value>
		public SKShaderTileMode TileMode
		{
			get { return _tileMode; }
			set
			{
				_tileMode = value;
				RaiseGradientModified();
			}
		}

		/// <summary>
		/// Gets or sets the control points that define the color.
		/// </summary>
		/// <value>The control points.</value>
		public List<KimonoHandle> ControlPoints { get; set; } = new List<KimonoHandle>();

		/// <summary>
		/// Gets or sets the selected handle.
		/// </summary>
		/// <value>The selected handle.</value>
		public KimonoHandle SelectedHandle
		{
			get { return _selectedHandle; }
			set
			{
				// Was a previous handle selected?
				if (_selectedHandle != null) _selectedHandle.State = KimonoShapeState.Unselected;

				// Save new handle
				_selectedHandle = value;

				// Set new handle state
				if (_selectedHandle != null) _selectedHandle.State = KimonoShapeState.Selected;

				// Inform caller
				RaiseGradientModified();
				RaiseHandleSelected(_selectedHandle);
			}
		}

		/// <summary>
		/// Gets the color of the selected handle.
		/// </summary>
		/// <value>The color of the selected handle or black if no handle is selected.</value>
		public SKColor SelectedColor
		{
			get
			{
				// Is a handle selected?
				if (SelectedHandle == null)
				{
					// No, return black
					return KimonoColor.Black;
				}
				else
				{
					// Yes, return the represented color
					return SelectedHandle.RepresentedColor;
				}
			}
		}

		/// <summary>
		/// Gets the Skia Shader that represents this gradient.
		/// </summary>
		/// <value>The <c>SKShader</c> for this gradient.</value>
		public SKShader Shader
		{
			get
			{
				// Create new shader
				SKShader shader = null;

				// Take action based on the gradient type
				switch (GradientType)
				{
					case KimonoGradientType.LinearGradient:
						shader = SKShader.CreateLinearGradient(new SKPoint(StartPoint.X, StartPoint.Y),
															   new SKPoint(EndPoint.X, EndPoint.Y),
															   SortedColors(),
						                                       SortedWeights(),
															   TileMode);
						break;
					case KimonoGradientType.RadialGradient:
						shader = SKShader.CreateRadialGradient(new SKPoint(StartPoint.X, StartPoint.Y),
															   Radius,
															   SortedColors(),
															   SortedWeights(),
															   TileMode);
						break;
					case KimonoGradientType.ConicalGradient:
						shader = SKShader.CreateTwoPointConicalGradient(new SKPoint(StartPoint.X, StartPoint.Y),
						                                                Radius,
															   			new SKPoint(EndPoint.X, EndPoint.Y),
						                                                Radius / 2f,
															   			SortedColors(),
															   			SortedWeights(),
															   			TileMode);
						break;
					case KimonoGradientType.SweepGradient:
						shader = SKShader.CreateSweepGradient( new SKPoint(StartPoint.X, StartPoint.Y),
															   SortedColors(),
															   SortedWeights());
						break;
				}

				// Return the new shader
				return shader;
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoGradient"/> class.
		/// </summary>
		public KimonoGradient()
		{
			// Initialize
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoGradient"/> class.
		/// </summary>
		/// <param name="barWidth">Bar width.</param>
		/// <param name="barHeight">Bar height.</param>
		public KimonoGradient(float barWidth, float barHeight)
		{
			// Initialize
			BarWidth = barWidth;
			BarHeight = barHeight;
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoGradient"/> class.
		/// </summary>
		/// <param name="barWidth">Bar width.</param>
		/// <param name="barHeight">Bar height.</param>
		/// <param name="previewWidth">Preview width.</param>
		/// <param name="previewHeight">Preview height.</param>
		public KimonoGradient(float barWidth, float barHeight, float previewWidth, float previewHeight)
		{
			// Initialize
			BarWidth = barWidth;
			BarHeight = barHeight;
			PreviewWidth = previewWidth;
			PreviewHeight = previewHeight;
			Initialize();
		}

		/// <summary>
		/// Initialize this instance.
		/// </summary>
		internal void Initialize()
		{
			// Create starting point
			var start = new KimonoHandle(0, (BarHeight / 2f) - KimonoHandle.DrawOffset, KimonoHandleConstraint.Locked)
			{
				Color = KimonoColor.White
			};
			ControlPoints.Add(start);

			// Create an ending point
			var end = new KimonoHandle(BarWidth - KimonoHandle.DrawWidth, (BarHeight / 2f) - KimonoHandle.DrawOffset, KimonoHandleConstraint.Locked)
			{
				Color = KimonoColor.Black
			};
			ControlPoints.Add(end);
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Returns a list of sorted colors by their "X" location inside the gradient.
		/// </summary>
		/// <returns>The sorted colors arrays.</returns>
		private SKColor[] SortedColors()
		{
			// Sort color list
			var list = ControlPoints.OrderBy(n => n.X).ToList();

			// Copy colors into new list
			var colors = new List<SKColor>();
			foreach (KimonoHandle handle in list)
			{
				// Linked color?
				if (handle.LinkedColor == null)
				{
					colors.Add(handle.Color);
				}
				else
				{
					colors.Add(handle.LinkedColor.Color);
				}
			}

			// Return colors array
			return colors.ToArray();
		}

		/// <summary>
		/// Returns a list a color weights by their "X" location in the gradient.
		/// </summary>
		/// <returns>The sorted weights.</returns>
		private Single[] SortedWeights()
		{
			// Sort color list
			var list = ControlPoints.OrderBy(n => n.X).ToList();

			// Calculate weights for colors
			var weights = new List<Single>();
			foreach (KimonoHandle handle in list)
			{
				// Calculate weight for each color point
				weights.Add((Single)(handle.X/BarWidth));
			}

			// Return weight array
			return weights.ToArray();
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Generates a shader that conforms to a given start and end point.
		/// </summary>
		/// <returns>The <c>SKShader</c> for the gradient bound to a given shape's dimentions.</returns>
		/// <param name="startPoint">Start point.</param>
		/// <param name="endPoint">End point.</param>
		public SKShader ConformingShader(SKPoint startPoint, SKPoint endPoint)
		{
			// Create new shader
			SKShader shader = null;

			// Take action based on the gradient type
			switch (GradientType)
			{
				case KimonoGradientType.LinearGradient:
					shader = SKShader.CreateLinearGradient(startPoint,
														   endPoint,
														   SortedColors(),
														   SortedWeights(),
														   TileMode);
					break;
				case KimonoGradientType.RadialGradient:
					shader = SKShader.CreateRadialGradient(startPoint,
														   Radius,
														   SortedColors(),
														   SortedWeights(),
														   TileMode);
					break;
				case KimonoGradientType.ConicalGradient:
					shader = SKShader.CreateTwoPointConicalGradient(startPoint,
																	Radius,
																	   endPoint,
																	Radius / 2f,
																	   SortedColors(),
																	   SortedWeights(),
																	   TileMode);
					break;
				case KimonoGradientType.SweepGradient:
					shader = SKShader.CreateSweepGradient(startPoint,
														   SortedColors(),
														   SortedWeights());
					break;
			}

			// Return the new shader
			return shader;
		}

		/// <summary>
		/// Adds a new control point to the gradients collection and makes it the
		/// selected control point.
		/// </summary>
		public void AddControlPoint()
		{
			var point = new KimonoHandle((BarWidth /2f) - KimonoHandle.DrawOffset, (BarHeight / 2f) - KimonoHandle.DrawOffset, KimonoHandleConstraint.Horizontal);
			ControlPoints.Add(point);
			SelectedHandle = point;
		}

		/// <summary>
		/// Deletes the selected control point.
		/// </summary>
		public void DeleteSelectedControlPoint()
		{
			// Anything to process?
			if (SelectedHandle == null) return;

			ControlPoints.Remove(SelectedHandle);
			SelectedHandle = null;
		}

		/// <summary>
		/// Duplicates the selected control point.
		/// </summary>
		public void DuplicateSelectedControlPoint()
		{
			// Anything to process?
			if (SelectedHandle == null) return;

			// Make duplicate
			var point = SelectedHandle.Clone();
			point.Constraint = KimonoHandleConstraint.Horizontal;
			ControlPoints.Add(point);
			SelectedHandle = point;
		}

		/// <summary>
		/// Finds the handle matching the given unique ID.
		/// </summary>
		/// <returns>The matching <c>KimonoHandle</c> or <c>null</c> if not found.</returns>
		/// <param name="uniqueID">Unique identifier.</param>
		public KimonoHandle FindHandle(string uniqueID)
		{
			// Scan all handles
			foreach (KimonoHandle handle in ControlPoints)
			{
				// Found?
				if (handle.UniqueID == uniqueID) return handle;
			}

			// Not found
			return null;
		}

		/// <summary>
		/// Draws the bar.
		/// </summary>
		/// <returns>The bar.</returns>
		public SKData DrawBar()
		{
			// Draw all of the elements into the image buffer
			using (var surface = SKSurface.Create((int)BarWidth, (int)BarHeight, SKImageInfo.PlatformColorType, SKAlphaType.Premul))
			{
				// Define bar bounds
				var rect = new SKRect(0, 0, BarWidth, BarHeight);

				// Create Canvas
				SKCanvas canvas = surface.Canvas;
				canvas.Clear(KimonoColor.White);

				// Make background gradient
				var shader = SKShader.CreateLinearGradient(new SKPoint(0, BarHeight / 2f),
														   new SKPoint(BarWidth, BarHeight / 2f),
														   SortedColors(),
														   SortedWeights(),
														   SKShaderTileMode.Clamp);
				var paint = new SKPaint()
				{
					Color = KimonoColor.Black,
					StrokeWidth = 2,
					Shader = shader
				};

				// Draw background
				canvas.DrawRect(rect, paint);

				// Draw all handles into the canvas
				foreach (KimonoHandle handle in ControlPoints)
				{
					handle.Draw(canvas);
				}

				// Draw frame
				paint.Shader = null;
				paint.IsStroke = true;
				canvas.DrawRect(rect, paint);

				// Return data from sketch
				return surface.Snapshot().Encode();
			}
		}

		/// <summary>
		/// Draws the preview.
		/// </summary>
		/// <returns>The preview.</returns>
		public SKData DrawPreview()
		{
			// Draw all of the elements into the image buffer
			using (var surface = SKSurface.Create((int)PreviewWidth, (int)PreviewHeight, SKImageInfo.PlatformColorType, SKAlphaType.Premul))
			{
				// Define bar bounds
				var rect = new SKRect(0, 0, PreviewWidth, PreviewHeight);

				// Create Canvas
				SKCanvas canvas = surface.Canvas;
				canvas.Clear(KimonoColor.White);

				// Make background paint
				var paint = new SKPaint()
				{
					Color = KimonoColor.Black,
					StrokeWidth = 2,
					Shader = this.Shader
				};

				// Draw background
				canvas.DrawRect(rect, paint);

				// Draw all handles into the canvas based on the shader type
				switch (GradientType)
				{
					case KimonoGradientType.LinearGradient:
						StartPoint.Draw(canvas);
						EndPoint.Draw(canvas);
						break;
					case KimonoGradientType.RadialGradient:
						StartPoint.Draw(canvas);
						break;
					case KimonoGradientType.ConicalGradient:
						StartPoint.Draw(canvas);
						EndPoint.Draw(canvas);
						break;
					case KimonoGradientType.SweepGradient:
						StartPoint.Draw(canvas);
						break;
				}

				// Draw frame
				paint.Shader = null;
				paint.IsStroke = true;
				canvas.DrawRect(rect, paint);

				// Return data from sketch
				return surface.Snapshot().Encode();
			}
		}
		#endregion

		#region Bar Tool Events
		/// <summary>
		/// Handles the user clicking a control point in the gradient design bar.
		/// </summary>
		/// <param name="point">The point the user clicked.</param>
		/// <param name="clicks">The number of times the user clicked.</param>
		/// <param name="multiSelect">If set to <c>true</c> multi select.</param>
		public void BarToolDown(SKPoint point, int clicks, bool multiSelect)
		{
			// Clear states
			PerformingDrag = false;

			// Adding a new point?
			if (clicks == 2)
			{
				// Yes, build new point and add to collection
				var handle = new KimonoHandle(point.X-KimonoHandle.DrawOffset, (BarHeight / 2f) - KimonoHandle.DrawOffset, KimonoHandleConstraint.Horizontal);
				ControlPoints.Add(handle);
				SelectedHandle = handle;
				return;
			}

			// Scan all point to see it one was hit
			foreach (KimonoHandle handle in ControlPoints)
			{
				// Hit?
				if (handle.PointInBound(point))
				{
					// Yes, select handle
					SelectedHandle = handle;
					return;
				}
			}

			// Not found, unselect all
			SelectedHandle = null;
		}

		/// <summary>
		/// Handles the user draging a control point in the gradient design bar. 
		/// </summary>
		/// <param name="point">The new location.</param>
		public void BarToolDrag(SKPoint point)
		{
			// Anything to process?
			if (SelectedHandle == null) return;

			// Valid position?
			if (point.X < 0) point.X = 0;
			if (point.X > (BarWidth - KimonoHandle.DrawWidth)) point.X = (BarWidth - KimonoHandle.DrawWidth);

			// Drag bounds
			SelectedHandle.DragHandle(point);
			PerformingDrag = true;
		}

		/// <summary>
		/// Handles the user releasing a control point in the gradient design bar.
		/// </summary>
		/// <param name="point">Point.</param>
		public void BarToolUp(SKPoint point)
		{
			// Was the user performing a drag?
			if (PerformingDrag)
			{
				// Yes, refresh view
				RaiseGradientModified();
			}

			// Clear states
			PerformingDrag = false;
		}
		#endregion

		#region Preview Tool Events
		/// <summary>
		/// Handles the user clicking a control point in the gradient preview.
		/// </summary>
		/// <param name="point">The point the user clicked.</param>
		/// <param name="clicks">The number of times the user clicked.</param>
		/// <param name="multiSelect">If set to <c>true</c> multi select.</param>
		public void PreviewToolDown(SKPoint point, int clicks, bool multiSelect)
		{
			// Clear states
			PerformingDrag = false;

			// Take action based on the gradient type
			switch (GradientType)
			{
				case KimonoGradientType.LinearGradient:
				case KimonoGradientType.ConicalGradient:
					if (StartPoint.PointInBound(point))
					{
						SelectedHandle = StartPoint;
						return;
					}
					else if (EndPoint.PointInBound(point))
					{
						SelectedHandle = EndPoint;
						return;
					}
					break;
				case KimonoGradientType.RadialGradient:
				case KimonoGradientType.SweepGradient:
					if (StartPoint.PointInBound(point))
					{
						SelectedHandle = StartPoint;
						return;
					}
					break;
			}

			// Not found, unselect all
			SelectedHandle = null;
		}

		/// <summary>
		/// Handles the user draging a control point in the gradient preview. 
		/// </summary>
		/// <param name="point">The new location.</param>
		public void PreviewToolDrag(SKPoint point)
		{
			// Anything to process?
			if (SelectedHandle == null) return;

			// Valid position?
			if (point.X < 0) point.X = 0;
			if (point.X > (PreviewWidth - KimonoHandle.DrawOffset)) point.X = (PreviewWidth - KimonoHandle.DrawOffset);
			if (point.Y < 0) point.Y = 0;
			if (point.Y > (PreviewHeight - KimonoHandle.DrawOffset)) point.Y = (PreviewHeight - KimonoHandle.DrawOffset);

			// Drag bounds
			SelectedHandle.DragHandle(point);
			PerformingDrag = true;
		}

		/// <summary>
		/// Handles the user releasing a control point in the gradient preview.
		/// </summary>
		/// <param name="point">Point.</param>
		public void PreviewToolUp(SKPoint point)
		{
			// Was the user performing a drag?
			if (PerformingDrag)
			{
				// Yes, refresh view
				RaiseGradientModified();
			}

			// Clear states
			PerformingDrag = false;
		}
		#endregion

		#region Cloning
		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>The clone.</returns>
		public KimonoGradient Clone()
		{
			// Duplicate shape
			var newGradient = new KimonoGradient(this.BarWidth, this.BarHeight, this.PreviewWidth, this.PreviewHeight)
			{
				UniqueID = this.UniqueID,
				Name = this.Name,
				GradientType = this.GradientType,
				StartPoint = this.StartPoint.Clone(),
				EndPoint = this.EndPoint.Clone(),
				Radius = this.Radius,
				TileMode = this.TileMode
			};

			// Clone control points
			newGradient.ControlPoints.Clear();
			foreach (KimonoHandle handle in ControlPoints)
			{
				// Duplicate handle and add to collection
				newGradient.ControlPoints.Add(handle.Clone());
			}

			// Was a handle selected?
			if (SelectedHandle != null)
			{
				// Find new instance
				newGradient.SelectedHandle = newGradient.FindHandle(SelectedHandle.UniqueID);
			}

			// Return new shape
			return newGradient;
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when the gradient is modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate GradientModified;

		/// <summary>
		/// Occurs when a handle is selected.
		/// </summary>
		public event Kimono.HandleEventDelegate HandleSelected;

		/// <summary>
		/// Raises the gradient modified event.
		/// </summary>
		internal void RaiseGradientModified()
		{
			// Inform caller
			if (GradientModified != null) GradientModified();
		}

		/// <summary>
		/// Raises the handle selected event.
		/// </summary>
		/// <param name="handle">Handle.</param>
		internal void RaiseHandleSelected(KimonoHandle handle)
		{
			// Inform caller
			if (HandleSelected != null) HandleSelected(handle);
		}
		#endregion
	}
}
