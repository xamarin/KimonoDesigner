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
	[Register ("KimonoInspectorSketch")]
	partial class KimonoInspectorSketch
	{
		[Outlet]
		AppKit.NSColorWell CanvasColor { get; set; }

		[Outlet]
		AppKit.NSButton CanvasColorCheckbox { get; set; }

		[Outlet]
		AppKit.NSSlider OpacitySlider { get; set; }

		[Outlet]
		AppKit.NSTextField OpacityValue { get; set; }

		[Outlet]
		AppKit.NSTextField SketchHeight { get; set; }

		[Outlet]
		AppKit.NSTextField SketchName { get; set; }

		[Outlet]
		AppKit.NSTextField SketchWidth { get; set; }

		[Action ("CanvasColorChanged:")]
		partial void CanvasColorChanged (Foundation.NSObject sender);

		[Action ("DeleteSketch:")]
		partial void DeleteSketch (Foundation.NSObject sender);

		[Action ("DuplicateSketch:")]
		partial void DuplicateSketch (Foundation.NSObject sender);

		[Action ("HasCanvasColorChanged:")]
		partial void HasCanvasColorChanged (Foundation.NSObject sender);

		[Action ("OpacityChanged:")]
		partial void OpacityChanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (SketchName != null) {
				SketchName.Dispose ();
				SketchName = null;
			}

			if (SketchWidth != null) {
				SketchWidth.Dispose ();
				SketchWidth = null;
			}

			if (SketchHeight != null) {
				SketchHeight.Dispose ();
				SketchHeight = null;
			}

			if (CanvasColorCheckbox != null) {
				CanvasColorCheckbox.Dispose ();
				CanvasColorCheckbox = null;
			}

			if (CanvasColor != null) {
				CanvasColor.Dispose ();
				CanvasColor = null;
			}

			if (OpacitySlider != null) {
				OpacitySlider.Dispose ();
				OpacitySlider = null;
			}

			if (OpacityValue != null) {
				OpacityValue.Dispose ();
				OpacityValue = null;
			}
		}
	}
}
