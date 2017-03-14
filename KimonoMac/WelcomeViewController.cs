using System;
using Foundation;
using AppKit;
using CoreGraphics;
using System.IO;

namespace KimonoMac
{
	/// <summary>
	/// Handles the welcome window
	/// </summary>
	public partial class WelcomeViewController : NSViewController
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

		#region Computed Properties
		/// <summary>
		/// Gets or sets the visible rect (the current scroll position within the document).
		/// </summary>
		/// <value>The visible rect.</value>
		public CGRect VisibleRect { get; set; } = new CGRect(0, 0, 0, 0);

		/// <summary>
		/// Gets or sets the Scroll View for the currently displayed preview.
		/// </summary>
		/// <value>The <c>NSScrollView</c> containing the preview.</value>
		public NSScrollView Scroll { get; set; } = null;

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="SourceWriter.PreviewVIewController"/> is 
		/// currenlty in the process of updating the preview.
		/// </summary>
		/// <value><c>true</c> if updating; otherwise, <c>false</c>.</value>
		public bool Updating { get; set; } = false;
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.WelcomeViewController"/> class.
		/// </summary>
		/// <param name="handle">Handle.</param>
		public WelcomeViewController(IntPtr handle) : base(handle)
		{
		}
		#endregion

		#region Override Methods
		/// <summary>
		/// Called before the view is displayed to the user.
		/// </summary>
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Initialize
			ShowCheckbox.IntValue = (App.Preferences.ShowWelcomeWindow) ? 1 : 0;
		}

		/// <summary>
		/// Called before the view is presented to the user.
		/// </summary>
		public override void ViewWillAppear()
		{
			base.ViewWillAppear();

			// Grab scroller
			Scroll = Contents.MainFrame.FrameView.DocumentView.EnclosingScrollView;

			// Configure preview
			Scroll.AllowsMagnification = true;
			Scroll.Magnification = 1.0f;

			// Wire-up events
			Contents.FinishedLoad += (sender, e) =>
			{
				// Restore to preview scroll location
				//if (Scroll != null)
				//{
				//	Scroll.ContentView.ScrollToPoint(VisibleRect.Location);
				//	Scroll.ReflectScrolledClipView(Scroll.ContentView);
				//	VisibleRect = Scroll.ContentView.DocumentVisibleRect();
				//}

				// Clear update flag
				Updating = false;
				//Contents.Hidden = false;
			};

			// Default to What's New
			WhatsNew();
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Displays the What's New info for the app
		/// </summary>
		public void WhatsNew()
		{
			var bundle = NSBundle.MainBundle;
			var path = bundle.PathForResource("WhatsNew", "html");

			// Anything to process?
			if (string.IsNullOrEmpty(path))
			{
				// Default to showing SkiaSharp's website
				DisplayURL("https://skia.org");
			}
			else
			{
				// Load the file
				var html = File.ReadAllText(path);

				// Display results
				DisplayText(html, "");
			}
		}

		/// <summary>
		/// Displays the "Home" about Kimono Designer screen.
		/// </summary>
		public void Home()
		{
			var bundle = NSBundle.MainBundle;
			var path = bundle.PathForResource("Home", "html");

			// Anything to process?
			if (string.IsNullOrEmpty(path))
			{
				// Default to showing SkiaSharp's website
				DisplayURL("https://skia.org");
			}
			else
			{
				// Load the file
				var html = File.ReadAllText(path);

				// Display results
				DisplayText(html, "");
			}

		}

		/// <summary>
		/// Displays the given text string as final output to the user using a <c>WebKit</c> view.
		/// </summary>
		/// <param name="text">The formatted text to display.</param>
		public void DisplayText(string text, string filePath)
		{

			// Are we already performing an update?
			if (Updating) return;

			// Save current scroll position
			Scroll = Contents.MainFrame.FrameView.DocumentView.EnclosingScrollView;
			if (Scroll != null)
			{
				VisibleRect = Scroll.ContentView.DocumentVisibleRect();
			}

			// Update view contents
			Updating = true;
			//Contents.Hidden = true;
			if (filePath == "")
			{
				Contents.MainFrame.LoadHtmlString(text, null);
			}
			else
			{
				var url = NSUrl.CreateFileUrl(filePath, true, null);
				Contents.MainFrame.LoadHtmlString(text, url);
			}

		}

		/// <summary>
		/// Displays the the URL.
		/// </summary>
		/// <param name="text">Text.</param>
		public void DisplayURL(string text)
		{

			// Are we already performing an update?
			if (Updating) return;

			// Save current scroll position
			Scroll = Contents.MainFrame.FrameView.DocumentView.EnclosingScrollView;
			if (Scroll != null)
			{
				VisibleRect = Scroll.ContentView.DocumentVisibleRect();
			}

			// Update view contents
			Updating = true;
			//Contents.Hidden = true;
			Contents.MainFrame.LoadRequest(NSUrlRequest.FromUrl(NSUrl.FromString(text)));

		}
		#endregion

		#region Custom Actions
		partial void OpenWhatsNew(Foundation.NSObject sender)
		{
			WhatsNew();
		}

		partial void OpenSkiaWebsite(Foundation.NSObject sender)
		{
			DisplayURL("https://skia.org");
		}

		partial void OpenHome(Foundation.NSObject sender)
		{
			Home();
		}

		/// <summary>
		/// Closes the dialog.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void CloseDialog(Foundation.NSObject sender)
		{
			// Close this window
			View.Window.Close();
		}

		/// <summary>
		/// Opens a new file.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void NewFile(Foundation.NSObject sender)
		{
			// Get new window
			var storyboard = NSStoryboard.FromName("Main", null);
			var controller = storyboard.InstantiateControllerWithIdentifier("MainWindow") as NSWindowController;

			// Display
			controller.ShowWindow(this);

			// Close this window
			View.Window.Close();
		}

		/// <summary>
		/// Opens a recently saved file.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void OpenFile(Foundation.NSObject sender)
		{
			var dlg = NSOpenPanel.OpenPanel;
			dlg.CanChooseFiles = true;
			dlg.CanChooseDirectories = false;
			dlg.AllowedFileTypes = new string[] { "ksp" };

			if (dlg.RunModal() == 1)
			{
				// Nab the first file
				var url = dlg.Urls[0];

				if (url != null)
				{
					// Open the document in a new window
					App.OpenFile(url);

					// Close this window
					View.Window.Close();
				}
			}
		}

		/// <summary>
		/// Handles the user clicking the "Show this window at launch" checkbox.
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ShowWindowChanged(Foundation.NSObject sender)
		{
			App.Preferences.ShowWelcomeWindow = !App.Preferences.ShowWelcomeWindow;
		}
		#endregion
	}
}
