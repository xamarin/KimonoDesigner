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
	[Register ("KimonoInspectorGroup")]
	partial class KimonoInspectorGroup
	{
		[Outlet]
		AppKit.NSButton BooleanCheckbox { get; set; }

		[Outlet]
		AppKit.NSPopUpButton Operation { get; set; }

		[Action ("BooleanChanged:")]
		partial void BooleanChanged (Foundation.NSObject sender);

		[Action ("OperationChanged:")]
		partial void OperationChanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (BooleanCheckbox != null) {
				BooleanCheckbox.Dispose ();
				BooleanCheckbox = null;
			}

			if (Operation != null) {
				Operation.Dispose ();
				Operation = null;
			}
		}
	}
}
