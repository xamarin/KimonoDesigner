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
	[Register ("KimonoInspectorGradient")]
	partial class KimonoInspectorGradient
	{
		[Outlet]
		AppKit.NSButton AddColorButton { get; set; }

		[Outlet]
		AppKit.NSButton AddPointButton { get; set; }

		[Outlet]
		AppKit.NSButton BackButton { get; set; }

		[Outlet]
		AppKit.NSButton DeleteButton { get; set; }

		[Outlet]
		AppKit.NSButton DeletePointButton { get; set; }

		[Outlet]
		KimonoCore.Mac.KimonoGradientDesignBar DesignBar { get; set; }

		[Outlet]
		KimonoCore.Mac.KimonoGradientDesignPreview DesignPreview { get; set; }

		[Outlet]
		AppKit.NSButton DuplicateButton { get; set; }

		[Outlet]
		AppKit.NSButton DuplicatePointButton { get; set; }

		[Outlet]
		AppKit.NSTextField GradientName { get; set; }

		[Outlet]
		AppKit.NSPopUpButton LinkedColorDropdown { get; set; }

		[Outlet]
		AppKit.NSSlider OpacitySlider { get; set; }

		[Outlet]
		AppKit.NSTextField OpacityValue { get; set; }

		[Outlet]
		AppKit.NSColorWell PointColor { get; set; }

		[Outlet]
		AppKit.NSSlider RadiusSlider { get; set; }

		[Outlet]
		AppKit.NSTextField RadiusValue { get; set; }

		[Outlet]
		AppKit.NSTextField SelectedColorTitle { get; set; }

		[Outlet]
		AppKit.NSPopUpButton TileDropdown { get; set; }

		[Outlet]
		AppKit.NSPopUpButton TypeDropdown { get; set; }

		[Action ("AddColor:")]
		partial void AddColor (Foundation.NSObject sender);

		[Action ("AddPoint:")]
		partial void AddPoint (Foundation.NSObject sender);

		[Action ("DeleteGradient:")]
		partial void DeleteGradient (Foundation.NSObject sender);

		[Action ("DeletePoint:")]
		partial void DeletePoint (Foundation.NSObject sender);

		[Action ("DuplicateGradient:")]
		partial void DuplicateGradient (Foundation.NSObject sender);

		[Action ("DuplicatePoint:")]
		partial void DuplicatePoint (Foundation.NSObject sender);

		[Action ("GoBack:")]
		partial void GoBack (Foundation.NSObject sender);

		[Action ("LinkedColorChanged:")]
		partial void LinkedColorChanged (Foundation.NSObject sender);

		[Action ("OpacityChanged:")]
		partial void OpacityChanged (Foundation.NSObject sender);

		[Action ("PointColorChanged:")]
		partial void PointColorChanged (Foundation.NSObject sender);

		[Action ("RadiusChanged:")]
		partial void RadiusChanged (Foundation.NSObject sender);

		[Action ("TileChanged:")]
		partial void TileChanged (Foundation.NSObject sender);

		[Action ("TypeChanged:")]
		partial void TypeChanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (DesignPreview != null) {
				DesignPreview.Dispose ();
				DesignPreview = null;
			}

			if (AddColorButton != null) {
				AddColorButton.Dispose ();
				AddColorButton = null;
			}

			if (AddPointButton != null) {
				AddPointButton.Dispose ();
				AddPointButton = null;
			}

			if (BackButton != null) {
				BackButton.Dispose ();
				BackButton = null;
			}

			if (DeleteButton != null) {
				DeleteButton.Dispose ();
				DeleteButton = null;
			}

			if (DeletePointButton != null) {
				DeletePointButton.Dispose ();
				DeletePointButton = null;
			}

			if (DesignBar != null) {
				DesignBar.Dispose ();
				DesignBar = null;
			}

			if (DuplicateButton != null) {
				DuplicateButton.Dispose ();
				DuplicateButton = null;
			}

			if (DuplicatePointButton != null) {
				DuplicatePointButton.Dispose ();
				DuplicatePointButton = null;
			}

			if (GradientName != null) {
				GradientName.Dispose ();
				GradientName = null;
			}

			if (LinkedColorDropdown != null) {
				LinkedColorDropdown.Dispose ();
				LinkedColorDropdown = null;
			}

			if (OpacitySlider != null) {
				OpacitySlider.Dispose ();
				OpacitySlider = null;
			}

			if (OpacityValue != null) {
				OpacityValue.Dispose ();
				OpacityValue = null;
			}

			if (PointColor != null) {
				PointColor.Dispose ();
				PointColor = null;
			}

			if (SelectedColorTitle != null) {
				SelectedColorTitle.Dispose ();
				SelectedColorTitle = null;
			}

			if (TileDropdown != null) {
				TileDropdown.Dispose ();
				TileDropdown = null;
			}

			if (TypeDropdown != null) {
				TypeDropdown.Dispose ();
				TypeDropdown = null;
			}

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
