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
	[Register ("KimonoInspectorRoundRect")]
	partial class KimonoInspectorRoundRect
	{
		[Outlet]
		AppKit.NSSlider RadiusSlider { get; set; }

		[Outlet]
		AppKit.NSTextField RadiusValue { get; set; }

		[Action ("RadiusChanged:")]
		partial void RadiusChanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (RadiusSlider != null) {
				RadiusSlider.Dispose ();
				RadiusSlider = null;
			}

			if (RadiusValue != null) {
				RadiusValue.Dispose ();
				RadiusValue = null;
			}
		}
	}
}
