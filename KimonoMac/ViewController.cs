using System;
using AppKit;
using CoreGraphics;
using Foundation;
using SkiaSharp;
using KimonoCore;
using KimonoCore.Mac;
using AppKit.TextKit.Formatter;
using System.IO;

namespace KimonoMac
{
	/// <summary>
	/// Handles the master view for the Kimono Designer.
	/// </summary>
	public partial class ViewController : NSViewController
	{
		#region Application Access
		/// <summary>
		/// A helper shortcut to the app delegate.
		/// </summary>
		/// <value>The app.</value>
		public static AppDelegate App
		{
			get { return (AppDelegate)NSApplication.SharedApplication.Delegate; }
		}
		#endregion

		#region Private Variables
		/// <summary>
		/// The information on the currently highlighted keyword.
		/// </summary>
		private KeywordDescriptor _keywordInfo = null;

		/// <summary>
		/// Holds the current inspector view that is being displayed.
		/// </summary>
		private InspectorViewMode _currentInspectorMode = InspectorViewMode.DetailsView;

		/// <summary>
		/// The Kimono element that is currently being inspected.
		/// </summary>
		private object InspectingElement = null;
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets the design surface surface.
		/// </summary>
		/// <value>The currently active Kimono Design Surface.</value>
		public KimonoDesignSurface Surface
		{
			get { return DesignSurface; }
		}

		/// <summary>
		/// Gets or sets the inspector view mode.
		/// </summary>
		/// <value>The `InspectorViewMode`.</value>
		public InspectorViewMode CurrentInspectorMode
		{
			get { return _currentInspectorMode; } 
			set
			{
				// Save new value
				_currentInspectorMode = value;

				// Set on/off states
				DetailsInspectorButton.Image = (_currentInspectorMode == InspectorViewMode.DetailsView) ? NSImage.ImageNamed("IconDetailsOn") : NSImage.ImageNamed("IconDetailsOff");
				FillInspectorsButton.Image = (_currentInspectorMode == InspectorViewMode.FillStyleView) ? NSImage.ImageNamed("IconFillOn") : NSImage.ImageNamed("IconFillOff");
				BorderInspectorsButton.Image = (_currentInspectorMode == InspectorViewMode.BorderStyleView) ? NSImage.ImageNamed("IconBorderOn") : NSImage.ImageNamed("IconBorderOff");
				ConnectionInspectorsButton.Image = (_currentInspectorMode == InspectorViewMode.ConnectionView) ? NSImage.ImageNamed("IconConnectionOn") : NSImage.ImageNamed("IconConnectionOff");
			}
		}

		/// <summary>
		/// Gets or sets the OS that code will be generated for.
		/// </summary>
		/// <value>The OS code type.</value>
		public CodeOutputOS GenerateOSCode { get; set; } = CodeOutputOS.macOS;

		/// <summary>
		/// Gets or sets the language code will be generated in.
		/// </summary>
		/// <value>The code language.</value>
		public CodeOutputLanguage GenerateLanguageCode { get; set; } = CodeOutputLanguage.CSharp;

		/// <summary>
		/// Gets or sets the library the generated code will use.
		/// </summary>
		/// <value>The library to use in the generated code.</value>
		public CodeOutputLibrary GenerateLibraryCode { get; set; } = CodeOutputLibrary.SkiaSharp;

		/// <summary>
		/// Gets or sets the Kimono object that preview code is currently being generated for.
		/// </summary>
		/// <value>The kimono preview element.</value>
		public IKimonoCodeGeneration KimonoPreviewElement { get; set; } = null;

		/// <summary>
		/// Gets or sets the `KimonoProperty` currently being edited.
		/// </summary>
		/// <value>The editing property.</value>
		public KimonoProperty EditingProperty { get; set; } = null;

		/// <summary>
		/// Gets or sets the default language that this `ViewController` will
		/// be editing.
		/// </summary>
		/// <value>An integer representing the default language as: 0 - C#,
		/// 1 - HTML, 2 - MarkDown, 3 - XML.</value>
		public int DefaultLanguage { get; set; } = 0; //App.Preferences.DefaultLanguage;

		/// <summary>
		/// Gets or sets the parent window controller.
		/// </summary>
		/// <value>The parent window controller.</value>
		public MainWindowController ParentWindowController { get; set; } = null;

		/// <summary>
		/// Gets or sets a value indicating whether this `ViewController` document 
		/// has been edited.
		/// </summary>
		/// <value><c>true</c> if document has been edited; otherwise, <c>false</c>.</value>
		public bool DocumentEdited
		{
			get { return View.Window.DocumentEdited; }
			set {
				if (View.Window != null)
				{
					View.Window.DocumentEdited = value;
				}
			}
		}

		/// <summary>
		/// Gets the <see cref="AppKit.TextKit.Formatter.SourceTextView"/> attached to this view.
		/// </summary>
		/// <value>The <see cref="AppKit.TextKit.Formatter.SourceTextView"/> used to edit source.</value>
		public SourceTextView Editor
		{
			get { return TextEditor; }
		}

		/// <summary>
		/// Gets or sets the text for the <c>NSTextView</c> being used as a text editor
		/// </summary>
		/// <value>The string content of the <c>NSTextView</c>.</value>
		public string Text
		{
			get { return TextEditor.TextStorage.Value; }
			set
			{
				TextEditor.Value = value;
				Formatter.Reformat();
			}
		}

		/// <summary>
		/// Gets or sets the <see cref="AppKit.TextKit.Formatter.LanguageFormatter"/> used to perform
		/// syntax highlighting on the <c>NSTextView</c> containing the contents of the document being
		/// edited.
		/// </summary>
		/// <value>The <see cref="AppKit.TextKit.Formatter.LanguageFormatter"/> for the selected language.</value>
		public LanguageFormatter Formatter
		{
			get { return TextEditor.Formatter; }
			set { TextEditor.Formatter = value; }
		}

		/// <summary>
		/// Gets or sets the full file path where this document was last loaded from
		/// or saved to.
		/// </summary>
		/// <value>The file path.</value>
		/// <remarks>>The path will be the empty string ("") if the document has never
		/// been saved to a file.</remarks>
		public string FilePath { get; set; } = "";

		/// <summary>
		/// Gets or sets the info about the currently selected keyword.
		/// </summary>
		/// <value>The keyword info.</value>
		public KeywordDescriptor KeywordInfo
		{
			get { return _keywordInfo; }
			set
			{
				_keywordInfo = value;
				if (WindowController != null)
				{
					//WindowController.DefinitionItem.Disabled = (_keywordInfo == null);
					//App.DefinitionItem.Enabled = (!WindowController.DefinitionItem.Disabled);
				}
			}
		}

		/// <summary>
		/// Gets the window controller.
		/// </summary>
		/// <value>The window controller.</value>
		public MainWindowController WindowController
		{
			get
			{
				if (View.Window == null)
				{
					return null;
				}
				else
				{
					return View.Window.WindowController as MainWindowController;
				}
			}
		}

		/// <summary>
		/// Gets or sets the keyword that is currently selected.
		/// </summary>
		/// <value>The keyword.</value>
		public string Keyword { get; set; } = "";

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

		/// <summary>
		/// Gets or sets the property list.
		/// </summary>
		/// <value>The property list.</value>
		public SourceListItem PropertyList { get; set; }
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
		/// Configures the editor with the current user preferences.
		/// </summary>
		public void ConfigureEditor()
		{

			// General Preferences
			TextEditor.AutomaticLinkDetectionEnabled = true;
			TextEditor.AutomaticQuoteSubstitutionEnabled = false;
			TextEditor.AutomaticDashSubstitutionEnabled = false;
			TextEditor.AutomaticDataDetectionEnabled = true;
			TextEditor.AutomaticTextReplacementEnabled = true;
			TextEditor.SmartInsertDeleteEnabled = true;
			TextEditor.ContinuousSpellCheckingEnabled = false;
			TextEditor.AutomaticSpellingCorrectionEnabled = false;
			TextEditor.GrammarCheckingEnabled = false;

			// Editor Preferences
			TextEditor.RichText = true;
			TextEditor.ImportsGraphics = false;
			TextEditor.AllowsImageEditing = false;
			TextEditor.AllowsDocumentBackgroundColorChange = false;
			TextEditor.BackgroundColor = NSColor.White;
			TextEditor.UsesFontPanel = false;
			TextEditor.UsesRuler = false;
			TextEditor.UsesInspectorBar = false;
			TextEditor.CompleteClosures = true;
			TextEditor.WrapClosures = true;
			TextEditor.SelectAfterWrap = true;

			// Search Preferences
			switch (App.Preferences.SearchType)
			{
				case 0:
					// None
					TextEditor.UsesFindBar = false;
					TextEditor.UsesFindPanel = false;
					break;
				case 1:
					// Uses bar
					TextEditor.UsesFindBar = true;
					break;
				case 2:
					// Uses panel
					TextEditor.UsesFindPanel = true;
					break;
			}
			TextEditor.IsIncrementalSearchingEnabled = true;

			// Auto Complete Preferences
			TextEditor.AllowAutoComplete = true;
			TextEditor.AutoCompleteKeywords = true;
			TextEditor.AutoCompleteDefaultWords = true;
			TextEditor.DefaultWordsOnlyIfKeywordsEmpty = true;

		}

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
					if (CurrentInspectorMode == InspectorViewMode.ConnectionView)
					 {
						 ShowConnectionInspectors(InspectingElement as IKimonoPropertyConsumer);
					 }
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
		/// Updates the property list.
		/// </summary>
		/// <param name="refreshList">If set to <c>true</c> refresh list.</param>
		private void UpdatePropertyList(bool refreshList)
		{
			// Clear 
			PropertyList.Clear();

			// Repopulate
			foreach (KimonoProperty property in DesignSurface.Portfolio.Properties)
			{
				PropertyList.AddItem(property.Name, "IconProperty", () =>
				 {
					 // Display editor for the given style
					 ShowPropertyInspectors(property);
				 });
			}

			// Empty list?
			if (PropertyList.Count == 0)
			{
				PropertyList.AddItem("(empty)", "IconDocFolder");
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
					 // Update the UI
					 ShowPortfolioInspectors(DesignSurface.Portfolio);
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
			PropertyInspector.Initialize();
			PortfolioInspector.Initialize();
			BooleanPropertyInspector.Initialize();
			NumberPropertyInspector.Initialize();
			RectPropertyInspector.Initialize();
			TextPropertyInspector.Initialize();
			ConnectionsInspector.Initialize();
			ScriptDebuggerInspector.Initialize();
			PointInspector.Initialize();

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
			PropertyInspector.DesignSurface = DesignSurface;
			PortfolioInspector.DesignSurface = DesignSurface;
			BooleanPropertyInspector.DesignSurface = DesignSurface;
			NumberPropertyInspector.DesignSurface = DesignSurface;
			RectPropertyInspector.DesignSurface = DesignSurface;
			TextPropertyInspector.DesignSurface = DesignSurface;
			ConnectionsInspector.DesignSurface = DesignSurface;
			ScriptDebuggerInspector.DesignSurface = DesignSurface;
			PointInspector.DesignSurface = DesignSurface;

			// Wire-up Inspector events
			// -- General Inspector -----------------------------------------
			GeneralInfoInspector.SketchModified += () =>
			{
				// Update the UI
				DocumentEdited = true;
				UpdateShapesList(true);
				UpdateTextEditor();
			};

			GeneralInfoInspector.ShapeModified += () =>
			{
				// Update design surface
				DocumentEdited = true;
				DesignSurface.RefreshView();
				UpdateTextEditor();
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

			// -- Connection Inspector -----------------------------------------
			ConnectionsInspector.ConnectionModified += () =>
			{
				// Update UI
				DocumentEdited = true;
				DesignSurface.RefreshView();
				UpdateTextEditor();
			};

			// -- Point Inspector -----------------------------------------
			PointInspector.ShapeModified += () =>
			{
				// Update UI
				DocumentEdited = true;
				DesignSurface.RefreshView();
				UpdateTextEditor();
			};

			// -- Property Inspector -----------------------------------------
			PropertyInspector.PropertyModified += (property) =>
			{
				// Update UI
				DocumentEdited = true;
				UpdatePropertyList(true);
				DesignSurface.RefreshView();
				UpdateTextEditor();
				ShowPropertyInspectors(property);
			};

			PropertyInspector.RequestDeleteProperty += (property) =>
			{
				// Delete requested property
				DesignSurface.Portfolio.DeleteProperty(property);

				// Update UI
				DocumentEdited = true;
				CloseAllInspectors();
				UpdatePropertyList(true);
				DesignSurface.RefreshView();
			};

			PropertyInspector.RequestDuplicateProperty += (property) =>
			{
				// Duplicate property
				var newProperty = DesignSurface.Portfolio.DuplicateProperty(property);

				// Update UI
				DocumentEdited = true;
				UpdatePropertyList(true);
				ShowPropertyInspectors(newProperty);
			};

			// -- Script Debug Inspector -----------------------------------------
			ScriptDebuggerInspector.PropertyModified += (property) =>
			{
				// Update UI
				DocumentEdited = true;
				DesignSurface.RefreshView();
				UpdateTextEditor();
				ShowPropertyInspectors(property);
			};

			// -- Boolean Property Inspector -----------------------------------------
			BooleanPropertyInspector.PropertyModified += (property) =>
			{
				// Update UI
				DocumentEdited = true;
				DesignSurface.RefreshView();
			};

			// -- Number Property Inspector -----------------------------------------
			NumberPropertyInspector.PropertyModified += (property) =>
			{
				// Update UI
				DocumentEdited = true;
				DesignSurface.RefreshView();
			};

			// -- Rect Property Inspector -----------------------------------------
			RectPropertyInspector.PropertyModified += (property) =>
			{
				// Update UI
				DocumentEdited = true;
				DesignSurface.RefreshView();
			};

			// -- Text Property Inspector -----------------------------------------
			TextPropertyInspector.PropertyModified += (property) =>
			{
				// Update UI
				DocumentEdited = true;
				DesignSurface.RefreshView();
			};

			// -- Group Inspector -----------------------------------------
			GroupInspector.GroupModified += (group) =>
			{

				// Show the required inspectors
				ShowGeneralInspectors(group);

				// Update design surface
				DocumentEdited = true;
				DesignSurface.RefreshView();

			};

			// -- Star Inspector -----------------------------------------
			StarInspector.ShapeModified += () =>
			{
				// Update design surface
				DocumentEdited = true;
				DesignSurface.RefreshView();
				UpdateTextEditor();
			};

			// -- Round Rectangle Inspector -----------------------------------------
			RoundRectInspector.ShapeModified += () =>
			{
				// Update design surface
				DocumentEdited = true;
				DesignSurface.RefreshView();
				UpdateTextEditor();
			};

			// -- Polygon Inspector -----------------------------------------
			PolygonInspector.ShapeModified += () =>
			{
				// Update design surface
				DocumentEdited = true;
				DesignSurface.RefreshView();
				UpdateTextEditor();
			};

			// -- Fill Inspector -----------------------------------------
			FillInspector.ShapeModified += () =>
			{
				// Update design surface
				DocumentEdited = true;
				DesignSurface.RefreshView();
				UpdateTextEditor();
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
				UpdateTextEditor();
			};

			FrameInspector.MakeNewColor += (color) =>
			{
				DocumentEdited = true;
				AddNewColor(color);
			};

			// -- Style Inspector -----------------------------------------
			StyleInspector.ShapeModified += () =>
			{
				// Update design surface
				DocumentEdited = true;
				DesignSurface.RefreshView();
			};

			StyleInspector.StyleModified += () =>
			{
				// Update style and design surface
				DocumentEdited = true;
				UpdateStyleList(true);
				DesignSurface.RefreshView();
				UpdateTextEditor();
			};

			StyleInspector.MakeDuplicate += (style) =>
			{
				// Duplicate style
				DocumentEdited = true;
				DuplicateStyle(style);
			};

			StyleInspector.RemoveStyle += (style) =>
			{
				// Delete style
				DocumentEdited = true;
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
				DocumentEdited = true;
				ShowStyleInspectors(style);
			};

			// -- Gradient Inspector -----------------------------------------
			GradientInspector.GradientModified += (gradient) =>
			{
				// Update list and design view
				DocumentEdited = true;
				UpdateGradientList(true);
				DesignSurface.RefreshView();
				UpdateTextEditor();
			};

			GradientInspector.ShapeModified += () =>
			{
				// Update design surface
				DocumentEdited = true;
				DesignSurface.RefreshView();
				UpdateTextEditor();
			};

			GradientInspector.MakeDuplicate += (gradient) =>
			{
				// Duplicate style
				DocumentEdited = true;
				DuplicateGradient(gradient);
			};

			GradientInspector.RemoveGradient += (gradient) =>
			{
				// Delete style
				DocumentEdited = true;
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
				DocumentEdited = true;
				UpdateColorList(true);
				DesignSurface.RefreshView();
				UpdateTextEditor();
			};

			ColorPaletteInspector.RemoveColor += (color) =>
			{
				DocumentEdited = true;
				DeleteColor(color);
			};

			ColorPaletteInspector.MakeDuplicate += (color) =>
			{
				DocumentEdited = true;
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
				DocumentEdited = true;
				ShowGeneralInspectors(DesignSurface.DeeplySelectedShape);
			};

			AttachedStyleInspector.EditAttachedStyle += (style) =>
			{
				// Update UI
				DocumentEdited = true;
				ShowStyleInspectors(style);
			};

			AttachedStyleInspector.ConvertToStyle += () =>
			{
				DocumentEdited = true;
				DesignSurface.Portfolio.ConvertSelectedShapeToStyle();
			};

			AttachedStyleInspector.ShapeModified += (shape) =>
			{
				// Update design surface
				DocumentEdited = true;
				ShowGeneralInspectors(shape);
				DesignSurface.RefreshView();
				UpdateTextEditor();
			};

			// -- Arrow Inspector -----------------------------------------
			ArrowInspector.ShapeModified += () =>
			{
				// Update design surface
				DocumentEdited = true;
				DesignSurface.RefreshView();
				UpdateTextEditor();
			};

			// -- Text Inspector -----------------------------------------
			TextInspector.ShapeModified += () =>
			{
				// Update design surface
				DocumentEdited = true;
				DesignSurface.RefreshView();
				UpdateTextEditor();
			};

			// -- Font Inspector -----------------------------------------
			FontInspector.ShapeModified += () =>
			{
				// Update design surface
				DocumentEdited = true;
				DesignSurface.RefreshView();
				UpdateTextEditor();
			};

			FontInspector.StyleModified += () =>
			{
				// Update style and design surface
				DocumentEdited = true;
				UpdateStyleList(true);
				DesignSurface.RefreshView();
			};

			// -- Sketch Inspector -----------------------------------------
			SketchInspector.SketchModified += () =>
			{
				// Update sketch list
				DocumentEdited = true;
				UpdateSketchesList(true);
				UpdateTextEditor();
			};

			SketchInspector.MakeDuplicate += () =>
			{
				// Duplicate current sketch
				DocumentEdited = true;
				DesignSurface.Portfolio.DuplicateSelectedSketch();
			};

			SketchInspector.RemoveSketch += () =>
			{
				// Remove current sketch
				DocumentEdited = true;
				DesignSurface.Portfolio.DeleteSelectedSketch();
			};

			// -- Portfolio Inspector -----------------------------------------
			PortfolioInspector.PortfolioModified += () =>
			{
				// Update the code generation
				DocumentEdited = true;
				UpdateTextEditor();
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
			PropertyInspector.RemoveFromSuperview();
			PortfolioInspector.RemoveFromSuperview();
			BooleanPropertyInspector.RemoveFromSuperview();
			NumberPropertyInspector.RemoveFromSuperview();
			RectPropertyInspector.RemoveFromSuperview();
			TextPropertyInspector.RemoveFromSuperview();
			ConnectionsInspector.RemoveFromSuperview();
			ScriptDebuggerInspector.RemoveFromSuperview();
			PointInspector.RemoveFromSuperview();
		}

		/// <summary>
		/// Shows the property obi script.
		/// </summary>
		private void ShowPropertyObiScript(KimonoProperty property)
		{
			// Set UI state
			KimonoPreviewElement = null;
			EditingProperty = property;

			// Configure Editor
			Formatter = new LanguageFormatter(TextEditor, new ObiScriptDescriptor());
			TextEditorMode.StringValue = (EditingProperty.GetsValueFromScript) ? "Editing" : "Showing";
			TextEditorTitle.StringValue = $"{EditingProperty.Name} Script";
			TextEditor.Editable = EditingProperty.GetsValueFromScript;
			Text = EditingProperty.ObiScript;

			// Update UI
			OSSelector.SelectItem(7);
			OSSelector.Enabled = false;
			LanguageSelector.SelectItem(1);
			LanguageSelector.Enabled = false;
			LibrarySelector.SelectItem(1);
			LibrarySelector.Enabled = false;
			ExportButton.Enabled = false;
		}

		/// <summary>
		/// Clears the text editor.
		/// </summary>
		private void ClearTextEditor()
		{
			KimonoPreviewElement = null;
			EditingProperty = null;

			// Configure Editor
			TextEditorMode.StringValue = "Preview";
			TextEditorTitle.StringValue = $"Nothing Selected";
			Text = "";
			TextEditor.Editable = false;

			// Update UI
			OSSelector.Enabled = false;
			LanguageSelector.Enabled = false;
			LibrarySelector.Enabled = false;
			ExportButton.Enabled = false;
		}

		/// <summary>
		/// Shows the code preview.
		/// </summary>
		/// <param name="kimonoElement">Kimono element.</param>
		private void ShowCodePreview(IKimonoCodeGeneration kimonoElement)
		{
			// Set UI state
			KimonoPreviewElement = kimonoElement;
			EditingProperty = null;

			// Configure Editor
			TextEditorMode.StringValue = "Preview";
			TextEditorTitle.StringValue = $"{KimonoPreviewElement.Name} Code";
			TextEditor.Editable = false;

			// Set OS
			switch (GenerateOSCode)
			{
				case CodeOutputOS.Android:
					OSSelector.SelectItem(3);
					break;
				case CodeOutputOS.CrossPlatform:
					OSSelector.SelectItem(7);
					break;
				case CodeOutputOS.iOS:
					OSSelector.SelectItem(4);
					break;
				case CodeOutputOS.tvOS:
					OSSelector.SelectItem(5);
					break;
				case CodeOutputOS.macOS:
					OSSelector.SelectItem(6);
					break;
				case CodeOutputOS.Windows:
					OSSelector.SelectItem(0);
					break;
				case CodeOutputOS.WindowsUWP:
					OSSelector.SelectItem(1);
					break;
				case CodeOutputOS.WindowsWPF:
					OSSelector.SelectItem(2);
					break;
			}
			OSSelector.Enabled = true;

			// Set language
			switch (GenerateLanguageCode)
			{
				case CodeOutputLanguage.CSharp:
					Formatter = new LanguageFormatter(TextEditor, new CSharpDescriptor());
					LanguageSelector.SelectItem(0);
					break;
				case CodeOutputLanguage.ObiScript:
					Formatter = new LanguageFormatter(TextEditor, new ObiScriptDescriptor());
					LanguageSelector.SelectItem(1);
					break;
				case CodeOutputLanguage.FSharp :
					Formatter = new LanguageFormatter(TextEditor, new FSharpDescriptor());
					LanguageSelector.SelectItem(2);
					break;
				default:
					throw new ArgumentOutOfRangeException($"Unsupported language code {GenerateLanguageCode}");	
					
			}
			LanguageSelector.Enabled = true;

			// Set library
			switch (GenerateLibraryCode)
			{
				case CodeOutputLibrary.SkiaSharp:
					LibrarySelector.SelectItem(0);
					break;
				case CodeOutputLibrary.KimonoCore:
					LibrarySelector.SelectItem(1);
					break;
			}
			LibrarySelector.Enabled = true;

			// Show preview code
			KimonoCodeGenerator.ResetCodeGeneration();
			Text = KimonoPreviewElement.ToCode(GenerateOSCode, GenerateLanguageCode, GenerateLibraryCode);

			// Enable export?
			ExportButton.Enabled = (LanguageSelector.IndexOfSelectedItem != 1);
		}

		/// <summary>
		/// Updates the text editor.
		/// </summary>
		private void UpdateTextEditor()
		{
			// Take action based on the selected object
			if (KimonoPreviewElement != null)
			{
				// Switch the editor to the code preview mode
				ShowCodePreview(KimonoPreviewElement);
			}
			else if (EditingProperty != null)
			{
				// Switch to the property editor mode
				ShowPropertyObiScript(EditingProperty);
			}
			else
			{
				// Empty the text editor
				ClearTextEditor();
			}
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
			var showFillFrame = (shape.Style.StyleType == KimonoStyleType.Custom ||
					   shape.Style.StyleType == KimonoStyleType.CustomText);
			var showStyle = true;

			// Close any open inspectors
			CloseAllInspectors();

			// Save the shape being inspected
			InspectingElement = shape;

			// Should show fill/frame?
			if (shape is KimonoShapeGroup)
			{
				// Grab group
				var group = shape as KimonoShapeGroup;

				// Show style tools?
				showStyle = (group.IsBooleanConstruct && group.State != KimonoShapeState.Editing);
				showFillFrame = (showFillFrame && showStyle);
			}

			// Validate the current mode
			switch (CurrentInspectorMode)
			{
				case InspectorViewMode.DetailsView:
					break;
				case InspectorViewMode.FillStyleView:
					if (shape is KimonoShapeLine || !showFillFrame)
					{
						CurrentInspectorMode = InspectorViewMode.DetailsView;
					}
					break;
				case InspectorViewMode.BorderStyleView:
					if (!showFillFrame)
					{
						CurrentInspectorMode = InspectorViewMode.DetailsView;
					}
					break;
				case InspectorViewMode.ConnectionView:
					break;
			}

			// Update inspector UI
			FillInspectorsButton.Enabled =(showFillFrame && !(shape is KimonoShapeLine));
			BorderInspectorsButton.Enabled = showFillFrame;
			ConnectionInspectorsButton.Enabled = true;

			// Get initial offset
			var offset = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, View.Frame.Height);

			// Show inspectors based on the view mode
			switch (CurrentInspectorMode)
			{
				case InspectorViewMode.DetailsView:
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
					}

					// Is a control point based shape?
					if (shape.State == KimonoShapeState.Editing && (shape is KimonoShapeVector || shape is KimonoShapeBezier))
					{
						// Yes, add point inspector
						PointInspector.SelectedShape = shape;
						offset = PointInspector.MoveTo(offset);
						InspectorView.AddSubview(PointInspector);
					}

					// Display the style editors?
					if (showStyle)
					{
						// Display attached style
						AttachedStyleInspector.SelectedStyle = shape.Style;
						AttachedStyleInspector.SelectedShape = shape;
						offset = AttachedStyleInspector.MoveTo(offset);
						InspectorView.AddSubview(AttachedStyleInspector);

						// No, add text properties
						if (shape.Style.StyleType == KimonoStyleType.CustomText)
						{
							FontInspector.SelectedStyle = shape.Style;
							FontInspector.SelectedShape = shape;
							offset = FontInspector.MoveTo(offset);
							InspectorView.AddSubview(FontInspector);
						}
					}
					break;
				case InspectorViewMode.FillStyleView:
					// Add Fill inspector
					FillInspector.SelectedStyle = shape.Style;
					offset = FillInspector.MoveTo(offset);
					InspectorView.AddSubview(FillInspector);
					break;
				case InspectorViewMode.BorderStyleView:
					// Add Frame inspector
					FrameInspector.SelectedStyle = shape.Style;
					offset = FrameInspector.MoveTo(offset);
					InspectorView.AddSubview(FrameInspector);
					break;
				case InspectorViewMode.ConnectionView:
					break;
			}

			// Adjust Side content size
			var height = View.Frame.Height - offset;
			if (height < View.Frame.Height) height = View.Frame.Height;
			if (height < View.Frame.Height) height = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, height);
			ScrollInspectorsToTop();

			// Update code preview
			ShowCodePreview(shape);

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

			// Save the style being inspected
			InspectingElement = style;

			// Update inspector UI
			FillInspectorsButton.Enabled = true;
			BorderInspectorsButton.Enabled = true;
			ConnectionInspectorsButton.Enabled = true;

			// Get initial offset
			var offset = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, View.Frame.Height);

			// Show inspectors based on the view mode
			switch (CurrentInspectorMode)
			{
				case InspectorViewMode.DetailsView:
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
					break;
				case InspectorViewMode.FillStyleView:
					// Add Fill inspector
					FillInspector.SelectedStyle = style;
					offset = FillInspector.MoveTo(offset);
					InspectorView.AddSubview(FillInspector);
					break;
				case InspectorViewMode.BorderStyleView:
					// Add Frame inspector
					FrameInspector.SelectedStyle = style;
					offset = FrameInspector.MoveTo(offset);
					InspectorView.AddSubview(FrameInspector);
					break;
				case InspectorViewMode.ConnectionView:
					break;
			}

			// Adjust Side content size
			var height = View.Frame.Height - offset;
			if (height < View.Frame.Height) height = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, height);
			ScrollInspectorsToTop();

			// Update code preview
			ShowCodePreview(style);
		}

		/// <summary>
		/// Shows the palette color inspectors for the given color.
		/// </summary>
		/// <param name="color">The <c>KimonoColor</c> to show the inspectors for.</param>
		private void ShowPaletteColorInspectors(KimonoColor color)
		{
			// Close any open inspectors
			CloseAllInspectors();

			// Save the color being inspected
			InspectingElement = color;

			// Validate the current mode
			switch (CurrentInspectorMode)
			{
				case InspectorViewMode.DetailsView:
					break;
				case InspectorViewMode.FillStyleView:
					CurrentInspectorMode = InspectorViewMode.DetailsView;
					break;
				case InspectorViewMode.BorderStyleView:
					CurrentInspectorMode = InspectorViewMode.DetailsView;
					break;
				case InspectorViewMode.ConnectionView:
					break;
			}

			// Update inspector UI
			FillInspectorsButton.Enabled = false;
			BorderInspectorsButton.Enabled = false;
			ConnectionInspectorsButton.Enabled = true;

			// Get initial offset
			var offset = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, View.Frame.Height);

			// Take action based on the inspector mode
			switch (CurrentInspectorMode)
			{
				case InspectorViewMode.DetailsView:
					// Add required inspector panels
					ColorPaletteInspector.SelectedShape = DesignSurface.SelectedShape;
					ColorPaletteInspector.SelectedColor = color;
					offset = ColorPaletteInspector.MoveTo(offset);
					InspectorView.AddSubview(ColorPaletteInspector);
					break;
			}

			// Adjust Side content size
			var height = View.Frame.Height - offset;
			if (height < View.Frame.Height) height = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, height);
			ScrollInspectorsToTop();

			// Update code preview
			ShowCodePreview(color);
		}

		/// <summary>
		/// Shows the gradient inspectors.
		/// </summary>
		/// <param name="gradient">The <c>KimonoGradient</c> to show the inspector for.</param>
		private void ShowGradientInspectors(KimonoGradient gradient)
		{
			// Close any open inspectors
			CloseAllInspectors();

			// Save the gradient being inspected
			InspectingElement = gradient;

			// Update inspector UI
			CurrentInspectorMode = InspectorViewMode.DetailsView;
			FillInspectorsButton.Enabled = false;
			BorderInspectorsButton.Enabled = false;
			ConnectionInspectorsButton.Enabled = false;

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

			// Update code preview
			ShowCodePreview(gradient);
		}

		/// <summary>
		/// Shows the connection inspectors.
		/// </summary>
		/// <param name="propertyConsumer">The `IKimonoPropertyConsumer` to show property connections for.</param>
		private void ShowConnectionInspectors(IKimonoPropertyConsumer propertyConsumer)
		{
			// Close any open inspectors
			CloseAllInspectors();

			// Save the gradient being inspected
			InspectingElement = propertyConsumer;

			// Get initial offset
			var offset = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, View.Frame.Height);

			// Add required inspector panels
			ConnectionsInspector.PropertyConsumer = propertyConsumer;
			offset = ConnectionsInspector.MoveTo(offset);
			InspectorView.AddSubview(ConnectionsInspector);

			// Adjust Side content size
			var height = View.Frame.Height - offset;
			if (height < View.Frame.Height) height = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, height);
			ScrollInspectorsToTop();

		}

		/// <summary>
		/// Shows the property inspectors.
		/// </summary>
		/// <param name="property">The `KimonoProperty` to show the inspectors for.</param>
		private void ShowPropertyInspectors(KimonoProperty property)
		{
			// Close any open inspectors
			CloseAllInspectors();

			// Save the property being inspected
			InspectingElement = property;

			// Update inspector UI
			CurrentInspectorMode = InspectorViewMode.DetailsView;
			FillInspectorsButton.Enabled = false;
			BorderInspectorsButton.Enabled = false;
			ConnectionInspectorsButton.Enabled = false;

			// Get initial offset
			var offset = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, View.Frame.Height);

			// Add required inspector panels
			PropertyInspector.SelectedProperty = property;
			offset = PropertyInspector.MoveTo(offset);
			InspectorView.AddSubview(PropertyInspector);

			// Boolean property?
			if (property is KimonoPropertyBoolean)
			{
				BooleanPropertyInspector.SelectedBoolean = property as KimonoPropertyBoolean;
				offset = BooleanPropertyInspector.MoveTo(offset);
				InspectorView.AddSubview(BooleanPropertyInspector);
			}

			// Number property?
			if (property is KimonoPropertyNumber)
			{
				NumberPropertyInspector.SelectedNumber = property as KimonoPropertyNumber;
				offset = NumberPropertyInspector.MoveTo(offset);
				InspectorView.AddSubview(NumberPropertyInspector);
			}

			// Rect property?
			if (property is KimonoPropertyRect)
			{
				RectPropertyInspector.SelectedRect = property as KimonoPropertyRect;
				offset = RectPropertyInspector.MoveTo(offset);
				InspectorView.AddSubview(RectPropertyInspector);
			}

			// Text property?
			if (property is KimonoPropertyText)
			{
				TextPropertyInspector.SelectedText = property as KimonoPropertyText;
				offset = TextPropertyInspector.MoveTo(offset);
				InspectorView.AddSubview(TextPropertyInspector);
			}

			// Scripting?
			if (property.GetsValueFromScript)
			{
				// Yes, add debug inspector
				ScriptDebuggerInspector.SelectedProperty = property;
				offset = ScriptDebuggerInspector.MoveTo(offset);
				InspectorView.AddSubview(ScriptDebuggerInspector);
			}

			// Adjust Side content size
			var height = View.Frame.Height - offset;
			if (height < View.Frame.Height) height = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, height);
			ScrollInspectorsToTop();

			// Show Obi Script
			ShowPropertyObiScript(property);
		}

		/// <summary>
		/// Shows the portfolio inspectors.
		/// </summary>
		/// <param name="portfolio">The `KimonoPortfolio` to show the inspectors for.</param>
		private void ShowPortfolioInspectors(KimonoPortfolio portfolio)
		{
			// Close any open inspectors
			CloseAllInspectors();

			// Save the portfolio being inspected
			InspectingElement = portfolio;

			// Update inspector UI
			CurrentInspectorMode = InspectorViewMode.DetailsView;
			FillInspectorsButton.Enabled = false;
			BorderInspectorsButton.Enabled = false;
			ConnectionInspectorsButton.Enabled = false;

			// Get initial offset
			var offset = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, View.Frame.Height);

			// Add required inspector panels
			PortfolioInspector.SelectedPortfolio = portfolio;
			offset = PortfolioInspector.MoveTo(offset);
			InspectorView.AddSubview(PortfolioInspector);

			// Adjust Side content size
			var height = View.Frame.Height - offset;
			if (height < View.Frame.Height) height = View.Frame.Height;
			InspectorView.Frame = new CGRect(InspectorView.Frame.Left, InspectorView.Frame.Top, 251, height);
			ScrollInspectorsToTop();

			// Update code preview
			ShowCodePreview(portfolio);
		}

		/// <summary>
		/// Shows the sketch inspectors for the given sketch.
		/// </summary>
		/// <param name="sketch">The <c>KimonoSketch</c> to show the inspectors for.</param>
		private void ShowSketchInspectors(KimonoSketch sketch)
		{
			// Close any open inspectors
			CloseAllInspectors();

			// Save the sketch being inspected
			InspectingElement = sketch;

			// Update inspector UI
			CurrentInspectorMode = InspectorViewMode.DetailsView;
			FillInspectorsButton.Enabled = false;
			BorderInspectorsButton.Enabled = false;
			ConnectionInspectorsButton.Enabled = false;

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

			// Update code preview
			ShowCodePreview(sketch);
		}

		/// <summary>
		/// Updates the inspectors view based on the Kimono element currently
		/// being inspected.
		/// </summary>
		private void UpdateInspectorsView()
		{
			// Take action based on the element being
			// inspected
			if (InspectingElement is KimonoPortfolio)
			{
				ShowPortfolioInspectors(InspectingElement as KimonoPortfolio);
			}
			else if (InspectingElement is KimonoSketch)
			{
				ShowSketchInspectors(InspectingElement as KimonoSketch);
			}
			else if (InspectingElement is KimonoProperty)
			{
				ShowPropertyInspectors(InspectingElement as KimonoProperty);
			}
			else if (InspectingElement is KimonoGradient)
			{
				ShowGradientInspectors(InspectingElement as KimonoGradient);
			}
			else if (InspectingElement is KimonoColor)
			{
				ShowPaletteColorInspectors(InspectingElement as KimonoColor);
				if (CurrentInspectorMode == InspectorViewMode.ConnectionView)
				{
					ShowConnectionInspectors(InspectingElement as IKimonoPropertyConsumer);
				}
			}
			else if (InspectingElement is KimonoStyle)
			{
				ShowStyleInspectors(InspectingElement as KimonoStyle);
				if (CurrentInspectorMode == InspectorViewMode.ConnectionView)
				{
					ShowConnectionInspectors(InspectingElement as IKimonoPropertyConsumer);
				}
			}
			else
			{
				// Default to shapes
				ShowGeneralInspectors(InspectingElement as KimonoShape);
				if (CurrentInspectorMode == InspectorViewMode.ConnectionView)
				{
					ShowConnectionInspectors(InspectingElement as IKimonoPropertyConsumer);
				}
			}
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

			// Configure editor from user preferences
			ConfigureEditor();

			// Highligh the syntax of the text after an edit has been made
			TextEditor.TextStorage.DidProcessEditing += (sender, e) =>
			{
				DocumentEdited = true;
				Formatter.HighlightSyntaxRegion(TextEditor.TextStorage.Value, TextEditor.TextStorage.EditedRange);

				// Editing an Obi Script?
				if (EditingProperty != null)
				{
					// Yes, save script changes
					EditingProperty.ObiScript = Text;
				}
			};

			// If the text selection or cursor location changes, attempt to display the Tool Tip
			// for any keyword defined in the current language being syntax highlighted
			TextEditor.SourceSelectionChanged += (sender, e) =>
			{
				var range = Formatter.FindWordBoundries(TextEditor.TextStorage.Value, TextEditor.SelectedRange);
				var word = TextEditor.TextStorage.Value.Substring((int)range.Location, (int)range.Length);

				// Update UI
				if (WindowController != null)
				{
					//WindowController.Indent.Disabled = (TextEditor.SelectedRange.Length == 0);
					//App.IndentItem.Enabled = (!WindowController.Indent.Disabled);
					//WindowController.Outdent.Disabled = WindowController.Indent.Disabled;
					//App.OutdentItem.Enabled = (!WindowController.Outdent.Disabled);
					//App.ReformatItem.Enabled = (Text.Length > 0);
				}

				// Found a keyword?
				KeywordDescriptor info;
				if (Formatter.Language.Keywords.TryGetValue(word, out info))
				{
					// Display the tool tip
					//StatusText.StringValue = string.Format("{0}: {1}", info.Type, word);
					//StatusText.TextColor = info.Color;
					//StatusDesc.StringValue = info.Tooltip;
					Keyword = word;
					KeywordInfo = info;
				}
				else
				{
					// Display the currently selected text
					//StatusText.StringValue = "Selection:";
					//StatusText.TextColor = NSColor.Black;
					//StatusDesc.StringValue = word;
					Keyword = "";
					KeywordInfo = null;
				}
			};

			// Set document size
			SetDocumentSize();

			// Configure the source list
			SourceList.Initialize();

			// Set as first responder
			DesignSurface.BecomeFirstResponder();

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

			// Add Properties
			PropertyList = new SourceListItem("Properties");
			UpdatePropertyList(false);
			SourceList.AddItem(PropertyList);

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
				UpdatePropertyList(false);
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
				DocumentEdited = true;
				UpdateShapesList(true);
			};

			DesignSurface.SketchesModified += () =>
			{
				DocumentEdited = true;
				UpdateSketchesList(true);
			};

			DesignSurface.StylesModified += (style) =>
			{
				// Refresh style list
				DocumentEdited = true;
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
				DocumentEdited = true;
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
				DocumentEdited = true;
				UpdateGradientList(true);

				// Was a specific gradient modified?
				if (gradient != null)
				{
					// Yes, display that gradient
					ShowGradientInspectors(gradient);
				}

			};

			DesignSurface.PropertyModified += (property) =>
			{

				// Refresh properties list
				DocumentEdited = true;
				UpdatePropertyList(true);

				// Was a specific property modified?
				if (property != null)
				{
					// Yes, display that gradient
					ShowPropertyInspectors(property);
				}

			};

			DesignSurface.SelectionChanged += (selected) =>
			{
				// Anything selected
				if (selected == null)
				{
					// Close any open inspectors
					CloseAllInspectors();
					ClearTextEditor();
				} else 
				{
					// Show the required inspectors
					ShowGeneralInspectors(selected);
					if (CurrentInspectorMode == InspectorViewMode.ConnectionView)
					{
						ShowConnectionInspectors(InspectingElement as IKimonoPropertyConsumer);
					}
				}

				// Inform window of change
				RaiseSketchModified(DesignSurface.SelectedSketch);
			};

			DesignSurface.SketchSizeChanged += () =>
			{
				DocumentEdited = true;
				SetDocumentSize();
			};

			// Update the design surface
			DesignSurface.RefreshView();

			// Display the sketch inspector
			ShowSketchInspectors(DesignSurface.SelectedSketch);

		}

		/// <summary>
		/// Called before the view is displayed
		/// </summary>
		public override void ViewWillAppear()
		{
			base.ViewWillAppear();

			// Set intial formatter
			Formatter = new LanguageFormatter(TextEditor, new CSharpDescriptor());
		}

		/// <summary>
		/// This method is called after the View being handled by this View Controller has
		/// been displayed on screen.
		/// </summary>
		public override void ViewDidAppear()
		{
			base.ViewDidAppear();

			// Set Window Title
			if (View.Window.Title == "Window")
			{
				if (++App.NewWindowNumber == 0)
				{
					View.Window.Title = "untitled";
				}
				else
				{
					View.Window.Title = string.Format("untitled {0}", App.NewWindowNumber);
				}
			}

			// Configure
			Keyword = "";
			KeywordInfo = null;

			// Make the design surface the first responder
			View.Window.MakeFirstResponder(DesignSurface);

			// Update UI
			//App.ReformatItem.Enabled = (Text.Length > 0);
			//WindowController.Print.Disabled = false;
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
				case 9:
					// Can export source code?
					return ExportButton.Enabled;
			}

			return true;
		}

		/// <summary>
		/// Exports the currently generated source code to a file.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ExportSource(Foundation.NSObject sender)
		{
			// Ask user to select location
			var dlg = new NSSavePanel();
			dlg.Title = "Export Source Code";
			dlg.AllowedFileTypes = new string[] { "cs" };
			dlg.BeginSheet(View.Window, (rslt) =>
			{
					// File selected?
					if (rslt == 1)
				{
					var path = dlg.Url.Path;
					File.WriteAllText(path, Text);
				}
			});
		}

		/// <summary>
		/// Switch to details inspectors.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void SwitchToDetailsInspectors(Foundation.NSObject sender)
		{
			CurrentInspectorMode = InspectorViewMode.DetailsView;
			UpdateInspectorsView();
		}

		/// <summary>
		/// Switch to fill inspectors.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void SwitchToFillInspectors(Foundation.NSObject sender)
		{
			CurrentInspectorMode = InspectorViewMode.FillStyleView;
			UpdateInspectorsView();
		}

		/// <summary>
		/// Switch to border inspectors.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void SwitchToBorderInspectors(Foundation.NSObject sender)
		{
			CurrentInspectorMode = InspectorViewMode.BorderStyleView;
			UpdateInspectorsView();
		}

		/// <summary>
		/// Switch to connection inspectors.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void SwitchToConnectionInspectors(Foundation.NSObject sender)
		{
			CurrentInspectorMode = InspectorViewMode.ConnectionView;
			UpdateInspectorsView();
		}

		/// <summary>
		/// Handle the OS selection changing
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void OSSelectionChanged(Foundation.NSObject sender)
		{
			// Set OS
			switch (OSSelector.IndexOfSelectedItem)
			{
				case 0:
					GenerateOSCode = CodeOutputOS.Windows;
					break;
				case 1:
					GenerateOSCode = CodeOutputOS.WindowsUWP;
					break;
				case 2:
					GenerateOSCode = CodeOutputOS.WindowsWPF;
					break;
				case 3:
					GenerateOSCode = CodeOutputOS.Android;
					break;
				case 4:
					GenerateOSCode = CodeOutputOS.iOS;
					break;
				case 5:
					GenerateOSCode = CodeOutputOS.tvOS;
					break;
				case 6:
					GenerateOSCode = CodeOutputOS.macOS;
					break;
				case 7:
					GenerateOSCode = CodeOutputOS.CrossPlatform;
					break;

			}

			// Update UI
			UpdateTextEditor();
		}

		/// <summary>
		/// Handle the language selection changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void LanguageSelectionChanged(Foundation.NSObject sender)
		{
			// Set language
			switch (LanguageSelector.IndexOfSelectedItem)
			{
				case 0:
					GenerateLanguageCode = CodeOutputLanguage.CSharp;
					break;
				case 1:
					GenerateLanguageCode = CodeOutputLanguage.ObiScript;
					break;
				case 2 :
					GenerateLanguageCode = CodeOutputLanguage.FSharp;
					break;
				default:
					throw new ArgumentOutOfRangeException($"Unknown Language Selection index {LanguageSelector.IndexOfSelectedItem}");
			
			}

			// Update UI
			UpdateTextEditor();
		}

		/// <summary>
		/// Handles the library selection changing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void LibrarySelectionChanged(Foundation.NSObject sender)
		{
			// Set language
			switch (LibrarySelector.IndexOfSelectedItem)
			{
				case 0:
					GenerateLibraryCode = CodeOutputLibrary.SkiaSharp;
					break;
				case 1:
					GenerateLibraryCode = CodeOutputLibrary.KimonoCore;
					break;
			}

			// Update UI
			UpdateTextEditor();
		}

		/// <summary>
		/// Adds the property boolean.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("addPropertyLibrary:")]
		public void AddPropertyLibrary(NSObject sender)
		{
			DesignSurface.Portfolio.AddPropertyLibrary();
		}

		/// <summary>
		/// Adds the property boolean.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("addPropertyBoolean:")]
		public void AddPropertyBoolean(NSObject sender)
		{
			DesignSurface.Portfolio.AddPropertyBoolean();
		}

		/// <summary>
		/// Adds the color of the property.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("addPropertyColor:")]
		public void AddPropertyColor(NSObject sender)
		{
			DesignSurface.Portfolio.AddPropertyColor();
		}

		/// <summary>
		/// Adds the property gradient.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("addPropertyGradient:")]
		public void AddPropertyGradient(NSObject sender)
		{
			DesignSurface.Portfolio.AddPropertyGradient();
		}

		/// <summary>
		/// Adds the property number.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("addPropertyNumber:")]
		public void AddPropertyNumber(NSObject sender)
		{
			DesignSurface.Portfolio.AddPropertyNumber();
		}

		/// <summary>
		/// Adds the property rect.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("addPropertyRect:")]
		public void AddPropertyRect(NSObject sender)
		{
			DesignSurface.Portfolio.AddPropertyRect();
		}

		/// <summary>
		/// Adds the property style.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("addPropertyStyle:")]
		public void AddPropertyStyle(NSObject sender)
		{
			DesignSurface.Portfolio.AddPropertyStyle();
		}

		/// <summary>
		/// Adds the property text.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("addPropertyText:")]
		public void AddPropertyText(NSObject sender)
		{
			DesignSurface.Portfolio.AddPropertyText();
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
		/// Selects all shapes.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("selectAll:")]
		public void SelectAll(NSObject sender)
		{
			DesignSurface.SelectAll();
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
