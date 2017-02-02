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
	[Register ("KimonoInspectorGeneralInfo")]
	partial class KimonoInspectorGeneralInfo
	{
		[Outlet]
		AppKit.NSButton EditButton { get; set; }

		[Outlet]
		AppKit.NSButton GroupUngroupButton { get; set; }

		[Outlet]
		AppKit.NSSlider RotationSlider { get; set; }

		[Outlet]
		AppKit.NSTextField RotationValue { get; set; }

		[Outlet]
		AppKit.NSTextField ShapeHeight { get; set; }

		[Outlet]
		AppKit.NSTextField ShapeName { get; set; }

		[Outlet]
		AppKit.NSTextField ShapeType { get; set; }

		[Outlet]
		AppKit.NSTextField ShapeWidth { get; set; }

		[Outlet]
		AppKit.NSTextField ShapeX { get; set; }

		[Outlet]
		AppKit.NSTextField ShapeY { get; set; }

		[Outlet]
		AppKit.NSButton VisibleButton { get; set; }

		[Action ("DeleteShape:")]
		partial void DeleteShape (Foundation.NSObject sender);

		[Action ("DuplicateShape:")]
		partial void DuplicateShape (Foundation.NSObject sender);

		[Action ("EditOrFinalizeShape:")]
		partial void EditOrFinalizeShape (Foundation.NSObject sender);

		[Action ("GroupUngroupShapes:")]
		partial void GroupUngroupShapes (Foundation.NSObject sender);

		[Action ("RotationChanged:")]
		partial void RotationChanged (Foundation.NSObject sender);

		[Action ("VisibilityChanged:")]
		partial void VisibilityChanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (GroupUngroupButton != null) {
				GroupUngroupButton.Dispose ();
				GroupUngroupButton = null;
			}

			if (RotationSlider != null) {
				RotationSlider.Dispose ();
				RotationSlider = null;
			}

			if (RotationValue != null) {
				RotationValue.Dispose ();
				RotationValue = null;
			}

			if (ShapeHeight != null) {
				ShapeHeight.Dispose ();
				ShapeHeight = null;
			}

			if (ShapeName != null) {
				ShapeName.Dispose ();
				ShapeName = null;
			}

			if (ShapeType != null) {
				ShapeType.Dispose ();
				ShapeType = null;
			}

			if (ShapeWidth != null) {
				ShapeWidth.Dispose ();
				ShapeWidth = null;
			}

			if (ShapeX != null) {
				ShapeX.Dispose ();
				ShapeX = null;
			}

			if (ShapeY != null) {
				ShapeY.Dispose ();
				ShapeY = null;
			}

			if (VisibleButton != null) {
				VisibleButton.Dispose ();
				VisibleButton = null;
			}

			if (EditButton != null) {
				EditButton.Dispose ();
				EditButton = null;
			}
		}
	}
}
