using System;
using AppKit;
using CoreGraphics;
using Foundation;
using SkiaSharp;
using KimonoCore;
using KimonoCore.Mac;

namespace KimonoMac
{
	/// <summary>
	/// Handles the master view for the Kimono Designer.
	/// </summary>
	public partial class ViewController : NSViewController
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the sidebar project list.
		/// </summary>
		/// <value>The project list.</value>
		public SourceListItem ProjectList { get; set; }

		/// <summary>
		/// Gets or sets the sidebar sketches list.
		/// </summary>
		/// <value>The sketches list.</value>
		public SourceListItem SketchesList { get; set; }

		/// <summary>
		/// Gets or sets the sidebar shapes list.
		/// </summary>
		/// <value>The shapes list.</value>
		public SourceListItem ShapesList { get; set; }

		/// <summary>
		/// Gets or sets the sidebar style list.
		/// </summary>
		/// <value>The style list.</value>
		public SourceListItem StyleList { get; set; }

		/// <summary>
		/// Gets or sets the sidebar color list.
		/// </summary>
		/// <value>The color list.</value>
		public SourceListItem ColorList { get; set; }

		/// <summary>
		/// Gets or sets the gradient list.
		/// </summary>
		/// <value>The gradient list.</value>
		public SourceListItem GradientList { get; set; }
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.ViewController"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public ViewController(IntPtr handle) : base(handle)
		{
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Adds a new <c>KimonoSketch</c> to the <c>KimonoPortfolio</c>.
		/// </summary>
		public void AddNewSketch()
		{
			// add new sketch
			DesignSurface.Portfolio.AddNewSketch();
			SetDocumentSize();
			ShowSketchInspectors(DesignSurface.SelectedSketch);
		}

		/// <summary>
		/// Adds a new <c>KimonoSketch</c> to the <c>KimonoPortfolio</c>.
		/// </summary>
		public void AddNewColor()
		{
			// Add new color
			DesignSurface.Portfolio.AddNewColor();
		}

		/// <summary>
		/// Adds a new <c>KimonoColor</c> based off of the given <c>SKColor</c> to the
		/// <c>KimonoPortfolio</c>.
		/// </summary>
		/// <param name="baseColor">The base <c>SKColor</c>.</param>
		public void AddNewColor(SKColor baseColor)
		{
			// Add new color
			DesignSurface.Portfolio.AddNewColor(baseColor);
		}

		/// <summary>
		/// Adds a new <c>KimonoStyle</c> to the <c>KimonoPortfolio</c>.
		/// </summary>
		public void AddNewStyle()
		{
			// Add new style
			DesignSurface.Portfolio.AddNewStyle();
		}

		/// <summary>
		/// Duplicates the given <c>KimonoColor</c> and adds it to <c>KimonoPortfolio</c>.
		/// </summary>
		/// <param name="color">The <c>KimonoColor</c> to duplicate.</param>
		public void DuplicateColor(KimonoColor color)
		{
			// Duplicate
			DesignSurface.Portfolio.DuplicateColor(color);
		}

		/// <summary>
		/// Deletes the given <c>KimonoColor</c> from the <c>KimonoPortfolio</c>.
		/// </summary>
		/// <param name="color">The <c>KimonoColor</c> to delete.</param>
		public void DeleteColor(KimonoColor color)
		{
			// Delete
			DesignSurface.Portfolio.DeleteColor(color);
		}

		/// <summary>
		/// Adds the new gradient.
		/// </summary>
		public void AddNewGradient()
		{
			// Add new gradient
			DesignSurface.Portfolio.AddNewGradient();
		}

		/// <summary>
		/// Duplicates the given gradient.
		/// </summary>
		/// <param name="gradient">The <c>KimonoGradient</c> to duplicate.</param>
		public void DuplicateGradient(KimonoGradient gradient)
		{
			// Duplicate gradient
			DesignSurface.Portfolio.DuplicateGradient(gradient);
		}

		/// <summary>
		/// Deletes the given gradient.
		/// </summary>
		/// <param name="gradient">The <c>KimonoGradient</c> to delete.</param>
		public void DeleteGradient(KimonoGradient gradient)
		{
			// Delete gradient
			DesignSurface.Portfolio.DeleteGradient(gradient);
		}

		/// <summary>
		/// Duplicates the given <c>KimonoStyle</c> in the <c>KimonoPortfolio</c>.
		/// </summary>
		/// <param name="style">The <c>KimonoStyle</c> to duplicate.</param>
		public void DuplicateStyle(KimonoStyle style)
		{
			// Add new style
			DesignSurface.Portfolio.DuplicateStyle(style);
		}

		/// <summary>
		/// Deletes the given <c>KimonoStyle</c> from the <c>KimonoPortfolio</c>.
		/// </summary>
		/// <param name="style">The <c>KimonoStyle</c> to delete.</param>
		public void DeleteStyle(KimonoStyle style)
		{
			// Remove the given style
			DesignSurface.Portfolio.DeleteStyle(style);
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Highlights the currently selected <c>KimonoTool</c>.
		/// </summary>
		/// <param name="tool">The <c>KimonoTool</c> to highlight.</param>
		private void HighlightTool(KimonoTool tool)
		{
			// Set the image of the tool based on its
			// selected state.
			ToolCursor.Image = NSImage.ImageNamed((tool == KimonoTool.Cursor) ? "IconCursorSelected" : "IconCursor");
			ToolLine.Image = NSImage.ImageNamed((tool == KimonoTool.Line) ? "IconLineSelected" : "IconLine");
			ToolArrow.Image = NSImage.ImageNamed((tool == KimonoTool.Arrow) ? "IconArrowSelected" : "IconArrow");
			ToolRect.Image = NSImage.ImageNamed((tool == KimonoTool.Rectangle) ? "IconRectangleSelected" : "IconRectangle");
			ToolOval.Image = NSImage.ImageNamed((tool == KimonoTool.Oval) ? "IconOvalSelected" : "IconOval");
			ToolRoundRect.Image = NSImage.ImageNamed((tool == KimonoTool.RoundRect) ? "IconRoundRectSelected" : "IconRoundRect");
			ToolStar.Image = NSImage.ImageNamed((tool == KimonoTool.Star) ? "IconStarSelected" : "IconStar");
			ToolPolygon.Image = NSImage.ImageNamed((tool == KimonoTool.Polygon) ? "IconPolygonSelected" : "IconPolygon");
			ToolTriangle.Image = NSImage.ImageNamed((tool == KimonoTool.Triangle) ? "IconTriangleSelected" : "IconTriangle");
			ToolVector.Image = NSImage.ImageNamed((tool == KimonoTool.Vector) ? "IconVectorSelected" : "IconVector");
			ToolBezier.Image = NSImage.ImageNamed((tool == KimonoTool.Bezier) ? "IconBezierSelected" : "IconBezier");
			ToolText.Image = NSImage.ImageNamed((tool == KimonoTool.Text) ? "IconTextSelected" : "IconText");
		}

		/// <summary>
		/// Populates the Shapes sidbar with all of the <c>KimonoShapes</c> in the currently selected
		/// <c>KimonoSketch</c>.
		/// </summary>
		private void ShowSketchShapes()
		{
			// Set Shape List Title
			ShapesList.Title = "Shapes";

			// Process all shapes in the sketch
			for (int n = DesignSurface.SelectedSketch.Shapes.Count - 1; n >= 0; n--)
			{
				var shape = DesignSurface.SelectedSketch.Shapes[n];
				if (shape is KimonoShapeArrow)
				{
					ShapesList.AddItem(shape.Name, "IconArrow", () => { DesignSurface.SelectedSketch.SelectShape(shape); });
				}
				else if (shape is KimonoShapeStar)
				{
					ShapesList.AddItem(shape.Name, "IconStar", () => { DesignSurface.SelectedSketch.SelectShape(shape); });
				}
				else if (shape is KimonoShapeRect)
				{
					ShapesList.AddItem(shape.Name, "IconRectangle", () => { DesignSurface.SelectedSketch.SelectShape(shape); });
				}
				else if (shape is KimonoShapeOval)
				{
					ShapesList.AddItem(shape.Name, "IconOval", () => { DesignSurface.SelectedSketch.SelectShape(shape); });
				}
				else if (shape is KimonoShapeLine)
				{
					ShapesList.AddItem(shape.Name, "IconLine", () => { DesignSurface.SelectedSketch.SelectShape(shape); });
				}
				else if (shape is KimonoShapeVector)
				{
					ShapesList.AddItem(shape.Name, "IconVector", () => { DesignSurface.SelectedSketch.SelectShape(shape); });
				}
				else if (shape is KimonoShapePolygon)
				{
					ShapesList.AddItem(shape.Name, "IconPolygon", () => { DesignSurface.SelectedSketch.SelectShape(shape); });
				}
				else if (shape is KimonoShapeTriangle)
				{
					ShapesList.AddItem(shape.Name, "IconTriangle", () => { DesignSurface.SelectedSketch.SelectShape(shape); });
				}
				else if (shape is KimonoShapeRoundRect)
				{
					ShapesList.AddItem(shape.Name, "IconRoundRect", () => { DesignSurface.SelectedSketch.SelectShape(shape); });
				}
				else if (shape is KimonoShapeText)
				{
					ShapesList.AddItem(shape.Name, "IconText", () => { DesignSurface.SelectedSketch.SelectShape(shape); });
				}
				else if (shape is KimonoShapeGroup)
				{
					ShapesList.AddItem(shape.Name, "IconGroup", () => { DesignSurface.SelectedSketch.SelectShape(shape); });
				} 
				else if (shape is KimonoShapeBezier)
				{
					ShapesList.AddItem(shape.Name, "IconBezier", () => { DesignSurface.SelectedSketch.SelectShape(shape); });
				}
			}
		}

		/// <summary>
		/// Populates the Shapes sidebar with all of the <c>KimonoShapes</c> in the currently selected
		/// <c>KimonoSHapeGroup</c> that is being edited.
		/// </summary>
		private void ShowGroupShapes()
		{
			// Set Shape List Title
			ShapesList.Title = "Group Shapes";

			// Get group
			var group = DesignSurface.DeeplySelectedGroup;

			// Process all shapes in the sketch
			for (int n = group.Shapes.Count - 1; n >= 0; n--)
			{
				var shape = group.Shapes[n];
				if (shape is KimonoShapeArrow)
				{
					ShapesList.AddItem(shape.Name, "IconArrow", () => { group.SelectShape(shape); });
				}
				else if (shape is KimonoShapeStar)
				{
					ShapesList.AddItem(shape.Name, "IconStar", () => { group.SelectShape(shape); });
				}
				else if (shape is KimonoShapeRect)
				{
					ShapesList.AddItem(shape.Name, "IconRectangle", () => { group.SelectShape(shape); });
				}
				else if (shape is KimonoShapeOval)
				{
					ShapesList.AddItem(shape.Name, "IconOval", () => { group.SelectShape(shape); });
				}
				else if (shape is KimonoShapeLine)
				{
					ShapesList.AddItem(shape.Name, "IconLine", () => { group.SelectShape(shape); });
				}
				else if (shape is KimonoShapeVector)
				{
					ShapesList.AddItem(shape.Name, "IconVector", () => { group.SelectShape(shape); });
				}
				else if (shape is KimonoShapePolygon)
				{
					ShapesList.AddItem(shape.Name, "IconPolygon", () => { group.SelectShape(shape); });
				}
				else if (shape is KimonoShapeTriangle)
				{
					ShapesList.AddItem(shape.Name, "IconTriangle", () => { group.SelectShape(shape); });
				}
				else if (shape is KimonoShapeRoundRect)
				{
					ShapesList.AddItem(shape.Name, "IconRoundRect", () => { group.SelectShape(shape); });
				}
				else if (shape is KimonoShapeText)
				{
					ShapesList.AddItem(shape.Name, "IconText", () => { group.SelectShape(shape); });
				}
				else if (shape is KimonoShapeGroup)
				{
					ShapesList.AddItem(shape.Name, "IconGroup", () => { group.SelectShape(shape); });
				}
				else if (shape is KimonoShapeBezier)
				{
					ShapesList.AddItem(shape.Name, "IconBezier", () => { group.SelectShape(shape); });
				}
			}
		}

		/// <summary>
		/// Updates the path display at the top of the Design Surface showing the full path
		/// to the shape currently being edited.
		/// </summary>
		private void UpdatePath()
		{
			// Take action based on the selected item
			if (DesignSurface.DeeplySelectedGroup != null && DesignSurface.DeeplySelectedGroup.State == KimonoShapeState.Editing)
			{
				SketchPath.StringValue = DesignSurface.DeeplySelectedGroup.Path;
				BackButton.Enabled = true;
			}
			else
			{
				SketchPath.StringValue = DesignSurface.SelectedSketch.Name;
				BackButton.Enabled = false;
			}

		}

		/// <summary>
		/// Updates the shapes list in the sidebar.
		/// </summary>
		/// <param name="refreshList">If set to <c>true</c> refresh list.</param>
		private void UpdateShapesList(bool refreshList)
		{
			// Update path
			UpdatePath();

			// Remove all items from the list
			ShapesList.Clear();

			// Repopulate based on selection type
			if (DesignSurface.DeeplySelectedGroup != null)
			{
				// Show shapes in the deepest selected group
				ShowGroupShapes();
			}
			else
			{
				// Show shapes in sketch
				ShowSketchShapes();
			}

			// Empty list?
			if (ShapesList.Count == 0)
			{
				ShapesList.AddItem("(empty)", "IconDocFolder", () => {CloseAllInspectors();});
			}

			// Refresh source list?
			if (refreshList) SourceList.ReloadData();

			// Inform window of change
			RaiseSketchModified(DesignSurface.SelectedSketch);
		}

		/// <summary>
		/// Updates the style list in the sidebar.
		/// </summary>
		/// <param name="refreshList">If set to <c>true</c> refresh list.</param>
		private void UpdateStyleList(bool refreshList)
		{
			// Clear
			StyleList.Clear();

			// Repopulate
			foreach (KimonoStyle style in DesignSurface.Portfolio.Styles)
			{
				StyleList.AddItem(style.Name, "IconStyle", () =>
				 {
					 // Display editor for the given style
					 ShowStyleInspectors(style);
				 });
			}

			// Empty list?
			if (StyleList.Count == 0)
			{
				StyleList.AddItem("(empty)", "IconDocFolder");
			}

			// Refresh source list?
			if (refreshList) SourceList.ReloadData();
		}

		/// <summary>
		/// Updates the color list in the sidebar.
		/// </summary>
		/// <param name="refreshList">If set to <c>true</c> refresh list.</param>
		private void UpdateColorList(bool refreshList)
		{
			// Clear
			ColorList.Clear();

			// Repopulate
			foreach (KimonoColor color in DesignSurface.Portfolio.Colors)
			{
				ColorList.AddItem(color.Name, "IconColor", () =>
				 {
					 // Display editor for the given style
					 ShowPaletteColorInspectors(color);
				 });
			}

			// Empty list?
			if (ColorList.Count == 0)
			{
				ColorList.AddItem("(empty)", "IconDocFolder");
			}

			// Refresh source list?
			if (refreshList) SourceList.ReloadData();
		}

		/// <summary>
		/// Updates the gradient list.
		/// </summary>
		/// <param name="refreshList">If set to <c>true</c> refresh list.</param>
		private void UpdateGradientList(bool refreshList)
		{
			// Clear 
			GradientList.Clear();

			// Repopulate
			foreach (KimonoGradient gradient in DesignSurface.Portfolio.Gradients)
			{
				GradientList.AddItem(gradient.Name, "IconGradient", () =>
				 {
					 // Display editor for the given style
					 ShowGradientInspectors(gradient);
				 });
			}

			// Empty list?
			if (GradientList.Count == 0)
			{
				GradientList.AddItem("(empty)", "IconDocFolder");
			}

			// Refresh source list?
			if (refreshList) SourceList.ReloadData();
		}

		/// <summary>
		/// Updates the project list in the sidebar.
		/// </summary>
		/// <param name="refreshList">If set to <c>true</c> refresh list.</param>
		private void UpdateProjectList(bool refreshList)
		{
			// Clear
			ProjectList.Clear();

			// Repopulate
			ProjectList.AddItem("Portfolio", "IconPortfolio", () =>
				 {
					 // TODO: Display editor for the given portfolio
					 
				 });

			// Empty list?
			if (ProjectList.Count == 0)
			{
				ProjectList.AddItem("(empty)", "IconDocFolder");
			}

			// Refresh source list?
			if (refreshList) SourceList.ReloadData();
		}

		/// <summary>
		/// Updates the sketches list in the sidebar.
		/// </summary>
		/// <param name="refreshList">If set to <c>true</c> refresh list.</param>
		private void UpdateSketchesList(bool refreshList)
		{
			// Update path
			UpdatePath();

			// Clear
			SketchesList.Clear();

			// Repopulate
			foreach (KimonoSketch sketch in DesignSurface.Portfolio.Sketches)
			{
				SketchesList.AddItem(sketch.Name, "IconSketch", () =>
				 {
					// Display editor for the given sketch
					DesignSurface.SelectedSketch = sketch;
					SetDocumentSize();
					ShowSketchInspectors(sketch);
					UpdateShapesList(true);
				 });
			}

			// Empty list?
			if (SketchesList.Count == 0)
			{
				SketchesList.AddItem("(empty)", "IconDocFolder");
			}

			// Refresh source list?
			if (refreshList) SourceList.ReloadData();
		}

		/// <summary>
		/// Initializes the inspectors that allow the user to configure all
		/// of the elements in the <c>KimonoPortfolio</c> that is currently
		/// being edited.
		/// </summary>
		private void InitializeInspectors()
		{
			// Prepare inspector panels
			GeneralInfoInspector.Initialize();
			StarInspector.Initialize();
			PolygonInspector.Initialize();
			FillInspector.Initialize();
			FrameInspector.Initialize();
			StyleInspector.Initialize();
			AttachedStyleInspector.Initialize();
			ArrowInspector.Initialize();
			TextInspector.Initialize();
			FontInspector.Initialize();
			SketchInspector.Initialize();
			ColorPaletteInspector.Initialize();
			GradientInspector.Initialize();
			GroupInspector.Initialize();
			RoundRectInspector.Initialize();

			// Attach inspectors to the Design Surface
			GeneralInfoInspector.DesignSurface = DesignSurface;
			StarInspector.DesignSurface = DesignSurface;
			PolygonInspector.DesignSurface = DesignSurface;
			FillInspector.DesignSurface = DesignSurface;
			FrameInspector.DesignSurface = DesignSurface;
			StyleInspector.DesignSurface = DesignSurface;
			AttachedStyleInspector.DesignSurface = DesignSurface;
			ArrowInspector.DesignSurface = DesignSurface;
			TextInspector.DesignSurface = DesignSurface;
			FontInspector.DesignSurface = DesignSurface;
			SketchInspector.DesignSurface = DesignSurface;
			ColorPaletteInspector.DesignSurface = DesignSurface;
			GradientInspector.DesignSurface = DesignSurface;
			GroupInspector.DesignSurface = DesignSurface;
			RoundRectInspector.DesignSurface = DesignSurface;

			// Wire-up Inspector events
			// -- General Inspector -----------------------------------------
			GeneralInfoInspector.SketchModified += () =>
			{
				// Update the UI
				UpdateShapesList(true);
			};

			GeneralInfoInspector.ShapeModified += () =>
			{
				// Update design surface
				DesignSurface.RefreshView();
			};

			GeneralInfoInspector.MakeDuplicate += () =>
			{
				// Make duplicate of the selected shape
				DesignSurface.DuplicateSelectedShape();
			};

			GeneralInfoInspector.RemoveShape += () =>
			{
				// Delete the selected shape
				DesignSurface.DeleteSelectedShape();
			};

			GeneralInfoInspector.SelectionChanged += (selected) =>
			{
				// Anything selected
				if (selected == null)
				{
					// Close any open inspectors
					CloseAllInspectors();

					// Inform window of change
					RaiseSketchModified(DesignSurface.SelectedSketch);
				}
				else
				{
					// Show the required inspectors
					ShowGeneralInspectors(selected);
				}
			};

			// -- Group Inspector -----------------------------------------
			GroupInspector.GroupModified += (group) =>
			{

				// Show the required inspectors
				ShowGeneralInspectors(group);

				// Update design surface
				DesignSurface.RefreshView();

			};

			// -- Star Inspector -----------------------------------------
			StarInspector.ShapeModified += () =>
			{
				// Update design surface
				DesignSurface.RefreshView();
			};

			// -- Round Rectangle Inspector -----------------------------------------
			RoundRectInspector.ShapeModified += () =>
			{
				// Update design surface
				DesignSurface.RefreshView();
			};

			// -- Polygon Inspector -----------------------------------------
			PolygonInspector.ShapeModified += () =>
			{
				// Update design surface
				DesignSurface.RefreshView();
			};

			// -- Fill Inspector -----------------------------------------
			FillInspector.ShapeModified += () =>
			{
				// Update design surface
				DesignSurface.RefreshView();
			};

			FillInspector.MakeNewColor += (color) =>
			{
				AddNewColor(color);
			};

			// -- Frame Inspector -----------------------------------------
			FrameInspector.ShapeModified += () =>
			{
				// Update design surface
				DesignSurface.RefreshView();
			};

			FrameInspector.MakeNewColor += (color) =>
			{
				AddNewColor(color);
			};

			// -- Style Inspector -----------------------------------------
			StyleInspector.ShapeModified += () =>
			{
				// Update design surface
				DesignSurface.RefreshView();
			};

			StyleInspector.StyleModified += () =>
			{
				// Update style and design surface
				UpdateStyleList(true);
				DesignSurface.RefreshView();
			};

			StyleInspector.MakeDuplicate += (style) =>
			{
				// Duplicate style
				DuplicateStyle(style);
			};

			StyleInspector.RemoveStyle += (style) =>
			{
				// Delete style
				DeleteStyle(style);
			};

			StyleInspector.ReturnToShape += (shape) =>
			{
				// Update UI
				ShowGeneralInspectors(shape);
			};

			StyleInspector.StyleTypeChanged += (style) =>
			{
				// Update the inspector view to reflect change
				ShowStyleInspectors(style);
			};

			// -- Gradient Inspector -----------------------------------------
			GradientInspector.GradientModified += (gradient) =>
			{
				// Update list and design view
				UpdateGradientList(true);
				DesignSurface.RefreshView();
			};

			GradientInspector.ShapeModified += () =>
			{
				// Update design surface
				DesignSurface.RefreshView();
			};

			GradientInspector.MakeDuplicate += (gradient) =>
			{
				// Duplicate style
				DuplicateGradient(gradient);
			};

			GradientInspector.RemoveGradient += (gradient) =>
			{
				// Delete style
				DeleteGradient(gradient);
			};

			GradientInspector.ReturnToShape += (shape) =>
			{
				// Update UI
				ShowGeneralInspectors(shape);
			};

			// -- Color Palette Inspector -----------------------------------------
			ColorPaletteInspector.ColorModified += (color) =>
			{
				// Update UI
				UpdateColorList(true);
				DesignSurface.RefreshView();
			};

			ColorPaletteInspector.RemoveColor += (color) =>
			{
				DeleteColor(color);
			};

			ColorPaletteInspector.MakeDuplicate += (color) =>
			{
				DuplicateColor(color);
			};

			ColorPaletteInspector.ReturnToShape += (shape) =>
			{
				// Update UI
				ShowGeneralInspectors(shape);
			};

			// -- Attached Style Inspector -----------------------------------------
			AttachedStyleInspector.RemoveStyle += (style) =>
			{
				// Update UI
				ShowGeneralInspectors(DesignSurface.DeeplySelectedShape);
			};

			AttachedStyleInspector.EditAttachedStyle += (style) =>
			{
				// Update UI
				ShowStyleInspectors(style);
			};

			AttachedStyleInspector.ConvertToStyle += () =>
			{
				DesignSurface.Portfolio.ConvertSelectedShapeToStyle();
			};

			AttachedStyleInspector.ShapeModified += (shape) =>
			{
				// Update design surface
				ShowGeneralInspectors(shape);
				DesignSurface.RefreshView();
			};

			// -- Arrow Inspector -----------------------------------------
			ArrowInspector.ShapeModified += () =>
			{
				// Update design surface
				DesignSurface.RefreshView();
			};

			// -- Text Inspector -----------------------------------------
			TextInspector.ShapeModified += () =>
			{
				// Update design surface
				DesignSurface.RefreshView();
			};

			// -- Font Inspector -----------------------------------------
			FontInspector.ShapeModified += () =>
			{
				// Update design surface
				DesignSurface.RefreshView();
			};

			FontInspector.StyleModified += () =>
			{
				// Update style and design surface
				UpdateStyleList(true);
				DesignSurface.RefreshView();
			};

			// -- Sketch Inspector -----------------------------------------
			SketchInspector.SketchModified += () =>
			{
				// Update sketch list
				UpdateSketchesList(true);
			};

			SketchInspector.MakeDuplicate += () =>
			{
				// Duplicate current sketch
				DesignSurface.Portfolio.DuplicateSelectedSketch();
			};

			SketchInspector.RemoveSketch += () =>
			{
				// Remove current sketch
				DesignSurface.Portfolio.DeleteSelectedSketch();
			};
		}

		/// <summary>
		/// Closes all open inspectors.
		/// </summary>
		private void CloseAllInspectors()
		{
			// Close all inspector panels
			GeneralInfoInspector.RemoveFromSuperview();
			StarInspector.RemoveFromSuperview();
			PolygonInspector.RemoveFromSuperview();
			FillInspector.RemoveFromSuperview();
			FrameInspector.RemoveFromSuperview();
			StyleInspector.RemoveFromSuperview();
			AttachedStyleInspector.RemoveFromSuperview();
			ArrowInspector.RemoveFromSuperview();
			TextInspector.RemoveFromSuperview();
			FontInspector.RemoveFromSuperview();
			SketchInspector.RemoveFromSuperview();
			ColorPaletteInspector.RemoveFromSuperview();
			GradientInspector.RemoveFromSuperview();
			GroupInspector.RemoveFromSuperview();
			RoundRectInspector.RemoveFromSuperview();
		}

		/// <summary>
		/// Scrolls the inspector list to top.
		/// </summary>
		private void ScrollInspectorsToTop()
		{
			var point = new CGPoint(0, InspectorView.Bounds.Height);
			InspectorView.ScrollPoint(point);
		}

		/// <summary>
		/// Shows the general information inspectors for the given shape.
		/// </summary>
		/// <param name="shape">The <c>KimonoShape</c> to show the inspectors for.</param>
		private void ShowGeneralInspectors(KimonoShape shape)
		{
			var showFillFrame = true;

			// Close any open inspectors
			CloseAllInspectors();

			// Get initial offset
			var offset = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, View.Frame.Height);

			// Add required inspector panels
			GeneralInfoInspector.SelectedShape = shape;
			offset = GeneralInfoInspector.MoveTo(offset);
			InspectorView.AddSubview(GeneralInfoInspector);

			// Is this a round rectangle?
			if (shape is KimonoShapeRoundRect)
			{
				// Show the round rectangle inspector
				RoundRectInspector.SelectedRoundRect = shape as KimonoShapeRoundRect;
				offset = RoundRectInspector.MoveTo(offset);
				InspectorView.AddSubview(RoundRectInspector);
			}

			// Is this a star?
			if (shape is KimonoShapeStar)
			{
				// Show star inspector
				StarInspector.SelectedShape = shape as KimonoShapeStar;
				offset = StarInspector.MoveTo(offset);
				InspectorView.AddSubview(StarInspector);
			}

			// Is this a polygon?
			if (shape is KimonoShapePolygon)
			{
				// Show the polygon inspector
				PolygonInspector.SelectedShape = shape as KimonoShapePolygon;
				offset = PolygonInspector.MoveTo(offset);
				InspectorView.AddSubview(PolygonInspector);
			}

			// Is this an arrow?
			if (shape is KimonoShapeArrow)
			{
				ArrowInspector.SelectedShape = shape as KimonoShapeArrow;
				offset = ArrowInspector.MoveTo(offset);
				InspectorView.AddSubview(ArrowInspector);
			}

			// Is this a text box?
			if (shape is KimonoShapeText)
			{
				TextInspector.SelectedShape = shape as KimonoShapeText;
				offset = TextInspector.MoveTo(offset);
				InspectorView.AddSubview(TextInspector);
			}

			// Is this a group?
			if (shape is KimonoShapeGroup)
			{
				// Grab group
				var group = shape as KimonoShapeGroup;

				// Is this group a collection?
				if (group.GroupType == KimonoShapeGroupType.Collection)
				{
					// Yes, show the group inspector
					GroupInspector.SelectedGroup = group;
					offset = GroupInspector.MoveTo(offset);
					InspectorView.AddSubview(GroupInspector);
				}

				// Show style tools?
				showFillFrame = (group.IsBooleanConstruct && group.State != KimonoShapeState.Editing);
			}

			// Display the style editors?
			if (showFillFrame) {
				// Display attached style
				AttachedStyleInspector.SelectedStyle = shape.Style;
				AttachedStyleInspector.SelectedShape = shape;
				offset = AttachedStyleInspector.MoveTo(offset);
				InspectorView.AddSubview(AttachedStyleInspector);

				// Is a style attached?
				if (shape.Style.StyleType == KimonoStyleType.Custom ||
				   shape.Style.StyleType == KimonoStyleType.CustomText)
				{
					// No, add text properties
					if (shape.Style.StyleType == KimonoStyleType.CustomText)
					{
						FontInspector.SelectedStyle = shape.Style;
						FontInspector.SelectedShape = shape;
						offset = FontInspector.MoveTo(offset);
						InspectorView.AddSubview(FontInspector);
					}

					// Add Fill inspector
					if (!(shape is KimonoShapeLine))
					{
						FillInspector.SelectedStyle = shape.Style;
						offset = FillInspector.MoveTo(offset);
						InspectorView.AddSubview(FillInspector);
					}

					// Add Frame inspector
					FrameInspector.SelectedStyle = shape.Style;
					offset = FrameInspector.MoveTo(offset);
					InspectorView.AddSubview(FrameInspector);
				}
			}

			// Adjust Side content size
			var height = View.Frame.Height - offset;
			if (height < View.Frame.Height) height = View.Frame.Height;
			if (height < View.Frame.Height) height = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, height);
			ScrollInspectorsToTop();

			// Inform window of change
			RaiseSketchModified(DesignSurface.SelectedSketch);
		}

		/// <summary>
		/// Shows the style inspectors for the given style.
		/// </summary>
		/// <param name="style">The <c>KimonoStyle</c> to show the inspectors for.</param>
		private void ShowStyleInspectors(KimonoStyle style)
		{
			// Close any open inspectors
			CloseAllInspectors();

			// Get initial offset
			var offset = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, View.Frame.Height);

			// Add required inspector panels
			StyleInspector.SelectedStyle = style;
			StyleInspector.SelectedShape = DesignSurface.SelectedShape;
			offset = StyleInspector.MoveTo(offset);
			InspectorView.AddSubview(StyleInspector);

			// Add text properties
			if (style.StyleType == KimonoStyleType.Text)
			{
				FontInspector.SelectedStyle = style;
				FontInspector.SelectedShape = DesignSurface.SelectedShape;
				offset = FontInspector.MoveTo(offset);
				InspectorView.AddSubview(FontInspector);
			}

			// Add Fill inspector
			FillInspector.SelectedStyle = style;
			offset = FillInspector.MoveTo(offset);
			InspectorView.AddSubview(FillInspector);

			// Add Frame inspector
			FrameInspector.SelectedStyle = style;
			offset = FrameInspector.MoveTo(offset);
			InspectorView.AddSubview(FrameInspector);

			// Adjust Side content size
			var height = View.Frame.Height - offset;
			if (height < View.Frame.Height) height = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, height);
			ScrollInspectorsToTop();
		}

		/// <summary>
		/// Shows the palette color inspectors for the given color.
		/// </summary>
		/// <param name="color">The <c>KimonoColor</c> to show the inspectors for.</param>
		private void ShowPaletteColorInspectors(KimonoColor color)
		{
			// Close any open inspectors
			CloseAllInspectors();

			// Get initial offset
			var offset = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, View.Frame.Height);

			// Add required inspector panels
			ColorPaletteInspector.SelectedShape = DesignSurface.SelectedShape;
			ColorPaletteInspector.SelectedColor = color;
			offset = ColorPaletteInspector.MoveTo(offset);
			InspectorView.AddSubview(ColorPaletteInspector);

			// Adjust Side content size
			var height = View.Frame.Height - offset;
			if (height < View.Frame.Height) height = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, height);
			ScrollInspectorsToTop();
		}

		/// <summary>
		/// Shows the gradient inspectors.
		/// </summary>
		/// <param name="gradient">The <c>KimonoGradient</c> to show the inspector for.</param>
		private void ShowGradientInspectors(KimonoGradient gradient)
		{
			// Close any open inspectors
			CloseAllInspectors();

			// Get initial offset
			var offset = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, View.Frame.Height);

			// Add required inspector panels
			GradientInspector.SelectedGradient = gradient;
			GradientInspector.SelectedShape = DesignSurface.SelectedShape;
			offset = GradientInspector.MoveTo(offset);
			InspectorView.AddSubview(GradientInspector);

			// Adjust Side content size
			var height = View.Frame.Height - offset;
			if (height < View.Frame.Height) height = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, height);
			ScrollInspectorsToTop();
		}

		/// <summary>
		/// Shows the sketch inspectors for the given sketch.
		/// </summary>
		/// <param name="sketch">The <c>KimonoSketch</c> to show the inspectors for.</param>
		private void ShowSketchInspectors(KimonoSketch sketch)
		{
			// Close any open inspectors
			CloseAllInspectors();

			// Get initial offset
			var offset = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, View.Frame.Height);

			// Add required inspector panels
			SketchInspector.SelectedSketch = DesignSurface.SelectedSketch;
			offset = SketchInspector.MoveTo(offset);
			InspectorView.AddSubview(SketchInspector);

			// Adjust Side content size
			var height = View.Frame.Height - offset;
			if (height < View.Frame.Height) height = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, height);
			ScrollInspectorsToTop();
		}

		/// <summary>
		/// Adjusts the visible representation of the Design Surface to the dimentions of
		/// current <c>KimonoSketch</c> being edited.
		/// </summary>
		private void SetDocumentSize()
		{
			// Get size
			var width = (DesignSurface.SelectedSketch == null) ? 1 : DesignSurface.SelectedSketch.Width;
			var height = (DesignSurface.SelectedSketch == null) ? 1 : DesignSurface.SelectedSketch.Height;

			// Set document size
			DocumentViewWidth.Constant = width;
			DocumentViewHeight.Constant = height;

		}
		#endregion

		#region Override Methods
		/// <summary>
		/// Handles the view being sucessfully loaded.
		/// </summary>
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Set document size
			SetDocumentSize();

			// Configure the source list
			SourceList.Initialize();

			// Add projects
			ProjectList = new SourceListItem("Project");
			UpdateProjectList(false);
			SourceList.AddItem(ProjectList);

			// Add sketches
			SketchesList = new SourceListItem("Sketches");
			UpdateSketchesList(false);
			SourceList.AddItem(SketchesList);

			// Add Shapes
			ShapesList = new SourceListItem("Shapes");
			UpdateShapesList(false);
			SourceList.AddItem(ShapesList);

			// Add Styles
			StyleList = new SourceListItem("Styles");
			UpdateStyleList(false);
			SourceList.AddItem(StyleList);

			// Add Gradients
			GradientList = new SourceListItem("Gradients");
			UpdateGradientList(false);
			SourceList.AddItem(GradientList);

			// Add Colors
			ColorList = new SourceListItem("Colors");
			UpdateColorList(false);
			SourceList.AddItem(ColorList);

			// Display side list
			SourceList.ReloadData();
			SourceList.ExpandItem(null, true);

			// Prepare inspector panels
			InitializeInspectors();

			// Prepare the design surface
			DesignSurface.Initialize();

			// Wireup DesignSurface events
			DesignSurface.ToolChanged += HighlightTool;
			DesignSurface.SelectedShapeModified += GeneralInfoInspector.UpdateInspector;

			DesignSurface.ReloadUI += () =>
			{
				// Select tool
				HighlightTool(DesignSurface.SelectedSketch.Tool);

				// Update edit path
				UpdatePath();

				// Reload the entire sidebar
				UpdateProjectList(false);
				UpdateSketchesList(false);
				UpdateShapesList(false);
				UpdateStyleList(false);
				UpdateGradientList(false);
				UpdateColorList(false);
				SourceList.ReloadData();

				// Anything selected
				if (DesignSurface.DeeplySelectedShape == null)
				{
					// Close any open inspectors
					CloseAllInspectors();
				}
				else
				{
					// Show the required inspectors
					ShowGeneralInspectors(DesignSurface.DeeplySelectedShape);
				}

				// Redisplay the design surface
				DesignSurface.RefreshView();

				// Inform window of change
				RaiseSketchModified(DesignSurface.SelectedSketch);
			};

			DesignSurface.SketchModified += () =>
			{
				UpdateShapesList(true);
			};

			DesignSurface.SketchesModified += () =>
			{
				UpdateSketchesList(true);
			};

			DesignSurface.StylesModified += (style) =>
			{
				// Refresh style list
				UpdateStyleList(true);

				// Was a specific style modified?
				if (style != null)
				{
					// Yes, display that style
					ShowStyleInspectors(style);
				}
			};

			DesignSurface.ColorsModified += (color) =>
			{
				// Refresh colors list
				UpdateColorList(true);

				// Was a specific color modified?
				if (color != null)
				{
					// Yes, display that color
					ShowPaletteColorInspectors(color);
				}
			};

			DesignSurface.GradientsModified += (gradient) =>
			{

				// Refresh gradients list
				UpdateGradientList(true);

				// Was a specific gradient modified?
				if (gradient != null)
				{
					// Yes, display that gradient
					ShowGradientInspectors(gradient);
				}

			};

			DesignSurface.SelectionChanged += (selected) =>
			{
				// Anything selected
				if (selected == null)
				{
					// Close any open inspectors
					CloseAllInspectors();
				} else 
				{
					// Show the required inspectors
					ShowGeneralInspectors(selected);
				}

				// Inform window of change
				RaiseSketchModified(DesignSurface.SelectedSketch);
			};

			DesignSurface.SketchSizeChanged += () =>
			{
				SetDocumentSize();
			};

			// Update the design surface
			DesignSurface.RefreshView();

			// Display the sketch inspector
			ShowSketchInspectors(DesignSurface.SelectedSketch);

		}
		#endregion

		#region Custom Actions
		/// <summary>
		/// Validates any menu item attached to actions on this view controller based on its assigned
		/// <c>Tag</c> value.
		/// </summary>
		/// <returns><c>true</c>, if menu item was validated, <c>false</c> otherwise.</returns>
		/// <param name="item">The <c>NSMenuItem</c> being tested.</param>
		[Action("validateMenuItem:")]
		public bool ValidateMenuItem(NSMenuItem item)
		{

			// Take action based on the Menu Item type
			// (As specified in its Tag)
			switch (item.Tag)
			{
				case 1:
					// Can undo?
					return DesignSurface.CanUndo;
				case 2:
					// Can redo?
					return DesignSurface.CanRedo;
				case 3:
					// Can a collection of shapes be aligned?
					return DesignSurface.SelectedSketch.CanAlignShapes;
				case 4:
					// Can a collection of shapes be aligned?
					return DesignSurface.SelectedSketch.CanGroupShapes;
				case 5:
					// Can a collection of shapes be aligned?
					return DesignSurface.SelectedSketch.CanUngroupShapes;
				case 6:
					// Can a collection of shapes be aligned?
					return (DesignSurface.DeeplySelectedShape != null && !DesignSurface.SelectedSketch.SelectedShapeAtBottom);
				case 7:
					// Can a collection of shapes be aligned?
					return (DesignSurface.DeeplySelectedShape != null && !DesignSurface.SelectedSketch.SelectedShapeAtTop);
				case 8:
					// Anything selected?
					return (DesignSurface.DeeplySelectedShape != null);
			}

			return true;
		}

		/// <summary>
		/// Duplicates the selected shape.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("duplicateSelectedShape:")]
		public void DuplicateSelectedShape(NSObject sender)
		{
			DesignSurface.DuplicateSelectedShape();
		}

		/// <summary>
		/// Deletes the selected shape.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("delete:")]
		public void DeleteSelectedShape(NSObject sender)
		{
			DesignSurface.DeleteSelectedShape();
		}

		/// <summary>
		/// Groups or ungroups the currently selected group of shapes
		/// based on the current selection type.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("groupUngroupSelectedShapes:")]
		public void GroupUngroupSelectedShapes(NSObject sender)
		{
			DesignSurface.SelectedSketch.GroupUngroupSelectedShapes();
		}

		/// <summary>
		/// Udoes the last change.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("undo:")]
		public void Undo(NSObject sender)
		{
			DesignSurface.UndoChange();
		}

		/// <summary>
		/// Redoes the last change.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("redo:")]
		public void Redo(NSObject sender)
		{
			DesignSurface.RedoChange();
		}

		/// <summary>
		/// Moves the selected shape to bottom.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("moveToBottom:")]
		public void MoveToBottom(NSObject sender)
		{
			if (DesignSurface.DeeplySelectedGroup != null)
			{
				DesignSurface.DeeplySelectedGroup.MoveSelectedShapeToBottom();
			}
			else
			{
				DesignSurface.SelectedSketch.MoveSelectedShapeToBottom();
			}
		}

		/// <summary>
		/// Moves the selected shape backwards.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("moveBackwards:")]
		public void MoveBackwards(NSObject sender)
		{
			if (DesignSurface.DeeplySelectedGroup != null)
			{
				DesignSurface.DeeplySelectedGroup.MoveSelectedShapeBackwards();
			}
			else
			{
				DesignSurface.SelectedSketch.MoveSelectedShapeBackwards();
			}
		}

		/// <summary>
		/// Moves the selected shape forwards.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("moveForwards:")]
		public void MoveForwards(NSObject sender)
		{
			if (DesignSurface.DeeplySelectedGroup != null)
			{
				DesignSurface.DeeplySelectedGroup.MoveSelectedShapeForwards();
			}
			else
			{
				DesignSurface.SelectedSketch.MoveSelectedShapeForwards();
			}
		}

		/// <summary>
		/// Moves the selected shape to top.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("moveToTop:")]
		public void MoveToTop(NSObject sender)
		{
			if (DesignSurface.DeeplySelectedGroup != null)
			{
				DesignSurface.DeeplySelectedGroup.MoveSelectedShapeToTop(); 
			}
			else
			{
				DesignSurface.SelectedSketch.MoveSelectedShapeToTop();
			}
		}

		/// <summary>
		/// Aligns the shape tops.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("alignShapeTop:")]
		public void AlignShapeTop(NSObject sender)
		{
			var group = DesignSurface.DeeplySelectedShape as KimonoShapeGroup;
			group.AlignAllTop();
		}

		/// <summary>
		/// Aligns the shape bottoms.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("alignShapeBottom:")]
		public void AlignShapeBottom(NSObject sender)
		{
			var group = DesignSurface.DeeplySelectedShape as KimonoShapeGroup;
			group.AlignAllBottom();
		}

		/// <summary>
		/// Aligns the shape left sides.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("alignShapeLeft:")]
		public void AlignShapeLeft(NSObject sender)
		{
			var group = DesignSurface.DeeplySelectedShape as KimonoShapeGroup;
			group.AlignAllLeft();
		}

		/// <summary>
		/// Aligns the shape right sides.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("alignShapeRight:")]
		public void AlignShapeRight(NSObject sender)
		{
			var group = DesignSurface.DeeplySelectedShape as KimonoShapeGroup;
			group.AlignAllRight();
		}

		/// <summary>
		/// Aligns the shape centers.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("alignShapeCenter:")]
		public void AlignShapeCenter(NSObject sender)
		{
			var group = DesignSurface.DeeplySelectedShape as KimonoShapeGroup;
			group.AlignAllCenter();
		}

		/// <summary>
		/// Aligns the shape centers horizontally.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("alignShapeCenterHorizontal:")]
		public void AlignShapeCenterHorizontal(NSObject sender)
		{
			var group = DesignSurface.DeeplySelectedShape as KimonoShapeGroup;
			group.AlignAllCenterHorizontal();
		}

		/// <summary>
		/// Aligns the shape centers vertically.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("alignShapeCenterVertical:")]
		public void AlignShapeCenterVertical(NSObject sender)
		{
			var group = DesignSurface.DeeplySelectedShape as KimonoShapeGroup;
			group.AlignAllCenterVertical();
		}

		/// <summary>
		/// Goes the back to sketch.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void GoBackToSketch(Foundation.NSObject sender)
		{
			// Ask all groups in current path to end editing
			if (DesignSurface.DeeplySelectedGroup != null)
			{
				DesignSurface.DeeplySelectedGroup.ReturnToSketch();
			}
		}

		/// <summary>
		/// Tool arrow selected.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ToolArrowSelected(Foundation.NSObject sender)
		{
			// Select the correct tool
			DesignSurface.Tool = KimonoTool.Arrow;
		}

		/// <summary>
		/// Tool bezier selected.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ToolBezierSelected(Foundation.NSObject sender)
		{
			// Select the correct tool
			DesignSurface.Tool = KimonoTool.Bezier;
		}

		/// <summary>
		/// Tool cursor selected.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ToolCursorSelected(Foundation.NSObject sender)
		{
			// Select the correct tool
			DesignSurface.Tool = KimonoTool.Cursor;
		}

		/// <summary>
		/// Tool line selected.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ToolLineSelected(Foundation.NSObject sender)
		{
			// Select the correct tool
			DesignSurface.Tool = KimonoTool.Line;
		}

		/// <summary>
		/// Tool oval selected.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ToolOvalSelected(Foundation.NSObject sender)
		{
			// Select the correct tool
			DesignSurface.Tool = KimonoTool.Oval;
		}

		/// <summary>
		/// Tool polygon selected.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ToolPolygonSelected(Foundation.NSObject sender)
		{
			// Select the correct tool
			DesignSurface.Tool = KimonoTool.Polygon;
		}

		/// <summary>
		/// Tool rect selected.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ToolRectSelected(Foundation.NSObject sender)
		{
			// Select the correct tool
			DesignSurface.Tool = KimonoTool.Rectangle;
		}

		/// <summary>
		/// Tool round rect selected.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ToolRoundRectSelected(Foundation.NSObject sender)
		{
			// Select the correct tool
			DesignSurface.Tool = KimonoTool.RoundRect;
		}

		/// <summary>
		/// Tool star selected.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ToolStarSelected(Foundation.NSObject sender)
		{
			// Select the correct tool
			DesignSurface.Tool = KimonoTool.Star;
		}

		/// <summary>
		/// Tool text selected.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ToolTextSelected(Foundation.NSObject sender)
		{
			// Select the correct tool
			DesignSurface.Tool = KimonoTool.Text;
		}

		/// <summary>
		/// Tool triangle selected.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ToolTriangleSelected(Foundation.NSObject sender)
		{
			// Select the correct tool
			DesignSurface.Tool = KimonoTool.Triangle;
		}

		/// <summary>
		/// Tool vector selected.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ToolVectorSelected(Foundation.NSObject sender)
		{
			// Select the correct tool
			DesignSurface.Tool = KimonoTool.Vector;
		}
		#endregion

		#region Events
		/// <summary>
		/// Occurs when the sketch is modified.
		/// </summary>
		public event Kimono.SketchEventDelegate SketchModified;

		/// <summary>
		/// Raises the sketch modified event.
		/// </summary>
		/// <param name="sketch">Sketch.</param>
		internal void RaiseSketchModified(KimonoSketch sketch)
		{
			// Inform caller of event
			if (SketchModified != null) SketchModified(sketch);
		}
		#endregion
	}
}
