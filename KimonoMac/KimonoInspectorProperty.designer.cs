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
	[Register ("KimonoInspectorProperty")]
	partial class KimonoInspectorProperty
	{
		[Outlet]
		AppKit.NSTextField PropertyName { get; set; }

		[Outlet]
		AppKit.NSTextField PropertyType { get; set; }

		[Outlet]
		AppKit.NSPopUpButton PropertyUsage { get; set; }

		[Action ("DeleteProperty:")]
		partial void DeleteProperty (Foundation.NSObject sender);

		[Action ("DuplicateProperty:")]
		partial void DuplicateProperty (Foundation.NSObject sender);

		[Action ("UsageChanged:")]
		partial void UsageChanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (PropertyType != null) {
				PropertyType.Dispose ();
				PropertyType = null;
			}

			if (PropertyName != null) {
				PropertyName.Dispose ();
				PropertyName = null;
			}

			if (PropertyUsage != null) {
				PropertyUsage.Dispose ();
				PropertyUsage = null;
			}
		}
	}
}
