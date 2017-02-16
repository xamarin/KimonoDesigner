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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		KimonoMac.KimonoInspectorArrow ArrowInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorAttachedStyle AttachedStyleInspector { get; set; }

		[Outlet]
		AppKit.NSButton BackButton { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorPropertyBoolean BooleanPropertyInspector { get; set; }

		[Outlet]
		AppKit.NSButton BorderInspectorsButton { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorPaleteColor ColorPaletteInspector { get; set; }

		[Outlet]
		AppKit.NSButton ConnectionInspectorsButton { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorConnections ConnectionsInspector { get; set; }

		[Outlet]
		KimonoCore.Mac.KimonoDesignSurface DesignSurface { get; set; }

		[Outlet]
		AppKit.NSButton DetailsInspectorButton { get; set; }

		[Outlet]
		AppKit.NSScrollView DocumentScrollView { get; set; }

		[Outlet]
		AppKit.NSView DocumentView { get; set; }

		[Outlet]
		AppKit.NSLayoutConstraint DocumentViewHeight { get; set; }

		[Outlet]
		AppKit.NSLayoutConstraint DocumentViewWidth { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorFill FillInspector { get; set; }

		[Outlet]
		AppKit.NSButton FillInspectorsButton { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorFont FontInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorFrame FrameInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorGeneralInfo GeneralInfoInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorGradient GradientInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorGroup GroupInspector { get; set; }

		[Outlet]
		AppKit.NSScrollView InspectorScrollView { get; set; }

		[Outlet]
		AppKit.NSView InspectorView { get; set; }

		[Outlet]
		AppKit.NSPopUpButton LanguageSelector { get; set; }

		[Outlet]
		AppKit.NSPopUpButton LibrarySelector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorPropertyNumber NumberPropertyInspector { get; set; }

		[Outlet]
		AppKit.NSPopUpButton OSSelector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorPolygon PolygonInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorPortfolio PortfolioInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorProperty PropertyInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorPropertyRect RectPropertyInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorRoundRect RoundRectInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorSketch SketchInspector { get; set; }

		[Outlet]
		AppKit.NSTextField SketchPath { get; set; }

		[Outlet]
		KimonoMac.SourceListView SourceList { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorStar StarInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorStyle StyleInspector { get; set; }

		[Outlet]
		AppKit.TextKit.Formatter.SourceTextView TextEditor { get; set; }

		[Outlet]
		AppKit.NSTextField TextEditorMode { get; set; }

		[Outlet]
		AppKit.NSTextField TextEditorTitle { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorText TextInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorPropertyText TextPropertyInspector { get; set; }

		[Outlet]
		AppKit.NSButton ToolArrow { get; set; }

		[Outlet]
		AppKit.NSButtonCell ToolBezier { get; set; }

		[Outlet]
		AppKit.NSButtonCell ToolCursor { get; set; }

		[Outlet]
		AppKit.NSButton ToolLine { get; set; }

		[Outlet]
		AppKit.NSButton ToolOval { get; set; }

		[Outlet]
		AppKit.NSButton ToolPolygon { get; set; }

		[Outlet]
		AppKit.NSButton ToolRect { get; set; }

		[Outlet]
		AppKit.NSButton ToolRoundRect { get; set; }

		[Outlet]
		AppKit.NSButton ToolStar { get; set; }

		[Outlet]
		AppKit.NSButton ToolText { get; set; }

		[Outlet]
		AppKit.NSButton ToolTriangle { get; set; }

		[Outlet]
		AppKit.NSButton ToolVector { get; set; }

		[Action ("GoBackToSketch:")]
		partial void GoBackToSketch (Foundation.NSObject sender);

		[Action ("LanguageSelectionChanged:")]
		partial void LanguageSelectionChanged (Foundation.NSObject sender);

		[Action ("LibrarySelectionChanged:")]
		partial void LibrarySelectionChanged (Foundation.NSObject sender);

		[Action ("OSSelectionChanged:")]
		partial void OSSelectionChanged (Foundation.NSObject sender);

		[Action ("SwitchToBorderInspectors:")]
		partial void SwitchToBorderInspectors (Foundation.NSObject sender);

		[Action ("SwitchToConnectionInspectors:")]
		partial void SwitchToConnectionInspectors (Foundation.NSObject sender);

		[Action ("SwitchToDetailsInspectors:")]
		partial void SwitchToDetailsInspectors (Foundation.NSObject sender);

		[Action ("SwitchToFillInspectors:")]
		partial void SwitchToFillInspectors (Foundation.NSObject sender);

		[Action ("ToolArrowSelected:")]
		partial void ToolArrowSelected (Foundation.NSObject sender);

		[Action ("ToolBezierSelected:")]
		partial void ToolBezierSelected (Foundation.NSObject sender);

		[Action ("ToolCursorSelected:")]
		partial void ToolCursorSelected (Foundation.NSObject sender);

		[Action ("ToolLineSelected:")]
		partial void ToolLineSelected (Foundation.NSObject sender);

		[Action ("ToolOvalSelected:")]
		partial void ToolOvalSelected (Foundation.NSObject sender);

		[Action ("ToolPolygonSelected:")]
		partial void ToolPolygonSelected (Foundation.NSObject sender);

		[Action ("ToolRectSelected:")]
		partial void ToolRectSelected (Foundation.NSObject sender);

		[Action ("ToolRoundRectSelected:")]
		partial void ToolRoundRectSelected (Foundation.NSObject sender);

		[Action ("ToolStarSelected:")]
		partial void ToolStarSelected (Foundation.NSObject sender);

		[Action ("ToolTextSelected:")]
		partial void ToolTextSelected (Foundation.NSObject sender);

		[Action ("ToolTriangleSelected:")]
		partial void ToolTriangleSelected (Foundation.NSObject sender);

		[Action ("ToolVectorSelected:")]
		partial void ToolVectorSelected (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ConnectionsInspector != null) {
				ConnectionsInspector.Dispose ();
				ConnectionsInspector = null;
			}

			if (ArrowInspector != null) {
				ArrowInspector.Dispose ();
				ArrowInspector = null;
			}

			if (AttachedStyleInspector != null) {
				AttachedStyleInspector.Dispose ();
				AttachedStyleInspector = null;
			}

			if (BackButton != null) {
				BackButton.Dispose ();
				BackButton = null;
			}

			if (BooleanPropertyInspector != null) {
				BooleanPropertyInspector.Dispose ();
				BooleanPropertyInspector = null;
			}

			if (BorderInspectorsButton != null) {
				BorderInspectorsButton.Dispose ();
				BorderInspectorsButton = null;
			}

			if (ColorPaletteInspector != null) {
				ColorPaletteInspector.Dispose ();
				ColorPaletteInspector = null;
			}

			if (ConnectionInspectorsButton != null) {
				ConnectionInspectorsButton.Dispose ();
				ConnectionInspectorsButton = null;
			}

			if (DesignSurface != null) {
				DesignSurface.Dispose ();
				DesignSurface = null;
			}

			if (DetailsInspectorButton != null) {
				DetailsInspectorButton.Dispose ();
				DetailsInspectorButton = null;
			}

			if (DocumentScrollView != null) {
				DocumentScrollView.Dispose ();
				DocumentScrollView = null;
			}

			if (DocumentView != null) {
				DocumentView.Dispose ();
				DocumentView = null;
			}

			if (DocumentViewHeight != null) {
				DocumentViewHeight.Dispose ();
				DocumentViewHeight = null;
			}

			if (DocumentViewWidth != null) {
				DocumentViewWidth.Dispose ();
				DocumentViewWidth = null;
			}

			if (FillInspector != null) {
				FillInspector.Dispose ();
				FillInspector = null;
			}

			if (FillInspectorsButton != null) {
				FillInspectorsButton.Dispose ();
				FillInspectorsButton = null;
			}

			if (FontInspector != null) {
				FontInspector.Dispose ();
				FontInspector = null;
			}

			if (FrameInspector != null) {
				FrameInspector.Dispose ();
				FrameInspector = null;
			}

			if (GeneralInfoInspector != null) {
				GeneralInfoInspector.Dispose ();
				GeneralInfoInspector = null;
			}

			if (GradientInspector != null) {
				GradientInspector.Dispose ();
				GradientInspector = null;
			}

			if (GroupInspector != null) {
				GroupInspector.Dispose ();
				GroupInspector = null;
			}

			if (InspectorScrollView != null) {
				InspectorScrollView.Dispose ();
				InspectorScrollView = null;
			}

			if (InspectorView != null) {
				InspectorView.Dispose ();
				InspectorView = null;
			}

			if (LanguageSelector != null) {
				LanguageSelector.Dispose ();
				LanguageSelector = null;
			}

			if (LibrarySelector != null) {
				LibrarySelector.Dispose ();
				LibrarySelector = null;
			}

			if (NumberPropertyInspector != null) {
				NumberPropertyInspector.Dispose ();
				NumberPropertyInspector = null;
			}

			if (OSSelector != null) {
				OSSelector.Dispose ();
				OSSelector = null;
			}

			if (PolygonInspector != null) {
				PolygonInspector.Dispose ();
				PolygonInspector = null;
			}

			if (PortfolioInspector != null) {
				PortfolioInspector.Dispose ();
				PortfolioInspector = null;
			}

			if (PropertyInspector != null) {
				PropertyInspector.Dispose ();
				PropertyInspector = null;
			}

			if (RectPropertyInspector != null) {
				RectPropertyInspector.Dispose ();
				RectPropertyInspector = null;
			}

			if (RoundRectInspector != null) {
				RoundRectInspector.Dispose ();
				RoundRectInspector = null;
			}

			if (SketchInspector != null) {
				SketchInspector.Dispose ();
				SketchInspector = null;
			}

			if (SketchPath != null) {
				SketchPath.Dispose ();
				SketchPath = null;
			}

			if (SourceList != null) {
				SourceList.Dispose ();
				SourceList = null;
			}

			if (StarInspector != null) {
				StarInspector.Dispose ();
				StarInspector = null;
			}

			if (StyleInspector != null) {
				StyleInspector.Dispose ();
				StyleInspector = null;
			}

			if (TextEditor != null) {
				TextEditor.Dispose ();
				TextEditor = null;
			}

			if (TextEditorMode != null) {
				TextEditorMode.Dispose ();
				TextEditorMode = null;
			}

			if (TextEditorTitle != null) {
				TextEditorTitle.Dispose ();
				TextEditorTitle = null;
			}

			if (TextInspector != null) {
				TextInspector.Dispose ();
				TextInspector = null;
			}

			if (TextPropertyInspector != null) {
				TextPropertyInspector.Dispose ();
				TextPropertyInspector = null;
			}

			if (ToolArrow != null) {
				ToolArrow.Dispose ();
				ToolArrow = null;
			}

			if (ToolBezier != null) {
				ToolBezier.Dispose ();
				ToolBezier = null;
			}

			if (ToolCursor != null) {
				ToolCursor.Dispose ();
				ToolCursor = null;
			}

			if (ToolLine != null) {
				ToolLine.Dispose ();
				ToolLine = null;
			}

			if (ToolOval != null) {
				ToolOval.Dispose ();
				ToolOval = null;
			}

			if (ToolPolygon != null) {
				ToolPolygon.Dispose ();
				ToolPolygon = null;
			}

			if (ToolRect != null) {
				ToolRect.Dispose ();
				ToolRect = null;
			}

			if (ToolRoundRect != null) {
				ToolRoundRect.Dispose ();
				ToolRoundRect = null;
			}

			if (ToolStar != null) {
				ToolStar.Dispose ();
				ToolStar = null;
			}

			if (ToolText != null) {
				ToolText.Dispose ();
				ToolText = null;
			}

			if (ToolTriangle != null) {
				ToolTriangle.Dispose ();
				ToolTriangle = null;
			}

			if (ToolVector != null) {
				ToolVector.Dispose ();
				ToolVector = null;
			}
		}
	}
}
