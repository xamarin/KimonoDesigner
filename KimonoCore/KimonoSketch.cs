using System;
using System.Collections.Generic;
using SkiaSharp;
using TextBase;

namespace KimonoCore
{
	/// <summary>
	/// Holds a collection of <c>KimonoShapes</c> that are used to create a given
	/// image using Skia.
	/// </summary>
	[Table("Sketch")]
	public partial class KimonoSketch : IKimonoCodeGeneration
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
		[PrimaryKey]
		public string UniqueID { get; set; } = Guid.NewGuid().ToString();

		/// <summary>
		/// Gets or sets the portfolio that this sketch belongs to.
		/// </summary>
		/// <value>The parent `KimonoPortfolio`.</value>
		[Ignore]
		public KimonoPortfolio Portfolio { get; set; } = null;

		/// <summary>
		/// Gets or sets the name of the element as it will be called in generated source
		/// code.
		/// </summary>
		/// <value>The name of the element.</value>
		internal string ElementName { get; set; } = "";

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; } = "Untitled";

		/// <summary>
		/// When converting this Sketch to source code, ouput a method that draws into the
		/// given SkiaSharp Canvas.
		/// </summary>
		/// <value><c>true</c> if generate code to ouput to canvas; otherwise, <c>false</c>.</value>
		public bool GenerateCodeToOuputToCanvas { get; set; } = true;

		/// <summary>
		/// When converting this Sketch to source code, output a method that returns the SkiaSharp
		/// Data (`SKData[]`) representing the Sketch.
		/// </summary>
		/// <value><c>true</c> if generate code to ouput skia data; otherwise, <c>false</c>.</value>
		public bool GenerateCodeToOuputSkiaData { get; set; } = false;

		/// <summary>
		/// When converting this Sketch to source code, output a method that returns the Sketch as
		/// a OS specific bitmap image.
		/// </summary>
		/// <value><c>true</c> if generate code to ouput bitmap image; otherwise, <c>false</c>.</value>
		public bool GenerateCodeToOuputBitmapImage { get; set; } = true;

		/// <summary>
		/// When converting this Sketch to source code, output a method that returns the Sketch as class
		/// based on the `SkiaSharp.Views` extension library.
		/// </summary>
		/// <value><c>true</c> if generate code to ouput to skia sharp views; otherwise, <c>false</c>.</value>
		public bool GenerateCodeToOuputToSkiaSharpViews { get; set; } = false;

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
		[Serializer("SKColor")]
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
		[Children]
		public List<KimonoShape> Shapes { get; set; } = new List<KimonoShape>();

		/// <summary>
		/// Gets or sets the tool.
		/// </summary>
		/// <value>The tool.</value>
		[Ignore]
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
		[Ignore]
		public KimonoShape SelectedShape
		{
			get {return _selectedShape;}
			set { _selectedShape = value; }
		}

		/// <summary>
		/// Gets the deepest selected shape in a chain of groups.
		/// </summary>
		/// <value>The deeply selected shape.</value>
		[Ignore]
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
		[Ignore]
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
		[Ignore]
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
		[Ignore]
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
		[Ignore]
		public bool CanAlignShapes
		{
			get { return (DeeplySelectedShape is KimonoShapeGroup && DeeplySelectedShape.State == KimonoShapeState.Constructing);}
		}

		/// <summary>
		/// Gets a value indicating whether the selection of shapes can be grouped.
		/// </summary>
		/// <value><c>true</c> if can group shapes; otherwise, <c>false</c>.</value>
		[Ignore]
		public bool CanGroupShapes
		{
			get { return (DeeplySelectedShape is KimonoShapeGroup && DeeplySelectedShape.State == KimonoShapeState.Constructing); }
		}

		/// <summary>
		/// Gets a value indicating whether the selection of shapes can be ungrouped.
		/// </summary>
		/// <value><c>true</c> if can group shapes; otherwise, <c>false</c>.</value>
		[Ignore]
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
		/// Draw this sketch into the give SkiaSharp canvas.
		/// </summary>
		/// <param name="canvas">The `SKCanvas` to draw into.</param>
		public void Draw(SKCanvas canvas)
		{
			// Draw all shapes into the canvas
			foreach (KimonoShape shape in Shapes)
			{
				shape.Draw(canvas);
			}

			// If a new shape is being added to the document,
			// draw it as well
			ShapeUnderConstruction?.Draw(canvas);
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
		/// Selects all of the shapes in this sketch.
		/// </summary>
		public void SelectAll()
		{
			// Make a new group
			var group = new KimonoShapeGroup(this);
			SelectedShape = group;
			ShapeUnderConstruction = SelectedShape;

			// Process all shapes
			foreach(KimonoShape shape in Shapes)
			{
				// Add the hit shape to the group
				group.AddShape(shape);
				shape.StartGrouping();
			}

			// Update UI
			group.PlaceUnderConstruction(true);
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
		/// Converts the shapes path to C# Skia based code.
		/// </summary>
		/// <returns>The path as code.</returns>
		public virtual string ToSkiaSharpPath()
		{
			var sourceCode = "";

			// Assemble path name
			if (ElementName == "") KimonoCodeGenerator.MakeElementName(Name);
			var pathName = $"{ElementName}Path";

			// Define path with Skia
			sourceCode += "//-----------------------------------------------------------------------------\n" +
				$"// Define {Name} Sketch paths\n" +
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
		public virtual string ToSkiaSharp()
		{
			var sourceCode = "";

			// Draw each shape in the group
			foreach (KimonoShape shape in Shapes)
			{
				sourceCode += shape.ToCSharp(CodeOutputLibrary.SkiaSharp) + "\n";
			}

			// Return code
			return sourceCode;
		}

		/// <summary>
		/// Converts this shape C# using the KimonoCore library.
		/// </summary>
		/// <returns>The kimono core.</returns>
		public virtual string ToKimonoCore()
		{
			var sourceCode = "";

			// Draw with KimonoCore
			sourceCode += $"// Build {Name} shape\n" +
				$"var {ElementName} = new KimonoSketch({Name}, {Width}f, {Height}f)" + "{" +
				$"\n\tDrawCanvas = {DrawCanvas.ToString().ToLower()}," +
				$"\n\tCanvasColor = {KimonoCodeGenerator.ColorToCode(CodeOutputLibrary.SkiaSharp,CanvasColor)}" +
				"};\n\n";

			sourceCode += "//-----------------------------------------------------------------------------\n" +
				$"// Define {Name} Sketch shapes\n";

			// Add shapes
			foreach (KimonoShape shape in Shapes)
			{
				var shapeCode = shape.ToCSharp(CodeOutputLibrary.KimonoCore);
				sourceCode += shapeCode.Replace($"{shape.ElementName}.Draw(canvas);\n", $"Shapes.Add({shape.ElementName});\n\n");
			}

			// Close group's code
			sourceCode += "//-----------------------------------------------------------------------------\n\n";

			// Return code
			return sourceCode;
		}

		/// <summary>
		/// Build the method to draw into a specific SkiaSharp Canvas in C# source code.
		/// </summary>
		/// <returns>The source code for the method.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public virtual string BuildCsharpToCanvasMethod(CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Start method
			sourceCode += "/// <summary>\n" +
				$"/// Draw the {Name} sketch into the given SkiaSharp canvas.\n" +
				"/// </summary>\n" +
				"/// <param name=\"canvas\">The <c>SKCanvas</c> to draw the sketch into.</param>\n";
			sourceCode += (GenerateCodeToOuputToCanvas) ? "public" : "private";
			sourceCode += $" void Draw{ElementName}(SKCanvas canvas)" + "{\n";

			// Add body of method
			if (Shapes.Count > 0)
			{
				// Take action based on the library
				switch (outputLibrary)
				{
					case CodeOutputLibrary.SkiaSharp:
						sourceCode += KimonoCodeGenerator.IncreaseIndentLevel(ToSkiaSharp());
						break;
					case CodeOutputLibrary.KimonoCore:
						sourceCode += KimonoCodeGenerator.IncreaseIndentLevel(ToKimonoCore());
						break;
				}
			}

			// End method
			sourceCode += "\n}\n";

			// Return code
			return sourceCode;
		}

		/// <summary>
		/// Bulids the method to convert this Sketch to SkiaSharp data (`SKData`).
		/// </summary>
		/// <returns>The Sketch as `SKData`.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public virtual string BuildCsharpToSkiaDataMethod(CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";
			var clearColor = "";

			// Drawing background?
			if (DrawCanvas)
			{
				// Yes, make color
				clearColor = KimonoCodeGenerator.ColorToCode(outputLibrary, CanvasColor);
			}

			// Start method
			sourceCode += "/// <summary>\n" +
				$"/// Convert the {Name} sketch to a png encoded SkiaSharp data object.\n" +
				"/// </summary>\n" +
				"/// <returns>The Sketch as a <c>SKData</c> object.</returns>\n";
			sourceCode += (GenerateCodeToOuputSkiaData) ? "public" : "private";
			sourceCode += $" SKData {ElementName}ToData()" + "{\n";

			// Draw all of the elements into the image buffer
			sourceCode += $"\tusing (var surface = SKSurface.Create({(int)Width}, {(int)Height}, SKImageInfo.PlatformColorType, SKAlphaType.Premul))\n" +
				"\t{\n" +
				"\t\t// Create Canvas\n" +
				"\t\tSKCanvas canvas = surface.Canvas;\n" +
				$"\t\tcanvas.Clear({clearColor});\n\n" +
				"\t\t// Draw all shapes into the canvas\n" +
				$"\t\tDraw{ElementName}(canvas);\n\n" +
				"\t\t// Return data from sketch\n" +
				"\t\treturn surface.Snapshot().Encode();\n" +
				"\t}";

			// End method
			sourceCode += "\n}\n";

			// Return code
			return sourceCode;
		}

		/// <summary>
		/// Bulids the method to convert this Sketch to OS specific bitmap image format.
		/// </summary>
		/// <returns>Sketch as a platform specific image.</returns>
		/// <param name="outputOS">Output os.</param>
		public virtual string BuildCsharpToBitmapImage(CodeOutputOS outputOS)
		{
			var sourceCode = "";
			var imageType = "";

			// Set the output image type
			switch (outputOS)
			{
				case CodeOutputOS.Android:
					imageType = "Bitmap";
					break;
				case CodeOutputOS.iOS:
				case CodeOutputOS.tvOS:
					imageType = "UIImage";
					break;
				case CodeOutputOS.macOS:
					imageType = "NSImage";
					break;
				case CodeOutputOS.Windows:
                case CodeOutputOS.WindowsWPF:
                    imageType = "Bitmap";
                    break;
				case CodeOutputOS.WindowsUWP:
					imageType = "BitmapImage";
					break;
			}

			// Start method
			sourceCode += "/// <summary>\n" +
				$"/// Convert the {Name} sketch to a bitmap image.\n" +
				"/// </summary>\n" +
				"/// <returns>The sketch as a platform specific bitmap image.</returns>\n";
			sourceCode += (GenerateCodeToOuputBitmapImage) ? "public" : "private";
			sourceCode += $" {imageType} {ElementName}ToImage()" + "{\n" +
				"\t// Get image data from sketch\n" +
				$"\tvar skPngdata = {ElementName}ToData();\n\n";

			// Export image based on OS type
			switch (outputOS)
			{
				case CodeOutputOS.Android:
					sourceCode += "\t// Convert to image and return\n" +
						"\tvar imageBytes = skPngdata.ToArray();\n" +
						"\treturn BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);";
					break;
				case CodeOutputOS.iOS:
				case CodeOutputOS.tvOS:
					sourceCode += "\t// Convert to image and return\n" +
						"\tvar data = NSData.FromBytes(skPngdata.Data, (nuint)skPngdata.Size);\n" +
						"\treturn new UIImage(data);";
					break;
				case CodeOutputOS.macOS:
					sourceCode += "\t// Convert to image and return\n" +
						"\tvar data = NSData.FromBytes(skPngdata.Data, (nuint)skPngdata.Size);\n" +
						"\treturn new NSImage(data);";
					break;
				case CodeOutputOS.Windows:
                case CodeOutputOS.WindowsWPF:
                    sourceCode += "\t// Convert to image and return\n" +
                        "\tvar imageBytes = skPngdata.ToArray();\n" +
                        "\tImageConverter ic = new ImageConverter();\n" +
                        "\tImage img = (Image)ic.ConvertFrom(imageBytes);\n" +
                        "\tBitmap bitmap = new Bitmap(img);\n" +
                        "\treturn bitmap;";
                    break;
                case CodeOutputOS.WindowsUWP:
                    sourceCode += "\t// Convert to image and return\n" +
                        "\tvar imageBytes = skPngdata.ToArray();\n" +
                        "\tvar image = new BitmapImage();\n" +
                        "\tInMemoryRandomAccessStream ms = new InMemoryRandomAccessStream();\n" +
                        "\tms.AsStreamForWrite().Write(imageBytes, 0, imageBytes.Length);\n" +
                        "\tms.Seek(0);\n" +
                        "\timage.SetSource(ms);\n" +
                        "\treturn image;";
					break;
			}

			// End method
			sourceCode += "\n}\n";

			// Return code
			return sourceCode;
		}

        /// <summary>
        /// Builds the C# ToImage method for Cross Platform image support.
        /// </summary>
        /// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
        /// <returns>Conditionally compiled code to support all of the different image types.</returns>
        public virtual string BuildCSharpCrossPlatformToImage(CodeOutputLibrary outputLibrary)
        {
            var sourceCode = "";

            // Add Android platform
            sourceCode += "#if __Android__\n" +
                BuildCsharpToBitmapImage(CodeOutputOS.Android) +
                "#endif\n\n";

            // Add iOS and tvOS platforms
            sourceCode += "#if (__IOS__ || __TVOS__)\n" +
                BuildCsharpToBitmapImage(CodeOutputOS.iOS) +
                "#endif\n\n";

            // Add macOS platform
            sourceCode += "#if __MACOS__\n" +
                BuildCsharpToBitmapImage(CodeOutputOS.macOS) +
                "#endif\n\n";

            // Add Windows and Window WPF platforms
            sourceCode += "#if (WINDOWS || WINDOWS_WPF)\n" +
                BuildCsharpToBitmapImage(CodeOutputOS.Windows) +
                "#endif\n\n";

            // Add Windows UWP platform
            sourceCode += "#if WINDOWS_UWP\n" +
                BuildCsharpToBitmapImage(CodeOutputOS.WindowsUWP) +
                "#endif\n";

            // Return code
            return sourceCode;
        }

		/// <summary>
		/// Converts this shape to C# code.
		/// </summary>
		/// <returns>The shape as C# code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public virtual string ToCSharp(CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

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
		/// Builds the C# using statements.
		/// </summary>
		/// <returns>The required using statements based on what other features have been selected.</returns>
		/// <param name="outputOS">The `CodeOutputOS` to write code for.</param>
		/// <param name="outputLibrary">Output library.</param>
		public virtual string ToCSharpUsingStatements(CodeOutputOS outputOS, CodeOutputLibrary outputLibrary)
		{
			var usingStatements = "";

			// Add any supporting using statements based
			// on the selected OS
			switch (outputOS)
			{
				case CodeOutputOS.Android:
					usingStatements += "using Android.App;\n" +
						"using Android.Widget;\n" +
						"using Android.OS;\n" +
						"using Android.Graphics;\n";

					if (outputLibrary == CodeOutputLibrary.KimonoCore)
					{
						usingStatements += "using KimonoCore.Android;\n";
					}
					break;
				case CodeOutputOS.iOS:
					usingStatements += "using Foundation;\n" +
						"using UIKit;\n";
					
					if (outputLibrary == CodeOutputLibrary.KimonoCore)
					{
						usingStatements += "using KimonoCore.iOS;\n";
					}
					break;
				case CodeOutputOS.tvOS:
					usingStatements += "using Foundation;\n" +
						"using UIKit;\n";

					if (outputLibrary == CodeOutputLibrary.KimonoCore)
					{
						usingStatements += "using KimonoCore.tvOS;\n";
					}
					break;
				case CodeOutputOS.macOS:
					usingStatements += "using Foundation;\n" +
						"using AppKit;\n";

					if (outputLibrary == CodeOutputLibrary.KimonoCore)
					{
						usingStatements += "using KimonoCore.Mac;\n";
					}
					break;
				case CodeOutputOS.Windows:
				case CodeOutputOS.WindowsWPF:
					usingStatements += "using System.Drawing;\n";

					if (outputLibrary == CodeOutputLibrary.KimonoCore)
					{
						usingStatements += "using KimonoCore.Windows;\n";
					}
					break;
				case CodeOutputOS.WindowsUWP:
					usingStatements += "using Windows.UI.Xaml.Media.Imaging;\n" +
						"using System.IO;\n" +
						"using Windows.Storage.Streams;\n";

					if (outputLibrary == CodeOutputLibrary.KimonoCore)
					{
						usingStatements += "using KimonoCore.Windows.UWP;\n";
					}
					break;
			}

			// Return code
			return usingStatements;
		}

		/// <summary>
		/// Returns the methods that a portfolio will use to draw the sketch.
		/// </summary>
		/// <param name="outputOS">The `CodeOutputOS` to generate code for.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		/// <param name="privateMethodsCode">The private methods required by this sketch.</param>
		/// <param name="publicMethodsCode">The public methods required by this sketch.</param>
		public virtual void PortfolioSketchMethods(CodeOutputOS outputOS, CodeOutputLibrary outputLibrary, ref string privateMethodsCode, ref string publicMethodsCode)
		{
			// Add to canvas method
			if (GenerateCodeToOuputToCanvas)
			{
				// Expose this method
				publicMethodsCode = KimonoCodeGenerator.AddCarriageIfNeeded(publicMethodsCode);
				publicMethodsCode += BuildCsharpToCanvasMethod(outputLibrary);
			}
			else
			{
				// Always required as it does the actual work of drawing the
				// sketch and is used by the other export methods
				privateMethodsCode = KimonoCodeGenerator.AddCarriageIfNeeded(privateMethodsCode);
				privateMethodsCode += BuildCsharpToCanvasMethod(outputLibrary);
			}

			// Add to Skia Data method?
			if (GenerateCodeToOuputSkiaData)
			{
				// Expose this method
				publicMethodsCode = KimonoCodeGenerator.AddCarriageIfNeeded(publicMethodsCode);
				publicMethodsCode += BuildCsharpToSkiaDataMethod(outputLibrary);
			}
			else if (GenerateCodeToOuputBitmapImage)
			{
				// Add this method if making bitmap images, as it is required to do the
				// conversion
				privateMethodsCode = KimonoCodeGenerator.AddCarriageIfNeeded(privateMethodsCode);
				privateMethodsCode += BuildCsharpToSkiaDataMethod(outputLibrary);
			}

			// Add to Bitmap Image method?
			if (GenerateCodeToOuputBitmapImage)
			{
				// Cross platform?
				if (outputOS == CodeOutputOS.CrossPlatform)
				{
					// Expose all possible versions of this method with conditional
					// compile statements based on the OS the class is being used on.
					publicMethodsCode = KimonoCodeGenerator.AddCarriageIfNeeded(publicMethodsCode);
					publicMethodsCode += BuildCSharpCrossPlatformToImage(outputLibrary);
				}
				else
				{
					// Expose this method
					publicMethodsCode = KimonoCodeGenerator.AddCarriageIfNeeded(publicMethodsCode);
					publicMethodsCode += BuildCsharpToBitmapImage(outputOS);
				}
			}
		}

		/// <summary>
		/// Converts this shape to C# code.
		/// </summary>
		/// <returns>The shape as C# code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public virtual string ToCSharp(CodeOutputOS outputOS, CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var usingStatements = "";
			var sourceCode = "";
			var initializers = "";
			var privateVariables = "";
			var privateMethodsCode = "";
			var publicMethodsCode = "";
			var computedProperties = "";
			var overrideMethods = "";

			// Add to canvas method
			if (GenerateCodeToOuputToCanvas)
			{
				// Expose this method
				publicMethodsCode = KimonoCodeGenerator.AddCarriageIfNeeded(publicMethodsCode);
				publicMethodsCode += BuildCsharpToCanvasMethod(outputLibrary);
			}
			else
			{
				// Always required as it does the actual work of drawing the
				// sketch and is used by the other export methods
				privateMethodsCode = KimonoCodeGenerator.AddCarriageIfNeeded(privateMethodsCode);
				privateMethodsCode += BuildCsharpToCanvasMethod(outputLibrary);
			}

			// Add to Skia Data method?
			if (GenerateCodeToOuputSkiaData)
			{
				// Expose this method
				publicMethodsCode = KimonoCodeGenerator.AddCarriageIfNeeded(publicMethodsCode);
				publicMethodsCode += BuildCsharpToSkiaDataMethod(outputLibrary);
			}
			else if (GenerateCodeToOuputBitmapImage)
			{
				// Add this method if making bitmap images, as it is required to do the
				// conversion
				privateMethodsCode = KimonoCodeGenerator.AddCarriageIfNeeded(privateMethodsCode);
				privateMethodsCode += BuildCsharpToSkiaDataMethod(outputLibrary);
			}

			// Add to Bitmap Image method?
			if (GenerateCodeToOuputBitmapImage)
			{
				// Cross platform?
				if (outputOS == CodeOutputOS.CrossPlatform)
				{
					// Expose all possible versions of this method with conditional
					// compile statements based on the OS the class is being used on.
					publicMethodsCode = KimonoCodeGenerator.AddCarriageIfNeeded(publicMethodsCode);
					publicMethodsCode += BuildCSharpCrossPlatformToImage(outputLibrary);
				}
				else
				{
					// Expose this method
					publicMethodsCode = KimonoCodeGenerator.AddCarriageIfNeeded(publicMethodsCode);
					publicMethodsCode += BuildCsharpToBitmapImage(outputOS);
				}
			}

			// Assemble using statements
			usingStatements = "using System;\n" +
				"using SkiaSharp;\n";

			// Using the SkiaSharp.Views library?
			if (GenerateCodeToOuputToSkiaSharpViews)
			{
				// Yes, add it
				usingStatements += "using SkiaSharp.Views.Forms;\n";
			}

			// Cross platform?
			if (outputOS == CodeOutputOS.CrossPlatform)
			{
				// Yes, add all platform's using statements
				// Add Android platform
				usingStatements += "\n#if __Android__\n" +
					ToCSharpUsingStatements(CodeOutputOS.Android, outputLibrary) +
					"#endif\n\n";

				// Add iOS platforms
				usingStatements += "#if __IOS__ \n" +
					ToCSharpUsingStatements(CodeOutputOS.iOS, outputLibrary) +
					"#endif\n\n";

				// Add tvOS platforms
				usingStatements += "#if __TVOS__ \n" +
					ToCSharpUsingStatements(CodeOutputOS.tvOS, outputLibrary) +
					"#endif\n\n";

				// Add macOS platform
				usingStatements += "#if __MACOS__\n" +
					ToCSharpUsingStatements(CodeOutputOS.macOS, outputLibrary) +
					"#endif\n\n";

				// Add Windows and Window WPF platforms
				usingStatements += "#if (WINDOWS || WINDOWS_WPF)\n" +
					ToCSharpUsingStatements(CodeOutputOS.Windows, outputLibrary) +
					"#endif\n\n";

				// Add Windows UWP platform
				usingStatements += "#if WINDOWS_UWP\n" +
					ToCSharpUsingStatements(CodeOutputOS.WindowsUWP, outputLibrary) +
					"#endif\n";
			}
			else
			{
				// No, add only the specific OS using statements
				usingStatements += ToCSharpUsingStatements(outputOS, outputLibrary);

				// Using the SkiaSharp.Views library?
				if (GenerateCodeToOuputToSkiaSharpViews)
				{
					// Yes, add it
					switch (outputOS)
					{
						case CodeOutputOS.Android:
							usingStatements += "using SkiaSharp.Views.Android;\n";
							break;
						case CodeOutputOS.iOS:
							usingStatements += "using SkiaSharp.Views.iOS;\n";
							break;
						case CodeOutputOS.tvOS:
							usingStatements += "using SkiaSharp.Views.tvOS;\n";
							break;
						case CodeOutputOS.macOS:
							usingStatements += "using SkiaSharp.Views.Mac;\n";
							break;
						case CodeOutputOS.Windows:
							usingStatements += "using SkiaSharp.Views.Desktop;\n";
							break;
						case CodeOutputOS.WindowsWPF:
							usingStatements += "using SkiaSharp.Views.WPF;\n";
							break;
						case CodeOutputOS.WindowsUWP:
							usingStatements += "using SkiaSharp.Views.UWP;\n";
							break;
					}
				}
			}

			// Assemble precode items in reverse order to ensure dependencies are registered first
			initializers = KimonoCodeGenerator.InitializerForSupportStyles(outputLanguage, outputLibrary);
			initializers = KimonoCodeGenerator.InitializerForSupportGradients(outputLanguage, outputLibrary) + initializers;

			// Assemble private variables
			if (KimonoCodeGenerator.SupportingGradients.Count > 0) privateVariables = KimonoCodeGenerator.AddCarriageIfNeeded(privateVariables);
			privateVariables += KimonoCodeGenerator.PrivateVariablesForSupportingGradients(outputLanguage, outputLibrary);

			// Assemble computed properties
			if (KimonoCodeGenerator.SupportingColors.Count > 0) computedProperties = KimonoCodeGenerator.AddCarriageIfNeeded(computedProperties);
			computedProperties += KimonoCodeGenerator.PropertyForSupportingColors(outputLanguage, outputLibrary);

			if (KimonoCodeGenerator.SupportingGradients.Count > 0) computedProperties = KimonoCodeGenerator.AddCarriageIfNeeded(computedProperties);
			computedProperties += KimonoCodeGenerator.PropertyForSupportingGradients(outputLanguage, outputLibrary);

			if (KimonoCodeGenerator.SupportingStyles.Count > 0) computedProperties = KimonoCodeGenerator.AddCarriageIfNeeded(computedProperties);
			computedProperties += KimonoCodeGenerator.PropertyForSupportingStyles(outputLanguage, outputLibrary);

			// Convert this Sketch to a class
			// Using a SkiaSharp.Views?
			if (GenerateCodeToOuputToSkiaSharpViews)
			{
				// Yes, Take action based on OS
				switch (outputOS)
				{
					case CodeOutputOS.Android:
						// Setup class
						sourceCode += $"{usingStatements}\n" +
							$"namespace {KimonoCodeGenerator.MakeElementName(Portfolio.Namespace)} " + "{\n" +
							"\t/// <summary>\n" +
							$"\t/// Author: {Portfolio.Author}\n" +
							$"\t/// {Portfolio.Copyright}\n" +
							"\t/// </summary>\n" +
							$"\t/// <remarks>Generated by Kimono Designer {DateTime.Now.ToString("D")}.</remarks>\n" +
							$"\tpublic class {ElementName} : SKCanvasView\n" + "\t{\n";

						// Generate override methods
						overrideMethods += "protected override void OnDraw (SKSurface surface, SKImageInfo info) {\n" +
							"\t// Call the base method\n" +
							"\tbase.OnDraw (surface, info);\n\n" +
							"\t// Draw the sketch into the canvas\n" +
							$"\tDraw{ElementName}(surface.Canvas);\n" +
							"\tsurface.Canvas.Flush();\n" +
							"}\n";
						break;
					case CodeOutputOS.iOS:
					case CodeOutputOS.tvOS:
					case CodeOutputOS.macOS:
						// Setup class
						sourceCode += $"{usingStatements}\n" +
							$"namespace {KimonoCodeGenerator.MakeElementName(Portfolio.Namespace)} " + "{\n" +
							"\t/// <summary>\n" +
							$"\t/// Author: {Portfolio.Author}\n" +
							$"\t/// {Portfolio.Copyright}\n" +
							"\t/// </summary>\n" +
							$"\t/// <remarks>Generated by Kimono Designer {DateTime.Now.ToString("D")}.</remarks>\n" +
							$"\t[Register(\"{ElementName}\")]\n" +
							$"\tpublic class {ElementName} : SKCanvasView\n" + "{\n";

						// Generate override methods
						overrideMethods += "protected override void DrawInSurface (SKSurface surface, SKImageInfo info) {\n" +
							"\t// Call the base method\n" +
							"\tbase.DrawInSurface (surface, info);\n\n" +
							"\t// Draw the sketch into the canvas\n" +
							$"\tDraw{ElementName}(surface.Canvas);\n" +
							"\tsurface.Canvas.Flush();\n" +
							"}\n";
						break;
					case CodeOutputOS.Windows:
						// Setup class
						sourceCode += $"{usingStatements}\n" +
							$"namespace {KimonoCodeGenerator.MakeElementName(Portfolio.Namespace)} " + "{\n" +
							"\t/// <summary>\n" +
							$"\t/// Author: {Portfolio.Author}\n" +
							$"\t/// {Portfolio.Copyright}\n" +
							"\t/// </summary>\n" +
							$"\t/// <remarks>Generated by Kimono Designer {DateTime.Now.ToString("D")}.</remarks>\n" +
							$"\tpublic class {ElementName} : SKControl\n" + "\t{\n";

						// Generate override methods
						overrideMethods += "protected override void OnPaintSurface (SKPaintSurfaceEventArgs e) {\n" +
							"\t// Call the base method\n" +
							"\tbase.OnPaintSurface (e);\n\n" +
							"\t// Get surface\n" +
							"\tvar surface = e.Surface;\n\n" +
							"\t// Draw the sketch into the canvas\n" +
							$"\tDraw{ElementName}(surface.Canvas);\n" +
							"\tsurface.Canvas.Flush();\n" +
							"}\n";
						break;
					case CodeOutputOS.WindowsWPF:
						// Setup class
						sourceCode += $"{usingStatements}\n" +
							$"namespace {KimonoCodeGenerator.MakeElementName(Portfolio.Namespace)} " + "{\n" +
							"\t/// <summary>\n" +
							$"\t/// Author: {Portfolio.Author}\n" +
							$"\t/// {Portfolio.Copyright}\n" +
							"\t/// </summary>\n" +
							$"\t/// <remarks>Generated by Kimono Designer {DateTime.Now.ToString("D")}.</remarks>\n" +
							$"\tpublic class {ElementName} : SKElement\n" + "\t{\n";

						// Generate override methods
						overrideMethods += "protected override void OnPaintSurface (SKPaintSurfaceEventArgs e) {\n" +
							"\t// Call the base method\n" +
							"\tbase.OnPaintSurface (e);\n\n" +
							"\t// Get surface\n" +
							"\tvar surface = e.Surface;\n\n" +
							"\t// Draw the sketch into the canvas\n" +
							$"\tDraw{ElementName}(surface.Canvas);\n" +
							"\tsurface.Canvas.Flush();\n" +
							"}\n";
						break;
					case CodeOutputOS.WindowsUWP:
						// Setup class
						sourceCode += $"{usingStatements}\n" +
							$"namespace {KimonoCodeGenerator.MakeElementName(Portfolio.Namespace)} " + "{\n" +
							"\t/// <summary>\n" +
							$"\t/// Author: {Portfolio.Author}\n" +
							$"\t/// {Portfolio.Copyright}\n" +
							"\t/// </summary>\n" +
							$"\t/// <remarks>Generated by Kimono Designer {DateTime.Now.ToString("D")}.</remarks>\n" +
							$"\tpublic class {ElementName} : SKXamlCanvas\n" + "\t{\n";

						// Generate override methods
						overrideMethods += "protected override void OnPaintSurface (SKPaintSurfaceEventArgs e) {\n" +
							"\t// Call the base method\n" +
							"\tbase.OnPaintSurface (e);\n\n" +
							"\t// Get surface\n" +
							"\tvar surface = e.Surface;\n\n" +
							"\t// Draw the sketch into the canvas\n" +
							$"\tDraw{ElementName}(surface.Canvas);\n" +
							"\tsurface.Canvas.Flush();\n" +
							"}\n";
						break;
					case CodeOutputOS.CrossPlatform:
						// Setup class
						sourceCode += $"{usingStatements}\n" +
							$"namespace {KimonoCodeGenerator.MakeElementName(Portfolio.Namespace)} " + "{\n" +
							"\t/// <summary>\n" +
							$"\t/// Author: {Portfolio.Author}\n" +
							$"\t/// {Portfolio.Copyright}\n" +
							"\t/// </summary>\n" +
							$"\t/// <remarks>Generated by Kimono Designer {DateTime.Now.ToString("D")}.</remarks>\n" +
							$"\tpublic class {ElementName} : SKCanvasView\n" + "\t{\n";

						// Generate override methods
						overrideMethods += "protected override void OnPaintSurface (SKPaintSurfaceEventArgs e) {\n" +
							"\t// Call the base method\n" +
							"\tbase.OnPaintSurface (e);\n\n" +
							"\t// Get surface\n" +
							"\tvar surface = e.Surface;\n\n" +
							"\t// Draw the sketch into the canvas\n" +
							$"\tDraw{ElementName}(surface.Canvas);\n" +
							"\tsurface.Canvas.Flush();\n" +
							"}\n";
						break;
				}
			}
			else
			{
				// No, make a generic class
				sourceCode += $"{usingStatements}\n" +
					$"namespace {KimonoCodeGenerator.MakeElementName(Portfolio.Namespace)} " + "{\n" +
					"\t/// <summary>\n" +
					$"\t/// Author: {Portfolio.Author}\n" +
					$"\t/// {Portfolio.Copyright}\n" +
					"\t/// </summary>\n" +
					$"\t/// <remarks>Generated by Kimono Designer {DateTime.Now.ToString("D")}.</remarks>\n" +
					$"\tpublic class {ElementName}\n" + "\t{\n";
			}

			// Any private variables?
			if (privateVariables != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Private Variables\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(privateVariables, 2) +
					"#endregion\n\n";
			}

			// Any computed properties?
			if (computedProperties != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Computed Properties\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(computedProperties, 2) +
					"#endregion\n\n";
			}

			// Add constructors
			sourceCode += "\t\t#region Constructors\n" +
				"\t\t/// <summary>\n" +
				$"\t\t/// Creates a new instance of the {ElementName} class.\n" +
				"\t\t/// </summary>\n" +
				$"\t\tpublic {ElementName}() " + "{\n" +
				"\t\t\tInitialize();\n" +
				"\t\t}\n\n";

			// Using a SkiaSharp.Views?
			if (GenerateCodeToOuputToSkiaSharpViews)
			{
				// Take action based on OS
				switch (outputOS)
				{
					case CodeOutputOS.Android:
						// Add Android specific constructors.
						sourceCode += "\t\t/// <summary>\n" +
							$"\t\t/// Creates a new instance of the {ElementName} class.\n" +
							"\t\t/// </summary>\n" +
							$"\t\tpublic {ElementName}(Context context) : base(context) " + "{\n" +
							"\t\t\tInitialize();\n" +
							"\t\t}\n\n" +
							"\t\t/// <summary>\n" +
							$"\t\t/// Creates a new instance of the {ElementName} class.\n" +
							"\t\t/// </summary>\n" +
							$"\t\tpublic {ElementName}(Context context, IAttributeSet attrs) : base(context, attrs) " + "{\n" +
							"\t\t\tInitialize();\n" +
							"\t\t}\n\n" +
							"\t\t/// <summary>\n" +
							$"\t\t/// Creates a new instance of the {ElementName} class.\n" +
							"\t\t/// </summary>\n" +
							$"\t\tpublic {ElementName}(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr) " + "{\n" +
							"\t\t\tInitialize();\n" +
							"\t\t}\n\n";
						break;
					case CodeOutputOS.iOS:
					case CodeOutputOS.tvOS:
					case CodeOutputOS.macOS:
						// Add required storyboard/.xib constructor for Apple OSes.
						sourceCode += "\t\t/// <summary>\n" +
							$"\t\t/// Creates a new instance of the {ElementName} class.\n" +
							"\t\t/// </summary>\n" +
							$"\t\tpublic {ElementName}(IntPtr p) : base(p) " + "{\n" +
							"\t\t\tInitialize();\n" +
							"\t\t}\n\n";
						break;
				}
			}

			// Add initializer
			sourceCode += "\t\t/// <summary>\n" +
					$"\t\t/// Initialize this new instance of the {ElementName} class.\n" +
					"\t\t/// </summary>\n" +
					"\t\tinternal void Initialize() {\n";

			// Any initialization code?
			if (initializers != "")
			{
				// Yes, include code
				sourceCode += KimonoCodeGenerator.IncreaseIndentLevel(initializers, 3);
			}
            
			// Complete costructor
			sourceCode += "\n\t\t}\n" +
				"\t\t#endregion\n\n";

			// Any private methods?
			if (privateMethodsCode != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Private Methods\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(privateMethodsCode, 2) +
					"#endregion\n\n";
			}

			// Any private methods?
			if (publicMethodsCode != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Public Methods\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(publicMethodsCode, 2) +
					"#endregion\n\n";
			}

			// Any override methods?
			if (overrideMethods != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Override Methods\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(overrideMethods, 2) +
					"#endregion\n\n";
			}

			// Close class
			sourceCode += "\t}\n" +
				"}\n";

			// Return code
			return sourceCode;
		}

		/// <summary>
		/// Converts this sketch to C# code using the KimonoCore library.
		/// </summary>
		/// <returns>The sketch as source code.</returns>
		/// <param name="outputOS">The `CodeOutputOS` to create code for.</param>
		/// <param name="outputLanguage">The `CodeOutputLanguage` to use.</param>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public virtual string ToCSharpKimono(CodeOutputOS outputOS, CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var usingStatements = "";
			var sourceCode = "";
			var initializers = "";
			var privateVariables = "";
			var privateMethodsCode = "";
			var publicMethodsCode = "";
			var computedProperties = "";
			var overrideMethods = "";

			// Assemble using statements
			usingStatements = "using System;\n" +
				"using SkiaSharp;\n" +
				"using KimonoCore;\n";

			// Take action based on the outputOS
			switch (outputOS)
			{
				case CodeOutputOS.Android:
					usingStatements += "using KimonoCore.Android;\n";
					break;
				case CodeOutputOS.CrossPlatform:
					usingStatements += "using KimonoCore.Forms;\n";
					break;
				case CodeOutputOS.iOS:
					usingStatements += "using KimonoCore.iOS;\n";
					break;
				case CodeOutputOS.macOS:
					usingStatements += "using KimonoCore.Mac;\n";
					break;
				case CodeOutputOS.tvOS:
					usingStatements += "using KimonoCore.tvOS;\n";
					break;
				case CodeOutputOS.Windows:
				case CodeOutputOS.WindowsWPF:
					usingStatements += "using KimonoCore.Windows;\n";
					break;
				case CodeOutputOS.WindowsUWP:
					usingStatements += "using KimonoCore.Windows.UWP;\n";
					break;
			}

			// Start initializers
			initializers += "\n// Initialize Sketch\n" +
				$"Name = \"{Name}\";\n" +
				$"DrawCanvas = {DrawCanvas.ToString().ToLower()};\n" +
				$"Width = {Width}f;\n" +
				$"Height = {Height}f;\n" +
				$"CanvasColor = {KimonoCodeGenerator.ColorToCode(CodeOutputLibrary.SkiaSharp, CanvasColor)};\n" +
				$"Portfolio = new KimonoPortfolio(true);\n" +
				$"Portfolio.Sketches.Add(this);\n" +
				$"ObiScriptPortfolio.Portfolio = Portfolio;\n\n";

			// Add shapes
			foreach (KimonoShape shape in Shapes)
			{
				var shapeCode = shape.ToCSharp(CodeOutputLibrary.KimonoCore);
				initializers = KimonoCodeGenerator.AddCarriageIfNeeded(initializers);
				initializers += shapeCode.Replace($"{shape.ElementName}.Draw(canvas);\n",$"Shapes.Add({shape.ElementName});\n");
			}

			// Assemble precode items in reverse order to ensure dependencies are registered first
			var baseInitializers = KimonoCodeGenerator.InitializerForSupportStyles(outputLanguage, outputLibrary);
			baseInitializers = KimonoCodeGenerator.InitializerForSupportColors(outputLanguage, outputLibrary) + baseInitializers;
			baseInitializers = KimonoCodeGenerator.InitializerForSupportGradients(outputLanguage, outputLibrary) + baseInitializers;
			baseInitializers = KimonoCodeGenerator.CodeForSupportLocalProperties(outputLanguage, outputLibrary) + baseInitializers;

			// Accumulate objects for portfolio
			var accumulation = KimonoCodeGenerator.CodeToAccumulatePortfolioElements("Portfolio.");
			if (accumulation != "")
			{
				// Include accumulators
				initializers += "\n"+ accumulation;
			}

			// Assemble full initializer code
			initializers = baseInitializers + initializers;

			// Assemble private variables
			if (KimonoCodeGenerator.SupportingGradients.Count > 0) privateVariables = KimonoCodeGenerator.AddCarriageIfNeeded(privateVariables);
			privateVariables += KimonoCodeGenerator.PrivateVariablesForSupportingGradients(outputLanguage, outputLibrary);

			// Assemble computed properties
			if (KimonoCodeGenerator.SupportingColors.Count > 0) computedProperties = KimonoCodeGenerator.AddCarriageIfNeeded(computedProperties);
			computedProperties += KimonoCodeGenerator.PropertyForSupportingColors(outputLanguage, outputLibrary);

			if (KimonoCodeGenerator.SupportingGradients.Count > 0) computedProperties = KimonoCodeGenerator.AddCarriageIfNeeded(computedProperties);
			computedProperties += KimonoCodeGenerator.PropertyForSupportingGradients(outputLanguage, outputLibrary);

			if (KimonoCodeGenerator.SupportingStyles.Count > 0) computedProperties = KimonoCodeGenerator.AddCarriageIfNeeded(computedProperties);
			computedProperties += KimonoCodeGenerator.PropertyForSupportingStyles(outputLanguage, outputLibrary);

			if (KimonoCodeGenerator.GlobalProperties.Count > 0) computedProperties = KimonoCodeGenerator.AddCarriageIfNeeded(computedProperties);
			computedProperties += KimonoCodeGenerator.CodeForSupportGlobalProperties(outputLanguage, outputLibrary);

			// Start class
			sourceCode += $"{usingStatements}\n" +
				$"namespace {KimonoCodeGenerator.MakeElementName(Portfolio.Namespace)} " + "{\n" +
				"\t/// <summary>\n" +
				$"\t/// Author: {Portfolio.Author}\n" +
				$"\t/// {Portfolio.Copyright}\n" +
				"\t/// </summary>\n" +
				$"\t/// <remarks>Generated by Kimono Designer {DateTime.Now.ToString("D")}.</remarks>\n" +
				$"\tpublic class {ElementName} : KimonoSketch\n" + "\t{\n";

			// Any private variables?
			if (privateVariables != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Private Variables\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(privateVariables, 2) +
					"#endregion\n\n";
			}

			// Any computed properties?
			if (computedProperties != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Computed Properties\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(computedProperties, 2) +
					"#endregion\n\n";
			}

			// Make parameter list
			var parameters = KimonoCodeGenerator.CodeForSupportParameterProperties(outputLanguage, outputLibrary);
			var paramList = KimonoCodeGenerator.CodeForInitializeParameterProperties(outputLanguage, outputLibrary);

			// Add constructors
			sourceCode += "\t\t#region Constructors\n" +
				"\t\t/// <summary>\n" +
				$"\t\t/// Creates a new instance of the {ElementName} class.\n" +
				"\t\t/// </summary>\n" +
				$"\t\tpublic {ElementName}({parameters}) " + "{\n" +
				$"\t\t\tInitialize({paramList});\n" +
				"\t\t}\n\n";

			// Add initializer
			sourceCode += "\t\t/// <summary>\n" +
				$"\t\t/// Initializes this new instance of the {ElementName} class.\n" +
				"\t\t/// </summary>\n" +
				$"\t\tinternal void Initialize({parameters}) " + "{\n";

			// Any initialization code?
			if (initializers != "")
			{
				// Yes, include code
				sourceCode += KimonoCodeGenerator.IncreaseIndentLevel(initializers, 3);
			}

			// Complete costructor
			sourceCode += "\n\t\t}\n" +
				"#endregion\n\n";

			// Any private methods?
			if (privateMethodsCode != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Private Methods\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(privateMethodsCode, 2) +
					"#endregion\n\n";
			}

			// Any private methods?
			if (publicMethodsCode != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Public Methods\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(publicMethodsCode, 2) +
					"#endregion\n\n";
			}

			// Any override methods?
			if (overrideMethods != "")
			{
				// Yes, emit private methods
				sourceCode += "\t\t#region Override Methods\n" +
					KimonoCodeGenerator.IncreaseIndentLevel(overrideMethods, 2) +
					"#endregion\n\n";
			}

			// Close class
			sourceCode += "\t}\n" +
				"}\n";

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
		public virtual string ToCode(CodeOutputOS outputOS, CodeOutputLanguage outputLanguage, CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Define element name
			ElementName = KimonoCodeGenerator.MakeElementName(Name);

			// Take action based on the language
			switch (outputLanguage)
			{
				case CodeOutputLanguage.CSharp:
					// Take action based on the output library
					switch (outputLibrary)
					{
						case CodeOutputLibrary.SkiaSharp:
							sourceCode += ToCSharp(outputOS, outputLanguage, outputLibrary);
							break;
						case CodeOutputLibrary.KimonoCore:
							sourceCode += ToCSharpKimono(outputOS, outputLanguage, outputLibrary);
							break;
					}
					break;
				case CodeOutputLanguage.ObiScript:
					sourceCode += "// Sketches are not supported in ObiScript\n";
					break;
				case CodeOutputLanguage.FSharp :
					IVisitorCodeGen generator = null;
					switch (outputLibrary)
					{
						case (CodeOutputLibrary.SkiaSharp):
							generator = new CodeGenFSharp.SkiaSharp.ToFSharpSkia();
							break;
						case (CodeOutputLibrary.KimonoCore):
							//TODO
							throw new NotImplementedException("TODO");
						default:
							throw new ArgumentOutOfRangeException($"Unknown code generation library {outputLibrary}");
					}
					//Kick off source code generation here
					sourceCode += this.ToCode(generator);
					break;
				default:
					throw new ArgumentOutOfRangeException($"Unknown output language {outputLanguage}");
			}

			// Return code
			return sourceCode;
		}

        /// <summary>
        /// Visitor pattern: returns results of double-dispatch to code generator
        /// </summary>
        /// <returns>The code from the code generator visitor.</returns>
        /// <param name="visitor">A code generator.</param>
        /// <remarks>Note that implementation is always just `=>visitor.CodeGen(this)`</remarks>
        public string ToCode (IVisitorCodeGen visitor) => visitor.CodeGen(this);

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
