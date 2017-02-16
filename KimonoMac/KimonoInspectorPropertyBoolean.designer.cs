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
	[Register ("KimonoInspectorPropertyBoolean")]
	partial class KimonoInspectorPropertyBoolean
	{
		[Outlet]
		AppKit.NSPopUpButton ValueDropdown { get; set; }

		[Action ("ValueChanged:")]
		partial void ValueChanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ValueDropdown != null) {
				ValueDropdown.Dispose ();
				ValueDropdown = null;
			}
		}
	}
}
