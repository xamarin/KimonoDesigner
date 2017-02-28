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
	[Register ("KimonoInspectorPoint")]
	partial class KimonoInspectorPoint
	{
		[Outlet]
		AppKit.NSButton DeleteButton { get; set; }

		[Outlet]
		AppKit.NSButton DuplicateButton { get; set; }

		[Action ("DeletePoint:")]
		partial void DeletePoint (Foundation.NSObject sender);

		[Action ("DuplicatePoint:")]
		partial void DuplicatePoint (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (DuplicateButton != null) {
				DuplicateButton.Dispose ();
				DuplicateButton = null;
			}

			if (DeleteButton != null) {
				DeleteButton.Dispose ();
				DeleteButton = null;
			}
		}
	}
}
