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
	[Register ("KimonoInspectorArrow")]
	partial class KimonoInspectorArrow
	{
		[Outlet]
		AppKit.NSButton HeadCheckbox { get; set; }

		[Outlet]
		AppKit.NSSlider InnerSlider { get; set; }

		[Outlet]
		AppKit.NSTextField InnerValue { get; set; }

		[Outlet]
		AppKit.NSSlider OuterSlider { get; set; }

		[Outlet]
		AppKit.NSTextField OuterValue { get; set; }

		[Outlet]
		AppKit.NSButton StreamlinedCheckbox { get; set; }

		[Outlet]
		AppKit.NSButton TailCheckbox { get; set; }

		[Action ("HeadChanged:")]
		partial void HeadChanged (Foundation.NSObject sender);

		[Action ("InnerChanged:")]
		partial void InnerChanged (Foundation.NSObject sender);

		[Action ("OuterChanged:")]
		partial void OuterChanged (Foundation.NSObject sender);

		[Action ("StreamlinedChanged:")]
		partial void StreamlinedChanged (Foundation.NSObject sender);

		[Action ("TailChanged:")]
		partial void TailChanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (InnerSlider != null) {
				InnerSlider.Dispose ();
				InnerSlider = null;
			}

			if (InnerValue != null) {
				InnerValue.Dispose ();
				InnerValue = null;
			}

			if (OuterSlider != null) {
				OuterSlider.Dispose ();
				OuterSlider = null;
			}

			if (OuterValue != null) {
				OuterValue.Dispose ();
				OuterValue = null;
			}

			if (StreamlinedCheckbox != null) {
				StreamlinedCheckbox.Dispose ();
				StreamlinedCheckbox = null;
			}

			if (HeadCheckbox != null) {
				HeadCheckbox.Dispose ();
				HeadCheckbox = null;
			}

			if (TailCheckbox != null) {
				TailCheckbox.Dispose ();
				TailCheckbox = null;
			}
		}
	}
}
