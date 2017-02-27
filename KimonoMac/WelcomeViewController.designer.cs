// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace KimonoMac
{
	[Register ("WelcomeViewController")]
	partial class WelcomeViewController
	{
		[Outlet]
		WebKit.WebView Contents { get; set; }

		[Outlet]
		AppKit.NSButton ShowCheckbox { get; set; }

		[Action ("CloseDialog:")]
		partial void CloseDialog (Foundation.NSObject sender);

		[Action ("NewFile:")]
		partial void NewFile (Foundation.NSObject sender);

		[Action ("OpenFile:")]
		partial void OpenFile (Foundation.NSObject sender);

		[Action ("OpenHome:")]
		partial void OpenHome (Foundation.NSObject sender);

		[Action ("OpenSkiaWebsite:")]
		partial void OpenSkiaWebsite (Foundation.NSObject sender);

		[Action ("OpenWhatsNew:")]
		partial void OpenWhatsNew (Foundation.NSObject sender);

		[Action ("ShowWindowChanged:")]
		partial void ShowWindowChanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (Contents != null) {
				Contents.Dispose ();
				Contents = null;
			}

			if (ShowCheckbox != null) {
				ShowCheckbox.Dispose ();
				ShowCheckbox = null;
			}
		}
	}
}
