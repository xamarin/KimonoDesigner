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
	[Register ("KimonoInspectorScriptDebugger")]
	partial class KimonoInspectorScriptDebugger
	{
		[Outlet]
		KimonoMac.KimonoTextView ErrorMessage { get; set; }

		[Outlet]
		AppKit.NSButton EvalButton { get; set; }

		[Action ("EvalScript:")]
		partial void EvalScript (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (EvalButton != null) {
				EvalButton.Dispose ();
				EvalButton = null;
			}

			if (ErrorMessage != null) {
				ErrorMessage.Dispose ();
				ErrorMessage = null;
			}
		}
	}
}
