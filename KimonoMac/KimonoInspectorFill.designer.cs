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
	[Register ("KimonoInspectorFill")]
	partial class KimonoInspectorFill
	{
		[Outlet]
		AppKit.NSButton AddColorButton { get; set; }

		[Outlet]
		AppKit.NSButton AntialiaseCheckbox { get; set; }

		[Outlet]
		AppKit.NSPopUpButton BlendMode { get; set; }

		[Outlet]
		AppKit.NSButton BlurCheckbox { get; set; }

		[Outlet]
		AppKit.NSSlider DeviationSlider { get; set; }

		[Outlet]
		AppKit.NSTextField DeviationValue { get; set; }

		[Outlet]
		AppKit.NSButton FillCheckbox { get; set; }

		[Outlet]
		AppKit.NSColorWell FillColor { get; set; }

		[Outlet]
		AppKit.NSPopUpButton GradientDropdown { get; set; }

		[Outlet]
		AppKit.NSSlider HorizontalBlurSlider { get; set; }

		[Outlet]
		AppKit.NSTextField HorizontalBlurValue { get; set; }

		[Outlet]
		AppKit.NSSlider HorizontalShadowBlurSlider { get; set; }

		[Outlet]
		AppKit.NSTextField HorizontalShadowBlurValue { get; set; }

		[Outlet]
		AppKit.NSSlider HorizontalShadowOffsetSlider { get; set; }

		[Outlet]
		AppKit.NSTextField HorizontalShadowOffsetValue { get; set; }

		[Outlet]
		AppKit.NSButton JitterCheckbox { get; set; }

		[Outlet]
		AppKit.NSSlider LengthSlider { get; set; }

		[Outlet]
		AppKit.NSTextField LengthValue { get; set; }

		[Outlet]
		AppKit.NSPopUpButton LinkedColorSelector { get; set; }

		[Outlet]
		AppKit.NSPopUpButton LinkedShadowColor { get; set; }

		[Outlet]
		AppKit.NSSlider OpacitySlider { get; set; }

		[Outlet]
		AppKit.NSTextField OpacityValue { get; set; }

		[Outlet]
		AppKit.NSButton ShadowCheckbox { get; set; }

		[Outlet]
		AppKit.NSColorWell ShadowColor { get; set; }

		[Outlet]
		AppKit.NSSlider ShadowOpacitySlider { get; set; }

		[Outlet]
		AppKit.NSTextField ShadowOpacityValue { get; set; }

		[Outlet]
		AppKit.NSSlider VerticalBlurSlider { get; set; }

		[Outlet]
		AppKit.NSTextField VerticalBlurValue { get; set; }

		[Outlet]
		AppKit.NSSlider VerticalShadowBlurSlider { get; set; }

		[Outlet]
		AppKit.NSTextField VerticalShadowBlurValue { get; set; }

		[Outlet]
		AppKit.NSSlider VerticalShadowOffsetSlider { get; set; }

		[Outlet]
		AppKit.NSTextField VerticalShadowOffsetValue { get; set; }

		[Action ("AddColor:")]
		partial void AddColor (Foundation.NSObject sender);

		[Action ("AntialiaseChanged:")]
		partial void AntialiaseChanged (Foundation.NSObject sender);

		[Action ("BlendModeChanged:")]
		partial void BlendModeChanged (Foundation.NSObject sender);

		[Action ("BlurChanged:")]
		partial void BlurChanged (Foundation.NSObject sender);

		[Action ("DeviationChanged:")]
		partial void DeviationChanged (Foundation.NSObject sender);

		[Action ("FillChanged:")]
		partial void FillChanged (Foundation.NSObject sender);

		[Action ("FillColorChanged:")]
		partial void FillColorChanged (Foundation.NSObject sender);

		[Action ("GradientChanged:")]
		partial void GradientChanged (Foundation.NSObject sender);

		[Action ("HorizontalBlurChanged:")]
		partial void HorizontalBlurChanged (Foundation.NSObject sender);

		[Action ("HorizontalShadowBlurChanged:")]
		partial void HorizontalShadowBlurChanged (Foundation.NSObject sender);

		[Action ("HorizontalShadowOffsetChanged:")]
		partial void HorizontalShadowOffsetChanged (Foundation.NSObject sender);

		[Action ("JitterChanged:")]
		partial void JitterChanged (Foundation.NSObject sender);

		[Action ("LengthChanged:")]
		partial void LengthChanged (Foundation.NSObject sender);

		[Action ("LinkedColorChanged:")]
		partial void LinkedColorChanged (Foundation.NSObject sender);

		[Action ("LinkedShadowColorChanged:")]
		partial void LinkedShadowColorChanged (Foundation.NSObject sender);

		[Action ("OpacityChanged:")]
		partial void OpacityChanged (Foundation.NSObject sender);

		[Action ("ShadowChanged:")]
		partial void ShadowChanged (Foundation.NSObject sender);

		[Action ("ShadowColorChanged:")]
		partial void ShadowColorChanged (Foundation.NSObject sender);

		[Action ("ShadowOpacityChanged:")]
		partial void ShadowOpacityChanged (Foundation.NSObject sender);

		[Action ("VerticalBlurChanged:")]
		partial void VerticalBlurChanged (Foundation.NSObject sender);

		[Action ("VerticalShadowBlurChanged:")]
		partial void VerticalShadowBlurChanged (Foundation.NSObject sender);

		[Action ("VerticalShadowOffsetChanged:")]
		partial void VerticalShadowOffsetChanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (AddColorButton != null) {
				AddColorButton.Dispose ();
				AddColorButton = null;
			}

			if (AntialiaseCheckbox != null) {
				AntialiaseCheckbox.Dispose ();
				AntialiaseCheckbox = null;
			}

			if (BlendMode != null) {
				BlendMode.Dispose ();
				BlendMode = null;
			}

			if (BlurCheckbox != null) {
				BlurCheckbox.Dispose ();
				BlurCheckbox = null;
			}

			if (DeviationSlider != null) {
				DeviationSlider.Dispose ();
				DeviationSlider = null;
			}

			if (DeviationValue != null) {
				DeviationValue.Dispose ();
				DeviationValue = null;
			}

			if (FillCheckbox != null) {
				FillCheckbox.Dispose ();
				FillCheckbox = null;
			}

			if (FillColor != null) {
				FillColor.Dispose ();
				FillColor = null;
			}

			if (GradientDropdown != null) {
				GradientDropdown.Dispose ();
				GradientDropdown = null;
			}

			if (HorizontalBlurSlider != null) {
				HorizontalBlurSlider.Dispose ();
				HorizontalBlurSlider = null;
			}

			if (HorizontalBlurValue != null) {
				HorizontalBlurValue.Dispose ();
				HorizontalBlurValue = null;
			}

			if (JitterCheckbox != null) {
				JitterCheckbox.Dispose ();
				JitterCheckbox = null;
			}

			if (LengthSlider != null) {
				LengthSlider.Dispose ();
				LengthSlider = null;
			}

			if (LengthValue != null) {
				LengthValue.Dispose ();
				LengthValue = null;
			}

			if (LinkedColorSelector != null) {
				LinkedColorSelector.Dispose ();
				LinkedColorSelector = null;
			}

			if (OpacitySlider != null) {
				OpacitySlider.Dispose ();
				OpacitySlider = null;
			}

			if (OpacityValue != null) {
				OpacityValue.Dispose ();
				OpacityValue = null;
			}

			if (VerticalBlurSlider != null) {
				VerticalBlurSlider.Dispose ();
				VerticalBlurSlider = null;
			}

			if (VerticalBlurValue != null) {
				VerticalBlurValue.Dispose ();
				VerticalBlurValue = null;
			}

			if (ShadowCheckbox != null) {
				ShadowCheckbox.Dispose ();
				ShadowCheckbox = null;
			}

			if (ShadowColor != null) {
				ShadowColor.Dispose ();
				ShadowColor = null;
			}

			if (LinkedShadowColor != null) {
				LinkedShadowColor.Dispose ();
				LinkedShadowColor = null;
			}

			if (ShadowOpacitySlider != null) {
				ShadowOpacitySlider.Dispose ();
				ShadowOpacitySlider = null;
			}

			if (ShadowOpacityValue != null) {
				ShadowOpacityValue.Dispose ();
				ShadowOpacityValue = null;
			}

			if (HorizontalShadowOffsetSlider != null) {
				HorizontalShadowOffsetSlider.Dispose ();
				HorizontalShadowOffsetSlider = null;
			}

			if (HorizontalShadowOffsetValue != null) {
				HorizontalShadowOffsetValue.Dispose ();
				HorizontalShadowOffsetValue = null;
			}

			if (VerticalShadowOffsetSlider != null) {
				VerticalShadowOffsetSlider.Dispose ();
				VerticalShadowOffsetSlider = null;
			}

			if (VerticalShadowOffsetValue != null) {
				VerticalShadowOffsetValue.Dispose ();
				VerticalShadowOffsetValue = null;
			}

			if (HorizontalShadowBlurSlider != null) {
				HorizontalShadowBlurSlider.Dispose ();
				HorizontalShadowBlurSlider = null;
			}

			if (HorizontalShadowBlurValue != null) {
				HorizontalShadowBlurValue.Dispose ();
				HorizontalShadowBlurValue = null;
			}

			if (VerticalShadowBlurSlider != null) {
				VerticalShadowBlurSlider.Dispose ();
				VerticalShadowBlurSlider = null;
			}

			if (VerticalShadowBlurValue != null) {
				VerticalShadowBlurValue.Dispose ();
				VerticalShadowBlurValue = null;
			}
		}
	}
}
