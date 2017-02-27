using System;
using AppKit;
using CoreGraphics;
using Foundation;
using SkiaSharp;
using KimonoCore;
using KimonoCore.Mac;
using System.IO;

namespace KimonoMac
{
	/// <summary>
	/// Handles the main window for the Kimono Designer app.
	/// </summary>
	public partial class MainWindowController : NSWindowController
	{
		#region Computed Properties
		/// <summary>
		/// Gets the main controller.
		/// </summary>
		/// <value>The main controller.</value>
		public ViewController MainController
		{
			get { return ContentViewController as ViewController; }
		}

		/// <summary>
		/// Gets or sets the portfolio.
		/// </summary>
		/// <value>The KimonoPortfolio currently being edited.</value>
		public KimonoPortfolio Portfolio
		{

			get { return MainController.Surface.Portfolio; }
			set
			{
				MainController.Surface.Portfolio = value;
				MainController.Surface.RefreshView();
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.MainWindowController"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public MainWindowController(IntPtr handle) : base(handle)
		{
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Saves the document being edited in the current window. If the document hasn't been saved
		/// before, it presents a Save File Dialog and allows to specify the name and location of 
		/// the file.
		/// </summary>
		public void SaveDocument()
		{

			// Get path
			var path = (Window.RepresentedUrl == null) ? "" : Window.RepresentedUrl.Path;

			// Already saved?
			if (!string.IsNullOrEmpty(path))
			{
				// Save changes to file
				File.WriteAllText(path, Portfolio.SaveToTextBase());
				Window.DocumentEdited = false;
			}
			else
			{
				var dlg = new NSSavePanel();
				dlg.Title = "Save Portfolio";
				dlg.AllowedFileTypes = new string[] { "ksp" };
				dlg.BeginSheet(Window, (rslt) =>
				{
					// File selected?
					if (rslt == 1)
					{
						path = dlg.Url.Path;
						File.WriteAllText(path, Portfolio.SaveToTextBase());
						Window.DocumentEdited = false;
						MainController.View.Window.SetTitleWithRepresentedFilename(Path.GetFileName(path));
						MainController.View.Window.RepresentedUrl = dlg.Url;
						MainController.FilePath = path;

						// Add document to the Open Recent menu
						NSDocumentController.SharedDocumentController.NoteNewRecentDocumentURL(dlg.Url);
					}
				});
			}
		}
		#endregion

		#region Override Events
		/// <summary>
		/// Handles the window loading and configures any user interface elements based on the stateof
		/// the <c>KimonoPortfolio</c> being edited.
		/// </summary>
		public override void WindowDidLoad()
		{
			base.WindowDidLoad();

			// Configure window
			Window.Delegate = new MainWindowDelegate(Window);
			// Window.TitleVisibility = NSWindowTitleVisibility.Hidden;

			// Apply the Dark Interface Appearance
			// NOTE: Nope, this DOES NOT look good with the way the app's UI has been built!
			// Window.Appearance = NSAppearance.GetAppearance(NSAppearance.NameVibrantDark);

			// Set initial tool states
			MoveTopTool.Active = false;
			MoveForwardsTool.Active = false;
			MoveBackwardsTool.Active = false;
			MoveBottomTool.Active = false;

			// Disable alignment tools
			AlignTopTool.Active = false;
			AlignLeftTool.Active = false;
			AlignRightTool.Active = false;
			AlignBottomTool.Active = false;
			CenterTool.Active = false;
			CenterVerticalTool.Active = false;
			CenterHorizontalTool.Active = false;

			// Grouping tools
			GroupShapes.Active = false;
			UngroupShapes.Active = false;

			// Connect to view controller
			MainController.ParentWindowController = this;

			// Wireup events
			MainController.SketchModified += (sketch) =>
			{
				// Configure tool states
				MoveTopTool.Active = (sketch.DeeplySelectedShape != null && !sketch.SelectedShapeAtTop);
				MoveForwardsTool.Active = MoveTopTool.Active;
				MoveBackwardsTool.Active = (sketch.DeeplySelectedShape != null && !sketch.SelectedShapeAtBottom);
				MoveBottomTool.Active = MoveBackwardsTool.Active;

				// Configure alignment tools
				AlignTopTool.Active = sketch.CanAlignShapes;
				AlignLeftTool.Active = AlignTopTool.Active;
				AlignRightTool.Active = AlignTopTool.Active;
				AlignBottomTool.Active = AlignTopTool.Active;
				CenterTool.Active = AlignTopTool.Active;
				CenterVerticalTool.Active = AlignTopTool.Active;
				CenterHorizontalTool.Active = AlignTopTool.Active;

				// Configure grouping tools
				GroupShapes.Active = sketch.CanGroupShapes;
				UngroupShapes.Active = sketch.CanUngroupShapes;
			};
		}

		/// <summary>
		/// Gets the new window for tab.
		/// </summary>
		/// <param name="sender">Sender.</param>
		public override void GetNewWindowForTab(NSObject sender)
		{
			// Get new window
			var storyboard = NSStoryboard.FromName("Main", null);
			var controller = storyboard.InstantiateControllerWithIdentifier("MainWindow") as NSWindowController;

			// Display
			controller.ShowWindow(this);
		}
		#endregion

		#region Custom Actions
		/// <summary>
		/// Allows the user to specify where to save the document.
		/// </summary>
		/// <param name="sender">The controller calling the method.</param>
		[Action("saveDocumentAs:")]
		public void SaveDocumentAs(NSObject sender)
		{
			Window.RepresentedUrl = new NSUrl("");
			SaveDocument();
		}

		/// <summary>
		/// Saves the document to its last location or allows the user to select a 
		/// location if it has never been saved before.
		/// </summary>
		/// <param name="sender">The controller calling the method.</param>
		[Action("saveDocument:")]
		public void SaveDocument(NSObject sender)
		{
			SaveDocument();
		}

		/// <summary>
		/// Adds the sketch.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("addSketch:")]
		public void AddSketch(NSObject sender)
		{
			// Create new style
			MainController.AddNewSketch();

		}

		/// <summary>
		/// Adds the style.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("addStyle:")]
		public void AddStyle(NSObject sender)
		{
			// Create new style
			MainController.AddNewStyle();

		}

		/// <summary>
		/// Adds the color.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("addColor:")]
		public void AddColor(NSObject sender)
		{
			// Create new style
			MainController.AddNewColor();

		}

		/// <summary>
		/// Adds the gradient.
		/// </summary>
		/// <param name="sender">Sender.</param>
		[Action("addGradient:")]
		public void AddGradient(NSObject sender)
		{
			// Create new style
			MainController.AddNewGradient();

		}
		#endregion
	}
}
