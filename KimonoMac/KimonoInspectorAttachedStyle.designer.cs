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
	[Register ("KimonoInspectorAttachedStyle")]
	partial class KimonoInspectorAttachedStyle
	{
		[Outlet]
		AppKit.NSButton EditButton { get; set; }

		[Outlet]
		AppKit.NSPopUpButton StyleSelector { get; set; }

		[Action ("EditStyle:")]
		partial void EditStyle (Foundation.NSObject sender);

		[Action ("StyleChanged:")]
		partial void StyleChanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (EditButton != null) {
				EditButton.Dispose ();
				EditButton = null;
			}

			if (StyleSelector != null) {
				StyleSelector.Dispose ();
				StyleSelector = null;
			}
		}
	}
}
