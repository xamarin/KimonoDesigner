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

		#region Override Events
		/// <summary>
		/// Handles the window loading and configures any user interface elements based on the stateof
		/// the <c>KimonoPortfolio</c> being edited.
		/// </summary>
		public override void WindowDidLoad()
		{
			base.WindowDidLoad();

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
		#endregion

		#region Custom Actions
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
