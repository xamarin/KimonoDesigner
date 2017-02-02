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
	[Register ("KimonoInspectorStyle")]
	partial class KimonoInspectorStyle
	{
		[Outlet]
		AppKit.NSButton ApplyButton { get; set; }

		[Outlet]
		AppKit.NSButton Backbutton { get; set; }

		[Outlet]
		AppKit.NSButton DeleteButton { get; set; }

		[Outlet]
		AppKit.NSTextField StyleName { get; set; }

		[Outlet]
		AppKit.NSPopUpButton TypeDropdown { get; set; }

		[Action ("ApplyChange:")]
		partial void ApplyChange (Foundation.NSObject sender);

		[Action ("DeleteStyle:")]
		partial void DeleteStyle (Foundation.NSObject sender);

		[Action ("DuplicateStyle:")]
		partial void DuplicateStyle (Foundation.NSObject sender);

		[Action ("GoBack:")]
		partial void GoBack (Foundation.NSObject sender);

		[Action ("TypeChanged:")]
		partial void TypeChanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ApplyButton != null) {
				ApplyButton.Dispose ();
				ApplyButton = null;
			}

			if (Backbutton != null) {
				Backbutton.Dispose ();
				Backbutton = null;
			}

			if (DeleteButton != null) {
				DeleteButton.Dispose ();
				DeleteButton = null;
			}

			if (StyleName != null) {
				StyleName.Dispose ();
				StyleName = null;
			}

			if (TypeDropdown != null) {
				TypeDropdown.Dispose ();
				TypeDropdown = null;
			}
		}
	}
}
