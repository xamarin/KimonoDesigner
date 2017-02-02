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
	[Register ("KimonoInspectorStar")]
	partial class KimonoInspectorStar
	{
		[Outlet]
		AppKit.NSSlider DepthSlider { get; set; }

		[Outlet]
		AppKit.NSTextField DepthValue { get; set; }

		[Outlet]
		AppKit.NSSlider PointsSlider { get; set; }

		[Outlet]
		AppKit.NSTextField PointsValue { get; set; }

		[Outlet]
		AppKit.NSSlider SkipSlider { get; set; }

		[Outlet]
		AppKit.NSTextField SkipValue { get; set; }

		[Action ("DepthChanged:")]
		partial void DepthChanged (Foundation.NSObject sender);

		[Action ("PointsChanged:")]
		partial void PointsChanged (Foundation.NSObject sender);

		[Action ("SkipChanged:")]
		partial void SkipChanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (PointsSlider != null) {
				PointsSlider.Dispose ();
				PointsSlider = null;
			}

			if (PointsValue != null) {
				PointsValue.Dispose ();
				PointsValue = null;
			}

			if (SkipSlider != null) {
				SkipSlider.Dispose ();
				SkipSlider = null;
			}

			if (SkipValue != null) {
				SkipValue.Dispose ();
				SkipValue = null;
			}

			if (DepthSlider != null) {
				DepthSlider.Dispose ();
				DepthSlider = null;
			}

			if (DepthValue != null) {
				DepthValue.Dispose ();
				DepthValue = null;
			}
		}
	}
}
