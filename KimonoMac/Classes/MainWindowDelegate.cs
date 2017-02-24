using System;
using AppKit;
using AppKit.TextKit.Formatter;
using System.IO;
using Foundation;

namespace KimonoMac
{
	public class MainWindowDelegate : NSWindowDelegate
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
		/// Gets or sets the window being managed.
		/// </summary>
		/// <value>The <c>NSWindow</c> being managed by the <c>NSWindowController</c> this delegate
		/// is attached to.</value>
		public NSWindow Window { get; set; }

		/// <summary>
		/// Gets the editor window controller.
		/// </summary>
		/// <value>The editor controller.</value>
		public MainWindowController EditorController
		{
			get { return Window.WindowController as MainWindowController; }
		}
		#endregion

		#region constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoMac.MainWindowDelegate"/> class.
		/// </summary>
		/// <param name="window">Window.</param>
		public MainWindowDelegate(NSWindow window)
		{
			// Initialize
			this.Window = window;

		}
		#endregion

		#region Override Methods
		/// <summary>
		/// Called before an <c>NSWindow</c> is closed. If the contents of the window has changed and
		/// not been saved, display a dialog allowing the user to: a) Cancel the closing, b) Close
		/// without saving, c) Save the changes to the document.
		/// </summary>
		/// <returns><c>true</c>, if the window can be closed, else <c>false</c> if it cannot.</returns>
		/// <param name="sender">The <c>NSWindowController</c> calling this method.</param>
		public override bool WindowShouldClose(Foundation.NSObject sender)
		{
			// is the window dirty?
			if (Window.DocumentEdited)
			{
				var alert = new NSAlert()
				{
					AlertStyle = NSAlertStyle.Critical,
					InformativeText = "Save changes to portfolio before closing window?",
					MessageText = "Save Portfolio",
				};
				alert.AddButton("Save");
				alert.AddButton("Lose Changes");
				alert.AddButton("Cancel");
				var result = alert.RunSheetModal(Window);

				// Take action based on resu;t
				switch (result)
				{
					case 1000:
						// Grab controller
						var viewController = Window.ContentViewController as ViewController;

						// Already saved?
						if (Window.RepresentedUrl != null)
						{
							var path = Window.RepresentedUrl.Path;

							// Save changes to file
							File.WriteAllText(path, EditorController.Portfolio.SaveToTextBase());
							return true;
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
									var path = dlg.Url.Path;
									File.WriteAllText(path, EditorController.Portfolio.SaveToTextBase());
									Window.DocumentEdited = false;
									viewController.View.Window.SetTitleWithRepresentedFilename(Path.GetFileName(path));
									viewController.View.Window.RepresentedUrl = dlg.Url;
									Window.Close();
								}
							});
							return true;
						}
					case 1001:
						// Lose Changes
						return true;
					case 1002:
						// Cancel
						return false;
				}
			}

			return true;
		}

		/// <summary>
		/// Called when the window gains focus and becomes the active window.
		/// </summary>
		/// <param name="notification">Notification.</param>
		/// <remarks>We are using this method to update the preview of the document and
		/// to populate the Formatting Menu with any extra commands from the document's
		/// <see cref="AppKit.TextKit.Formatter.LanguageFormatter"/>.</remarks>
		public override void DidBecomeKey(NSNotification notification)
		{
			// Valid
			if (EditorController == null) return;

			// Populate Formatting Command menu
			// EditorController.ContentController.PopulateFormattingMenu();

		}

		/// <summary>
		/// Called when the window loses focus and falls into the background.
		/// </summary>
		/// <param name="notification">Notification.</param>
		/// <remarks>We are using this method to remove any custom commands added
		/// to the Formatting Menu by the <see cref="AppKit.TextKit.Formatter.LanguageFormatter"/>.</remarks>
		public override void DidResignKey(NSNotification notification)
		{
			// Valid
			if (EditorController == null) return;

			// Remove this window's extra formatting commands from the menu
			// EditorController.ContentController.UnpopulateFormattingMenu();
		}
		#endregion
	}
}
