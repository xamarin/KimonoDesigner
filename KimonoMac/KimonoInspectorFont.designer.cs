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
	[Register ("KimonoInspectorFont")]
	partial class KimonoInspectorFont
	{
		[Outlet]
		AppKit.NSSegmentedControl Alignment { get; set; }

		[Outlet]
		AppKit.NSSlider ScaleSlider { get; set; }

		[Outlet]
		AppKit.NSTextField ScaleValue { get; set; }

		[Outlet]
		AppKit.NSComboBox Size { get; set; }

		[Outlet]
		AppKit.NSSlider SkewSlider { get; set; }

		[Outlet]
		AppKit.NSTextField SkewValue { get; set; }

		[Outlet]
		AppKit.NSButton StrikeThruCheckbox { get; set; }

		[Outlet]
		AppKit.NSPopUpButton TypefaceDropdown { get; set; }

		[Outlet]
		AppKit.NSButton UnderlineCheckbox { get; set; }

		[Outlet]
		AppKit.NSButton VerticalCheckbox { get; set; }

		[Outlet]
		AppKit.NSPopUpButton WeightDropdown { get; set; }

		[Action ("AlignmentChanged:")]
		partial void AlignmentChanged (Foundation.NSObject sender);

		[Action ("ScaleChanged:")]
		partial void ScaleChanged (Foundation.NSObject sender);

		[Action ("SizeChanged:")]
		partial void SizeChanged (Foundation.NSObject sender);

		[Action ("SkewChanged:")]
		partial void SkewChanged (Foundation.NSObject sender);

		[Action ("StrikeThruChanged:")]
		partial void StrikeThruChanged (Foundation.NSObject sender);

		[Action ("TypefaceChanged:")]
		partial void TypefaceChanged (Foundation.NSObject sender);

		[Action ("UnderlineChanged:")]
		partial void UnderlineChanged (Foundation.NSObject sender);

		[Action ("VerticalChanged:")]
		partial void VerticalChanged (Foundation.NSObject sender);

		[Action ("WeightChanged:")]
		partial void WeightChanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (TypefaceDropdown != null) {
				TypefaceDropdown.Dispose ();
				TypefaceDropdown = null;
			}

			if (WeightDropdown != null) {
				WeightDropdown.Dispose ();
				WeightDropdown = null;
			}

			if (Size != null) {
				Size.Dispose ();
				Size = null;
			}

			if (Alignment != null) {
				Alignment.Dispose ();
				Alignment = null;
			}

			if (StrikeThruCheckbox != null) {
				StrikeThruCheckbox.Dispose ();
				StrikeThruCheckbox = null;
			}

			if (UnderlineCheckbox != null) {
				UnderlineCheckbox.Dispose ();
				UnderlineCheckbox = null;
			}

			if (VerticalCheckbox != null) {
				VerticalCheckbox.Dispose ();
				VerticalCheckbox = null;
			}

			if (ScaleSlider != null) {
				ScaleSlider.Dispose ();
				ScaleSlider = null;
			}

			if (ScaleValue != null) {
				ScaleValue.Dispose ();
				ScaleValue = null;
			}

			if (SkewSlider != null) {
				SkewSlider.Dispose ();
				SkewSlider = null;
			}

			if (SkewValue != null) {
				SkewValue.Dispose ();
				SkewValue = null;
			}
		}
	}
}
