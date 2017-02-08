using System;
using System.Collections.Generic;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// Holds a collection of <c>KimonoShapes</c> that are used to create a given
	/// image using Skia.
	/// </summary>
	public class KimonoSketch : IKimonoCodeGeneration
	{

		#region Private Variables
		/// <summary>
		/// The shape under construction.
		/// </summary>
		internal KimonoShape ShapeUnderConstruction = null;

		/// <summary>
		/// The size of the previous of a sketch for a rezise operation.
		/// </summary>
		private SKSize PreviousSize = new SKSize(640, 480);

		/// <summary>
		/// The current size of the sketch
		/// </summary>
		private SKSize Size = new SKSize(640, 480);

		/// <summary>
		/// The currently <c>KimonoTool</c> that will be used to edit the sketch.
		/// </summary>
		private KimonoTool _tool = KimonoTool.Cursor;

		/// <summary>
		/// The color of the canvas.
		/// </summary>
		private SKColor _canvasColor = SKColors.White;

		/// <summary>
		/// The selected shape.
		/// </summary>
		private KimonoShape _selectedShape = null;

		/// <summary>
		/// If <c>true</c>, the next drag event will be ignored.
		/// </summary>
		private bool IgnoreDrag = false;

		/// <summary>
		/// If <c>true</c>, the user is performing a drag operation.
		/// </summary>
		private bool PerformingDrag = false;

		/// <summary>
		/// The last point that a <c>KimonoTool</c> went down on the sketch's Design
		/// Surface.
		/// </summary>
		private SKPoint ToolDownAt = new SKPoint();
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the unique identifier.
		/// </summary>
		/// <value>The unique identifier.</value>
		public string UniqueID { get; set; } = Guid.NewGuid().ToString();

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; } = "Untitled";

		/// <summary>
		/// Gets or sets the width.
		/// </summary>
		/// <value>The width.</value>
		public float Width
		{
			get { return Size.Width; }
			set
			{
				SavePreviousSize();
				Size.Width = value;
				ApplySizeChange();
				RaiseImageBufferNeedsRefresh();
				RaiseSketchSizeChanged();
			}
		}

		/// <summary>
		/// Gets or sets the height.
		/// </summary>
		/// <value>The height.</value>
		public float Height
		{
			get { return Size.Height; }
			set
			{
				SavePreviousSize();
				Size.Height = value;
				ApplySizeChange();
				RaiseImageBufferNeedsRefresh();
				RaiseSketchSizeChanged();
			}
		}

		/// <summary>
		/// Gets or sets the color of the canvas.
		/// </summary>
		/// <value>The color of the canvas.</value>
		public SKColor CanvasColor
		{
			get { return _canvasColor; }
			set
			{
				_canvasColor = value;
				RaiseImageBufferNeedsRefresh();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoSketch"/> should draw 
		/// the canvas when it is included in another sketch.
		/// </summary>
		/// <value><c>true</c> if draw canvas; otherwise, <c>false</c>.</value>
		public bool DrawCanvas { get; set; } = true;

		/// <summary>
		/// Gets or sets the shapes.
		/// </summary>
		/// <value>The shapes.</value>
		public List<KimonoShape> Shapes { get; set; } = new List<KimonoShape>();

		/// <summary>
		/// Gets or sets the tool.
		/// </summary>
		/// <value>The tool.</value>
		public KimonoTool Tool
		{
			get { return _tool; }
			set
			{
				_tool = value;
				RaiseToolChanged(value);
			}
		}

		/// <summary>
		/// Gets or sets the selected shape.
		/// </summary>
		/// <value>The selected shape.</value>
		public KimonoShape SelectedShape
		{
			get {return _selectedShape;}
			set { _selectedShape = value; }
		}

		/// <summary>
		/// Gets the deepest selected shape in a chain of groups.
		/// </summary>
		/// <value>The deeply selected shape.</value>
		public KimonoShape DeeplySelectedShape
		{
			get
			{
				if (_selectedShape is KimonoShapeGroup)
				{
					var group = _selectedShape as KimonoShapeGroup;
					if (group.DeeplySelectedShape == null)
					{
						return group;
					}
					else return group.DeeplySelectedShape;
				}
				else return _selectedShape;
			}
		}

		/// <summary>
		/// Gets the deepest selected group in a chain of groups that is in the edit mode.
		/// </summary>
		/// <value>The deeply selected group.</value>
		public KimonoShapeGroup DeeplySelectedGroup
		{
			get
			{
				if (_selectedShape is KimonoShapeGroup && _selectedShape.State == KimonoShapeState.Editing)
				{
					var group = _selectedShape as KimonoShapeGroup;
					return group.DeeplySelectedGroup;
				}
				else return null;
			}
		}

		/// <summary>
		/// Gets a value indicating whether the selected shape is at the bottom.
		/// </summary>
		/// <value><c>true</c> if selected shape at bottom; otherwise, <c>false</c>.</value>
		public bool SelectedShapeAtBottom
		{
			get 
			{
				// Is a group selected?
				if (DeeplySelectedGroup != null)
				{
					return DeeplySelectedGroup.SelectedShapeAtBottom;
				}
				else
				{
					return (SelectedShape?.LayerDepth == 0);
				}
			}
		}

		/// <summary>
		/// Gets a value indicating whether the selected shape is at the top.
		/// </summary>
		/// <value><c>true</c> if selected shape at top; otherwise, <c>false</c>.</value>
		public bool SelectedShapeAtTop
		{
			get 
			{
				// Is a group selected?
				if (DeeplySelectedGroup != null)
				{
					return DeeplySelectedGroup.SelectedShapeAtTop;
				}
				else
				{
					return (SelectedShape?.LayerDepth == Shapes.Count - 1);
				}
			}
		}

		/// <summary>
		/// Gets a value indicating whether alignment can be applied on a set of shapes.
		/// </summary>
		/// <value><c>true</c> if can align shapes; otherwise, <c>false</c>.</value>
		public bool CanAlignShapes
		{
			get { return (DeeplySelectedShape is KimonoShapeGroup && DeeplySelectedShape.State == KimonoShapeState.Constructing);}
		}

		/// <summary>
		/// Gets a value indicating whether the selection of shapes can be grouped.
		/// </summary>
		/// <value><c>true</c> if can group shapes; otherwise, <c>false</c>.</value>
		public bool CanGroupShapes
		{
			get { return (DeeplySelectedShape is KimonoShapeGroup && DeeplySelectedShape.State == KimonoShapeState.Constructing); }
		}

		/// <summary>
		/// Gets a value indicating whether the selection of shapes can be ungrouped.
		/// </summary>
		/// <value><c>true</c> if can group shapes; otherwise, <c>false</c>.</value>
		public bool CanUngroupShapes
		{
			get { return (DeeplySelectedShape is KimonoShapeGroup && DeeplySelectedShape.State == KimonoShapeState.Selected); }
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoSketch"/> class.
		/// </summary>
		public KimonoSketch()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoSketch"/> class.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="width">Width.</param>
		/// <param name="height">Height.</param>
		public KimonoSketch(string name, float width, float height)
		{
			// Initialize
			Name = name;
			Width = width;
			Height = height;

			Initialize();
		}

		/// <summary>
		/// Initialize this instance.
		/// </summary>
		internal void Initialize()
		{
			
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Saves the previous size of the sketch.
		/// </summary>
		private void SavePreviousSize()
		{
			PreviousSize = new SKSize(Size.Width, Size.Height);
		}

		/// <summary>
		/// Applies the size change.
		/// </summary>
		private void ApplySizeChange()
		{
			// Calculate centers
			var previousCenter = new SKPoint(PreviousSize.Width / 2f, PreviousSize.Height / 2f);
			var center = new SKPoint(Size.Width / 2f, Size.Height / 2f);

			// Calculate Size change
			var offsetX = 0f;
			var shrinkX = true;
			var offsetY = 0f;
			var shrinkY = true;

			if (Size.Width < PreviousSize.Width)
			{
				offsetX = Size.Width / PreviousSize.Width;
				shrinkX = true;
			}
			else
			{
				offsetX = PreviousSize.Width / Size.Width;
				shrinkX = false;
			}

			if (Size.Height < PreviousSize.Height)
			{
				offsetY = Size.Height / PreviousSize.Height;
				shrinkY = true;
			}
			else
			{
				offsetY = PreviousSize.Height / Size.Height;
				shrinkY = false;
			}

			if (!((int)offsetX == 1 && (int)offsetY == 1))
			{
				// Apply offest to all shapes
				foreach(KimonoShape shape in Shapes)
				{
					// Get adjusted x,y
					var x = shape.Left - previousCenter.X;
					var y = shape.Top - previousCenter.Y;
					var x1 = shape.Right - previousCenter.X;
					var y1 = shape.Bottom - previousCenter.Y;

					// Calculate resized X positions
					if (shrinkX)
					{
						x = (x * offsetX) + center.X;
						x1 = (x1 * offsetX) + center.X;
					}
					else
					{
						x = (x / offsetX) + center.X;
						x1 = (x1 / offsetX) + center.X;
					}

					// Calculate resized Y positions
					if (shrinkY)
					{
						y = (y * offsetY) + center.Y;
						y1 = (y1 * offsetY) + center.Y;
					}
					else
					{
						y = (y / offsetY) + center.Y;
						y1 = (y1 / offsetY) + center.Y;
					}

					// Apply new point
					shape.ChangeBounds(x, y, x1, y1);
				}
			}

			// Update bounds
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Removes the property connection.
		/// </summary>
		/// <param name="connection">The `KimonoPropertyConnection` to remove.</param>
		public void RemovePropertyConnection(KimonoPropertyConnection connection)
		{
			// Process all shapes
			foreach (KimonoShape shape in Shapes)
			{
				// Is this a sub group?
				if (shape is KimonoShapeGroup)
				{
					// Yes, remove from sub group
					var group = shape as KimonoShapeGroup;
					group.RemovePropertyConnection(connection);
				}
				else
				{
					// No, remove directly from shape
					shape.RemovePropertyConnection(connection);
				}
			}
		}

		/// <summary>
		/// Removes any connection using this property.
		/// </summary>
		/// <param name="property">The `KimonoProperty` to remove.</param>
		public void RemoveProperty(KimonoProperty property)
		{
			// Process all shapes
			foreach (KimonoShape shape in Shapes)
			{
				// Is this a sub group?
				if (shape is KimonoShapeGroup)
				{
					// Yes, remove from sub group
					var group = shape as KimonoShapeGroup;
					group.RemoveProperty(property);
				}
				else
				{
					// No, remove directly from shape
					shape.RemoveProperty(property);
				}
			}
		}

		/// <summary>
		/// Finds the shape specified by its unique ID.
		/// </summary>
		/// <returns>If found, the <c>KimonoShape</c> will be returned, else <c>null</c>.</returns>
		/// <param name="uniqueID">Unique identifier.</param>
		public KimonoShape FindShape(string uniqueID)
		{
			// Scan all shapes
			foreach (KimonoShape shape in Shapes)
			{
				// Found?
				if (shape.UniqueID == uniqueID) return shape;
			}

			// Not found
			return null;
		}

		/// <summary>
		/// Draw this instance into a <c>SKData</c> buffer.
		/// </summary>
		/// <returns>An <c>SKdata</c> buffer representing the sketch as a Skia image.</returns>
		public SKData Draw()
		{
			// Draw all of the elements into the image buffer
			using (var surface = SKSurface.Create((int)Width, (int)Height, SKImageInfo.PlatformColorType, SKAlphaType.Premul))
			{
				// Create Canvas
				SKCanvas canvas = surface.Canvas;
				canvas.Clear(CanvasColor);

				// Draw all shapes into the canvas
				foreach (KimonoShape shape in Shapes)
				{
					shape.Draw(canvas);
				}

				// If a new shape is being added to the document,
				// draw it as well
				ShapeUnderConstruction?.Draw(canvas);

				// Return data from sketch
				return surface.Snapshot().Encode();
			}
		}

		/// <summary>
		/// Moves the selected shape to bottom.
		/// </summary>
		public void MoveSelectedShapeToBottom()
		{
			// Anything to process
			if (SelectedShape == null || SelectedShapeAtBottom) return;

			// Save undo point
			RaiseRequestNewUndoPoint();

			// Move shape
			Shapes.Remove(SelectedShape);
			Shapes.Insert(0, SelectedShape);

			// Set new layer depths
			RecalculateLayerDepths();

			// Update UI
			RaiseSketchModified();
			RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Moves the selected shape backwards.
		/// </summary>
		public void MoveSelectedShapeBackwards()
		{
			// Anything to process
			if (SelectedShape == null || SelectedShapeAtBottom) return;

			// Save undo point
			RaiseRequestNewUndoPoint();

			// Move shape
			Shapes.Remove(SelectedShape);
			Shapes.Insert(SelectedShape.LayerDepth -1, SelectedShape);

			// Set new layer depths
			RecalculateLayerDepths();

			// Update UI
			RaiseSketchModified();
			RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Moves the selected shape to top.
		/// </summary>
		public void MoveSelectedShapeToTop()
		{
			// Anything to process
			if (SelectedShape == null || SelectedShapeAtTop) return;

			// Save undo point
			RaiseRequestNewUndoPoint();

			// Move shape
			Shapes.Remove(SelectedShape);
			Shapes.Add(SelectedShape);

			// Set new layer depths
			RecalculateLayerDepths();

			// Update UI
			RaiseSketchModified();
			RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Moves the selected shape forwards.
		/// </summary>
		public void MoveSelectedShapeForwards()
		{
			// Anything to process
			if (SelectedShape == null || SelectedShapeAtTop) return;

			// Save undo point
			RaiseRequestNewUndoPoint();

			// Move shape
			Shapes.Remove(SelectedShape);
			if (SelectedShape.LayerDepth + 1 > Shapes.Count - 1)
			{
				Shapes.Add(SelectedShape);
			}
			else
			{
				Shapes.Insert(SelectedShape.LayerDepth + 1, SelectedShape);
			}

			// Set new layer depths
			RecalculateLayerDepths();

			// Update UI
			RaiseSketchModified();
			RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Adds the shape.
		/// </summary>
		/// <param name="shape">The <c>KimonoShape</c> to add.</param>
		public void AddShape(KimonoShape shape)
		{
			// Save undo point
			RaiseRequestNewUndoPoint();

			// Add new shape
			Shapes.Add(shape);

			// Set new layer depths
			RecalculateLayerDepths();

			// Update UI
			RaiseSketchModified();
		}

		/// <summary>
		/// Recalculates the layer depths.
		/// </summary>
		/// <remarks>Layer depths are used to maintain the front to back order of the
		/// <c>KimonoShapes</c> that for the sketch.</remarks>
		public void RecalculateLayerDepths()
		{
			// Set the layer depth of all shapes
			var n = 0;
			foreach (KimonoShape shape in Shapes)
			{
				// Set depth
				shape.LayerDepth = n++;
			}
		}

		/// <summary>
		/// Duplicates the selected shape.
		/// </summary>
		public void DuplicateSelectedShape()
		{
			// Anything to process
			if (SelectedShape == null) return;

			// Is this a raw selection group?
			if (SelectedShape is KimonoShapeGroup && SelectedShape.State == KimonoShapeState.Constructing)
			{
				// Yes, make a copy of all the shapes 
				var group = SelectedShape as KimonoShapeGroup;
				group.DuplicateShapes();
				return;
			}

			// Save undo point
			RaiseRequestNewUndoPoint();

			// Make a new copy and insert it into the collection
			var newShape = SelectedShape.Clone() as KimonoShape;
			newShape.Name = Kimono.IncrementName(newShape.Name);
			DeselectAll();
			Shapes.Add(newShape);

			// Set new layer depths
			RecalculateLayerDepths();

			// Make this the currently selected shape
			SelectedShape = newShape;
			RaiseSketchModified();
			RaiseSelectionChanged(SelectedShape);
			RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Deletes the selected shape.
		/// </summary>
		public void DeleteSelectedShape()
		{
			// Anything to process
			if (SelectedShape == null) return;

			// Is this a raw selection group?
			if (SelectedShape is KimonoShapeGroup && SelectedShape.State == KimonoShapeState.Constructing)
			{
				// Yes, delete of all the shapes and
				// dispose of the group
				var group = SelectedShape as KimonoShapeGroup;
				group.DeleteShapes();
				return;
			}

			// Save undo point
			RaiseRequestNewUndoPoint();

			// Remove shape from selection
			Shapes.Remove(SelectedShape);
			SelectedShape = null;

			// Set new layer depths
			RecalculateLayerDepths();

			// Inform caller
			RaiseSketchModified();
			RaiseSelectionChanged(null);
			RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Selects the given shape.
		/// </summary>
		/// <param name="shape">The <c>KimonoShape</c> to select.</param>
		public void SelectShape(KimonoShape shape)
		{
			// Clear all existing selections
			DeselectAll();
			SelectedShape = shape;
			shape.Select();

			// Inform caller of change
			RaiseSelectionChanged(SelectedShape);
			RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Deselects all shapes in the sketch.
		/// </summary>
		public void DeselectAll()
		{
			foreach (KimonoShape shape in Shapes)
			{
				// If the shape was being edited, close it
				if (shape.State == KimonoShapeState.Editing)
				{
					shape.EndEditing();
				}

				// Mark unselected
				shape.Unselect();
			}

			SelectedShape = null;
			ShapeUnderConstruction = null;
		}

		/// <summary>
		/// Groups or ungroups the currently selected group of shapes
		/// based on the current selection type.
		/// </summary>
		public void GroupUngroupSelectedShapes()
		{
			// Get group
			var group = SelectedShape as KimonoShapeGroup;

			// Anything to process?
			if (group == null) return;

			// Take action based on type
			if (group.GroupType == KimonoShapeGroupType.Collection)
			{
				group.UngroupShapes();
			}
			else
			{
				group.GroupShapes();
			}

			// Update UI
			RaiseSketchModified();
			RaiseSelectionChanged(SelectedShape);
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
		public virtual string ToCode(CodeOutputOS outputOS, CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			return "";
		}
		#endregion

		#region Cloning
		/// <summary>
		/// Relinks the given shape after a clone operation.
		/// </summary>
		/// <param name="shape">The <c>KimonoShape</c> to relink.</param>
		internal void RelinkShape(KimonoShape shape)
		{
			// Is this a group?
			if (shape is KimonoShapeGroup)
			{
				var group = shape as KimonoShapeGroup;
				group.Parent = this;
			}
		}

		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>A deep clone of this <c>KimonoSketch</c>.</returns>
		public KimonoSketch Clone()
		{
			//Console.WriteLine(">> Cloning: {0}", Name);

			// Create new sketch and copy over values
			var sketch = new KimonoSketch(this.Name, this.Width, this.Height)
			{
				UniqueID = this.UniqueID,
				CanvasColor = KimonoColor.CloneColor(this.CanvasColor),
				DrawCanvas = this.DrawCanvas,
				Tool = this.Tool
			};

			// Clone over all of the shapes
			foreach (KimonoShape shape in Shapes)
			{
				var shapeCopy = shape.Clone() as KimonoShape;
				sketch.RelinkShape(shapeCopy);
				sketch.Shapes.Add(shapeCopy);
			}

			// Match selection
			if (SelectedShape != null )
			{
				// Was a current group in progress?
				if (SelectedShape is KimonoShapeGroup && SelectedShape.State == KimonoShapeState.Constructing)
				{
					var group = SelectedShape as KimonoShapeGroup;
					var groupCopy = new KimonoShapeGroup(sketch);
					sketch.SelectedShape = groupCopy;
					sketch.ShapeUnderConstruction = sketch.SelectedShape;

					// Clone in items
					foreach (KimonoShape shape in group.Shapes)
					{
						groupCopy.Shapes.Add(sketch.FindShape(shape.UniqueID));
					}
					groupCopy.RecalculateGroupBounds();
					groupCopy.AddHandles(KimonoShapeState.Constructing);
				}
				else
				{
					// Find matching shape in clone
					sketch.SelectedShape = sketch.FindShape(SelectedShape.UniqueID);
					if (sketch.SelectedShape !=null) sketch.SelectedShape.AddHandles(KimonoShapeState.Unselected);
				}
			}

			// Was a shape under construction?
			if (ShapeUnderConstruction != null && !(ShapeUnderConstruction is KimonoShapeGroup))
			{
				// Clone the under construction shape too
				sketch.ShapeUnderConstruction = ShapeUnderConstruction.Clone() as KimonoShape;
			}

			// Return new instance
			return sketch;
		}
		#endregion

		#region Tool Events
		// -----------------------------------------------------------------------------------------------------
		// NOTICE:
		// Changes to the code in the <c>KimonoSketch<c> Tool Events will also need to be made to the 
		// <c>KimonoShapeGroup<c>'s Tool Events section as well.
		// -----------------------------------------------------------------------------------------------------

		/// <summary>
		/// Handles the user placing the current <c>KimonoTool</c> down on the sketch's
		/// Design Surface.
		/// </summary>
		/// <param name="point">The <c>SKPoint</c> where the tool went down on the Design Surface.</param>
		/// <param name="clicks">The number of time the user clicked/tapped the tool down on the Design Surface.</param>
		/// <param name="multiSelect">If <c>true</c>, the user has started a multi-shape select process.</param>
		public void ToolDown(SKPoint point, int clicks, bool multiSelect)
		{
			// Save the point where the tool went down
			ToolDownAt = point;

			// Is the selected shape a group in the edit mode?
			if (SelectedShape is KimonoShapeGroup && SelectedShape.State == KimonoShapeState.Editing)
			{
				// Forward tool events into group
				var group = SelectedShape as KimonoShapeGroup;
				group.ToolDown(point, clicks, multiSelect);
				return;
			}

			// Clear selection if not using the cursor
			if (Tool != KimonoTool.Cursor && SelectedShape != null)
			{
				// Clear existing selection
				DeselectAll();
				RaiseSelectionChanged(null);
			}

			// Take action based on the currently selected tool
			switch (Tool)
			{
				case KimonoTool.Cursor:
					// Multi select in progress?
					if (multiSelect)
					{
						// Already starting a group selection?
						if (SelectedShape is KimonoShapeGroup)
						{
							// Access group
							var group = SelectedShape as KimonoShapeGroup;

							// Scan all shapes
							for (int n = Shapes.Count - 1; n >= 0; n--)
							{
								if (Shapes[n].PointInBound(point))
								{
									// Are we inside the selected group?
									if (Shapes[n] == group)
									{
										// Yes, treat this as a normal click/drag
										// operation
										return;
									}
									else
									{
										// No, add the hit shape to the group
										group.AddShape(Shapes[n]);
										Shapes[n].StartGrouping();
										RaiseSelectionChanged(SelectedShape);
										IgnoreDrag = true;
										return;
									}
								}
							}

							// Deselect the group and its shapes
							DeselectAll();
							RaiseSelectionChanged(null);
							return;
						}
						else if (SelectedShape !=null && !SelectedShape.PointInBound(point)) 
						{
							// Scan all shapes
							for (int n = Shapes.Count - 1; n >= 0; n--)
							{
								if (Shapes[n].PointInBound(point))
								{
									// Make new group
									var group = new KimonoShapeGroup(this);
									group.Shapes.Add(SelectedShape);
									SelectedShape.StartGrouping();
									SelectedShape = group;
									ShapeUnderConstruction = SelectedShape;

									// Add the hit shape to the group
									group.AddShape(Shapes[n]);
									Shapes[n].StartGrouping();
									RaiseSelectionChanged(SelectedShape);
									group.PlaceUnderConstruction(true);
									IgnoreDrag = true;
									return;
								}
							}

							// Deselect the current shapes
							DeselectAll();
							RaiseSelectionChanged(null);
							return;
						}
					}

					// Did the user click inside an already selected shape?
					if (SelectedShape != null && SelectedShape.PointInBound(point))
					{
						if (clicks == 2 && SelectedShape.IsEditable && SelectedShape.State != KimonoShapeState.Editing)
						{
							SelectedShape.StartEditing();
						}

						// Update selection in designer
						RaiseSelectionChanged(SelectedShape);
						return;
					}

					// Deselect any existing shape
					DeselectAll();
					RaiseSelectionChanged(null);

					// Scan all shapes
					for (int n = Shapes.Count - 1; n >= 0; n--)
					{
						if (Shapes[n].PointInBound(point))
						{
							// Select the hit shape
							SelectedShape = Shapes[n];
							SelectedShape.Select();
							RaiseSelectionChanged(SelectedShape);
							return;
						}
					}
					break;
				case KimonoTool.Line:
					ShapeUnderConstruction = new KimonoShapeLine(point.X, point.Y, point.X, point.Y);
					break;
				case KimonoTool.Arrow:
					ShapeUnderConstruction = new KimonoShapeArrow(point.X, point.Y, point.X, point.Y, KimonoShapeState.Selected);
					break;
				case KimonoTool.Rectangle:
					ShapeUnderConstruction = new KimonoShapeRect(point.X, point.Y, point.X, point.Y, KimonoShapeState.Selected);
					break;
				case KimonoTool.Oval:
					ShapeUnderConstruction = new KimonoShapeOval(point.X, point.Y, point.X, point.Y, KimonoShapeState.Selected);
					break;
				case KimonoTool.RoundRect:
					ShapeUnderConstruction = new KimonoShapeRoundRect(point.X, point.Y, point.X, point.Y, KimonoShapeState.Selected);
					break;
				case KimonoTool.Star:
					ShapeUnderConstruction = new KimonoShapeStar(point.X, point.Y, point.X, point.Y, KimonoShapeState.Selected);
					break;
				case KimonoTool.Polygon:
					ShapeUnderConstruction = new KimonoShapePolygon(point.X, point.Y, point.X, point.Y, KimonoShapeState.Selected);
					break;
				case KimonoTool.Triangle:
					ShapeUnderConstruction = new KimonoShapeTriangle(point.X, point.Y, point.X, point.Y, KimonoShapeState.Selected);
					break;
				case KimonoTool.Vector:
					// Save undo point
					RaiseRequestNewUndoPoint();

					if (ShapeUnderConstruction == null)
					{
						var vector = new KimonoShapeVector(point.X, point.Y, point.X, point.Y, KimonoShapeState.Editing);
						vector.AddPoint(point);
						ShapeUnderConstruction = vector;
					}
					else
					{
						var vector = ShapeUnderConstruction as KimonoShapeVector;
						if (clicks == 2)
						{
							// Closing vector shape
							vector.State = KimonoShapeState.Finalizing;
						}
						else
						{
							vector.AddPoint(point);
						}
					}
					IgnoreDrag = true;
					break;
				case KimonoTool.Bezier:
					// Save undo point
					RaiseRequestNewUndoPoint();

					if (ShapeUnderConstruction == null)
					{
						var bezier = new KimonoShapeBezier(point.X, point.Y, point.X, point.Y, KimonoShapeState.Editing);
						bezier.AddPoint(point);
						ShapeUnderConstruction = bezier;
					}
					else
					{
						var bezier = ShapeUnderConstruction as KimonoShapeBezier;
						if (clicks == 2)
						{
							// Closing vector shape
							bezier.State = KimonoShapeState.Finalizing;
						}
						else
						{
							bezier.AddPoint(point);
						}
					}
					IgnoreDrag = true;
					break;
				case KimonoTool.Text:
					ShapeUnderConstruction = new KimonoShapeText(point.X, point.Y, point.X, point.Y, KimonoShapeState.Selected);
					break;
			}
		}

		/// <summary>
		/// Handle the user dragging the selected <c>KimonoTool</c> on the sketch's Design Surface.
		/// </summary>
		/// <param name="point">The <c>SKPoint</c> representing the new tool position on the Design Surface.</param>
		public void ToolDrag(SKPoint point)
		{
			// Is the selected shape a group in the edit mode?
			if (SelectedShape is KimonoShapeGroup && SelectedShape.State == KimonoShapeState.Editing)
			{
				// Forward tool events into group
				var group = SelectedShape as KimonoShapeGroup;
				group.ToolDrag(point);
				return;
			}

			// Anything to process?
			if (IgnoreDrag) return;

			// Take action based on the currently selected tool
			switch (Tool)
			{
				case KimonoTool.Cursor:
					if (SelectedShape != null && ! ((int)point.X == (int)ToolDownAt.X && (int)point.Y == (int)ToolDownAt.Y))
					{
						SelectedShape.DragBounds(point);
						RaiseSelectedShapeModified();

						// Starting a drag operation?
						if (!PerformingDrag)
						{
							// Save undo point
							RaiseRequestNewUndoPoint();
							PerformingDrag = true;
						}
					}
					break;
				default:
					ShapeUnderConstruction?.GrowBounds(point);
					break;
			}
		}

		/// <summary>
		/// Handles the user lifting the current <c>KimonoTool</c> off of the sketch's Design Surface.
		/// </summary>
		/// <param name="point">The <c>SKPoint</c> where the user lifted up the tool.</param>
		public void ToolUp(SKPoint point)
		{
			// Is the selected shape a group in the edit mode?
			if (SelectedShape is KimonoShapeGroup && SelectedShape.State == KimonoShapeState.Editing)
			{
				// Forward tool events into group
				var group = SelectedShape as KimonoShapeGroup;
				group.ToolUp(point);
				return;
			}

			// Adjust sketch state
			var addShape = false;
			IgnoreDrag = false;
			PerformingDrag = false;

			// Take action based on the currently selected tool
			switch (Tool)
			{
				case KimonoTool.Cursor:
					break;
				case KimonoTool.Vector:
					if (ShapeUnderConstruction.State == KimonoShapeState.Finalizing)
					{
						ShapeUnderConstruction.EndEditing();
						addShape = true;
					}
					break;
				case KimonoTool.Bezier:
					if (ShapeUnderConstruction.State == KimonoShapeState.Finalizing)
					{
						ShapeUnderConstruction.EndEditing();
						addShape = true;
					}
					break;
				default:
					addShape = (ShapeUnderConstruction.State != KimonoShapeState.Constructing);
					break;
			}

			// Has a shape been completed?
			if (addShape)
			{
				// Prepare to add shape
				var newShape = ShapeUnderConstruction;
				ShapeUnderConstruction = null;
				Tool = KimonoTool.Cursor;

				// Was a shape actually built?
				if (newShape?.Width > 1 && newShape?.Height > 1)
				{
					// Add to drawing and inform caller
					newShape.Select();
					AddShape(newShape);
					SelectedShape = newShape;
					RaiseSelectionChanged(newShape);
				}
			}
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when a new undo point is requested.
		/// </summary>
		public event Kimono.PortfolioEventDelegate RequestNewUndoPoint;

		/// <summary>
		/// Occurs when sketch size changed.
		/// </summary>
		public event Kimono.PortfolioEventDelegate SketchSizeChanged;

		/// <summary>
		/// Occurs when sketch modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate SketchModified;

		/// <summary>
		/// Occurs when image buffer needs refresh.
		/// </summary>
		public event Kimono.PortfolioEventDelegate ImageBufferNeedsRefresh;

		/// <summary>
		/// Occurs when selected shape is modified.
		/// </summary>
		public event Kimono.PortfolioEventDelegate SelectedShapeModified;

		/// <summary>
		/// Occurs when selection changed.
		/// </summary>
		public event Kimono.ShapeEventDelegate SelectionChanged;

		/// <summary>
		/// Occurs when tool changed.
		/// </summary>
		public event Kimono.ToolEventDelegate ToolChanged;

		/// <summary>
		/// Raises the request new undo point event.
		/// </summary>
		internal void RaiseRequestNewUndoPoint()
		{
			// Inform caller of event
			if (RequestNewUndoPoint != null) RequestNewUndoPoint();
		}

		/// <summary>
		/// Raises the sketch size changed event.
		/// </summary>
		internal void RaiseSketchSizeChanged()
		{
			// Inform caller of event
			if (SketchSizeChanged != null) SketchSizeChanged();
		}

		/// <summary>
		/// Raises the sketch modified event.
		/// </summary>
		internal void RaiseSketchModified()
		{
			// Inform caller of event
			if (SketchModified != null) SketchModified();
		}

		/// <summary>
		/// Raises the image buffer needs refresh event.
		/// </summary>
		internal void RaiseImageBufferNeedsRefresh()
		{
			// Inform caller of event
			if (ImageBufferNeedsRefresh != null) ImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Raises the selected shape modified event.
		/// </summary>
		internal void RaiseSelectedShapeModified()
		{
			// Inform caller of event
			if (SelectedShapeModified != null) SelectedShapeModified();
		}

		/// <summary>
		/// Raises the selection changed event.
		/// </summary>
		/// <param name="selected">Selected.</param>
		internal void RaiseSelectionChanged(KimonoShape selected)
		{
			if (SelectionChanged != null) SelectionChanged(selected);
		}

		/// <summary>
		/// Raises the tool changed event.
		/// </summary>
		/// <param name="tool">The new <c>KimonoTool</c> that has been selected.</param>
		internal void RaiseToolChanged(KimonoTool tool)
		{
			if (ToolChanged != null) ToolChanged(tool);
		}
		#endregion

	}
}
