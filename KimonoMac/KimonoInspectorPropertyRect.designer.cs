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
	[Register ("KimonoInspectorPropertyRect")]
	partial class KimonoInspectorPropertyRect
	{
		[Outlet]
		AppKit.NSTextField HeightField { get; set; }

		[Outlet]
		AppKit.NSTextField WidthField { get; set; }

		[Outlet]
		AppKit.NSTextField XField { get; set; }

		[Outlet]
		AppKit.NSTextField YField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (XField != null) {
				XField.Dispose ();
				XField = null;
			}

			if (YField != null) {
				YField.Dispose ();
				YField = null;
			}

			if (WidthField != null) {
				WidthField.Dispose ();
				WidthField = null;
			}

			if (HeightField != null) {
				HeightField.Dispose ();
				HeightField = null;
			}
		}
	}
}
