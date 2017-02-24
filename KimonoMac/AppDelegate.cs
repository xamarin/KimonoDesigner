using System.IO;
using AppKit;
using Foundation;
using KimonoCore;
using KimonoCore.Mac;

namespace KimonoMac
{
	/// <summary>
	/// App delegate.
	/// </summary>
	[Register("AppDelegate")]
	public class AppDelegate : NSApplicationDelegate
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the number of the next new editor window created.
		/// </summary>
		/// <value>The new window number.</value>
		public int NewWindowNumber { get; set; } = -1;

		/// <summary>
		/// Gets or sets the preferences for the app.
		/// </summary>
		/// <value>The AppPreferences for the app.</value>
		public AppPreferences Preferences { get; set; } = new AppPreferences();
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.AppDelegate"/> class.
		/// </summary>
		public AppDelegate()
		{
		}
		#endregion

		#region Override Methods
		/// <summary>
		/// Did finish launching.
		/// </summary>
		/// <param name="notification">Notification.</param>
		public override void DidFinishLaunching(NSNotification notification)
		{
			// Display the welcome window?
			if (Preferences.ShowWelcomeWindow) {
				// Yes, get new window
				var storyboard = NSStoryboard.FromName("Main", null);
				var controller = storyboard.InstantiateControllerWithIdentifier("WelcomeWindow") as NSWindowController;

				// Display
				controller.ShowWindow(this);
			}
		}

		/// <summary>
		/// Called before the app terminates to allow the app to cancel the termination
		/// based on state, such as a file not being saved.
		/// </summary>
		/// <returns>A flag stating if the app can terminate at this time.</returns>
		/// <param name="sender">A pointer to the app.</param>
		/// <remarks>For more details, see: https://developer.xamarin.com/guides/mac/user-interface/working-with-windows/#Modified_Windows_Content</remarks>
		public override NSApplicationTerminateReply ApplicationShouldTerminate(NSApplication sender)
		{
			// See if any window needs to be saved first
			foreach (NSWindow window in NSApplication.SharedApplication.Windows)
			{
				if (window.Delegate != null && !window.Delegate.WindowShouldClose(this))
				{
					// Did the window terminate the close?
					return NSApplicationTerminateReply.Cancel;
				}
			}

			// Allow normal termination
			return NSApplicationTerminateReply.Now;
		}

		/// <summary>
		/// Will terminate.
		/// </summary>
		/// <param name="notification">Notification.</param>
		public override void WillTerminate(NSNotification notification)
		{
			// Insert code here to tear down your application
			Preferences.StopUsingDefaultPreferences();
		}

		/// <summary>
		/// This method is called when the user selects a file from the <c>Open Recent</c>
		/// menu item.
		/// </summary>
		/// <returns><c>true</c>, if file was opened, <c>false</c> otherwise.</returns>
		/// <param name="sender">A pointer to the app.</param>
		/// <param name="filename">The full path and filename of the file to open.</param>
		/// <remarks>For more details, see: https://developer.xamarin.com/guides/mac/user-interface/working-with-menus/#Working_with_the_Open_Recent_Menu</remarks>
		public override bool OpenFile(NSApplication sender, string filename)
		{
			// Trap all errors
			try
			{
				// Escape any spaces (" ") or they will cause an error
				// when converted to an NSUrl.
				filename = filename.Replace(" ", "%20");
				var url = new NSUrl("file://" + filename);
				return OpenFile(url);
			}
			catch
			{
				return false;
			}
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Attempts to open the file at the specified URL. If the file is currently open
		/// in a window, that will be brought to the front and selected instead of opening
		/// another copy of the file.
		/// </summary>
		/// <returns><c>true</c>, if file was opened, <c>false</c> otherwise.</returns>
		/// <param name="url">A <c>NSUrl</c> pointing to the file to open.</param>
		public bool OpenFile(NSUrl url)
		{
			var good = false;

			// Trap all errors
			try
			{
				var path = url.Path;

				// Is the file already open?
				foreach (NSWindow window in NSApplication.SharedApplication.Windows)
				{
					var content = window.ContentViewController as ViewController;
					if (content != null && path == content.FilePath)
					{
						// Bring window to front
						window.MakeKeyAndOrderFront(this);
						return true;
					}
				}

				// Load in portfolio
				var data = File.ReadAllText(path);
				var portfolio = new KimonoPortfolio(data);

				// Get new window
				var storyboard = NSStoryboard.FromName("Main", null);
				var controller = storyboard.InstantiateControllerWithIdentifier("MainWindow") as NSWindowController;

				// Display
				controller.ShowWindow(this);

				// Load portfolio into the window
				var viewController = controller.Window.ContentViewController as ViewController;
				viewController.Surface.Portfolio = portfolio;
				viewController.View.Window.SetTitleWithRepresentedFilename(Path.GetFileName(path));
				viewController.View.Window.RepresentedUrl = url;

				// Add document to the Open Recent menu
				NSDocumentController.SharedDocumentController.NoteNewRecentDocumentURL(url);

				// Make as successful
				good = true;
			}
			catch
			{
				// Mark as bad file on error
				good = false;
			}

			// Return results
			return good;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// For any open windows, redefine the language to pick up any changes to the user
		/// preferences and reformat all of the text in the document.
		/// </summary>
		/// <remarks>For more details, see: https://developer.xamarin.com/guides/mac/user-interface/working-with-dialogs/#Creating_a_Preferences_Dialog</remarks>
		public void UpdateWindowPreferences()
		{

			// Process all open windows
			for (int n = 0; n < NSApplication.SharedApplication.Windows.Length; ++n)
			{
				var content = NSApplication.SharedApplication.Windows[n].ContentViewController as ViewController;
				if (content != null)
				{
					// Reformat all text

				}
			}

		}
		#endregion

		#region Actions
		/// <summary>
		/// Displays the Open File dialog box allowing the user to select a file to open.
		/// </summary>
		/// <param name="sender">A pointer to the app.</param>
		/// <remarks>For more details, see: https://developer.xamarin.com/guides/mac/user-interface/working-with-menus/#Built-In_Menu_Functionality</remarks>
		[Export("openDocument:")]
		void OpenDialog(NSObject sender)
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
					OpenFile(url);
				}
			}
		}

		[Export("newDocument:")]
		void NewDocument(NSObject sender)
		{
			// Get new window
			var storyboard = NSStoryboard.FromName("Main", null);
			var controller = storyboard.InstantiateControllerWithIdentifier("MainWindow") as NSWindowController;

			// Display
			controller.ShowWindow(this);

		}
		#endregion
	}
}
