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
	[Register ("KimonoInspectorPaleteColor")]
	partial class KimonoInspectorPaleteColor
	{
		[Outlet]
		AppKit.NSButton AdjustBrightnessCheckbox { get; set; }

		[Outlet]
		AppKit.NSButton AdjustHueCheckbox { get; set; }

		[Outlet]
		AppKit.NSButton AdjustOpacityCheckbox { get; set; }

		[Outlet]
		AppKit.NSButton AdjustSaturationCheckbox { get; set; }

		[Outlet]
		AppKit.NSPopUpButton BaseColorSelector { get; set; }

		[Outlet]
		AppKit.NSSlider BrightnessSlider { get; set; }

		[Outlet]
		AppKit.NSTextField BrightnessValue { get; set; }

		[Outlet]
		AppKit.NSColorWell Color { get; set; }

		[Outlet]
		AppKit.NSTextField ColorName { get; set; }

		[Outlet]
		AppKit.NSButton GoBackButton { get; set; }

		[Outlet]
		AppKit.NSSlider HueSlider { get; set; }

		[Outlet]
		AppKit.NSTextField HueValue { get; set; }

		[Outlet]
		AppKit.NSSlider OpacitySlider { get; set; }

		[Outlet]
		AppKit.NSTextField OpacityValue { get; set; }

		[Outlet]
		AppKit.NSSlider SaturationSlider { get; set; }

		[Outlet]
		AppKit.NSTextField SaturationValue { get; set; }

		[Action ("AdjustBrightnessChanged:")]
		partial void AdjustBrightnessChanged (Foundation.NSObject sender);

		[Action ("AdjustHueChanged:")]
		partial void AdjustHueChanged (Foundation.NSObject sender);

		[Action ("AdjustOpacityChanged:")]
		partial void AdjustOpacityChanged (Foundation.NSObject sender);

		[Action ("AdjustSaturationChanged:")]
		partial void AdjustSaturationChanged (Foundation.NSObject sender);

		[Action ("BaseColorChanged:")]
		partial void BaseColorChanged (Foundation.NSObject sender);

		[Action ("BrightnessChanged:")]
		partial void BrightnessChanged (Foundation.NSObject sender);

		[Action ("ColorChanged:")]
		partial void ColorChanged (Foundation.NSObject sender);

		[Action ("ColorNameChanged:")]
		partial void ColorNameChanged (Foundation.NSObject sender);

		[Action ("DeleteColor:")]
		partial void DeleteColor (Foundation.NSObject sender);

		[Action ("DuplicateColor:")]
		partial void DuplicateColor (Foundation.NSObject sender);

		[Action ("GoBack:")]
		partial void GoBack (Foundation.NSObject sender);

		[Action ("HueChanged:")]
		partial void HueChanged (Foundation.NSObject sender);

		[Action ("OpacityChanged:")]
		partial void OpacityChanged (Foundation.NSObject sender);

		[Action ("SaturationChanged:")]
		partial void SaturationChanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (GoBackButton != null) {
				GoBackButton.Dispose ();
				GoBackButton = null;
			}

			if (AdjustBrightnessCheckbox != null) {
				AdjustBrightnessCheckbox.Dispose ();
				AdjustBrightnessCheckbox = null;
			}

			if (AdjustHueCheckbox != null) {
				AdjustHueCheckbox.Dispose ();
				AdjustHueCheckbox = null;
			}

			if (AdjustOpacityCheckbox != null) {
				AdjustOpacityCheckbox.Dispose ();
				AdjustOpacityCheckbox = null;
			}

			if (AdjustSaturationCheckbox != null) {
				AdjustSaturationCheckbox.Dispose ();
				AdjustSaturationCheckbox = null;
			}

			if (BaseColorSelector != null) {
				BaseColorSelector.Dispose ();
				BaseColorSelector = null;
			}

			if (BrightnessSlider != null) {
				BrightnessSlider.Dispose ();
				BrightnessSlider = null;
			}

			if (BrightnessValue != null) {
				BrightnessValue.Dispose ();
				BrightnessValue = null;
			}

			if (Color != null) {
				Color.Dispose ();
				Color = null;
			}

			if (ColorName != null) {
				ColorName.Dispose ();
				ColorName = null;
			}

			if (HueSlider != null) {
				HueSlider.Dispose ();
				HueSlider = null;
			}

			if (HueValue != null) {
				HueValue.Dispose ();
				HueValue = null;
			}

			if (OpacitySlider != null) {
				OpacitySlider.Dispose ();
				OpacitySlider = null;
			}

			if (OpacityValue != null) {
				OpacityValue.Dispose ();
				OpacityValue = null;
			}

			if (SaturationSlider != null) {
				SaturationSlider.Dispose ();
				SaturationSlider = null;
			}

			if (SaturationValue != null) {
				SaturationValue.Dispose ();
				SaturationValue = null;
			}
		}
	}
}
