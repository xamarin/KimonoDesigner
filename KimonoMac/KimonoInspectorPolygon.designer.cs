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
	[Register ("KimonoInspectorPolygon")]
	partial class KimonoInspectorPolygon
	{
		[Outlet]
		AppKit.NSSlider SidesSlider { get; set; }

		[Outlet]
		AppKit.NSTextField SidesValue { get; set; }

		[Action ("SidesChanged:")]
		partial void SidesChanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (SidesSlider != null) {
				SidesSlider.Dispose ();
				SidesSlider = null;
			}

			if (SidesValue != null) {
				SidesValue.Dispose ();
				SidesValue = null;
			}
		}
	}
}
