using System;
using System.Collections.Generic;
using SkiaSharp;

namespace KimonoCore
{
	/// <summary>
	/// A <c>KimonoShapeGroup</c> holds a collection of <c>KimonoShapes</c> that can be acted
	/// upon as a group.
	/// </summary>
	public class KimonoShapeGroup : KimonoShape, IKimonoCodeGeneration, IKimonoPropertyConsumer
	{
		#region Private Variables
		/// <summary>
		/// The shape under construction.
		/// </summary>
		private KimonoShape ShapeUnderConstruction = null;

		/// <summary>
		/// The currently selected shape.
		/// </summary>
		private KimonoShape _selectedShape = null;

		/// <summary>
		/// Marks if the group itself is being moved be the user.
		/// </summary>
		private bool Dragging = false;

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

		/// <summary>
		/// If <c>true</c>, the top most shape in the group will act as a mask for the
		/// shapes below it.
		/// </summary>
		private bool _isMaskedGroup = false;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the parent <c>KimonoSketch</c> or <c>KimonoShapeGroup</c> that
		/// this <c>KimonoShapeGroup</c> belongs to.
		/// </summary>
		/// <value>The parent <c>KimonoSketch</c> or <c>KimonoShapeGroup</c>.</value>
		public object Parent { get; set; } = null;

		/// <summary>
		/// Gets the parent sketch by scanning backwards through the chain of parent
		/// objects until a <c>KimonoSketch</c> is reached.
		/// </summary>
		/// <value>The parent <c>KimonoSketch</c>.</value>
		public KimonoSketch ParentSketch
		{
			get
			{
				if (Parent is KimonoSketch)
				{
					return Parent as KimonoSketch;
				}
				else if (Parent is KimonoShapeGroup)
				{
					var group = Parent as KimonoShapeGroup;
					return group.ParentSketch;
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Gets the full path from this group back to the parent <c>KimonoSketch</c>.
		/// </summary>
		/// <value>The path representing the nesting level of this group.</value>
		public string Path
		{
			get
			{
				// Return path based on the parent object type
				if (Parent is KimonoShapeGroup)
				{
					var group = Parent as KimonoShapeGroup;
					return $"{group.Path} > {Name}";
				}
				else if (Parent is KimonoSketch)
				{
					var sketch = Parent as KimonoSketch;
					return $"{sketch.Name} > {Name}";
				}
				else return Name;
			}
		}

		/// <summary>
		/// Gets or sets the shapes.
		/// </summary>
		/// <value>The shapes.</value>
		public List<KimonoShape> Shapes { get; set; } = new List<KimonoShape>();

		/// <summary>
		/// Gets or sets the selected shape.
		/// </summary>
		/// <value>The selected shape.</value>
		public KimonoShape SelectedShape
		{
			get { return _selectedShape; }
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
				else return this;
			}
		}

		/// <summary>
		/// Gets or sets the type of the group.
		/// </summary>
		/// <value>The type of the group as a <c>KimonoShapeGroupType</c>.</value>
		public KimonoShapeGroupType GroupType { get; set; } = KimonoShapeGroupType.Selection;

		/// <summary>
		/// Gets or sets the style of this group.
		/// </summary>
		/// <value>The style as a <c>KimonoStyle</c>.</value>
		public override KimonoStyle Style
		{
			get
			{
				return base.Style;
			}
			set
			{
				// Apply style to all children
				foreach (KimonoShape shape in Shapes)
				{
					shape.Style = value;
				}
				base.Style = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoShapeGroup"/> is visible.
		/// </summary>
		/// <value><c>true</c> if visible; otherwise, <c>false</c>.</value>
		public override bool Visible
		{
			get
			{
				return base.Visible;
			}
			set
			{
				// in construction mode?
				if (State == KimonoShapeState.Constructing)
				{
					// Apply visibility to all children
					foreach (KimonoShape shape in Shapes)
					{
						shape.Visible = value;
					}
				}
				base.Visible = value;
			}
		}

		/// <summary>
		/// Gets a value indicating whether this <see cref="T:KimonoCore.KimonoShapeGroup"/> is editable.
		/// </summary>
		/// <value><c>true</c> if is editable; otherwise, <c>false</c>.</value>
		public override bool IsEditable
		{
			get { return true; }
		}

		/// <summary>
		/// Gets a value indicating whether the selected shape is at the bottom.
		/// </summary>
		/// <value><c>true</c> if selected shape at bottom; otherwise, <c>false</c>.</value>
		public bool SelectedShapeAtBottom
		{
			get { return (SelectedShape?.LayerDepth == 0); }
		}

		/// <summary>
		/// Gets a value indicating whether the selected shape is at the top.
		/// </summary>
		/// <value><c>true</c> if selected shape at top; otherwise, <c>false</c>.</value>
		public bool SelectedShapeAtTop
		{
			get { return (SelectedShape?.LayerDepth == Shapes.Count - 1); }
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoShapeGroup"/> is a boolean construct.
		/// </summary>
		/// <value><c>true</c> if is boolean construct; otherwise, <c>false</c>.</value>
		public bool IsBooleanConstruct { get; set; } = false;

		/// <summary>
		/// Gets or sets the boolean operation that will be applied to this group of objects.
		/// </summary>
		/// <value>The boolean operation as a <c>SKPathOp</c>.</value>
		public SKPathOp BooleanOperation { get; set; } = SKPathOp.Union;

		/// <summary>
		/// Gets or sets the <c>KimonoShape</c> that is acting as a mask for this group.
		/// </summary>
		/// <value>The mask as a <c>KimonoShape</c>.</value>
		public KimonoShape Mask { get; set; } = null;

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:KimonoCore.KimonoShapeGroup"/> is masked group.
		/// </summary>
		/// <value><c>true</c> if is masked group; otherwise, <c>false</c>.</value>
		public bool IsMaskedGroup
		{
			get { return _isMaskedGroup; }
			set
			{
				// Masking or unmasking?
				if (value)
				{
					// Perform mask
					_isMaskedGroup = true;

					// Grab the top most shape
					Mask = Shapes[Shapes.Count - 1];
					Mask.Visible = false;
				}
				else
				{
					// Perform unmask
					_isMaskedGroup = false;

					// Release mask
					if (Mask != null) Mask.Visible = true;
					Mask = null;
				}
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeGroup"/> class.
		/// </summary>
		/// <param name="parent">The parent <c>KimonoSketch</c> or <c>KimonoShapeGroup</c>.</param>
		public KimonoShapeGroup(object parent)
		{
			Initialize(parent);
			State = KimonoShapeState.Constructing;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeGroup"/> class.
		/// </summary>
		/// <param name="parent">Parent.</param>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		public KimonoShapeGroup(object parent, float left, float top, float right, float bottom) : base(left, top, right, bottom)
		{
			Initialize(parent);
			State = KimonoShapeState.Constructing;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoShapeGroup"/> class.
		/// </summary>
		/// <param name="parent">Parent.</param>
		/// <param name="left">Left.</param>
		/// <param name="top">Top.</param>
		/// <param name="right">Right.</param>
		/// <param name="bottom">Bottom.</param>
		/// <param name="state">State.</param>
		public KimonoShapeGroup(object parent, float left, float top, float right, float bottom, KimonoShapeState state) : base(left, top, right, bottom, state)
		{
			Initialize(parent);
		}

		/// <summary>
		/// Initialize the specified parent.
		/// </summary>
		/// <returns>The initialize.</returns>
		/// <param name="parent">Parent.</param>
		private void Initialize(object parent)
		{
			// Set the default properties
			Name = "Group";
			Parent = parent;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Finds a given shape by its Unique ID.
		/// </summary>
		/// <returns>The <c>KimonoShape</c> if found, else <c>null</c>.</returns>
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
		/// Recalculates the group bounds to encompass every <c>KimonoShape</c> inside this group.
		/// </summary>
		public void RecalculateGroupBounds()
		{
			// Anything to process?
			if (Shapes.Count < 1) return;

			// Reset the bounding rect
			Left = Shapes[0].Left;
			Right = Shapes[0].Right;
			Top = Shapes[0].Top;
			Bottom = Shapes[0].Bottom;

			// Process all shapes to find the bounds
			foreach (KimonoShape shape in Shapes)
			{
				//Console.WriteLine("Shape {4} ({0},{1}) - ({2},{3})", shape.Left, shape.Top, shape.Right, shape.Bottom, shape.Name);

				// Adjust bounds for this shape
				if (shape.Left < Left) Left = shape.Left;
				if (shape.Left > Right) Right = shape.Left;
				if (shape.Top < Top) Top = shape.Top;
				if (shape.Top > Bottom) Bottom = shape.Top;

				if (shape.Right < Left) Left = shape.Right;
				if (shape.Right > Right) Right = shape.Right;
				if (shape.Bottom < Top) Top = shape.Bottom;
				if (shape.Bottom > Bottom) Bottom = shape.Bottom;

				//Console.WriteLine("Bounds ({0},{1}) - ({2},{3})\n", Left, Top, Right, Bottom);
			}

			// If the parent is a group, adjust its bounds too
			if (Parent is KimonoShapeGroup)
			{
				var group = Parent as KimonoShapeGroup;
				group.RecalculateGroupBounds();
			}
		}

		/// <summary>
		/// Returns to base parent <c>KimonoSketch</c> for this group.
		/// </summary>
		public void ReturnToSketch()
		{
			// End editing of this group
			EndEditing();

			// If the parent is a group, exit our of editing it too
			if (Parent is KimonoShapeGroup)
			{
				var group = Parent as KimonoShapeGroup;
				group.ReturnToSketch();
			}
		}

		/// <summary>
		/// Selects the given <c>KimonoShape</c>.
		/// </summary>
		/// <param name="shape">Shape.</param>
		public void SelectShape(KimonoShape shape)
		{
			// Clear all existing selections
			DeselectAll();
			SelectedShape = shape;
			shape.Select();

			// Inform caller of change
			ParentSketch.RaiseSelectionChanged(SelectedShape);
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Recalculates the layer depths.
		/// </summary>
		/// <remarks>Layer depths are used to maintain the front to back order of the
		/// <c>KimonoShapes</c> that for the sketch.</remarks>
		public void RecalculateLayerDepths()
		{
			// Anything to process?
			if (GroupType != KimonoShapeGroupType.Collection) return;

			// Set the layer depth of all shapes
			var n = 0;
			foreach (KimonoShape shape in Shapes)
			{
				// Set depth
				shape.LayerDepth = n++;
			}
		}

		/// <summary>
		/// Moves the selected shape to bottom.
		/// </summary>
		public void MoveSelectedShapeToBottom()
		{
			// Anything to process
			if (SelectedShape == null || SelectedShapeAtBottom) return;

			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Move shape
			Shapes.Remove(SelectedShape);
			Shapes.Insert(0, SelectedShape);

			// Set new layer depths
			RecalculateLayerDepths();

			// Update UI
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Moves the selected shape backwards.
		/// </summary>
		public void MoveSelectedShapeBackwards()
		{
			// Anything to process
			if (SelectedShape == null || SelectedShapeAtBottom) return;

			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Move shape
			Shapes.Remove(SelectedShape);
			Shapes.Insert(SelectedShape.LayerDepth - 1, SelectedShape);

			// Set new layer depths
			RecalculateLayerDepths();

			// Update UI
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Moves the selected shape to top.
		/// </summary>
		public void MoveSelectedShapeToTop()
		{
			// Anything to process
			if (SelectedShape == null || SelectedShapeAtTop) return;

			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Move shape
			Shapes.Remove(SelectedShape);
			Shapes.Add(SelectedShape);

			// Set new layer depths
			RecalculateLayerDepths();

			// Update UI
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Moves the selected shape forwards.
		/// </summary>
		public void MoveSelectedShapeForwards()
		{
			// Anything to process
			if (SelectedShape == null || SelectedShapeAtTop) return;

			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

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
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Aligns all shapes in the group at the top.
		/// </summary>
		public void AlignAllTop()
		{
			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Process all shapes
			foreach (KimonoShape shape in Shapes)
			{
				var point = new SKPoint(shape.Left, Top);
				shape.MoveBounds(point);
			}

			// Adjust bounds to match
			RecalculateGroupBounds();

			// Update UI
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Aligns all shapes in the group at the bottom.
		/// </summary>
		public void AlignAllBottom()
		{
			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Process all shapes
			foreach (KimonoShape shape in Shapes)
			{
				var point = new SKPoint(shape.Left, Bottom - shape.Height);
				shape.MoveBounds(point);
			}

			// Adjust bounds to match
			RecalculateGroupBounds();

			// Update UI
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Aligns all shapes in the group to the left.
		/// </summary>
		public void AlignAllLeft()
		{
			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Process all shapes
			foreach (KimonoShape shape in Shapes)
			{
				var point = new SKPoint(Left, shape.Top);
				shape.MoveBounds(point);
			}

			// Adjust bounds to match
			RecalculateGroupBounds();

			// Update UI
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Aligns all shapes in the group to the right.
		/// </summary>
		public void AlignAllRight()
		{
			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Process all shapes
			foreach (KimonoShape shape in Shapes)
			{
				var point = new SKPoint(Right - shape.Width, shape.Top);
				shape.MoveBounds(point);
			}

			// Adjust bounds to match
			RecalculateGroupBounds();

			// Update UI
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Centers all shapes in the group.
		/// </summary>
		public void AlignAllCenter()
		{
			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Process all shapes
			foreach (KimonoShape shape in Shapes)
			{
				var point = new SKPoint(Left + (HorizontalCenter / 2f) - (shape.Width / 2f), Top + (VerticalCenter / 2f)- (shape.Height / 2f));
				shape.MoveBounds(point);
			}

			// Adjust bounds to match
			RecalculateGroupBounds();

			// Update UI
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Center horizontal all shapes in the group.
		/// </summary>
		public void AlignAllCenterHorizontal()
		{
			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Process all shapes
			foreach (KimonoShape shape in Shapes)
			{
				var point = new SKPoint(shape.Left, Top + (VerticalCenter / 2f) - (shape.Height / 2f));
				shape.MoveBounds(point);
			}

			// Adjust bounds to match
			RecalculateGroupBounds();

			// Update UI
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Center vertical all shapes in the group.
		/// </summary>
		public void AlignAllCenterVertical()
		{
			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Process all shapes
			foreach (KimonoShape shape in Shapes)
			{
				var point = new SKPoint(Left + (HorizontalCenter / 2f) - (shape.Width / 2f), shape.Top);
				shape.MoveBounds(point);
			}

			// Adjust bounds to match
			RecalculateGroupBounds();

			// Update UI
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Deletes the given <c>KimonoColor</c> from this group.
		/// </summary>
		/// <param name="color">The <c>KimonoColor</c> to delete.</param>
		public void DeleteColor(KimonoColor color)
		{
			foreach (KimonoShape shape in Shapes)
			{
				// Uncouple this color from any shapes
				if (shape.Style.FillColor == color) shape.Style.FillColor = null;
				if (shape.Style.FrameColor == color) shape.Style.FrameColor = null;

				// Is this a group
				if (shape is KimonoShapeGroup)
				{
					// Yes, cascade the delete through the group
					var group = shape as KimonoShapeGroup;
					group.DeleteColor(color);
				}
			}
		}

		/// <summary>
		/// Deletes the given gradient from the group.
		/// </summary>
		/// <param name="gradient">The <c>KimonoGradient</c> to delete.</param>
		public void DeleteGradient(KimonoGradient gradient)
		{
			foreach (KimonoShape shape in Shapes)
			{
				// Uncouple this color from any shapes
				if (shape.Style.FillGradient == gradient) shape.Style.FillGradient = null;
				if (shape.Style.FrameGradient == gradient) shape.Style.FrameGradient = null;

				// Is this a group
				if (shape is KimonoShapeGroup)
				{
					// Yes, cascade the delete through the group
					var group = shape as KimonoShapeGroup;
					group.DeleteGradient(gradient);
				}
			}
		}

		/// <summary>
		/// Adds the given <c>KimonoShape</c> to the group if it isn't already
		/// a part of the group.
		/// </summary>
		/// <param name="shape">The <c>KimonoShape</c> to add.</param>
		public void AddShape(KimonoShape shape)
		{
			// Add to collection and reset bounds
			if (!ShapeInGroup(shape))
			{
				// Save an undo point
				ParentSketch.RaiseRequestNewUndoPoint();

				// Insert based on layer order
				for (int n = 0; n < Shapes.Count; ++n)
				{
					// At a lower depth?
					if (shape.LayerDepth < Shapes[n].LayerDepth)
					{
						Shapes.Insert(n, shape);
						RecalculateGroupBounds();
						RecalculateLayerDepths();
						return;
					}
				}

				// Lower position not found, add at top
				// of stack
				Shapes.Add(shape);
				RecalculateGroupBounds();
				RecalculateLayerDepths();
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

			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Make a new copy and insert it into the collection
			var newShape = SelectedShape.Clone() as KimonoShape;
			newShape.Name = Kimono.IncrementName(newShape.Name);
			DeselectAll();
			Shapes.Add(newShape);

			// Set new layer depths
			RecalculateLayerDepths();

			// Make this the currently selected shape
			SelectedShape = newShape;
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseSelectionChanged(SelectedShape);
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Removes the given <c>KimonoShape</c> from the group.
		/// </summary>
		/// <param name="shape">Shape.</param>
		public void RemoveShape(KimonoShape shape)
		{
			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Remove from collection and reset bounds
			Shapes.Remove(shape);
			RecalculateGroupBounds();

			// Set new layer depths
			RecalculateLayerDepths();
		}

		/// <summary>
		/// Deletes the selected shape.
		/// </summary>
		public void DeleteSelectedShape()
		{
			// Anything to process
			if (SelectedShape == null) return;

			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Remove shape from selection
			RemoveShape(SelectedShape);
			SelectedShape = null;

			// Set new layer depths
			RecalculateLayerDepths();

			// Inform caller
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseSelectionChanged(null);
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Test to see if the given <c>KimonoShape</c> is a part of this group.
		/// </summary>
		/// <returns><c>true</c>, if in shape is in the group, <c>false</c> otherwise.</returns>
		/// <param name="shape">The <c>KimonoShape</c> to test for.</param>
		public bool ShapeInGroup(KimonoShape shape)
		{
			// Scan all shapes
			foreach (KimonoShape childShape in Shapes)
			{
				// Found?
				if (childShape == shape) return true;
			}

			// Not found
			return false;
		}

		/// <summary>
		/// Deselects all shapes in this group.
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
		/// Groups the shapes.
		/// </summary>
		public void GroupShapes()
		{
			// Take action based on the parent type
			if (Parent is KimonoSketch)
			{
				GroupShapes(Parent as KimonoSketch);
			}
			else if (Parent is KimonoShapeGroup)
			{
				GroupShapes(Parent as KimonoShapeGroup);
			}
		}

		/// <summary>
		/// Groups the shapes in the parent sketch.
		/// </summary>
		/// <param name="sketch">The parent <c>KimonoSketch</c>.</param>
		public void GroupShapes(KimonoSketch sketch)
		{
			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Deselect all shapes in the sketch
			sketch.DeselectAll();

			// Process all shapes
			foreach (KimonoShape shape in Shapes)
			{
				// Remove the shape from the sketch
				sketch.Shapes.Remove(shape);

				// Is this shape a group?
				if (shape is KimonoShapeGroup)
				{
					// Yes, adjust its parent to be this group
					var group = shape as KimonoShapeGroup;
					group.Parent = this;
				}
			}

			// Convert group to a collection and add
			// to sketch
			GroupType = KimonoShapeGroupType.Collection;
			Select();
			sketch.Shapes.Add(this);
			sketch.SelectedShape = this;

			// Set new layer depths
			sketch.RecalculateLayerDepths();
			RecalculateLayerDepths();

			// Inform caller
			sketch.RaiseSketchModified();
			sketch.RaiseSelectionChanged(sketch.SelectedShape);
			sketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Groups the shapes in the parent group.
		/// </summary>
		/// <param name="group">The parent <c>KimonoShapeGroup</c>.</param>
		public void GroupShapes(KimonoShapeGroup group)
		{
			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Deselect all shapes in the group
			group.DeselectAll();

			// Process all shapes
			foreach (KimonoShape shape in Shapes)
			{
				// Remove the shape from the group
				group.Shapes.Remove(shape);

				// Is this shape a group?
				if (shape is KimonoShapeGroup)
				{
					// Yes, adjust its parent to be this group
					var subGroup = shape as KimonoShapeGroup;
					subGroup.Parent = this;
				}
			}

			// Convert group to a collection and add
			// to parent group
			GroupType = KimonoShapeGroupType.Collection;
			Select();
			group.Shapes.Add(this);
			group.SelectedShape = this;

			// Set new layer depths
			group.RecalculateLayerDepths();
			RecalculateLayerDepths();

			// Inform caller
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseSelectionChanged(group.SelectedShape);
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Ungroups the shapes in this group.
		/// </summary>
		public void UngroupShapes()
		{
			// Take action based on the parent type
			if (Parent is KimonoSketch)
			{
				UngroupShapes(Parent as KimonoSketch);
			}
			else if (Parent is KimonoShapeGroup)
			{
				UngroupShapes(Parent as KimonoShapeGroup);
			}
		}

		/// <summary>
		/// Ungroups the shapes in the parent sketch.
		/// </summary>
		/// <param name="sketch">The parent <c>KimonoSketch</c>.</param>
		public void UngroupShapes(KimonoSketch sketch)
		{
			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Deselect everything in the group
			SelectedShape = null;

			// Remove group from collection
			sketch.Shapes.Remove(this);

			// Process all shapes
			foreach (KimonoShape shape in Shapes)
			{
				// Add the shape to the sketch
				sketch.Shapes.Add(shape);
				shape.StartGrouping();
			}

			// Ensure that this group is selected and configured
			GroupType = KimonoShapeGroupType.Selection;
			PlaceUnderConstruction(true);
			sketch.SelectedShape = this;
			sketch.ShapeUnderConstruction = this;

			// Set new layer depths
			sketch.RecalculateLayerDepths();

			// Inform caller
			sketch.RaiseSketchModified();
			sketch.RaiseSelectionChanged(this);
			sketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Ungroups the shapes in the parent group.
		/// </summary>
		/// <param name="group">The parent <c>KimonoShapeGroup</c>.</param>
		public void UngroupShapes(KimonoShapeGroup group)
		{
			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Deselect everything in the group
			SelectedShape = null;

			// Remove group from collection
			group.Shapes.Remove(this);

			// Process all shapes
			foreach (KimonoShape shape in Shapes)
			{
				// Add the shape to the sketch
				group.Shapes.Add(shape);
				shape.StartGrouping();
			}

			// Ensure that this group is selected
			GroupType = KimonoShapeGroupType.Selection;
			PlaceUnderConstruction(true);
			group.SelectedShape = this;
			group.ShapeUnderConstruction = this;

			// Set new layer depths
			group.RecalculateLayerDepths();

			// Inform caller
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseSelectionChanged(this);
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Duplicates the shapes in a selection group.
		/// </summary>
		public void DuplicateShapes()
		{
			// Is this a raw selection?
			if (GroupType == KimonoShapeGroupType.Collection) return;

			// Take action based on the parent type
			if (Parent is KimonoSketch)
			{
				DuplicateShapes(Parent as KimonoSketch);
			}
			else if (Parent is KimonoShapeGroup)
			{
				DuplicateShapes(Parent as KimonoShapeGroup);
			}
		}

		/// <summary>
		/// Duplicates the shapes in this selection group into the parent sketch.
		/// </summary>
		/// <param name="sketch">The parent <c>KimonoSketch</c>.</param>
		public void DuplicateShapes(KimonoSketch sketch)
		{
			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Process all shapes
			for (int n = 0; n < Shapes.Count; ++n)
			{
				// Create new shape instance
				var newShape = Shapes[n].Clone() as KimonoShape;
				newShape.Name = Kimono.IncrementName(newShape.Name);
				Shapes[n].Unselect();

				// Add the shape to the sketch and group
				sketch.Shapes.Add(newShape);
				Shapes[n] = newShape;
			}

			// Set new layer depths
			sketch.RecalculateLayerDepths();

			// Inform caller
			sketch.RaiseSketchModified();
			sketch.RaiseSelectionChanged(this);
			sketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Duplicates the shapes in this selection group into the parent group.
		/// </summary>
		/// <param name="group">The parent <c>KimonoShapeGroup</c>.</param>
		public void DuplicateShapes(KimonoShapeGroup group)
		{
			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Process all shapes
			for (int n = 0; n < Shapes.Count; ++n)
			{
				// Create new shape instance
				var newShape = Shapes[n].Clone() as KimonoShape;
				newShape.Name = Kimono.IncrementName(newShape.Name);
				Shapes[n].Unselect();

				// Add the shape to the sketch and group
				group.Shapes.Add(newShape);
				Shapes[n] = newShape;
			}

			// Set new layer depths
			group.RecalculateLayerDepths();

			// Inform caller
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseSelectionChanged(this);
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Deletes the shapes in this selection group.
		/// </summary>
		public void DeleteShapes()
		{
			// Is this a raw selection?
			if (GroupType == KimonoShapeGroupType.Collection) return;

			// Take action based on the parent type
			if (Parent is KimonoSketch)
			{
				DeleteShapes(Parent as KimonoSketch);
			}
			else if (Parent is KimonoShapeGroup)
			{
				DeleteShapes(Parent as KimonoShapeGroup);
			}
		}

		/// <summary>
		/// Deletes the shapes in this selection group from the parent sketch.
		/// </summary>
		/// <param name="sketch">The parent <c>KimonoSketch</c>.</param>
		public void DeleteShapes(KimonoSketch sketch)
		{
			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Process all shapes
			foreach (KimonoShape shape in Shapes)
			{
				// Remove the shape from the sketch
				sketch.Shapes.Remove(shape);
			}

			// Set new layer depths
			sketch.RecalculateLayerDepths();

			// Deselect all shapes in the sketch
			sketch.DeselectAll();

			// Inform caller
			sketch.RaiseSketchModified();
			sketch.RaiseSelectionChanged(null);
			sketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Deletes the shapes in this selection group from the parent group.
		/// </summary>
		/// <param name="group">The parent <c>KimonoShapeGroup</c>.</param>
		public void DeleteShapes(KimonoShapeGroup group)
		{
			// Save an undo point
			ParentSketch.RaiseRequestNewUndoPoint();

			// Process all shapes
			foreach (KimonoShape shape in Shapes)
			{
				// Remove the shape from the group
				group.Shapes.Remove(shape);
			}

			// Set new layer depths
			group.RecalculateLayerDepths();

			// Deselect all shapes in the sketch
			group.DeselectAll();

			// Inform caller
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseSelectionChanged(null);
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Applies the move and scale adjustments to all <c>KimonoShapes</c> inside this group.
		/// </summary>
		private void ApplyMoveAndScale()
		{
			// Calculate origin offest
			var originOffest = new SKSize(PreviousRect.Left - Rect.Left, PreviousRect.Top - Rect.Top);

			// Get new center
			var center = Center;

			// Calculate offsets
			var offest = new SKSize(Rect.Left - PreviousRect.Left, Rect.Top - PreviousRect.Top);

			// Apply offest to all shapes
			foreach (KimonoShape shape in Shapes)
			{
				shape.ChangeBounds(shape.Left + offest.Width, shape.Top + offest.Height, shape.Right + offest.Width, shape.Bottom + offest.Height);
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
				// Apply offest to all shapes
				foreach (KimonoShape shape in Shapes)
				{
					// Get adjusted x,y
					var x = shape.Left - PreviousCenter.X + originOffest.Width;
					var y = shape.Top - PreviousCenter.Y + originOffest.Height;
					var x1 = shape.Right - PreviousCenter.X + originOffest.Width;
					var y1 = shape.Bottom - PreviousCenter.Y + originOffest.Height;

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
		}
		#endregion

		#region Override Methods
		/// <summary>
		/// Removes the property connection.
		/// </summary>
		/// <param name="connection">The `KimonoPropertyConnection` to remove.</param>
		public override void RemovePropertyConnection(KimonoPropertyConnection connection)
		{
			// Remove connection
			base.RemovePropertyConnection(connection);

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
		public override void RemoveProperty(KimonoProperty property)
		{
			// Remove any connection that is using this property
			base.RemoveProperty(property);

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
		/// Converts the group of shapes to a path.
		/// </summary>
		/// <returns>The group of shapes as a <c>SKPath</c>.</returns>
		public override SKPath ToPath()
		{
			// Update any attached properties
			EvaluateConnectedProperties();

			var path = new SKPath();

			// Add all of the child paths
			foreach (KimonoShape shape in Shapes)
			{
				path.AddPath(shape.ToPath(), SKPath.AddMode.Append);
			}

			// Return path
			return path;
		}

		/// <summary>
		/// Draw all the <c>KimonoShapes</c> that are part of this group into the given
		/// Skia canvas.
		/// </summary>
		/// <param name="canvas">The <c>SKCanvas</c> to draw into.</param>
		public override void Draw(SKCanvas canvas)
		{
			// Update any attached properties
			EvaluateConnectedProperties();

			// Rotated?
			if (RotationDegrees > 0)
			{
				// Save current state and apply rotation
				canvas.Save();
				canvas.RotateDegrees(RotationDegrees, HorizontalCenter, VerticalCenter);
			}

			// Is masked?
			if (IsMaskedGroup && (State == KimonoShapeState.Selected || State == KimonoShapeState.Unselected))
			{
				// Apply a clipping path
				canvas.Save();
				if (Mask !=null) canvas.ClipPath(Mask.ToPath(), SKClipOperation.Intersect, true);
			}

			// Draw all child shapes
			if (Visible)
			{
				// Is this a boolean construct?
				if (IsBooleanConstruct && State != KimonoShapeState.Editing)
				{
					// Apple the boolean operation to the group of
					// shapes
					SKPath path = null;
					foreach (KimonoShape shape in Shapes)
					{
						// First shape in the group?
						if (path == null)
						{
							// Yes, set initial path
							path = shape.ToPath();
						}
						else
						{
							// No, apply boolean operation on the set of
							// paths
							path = path.Op(shape.ToPath(), BooleanOperation);
						}
					}

					// Draw resulting boolean group
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
				else
				{
					// Draw each shape in the group
					foreach (KimonoShape shape in Shapes)
					{
						shape.Draw(canvas);
					}
				}
			}

			// If a new shape is being added to the document,
			// draw it as well
			ShapeUnderConstruction?.Draw(canvas);

			// Is masked?
			if (IsMaskedGroup && (State == KimonoShapeState.Selected || State == KimonoShapeState.Unselected))
			{
				// Release clipping path
				canvas.Restore();
			}

			// Draw a bounding box when in the editing mode
			if (State == KimonoShapeState.Editing)
			{
				// Define the paint style
				var paint = new SKPaint()
				{
					Style = SKPaintStyle.Stroke,
					StrokeWidth = 1,
					Color = KimonoColor.Ice
				};

				// Draw bounding frame
				canvas.DrawRect(Rect, paint);
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
		/// Starts editing this group.
		/// </summary>
		public override void StartEditing()
		{
			base.StartEditing();

			// If a mask is in place, make it visible
			if (Mask != null) Mask.Visible = true;

			// Inform caller
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseSelectionChanged(null);
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Ends editing this group.
		/// </summary>
		public override void EndEditing()
		{
			DeselectAll();
			base.EndEditing();

			// If a mask is in place, make it invisible
			if (Mask != null) Mask.Visible = false;

			// Inform caller
			ParentSketch.RaiseSketchModified();
			ParentSketch.RaiseSelectionChanged(this);
			ParentSketch.RaiseImageBufferNeedsRefresh();
		}

		/// <summary>
		/// Test to see if the given point is inside the bounds of this group.
		/// </summary>
		/// <returns><c>true</c>, if the point was in bounds, <c>false</c> otherwise.</returns>
		/// <param name="point">The <c>SKPoint</c> to test for.</param>
		public override bool PointInBound(SKPoint point)
		{
			// In the editing mode?
			if (State == KimonoShapeState.Editing)
			{
				// Yes, see if any child shape has been hit
				SelectedShape = null;
				foreach (KimonoShape shape in Shapes)
				{
					if (shape.PointInBound(point))
					{
						SelectedShape = shape;
						return true;
					}
				}
			}

			// Default to parent
			return base.PointInBound(point);
		}

		/// <summary>
		/// Drags the bounds of this group.
		/// </summary>
		/// <param name="point">The new location as a <c>SKPoint</c>.</param>
		public override void DragBounds(SKPoint point)
		{
			// In the editing mode?
			if (State == KimonoShapeState.Editing || State == KimonoShapeState.Finalizing)
			{
				// Is a shape available?
				if (SelectedShape != null)
				{
					SelectedShape.DragBounds(point);
					RecalculateGroupBounds();
				}
				return;
			}

			// Allow parent to move and size bounds
			Dragging = true;
			base.DragBounds(point);
			Dragging = false;
		}

		/// <summary>
		/// Update the bouds of this group when they have changed from either a move or a drag
		/// operation.
		/// </summary>
		public override void BoundsChanged()
		{
			var shouldMoveAndScale = (Dragging) ? true : (!(State == KimonoShapeState.Editing || State == KimonoShapeState.Finalizing || State == KimonoShapeState.Constructing));

			if (shouldMoveAndScale)
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
			else
			{
				// Allow base to handle bounds
				base.BoundsChanged();
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
			sourceCode += "//-----------------------------------------------------------------------------\n" +
				$"// Define {Name} shape group paths\n" +
				$"var {pathName} = new SKPath();\n";

			// Add all of the child paths
			foreach (KimonoShape shape in Shapes)
			{
				// Emit the shape's path
				sourceCode += shape.ToSkiaSharpPath();

				// Add path to group path
				sourceCode += $"{pathName}.AddPath({shape.ElementName}Path, SKPath.AddMode.Append);\n";
			}

			// Close group's code
			sourceCode += "//-----------------------------------------------------------------------------\n\n";

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

			// Draw with Skia
			sourceCode += "//-----------------------------------------------------------------------------\n" +
				$"// Draw {Name} shape group\n";

			// Rotated?
			if (RotationDegrees > 0)
			{
				// Save current state and apply rotation
				sourceCode += $"canvas.Save();\n" +
					$"canvas.RotateDegrees({RotationDegrees}f, {HorizontalCenter}f, {VerticalCenter}f);\n";
			}

			// Is masked?
			if (IsMaskedGroup && (State == KimonoShapeState.Selected || State == KimonoShapeState.Unselected))
			{
				// Apply a clipping path
				sourceCode += $"// Apply shape {Mask.Name} as a mask to {Name} shape group\n" +
					$"canvas.Save();\n\n";
				if (Mask != null)
				{
					// Emit mask's path
					sourceCode += Mask.ToSkiaSharpPath();

					// Apply mask
					sourceCode += $"canvas.ClipPath({Mask.ElementName}Path, SKClipOperation.Intersect, true);\n\n";
				}
			}

			// Draw all child shapes
			if (Visible)
			{
				// Is this a boolean construct?
				if (IsBooleanConstruct && State != KimonoShapeState.Editing)
				{
					// Update any attached properties
					EvaluateConnectedProperties();

					// Apple the boolean operation to the group of
					// shapes
					var firstPath = true;
					foreach (KimonoShape shape in Shapes)
					{
						// Emit the shape's path
						sourceCode += shape.ToSkiaSharpPath();

						// First shape in the group?
						if (firstPath)
						{
							// Yes, set initial path
							sourceCode += $"var {pathName} = {shape.ElementName}Path;\n\n";
						}
						else
						{
							// No, apply boolean operation on the set of
							// paths
							sourceCode += $"{pathName} = {pathName}.Op({shape.ElementName}Path, SKPathOp.{BooleanOperation});\n\n";
						}

						// Set state
						firstPath = false;
					}

					// Needs spacer?
					if (Style.HasFill || Style.HasFrame)
					{
						sourceCode += $"\n// Draw {Name} boolean shape\n";
					}

					// Draw resulting boolean group
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
				else
				{
					// Update any attached properties
					EvaluateConnectedProperties();

					// Draw each shape in the group
					foreach (KimonoShape shape in Shapes)
					{
						sourceCode += shape.ToCSharp(CodeOutputLibrary.SkiaSharp)+"\n";
					}
				}
			}

			// Is masked?
			if (IsMaskedGroup && (State == KimonoShapeState.Selected || State == KimonoShapeState.Unselected))
			{
				// Release clipping path
				sourceCode += $"canvas.Restore();\n";
			}

			// Rotated?
			if (RotationDegrees > 0)
			{
				// Restore previous state
				sourceCode += $"canvas.Restore();\n";
			}

			// Close group's code
			sourceCode += "//-----------------------------------------------------------------------------\n\n";

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

			// Draw with KimonoCore
			sourceCode += "//-----------------------------------------------------------------------------\n" +
				$"// Build {Name} shape group\n" +
				$"var {ElementName} = new KimonoShapeRect({Left}f, {Top}f, {Right}f, {Bottom}f)" + "{" +
				$"\n\tRotationDegrees = {RotationDegrees}," +
				$"\n\tVisible = {Visible.ToString().ToLower()}," +
				$"\n\tStyle = {Style.ElementName}," +
				$"\n\tGroupType = KimonoShapeGroupType.{GroupType}" +
				"};\n\n";


			// Add all shapes to group
			sourceCode += $"// Add shapes {Name} shape group\n";
			foreach (KimonoShape shape in Shapes)
			{
				// Emit source for shape
				sourceCode += shape.ToCSharp(CodeOutputLibrary.KimonoCore);

				// Add shape to group
				sourceCode += $"{ElementName}.AddShape({shape.ElementName});\n\n";
			}

			// Configure group
			sourceCode += $"// Add shapes {Name} shape group\n" +
				$"{ElementName}.IsBooleanConstruct = {IsBooleanConstruct.ToString().ToLower()};\n" +
				$"{ElementName}.BooleanOperation = SKPathOp.{BooleanOperation};\n" +
				$"{ElementName}.IsMaskedGroup = {IsMaskedGroup.ToString().ToLower()};\n";

			// Draw group
			sourceCode += $"\n// Draw {Name} shape group\n" +
				$"{ElementName}.Draw(canvas);\n" +
				"//-----------------------------------------------------------------------------\n\n";

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
					// TODO: Add ObiScript output
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
		/// Relinks the shape after a clone operation.
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
		/// <returns>A deep clone of this <c>KimonoShapeGroup</c>.</returns>
		public override KimonoBounds Clone()
		{
			//Console.WriteLine(">> Cloning: {0}", Name);

			// Duplicate shape
			var newShape = new KimonoShapeGroup(this.Parent, this.Left, this.Top, this.Right, this.Bottom, this.State)
			{
				UniqueID = this.UniqueID,
				Name = this.Name,
				GroupType = this.GroupType,
				SelectedShape = this.SelectedShape,
				Parent = this.Parent,
				Style = CloneAttachedStyle(),
				Visible = this.Visible,
				LayerDepth = this.LayerDepth,
				IsBooleanConstruct = this.IsBooleanConstruct,
				BooleanOperation = this.BooleanOperation
			};

			// Clone all child shapes
			foreach (KimonoShape shape in Shapes)
			{
				var shapeCopy = shape.Clone() as KimonoShape;
				newShape.RelinkShape(shapeCopy);
				newShape.Shapes.Add(shapeCopy);
			}

			// Clone control points
			foreach (KimonoHandle handle in ControlPoints)
			{
				// Duplicate handle and add to collection
				newShape.ControlPoints.Add(handle.Clone());
			}

			// Match selection
			if (SelectedShape != null)
			{
				// Was a current group in progress?
				if (SelectedShape is KimonoShapeGroup && SelectedShape.State == KimonoShapeState.Constructing)
				{
					var group = SelectedShape as KimonoShapeGroup;
					var groupCopy = new KimonoShapeGroup(newShape);
					newShape.SelectedShape = groupCopy;
					newShape.ShapeUnderConstruction = groupCopy;

					// Clone in items
					foreach (KimonoShape shape in group.Shapes)
					{
						groupCopy.Shapes.Add(newShape.FindShape(shape.UniqueID));
					}
					groupCopy.RecalculateGroupBounds();
					groupCopy.AddHandles(KimonoShapeState.Constructing);
				}
				else
				{
					// Find matching shape in clone
					newShape.SelectedShape = newShape.FindShape(SelectedShape.UniqueID);
					newShape.SelectedShape.AddHandles(newShape.SelectedShape.State);
				}
			}

			// Was a shape under construction?
			if (ShapeUnderConstruction != null && !(ShapeUnderConstruction is KimonoShapeGroup))
			{
				// Clone the under construction shape too
				newShape.ShapeUnderConstruction = ShapeUnderConstruction.Clone() as KimonoShape;
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

		#region Tool Events
		// -----------------------------------------------------------------------------------------------------
		// NOTICE:
		// Changes to the code in the <c>KimonoShapeGroup<c> Tool Events will also need to be made to the 
		// <c>KimonoSketch<c>'s Tool Events section as well.
		// -----------------------------------------------------------------------------------------------------

		/// <summary>
		/// Handles the user placing the current <c>KimonoTool</c> down on the group's
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
			if (ParentSketch.Tool != KimonoTool.Cursor && SelectedShape != null)
			{
				// Clear existing selection
				DeselectAll();
				ParentSketch.RaiseSelectionChanged(null);
			}

			//Console.WriteLine("-- {0} Tool Down --", Name);

			// Take action based on the currently selected tool
			switch (ParentSketch.Tool)
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
										ParentSketch.RaiseSelectionChanged(SelectedShape);
										IgnoreDrag = true;
										return;
									}
								}
							}

							// Deselect the group and its shapes
							DeselectAll();
							ParentSketch.RaiseSelectionChanged(null);
							return;
						}
						else if (SelectedShape != null && !SelectedShape.PointInBound(point))
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
									ParentSketch.RaiseSelectionChanged(SelectedShape);
									group.PlaceUnderConstruction(true);
									IgnoreDrag = true;
									return;
								}
							}

							// Deselect the current shapes
							DeselectAll();
							ParentSketch.RaiseSelectionChanged(null);
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
						ParentSketch.RaiseSelectionChanged(SelectedShape);
						return;
					}

					// Deselect any existing shape
					DeselectAll();
					ParentSketch.RaiseSelectionChanged(null);

					// Scan all shapes
					for (int n = Shapes.Count - 1; n >= 0; n--)
					{
						if (Shapes[n].PointInBound(point))
						{
							// Select the hit shape
							SelectedShape = Shapes[n];
							SelectedShape.Select();
							ParentSketch.RaiseSelectionChanged(SelectedShape);
							return;
						}
					}

					// Nothing selected, show data for group
					ParentSketch.RaiseSelectionChanged(this);

					// Edit editing?
					if (clicks == 2 & State == KimonoShapeState.Editing) EndEditing();
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
					ParentSketch.RaiseRequestNewUndoPoint();

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
					ParentSketch.RaiseRequestNewUndoPoint();

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

			//Console.WriteLine("-- {0} Tool Drag --", Name);

			// Take action based on the currently selected tool
			switch (ParentSketch.Tool)
			{
				case KimonoTool.Cursor:
					if (SelectedShape != null && !((int)point.X == (int)ToolDownAt.X && (int)point.Y == (int)ToolDownAt.Y))
					{
						SelectedShape.DragBounds(point);
						ParentSketch.RaiseSelectedShapeModified();

						// Starting a drag operation?
						if (!PerformingDrag)
						{
							// Save undo point
							ParentSketch.RaiseRequestNewUndoPoint();
							PerformingDrag = true;
						}
					}
					break;
				default:
					ShapeUnderConstruction?.GrowBounds(point);
					break;
			}
		}

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

			// Set state
			var addShape = false;
			IgnoreDrag = false;
			PerformingDrag = false;

			//Console.WriteLine("-- {0} Tool Up --", Name);

			// Take action based on the currently selected tool
			switch (ParentSketch.Tool)
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
					addShape = true;
					break;
			}

			// Has a shape been completed?
			if (addShape)
			{
				// Prepare to add shape
				var newShape = ShapeUnderConstruction;
				ShapeUnderConstruction = null;
				ParentSketch.Tool = KimonoTool.Cursor;

				// Was a shape actually built?
				if (newShape?.Width > 1 && newShape?.Height > 1)
				{
					// Add to drawing and inform caller
					newShape.Select();
					AddShape(newShape);
					SelectedShape = newShape;
					ParentSketch.RaiseSelectionChanged(newShape);
					ParentSketch.RaiseSketchModified();
				}
			}
			else
			{
				// The groups bounds might have changed
				RecalculateGroupBounds();
			}
		}
		#endregion
	}
}
